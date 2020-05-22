using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class keyTextM : MonoBehaviour
{
    // Start is called before the first frame update
    private Text txt;
    void Start()
    {
        txt = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        inventory inv;
        inv = GameManager.instance.player.GetComponent<inventory>();
        txt.text = inv.keys.ToString();
    }
}
