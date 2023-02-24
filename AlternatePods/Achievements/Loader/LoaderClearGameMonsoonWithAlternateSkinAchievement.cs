using RoR2;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlternatePods.Achievements.Loader
{
    [RegisterAchievement("PodMod_LoaderClearGameMonsoonWithAlternateSkin", "PodMod.Loader.Mastery", "Skins.Loader.Alt1", null)]
    public class LoaderClearGameMonsoonWithAlternateSkinAchievement : BasePerSurvivorClearGameMonsoonWithAlternateSkinAchievement
    {
        public override string NameToken => "PODMOD_LOADERCLEARGAMEMONSOONWITHALTERNATESKIN";

        public override string Identifier => "PodMod.Loader.Mastery";

        public override BodyIndex LookUpRequiredBodyIndex()
        {
            return BodyCatalog.FindBodyIndex("LoaderBody");
        }
    }
}
