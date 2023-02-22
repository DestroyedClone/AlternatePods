using AlternatePods.SHARED;
using R2API;
using RoR2;
using RoR2.Skills;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace AlternatePods
{
    public abstract class PodModCharBase
    {
        public abstract GameObject BodyPrefab { get; }
        public virtual GenericSkill PodSlot { get; private set; }
        public virtual List<PodModPodBase> PodBases { get; set; } = new List<PodModPodBase>();
        public virtual string ModGUID { get; set; } = "";
        public virtual bool IsMonster { get; set; } = false;

        public virtual void Init()
        {
            if (!ShouldLoadCharacter())
            {
                return;
            }
            SetupPodSlot();
            AddSharedPodsToChar();
            AddPodsToPodChar();
            RegisterPods();
        }

        public bool ShouldLoadCharacter()
        {
            bool shouldLoad = true;
            if (ModGUID != null && ModGUID.Length > 0)
            {
                // have it point towards ModCompat.bools?
                shouldLoad &= BepInEx.Bootstrap.Chainloader.PluginInfos.ContainsKey(ModGUID);
            }
            if (IsMonster)
            {
                shouldLoad &= AlternatePodsPlugin.cfgAddMonsterPods.Value;
            }
            return shouldLoad;
        }

        public void AddSharedPodsToChar()
        {
            PodBases.Add(new PaintJob());
            PodBases.Add(new SurvivorPod());
            PodBases.Add(new RoboPod());
            PodBases.Add(new NoPod());
        }

        public virtual void AddPodsToPodChar()
        {
            if (PodBases.Count == 0)
                AlternatePodsPlugin._logger.LogWarning($"AddPodsToPodChar: {BodyPrefab.name} has a PodModChar, but no pods are added?");
            return;
        }

        public void RegisterPods()
        {
            foreach (var pod in PodBases)
            {
                string skillDefName = $"PodMod_{BodyPrefab.name}+{pod.PodName}";
                var skillDef = CreateSkillDef(skillDefName, pod.PodToken + "_NAME", pod.PodToken + "_DESC");
                if (pod.Achievement != null && pod.UnlockableDef == null)
                {
                    pod.UnlockableDef = pod.CreateUnlockableDef(pod.Achievement);
                }
                AddSkillDef(PodSlot.skillFamily, skillDef, pod.GetPodPrefab(), pod.UnlockableDef);
            }
        }

        public virtual void SetupPodSlot()
        {
            PodSlot = BodyPrefab.AddComponent<GenericSkill>();

            PodSlot._skillFamily = ScriptableObject.CreateInstance<SkillFamily>();
            //podSlot.skillName
            (PodSlot.skillFamily as ScriptableObject).name = "PodModSkillFamily";
            //ContentAddition.AddSkillFamily(passiveSlot.skillFamily);
            R2API.ContentAddition.AddSkillFamily(PodSlot.skillFamily);
            PodSlot.skillFamily.variants = new SkillFamily.Variant[1];
            PodSlot.skillFamily.variants[0] = new SkillFamily.Variant
            {
                skillDef = Assets.defaultSkillDef,
                unlockableDef = null,
                viewableNode = new ViewablesCatalog.Node(Assets.defaultSkillDef.skillName, false, null)
            };
            BodyPrefab.AddComponent<AlternatePodsPlugin.PodModGenericSkillPointer>().podmodGenericSkill = PodSlot;
        }

        public void AddSkillDef(SkillFamily skillFamily, SkillDef skillDef, GameObject podPrefab, UnlockableDef unlockableDef)
        {
            if (!AlternatePodsPlugin.cfgEnableAchievements.Value) unlockableDef = null;
            if (AlternatePodsPlugin.podName_to_podPrefab.ContainsKey(skillDef.skillName))
            {
                AlternatePodsPlugin._logger.LogError($"Duplicate skillName '{skillDef.skillName}' in '{BodyPrefab.name}'");
                UnityEngine.Object.Destroy(skillDef);
                return;
            }
            Array.Resize(ref skillFamily.variants, skillFamily.variants.Length + 1);
            skillFamily.variants[skillFamily.variants.Length - 1] = new SkillFamily.Variant
            {
                skillDef = skillDef,
                unlockableDef = unlockableDef,
                viewableNode = new ViewablesCatalog.Node(skillDef.skillName, false, null)
            };
            AlternatePodsPlugin.podName_to_podPrefab.Add(
                skillDef.skillName,
                podPrefab
            );
        }

        public static SkillDef CreateSkillDef(string skillName, string skillNameToken = null, string skillDescriptionToken = null)
        {
            var mySkillDef = ScriptableObject.CreateInstance<SkillDef>();
            //mySkillDef.activationState = null;
            //mySkillDef.icon = SurvivorSkillLocator.special.skillDef.icon;
            mySkillDef.skillName = skillName;
            mySkillDef.skillNameToken = skillNameToken ?? skillName + "_NAME";
            mySkillDef.skillDescriptionToken = skillDescriptionToken ?? skillName + "_DESC";
            (mySkillDef as ScriptableObject).name = skillName;
            mySkillDef.keywordTokens = new string[] { };
            //ContentAddition.AddSkillDef(mySkillDef);
            R2API.ContentAddition.AddSkillDef(mySkillDef);
            return mySkillDef;
        }
    }
}