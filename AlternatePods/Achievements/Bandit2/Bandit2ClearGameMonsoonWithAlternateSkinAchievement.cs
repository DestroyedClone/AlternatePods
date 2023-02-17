using RoR2;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlternatePods.Achievements.Bandit2
{
    [RegisterAchievement("Bandit2ClearGameMonsoonWithAlternateSkin", "Skins.Bandit2.Alt1", "CompleteThreeStages", null)]
    public class Bandit2ClearGameMonsoonWithAlternateSkinAchievement : BasePerSurvivorClearGameMonsoonWithAlternateSkinAchievement
    {
        public override BodyIndex LookUpRequiredBodyIndex()
        {
            return BodyCatalog.FindBodyIndex("Bandit2Body");
        }
    }
}
