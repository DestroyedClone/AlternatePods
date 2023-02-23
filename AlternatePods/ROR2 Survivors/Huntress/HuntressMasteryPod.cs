using AlternatePods.Achievements;
using AlternatePods.Achievements.Huntress;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace AlternatePods.ROR2_Survivors.Huntress
{
    public class HuntressMasteryPod : PodModPodBase
    {
        public override string PodName => "Mastery";

        public override string PodToken => "HUNTRESS_MASTERY";

        public override Texture2D Icon => throw new NotImplementedException();
        public override BaseModdedAchievement Achievement => new HuntressClearGameMonsoonWithAlternateSkinAchievement();
        {
    }
}
