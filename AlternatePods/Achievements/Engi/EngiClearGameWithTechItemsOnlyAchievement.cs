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
    [RegisterAchievement("PodMod_EngiClearGameWithTechItemsOnly", "PodMod.Engi.Tech", "Complete30StagesCareer", null)]
    public class EngiClearGameWithTechItemsOnlyAchievement : BaseModdedEndingAchievement
    {
        public bool hasPickedUpBioItems = false;

        public override string NameToken => "PODMOD_ENGICLEARGAMEWITHTECHITEMSONLY";

        public override string Identifier => "PodMod.Engi.Tech";
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
            hasPickedUpBioItems = false;
        }

        public override void OnBodyRequirementBroken()
        {
            Inventory.onInventoryChangedGlobal -= Inventory_onInventoryChangedGlobal;
            Run.onRunStartGlobal -= Run_onRunStartGlobal;
            base.OnBodyRequirementBroken();
        }


        public override bool ShouldGrant(RunReport runReport)
        {
            return !hasPickedUpBioItems;
        }

        private void Inventory_onInventoryChangedGlobal(Inventory inventory)
        {
            if (hasPickedUpBioItems) return;
            if (inventory != localUser.cachedMaster.inventory) return;
            ItemDef[] itemDefs = new ItemDef[]
            {
                LunarPrimaryReplacement,
                LunarSecondaryReplacement,
                LunarSpecialReplacement,
                LunarUtilityReplacement,
                MissileVoid,
                Mushroom,
                MushroomVoid,
                NovaOnLowHealth,
                ParentEgg,
                Pearl,
                Plant,
                ShinyPearl,
                RandomDamageZone,
                RegeneratingScrap,
                RegeneratingScrapConsumed,
                RepeatHeal,
                Seed,
                ShieldOnly,
                SlowOnHitVoid,
                Squid,
                TPHealingNova,
                TitanGoldDuringTP,
                Tooth,
                VoidMegaCrabItem,
                BleedOnHitVoid,
                BonusGoldPackOnKill,
                AlienHead,
                Clover,
                CloverVoid,
                ExtraLifeVoidConsumed,
                ExtraLifeVoid,
                AttackSpeedAndMoveSpeed,
                Feather,
                FireballsOnHit,
                Feather,
                FlatHealth,
                AttackSpeedOnCrit,
                HeadHunter,
                HealWhileSafe,
                HealingPotion,
                HealingPotionConsumed,
                Hoof,
                IncreaseHealing,
                Infusion,
                KillEliteFrenzy,
                LightningStrikeOnHit,
            };
            foreach (var itemDef in itemDefs)
            {
                var itemCount = inventory.GetItemCount(itemDef);
                if (itemCount > 0)
                {
                    hasPickedUpBioItems = true;
                    return;
                }
            }
        }

    }
}
