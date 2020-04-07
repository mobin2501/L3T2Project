
using UnityEngine;

public class HangingScript : MonoBehaviour
{
    public Transform t;
    float theta = 10;
    private void FixedUpdate()
    {
        t.transform.Rotate(0, 0,-theta*Time.fixedDeltaTime,Space.Self);
    }
}
