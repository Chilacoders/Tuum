using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exitChest : MonoBehaviour
{
   public GameObject exit;

    // Update is called once per frame

    void Update()
    {
        Debug.Log("Exec");
        if(!GameManager.instance.player.GetComponent<inventory>().selection3)
        {
            exit.gameObject.SetActive(true);
        }    
        else
        {
            exit.gameObject.SetActive(false);
        }
    }
}
