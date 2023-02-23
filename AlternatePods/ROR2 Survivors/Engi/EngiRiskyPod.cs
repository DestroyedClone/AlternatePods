using AlternatePods.Achievements;
using AlternatePods.Achievements.Engi;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace AlternatePods.ROR2_Survivors.Engi
{
    public class EngiRiskyPod : PodModPodBase
    {
        public override string PodName => "Risky";

        public override string PodToken => "PODMOD_ENGI_RISKY";

        public override Texture2D Icon => throw new NotImplementedException();

        public override BaseModdedAchievement Achievement => new EngiClearGameMonsoonWithRiskyRunAchievement();
    }
}
