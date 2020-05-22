using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyactions : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other) {
        if(GameManager.instance.player == other.gameObject)
        {
            inventory inv = other.gameObject.GetComponent<inventory>();
            inv.changeKeys(1);
            Destroy(this.gameObject);
        }
    }
}
