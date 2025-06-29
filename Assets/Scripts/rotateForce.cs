using UnityEngine;

public class rotateForce : MonoBehaviour
{   
    Rigidbody rb;

    [SerializeField]
    float rotationForce;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddTorque(Vector3.up * rotationForce);
    }
}
