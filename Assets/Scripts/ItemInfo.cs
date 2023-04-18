using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInfo : MonoBehaviour
{

    public string ItemName;
    // name of item 
    public int ItemValue;
    // how much item is worth

    PlayerController playerScript;

    // Start is called before the first frame update
    void Start()
    {
        playerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        // connecting player script to the item info script
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseOver()
    {
        Debug.Log(ItemName);
        //show key item name in debug menu
        //playerScript.itemText.text = ItemName;
        //changing the item display name to key 
    }

    void OnMouseDown()
    {
        playerScript.hasKey = true;
        // when mouse clicked on the key the player has the key is true
        Destroy(gameObject);
        // destroy when key is "picked up"
    }
}
