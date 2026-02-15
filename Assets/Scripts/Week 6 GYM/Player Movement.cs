using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerMovement : MonoBehaviour
{
    public float Speed = 3f;
    public float RotationSpeed = 80f;
    private Vector3 playerPos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move the player forward when the up arrow key is pressed
        // Rotate the player left when the left arrow key is pressed, and right when the right arrow key is pressed
        if (Keyboard.current.upArrowKey.isPressed)
        {
            transform.position += transform.up * Time.deltaTime * Speed;
        }

        if (Keyboard.current.leftArrowKey.isPressed)
        {
           playerPos = transform.eulerAngles;
           playerPos.z += Time.deltaTime * RotationSpeed;
           transform.eulerAngles = playerPos;

        }

        if (Keyboard.current.rightArrowKey.isPressed)
        {
            playerPos = transform.eulerAngles;
            playerPos.z -= Time.deltaTime * RotationSpeed;
            transform.eulerAngles = playerPos;
        }


    }
}
