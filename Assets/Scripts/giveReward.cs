using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class giveReward : MonoBehaviour
{
    [SerializeField] private Sprite rwd;
    // Start is called before the first frame update
   public void giveChestReward()
   {
       inventory inv;
       inv = GameManager.instance.player.GetComponent<inventory>();
       inv.getSelection(rwd);
   }
}
