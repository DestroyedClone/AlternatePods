using RoR2;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlternatePods.Achievements.Mage
{
    [RegisterAchievement("MagePickupEliteHealing", "PodMod.Mage.EliteHealing", "FreeMage", null)]
    public class MagePickupEliteHealingAchievement : BaseMagePickupEquipmentAchievement
    {
        public override EquipmentIndex EquipmentIndex => DLC1Content.Elites.Earth.eliteEquipmentDef.equipmentIndex;

        public override string NameToken => "PODMOD_MAGEHEALING";

        public override string Identifier => "PodMod.Mage.EliteHealing";
    }
}
