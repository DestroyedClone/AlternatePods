using RoR2;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlternatePods.Achievements.Mage
{
    [RegisterAchievement("MagePickupEliteIce", "PodMod.Mage.EliteIce", "FreeMage", null)]
    public class MagePickupEliteIceAchievement : BaseMagePickupEquipmentAchievement
    {
        public override EquipmentIndex EquipmentIndex => RoR2Content.Elites.Ice.eliteEquipmentDef.equipmentIndex;

        public override string NameToken => "PODMOD_MAGEICE";

        public override string Identifier => "PodMod.Mage.EliteIce";
    }
}
