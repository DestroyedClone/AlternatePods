using R2API;
using RoR2;
using UnityEngine;
using System.Collections.Generic;
using BepInEx.Configuration;
using UnityEngine.AddressableAssets;
using AlternatePods.ROR2_Survivors.Mage;

namespace AlternatePods
{
    public class MageMain : PodModCharBase
    {
        public override GameObject BodyPrefab => 
            Addressables.LoadAssetAsync<GameObject>("RoR2/Base/Mage/MageBody.prefab").WaitForCompletion();
        public override void AddPodsToPodChar()
        {
            PodBases.Add(new MageAdaptivePod());
            PodBases.Add(new MageAntiHealPod());
            PodBases.Add(new MageBluePod());
            PodBases.Add(new MageFirePod());
            PodBases.Add(new MageGhostPod());
            PodBases.Add(new MageHealingPod());
            PodBases.Add(new MageIcePod());
            PodBases.Add(new MagePerfectPod());
        }

        public override void Init()
        {
            base.Init();
        }
    }
}