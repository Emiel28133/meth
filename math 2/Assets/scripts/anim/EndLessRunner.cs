using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndlessRunner : MonoBehaviour
{
    [SerializeField] GameObject Jumper;
    Animator animator;
    enum State { grounded, airborne }
    State myState = State.grounded;
    float time = 0;
    Vector3 velocity = Vector3.zero;
    Vector3 gravity = Vector3.zero;
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
                velocity = new Vector3(0, 800, 0);
                gravity = new Vector3(0, -400, 0);
                myState = State.airborne;
            }
        }

        if (myState == State.airborne)
        {

            velocity += gravity * Time.deltaTime;
            Jumper.transform.position = velocity * Time.deltaTime;
            if(Jumper.transform.position.y <= y0)
            {
                velocity = Vector3.zero;
                gravity = Vector3.zero;
                animator.Play("run");
                Jumper.transform.position = new Vector3(Jumper.transform.position.x, y0, 0);
                myState = State.grounded;
            }
        }
    }
}