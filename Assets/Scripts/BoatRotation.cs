using UnityEngine;

public class BoatRotation : MonoBehaviour
{
    public float startRotationAngle = 11f;  // Starting angle
    public float rotationAngle = 12f;      // Maximum tilt angle in X-axis
    public float rotationSpeed = 2f;       // Speed of oscillation

    private float timeCounter = 0f;

    void Start()
    {
        // Initialize the boat's rotation with the start angle
        transform.localRotation = Quaternion.Euler(startRotationAngle, transform.localRotation.eulerAngles.y, transform.localRotation.eulerAngles.z);
    }

    void Update()
    {
        timeCounter += Time.deltaTime * rotationSpeed;
        float angle = Mathf.Lerp(startRotationAngle - rotationAngle, startRotationAngle + rotationAngle, (Mathf.Sin(timeCounter) + 1) / 2);
        transform.localRotation = Quaternion.Euler(angle, transform.localRotation.eulerAngles.y, transform.localRotation.eulerAngles.z);
    }
}
