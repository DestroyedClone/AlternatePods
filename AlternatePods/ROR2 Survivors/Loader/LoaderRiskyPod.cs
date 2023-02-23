using AlternatePods.Achievements;
using AlternatePods.Achievements.Loader;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace AlternatePods.ROR2_Survivors.Loader
{
    internal class LoaderRiskyPod : PodModPodBase
    {
        public override string PodName => "Risky";

        public override string PodToken => "PODMOD_LOADER_RISKY";

        public override Texture2D Icon => throw new NotImplementedException();

        public override BaseModdedAchievement Achievement => new LoaderClearGameMonsoonWithRiskyRunAchievement();
        
    }
}
