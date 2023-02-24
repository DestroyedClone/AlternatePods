using RoR2;
using RoR2.Achievements;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlternatePods.Achievements.Croco
{
    [RegisterAchievement("PodMod_CrocoBeatArena", "PodMod.Croco.VoidCell", "BeatArena", typeof(CrocoBeatArenaServerAchievement))]
    internal class CrocoBeatArenaAchievement : BaseModdedAchievement
    {
        public override string NameToken => "PODMOD_CROCOBEATARENA";

        public override string Identifier => "PodMod.Croco.VoidCell";
        public override BodyIndex LookUpRequiredBodyIndex()
        {
            return BodyCatalog.FindBodyIndex("CrocoBody");
        }

        public override void OnBodyRequirementMet()
        {
            base.OnBodyRequirementMet();
            base.SetServerTracked(true);
        }

        public override void OnBodyRequirementBroken()
        {
            base.SetServerTracked(false);
            base.OnBodyRequirementBroken();
        }

        private class CrocoBeatArenaServerAchievement : BaseServerAchievement
        {
            public override void OnInstall()
            {
                base.OnInstall();
                ArenaMissionController.onBeatArena += this.OnBeatArena;
            }

            public override void OnUninstall()
            {
                ArenaMissionController.onBeatArena -= this.OnBeatArena;
                base.OnInstall();
            }

            private void OnBeatArena()
            {
                base.Grant();
            }
        }
    }
}
