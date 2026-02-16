using UnityEngine;
using UnityEngine.UI;

public class TankMovement : MonoBehaviour
{
    public Slider tankX;
    Vector2 tankPos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //move the tank based on the slider value
        tankPos = transform.position;
        tankPos.x = tankX.value;
        transform.position = tankPos;
    }
}
