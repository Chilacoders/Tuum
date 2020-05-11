using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floatingText : MonoBehaviour
{
    public string sortingLayer = "Textos";

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Renderer>().sortingLayerName = sortingLayer;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
