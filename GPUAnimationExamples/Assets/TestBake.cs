using System;
using Unity.GPUAnimation;
using UnityEngine;
namespace DefaultNamespace
{
    public class TestBake : MonoBehaviour
    {
        public GameObject characterRig;
        public int framerate = 60;
        public AnimationClip[] clips;

        public KeyframeTextureBaker.BakedData bakedData;
        public Texture2D te1;
        public Texture2D te2;
        public Texture2D te3;
        
        private void Awake()
        {
            var renderer = characterRig.GetComponentInChildren<SkinnedMeshRenderer>();
            var lod = new LodData
            {
                Lod1Mesh = renderer.sharedMesh,
                Lod2Mesh = renderer.sharedMesh,
                Lod3Mesh = renderer.sharedMesh,
                Lod1Distance = 0,
                Lod2Distance = 100,
                Lod3Distance = 10000,
            };
            bakedData = KeyframeTextureBaker.BakeClips(characterRig, clips, framerate, lod);
            te1 = bakedData.AnimationTextures.Animation0;
            te2 = bakedData.AnimationTextures.Animation1;
            te3 = bakedData.AnimationTextures.Animation2;
        }
    }
}