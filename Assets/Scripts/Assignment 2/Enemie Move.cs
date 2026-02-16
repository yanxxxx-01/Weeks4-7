using UnityEngine;


public class EnemieMove : MonoBehaviour
{
    public float speed;
    public GameObject bullet; // Reference to the bullet game object
    public int points = 0; // Variable to keep track of the score
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Vector2 pos = transform.position;
        pos.x = Random.Range(-10f, 10f); // Set the initial horizontal position of the enemy to a random value between -10 and 10
        pos.y = Random.Range(-2f,5f); // Set the initial vertical position of the enemy to 5
        speed = Random.Range(0.01f, 0.05f); // Set the speed of the enemy to a random value between 0.05 and 0.1
        transform.position = pos;
    }

    // Update is called once per frame
    void Update()
    {
        // Move the enemy horizontally based on the speed variable
        Vector2 pos = transform.position;
        pos.x += speed;
        transform.position = pos;
        if (pos.x > 10f)//if the enemy reaches the right edge of the screen, reverse the direction and move it back to the edge
        {
            speed *= -1f;
            pos.x = 10f;
            transform.position = pos;
        }
        if (pos.x < -10f)//if the enemy reaches the left edge of the screen, reverse the direction and move it back to the edge
        {
            speed *= -1f;
            pos.x = -10f;
            transform.position = pos;
        }

        //if the distance between the enemy and the bullet is less than 2, it is considered a hit and destroy the enemy, and add one point to the score
        //float dis = Vector2.Distance(transform.position, bullet.transform.position);
        
        //if (dis < 3 && bullet != null)
        //{
        //    Debug.Log("Killed! ");
        //    Destroy(gameObject);
        //    points += 1; //add one point to the score
        //}
    }
}
