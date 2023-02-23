using RoR2;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlternatePods.Achievements.Engi
{
    [RegisterAchievement("EngiClearGameMonsoonWithAlternateSkin", "PodMod.Engi.Mastery", "Complete30StagesCareer", null)]
    public class EngiClearGameMonsoonWithAlternateSkinAchievement : BasePerSurvivorClearGameMonsoonWithAlternateSkinAchievement
    {
        public override string NameToken => "PODMOD_ENGIMASTERY";

        public override string Identifier => "PodMod.Engi.Mastery";
        public override BodyIndex LookUpRequiredBodyIndex()
        {
            return BodyCatalog.FindBodyIndex("EngiBody");
        }
    }
}
