using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platecollider : MonoBehaviour
{
    public int plateid;
    [SerializeField] private bool status;
    private SpriteRenderer spriteR;
    public Sprite active;
    public Sprite unactive;
    

    private void Start() {
        spriteR = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject == GameManager.instance.player )
        {
            textManager.instance.texts[plateid].SetActive(true);
        }
    }

    private void OnTriggerStay2D(Collider2D other) 
    {
        inputController input;
        if(other.gameObject == GameManager.instance.player )
        {
            input = other.gameObject.GetComponent<inputController>();
            if(input.action)
            {
                if(status)
                {
                    status = false;
                    ChangeAnswerQuantity();
                    return;
                }
                else if(textManager.instance.activatedTexts < 2)
                {
                    status = true;
                    ChangeAnswerQuantity();
                }
            }
        }
    }

    private void ChangeAnswerQuantity()
    {
        if(status)
        {
            textManager.instance.activatedTexts++;
        }
        else
        {
            textManager.instance.activatedTexts--;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject == GameManager.instance.player )
        {
            textManager.instance.texts[plateid].SetActive(false);
        }
    }

    private void Update() {
        if(status)
        {
            spriteR.sprite = active;
        }
        else
        {
            spriteR.sprite = unactive;
        }
    }
}
