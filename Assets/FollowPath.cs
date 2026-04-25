using UnityEngine;

public class FollowPath : MonoBehaviour
{
    public Transform[] waypoints; // Drag PointA, B, and C here
    public float speed = 3.0f;
    private int currentPoint = 0;

    void Update()
    {
        if (currentPoint < waypoints.Length)
        {
            // Move toward the current waypoint
            transform.position = Vector3.MoveTowards(transform.position, waypoints[currentPoint].position, speed * Time.deltaTime);
            
            // Look at the waypoint so you turn with the curve
            transform.LookAt(waypoints[currentPoint]);

            // If we reach the point, move to the next one
            if (Vector3.Distance(transform.position, waypoints[currentPoint].position) < 0.1f)
            {
                currentPoint++;
            }
        }
    }
}