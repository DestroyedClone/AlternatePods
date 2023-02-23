using AlternatePods.Achievements;
using AlternatePods.Achievements.Huntress;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace AlternatePods.ROR2_Survivors.Huntress
{
    internal class HuntressRiskyPod : PodModPodBase
    {
        public override string PodName => "Risky";

        public override string PodToken => "HUNTRESS_RISKY";

        public override Texture2D Icon => throw new NotImplementedException();
        public override BaseModdedAchievement Achievement => new HuntressClearGameMonsoonWithRiskyRunAchievement();
        {
    }
}
