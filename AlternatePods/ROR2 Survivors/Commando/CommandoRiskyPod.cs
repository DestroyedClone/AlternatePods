using AlternatePods.Achievements;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace AlternatePods.ROR2_Survivors.Commando
{
    public class CommandoRiskyPod : PodModPodBase
    {
        public override string PodName => "Mastery";

        public override string PodToken => "COMMANDO_MASTERY";

        public override Texture2D Icon => throw new NotImplementedException();

        public override BaseModdedAchievement Achievement => new Achievements.Commando.CommandoClearGameMonsoonWithRiskyRunAchievement();
    }
}
