using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateController_Jarren : MonoBehaviour
{
    Animator animator;
    public AudioSource movementSound;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        bool forward = Input.GetKey("w");
        bool moving = Input.GetKeyDown("w");

        if(forward)
        {
            animator.SetBool("isFloating", true);
        }

        if(moving)
        {
            movementSound.Play();
        }

        if (!forward) 
        {
            animator.SetBool("isFloating", false);
            
        }
    }
}
