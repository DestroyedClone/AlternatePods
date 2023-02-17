using R2API;
using RoR2;
using UnityEngine;
using System.Collections.Generic;
using BepInEx.Configuration;
using UnityEngine.AddressableAssets;

namespace AlternatePods
{
    public class HereticMain : PodModCharBase
    {
        public override GameObject bodyPrefab => 
            Addressables.LoadAssetAsync<GameObject>("RoR2/Base/Heretic/HereticBody.prefab").WaitForCompletion();
        public override void AddPodsToPodChar()
        {
        }

        public override void Init()
        {
            base.Init();
        }
    }
}