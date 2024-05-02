using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TPSCamera : MonoBehaviour
{
    [SerializeField]
    Transform target;
    Vector3 offSetCamera;

    [Range(0.01f, 1f)]
    [SerializeField]
    float smooth;

    // Start is called before the first frame update
    void Start()
    {
        offSetCamera = transform.position - target.position;
        
    }

    private void LateUpdate()
    {
        Vector3 camPosit = target.position + offSetCamera;
        Vector3 smoothPosit = Vector3.Lerp(transform.position, camPosit, smooth);
        transform.position = smoothPosit;
        transform.LookAt(target);
    }
}
