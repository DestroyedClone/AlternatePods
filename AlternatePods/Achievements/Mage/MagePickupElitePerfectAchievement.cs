using RoR2;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlternatePods.Achievements.Mage
{
    [RegisterAchievement("MagePickupElitePerfect", "PodMod.Mage.ElitePerfect", "FreeMage", null)]
    public class MagePickupElitePerfectAchievement : BaseMagePickupEquipmentAchievement
    {
        public override EquipmentIndex EquipmentIndex => RoR2Content.Elites.Lunar.eliteEquipmentDef.equipmentIndex;

        public override string NameToken => "PODMOD_MAGEPERFECT";

        public override string Identifier => "PodMod.Mage.ElitePerfect";
    }
}
