using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncingBall : MonoBehaviour
{
    Vector3 velocity;
    Vector3 direction = new Vector3(1, 1, 0);
    float speed = 3;
    float radius = 0.25f; // Half of the ball's size
    Vector3 acceleration;

    Vector2 min, max;

    // Start is called before the first frame update
    void Start()
    {
        min = Camera.main.ScreenToWorldPoint(Vector2.zero);
        print(min.x + " en " + min.y);

        max = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
        print(max.x + " en " + max.y);

        acceleration = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        direction = direction.normalized;

        velocity = speed * direction;

        this.transform.position += velocity * Time.deltaTime;

        // Check for collision with screen edges and reverse direction if necessary
        if (transform.position.x - radius <= min.x || transform.position.x + radius >= max.x)
        {
            direction.x = -direction.x;
        }

        if (transform.position.y - radius <= min.y || transform.position.y + radius >= max.y)
        {
            direction.y = -direction.y;
        }
    }
}
