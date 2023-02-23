using RoR2;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlternatePods.Achievements.Loader
{
    [RegisterAchievement("LoaderAcquireTesla", "PodMod.Loader.Tesla", "DefeatSuperRoboBallBoss", null)]
    internal class LoaderAcquireTeslaAchievement : BaseModdedAchievement
    {
        public override string NameToken => "PODMOD_LOADERTESLA";

        public override string Identifier => "PodMod.Loader.Tesla";

        public override BodyIndex LookUpRequiredBodyIndex()
        {
            return BodyCatalog.FindBodyIndex("LoaderBody");
        }

        public override void OnBodyRequirementMet()
        {
            base.OnBodyRequirementMet();
            Inventory.onInventoryChangedGlobal += Inventory_onInventoryChangedGlobal;
        }

        private void Inventory_onInventoryChangedGlobal(Inventory obj)
        {
            if (obj == localUser.cachedMaster.inventory
                && obj.GetItemCount(RoR2Content.Items.ShockNearby) > 0)
            {
                Grant();
            }
        }

        public override void OnBodyRequirementBroken()
        {
            Inventory.onInventoryChangedGlobal -= Inventory_onInventoryChangedGlobal;
            base.OnBodyRequirementBroken();
        }

    }
}
