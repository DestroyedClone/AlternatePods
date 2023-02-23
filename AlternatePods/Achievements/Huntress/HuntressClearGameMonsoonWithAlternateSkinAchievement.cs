﻿using RoR2;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlternatePods.Achievements.Huntress
{
    [RegisterAchievement("HuntressClearGameMonsoonWithAlternateSkin", "PodMod.Huntress.Mastery", "Skins.Huntress.Alt1", null)]
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
