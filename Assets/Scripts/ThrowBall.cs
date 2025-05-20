using UnityEngine;

public class Basketball : MonoBehaviour
{
    public Rigidbody rb;
    public float throwForce = 10f;
    private bool isThrown = false;

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isThrown)
        {
            ThrowBall();
        }
    }

    void ThrowBall()
    {
        isThrown = true;
        rb.AddForce(Vector3.up * throwForce + Vector3.forward * throwForce, ForceMode.Impulse);
    }
}
