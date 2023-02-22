using System;
using System.Collections.Generic;
using System.Text;
using AlternatePods.Achievements;
using RoR2;
using UnityEngine;

namespace AlternatePods.ROR2_Survivors.Mage
{
    public class Mage : PodModPodBase
    {
        public override string PodName => "";

        public override string PodToken => "";

        public override Texture2D Icon => throw new NotImplementedException();

        public override BaseModdedAchievement Achievement => new ;
    }
}
