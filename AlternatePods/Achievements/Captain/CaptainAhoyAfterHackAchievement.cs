using EntityStates.GameOver;
using RoR2;
using RoR2.Achievements;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace AlternatePods.Achievements.Captain
{
    [RegisterAchievement("CaptainAhoyAfterHack", "PodMod.Captain.AhoyAfterPurchase", "CompleteMainEnding", typeof(CaptainAhoyAfterHackServerAchievement))]
    public class CaptainAhoyAfterHackAchievement : BaseModdedAchievement
    {
        public override string NameToken => "CaptainAhoyAfterHack";

        public override string Identifier => "PodMod.Captain.AhoyAfterPurchase";

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

        private class CaptainAhoyAfterHackServerAchievement : BaseServerAchievement
        {
            public float stopwatch = 0;
            private readonly float allowedDurationForAhoy = 3;

            public override void OnInstall()
            {
                base.OnInstall();
                On.EntityStates.CaptainSupplyDrop.UnlockTargetState.OnEnter += UnlockTargetState_OnEnter;
                EquipmentSlot.onServerEquipmentActivated += EquipmentSlot_onServerEquipmentActivated;
                RoR2Application.onFixedUpdate += RoR2Application_onFixedUpdate;
            }

            public override void OnUninstall()
            {
                On.EntityStates.CaptainSupplyDrop.UnlockTargetState.OnEnter -= UnlockTargetState_OnEnter;
                EquipmentSlot.onServerEquipmentActivated -= EquipmentSlot_onServerEquipmentActivated;
                RoR2Application.onFixedUpdate -= RoR2Application_onFixedUpdate;
                base.OnUninstall();
            }

            private void RoR2Application_onFixedUpdate()
            {
                stopwatch += Time.fixedDeltaTime;
            }

            private void UnlockTargetState_OnEnter(On.EntityStates.CaptainSupplyDrop.UnlockTargetState.orig_OnEnter orig, EntityStates.CaptainSupplyDrop.UnlockTargetState self)
            {
                stopwatch = 0;
                orig(self);
            }

            private void EquipmentSlot_onServerEquipmentActivated(EquipmentSlot equipmentSlot, EquipmentIndex equipmentIndex)
            {
                if (networkUser.master.GetBody() 
                    && equipmentSlot == networkUser.master.GetBody().equipmentSlot)
                {
                    if (equipmentIndex == DLC1Content.Equipment.BossHunterConsumed.equipmentIndex
                        && stopwatch < allowedDurationForAhoy)
                    {
                        Grant();
                    }
                }
            }

        }
    }
}
