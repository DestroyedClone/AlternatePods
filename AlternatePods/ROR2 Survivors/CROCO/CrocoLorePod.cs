using AlternatePods.Achievements;
using AlternatePods.Achievements.Croco;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace AlternatePods.ROR2_Survivors.CROCO
{
    internal class CrocoLorePod : PodModPodBase
    {
        public override string PodName => "Lore";

        public override string PodToken => "PODMOD_CROCO_LORE";

        public override BaseModdedAchievement Achievement => new CrocoDieToVoidPrisonAchievement();

        public override Texture2D Icon => throw new NotImplementedException();
    }
}
