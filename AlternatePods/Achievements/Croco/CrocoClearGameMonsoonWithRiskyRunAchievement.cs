using RoR2;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlternatePods.Achievements.Bandit2
{
    [RegisterAchievement("PodMod_CrocoClearGameMonsoonWithRiskyRun", "PodMod.Croco.Risky", "BeatArena", null)]
    public class CrocoClearGameMonsoonWithRiskyRunAchievement : BasePerSurvivorClearGameMonsoonWithRiskyRunAchievement
    {
        public override string NameToken => "PODMOD_CROCOCLEARGAMEMONSOONWITHRISKYRUN";

        public override string Identifier => "PodMod.Croco.Risky";
        public override BodyIndex LookUpRequiredBodyIndex()
        {
            return BodyCatalog.FindBodyIndex("CrocoBody");
        }
    }
}
