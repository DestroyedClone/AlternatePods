using AlternatePods.Achievements;
using AlternatePods.Achievements.Commando;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace AlternatePods.ROR2_Survivors.Commando
{
    public class CommandoFakerPod : PodModPodBase
    {
        public override string PodName => "Faker";

        public override string PodToken => "PODMOD_COMMANDO_SURVIVOR";

        public override Texture2D Icon => throw new NotImplementedException();

        public override BaseModdedAchievement Achievement => new CommandoEncounterBrotherAsFakerAchievement();
    }
}
