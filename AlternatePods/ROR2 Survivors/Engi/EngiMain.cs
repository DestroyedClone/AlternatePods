using R2API;
using RoR2;
using UnityEngine;
using System.Collections.Generic;
using BepInEx.Configuration;
using UnityEngine.AddressableAssets;
using AlternatePods.ROR2_Survivors.Engi;

namespace AlternatePods
{
    public class EngiMain : PodModCharBase
    {
        public override GameObject BodyPrefab => 
            Addressables.LoadAssetAsync<GameObject>("RoR2/Base/Engi/EngiBody.prefab").WaitForCompletion();
        public override void AddPodsToPodChar()
        {
            PodBases.Add(new EngiDronePod());
            PodBases.Add(new EngiHumanPod());
            PodBases.Add(new EngiMasteryPod());
            PodBases.Add(new EngiRiskyPod());
            PodBases.Add(new EngiTechPod());
        }

        public override void Init()
        {
            base.Init();
        }
    }
}