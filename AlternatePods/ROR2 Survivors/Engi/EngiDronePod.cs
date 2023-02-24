﻿using AlternatePods.Achievements;
using AlternatePods.Achievements.Engi;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace AlternatePods.ROR2_Survivors.Engi
{
    public class EngiDronePod : PodModPodBase
    {
        public override string PodName => "Drone";

        public override string PodToken => "PODMOD_ENGI_PHD";

        public override Texture2D Icon => throw new NotImplementedException();

        public override BaseModdedAchievement Achievement => new EngiAcquireDroneCommanderAchievement();
    }
}
