﻿using RoR2;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlternatePods.Achievements.Mage
{
    [RegisterAchievement("MageClearGameMonsoonWithAlternateSkin", "PodMod.Mage.Mastery", "FreeMage", null)]
    public class MageClearGameMonsoonWithAlternateSkinAchievement : BasePerSurvivorClearGameMonsoonWithAlternateSkinAchievement
    {
        public override string NameToken => "PODMOD_MAGEMASTERY";

        public override string Identifier => "PodMod.Mage.Mastery";

        public override BodyIndex LookUpRequiredBodyIndex()
        {
            return BodyCatalog.FindBodyIndex("MageBody");
        }

    }
}