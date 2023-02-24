using AlternatePods.Achievements;
using AlternatePods.Achievements.Bandit2;
using RoR2;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace AlternatePods.ROR2_Survivors.Bandit2
{
    internal class Bandit2GamblerPod : PodModPodBase
    {//Gambler-themed. The drop pod is wooden, but there are 57-leaf clovers strung about. Lockboxes and small chests are inside of it. Pile of coins inside.
        public override string PodName => "Gambler";

        public override string PodToken => "BANDIT2_GAMBLER";

        public override Texture2D Icon => throw new NotImplementedException();

        public override BaseModdedAchievement Achievement => new Bandit2UseCasinoChestAchievement();
    }
}
