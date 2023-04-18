using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{

    PlayerController playerScript;

    // Start is called before the first frame update
    void Start()
    {
        playerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        //connceting player script to door open script
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        if(playerScript.hasKey == true)
        {
            // if statement for having the key the player can unlock door
            Destroy(gameObject);
            // destroy the door
        }
    }
}
