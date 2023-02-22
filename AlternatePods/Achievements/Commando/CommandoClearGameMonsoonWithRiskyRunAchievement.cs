﻿using RoR2;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlternatePods.Achievements.Commando
{
    [RegisterAchievement("CommandoClearGameMonsoonWithRiskyRun", "PodMod.Commando.Risky", null, null)]
    internal class CommandoClearGameMonsoonWithRiskyRunAchievement : BasePerSurvivorClearGameMonsoonWithRiskyRunAchievement
    {
        public override string NameToken => "PODMOD_COMMANDORISKY";

        public override string Identifier => "PodMod.Commando.Risky";

        public override BodyIndex LookUpRequiredBodyIndex()
        {
            return BodyCatalog.FindBodyIndex("CommandoBody");
        }
    }
}
