using RoR2;
using RoR2.Achievements;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace AlternatePods.Achievements.Shared
{
    [RegisterAchievement("SharedClearGameMonsoonWithAlternateSkin", "PodMod.Shared.SurvivorPod", null, null)]
    public class StayInPodForOneMinuteAchievement : BaseAchievement
    {
        private static readonly float requirement = 30f;

        private GameObject characterBodyObject;

        private float stopwatch;

        private bool canGive = false;

        public override void OnInstall()
        {
            base.OnInstall();
            localUser.onBodyChanged += LocalUser_onBodyChanged;
            RoR2Application.onFixedUpdate += RoR2Application_onFixedUpdate;
            VehicleSeat.onPassengerExitGlobal += VehicleSeat_onPassengerExitGlobal;
            Run.onRunStartGlobal += Run_onRunStartGlobal;
        }

        public override void OnUninstall()
        {
            RoR2Application.onFixedUpdate -= RoR2Application_onFixedUpdate;
            localUser.onBodyChanged -= LocalUser_onBodyChanged;
            VehicleSeat.onPassengerExitGlobal -= VehicleSeat_onPassengerExitGlobal;
            Run.onRunStartGlobal -= Run_onRunStartGlobal;
            base.OnUninstall();
        }

        private void Run_onRunStartGlobal(Run run)
        {
            canGive = true;
            stopwatch = 0;
        }

        private void VehicleSeat_onPassengerExitGlobal(VehicleSeat vehicleSeat, UnityEngine.GameObject passengerBodyObject)
        {
            if (passengerBodyObject == characterBodyObject)
                canGive = false;
        }

        private void LocalUser_onBodyChanged()
        {
            characterBodyObject = localUser.cachedBodyObject;
        }

        private void RoR2Application_onFixedUpdate()
        {
            stopwatch += Time.fixedDeltaTime;
            if (StayInPodForOneMinuteAchievement.requirement <= stopwatch && canGive)
            {
                Grant();
            }
        }
    }
}
