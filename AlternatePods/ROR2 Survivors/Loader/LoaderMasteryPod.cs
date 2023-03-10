using AlternatePods.Achievements;
using AlternatePods.Achievements.Loader;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace AlternatePods.ROR2_Survivors.Loader
{
    internal class LoaderMasteryPod : PodModPodBase
    {
        public override string PodName => "Mastery";

        public override string PodToken => "PODMOD_LOADER_MASTERY";

        public override Texture2D Icon => throw new NotImplementedException();

        public override BaseModdedAchievement Achievement => new LoaderClearGameMonsoonWithAlternateSkinAchievement();
        
    }
}
