using UnityEngine;

public class Poursuite : MonoBehaviour
{
    public GameObject Target;
    private const float VELOCITY = 0.02f;

    void Start()
    {
        
    }

    void Update()
    {
        if (Target != null) {
            Vector3 direction = Target.transform.position - this.transform.position;
            direction.y = 0;

            transform.position += VELOCITY * direction / direction.magnitude;
            transform.rotation = Quaternion.LookRotation(-direction);
        }
    }
}
