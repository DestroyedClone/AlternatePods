using RoR2;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlternatePods.Achievements.Mage
{
    [RegisterAchievement("MageRecyclerVulture", "PodMod.Mage.RecyclerVulture", "FreeMage", null)]
    public class MageRecyclerVultureAchievement : BaseModdedAchievement
    {
        public override string NameToken => "PODMOD_MAGERECYCLERVULTURE";

        public override string Identifier => "PodMod.Mage.RecyclerVulture";

        public override BodyIndex LookUpRequiredBodyIndex()
        {
            return BodyCatalog.FindBodyIndex("MageBody");
        }

        public override void OnBodyRequirementMet()
        {
            base.OnBodyRequirementMet();
            Inventory.onInventoryChangedGlobal += Inventory_onInventoryChangedGlobal;
        }

        public override void OnBodyRequirementBroken()
        {
            base.OnBodyRequirementBroken();
        }

        private void Inventory_onInventoryChangedGlobal(Inventory inventory)
        {
            if (inventory == localUser.cachedMaster.inventory)
            {
                if (inventory.GetItemCount(RoR2Content.Items.HeadHunter) > 0
                    && inventory.currentEquipmentIndex == RoR2Content.Equipment.Recycle.equipmentIndex)
                {
                    Grant();
                }
            }
        }

    }
}
