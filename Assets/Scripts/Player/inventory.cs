using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventory : MonoBehaviour
{
    // Cantidad de llaves obtenidas
    public int keys {get; private set;} 
    
    //Variables para mostrar las selecciones hechas
    public Sprite selection1 {get; private set;}
    public Sprite selection2 {get; private set;}
    public Sprite selection3 {get; private set;}
    

    public void changeKeys(int cant)
    {
        keys += cant;
    }

    public void getSelection(Sprite sel)
    {
        if(!selection1)
        {
            selection1 = sel;
        }
        else 
        {
            if (!selection2)
            {
                selection2 = sel;
            }
            else
            {
                if(!selection3) selection3 = sel;
            }
        }
    }

    public void clearInventory()
    {
        keys = 0;
        selection1 = selection2 = selection3 = null;
    }
}
