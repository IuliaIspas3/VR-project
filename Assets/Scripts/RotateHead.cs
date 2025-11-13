using UnityEngine;

public class RotateHead : MonoBehaviour
{
    public Transform head;
    public float rotationSpeed = 5f;

    void Update()
    {
        if (head == null) return;
        Vector3 headyaw = new Vector3(0, head.eulerAngles.y, 0);
        Quaternion targetRotation = Quaternion.Euler(headyaw);
        head.rotation = Quaternion.Slerp(head.rotation, targetRotation, Time.deltaTime * rotationSpeed);
    }
}
