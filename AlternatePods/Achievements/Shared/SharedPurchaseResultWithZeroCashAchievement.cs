using RoR2.Achievements;
using RoR2;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlternatePods.Achievements.Shared
{
    [RegisterAchievement("PodMod_SharedPurchaseResultWithZeroCash", "PodMod.Shared.NoPod", null, null)]
    public class SharedPurchaseResultWithZeroCashAchievement : BaseModdedAchievement
    {
        public override string NameToken => "PodMod_SharedPurchaseResultWithZeroCash";

        public override string Identifier => "PodMod.Shared.NoPod";
        public override void OnInstall()
        {
            base.OnInstall();
            On.RoR2.PurchaseInteraction.OnInteractionBegin += PurchaseInteraction_OnInteractionBegin;
        }

        private void PurchaseInteraction_OnInteractionBegin(On.RoR2.PurchaseInteraction.orig_OnInteractionBegin orig, PurchaseInteraction self, Interactor activator)
        {
            if (localUser.cachedBodyObject == activator.gameObject
                && self.CanBeAffordedByInteractor(activator)
                && self.Networkcost == localUser.cachedMaster.money)
            {
                Grant();
            }
            orig(self, activator);
        }

        public override void OnUninstall()
        {
            base.OnUninstall();
        }


    }
}
