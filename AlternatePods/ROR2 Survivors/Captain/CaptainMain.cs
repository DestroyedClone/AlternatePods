using R2API;
using RoR2;
using UnityEngine;
using System.Collections.Generic;
using BepInEx.Configuration;
using UnityEngine.AddressableAssets;
using AlternatePods.ROR2_Survivors.Captain;

namespace AlternatePods
{
    public class CaptainMain : PodModCharBase
    {
        public override GameObject BodyPrefab => 
            Addressables.LoadAssetAsync<GameObject>("RoR2/Base/Captain/CaptainBody.prefab").WaitForCompletion();

        public override void Init()
        {
            base.Init();
        }

        public override void AddPodsToPodChar()
        {
            PodBases.Add(new CaptainMasteryPod());
            PodBases.Add(new CaptainPiratePod());
            PodBases.Add(new CaptainSecretPod());
        }
    }
}