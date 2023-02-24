using RoR2;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlternatePods.Achievements.Mage
{
    [RegisterAchievement("PodMod_MagePickupEliteHaunted", "PodMod.Mage.EliteGhost", "FreeMage", null)]
    public class MagePickupEliteHauntedAchievement : BaseMagePickupEquipmentAchievement
    {
        public override EquipmentIndex EquipmentIndex => RoR2Content.Elites.Haunted.eliteEquipmentDef.equipmentIndex;

        public override string NameToken => "PODMOD_MAGEPICKUPELITEHAUNTED";

        public override string Identifier => "PodMod.Mage.EliteGhost";
    }
}
