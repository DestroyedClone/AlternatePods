using RoR2;
using RoR2.Achievements;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlternatePods.Achievements.Croco
{
    [RegisterAchievement("CrocoVoidPrison", "PodMod.Croco.Lore", "BeatArena", null)]
    public class CrocoVoidPrisonAchievement : BaseModdedAchievement
    {
        public override string NameToken => "PODMOD_CROCOLORE";

        public override string Identifier => "PodMod.Croco.Lore";
        public override BodyIndex LookUpRequiredBodyIndex()
        {
            return BodyCatalog.FindBodyIndex("CrocoBody");
        }

        public override void OnBodyRequirementMet()
        {
            base.OnBodyRequirementMet();
            GlobalEventManager.onCharacterDeathGlobal += GlobalEventManager_onCharacterDeathGlobal;

        }

        public override void OnBodyRequirementBroken()
        {
            GlobalEventManager.onCharacterDeathGlobal -= GlobalEventManager_onCharacterDeathGlobal;
            base.OnBodyRequirementBroken();
        }

        private void GlobalEventManager_onCharacterDeathGlobal(DamageReport damageReport)
        {
            if (damageReport.victimMaster == localUser.cachedMaster
                && damageReport.damageInfo.damageType.HasFlag(DamageType.VoidDeath))
            {
                Grant();
            }
        }
    }
}
