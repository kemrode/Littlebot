using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frigoSecretScript : MonoBehaviour
{
    public bool CanOpenSecret = false;

    [SerializeField]
    AudioClip soundOpen;

    private AudioSource doorAudioSource;

    private void Awake()
    {
        doorAudioSource = GetComponent<AudioSource>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player" && CanOpenSecret)
        {
            doorAudioSource.PlayOneShot(soundOpen);
            GameObject.Find("frigoVert").GetComponent<Animator>().enabled = true;
            GameObject.Find("Littlebot").GetComponent<LittlebotDiscours>().tellSecret();
            gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }
}
