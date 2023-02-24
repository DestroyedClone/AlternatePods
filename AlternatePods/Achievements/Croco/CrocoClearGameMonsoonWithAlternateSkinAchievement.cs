using RoR2;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlternatePods.Achievements.Bandit2
{
    [RegisterAchievement("PodMod_CrocoClearGameMonsoonWithAlternateSkin", "PodMod.Croco.Mastery", "Skins.Croco.Alt1", null)]
    public class CrocoClearGameMonsoonWithAlternateSkinAchievement : BasePerSurvivorClearGameMonsoonWithAlternateSkinAchievement
    {
        public override string NameToken => "PODMOD_CROCOCLEARGAMEMONSOONWITHALTERNATESKIN";

        public override string Identifier => "PodMod.Croco.Mastery";
        public override BodyIndex LookUpRequiredBodyIndex()
        {
            return BodyCatalog.FindBodyIndex("CrocoBody");
        }
    }
}
