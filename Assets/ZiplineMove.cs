using UnityEngine;

public class TunnelRide : MonoBehaviour
{
    public float speed = 5.0f;
    // Adjust this 'turnSpeed' in the Inspector until you stay on the rails
    public float turnSpeed = 0.5f; 

    void Update()
    {
        // 1. Move Forward
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // 2. Turn with the curve
        // Use a small positive number (0.5) to turn Right
        // Use a small negative number (-0.5) to turn Left
        transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime);
    }
}