using RoR2;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlternatePods.Achievements.Huntress
{
    [RegisterAchievement("PodMod_HuntressClearGameMonsoonWithRiskyRun", "PodMod.Huntress.Risky", null, null)]
    public class HuntressClearGameMonsoonWithRiskyRunAchievement : BasePerSurvivorClearGameMonsoonWithRiskyRunAchievement
    {
        public override string NameToken => "PODMOD_HUNTRESSCLEARGAMEMONSOONWITHRISKYRUN";

        public override string Identifier => "PodMod.Huntress.Risky";

        public override BodyIndex LookUpRequiredBodyIndex()
        {
            return BodyCatalog.FindBodyIndex("HuntressBody");
        }
    }
}
