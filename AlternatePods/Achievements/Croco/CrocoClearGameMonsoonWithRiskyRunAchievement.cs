using RoR2;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlternatePods.Achievements.Bandit2
{
    [RegisterAchievement("CrocoClearGameMonsoonWithRiskyRun", "PodMod.Croco.Risky", "BeatArena", null)]
    public class CrocoClearGameMonsoonWithRiskyRunAchievement : BasePerSurvivorClearGameMonsoonWithRiskyRunAchievement
    {
        public override string NameToken => "PODMOD_CROCORISKY";

        public override string Identifier => "PodMod.Croco.Risky";
        public override BodyIndex LookUpRequiredBodyIndex()
        {
            return BodyCatalog.FindBodyIndex("CrocoBody");
        }
    }
}
