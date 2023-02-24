using R2API;
using RoR2;
using UnityEngine;
using System.Collections.Generic;
using BepInEx.Configuration;
using UnityEngine.AddressableAssets;
using System;
using AlternatePods.Achievements;
using AlternatePods.Achievements.Shared;

namespace AlternatePods
{
    public class RoboPod : PodModPodBase
    {
        public override string PodName => "RoboPod";
        public override string PodToken => "PODMOD_SHARED_NOPOD";
        public override Texture2D Icon => null;
        public override BaseModdedAchievement Achievement => new SharedStartRunAsToolbotAchievement();

        public override GameObject CreatePodPrefab()
        {
            var podPrefabInstance = PrefabAPI.InstantiateClone(Assets.roboCratePodPrefab, PodName, true);
            PodPrefab = podPrefabInstance;
            return podPrefabInstance;
        }

    }
}