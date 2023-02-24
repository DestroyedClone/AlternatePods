using RoR2;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlternatePods.Achievements.Loader
{
    [RegisterAchievement("PodMod_LoaderClearGameMonsoonWithRiskyRun", "PodMod.Loader.Risky", "DefeatSuperRoboBallBoss", null)]
    public class LoaderClearGameMonsoonWithRiskyRunAchievement : BasePerSurvivorClearGameMonsoonWithRiskyRunAchievement
    {
        public override string NameToken => "PODMOD_LOADERCLEARGAMEMONSOONWITHRISKYRUN";

        public override string Identifier => "PodMod.Loader.Risky";

        public override BodyIndex LookUpRequiredBodyIndex()
        {
            return BodyCatalog.FindBodyIndex("LoaderBody");
        }
    }
}
