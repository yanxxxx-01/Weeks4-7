using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class Enemies : MonoBehaviour
{
    public float health = 10f;
    public SpriteRenderer image;
    public TextMeshProUGUI healthText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        if (image.bounds.Contains(mousePos) && Mouse.current.leftButton.wasPressedThisFrame)
        { 
            health -= 1f;
        }
        if (health <= 0f)
        {
            Destroy(gameObject);
        }

        healthText.text = health.ToString();
    }
}
