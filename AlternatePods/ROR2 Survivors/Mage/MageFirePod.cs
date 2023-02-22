using System;
using System.Collections.Generic;
using System.Text;
using AlternatePods.Achievements;
using AlternatePods.Achievements.Mage;
using RoR2;
using UnityEngine;

namespace AlternatePods.ROR2_Survivors.Mage
{
    public class MageFirePod : PodModPodBase
    {
        public override string PodName => "Fire";

        public override string PodToken => "PODMOD_MAGE_FIRE";

        public override Texture2D Icon => throw new NotImplementedException();

        public override BaseModdedAchievement Achievement => new MagePickupEliteFireAchievement();
    }
}
