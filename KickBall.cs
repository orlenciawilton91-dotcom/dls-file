using UnityEngine;

public class KickBall : MonoBehaviour
{
    public float kickForce = 10f;

    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            if (Input.GetKey(KeyCode.Space))
            {
                Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();

                Vector3 kickDirection = transform.forward;
                rb.AddForce(kickDirection * kickForce, ForceMode.Impulse);
            }
        }
    }
}
