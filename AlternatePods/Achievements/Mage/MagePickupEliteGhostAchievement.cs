using RoR2;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlternatePods.Achievements.Mage
{
    [RegisterAchievement("MagePickupEliteGhost", "PodMod.Mage.EliteGhost", "FreeMage", null)]
    public class MagePickupEliteGhostAchievement : BaseMagePickupEquipmentAchievement
    {
        public override EquipmentIndex EquipmentIndex => RoR2Content.Elites.Haunted.eliteEquipmentDef.equipmentIndex;

        public override string NameToken => "PODMOD_MAGEGHOST";

        public override string Identifier => "PodMod.Mage.EliteGhost";
    }
}
