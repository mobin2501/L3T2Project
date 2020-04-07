
using UnityEngine;

public class Fixed : MonoBehaviour
{
    public float speed = .15f;
    public Vector3 from = new Vector3(0f, 0f, -30f);
    public Vector3 to = new Vector3(0f, 0f, 30f);



    private void FixedUpdate()
    {
        float t = Mathf.PingPong(Time.time * speed * 1.0f, 1.0f);

        transform.eulerAngles = Vector3.Lerp(from, to, t);


    }
}
