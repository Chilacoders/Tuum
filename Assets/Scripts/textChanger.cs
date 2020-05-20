using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class textChanger : MonoBehaviour
{
    public Text txt;
    public string instructions;
    public string exit;
    // Start is called before the first frame update
    void Start()
    {
        txt = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if(textManager.instance.activatedTexts < 2)
        {
            txt.text = instructions;
        }
        else
        {
            txt.text = exit;
        }
    }
}
