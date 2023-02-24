using RoR2;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlternatePods.Achievements.Mage
{
    [RegisterAchievement("PodMod_MagePickupEliteFire", "PodMod.Mage.EliteFire", "FreeMage", null)]
    public class MagePickupEliteFireAchievement : BaseMagePickupEquipmentAchievement
    {
        public override EquipmentIndex EquipmentIndex => RoR2Content.Elites.Fire.eliteEquipmentDef.equipmentIndex;

        public override string NameToken => "PODMOD_MAGEPICKUPELITEFIRE";

        public override string Identifier => "PodMod.Mage.EliteFire";
    }
}
