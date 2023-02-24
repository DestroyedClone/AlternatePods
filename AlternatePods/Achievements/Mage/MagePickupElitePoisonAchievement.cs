using RoR2;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlternatePods.Achievements.Mage
{
    [RegisterAchievement("PodMod_MagePickupElitePoison", "PodMod.Mage.EliteAntiHeal", "FreeMage", null)]
    public class MagePickupElitePoisonAchievement : BaseMagePickupEquipmentAchievement
    {
        public override EquipmentIndex EquipmentIndex => RoR2Content.Elites.Poison.eliteEquipmentDef.equipmentIndex;

        public override string NameToken => "PODMOD_MAGEPICKUPELITEPOISON";

        public override string Identifier => "PodMod.Mage.EliteAntiHeal";
    }
}
