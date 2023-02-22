using RoR2;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlternatePods.Achievements.Bandit2
{
    [RegisterAchievement("CrocoClearGameMonsoonWithAlternateSkin", "PodMod.Croco.Mastery", "BeatArena", null)]
    public class CrocoClearGameMonsoonWithAlternateSkinAchievement : BasePerSurvivorClearGameMonsoonWithAlternateSkinAchievement
    {
        public override string NameToken => "PODMOD_CROCOMASTERY";

        public override string Identifier => "PodMod.Croco.Mastery";
        public override BodyIndex LookUpRequiredBodyIndex()
        {
            return BodyCatalog.FindBodyIndex("CrocoBody");
        }
    }
}
