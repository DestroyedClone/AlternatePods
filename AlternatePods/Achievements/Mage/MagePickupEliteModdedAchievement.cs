using RoR2;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlternatePods.Achievements.Mage
{
    [RegisterAchievement("MageClearGameMonsoonWithAlternateSkin", "PodMod.Mage.EliteFire", "FreeMage", null)]
    public class MagePickupEliteFireAchievement : BaseMagePickupEquipmentAchievement
    {
        public override EquipmentIndex EquipmentIndex => RoR2Content.Equipment.AffixRed.equipmentIndex;

        public override string NameToken => "";

        public override string Identifier => "";
    }
}
