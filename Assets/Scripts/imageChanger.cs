using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class imageChanger : MonoBehaviour
{
    private Image img;
    [SerializeField] private int id;
    // Start is called before the first frame update
    void Start()
    {
        img = GetComponent<Image>();
        img.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        inventory inv;
        inv = GameManager.instance.player.GetComponent<inventory>();

        switch(id)
        {
            case 0:
                if(inv.selection1)
                {
                    img.sprite = inv.selection1;
                    img.enabled = true;
                }
            break;

            case 1:
                if(inv.selection2)
                {
                    img.sprite = inv.selection2;
                    img.enabled = true;
                }
            break;

            case 2:
                if(inv.selection3)
                {
                    img.sprite = inv.selection3;
                    img.enabled = true;
                }
            break;
        }
    }
}
