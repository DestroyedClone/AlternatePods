using RoR2;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlternatePods.Achievements.Mage
{
    [RegisterAchievement("PodMod_MagePickupEliteEarth", "PodMod.Mage.EliteHealing", "FreeMage", null)]
    public class MagePickupEliteEarthAchievement : BaseMagePickupEquipmentAchievement
    {
        public override EquipmentIndex EquipmentIndex => DLC1Content.Elites.Earth.eliteEquipmentDef.equipmentIndex;

        public override string NameToken => "PODMOD_MAGEPICKUPELITEEARTH";

        public override string Identifier => "PodMod.Mage.EliteHealing";
    }
}
