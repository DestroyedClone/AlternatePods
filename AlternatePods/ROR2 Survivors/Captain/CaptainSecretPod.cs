using AlternatePods.Achievements.Bandit2;
using AlternatePods.Achievements;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using AlternatePods.Achievements.Captain;

namespace AlternatePods.ROR2_Survivors.Captain
{
    internal class CaptainSecretPod : PodModPodBase
    {
        public override string PodName => "Secret";

        public override string PodToken => "CAPTAIN_SECRET";

        public override Texture2D Icon => throw new NotImplementedException();

        public override BaseModdedAchievement Achievement => new CaptainClearGameNoPurchaseAchievement();
    }
}
