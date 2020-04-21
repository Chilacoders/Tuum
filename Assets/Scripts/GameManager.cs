using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject respawn;
    public GameObject malePlayer;
    public GameObject femalePlayer;
    public GameObject player;
    private string selection;
    
    
    void Start()
    {
        
        selection = PlayerPrefs.GetString("Seleccion");
        respawn = GameObject.FindGameObjectWithTag("Respawn");
        //Create Player
        CreatePlayer();
        
    }

    void OnEnable() {
        instance = this;
        
    }
    private void CreatePlayer()
    {
         if(!player)
        {
            switch(selection)
            {
                case "Male":
                    player = (GameObject)Instantiate(malePlayer,respawn.transform.position,respawn.transform.rotation);
                    break;

                case "Female":
                    player = (GameObject)Instantiate(femalePlayer,respawn.transform.position,respawn.transform.rotation);
                    break;
            }
        }

    }

}
