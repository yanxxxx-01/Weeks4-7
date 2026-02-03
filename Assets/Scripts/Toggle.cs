using UnityEngine;

public class Toggle : MonoBehaviour
{
    public void ToggleBird()
    {
        
        //gameObject.SetActive(false); //set the calue
        //gameObject.activeInHierarchy //if the box is ticked

        //if the bird is active, call SetActive to false
        //else call SetActive to true
        //if (gameObject.activeInHierarchy == true)
        //{
        //    gameObject.SetActive(false);
        //}
        //else if (gameObject.activeInHierarchy == false)
        //{
        //    gameObject.SetActive(true);
        //}

        gameObject.SetActive(!gameObject.activeInHierarchy);
        Debug.Log("Toggling bird pls!");
    }
}
