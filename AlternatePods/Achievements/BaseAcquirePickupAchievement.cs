using RoR2;
using RoR2.Achievements;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlternatePods.Achievements
{
    public abstract class BaseAcquirePickupAchievement : BaseModdedAchievement
    {
        public PickupIndex pickupIndex { get; }

        public override void OnInstall()
        {
            base.OnInstall();
        }

        public override void OnUninstall()
        {
            base.OnUninstall();
        }



    }
}
