using System.Collections.Generic;
using UnityEngine;

public class Swanper : MonoBehaviour
{
    public int points = 0; // Variable to keep track of the score

    public GameObject bulletPrefab; // Reference to the bullet prefab
    public GameObject bullets; // Reference to the instantiated bullet
    public List<GameObject> bulletList = new List<GameObject>(); // Array to hold the instantiated bullets
     Vector2 bulletPos; // Variable to hold the position of the bullet

    public AudioSource audioY;

    public int enemyMax = 5;
    public GameObject enemy; // Reference to the enemy Prefab
    public GameObject enemySwanpe; // Reference to the swanper object
    public List<GameObject> enemyList = new List<GameObject>(); // Array to hold the instantiated enemies

    Vector2 enemyPos; // Variable to hold the position of the enemy


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Get the AudioSource component attached to the same GameObject as this script
        audioY = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the number of enemies in the list is less than the maximum allowed
        if (enemyList.Count < enemyMax)
        {
            enemySwanpe = Instantiate(enemy, transform.position, transform.rotation);
            enemyList.Add(enemySwanpe);
        }

        // Loop through the bullet list in reverse order to check for collisions with enemies
        for (int i = bulletList.Count - 1; i >= 0; i--)
        {
            bulletPos = bulletList[i].transform.position; //Check all the bullets in the list and get their position
            Destroy(bulletList[i], 4f);// Destroy the bullet after 4 seconds to prevent it from existing indefinitely

            for (int j = enemyList.Count - 1; j >= 0; j--)
            {
                enemyPos = enemyList[j].transform.position; //Check all the enemies in the list and get their position

                float dis = Vector2.Distance(bulletPos, enemyPos); //get the distance between the bullet and the enemy using Vector2.Distance() method //reference https://docs.unity3d.com/ScriptReference/Vector2.Distance.html

                if (dis < 1)// if the distance is less than 1, it is considered a hit
                {
                    Debug.Log(dis);
                    Debug.Log("You Got it! ");

                    points += 1; //add one point to the score
                    Destroy(enemyList[j]);//destroy the enemy
                    enemyList.RemoveAt(j); //remove the enemy from the list //reference https://docs.unity3d.com/2017.1/Documentation/ScriptReference/Array.RemoveAt.html

                    if (bulletList[i] != null) // Check if the bullet still exists before trying to destroy it
                    {
                        Destroy(bulletList[i]);//destroy the bullet
                        bulletList.RemoveAt(i); //remove the bullet from the list
                    }
                }
            }

          

        }
        //get the position of the bullet and the enemy
        
        // if the distance between the enemy and the bullet is less than 2, it is considered a hit and destroy the enemy, and add one point to the score
       
    }

    public void Attack()
    {
        // Instantiate the bullet prefab at the position of the swanper
        {
            //when the attack button is pressed, instantiate a bullet and add it to the bullet list, and play the audio
            bullets = Instantiate(bulletPrefab, transform.position, transform.rotation);
            bulletList.Add(bullets);
            audioY.Play();
        }
    }
}
