using UnityEngine;

public class Driver : MonoBehaviour
{
    float steerSpeed = 0.1f;
    float moveSpeed = 0.01f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerRotation();
        playerMovement();
    }

    void playerRotation()
    {
        transform.Rotate(0, 0, steerSpeed);
    }

    void playerMovement()
    {
        transform.Translate(0, moveSpeed, 0);
    }
}
