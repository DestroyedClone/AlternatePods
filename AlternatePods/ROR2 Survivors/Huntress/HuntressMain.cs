using R2API;
using RoR2;
using UnityEngine;
using System.Collections.Generic;
using BepInEx.Configuration;
using UnityEngine.AddressableAssets;
using AlternatePods.ROR2_Survivors.Huntress;

namespace AlternatePods
{
    public class HuntressMain : PodModCharBase
    {
        public override GameObject BodyPrefab => 
            Addressables.LoadAssetAsync<GameObject>("RoR2/Base/Huntress/HuntressBody.prefab").WaitForCompletion();
        public override void AddPodsToPodChar()
        {
            PodBases.Add(new HuntressChecklistPod());
            PodBases.Add(new HuntressMasteryPod());
            PodBases.Add(new HuntressRiskyPod());
        }

        public override void Init()
        {
            base.Init();
        }
    }
}