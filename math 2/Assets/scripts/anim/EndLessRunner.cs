using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndlessRunner : MonoBehaviour
{
    [SerializeField] GameObject Jumper;
    Animator animator;
    enum State { grounded, airborne }
    State myState = State.grounded;
    Vector3 velocity = Vector3.zero;
    Vector3 gravity = new Vector3(0, -9.8f, 0);
    float y0;
    void Start()
    {
        animator = GetComponent<Animator>();
        y0 = Jumper.transform.position.y;
    }

    void Update()
    {
        if (myState == State.grounded)
        {
            if (Input.GetMouseButtonUp(0))
            {
                animator.Play("jump");
<<<<<<< Updated upstream
<<<<<<< Updated upstream
                velocity = new Vector3(0, 5, 0); // Initial jump velocity
                gravity = new Vector3(0, -4, 0);  // Downward acceleration
=======
                velocity = new Vector3(0, 8f, 0);
>>>>>>> Stashed changes
=======
                velocity = new Vector3(0, 8f, 0);
>>>>>>> Stashed changes
                myState = State.airborne;
            }
        }

        if (myState == State.airborne)
        {
<<<<<<< Updated upstream
<<<<<<< Updated upstream
            velocity += gravity * Time.deltaTime; // Apply gravity to velocity
            Jumper.transform.position += velocity * Time.deltaTime; // Add velocity to position

=======
            velocity += gravity * Time.deltaTime;
            Jumper.transform.position += velocity * Time.deltaTime;
>>>>>>> Stashed changes
=======
            velocity += gravity * Time.deltaTime;
            Jumper.transform.position += velocity * Time.deltaTime;
>>>>>>> Stashed changes
            if (Jumper.transform.position.y <= y0)
            {
                // Reset position and state when grounded
                velocity = Vector3.zero;
                animator.Play("run");
                Jumper.transform.position = new Vector3(Jumper.transform.position.x, y0, 0);
                myState = State.grounded;
            }
        }
    }
<<<<<<< Updated upstream
<<<<<<< Updated upstream

}
=======
}
>>>>>>> Stashed changes
=======
}
>>>>>>> Stashed changes
