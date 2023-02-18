using R2API;
using RoR2;
using UnityEngine;
using System.Collections.Generic;
using BepInEx.Configuration;
using UnityEngine.AddressableAssets;

namespace AlternatePods
{
    public class HuntressMain : PodModCharBase
    {
        public override GameObject BodyPrefab => 
            Addressables.LoadAssetAsync<GameObject>("RoR2/Base/Huntress/HuntressBody.prefab").WaitForCompletion();
        public override void AddPodsToPodChar()
        {
        }

        public override void Init()
        {
            base.Init();
        }
    }
}