using UnityEngine;
using System.Collections.Generic;

public class Collisioncheck : MonoBehaviour
{
    public Swanper bulletS;
    public EnemieSwanper enemieS;
    public int points = 0; // Variable to keep track of the score

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //get the position of the bullet and the enemy
        Vector2 bulletPos = bulletS.transform.position;
        Vector2 enemyPos = enemieS.transform.position;
        // if the distance between the enemy and the bullet is less than 2, it is considered a hit and destroy the enemy, and add one point to the score
        float dis = Vector2.Distance(bulletPos,enemyPos);
        if (dis < 1)
        {
            Debug.Log("You Got it! ");
            points += 1; //add one point to the score
        }
    }
}
