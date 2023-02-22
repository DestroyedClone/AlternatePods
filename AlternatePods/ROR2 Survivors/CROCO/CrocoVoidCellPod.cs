﻿using AlternatePods.Achievements;
using AlternatePods.Achievements.Croco;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace AlternatePods.ROR2_Survivors.CROCO
{
    internal class CrocoVoidCellPod : PodModPodBase
    {
        public override string PodName => "VoidCell";

        public override string PodToken => "CROCO_VOIDCELL";

        public override BaseModdedAchievement Achievement => new CrocoVoidFieldsAchievement();

        public override Texture2D Icon => throw new NotImplementedException();
    }
}