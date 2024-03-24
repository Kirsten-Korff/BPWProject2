using UnityEngine;

public class SpriteMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Adjust this to change the speed of movement

    Animator m_Animator;

    void Start()
    {
        //Get the Animator attached to the GameObject you are intending to animate.
        m_Animator = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        // Get input from arrow keys
        float horizontalInput = Input.GetAxis("Horizontal");

        // Calculate movement amount based on input and speed
        float movement = horizontalInput * moveSpeed * Time.deltaTime;

        // Move the sprite
        transform.Translate(new Vector3(movement, 0, 0));

       if (horizontalInput <0)
        { m_Animator.SetTrigger("WalkLeft");}

        if (horizontalInput >0)
        { m_Animator.SetTrigger("WalkRight"); }
    }
}