using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody playerRb;
    private GameObject focalPoint;
    public float speed = 5f;

    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("Focal Point");
    }

    // Update is called once per frame
    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");

        playerRb.AddForce(focalPoint.transform.forward * forwardInput * speed);
    }
}
