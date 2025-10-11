using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Morsure : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {

    }
    
    private void OnCollisionEnter(Collision collision)
    {
        SystemeDeSante systemedesante = collision.gameObject.GetComponent<SystemeDeSante>();
        if (systemedesante != null)
        {
            systemedesante.TakeDamage(10f);
        }
    }
}