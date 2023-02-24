using R2API;
using RoR2;
using UnityEngine;
using System.Collections.Generic;
using BepInEx.Configuration;
using UnityEngine.AddressableAssets;
using System;
using AlternatePods.Achievements;
using AlternatePods.Achievements.Shared;

namespace AlternatePods.SHARED
{
    public class NoPod : PodModPodBase
    {
        public override string PodName => "No Pod";

        public override string PodToken => "PODMOD_SHARED_NOPOD";

        public override Texture2D Icon => null;
        public override BaseModdedAchievement Achievement => new SharedPurchaseResultWithZeroCashAchievement();

        public override GameObject CreatePodPrefab()
        {
            return null;
        }
    }
}
