using RoR2.Achievements;
using System;
using System.Collections.Generic;
using System.Text;
using RoR2;

namespace AlternatePods.Achievements.Bandit2
{
    [RegisterAchievement("PodMod_Bandit2UseCasinoChest", "PodMod.Bandit2.Gamble", "CompleteThreeStages", typeof(Bandit2UseCasinoChestServerAchievement))]
    public class Bandit2UseCasinoChestAchievement : BaseModdedAchievement
    {
        public override string NameToken => "PODMOD_BANDIT2USECASINOCHEST";

        public override string Identifier => "PodMod.Bandit2.Gamble";
        public override BodyIndex LookUpRequiredBodyIndex()
        {
            return BodyCatalog.FindBodyIndex("Bandit2Body");
        }
        public override void OnBodyRequirementMet()
        {
            base.OnBodyRequirementMet();
            base.SetServerTracked(true);
        }

        public override void OnBodyRequirementBroken()
        {
            base.SetServerTracked(false);
            base.OnBodyRequirementBroken();
        }

        public class Bandit2UseCasinoChestServerAchievement : BaseServerAchievement
        {
            public override void OnInstall()
            {
                base.OnInstall();
                On.RoR2.RouletteChestController.EjectPickupServer += RouletteChestController_EjectPickupServer;
            }

            public override void OnUninstall()
            {
                On.RoR2.RouletteChestController.EjectPickupServer -= RouletteChestController_EjectPickupServer;
                base.OnUninstall();
            }

            private void RouletteChestController_EjectPickupServer(On.RoR2.RouletteChestController.orig_EjectPickupServer orig, RouletteChestController self, PickupIndex pickupIndex)
            {
                orig(self, pickupIndex);
                if (self.purchaseInteraction.lastActivator.TryGetComponent(out CharacterBody characterBody)
                    && this.serverAchievementTracker.networkUser.master == characterBody.master
                    && characterBody.master)
                {
                    Grant();
                }
            }
        }
    }
}
