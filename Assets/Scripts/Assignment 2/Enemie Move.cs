using UnityEngine;
using UnityEngine.UIElements;

public class EnemieMove : MonoBehaviour
{
    public float speed = 0.01f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        pos.x += speed;
        transform.position = pos;
        if (pos.x > 10f)
        {
            speed *= -1f;
            pos.x = 10f;
            transform.position = pos;
        }
        if (pos.x < -10f)
        {
            speed *= -1f;
            pos.x = -10f;
            transform.position = pos;
        }

    }
}
