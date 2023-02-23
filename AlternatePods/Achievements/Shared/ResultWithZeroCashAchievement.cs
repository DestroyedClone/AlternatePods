using RoR2.Achievements;
using RoR2;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlternatePods.Achievements.Shared
{
    [RegisterAchievement("ResultWithZeroCash", "PodMod.Shared.NoPod", null, null)]
    public class ResultWithZeroCashAchievement : BaseAchievement
    {
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
