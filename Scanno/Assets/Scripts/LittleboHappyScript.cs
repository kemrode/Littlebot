using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LittleboHappyScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            GameObject.Find("Littlebot").GetComponent<LittlebotDiscours>().tellItIsHappy();
            GetComponent<BoxCollider>().enabled = false;
        }
    }
}
