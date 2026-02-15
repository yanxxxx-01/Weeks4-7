using UnityEngine;


public class CarMovement : MonoBehaviour
{
    public float speed = 5f;
    private Vector2 carPos;
    public GameObject player;
    public SpriteRenderer sp;
    private AudioSource audioY;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioY = GetComponent<AudioSource>();
       carPos.y = Random.Range(-3f, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        //car moves frome right to left across the screen
        carPos.x = transform.position.x;
        carPos.x -= Time.deltaTime * speed;
        transform.position = carPos;

        //if the car goes off the left side of the screen, it reappears on the right side
        Vector2 screenPos = Camera.main.WorldToScreenPoint(transform.position);
        if (screenPos.x < 0)
        {
            screenPos.x = Screen.width;
            screenPos = Camera.main.ScreenToWorldPoint(screenPos);
            transform.position = screenPos;
        }

        float dis = Vector2.Distance(player.transform.position, transform.position);
        Debug.Log(dis);
        if (dis < 2)
        {
            Debug.Log("Game Over");
            audioY.Play();
        }


    }
}
