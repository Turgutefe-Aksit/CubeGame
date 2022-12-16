using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;

    public float forwardForce = 400f;

    public float sideWayForce = 1000f;

    
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        //Input.GetMouseButton(0) dokunmatik için down dersek 1 kere çalýþýr.
        if (Input.GetKey(KeyCode.D) || Input.GetTouch(0).position.x > Screen.width/2)
        {
            rb.AddForce(sideWayForce * Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.A) || Input.GetTouch(0).position.x < Screen.width /  2)
        {
            rb.AddForce(-sideWayForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }

        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
