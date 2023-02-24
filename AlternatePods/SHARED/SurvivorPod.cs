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
    public class SurvivorPod : PodModPodBase
    {
        public override string PodName => "SurvivorPod";
        public override string PodToken => "PODMOD_SHARED_SURVIVORPOD";
        public override Texture2D Icon => null;
        public override BaseModdedAchievement Achievement => new SharedStayInPodForOneMinuteAchievement();

        public override GameObject CreatePodPrefab()
        {
            var podPrefabInstance = PrefabAPI.InstantiateClone(Assets.genericPodPrefab, PodName, true);
            PodPrefab = podPrefabInstance;
            return podPrefabInstance;
        }

    }
}