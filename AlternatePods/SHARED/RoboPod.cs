using R2API;
using RoR2;
using UnityEngine;
using System.Collections.Generic;
using BepInEx.Configuration;
using UnityEngine.AddressableAssets;
using System;

namespace AlternatePods
{
    public class RoboPod : PodModPodBase
    {
        public override string podName => "RoboPod";
        public override string podToken => "PODMOD_SHARED_NOPOD";
        public override Texture2D icon => null;

        public override GameObject CreatePodPrefab()
        {
            var podPrefabInstance = PrefabAPI.InstantiateClone(Assets.roboCratePodPrefab, podName, true);
            podPrefab = podPrefabInstance;
            return podPrefabInstance;
        }

    }
}