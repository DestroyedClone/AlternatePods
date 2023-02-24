using R2API;
using RoR2;
using UnityEngine;
using System.Collections.Generic;
using BepInEx.Configuration;
using UnityEngine.AddressableAssets;
using AlternatePods.ROR2_Survivors.Loader;

namespace AlternatePods
{
    public class LoaderMain : PodModCharBase
    {
        public override GameObject BodyPrefab => 
            Addressables.LoadAssetAsync<GameObject>("RoR2/Base/Loader/LoaderBody.prefab").WaitForCompletion();
        public override void AddPodsToPodChar()
        {
            PodBases.Add(new LoaderMasteryPod());
            PodBases.Add(new LoaderRiskyPod());
            PodBases.Add(new LoaderTeslaPod());
        }

        public override void Init()
        {
            base.Init();
        }
    }
}