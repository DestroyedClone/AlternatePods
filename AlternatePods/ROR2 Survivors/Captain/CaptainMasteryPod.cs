using AlternatePods.Achievements;
using AlternatePods.Achievements.Bandit2;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace AlternatePods.ROR2_Survivors.Captain
{
    public class CaptainMasteryPod : PodModPodBase
    {
        public override string PodName => "Mastery";

        public override string PodToken => "PODMOD_CAPTAIN_MASTERY";

        public override Texture2D Icon => throw new NotImplementedException();

        public override BaseModdedAchievement Achievement => new CaptainClearGameMonsoonWithAlternateSkinAchievement();
    }
}
