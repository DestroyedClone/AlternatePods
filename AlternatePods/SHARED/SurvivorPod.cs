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
        public override string PodName => "SurvivorPod";
        public override string PodToken => "PODMOD_SHARED_SURVIVORPOD";
        public override Texture2D Icon => null;
        public override UnlockableDef UnlockableDef => CreateUnlockableDef("PodMod.Shared.SurvivorPod", "PODMOD_STAYINPODFORONEMINUTE");

        public override GameObject CreatePodPrefab()
        {
            var podPrefabInstance = PrefabAPI.InstantiateClone(Assets.genericPodPrefab, PodName, true);
            PodPrefab = podPrefabInstance;
            return podPrefabInstance;
        }

    }
}