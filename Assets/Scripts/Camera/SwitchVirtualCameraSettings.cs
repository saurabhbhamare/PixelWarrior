using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class SwitchVirtualCameraSettings : MonoBehaviour
{
    public static SwitchVirtualCameraSettings Instance = null;
    public int priority = 10;
    public bool broadView = false;

    public CinemachineVirtualCamera virtualCameraForVineSet;
    public void Awake()
    {
        if(Instance== null)
        {
            Instance = this;
        }
        else if(Instance != this)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }
    public void UpdateVirtualCameraView()
    {
        broadView = !broadView;
        if(broadView)
        {
            virtualCameraForVineSet.Priority = priority;
        }
        else
        {
            virtualCameraForVineSet.Priority = 8;
        }
       
    }

}
