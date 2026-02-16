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

    }

    public void Attack()
    {
        // Instantiate the bullet prefab at the position of the swanper
        {
            bullets = Instantiate(bulletPrefab, transform.position, transform.rotation);
            bulletList.Add(bullets);
        }
    }
}
