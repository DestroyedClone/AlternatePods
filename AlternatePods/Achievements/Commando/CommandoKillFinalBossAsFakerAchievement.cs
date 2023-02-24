using RoR2.Achievements;
using RoR2;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlternatePods.Achievements.Commando
{
    [RegisterAchievement("PodMod_CommandoKillFinalBossAsFaker", "PodMod.Commando.Faker", null, typeof(CommandoFakerServerAchievement))]
    public class CommandoKillFinalBossAsFakerAchievement : BaseModdedAchievement
    {
        public override string NameToken => "PODMOD_COMMANDOKILLFINALBOSSASFAKER";

        public override string Identifier => "PodMod.Commando.Faker";
        public override BodyIndex LookUpRequiredBodyIndex()
        {
            return BodyCatalog.FindBodyIndex("CommandoBody");
        }

        public override void OnBodyRequirementMet()
        {
            base.OnBodyRequirementMet();
            base.SetServerTracked(true);
        }

        public override void OnBodyRequirementBroken()
        {
            base.SetServerTracked(false);
            base.OnBodyRequirementBroken();
        }

        private class CommandoFakerServerAchievement : BaseServerAchievement
        {
            private BodyIndex requiredVictimIndex;
            public override void OnInstall()
            {
                base.OnInstall();
                requiredVictimIndex = BodyCatalog.FindBodyIndex("BrotherHurtBody");
                GlobalEventManager.onCharacterDeathGlobal += GlobalEventManager_onCharacterDeathGlobal;
            }

            private void GlobalEventManager_onCharacterDeathGlobal(DamageReport damageReport)
            {
                if (serverAchievementTracker.networkUser.master == damageReport.attackerMaster
                    && damageReport.victimBodyIndex == requiredVictimIndex
                    && damageReport.victimMaster.inventory.GetItemCount(RoR2Content.Items.AttackSpeedOnCrit) == 1
                    && damageReport.victimMaster.inventory.GetItemCount(RoR2Content.Items.CritGlasses) == 11)
                {
                    Grant();
                }
            }

            public override void OnUninstall()
            {
                base.OnUninstall();
            }
        }
    }
}
