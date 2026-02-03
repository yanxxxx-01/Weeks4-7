using UnityEngine;
using UnityEngine.InputSystem;


public class Description : MonoBehaviour
{
    public GameObject description;
    public bool mouseOver;
    public SpriteRenderer Image;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mosPos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        if (Image.bounds.Contains(mosPos) == true)
        {
            description.SetActive(true);
        }
        else if (Image.bounds.Contains(mosPos) == false)
        {
            description.SetActive(false);
        }
    }
}
