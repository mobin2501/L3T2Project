
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    float mv = 2f;
    float nv = 6f;
    bool yes = false;
    private void FixedUpdate()
    {
        if ( Input.GetKey(KeyCode.D) )
        {
            if(yes ==true)
            {
                rb.transform.position = rb.transform.position + new Vector3(mv * Time.fixedDeltaTime, 0, 0);
            }
            
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.transform.position = rb.transform.position + new Vector3(-mv * Time.fixedDeltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            rb.transform.position = rb.transform.position + new Vector3(0,nv * Time.fixedDeltaTime, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.transform.position = rb.transform.position + new Vector3(0,-nv * Time.fixedDeltaTime, 0);
        }

    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log(collision.collider);
        yes = true;
    }
}
