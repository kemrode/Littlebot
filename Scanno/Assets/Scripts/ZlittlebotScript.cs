using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class ZlittlebotScript : MonoBehaviour
{
    [SerializeField]
    private float walkSpeed = 1f;

    [SerializeField]
    Transform leftSensor;

    [SerializeField]
    Transform rightSensor;

    [SerializeField]
    float idlePosit = 20f;

    [SerializeField]
    float walkPosit = 15f;

    [SerializeField]
    float attackPosit = 3.5f;

    Transform target;
    NavMeshAgent agent;
    Animator zlittleAnimator;

    Ray rayonGauche;
    Ray rayonDroit;
    RaycastHit hitInfo;

    // Start is called before the first frame update
    void Start(){
        agent = GetComponent<NavMeshAgent>();
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        zlittleAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        this.sensorRay(rightSensor, Color.green, rayonDroit);
        this.sensorRay(leftSensor, Color.red, rayonGauche);

        if(agent.remainingDistance > walkPosit)
        {
            agent.speed = 0;
            zlittleAnimator.SetBool("isSawLittlebot", false);
            zlittleAnimator.SetBool("baston", false);
        } else
        {
            agent.speed = walkSpeed;
            zlittleAnimator.SetBool("isSawLittlebot", true);
            zlittleAnimator.SetBool("baston", false);

            if(agent.remainingDistance == attackPosit)
            {
                GameObject.Find("Littlebot").GetComponent<LittlebotDiscours>().tellTerror();
                print(zlittleAnimator.GetBool("baston"));
                agent.speed = 0;
                zlittleAnimator.SetBool("isSawLittlebot", true);
                zlittleAnimator.SetBool("baston", true);
            }
        }

        agent.SetDestination(target.position);
    }

    private void sensorRay(Transform sensor, Color colors, Ray rayon)
    {
        rayon = new Ray(sensor.position, transform.TransformDirection(Vector3.forward));

        if (Physics.Raycast(rayon, out hitInfo, Mathf.Infinity))
        {
            if (hitInfo.distance < 1)
            {
                float angle = Random.Range(100f, 300f);
                transform.Rotate(Vector3.up * angle);
            }
        }
        Debug.DrawRay(transform.position, Vector3.forward * 10, colors);
    }

    public void DamageToLittleBot()
    {

    }

    IEnumerator LooseGame()
    {
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene("gameOverScene");
    }
}
