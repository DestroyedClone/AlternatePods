using AlternatePods.Achievements;
using AlternatePods.Achievements.Bandit2;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace AlternatePods.ROR2_Survivors.Bandit2
{
    public class Bandit2CowboyPod : PodModPodBase
    {
        public override string PodName => "Pub";

        public override string PodToken => "BANDIT2_COWBOY";

        public override Texture2D Icon => throw new NotImplementedException();

        public override BaseModdedAchievement Achievement => new Bandit2KillFinalBossWithDrugsAchievement();
    }
}
