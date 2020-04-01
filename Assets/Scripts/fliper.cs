using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fliper : MonoBehaviour
{
    private SpriteRenderer sprite;
    private inputController input;
    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        input = GetComponent<inputController>();
    }

    // Update is called once per frame
    void Update()
    {
        if( input.facedir.x < 0 ) sprite.flipX = true;
        else sprite.flipX = false;
    }
}
