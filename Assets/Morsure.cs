// using System.Collections;
// using System.Collections.Generic;
// using System.Diagnostics;
// using UnityEngine;


// public class Morsure : MonoBehaviour
// {
//     private float date_prochaine_attaque=0;
//     void Start()
//     {

//     }

//     void Update()
//     {

//     }

//     private void OnCollisionEnter(Collision collision)
//     {
//         if (!collision.gameObject.CompareTag("Aggro"))
//         {
//             Morsures(collision);
//         }
//     }

//     private void OnCollisionStay(Collision collision)
//     {
//         if (!collision.gameObject.CompareTag("Aggro"))
//         {
//             Morsures(collision);
//         }
//     }

//     private void Morsures(Collision collision)
//     {
//         if (Time.time < date_prochaine_attaque) return;

//         SystemeDeSante systemedesante = collision.gameObject.GetComponent<SystemeDeSante>();
//         if (systemedesante != null && collision.gameObject != null)
//         {
//             systemedesante.TakeDamage(10f);
//             date_prochaine_attaque = Time.time + 0.7f;
//         }


//     }
    
// }

using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;


public class Morsure : MonoBehaviour
{
    private float date_prochaine_attaque=0;
    void Start()
    {

    }

    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag("Aggro"))
        {
            if (collision.gameObject.CompareTag("Joueur"))
            {
                Morsures_Joueur(collision);
            }
            Morsures(collision);
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (!collision.gameObject.CompareTag("Aggro"))
        {
            Morsures(collision);
        }
    }

    private void Morsures(Collision collision)
    {
        if (Time.time < date_prochaine_attaque) return;

        SystemeDeSante systemedesante = collision.gameObject.GetComponent<SystemeDeSante>();
        if (systemedesante != null && collision.gameObject != null)
        {
            systemedesante.TakeDamage(10f);
            date_prochaine_attaque = Time.time + 0.7f;
        }


    }
    
    private void Morsures_Joueur(Collision collision)
    {
        SystemeDeSante systemedesante = collision.gameObject.GetComponent<SystemeDeSante>();
        if (systemedesante != null && collision.gameObject!=null)
        {
            systemedesante.TakeDamage(10f);
        }
    }
}