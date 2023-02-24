using RoR2;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlternatePods.Achievements.Mage
{
    [RegisterAchievement("PodMod_MageClearGameMonsoonWithAlternateSkin", "PodMod.Mage.Mastery", "Skins.Mage.Alt1", null)]
    public class MageClearGameMonsoonWithAlternateSkinAchievement : BasePerSurvivorClearGameMonsoonWithAlternateSkinAchievement
    {
        public override string NameToken => "PODMOD_MAGECLEARGAMEMONSOONWITHALTERNATESKIN";

        public override string Identifier => "PodMod.Mage.Mastery";

        public override BodyIndex LookUpRequiredBodyIndex()
        {
            return BodyCatalog.FindBodyIndex("MageBody");
        }

    }
}
