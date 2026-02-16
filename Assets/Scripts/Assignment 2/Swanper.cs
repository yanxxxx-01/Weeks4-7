using System.Collections.Generic;
using UnityEngine;

public class Swanper : MonoBehaviour
{
    public GameObject bulletPrefab; // Reference to the bullet prefab
    public GameObject bullets; // Reference to the instantiated bullet
    public List<GameObject> bulletList; // Array to hold the instantiated bullets
    private AudioSource audioY;

  
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Get the AudioSource component attached to the same GameObject as this script
        audioY = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {



        ////check the distance between the bullet and the enemy, if it is less than 2, it is considered a hit and destroy the bullet
        //float dis = Vector2.Distance(transform.position, bullets.transform.position);
        //if (dis < 3f)
        //{
        //    //if the distance is less than 2, it is considered a hit and destroy the bullet
        //    Debug.Log("Distance: " + dis);
        //    Debug.Log("Great!");
        //    Destroy(bullets);

        //    audioY.Play();//play the audio
        //}

    }

    public void attack()
    {
        // Instantiate the bullet prefab at the position of the swanper
        {

            bullets = Instantiate(bulletPrefab, transform.position, transform.rotation);
            bulletList.Add(bullets);
           
        }
    }
}
