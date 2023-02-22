using AlternatePods.Achievements;
using AlternatePods.Achievements.Bandit2;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace AlternatePods.ROR2_Survivors.CROCO
{
    internal class CrocoMasteryPod : PodModPodBase
    {
        public override string PodName => "CROCO_MASTERY";

        public override string PodToken => "CROCO_MASTERY";

        public override BaseModdedAchievement Achievement => new CrocoClearGameMonsoonWithAlternateSkinAchievement();

        public override Texture2D Icon => throw new NotImplementedException();
    }
}
