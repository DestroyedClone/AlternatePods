using RoR2;
using RoR2.Achievements;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlternatePods.Achievements.Captain
{
    [RegisterAchievement("PodMod_CaptainClearGameNoPurchase", "PodMod.Captain.NoPurchase", "CompleteMainEnding", typeof(CaptainClearGameNoPurchaseServerAchievement))]
    public class CaptainClearGameNoPurchaseAchievement : BaseModdedAchievement
    {
        public override string NameToken => "PODMOD_CAPTAINCLEARGAMENOPURCHASE";

        public override string Identifier => "PodMod.Captain.NoPurchase";

        public override BodyIndex LookUpRequiredBodyIndex()
        {
            return BodyCatalog.FindBodyIndex("CaptainBody");
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

        private class CaptainClearGameNoPurchaseServerAchievement : BaseServerAchievement
        {
            
            public override void OnInstall()
            {
                base.OnInstall();
                On.RoR2.PurchaseInteraction.OnInteractionBegin += PurchaseInteraction_OnInteractionBegin;
                Run.onServerGameOver += Run_onServerGameOver;
            }

            public override void OnUninstall()
            {
                On.RoR2.PurchaseInteraction.OnInteractionBegin -= PurchaseInteraction_OnInteractionBegin;
                Run.onServerGameOver -= Run_onServerGameOver;
                base.OnUninstall();
            }

            private void PurchaseInteraction_OnInteractionBegin(On.RoR2.PurchaseInteraction.orig_OnInteractionBegin orig, PurchaseInteraction self, Interactor activator)
            {
                orig(self, activator);
                if (activator.gameObject.GetComponent<CharacterBody>().master == networkUser.master
                    && self.Networkcost > 0)
                {
                    purchases++;
                }
            }

            private void Run_onServerGameOver(Run run, GameEndingDef gameEndingDef)
            {
                if (purchases == 0
                    && gameEndingDef != null)
                    Grant();
            }

            private int purchases = 0;
        }
    }
}
