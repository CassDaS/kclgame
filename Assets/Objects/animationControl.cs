using UnityEngine;
public class animationControl : MonoBehaviour
{
    private Animator animator;
    private CharacterController controller;
    void Start()
    {
        animator = GetComponent<Animator>();
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
         Vector3 horizontalVelocity = controller.velocity;
        horizontalVelocity = new Vector3(controller.velocity.x, 0, controller.velocity.z);

        // The speed on the x-z plane ignoring any speed
        float horizontalSpeed = horizontalVelocity.magnitude;
        // The speed from gravity or jumping
        float verticalSpeed  = controller.velocity.y;
        // The overall speed
        float overallSpeed = controller.velocity.magnitude;
        
        if(overallSpeed > 0f){;
            animator.SetBool("iswalk", true);
        }
        else if(overallSpeed == 0f)
        {
            animator.SetBool("iswalk", false);
        }
    }

}
