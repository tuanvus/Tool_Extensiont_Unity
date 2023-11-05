using System.Collections;
using System.Collections.Generic;
using AnnulusGames.LucidTools.Inspector;
using UnityEngine;

public class Demo : MonoBehaviour
{
    [SerializeField] private AnimationHandle animationHandle;
    public List<ObjData> fxPreview;
    public int idPlay;
    void Start()
    {
        animationHandle = GetComponentInChildren<AnimationHandle>();
        animationHandle.Initialize();
        
    }
    [Button]
    public void PlayFx()
    {
        
    }
}
