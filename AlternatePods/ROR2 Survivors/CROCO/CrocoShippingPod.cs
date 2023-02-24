using AlternatePods.Achievements;
using AlternatePods.Achievements.Croco;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace AlternatePods.ROR2_Survivors.CROCO
{
    internal class CrocoShippingPod : PodModPodBase
    {
        public override string PodName => "Shipping";

        public override string PodToken => "PODMOD_CROCO_SHIPPING";

        public override BaseModdedAchievement Achievement => new CrocoShippingAchievement();

        public override Texture2D Icon => throw new NotImplementedException();
    }
}
