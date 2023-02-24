using RoR2;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlternatePods.Achievements.Engi
{
    [RegisterAchievement("PodMod_EngiClearGameMonsoonWithAlternateSkin", "PodMod.Engi.Mastery", "Skins.Engi.Alt1", null)]
    public class EngiClearGameMonsoonWithAlternateSkinAchievement : BasePerSurvivorClearGameMonsoonWithAlternateSkinAchievement
    {
        public override string NameToken => "PODMOD_ENGICLEARGAMEMONSOONWITHALTERNATESKIN";

        public override string Identifier => "PodMod.Engi.Mastery";
        public override BodyIndex LookUpRequiredBodyIndex()
        {
            return BodyCatalog.FindBodyIndex("EngiBody");
        }
    }
}
