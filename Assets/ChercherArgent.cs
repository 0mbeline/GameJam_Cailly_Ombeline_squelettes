using UnityEngine;

public class ChercherArgent : MonoBehaviour
{
    public GameObject ensemble_pieces;
    private GameObject Target;

    public float VELOCITY;
    void Start()
    {
        
    }

    void Update()
    {
        if (Target == null)
        {
            SelectPiece();
        }

        if (Target != null)
        {
            Vector3 direction = Target.transform.position - this.transform.position;
            direction.y = 0;
            direction = direction.normalized;

            transform.Translate(-VELOCITY *Vector3.forward);
            transform.rotation = Quaternion.LookRotation(-direction);
        }

    }
    void SelectPiece()
    {
        float min_distance = (float) 1e50;
        foreach (Transform child in ensemble_pieces.transform)
        {
            float distance = (transform.position - child.position).magnitude;
            if (distance < min_distance)
            {
                min_distance = distance;

                Target = child.gameObject;
            }
        }
    }
}
