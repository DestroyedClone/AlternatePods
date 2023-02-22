using RoR2;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlternatePods.Achievements.Bandit2
{
    [RegisterAchievement("Bandit2ClearGameMonsoonWithAlternateSkin", "PodMod.Bandit2.Mastery", "CompleteThreeStages", null)]
    public class Bandit2ClearGameMonsoonWithAlternateSkinAchievement : BasePerSurvivorClearGameMonsoonWithAlternateSkinAchievement
    {
        public override string NameToken => "PODMOD_BANDIT2MASTERY";

        public override string Identifier => "PodMod.Bandit2.Mastery";

        public override BodyIndex LookUpRequiredBodyIndex()
        {
            return BodyCatalog.FindBodyIndex("Bandit2Body");
        }
    }
}
