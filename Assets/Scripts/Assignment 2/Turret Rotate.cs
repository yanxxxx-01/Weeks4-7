using UnityEngine;
using UnityEngine.UI;

public class TurretRotate : MonoBehaviour
{
    public Slider rotate;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //set the turret to 90 degree at the start
        Vector3 rotateValue = transform.eulerAngles;
        rotateValue.z = 90f;
        transform.eulerAngles = rotateValue;
    }

    // Update is called once per frame
    void Update()
    {
        //rotate the turret based on the slider value
        Vector3 rotateValue = transform.eulerAngles;
        rotateValue.z = rotate.value;
        transform.eulerAngles = rotateValue;
    }
}
