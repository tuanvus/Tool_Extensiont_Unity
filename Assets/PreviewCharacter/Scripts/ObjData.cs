using System.Collections;
using System.Collections.Generic;
using Spine.Unity;
using UnityEngine;

[System.Serializable]
public class ObjData 
{
    public bool isLoop;
    
    [SpineAnimation] public string nameAnimation;
    [SerializeField, SpineEvent] public string eventAnimation;
    [SerializeField, SpineEvent] public string eventAnimationHide;
    [SerializeField] public ParticleSystem fx;
    

}

[System.Serializable]
public class FxPreview
{
    public bool isLoop;
    [SerializeField, SpineEvent] public string eventAnimation;
    [SerializeField] public ParticleSystem fx;
}