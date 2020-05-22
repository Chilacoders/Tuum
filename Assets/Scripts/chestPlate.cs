using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chestPlate : MonoBehaviour
{
    [SerializeField] private bool status;
    [SerializeField] private GameObject txt;
    [SerializeField] private GameObject chest;
    private Animator anim;
    private int openingChestHash;

    private void Start() 
    {
        anim = chest.GetComponent<Animator>();
        openingChestHash = Animator.StringToHash("open");
        txt.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject == GameManager.instance.player )
        {
           txt.SetActive(true);
        }
    }

    private void OnTriggerStay2D(Collider2D other) 
    {
        inputController input;
        inventory inv;
        if(other.gameObject == GameManager.instance.player )
        {
            input = other.gameObject.GetComponent<inputController>();
            inv = other.gameObject.GetComponent<inventory>();
            if(input.action)
            {
                if(status && inv.keys > 0)
                {
                    status = false;
                    inv.changeKeys(-1);
                    anim.SetTrigger(openingChestHash);
                }
            }
        }
    }


    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject == GameManager.instance.player )
        {
            txt.SetActive(false);
        }
    }

}
