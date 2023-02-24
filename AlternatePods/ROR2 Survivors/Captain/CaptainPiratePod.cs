using AlternatePods.Achievements.Bandit2;
using AlternatePods.Achievements;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using AlternatePods.Achievements.Captain;

namespace AlternatePods.ROR2_Survivors.Captain
{
    public class CaptainPiratePod : PodModPodBase
    {
        public override string PodName => "Pirate";

        public override string PodToken => "PODMOD_CAPTAIN_PIRATE";

        public override Texture2D Icon => throw new NotImplementedException();

        public override BaseModdedAchievement Achievement => new CaptainAhoyAfterHackAchievement();
    }
}
