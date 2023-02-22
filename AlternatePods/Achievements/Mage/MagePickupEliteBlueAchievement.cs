using RoR2;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlternatePods.Achievements.Mage
{
    [RegisterAchievement("MagePickupEliteBlue", "PodMod.Mage.EliteBlue", "FreeMage", null)]
    public class MagePickupEliteBlueAchievement : BaseMagePickupEquipmentAchievement
    {
        public override EquipmentIndex EquipmentIndex => RoR2Content.Elites.Lightning.eliteEquipmentDef.equipmentIndex;

        public override string NameToken => "PODMOD_MAGEBLUE";

        public override string Identifier => "PodMod.Mage.EliteBlue";
    }
}
