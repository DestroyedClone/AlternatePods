using RoR2;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlternatePods.Achievements.Bandit2
{
    [RegisterAchievement("PodMod_Bandit2ClearGameMonsoonWithAlternateSkin", "PodMod.Bandit2.Mastery", "Skins.Bandit2.Alt1", null)]
    public class Bandit2ClearGameMonsoonWithAlternateSkinAchievement : BasePerSurvivorClearGameMonsoonWithAlternateSkinAchievement
    {
        public override string NameToken => "BANDIT2CLEARGAMEMONSOONWITHALTERNATESKIN";

        public override string Identifier => "PodMod.Bandit2.Mastery";

        public override BodyIndex LookUpRequiredBodyIndex()
        {
            return BodyCatalog.FindBodyIndex("Bandit2Body");
        }
    }
}
