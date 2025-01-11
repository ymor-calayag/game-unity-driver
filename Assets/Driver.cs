using UnityEngine;

public class Driver : MonoBehaviour
{
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
        transform.Rotate(0, 0, 0.1f);
    }

    void playerMovement()
    {
        transform.Translate(0, 0.01f, 0);
    }
}
