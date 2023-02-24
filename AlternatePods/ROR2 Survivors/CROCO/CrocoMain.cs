using R2API;
using RoR2;
using UnityEngine;
using System.Collections.Generic;
using BepInEx.Configuration;
using UnityEngine.AddressableAssets;
using AlternatePods.ROR2_Survivors.CROCO;

namespace AlternatePods
{
    public class CrocoMain : PodModCharBase
    {
        public override GameObject BodyPrefab => 
            Addressables.LoadAssetAsync<GameObject>("RoR2/Base/Croco/CrocoBody.prefab").WaitForCompletion();
        public override void AddPodsToPodChar()
        {
            PodBases.Add(new CrocoLorePod());
            PodBases.Add(new CrocoMasteryPod());
            PodBases.Add(new CrocoRiskyPod());
            PodBases.Add(new CrocoShippingPod());
            PodBases.Add(new CrocoVoidCellPod());
        }

        public override void Init()
        {
            base.Init();
        }
    }
}