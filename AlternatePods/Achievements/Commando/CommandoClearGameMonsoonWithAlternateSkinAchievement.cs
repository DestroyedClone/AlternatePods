using RoR2;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlternatePods.Achievements.Commando
{
    [RegisterAchievement("CommandoClearGameMonsoonWithAlternateSkin", "PodMod.Commando.Mastery", null, null)]
    public class CommandoClearGameMonsoonWithAlternateSkinAchievement : BaseModdedAchievement
    {
        public override string NameToken => "PODMOD_COMMANDOMASTERY";

        public override string Identifier => "PodMod.Commando.Mastery";

        public override BodyIndex LookUpRequiredBodyIndex()
        {
            return BodyCatalog.FindBodyIndex("CommandoBody");
        }
    }
}
