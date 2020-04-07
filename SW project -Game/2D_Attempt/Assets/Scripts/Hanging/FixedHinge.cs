
using UnityEngine;

public class FixedHinje : MonoBehaviour
{
    //public Rigidbody2D rb;
    public float speed = .35f;
    public Vector3 from = new Vector3(0f, 0f, -30f);
    public Vector3 to = new Vector3(0f, 0f, 30f);



    private void FixedUpdate()
    {
        float t = Mathf.PingPong(Time.time * speed * 2.0f, 1.0f);

        transform.eulerAngles = Vector3.Lerp(from, to, t);


    }
}
