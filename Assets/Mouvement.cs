using UnityEngine;

public class Mouvement : MonoBehaviour {
    public Rigidbody rb;

    private const float VELOCITY = 0.15f;
    private const float JUMP_FORCE = 5f;

    private bool jump_is_enable;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        jump_is_enable = true;
    }

    bool IsGrounded()
    {
        return Mathf.Abs(rb.linearVelocity.y) < 0.0001f;
    }

    void Update()
    {
        float velocity = Input.GetKey(KeyCode.LeftShift) ? VELOCITY * 2.5f : VELOCITY;

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.back * velocity);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * velocity);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.up, -2);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up, 2);
        }

        if (Input.GetKey(KeyCode.Space) && IsGrounded())
        {
            if (jump_is_enable)
            {
                jump_is_enable = false;
                rb.AddForce(transform.up * JUMP_FORCE, ForceMode.VelocityChange);
            }
        }
        else
        {
            jump_is_enable = true;
        }
    }
}





// using UnityEngine;

// public class Mouvement : MonoBehaviour {
//     public Rigidbody rb;
	
//     private const float VELOCITY = 0.15f;
//     private const float JUMP_FORCE = 5f;

//     private bool jump_is_enable;
//     private int position=1; // 1 face à nous, 2 dos, 3 gauche, 4 droite;
//     void Start()
//     {
//         rb = GetComponent<Rigidbody>();
//         jump_is_enable = true;
//     }

//     bool IsGrounded()
//     {
//         return Mathf.Abs(rb.linearVelocity.y) < 0.0001f;
//     }

//     void Update()
//     {
//         float velocity = Input.GetKey(KeyCode.LeftShift) ? VELOCITY * 2.5f : VELOCITY;

//         if (Input.GetKey(KeyCode.DownArrow)&& (!Input.GetKey(KeyCode.LeftArrow) || !Input.GetKey(KeyCode.RightArrow)))
//         {
//             if (position != 1)
//             {
//                 if (position == 2)
//                 {
//                     transform.Rotate(Vector3.up, -30);
//                 }
//                 else if (position == 3)
//                 {
//                     transform.Rotate(Vector3.up, -15);
//                 }
//                 else if (position == 4)
//                 {
//                     transform.Rotate(Vector3.up, 15);
//                 }
//                 else
//                 {
//                     Debug.Log("Position incomprise");
//                 }
//                 position = 1;
//             }
//             transform.Translate(Vector3.forward * velocity);
//         }

//         if (Input.GetKey(KeyCode.UpArrow) && (!Input.GetKey(KeyCode.LeftArrow) || !Input.GetKey(KeyCode.RightArrow)))
//         {
//             if (position != 2)
//             {
//                 if (position == 1)
//                 {
//                     transform.Rotate(Vector3.up, -30);
//                 }
//                 else if (position == 3)
//                 {
//                     transform.Rotate(Vector3.up, 15);
//                 }
//                 else if (position == 4)
//                 {
//                     transform.Rotate(Vector3.up, -15);
//                 }
//                 else
//                 {
//                     Debug.Log("Position incomprise");
//                 }
//                 position = 2;
//             }
//             transform.Translate(Vector3.forward * velocity);
//         }

//         if (Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.UpArrow))
//         {if (position != 3)
//             {
//                 if (position == 1)
//                 {
//                     transform.Rotate(Vector3.up, 15);
//                 }
//                 else if (position == 2)
//                 {
//                     transform.Rotate(Vector3.up, -15);
//                 }
//                 else if (position == 4)
//                 {
//                     transform.Rotate(Vector3.up, -30);
//                 }
//                 else
//                 {
//                     Debug.Log("Position incomprise");
//                 }
//                 position = 3;
//             }
//             transform.Translate(Vector3.forward * velocity);
//             //transform.Rotate(Vector3.up, -15);
//         }

//         if (Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.UpArrow))
//         {
//             if (position != 4)
//             {
//                 if (position == 1)
//                 {
//                     transform.Rotate(Vector3.up, -15);
//                 }
//                 else if (position == 2)
//                 {
//                     transform.Rotate(Vector3.up, 15);
//                 }
//                 else if (position == 3)
//                 {
//                     transform.Rotate(Vector3.up, -30);
//                 }
//                 else
//                 {
//                     Debug.Log("Position incomprise");
//                 }
//                 position = 4;
//             }
//             transform.Translate(Vector3.forward * velocity);
//             //transform.Rotate(Vector3.up, 15);
//         }
		
// 		// if (Input.GetKey(KeyCode.LeftArrow))
//         // {
//         //     transform.Rotate(Vector3.up, -15);
//         // }

//         // if (Input.GetKey(KeyCode.RightArrow))
//         // {
//         //     transform.Rotate(Vector3.up, 15);
//         // }
        
//         if (Input.GetKey(KeyCode.Space) && IsGrounded())
//         {
//             if (jump_is_enable)
//             {
//                 jump_is_enable = false;
//                 rb.AddForce(transform.up * JUMP_FORCE, ForceMode.VelocityChange);
//             }
//         }
//         else
//         {
//             jump_is_enable = true;
//         }
//     }
// }