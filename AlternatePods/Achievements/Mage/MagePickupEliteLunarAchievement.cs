using RoR2;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlternatePods.Achievements.Mage
{
    [RegisterAchievement("PodMod_MagePickupEliteLunar", "PodMod.Mage.ElitePerfect", "FreeMage", null)]
    public class MagePickupEliteLunarAchievement : BaseMagePickupEquipmentAchievement
    {
        public override EquipmentIndex EquipmentIndex => RoR2Content.Elites.Lunar.eliteEquipmentDef.equipmentIndex;

        public override string NameToken => "PODMOD_MAGEPICKUPELITELUNAR";

        public override string Identifier => "PodMod.Mage.ElitePerfect";
    }
}
