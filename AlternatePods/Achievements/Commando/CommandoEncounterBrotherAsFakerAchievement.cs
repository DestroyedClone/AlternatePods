using RoR2.Achievements;
using RoR2;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlternatePods.Achievements.Commando
{
    [RegisterAchievement("PodMod_CommandoEncounterBrotherAsFaker", "PodMod.Commando.Faker", null, null)]
    public class CommandoEncounterBrotherAsFakerAchievement : BaseModdedAchievement
    {
        public override string NameToken => "PODMOD_COMMANDOENCOUNTERBROTHERASFAKER";

        public override string Identifier => "PodMod.Commando.Faker";
        public override BodyIndex LookUpRequiredBodyIndex()
        {
            return BodyCatalog.FindBodyIndex("CommandoBody");
        }

        public override void OnBodyRequirementMet()
        {
            base.OnBodyRequirementMet();
            On.EntityStates.Missions.BrotherEncounter.Phase1.OnEnter += Phase1_OnEnter;
        }

        public override void OnBodyRequirementBroken()
        {
            On.EntityStates.Missions.BrotherEncounter.Phase1.OnEnter -= Phase1_OnEnter;
            base.OnBodyRequirementBroken();
        }

        private void Phase1_OnEnter(On.EntityStates.Missions.BrotherEncounter.Phase1.orig_OnEnter orig, EntityStates.Missions.BrotherEncounter.Phase1 self)
        {
            orig(self);
            if (localUser.cachedMaster
                && !localUser.cachedMaster.IsDeadAndOutOfLivesServer()
                && localUser.cachedMaster.inventory.GetItemCount(RoR2Content.Items.AttackSpeedOnCrit) == 1
                && localUser.cachedMaster.inventory.GetItemCount(RoR2Content.Items.CritGlasses) == 11)
            {
                Grant();
            }
        }
    }
}
