﻿using RoR2;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlternatePods.Achievements.Bandit2
{
    [RegisterAchievement("CaptainClearGameMonsoonWithAlternateSkin", "PodMod.Captain.Mastery", "Skins.Captain.Alt1", null)]
    public class CaptainClearGameMonsoonWithAlternateSkinAchievement : BasePerSurvivorClearGameMonsoonWithAlternateSkinAchievement
    {
        public override string NameToken => "PODMOD_CAPTAINMASTERY";

        public override string Identifier => "PodMod.Captain.Mastery";

        public override BodyIndex LookUpRequiredBodyIndex()
        {
            return BodyCatalog.FindBodyIndex("CaptainBody");
        }
    }
}
