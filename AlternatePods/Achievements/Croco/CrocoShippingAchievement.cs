using RoR2;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlternatePods.Achievements.Croco
{
    [RegisterAchievement("CrocoShipping", "PodMod.Croco.Shipping", "BeatArena", null)]
    public class CrocoShippingAchievement : BaseModdedAchievement
    {
        public override string NameToken => "PODMOD_CROCOOPENSHIPPINGREQUEST";

        public override string Identifier => "PodMod.Croco.Shipping";
        public override BodyIndex LookUpRequiredBodyIndex()
        {
            return BodyCatalog.FindBodyIndex("CrocoBody");
        }

        public override void OnBodyRequirementMet()
        {
            base.OnBodyRequirementMet();
            Stage.onStageStartGlobal += Stage_onStageStartGlobal;
        }

        public override void OnBodyRequirementBroken()
        {
            Stage.onStageStartGlobal -= Stage_onStageStartGlobal;
            base.OnBodyRequirementBroken();
        }

        private void Stage_onStageStartGlobal(Stage stage)
        {
            if (localUser.cachedMaster.inventory.GetItemCount(DLC1Content.Items.FreeChest) > 0)
            {
                base.Grant();
            }
        }
    }
}
