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
            CharacterBody.onBodyInventoryChangedGlobal += CharacterBody_onBodyInventoryChangedGlobal;
        }

        public override void OnBodyRequirementBroken()
        {
            CharacterBody.onBodyInventoryChangedGlobal -= CharacterBody_onBodyInventoryChangedGlobal;
            base.OnBodyRequirementBroken();
        }

        private void CharacterBody_onBodyInventoryChangedGlobal(CharacterBody characterBody)
        {
            if (characterBody.equipmentSlot.equipmentIndex == EquipmentIndex)
            {
                base.Grant();
            }
        }

    }
}
