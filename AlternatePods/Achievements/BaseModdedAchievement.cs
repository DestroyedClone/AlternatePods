using RoR2.Achievements;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlternatePods.Achievements
{
    public abstract class BaseModdedAchievement : BaseAchievement
    {
        public abstract string NameToken { get; }
        public abstract string Identifier { get; }
    }
}
