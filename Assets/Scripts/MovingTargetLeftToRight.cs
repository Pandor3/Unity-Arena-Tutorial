using UnityEngine;

public class MovingTargetLtR : MonoBehaviour
{
    public float speed = 2f;
    public float moveDistance = 5f;

    private Vector3 startPosition;
    private bool movingLeft = true;

    void Start()
    {
        startPosition = transform.position;   
    }

    void Update()
    {
        if (movingLeft)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
            if (transform.position.x <= startPosition.x - moveDistance)
            {
                movingLeft = false;
            }
        }
        else 
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
            if (transform.position.x >= startPosition.x + moveDistance)
            {
                movingLeft = true;
            }
        }
    }
}
