using RoR2;
using RoR2.Achievements;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlternatePods.Achievements.Mage
{
    public abstract class BaseMagePickupEquipmentServerAchievement : BaseServerAchievement
    {
        public abstract EquipmentIndex EquipmentIndex { get; }
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
