using UnityEngine;

public class SpriteMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Adjust this to change the speed of movement

    void Update()
    {
        // Get input from arrow keys
        float horizontalInput = Input.GetAxis("Horizontal");

        // Calculate movement amount based on input and speed
        float movement = horizontalInput * moveSpeed * Time.deltaTime;

        // Move the sprite
        transform.Translate(new Vector3(movement, 0, 0));

      //  if (horizontalInput)
      //  { animation.Play(WalkAnimRight); }
    }
}