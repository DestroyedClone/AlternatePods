using AlternatePods.Achievements;
using AlternatePods.Achievements.Bandit2;
using R2API;
using RoR2;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace AlternatePods.ROR2_Survivors
{
    public class Bandit2MasteryPod : PodModPodBase
    {//DEADBOLT themed
        public override string PodName => "Mastery";

        public override string PodToken => "BANDIT2_MASTERY";

        public override Texture2D Icon => throw new NotImplementedException();

        public override BaseModdedAchievement Achievement => new Bandit2ClearGameMonsoonWithAlternateSkinAchievement();

        public override GameObject CreatePodPrefab()
        {
            var podPrefabInstance = PrefabAPI.InstantiateClone(Assets.genericPodPrefab, PodName, true);
            PodPrefab = podPrefabInstance;
            return podPrefabInstance;
        }
    }
}
