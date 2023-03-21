using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInfo : MonoBehaviour
{

    public string ItemName;
    public int ItemValue;

    PlayerController playerScript;

    // Start is called before the first frame update
    void Start()
    {
        playerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseOver()
    {
        Debug.Log(ItemName);
        playerScript.itemText.text = ItemName;
    }

    void OnMouseDown()
    {
        playerScript.hasKey = true;
        Destroy(gameObject);
    }
}
