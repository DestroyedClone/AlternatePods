using RoR2;
using RoR2.Achievements;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlternatePods.Achievements.Bandit2
{
    [RegisterAchievement("Bandit2ClearMoonMonsoonWithExecutiveCard", "PodMod.Bandit2.Lore", "CompleteThreeStages", null)]
    public class Bandit2ClearMoonMonsoonWithExecutiveCardAchievement : BaseModdedEndingAchievement
    {
        public override string NameToken => "PODMOD_BANDIT2LORE";

        public override string Identifier => "PodMod.Bandit2.Lore";
        public override BodyIndex LookUpRequiredBodyIndex()
        {
            return BodyCatalog.FindBodyIndex("Bandit2Body");
        }

        public override void OnBodyRequirementMet()
        {
            base.OnBodyRequirementMet();
            Run.onClientGameOverGlobal += OnClientGameOverGlobal;
        }

        public override void OnBodyRequirementBroken()
        {
            base.OnBodyRequirementBroken();
            Run.onClientGameOverGlobal -= OnClientGameOverGlobal;
        }
        public override bool ShouldGrant(RunReport runReport)
        {
            return runReport.gameEnding == GameEndingCatalog.FindGameEndingDef("MainEnding");
        }
    }
}
