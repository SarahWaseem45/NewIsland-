using UnityEngine;

public class ScaleZChanger : MonoBehaviour
{
    public float minZ = 114f; // Minimum Z scale
    public float maxZ = 200f; // Maximum Z scale
    public float speed = 1f; // Speed of oscillation

    private void Update()
    {
        // Calculate the PingPong value for Z scale
        float newZ = Mathf.PingPong(Time.time * speed, maxZ - minZ) + minZ;

        // Apply the new scale
        transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, newZ);
    }
}
