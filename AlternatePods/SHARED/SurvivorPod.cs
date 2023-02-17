using R2API;
using RoR2;
using UnityEngine;
using System.Collections.Generic;
using BepInEx.Configuration;
using UnityEngine.AddressableAssets;
using System;

namespace AlternatePods
{
    public class SurvivorPod : PodModPodBase
    {
        public override string podName => "SurvivorPod";
        public override string podToken => "PODMOD_SHARED_SURVIVORPOD";
        public override Texture2D icon => null;

        public override GameObject CreatePodPrefab()
        {
            var podPrefabInstance = PrefabAPI.InstantiateClone(Assets.genericPodPrefab, podName, true);
            podPrefab = podPrefabInstance;
            return podPrefabInstance;
        }

    }
}