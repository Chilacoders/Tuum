using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraManager : MonoBehaviour
{
    public CinemachineVirtualCamera cv;
    public Transform plr;

	// Use this for initialization
	void Start () {
		cv = GetComponent<CinemachineVirtualCamera>();

	}

    void Update() {
        if(!plr) 
        {
            plr = GameManager.instance.player.transform;
            cv.m_Follow = plr;
        }
    }

	
}
