using R2API;
using RoR2;
using UnityEngine;
using System.Collections.Generic;
using BepInEx.Configuration;
using UnityEngine.AddressableAssets;
using AlternatePods.ROR2_Survivors.Commando;

namespace AlternatePods
{
    public class CommandoMain : PodModCharBase
    {
        public override GameObject BodyPrefab => 
            Addressables.LoadAssetAsync<GameObject>("RoR2/Base/Commando/CommandoBody.prefab").WaitForCompletion();
        public override void AddPodsToPodChar()
        {
            PodBases.Add(new CommandoFakerPod());
            PodBases.Add(new CommandoLogisticsPod());
            PodBases.Add(new CommandoMasteryPod());
            PodBases.Add(new CommandoRiskyPod());
        }

        public override void Init()
        {
            base.Init();
        }
    }
}