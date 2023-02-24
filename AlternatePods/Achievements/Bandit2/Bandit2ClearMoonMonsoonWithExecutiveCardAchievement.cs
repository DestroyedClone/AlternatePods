using RoR2;
using RoR2.Achievements;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlternatePods.Achievements.Bandit2
{
    [RegisterAchievement("PodMod_Bandit2ClearMoonMonsoonWithExecutiveCard", "PodMod.Bandit2.Lore", "CompleteThreeStages", null)]
    public class Bandit2ClearMoonMonsoonWithExecutiveCardAchievement : BaseModdedEndingAchievement
    {
        public override string NameToken => "PODMOD_BANDIT2CLEARMOONMONSOONWITHEXECUTIVECARD";

        public override string Identifier => "PodMod.Bandit2.Lore";
        public override BodyIndex LookUpRequiredBodyIndex()
        {
            return BodyCatalog.FindBodyIndex("Bandit2Body");
        }
        public override bool ShouldGrant(RunReport runReport)
        {
            return runReport.gameEnding == GameEndingCatalog.FindGameEndingDef("MainEnding")
                && localUser.cachedMaster.inventory.GetEquipmentIndex() == DLC1Content.Equipment.MultiShopCard.equipmentIndex;
        }
    }
}
