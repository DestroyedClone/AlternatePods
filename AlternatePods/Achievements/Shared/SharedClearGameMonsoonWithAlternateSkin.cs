using RoR2;
using RoR2.Achievements;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlternatePods.Achievements.Shared
{
    [RegisterAchievement("PodMod_SharedClearGameMonsoonWithAlternateSkin", "PodMod.Shared.Paintjob", "Characters.Captain", null)]
    public class SharedClearGameMonsoonWithAlternateSkinAchievement : BaseModdedAchievement
    {
        public override string NameToken => "PodMod_SharedClearGameMonsoonWithAlternateSkin";

        public override string Identifier => "PodMod.Shared.Paintjob";

        public override void OnInstall()
        {
            base.OnInstall();
            Run.onClientGameOverGlobal += OnClientGameOverGlobal;
        }

        public override void OnUninstall()
        {
            Run.onClientGameOverGlobal -= OnClientGameOverGlobal;
            base.OnUninstall();
        }

        private void OnClientGameOverGlobal(Run run, RunReport runReport)
        {
            if (!runReport.gameEnding)
            {
                return;
            }
            if (runReport.gameEnding.isWin)
            {
                DifficultyDef difficultyDef = DifficultyCatalog.GetDifficultyDef(runReport.ruleBook.FindDifficulty());
                if (difficultyDef != null && difficultyDef.countsAsHardMode)
                {
                    var survivorPreference = userProfile.GetSurvivorPreference();
                    if (survivorPreference != null)
                    {
                        var bodyName = BodyCatalog.FindBodyIndex(survivorPreference.bodyPrefab.name);
                        if (userProfile.loadout.bodyLoadoutManager.GetReadOnlyBodyLoadout(bodyName)?.skinPreference > 0)
                        {
                            Grant();
                        }
                    }
                }
            }
        }
    }
}
