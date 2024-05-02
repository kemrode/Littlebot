using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZbotAudioScript : MonoBehaviour
{
    [SerializeField]
    float seeToTalk = 10f;

    [SerializeField]
    float attackPosit = 3.5f;


    [SerializeField]
    AudioClip clip;

    private AudioSource seeLittlebot;
    Transform target;
    NavMeshAgent agent;

    private void Awake()
    {
        seeLittlebot = GetComponent<AudioSource>();
    }
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if(agent.remainingDistance <= seeToTalk && agent.remainingDistance > attackPosit)
        {
            seeLittlebot.playOnAwake = false;
            seeLittlebot.loop = false;
            seeLittlebot.volume = 0.05f;
            seeLittlebot.PlayOneShot(clip);
        } else
        {
            seeLittlebot.Stop();
        }
    }
}
