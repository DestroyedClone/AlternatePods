using RoR2;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlternatePods.Achievements.Mage
{
    public abstract class BaseMagePickupEquipmentAchievement : BaseModdedAchievement
    {
        public abstract EquipmentIndex EquipmentIndex { get; }
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
            Inventory.onInventoryChangedGlobal -= Inventory_onInventoryChangedGlobal;
            base.OnBodyRequirementBroken();
        }

        private void Inventory_onInventoryChangedGlobal(Inventory inventory)
        {
            if (inventory.currentEquipmentIndex == EquipmentIndex)
            {
                base.Grant();
            }
        }
    }
}
