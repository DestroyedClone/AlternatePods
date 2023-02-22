using AlternatePods.Achievements;
using AlternatePods.Achievements.Bandit2;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace AlternatePods.ROR2_Survivors.CROCO
{
    internal class CrocoRiskyPod : PodModPodBase
    {
        public override string PodName => "Risky";

        public override string PodToken => "CROCO_RISKY";

        public override BaseModdedAchievement Achievement => new CrocoClearGameMonsoonWithRiskyRunAchievement();

        public override Texture2D Icon => throw new NotImplementedException();
    }
}
