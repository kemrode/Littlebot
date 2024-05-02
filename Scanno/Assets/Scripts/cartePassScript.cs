using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cartePassScript : MonoBehaviour
{
    private void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
            GameObject.Find("zona").GetComponent<frigoSecretScript>().CanOpenSecret = true;
            GameObject.Find("Littlebot").GetComponent<LittlebotDiscours>().tellFindCard();
            gameObject.GetComponent<MeshRenderer>().enabled = false;
            gameObject.GetComponent<BoxCollider>().enabled = false;
            Destroy(transform.parent.gameObject, 2f);
        }
    }
}
