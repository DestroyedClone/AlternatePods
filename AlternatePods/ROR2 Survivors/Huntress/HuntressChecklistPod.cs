using AlternatePods.Achievements;
using AlternatePods.Achievements.Huntress;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace AlternatePods.ROR2_Survivors.Huntress
{
    public class HuntressChecklistPod : PodModPodBase
    {
        public override string PodName => "Checklist";

        public override string PodToken => "PODMOD_HUNTRESS_BOUNTY";

        public override Texture2D Icon => throw new NotImplementedException();
        public override BaseModdedAchievement Achievement => new HuntressKill30UniqueMonstersAchievement();
    }
}
