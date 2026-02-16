using NUnit.Framework;
using UnityEngine;

public class Swanper : MonoBehaviour
{
    public GameObject bullet; // Reference to the bullet prefab
 
  
   
    public GameObject[] bullets; // Array to hold the instantiated bullets
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Get the AudioSource component attached to the same GameObject as this script
        
    }

    // Update is called once per frame
    void Update()
    {   
        
    }

    public void attack()
    {
        // Instantiate the bullet prefab at the position of the swanper
        Instantiate(bullet, transform.position, transform.rotation);
    }
}
