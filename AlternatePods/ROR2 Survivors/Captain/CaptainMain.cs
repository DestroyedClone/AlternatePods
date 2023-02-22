using R2API;
using RoR2;
using UnityEngine;
using System.Collections.Generic;
using BepInEx.Configuration;
using UnityEngine.AddressableAssets;

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
    }
}