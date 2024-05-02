using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class greenLightScript : MonoBehaviour
{
    public bool coinGreen = false;
    public bool bookGreen = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
        if(coinGreen && bookGreen)
        {
            GetComponent<Light>().color = Color.green;
        }
    }
}
