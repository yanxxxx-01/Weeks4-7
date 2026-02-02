using UnityEngine;
using UnityEngine.InputSystem;
public class NewMonoBehaviourScript : MonoBehaviour
{
    public GameObject tank;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 sp = Random.insideUnitCircle * 5;

        if (Keyboard.current.anyKey.wasPressedThisFrame)
        {
            Instantiate(tank,sp,Quaternion.identity);
        }
    }
}
