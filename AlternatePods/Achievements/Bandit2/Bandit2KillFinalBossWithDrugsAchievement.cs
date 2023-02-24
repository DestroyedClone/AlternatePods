using RoR2;
using RoR2.Achievements;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlternatePods.Achievements.Bandit2
{
    [RegisterAchievement("PodMod_Bandit2KillFinalBossWithDrugs", "PodMod.Bandit2.Drugs", "CompleteThreeStages", typeof(Bandit2KillBossWithDrugsServerAchievement))]
    public class Bandit2KillFinalBossWithDrugsAchievement : BaseModdedAchievement
    {
        public override string NameToken => "PODMOD_BANDIT2KILLFINALBOSSWITHDRUGS";

        public override string Identifier => "PodMod.Bandit2.Drugs";
        public override BodyIndex LookUpRequiredBodyIndex()
        {
            return BodyCatalog.FindBodyIndex("Bandit2Body");
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

        private class Bandit2KillBossWithDrugsServerAchievement : BaseServerAchievement
        {
            public override void OnInstall()
            {
                base.OnInstall();
                this.requiredVictimBodyIndices = new List<BodyIndex>
                {
                    BodyCatalog.FindBodyIndex("BrotherHurtBody"),
                    BodyCatalog.FindBodyIndex("MiniVoidRaidCrabBodyPhase3")
                };
                GlobalEventManager.onCharacterDeathGlobal += this.OnCharacterDeathGlobal;
                GlobalEventManager.onServerDamageDealt += this.OnServerDamageDealt;
                this.lastHitTime = float.NegativeInfinity;
            }

            public override void OnUninstall()
            {
                GlobalEventManager.onCharacterDeathGlobal -= this.OnCharacterDeathGlobal;
                GlobalEventManager.onServerDamageDealt -= this.OnServerDamageDealt;
                base.OnUninstall();
            }

            private void OnServerDamageDealt(DamageReport damageReport)
            {
                if (this.requiredVictimBodyIndices.Contains(damageReport.victimBodyIndex)
                    && this.serverAchievementTracker.networkUser.master == damageReport.attackerMaster 
                    && damageReport.attackerMaster 
                    && IsKillerDrugged(damageReport.attackerBody))
                {
                    this.lastHitTime = Run.FixedTimeStamp.now.t;
                }
            }

            private void OnCharacterDeathGlobal(DamageReport damageReport)
            {
                if (this.requiredVictimBodyIndices.Contains(damageReport.victimBodyIndex)
                    && this.serverAchievementTracker.networkUser.master == damageReport.attackerMaster
                    && damageReport.attackerMaster
                    && (Run.FixedTimeStamp.now.t - this.lastHitTime <= 0.1f)
                    && IsKillerDrugged(damageReport.attackerBody))
                {
                    base.Grant();
                }
            }

            private bool IsKillerDrugged(CharacterBody characterBody)
            {
                return characterBody && characterBody.HasBuff(RoR2Content.Buffs.TonicBuff);
            }


            private const float lastHitWindowSeconds = 0.1f;

            private List<BodyIndex> requiredVictimBodyIndices;

            private float lastHitTime;
        }
    }
}
