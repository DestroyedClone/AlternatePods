using R2API;
using RoR2;
using UnityEngine;
using System.Collections.Generic;
using BepInEx.Configuration;
using UnityEngine.AddressableAssets;
using System;
using AlternatePods.Achievements;
using AlternatePods.Achievements.Shared;

namespace AlternatePods
{
    public class PaintJob : PodModPodBase
    {
        public override string PodName => "PaintJob";
        public override string PodToken => "PODMOD_SHARED_PAINTJOB";
        public override Texture2D Icon => null;
        public override BaseModdedAchievement Achievement => new SharedClearGameMonsoonWithAlternateSkinAchievement();

        public override GameObject CreatePodPrefab()
        {
            var podPrefabInstance = PrefabAPI.InstantiateClone(Assets.genericPodPrefab, PodName, true);
            //var childLoc = pod.transform.Find("Base/mdlEscapePod").GetComponent<ChildLocator>();

            var podObj = podPrefabInstance.transform.Find("Base/mdlEscapePod/EscapePodArmature/Base/EscapePodMesh");
            var meshFilter = podObj.GetComponent<MeshFilter>();
            var meshRenderer = podObj.GetComponent<MeshRenderer>();
            var module = podObj.gameObject.AddComponent<PodMod_PaintJobModule>();
            module.meshFilter = meshFilter;
            module.meshRenderer = meshRenderer;
            module.vehicleSeat = podPrefabInstance.GetComponent<VehicleSeat>();
            PodPrefab = podPrefabInstance;
            return podPrefabInstance;
        }

        public class PodMod_PaintJobModule : MonoBehaviour
        {
            public MeshFilter meshFilter;
            public MeshRenderer meshRenderer;
            public VehicleSeat vehicleSeat;
            public Material materialOverride = null;

            public void Start()
            {
                Material materialToSet = null;
                if (materialOverride)
                {
                    materialToSet = materialOverride;
                }
                else {
                    if (vehicleSeat && vehicleSeat.hasPassenger)
                    {
                        var body = vehicleSeat.currentPassengerBody;
                        
                        var bodySkin = SkinCatalog.GetSkinDef((SkinIndex)body.skinIndex);
                        //var bodyMat = body.modelLocator.modelTransform.GetComponent<ModelSkinController>().skins[body.skinIndex].meshReplacements[0].renderer.material;
                        var bodyMat = bodySkin.rendererInfos[0].defaultMaterial;
                        if (bodyMat == null)
                        {
                            bodyMat = body.modelLocator?.modelTransform?.GetComponent<ModelSkinController>()?.skins[body.skinIndex]?.meshReplacements[0].renderer?.material;
                        }
                        materialToSet = bodyMat;
                    }
                }
                meshRenderer.SetMaterialArray(new Material[]{materialToSet});
            }
        }

    }
}