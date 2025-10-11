using UnityEngine;

public class Gravity : MonoBehaviour
{
    public Rigidbody rb;

    private const float G_VALUE = 9.81f;
    private Vector3 G;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        G = new Vector3(0f, -G_VALUE, 0f);
    }

    void Update()
    {
        rb.AddForce(rb.mass * G);
    }
}
