using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textManager : MonoBehaviour
{

    public static textManager instance;
    public int activatedTexts; // Quantity of texts
    
    void OnEnable() {
        instance = this;
        
    }
    // Start is called before the first frame update
    void Start()
    {

        HideText();
    }

    private void HideText()
    {
        foreach (GameObject item in GameObject.FindGameObjectsWithTag("text"))
        {
            item.SetActive(false);
        }
    }

}
