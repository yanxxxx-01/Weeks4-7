using System.Collections.Generic;
using UnityEngine;

public class EnemieSwanper : MonoBehaviour
{

    public int enemyMax = 5;
    public GameObject enemy; // Reference to the enemy Prefab
    public GameObject enemySwanpe; // Reference to the swanper object
    public List<GameObject> enemyList; // Array to hold the instantiated enemies

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
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
    }

}
