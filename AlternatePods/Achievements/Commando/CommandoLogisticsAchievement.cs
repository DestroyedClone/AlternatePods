using RoR2.Achievements;
using RoR2;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlternatePods.Achievements.Commando
{
    [RegisterAchievement("PodMod_CommandoLogistics", "PodMod.Commando.Logistics", null, null)]
    internal class CommandoLogisticsAchievement : BaseModdedAchievement
    {
        public override string NameToken => "PODMOD_COMMANDOLOGISTICS";

        public override string Identifier => "PodMod.Commando.Logistics";
        public override BodyIndex LookUpRequiredBodyIndex()
        {
            return BodyCatalog.FindBodyIndex("CommandoBody");
        }

        public override void OnBodyRequirementMet()
        {
            base.OnBodyRequirementMet();
            Inventory.onInventoryChangedGlobal += Inventory_onInventoryChangedGlobal;
        }

        private void Inventory_onInventoryChangedGlobal(Inventory inventory)
        {
            if (inventory == localUser.cachedMaster.inventory
                && inventory.GetItemCount(RoR2Content.Items.BossDamageBonus) > 0
                && inventory.GetItemCount(RoR2Content.Items.SecondarySkillMagazine) > 0
                && inventory.GetItemCount(RoR2Content.Items.StunChanceOnHit) > 0
                && inventory.GetItemCount(RoR2Content.Items.Missile) > 0
                && inventory.GetItemCount(RoR2Content.Items.Behemoth) > 0)
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
