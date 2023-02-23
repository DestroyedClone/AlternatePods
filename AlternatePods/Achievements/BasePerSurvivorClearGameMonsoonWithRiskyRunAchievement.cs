using RoR2;
using RoR2.Achievements;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlternatePods.Achievements
{
    public abstract class BasePerSurvivorClearGameMonsoonWithRiskyRunAchievement : BaseModdedAchievement
    {
        public override void OnBodyRequirementMet()
        {
            base.OnBodyRequirementMet();
            Run.onClientGameOverGlobal += OnClientGameOverGlobal;
        }

        public override void OnBodyRequirementBroken()
        {
            Run.onClientGameOverGlobal -= OnClientGameOverGlobal;
            base.OnBodyRequirementBroken();
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
                    var bodyName = BodyCatalog.FindBodyIndex(userProfile.GetSurvivorPreference().bodyPrefab.name);
                    if (userProfile.loadout.bodyLoadoutManager.GetReadOnlyBodyLoadout(bodyName).skinPreference > 0)
                    {
                        Grant();
                    }
                }
            }
        }

        private bool IsRiskyRun(Inventory inventory)
        {
            return false;
        }
    }
}
