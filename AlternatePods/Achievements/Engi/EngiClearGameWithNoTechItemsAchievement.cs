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
    [RegisterAchievement("PodMod_EngiClearGameWithNoTechItems", "PodMod.Engi.Bio", "Complete30StagesCareer", null)]
    public class EngiClearGameWithNoTechItemsAchievement : BaseModdedEndingAchievement
    {
        public bool hasPickedUpTechItem = false;

        public override string NameToken => "PODMOD_ENGICLEARGAMEWITHNOTECHITEMS";

        public override string Identifier => "PodMod.Engi.Bio";
        public override BodyIndex LookUpRequiredBodyIndex()
        {
            return BodyCatalog.FindBodyIndex("EngiBody");
        }

        public override void OnBodyRequirementMet()
        {
            base.OnBodyRequirementMet();
            Inventory.onInventoryChangedGlobal += Inventory_onInventoryChangedGlobal;
            Run.onRunStartGlobal += Run_onRunStartGlobal;
        }

        private void Run_onRunStartGlobal(Run obj)
        {
            hasPickedUpTechItem = false;
        }

        public override void OnBodyRequirementBroken()
        {
            Inventory.onInventoryChangedGlobal -= Inventory_onInventoryChangedGlobal;
            Run.onRunStartGlobal -= Run_onRunStartGlobal;
            base.OnBodyRequirementBroken();
        }


        public override bool ShouldGrant(RunReport runReport)
        {
            return !hasPickedUpTechItem;
        }

        private void Inventory_onInventoryChangedGlobal(Inventory inventory)
        {
            if (hasPickedUpTechItem) return;
            if (inventory != localUser.cachedMaster.inventory) return;
            ItemDef[] itemDefs = new ItemDef[]
            {
                Behemoth,
                BarrierOnKill,
                Medkit,
                MinorConstructOnKill,
                Missile,
                MoreMissile,
                PermanentDebuffOnHit,
                PersonalShield,
                Phasing,
                RoboBallBuddy,
                ScrapGreen,
                ScrapRed,
                ScrapWhite,
                ScrapYellow,
                SecondarySkillMagazine,
                ShockNearby,
                BleedOnHit,
                StickyBomb,
                StrengthenBurn,
                StunChanceOnHit,
                Syringe,
                Thorns,
                TreasureCache,
                UtilitySkillMagazine,
                BossDamageBonus,
                BounceNearby,
                CaptainDefenseMatrix,
                ChainLightning,
                ChainLightningVoid,
                ArmorPlate,
                CritDamage,
                CritGlasses,
                CritGlassesVoid,
                Crowbar,
                ArmorReductionOnHit,
                DroneWeapons,
                EquipmentMagazine,
                EquipmentMagazineVoid,
                FallBoots,
                Firework,
                FragileDamageBonus,
                FragileDamageBonusConsumed,
                FreeChest,
                GoldOnHurt,
                IgniteOnKill,
                ImmuneToDebuff,
                Bandolier,
                LaserTurbine
            };
            foreach (var itemDef in itemDefs)
            {
                var itemCount = inventory.GetItemCount(itemDef);
                if (itemCount > 0)
                {
                    hasPickedUpTechItem = true;
                    return;
                }
            }
        }

    }
}
