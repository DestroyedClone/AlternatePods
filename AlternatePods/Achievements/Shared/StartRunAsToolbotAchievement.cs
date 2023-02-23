using RoR2;
using RoR2.Achievements;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlternatePods.Achievements.Shared
{
    [RegisterAchievement("StartRunAsToolbot", "PodMod.Shared.RoboPod", "RepeatFirstTeleporter")]
    public class StartRunAsToolbotAchievement : BaseAchievement
    {
        private bool canGive = true;

        public override void OnInstall()
        {
            base.OnInstall();
            Run.onRunStartGlobal += Run_onRunStartGlobal;
            VehicleSeat.onPassengerExitGlobal += VehicleSeat_onPassengerExitGlobal;
        }

        private void Run_onRunStartGlobal(Run obj)
        {
            canGive = true;
        }

        public override BodyIndex LookUpRequiredBodyIndex()
        {
            return BodyCatalog.FindBodyIndex("ToolbotBody");
        }

        //no need to do a strict check and idc if they unlock this with metamorphosis + volcano egg
        private void VehicleSeat_onPassengerExitGlobal(VehicleSeat arg1, UnityEngine.GameObject passengerObject)
        {
            if (canGive && passengerObject == localUser.cachedBodyObject)
            {
                Grant();
            }
        }

        public override void OnUninstall()
        {
            Run.onRunStartGlobal -= Run_onRunStartGlobal;
            VehicleSeat.onPassengerExitGlobal -= VehicleSeat_onPassengerExitGlobal;
            base.OnUninstall();
        }


    }
}
