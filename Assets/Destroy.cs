using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    float Timer = 10;
    
    void Start()
    {
        
    }

    void Update()
    {
        if (gameObject.transform.position.y < 0.3)
        {
            Destroy(gameObject);
        }
        if (Timer > 0)
        {
            Timer -= Time.deltaTime;
        }

        if (Timer < 0)
        {
            Destroy(gameObject);
        }
    }
}
