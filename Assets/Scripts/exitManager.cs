using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exitManager : MonoBehaviour
{
    public GameObject exit;
    // Update is called once per frame
    void Update()
    {
        if(textManager.instance.activatedTexts < 2)
        {
            exit.gameObject.SetActive(true);
        }    
        else
        {
            exit.gameObject.SetActive(false);
        }
    }
}
