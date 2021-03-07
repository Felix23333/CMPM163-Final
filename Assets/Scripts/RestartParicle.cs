using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartParicle : MonoBehaviour
{
    public float time = 14;
    int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        count++;
        if(count >= time * 50)
        {
            GetComponent<ParticleSystem>().Stop();
            GetComponent<ParticleSystem>().Play();
            count = 0;
        }
    }
}
