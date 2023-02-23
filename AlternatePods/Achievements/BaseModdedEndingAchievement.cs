using RoR2.Achievements;
using System;
using System.Collections.Generic;
using System.Text;
using RoR2;

namespace AlternatePods.Achievements
{
    public abstract class BaseModdedEndingAchievement : BaseModdedAchievement
    {
        public abstract bool ShouldGrant(RunReport runReport);

        public override void OnInstall()
        {
            base.OnInstall();
            if (requiredBodyIndex == BodyIndex.None)
            {
                Run.onClientGameOverGlobal += this.OnClientGameOverGlobal;
            }
        }

        public override void OnUninstall()
        {
            if (requiredBodyIndex == BodyIndex.None)
            {
                Run.onClientGameOverGlobal -= this.OnClientGameOverGlobal;
            }
            base.OnUninstall();
        }

        public override void OnBodyRequirementMet()
        {
            base.OnBodyRequirementMet();
            if (requiredBodyIndex != BodyIndex.None)
            {
                Run.onClientGameOverGlobal += this.OnClientGameOverGlobal;
            }
        }

        public override void OnBodyRequirementBroken()
        {
            if (requiredBodyIndex != BodyIndex.None)
            {
                Run.onClientGameOverGlobal += this.OnClientGameOverGlobal;
            }
            base.OnBodyRequirementBroken();
        }

        public void OnClientGameOverGlobal(Run run, RunReport runReport)
        {
            if (this.ShouldGrant(runReport))
            {
                base.Grant();
            }
        }
    }
}
