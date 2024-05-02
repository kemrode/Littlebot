using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bookScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            bookScore.instance.AddBook(1);
            GetComponent<MeshRenderer>().enabled = false;
            GetComponent<BoxCollider>().enabled = false;
            Destroy(gameObject, 2f);
            GetComponent<AudioSource>().Play();
        }
    }
}
