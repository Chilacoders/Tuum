using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textManager : MonoBehaviour
{
    public GameObject[] texts;
    public static textManager instance;
    public int activatedTexts; // Quantity of texts
    
    void OnEnable() {
        instance = this;
        
    }
    // Start is called before the first frame update
    void Start()
    {
        texts = GameObject.FindGameObjectsWithTag("text");
        HideText();
    }

    private void HideText()
    {
        foreach (GameObject item in texts)
        {
            item.SetActive(false);
        }
    }

}
