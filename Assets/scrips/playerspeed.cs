using UnityEngine;

public class playerspeed : MonoBehaviour
{
    public float speed;
    void start()
    {
    
}



    void Update()
    {
        // Get the horizontal axis (A/D or Left/Right keys)
        float horizontalMovement = Input.GetAxis("Horizontal");

        // Get the vertical axis (W/S or Up/Down keys)
        float verticalMovement = Input.GetAxis("Vertical");

        // Create a movement direction vector (X and Z axes only)
        Vector3 direction = new Vector3(horizontalMovement, 0, verticalMovement);

        // Move the player object
        transform.Translate(direction * Time.deltaTime * speed);
    }
}

