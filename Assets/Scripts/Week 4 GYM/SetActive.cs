using UnityEngine;
using UnityEngine.UIElements;

public class SetActive : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public float speed;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newRotate = transform.eulerAngles;
        newRotate.z += speed * Time.deltaTime;
        transform.eulerAngles = newRotate;
    }

    public void StartSpin()
    {
        speed = 100f;
    }

    public void StopSpin()
    {
        speed = 0f;
    }
}
