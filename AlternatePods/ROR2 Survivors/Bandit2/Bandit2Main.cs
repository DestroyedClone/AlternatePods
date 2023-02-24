using R2API;
using RoR2;
using UnityEngine;
using System.Collections.Generic;
using BepInEx.Configuration;
using UnityEngine.AddressableAssets;
using AlternatePods.ROR2_Survivors.Bandit2;
using AlternatePods.ROR2_Survivors;

namespace AlternatePods
{
    public class Bandit2Main : PodModCharBase
    {
        public override GameObject BodyPrefab => 
            Addressables.LoadAssetAsync<GameObject>("RoR2/Base/Bandit2/Bandit2Body.prefab").WaitForCompletion();
        public override void AddPodsToPodChar()
        {
            PodBases.Add(new Bandit2CowboyPod());
            PodBases.Add(new Bandit2GamblerPod());
            PodBases.Add(new Bandit2LorePod());
            PodBases.Add(new Bandit2MasteryPod());
            PodBases.Add(new Bandit2RiskyPod());
        }

        public override void Init()
        {
            base.Init();
        }
    }
}