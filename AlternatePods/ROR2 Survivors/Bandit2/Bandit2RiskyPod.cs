using AlternatePods.Achievements;
using AlternatePods.Achievements.Bandit2;
using RoR2;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace AlternatePods.ROR2_Survivors.Bandit2
{
    public class Bandit2RiskyPod : PodModPodBase
    {//Wooden texture. There are 57 leaf clovers on the ground, gold piled high, and a syringe next to a red whip (tourniquet). A RoR1 item. 
        public override string PodName => "Risky";

        public override string PodToken => "BANDIT2_RISKY";

        public override Texture2D Icon => throw new NotImplementedException();

        public override BaseModdedAchievement Achievement => new Bandit2ClearGameMonsoonWithRiskyRunAchievement();
    }
}
