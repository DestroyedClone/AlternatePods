using RoR2;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlternatePods.Achievements.Engi
{
    [RegisterAchievement("PodMod_EngiClearGameMonsoonWithRiskyRun", "PodMod.Engi.Risky", "BeatArena", null)]
    internal class EngiClearGameMonsoonWithRiskyRunAchievement : BasePerSurvivorClearGameMonsoonWithRiskyRunAchievement
    {
        public override string NameToken => "PODMOD_ENGICLEARGAMEMONSOONWITHRISKYRUN";

        public override string Identifier => "PodMod.Engi.Risky";
        public override BodyIndex LookUpRequiredBodyIndex()
        {
            return BodyCatalog.FindBodyIndex("EngiBody");
        }
    }
}
