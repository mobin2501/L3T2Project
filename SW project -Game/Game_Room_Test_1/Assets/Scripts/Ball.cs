
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody rb;

    public static float x = .1f;
    public static float z = .1f;
    Vector3 pos;

    bool p1 = false;
    bool p2 = false;


    //bool dc = false;

    private void FixedUpdate()
    {
        if (p1 == false && p2 == false)
        {
            Posi3();
        }
        else if (p1 == true && p2 == false)
        {
            Posi4();
        }
        else if (p1 == false && p2 == true)
        {
            Posi2();
        }
        else
        {
            Posi();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.transform.position);
        
        if (collision.collider.name == "Wall2")
        {
            Debug.Log("Wall2");
            p1 = false;
            p2 = true;
            
        }
        else if (collision.collider.name == "Wall4")
        {
            Debug.Log("Wall4");
            p1 = true;
            p2 = false;
            
        }
        else if (collision.collider.name == "Wall3")
        {
            Debug.Log("Wall3");
            p1 = false;
            p2 = false;
            

        }
        else if (collision.collider.name == "Wall1")
        {
            Debug.Log("Wall1");
            p1 = true;
            p2 = true;
            

        }

    }
    void Posi()
    {
        pos = new Vector3(x, 0, z);
        //pos = new Vector3(.1f, 0, .1f);
        rb.transform.position = rb.transform.position + pos;
        
    }
    void Posi2()
    {
        
        pos = new Vector3(-x, 0, z);
        //pos = new Vector3(-.1f, 0, .1f);
        rb.transform.position = rb.transform.position +pos;

    }
    void Posi3()
    {
        pos = new Vector3(-x, 0, -z);
        //pos = new Vector3(-.1f, 0, -.1f);
        rb.transform.position = rb.transform.position + pos;
    }
    void Posi4()
    {
        pos = new Vector3(x, 0, -z);
        //pos = new Vector3(.1f, 0, -.1f);
        rb.transform.position = rb.transform.position + pos;
    }

}
