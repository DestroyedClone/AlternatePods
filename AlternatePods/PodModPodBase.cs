using BepInEx.Configuration;
using R2API;
using RoR2;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using RoR2.Skills;
using UnityEngine.AddressableAssets;
using System.Xml.Linq;
using AlternatePods.Achievements;

namespace AlternatePods
{
    public abstract class PodModPodBase
    {
        public abstract string PodName { get; }
        public abstract string PodToken { get; }
        public abstract Texture2D Icon { get; }
        public static GameObject PodPrefab { get; set; }
        public virtual UnlockableDef UnlockableDef { get; set; }

        public virtual BaseModdedAchievement Achievement { get; }
        
        public virtual GameObject CreatePodPrefab()
        {
            return Assets.genericPodPrefab;
        }

        public virtual GameObject GetPodPrefab()
        {
            if (!PodPrefab)
                PodPrefab = CreatePodPrefab();
            return PodPrefab;
        }

        public GameObject CreatePodRecolor(string podName, Material material)
        {
            var podPrefabInstance = PrefabAPI.InstantiateClone(Assets.genericPodPrefab, podName, true);
            //var childLoc = pod.transform.Find("Base/mdlEscapePod").GetComponent<ChildLocator>();

            var podObj = podPrefabInstance.transform.Find("Base/mdlEscapePod/EscapePodArmature/Base/EscapePodMesh");
            var meshFilter = podObj.GetComponent<MeshFilter>();
            var meshRenderer = podObj.GetComponent<MeshRenderer>();

            //var commandoMat = Addressables.LoadAssetAsync<Material>("RoR2/Base/Commando/matCommandoDualies.mat").WaitForCompletion();
            //meshRenderer.SetMaterial(material);
            meshRenderer.SetMaterialArray(new Material[]{material});
            return podPrefabInstance;
        }

        public GameObject CreatePodRecolor (string podName, string addressableKey)
        {
            return CreatePodRecolor(podName, Addressables.LoadAssetAsync<Material>(addressableKey).WaitForCompletion());
        }

        //credit: prod https://discordapp.com/channels/562704639141740588/562704639569428506/1076911381149925396
        public UnlockableDef CreateUnlockableDef(string identifier, string token)
        {
            UnlockableDef unlockableDef = ScriptableObject.CreateInstance<UnlockableDef>();
            unlockableDef.cachedName = identifier;
            unlockableDef.nameToken = token;
            ContentAddition.AddUnlockableDef(unlockableDef);
            return unlockableDef;
        }

        public UnlockableDef CreateUnlockableDef(BaseModdedAchievement baseModdedAchievement)
        {
            return CreateUnlockableDef(baseModdedAchievement.Identifier, baseModdedAchievement.NameToken);
        }
    }
}