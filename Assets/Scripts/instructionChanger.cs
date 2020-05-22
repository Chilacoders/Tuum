using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class instructionChanger : MonoBehaviour
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
        inventory inv;
        inv = GameManager.instance.player.GetComponent<inventory>();
        if(!inv.selection3)
        {
            txt.text = instructions;
        }
        else
        {
            txt.text = exit;
        }
    }
}
