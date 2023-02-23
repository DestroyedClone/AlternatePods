using RoR2;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlternatePods.Achievements.Huntress
{
    [RegisterAchievement("MageClearGameMonsoonWithAlternateSkin", "PodMod.Huntress.Mastery", null, null)]
    public class HuntressClearGameMonsoonWithAlternateSkinAchievement : BasePerSurvivorClearGameMonsoonWithAlternateSkinAchievement
    {
        public override string NameToken => "PODMOD_HUNTRESSMASTERY";

        public override string Identifier => "PodMod.Huntress.Mastery";

        public override BodyIndex LookUpRequiredBodyIndex()
        {
            return BodyCatalog.FindBodyIndex("HuntressBody");
        }
    }
}
