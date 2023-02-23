﻿using RoR2;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlternatePods.Achievements.Loader
{
    [RegisterAchievement("LoaderClearGameMonsoonWithAlternateSkin", "PodMod.Loader.Mastery", "DefeatSuperRoboBallBoss", null)]
    public class LoaderClearGameMonsoonWithAlternateSkinAchievement : BasePerSurvivorClearGameMonsoonWithAlternateSkinAchievement
    {
        public override string NameToken => "PODMOD_LOADERMASTERY";

        public override string Identifier => "PodMod.Loader.Mastery";

        public override BodyIndex LookUpRequiredBodyIndex()
        {
            return BodyCatalog.FindBodyIndex("LoaderBody");
        }
    }
}
