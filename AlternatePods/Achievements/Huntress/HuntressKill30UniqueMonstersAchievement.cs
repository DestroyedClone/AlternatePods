using RoR2;
using RoR2.Achievements;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlternatePods.Achievements.Huntress
{
    [RegisterAchievement("PodMod_HuntressKill30UniqueMonsters", "PodMod.Huntress.Checklist", null, typeof(HuntressChecklistServerAchievement))]
    public class HuntressKill30UniqueMonstersAchievement : BaseModdedAchievement
    {
        public override string NameToken => "PODMOD_HUNTRESSKILL30UNIQUEMONSTERS";

        public override string Identifier => "PodMod.Huntress.Checklist";

        public override BodyIndex LookUpRequiredBodyIndex()
        {
            return BodyCatalog.FindBodyIndex("HuntressBody");
        }

        public override void OnBodyRequirementMet()
        {
            base.OnBodyRequirementMet();
            SetServerTracked(true);
        }

        public override void OnBodyRequirementBroken()
        {
            SetServerTracked(false);
            base.OnBodyRequirementBroken();
        }

        private class HuntressChecklistServerAchievement : BaseServerAchievement
        {
            public List<BodyIndex> UniqueEnemiesKilled;

            public override void OnInstall()
            {
                base.OnInstall();
                UniqueEnemiesKilled = new List<BodyIndex>();
                GlobalEventManager.onCharacterDeathGlobal += GlobalEventManager_onCharacterDeathGlobal;
            }

            public override void OnUninstall()
            {
                GlobalEventManager.onCharacterDeathGlobal -= GlobalEventManager_onCharacterDeathGlobal;
                base.OnUninstall();
            }

            private void GlobalEventManager_onCharacterDeathGlobal(DamageReport damageReport)
            {
                if (damageReport.attackerMaster == networkUser.master)
                {
                    if (UniqueEnemiesKilled.Contains(damageReport.victimBodyIndex))
                    {
                        return;
                    } else
                    {
                        UniqueEnemiesKilled.Add(damageReport.victimBodyIndex);
                    }
                }
                if (UniqueEnemiesKilled.Count >= 30)
                {
                    Grant();
                }
            }
        }
    }
}
