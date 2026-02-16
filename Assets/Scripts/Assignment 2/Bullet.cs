using UnityEngine;
using UnityEngine.UIElements;

public class Bullet : MonoBehaviour
{
    public float speed = 5f;
    public float liveTime = 4f; // Time in seconds before the bullet is destroyed
    public GameObject enemies; // Reference to the enemy game object
    private AudioSource audioY;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioY = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {     
        transform.position += transform.right * Time.deltaTime * speed; // Move the bullet in the direction it is facing
        liveTime -= Time.deltaTime; // Decrease the live time of the bullet
        if (liveTime <= 0) // If the live time has expired, destroy the bullet
        {
            Destroy(gameObject);
        }

        //check the distance between the bullet and the enemy, if it is less than 2, it is considered a hit and destroy the bullet
        
        float dis = Vector2.Distance(enemies.transform.position, transform.position);
        Debug.Log("Distance: " + dis);
        if (dis < 2)
        {
            Debug.Log("Great!");
            Destroy(gameObject);

            audioY.Play();//add one point to the score, and play the audio

        }
    }
}
