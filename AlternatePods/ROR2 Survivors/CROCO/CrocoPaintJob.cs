using R2API;
using RoR2;
using UnityEngine;
using System.Collections.Generic;
using BepInEx.Configuration;
using UnityEngine.AddressableAssets;
using System;

namespace AlternatePods
{
    public class CrocoPaintJob : PodModPodBase
    {
        public override string PodName => "PaintJobCroco";
        public override string PodToken => "PODMOD_SHARED_DEFAULT";
        public override Texture2D Icon => Addressables.LoadAssetAsync<Texture2D>("RoR2/Base/Croco/CrocoBody.png").WaitForCompletion();

        public override GameObject CreatePodPrefab()
        {
            return CreatePodRecolor(PodName, "RoR2/Base/Croco/matCroco.mat");
        }
    }
}