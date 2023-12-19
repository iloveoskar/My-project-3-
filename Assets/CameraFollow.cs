using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // Assign the player character to this field
    public float smoothSpeed = 5f;
    public Vector3 offset;

    void LateUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
    }
}