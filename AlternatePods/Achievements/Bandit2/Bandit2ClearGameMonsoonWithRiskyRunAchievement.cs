using RoR2;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlternatePods.Achievements.Bandit2
{
    [RegisterAchievement("PodMod_Bandit2ClearGameMonsoonWithRiskyRun", "PodMod.Bandit2.Risky", "CompleteThreeStages", null)]
    public class Bandit2ClearGameMonsoonWithRiskyRunAchievement : BasePerSurvivorClearGameMonsoonWithRiskyRunAchievement
    {
        public override string NameToken => "PODMOD_BANDIT2CLEARGAMEMONSOONWITHRISKYRUN";

        public override string Identifier => "PodMod.Bandit2.Risky";
        public override BodyIndex LookUpRequiredBodyIndex()
        {
            return BodyCatalog.FindBodyIndex("Bandit2Body");
        }
    }
}
