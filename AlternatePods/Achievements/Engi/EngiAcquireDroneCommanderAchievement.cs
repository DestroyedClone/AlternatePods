using IL.RoR2.Orbs;
using KinematicCharacterController;
using RoR2;
using System;
using System.Collections.Generic;
using System.Text;
using static RoR2.RoR2Content.Items;
using static RoR2.DLC1Content.Items;
using EntityStates.ParentEgg;

namespace AlternatePods.Achievements.Engi
{
    [RegisterAchievement("PodMod_EngiAcquireDroneCommander", "PodMod.Engi.Drone", "Complete30StagesCareer", null)]
    public class EngiAcquireDroneCommanderAchievement : BaseAcquirePickupAchievement
    {
        public override string NameToken => "PODMOD_ENGIACQUIREDRONECOMMANDER";

        public override string Identifier => "PodMod.Engi.Drone";
        public override BodyIndex LookUpRequiredBodyIndex()
        {
            return BodyCatalog.FindBodyIndex("EngiBody");
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

        private void Inventory_onInventoryChangedGlobal(Inventory obj)
        {
            if (obj == localUser.cachedMaster.inventory
                && obj.GetItemCount(DLC1Content.Items.DroneWeapons) > 0)
            {
                Grant();
            }
        }
    }
}
