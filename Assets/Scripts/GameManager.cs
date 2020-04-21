using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject respawn;
    public GameObject malePlayer;
    public GameObject femalePlayer;
    private string selection;
    
    void Start()
    {
        selection = PlayerPrefs.GetString("Seleccion");
        respawn = GameObject.FindGameObjectWithTag("Respawn");
        
        CreatePlayer();
    }

    private void CreatePlayer()
    {
        switch(selection)
        {
            case "Male":
                Instantiate(malePlayer,respawn.transform);
                break;

             case "Female":
                Instantiate(femalePlayer,respawn.transform);
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
