using AlternatePods.Achievements;
using AlternatePods.Achievements.Bandit2;
using RoR2;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace AlternatePods.ROR2_Survivors.Bandit2
{
    internal class Bandit2LorePod : PodModPodBase
    {
        public override string PodName => "Lore";

        public override string PodToken => "BANDIT2_LORE";

        public override Texture2D Icon => throw new NotImplementedException();

        public override BaseModdedAchievement Achievement => new Bandit2ClearMoonMonsoonWithExecutiveCardAchievement();
    }
}
