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
        if (Input.GetKeyDown(KeyCode.W))
{
    direction = new Vector3(0, 0, verticalMovement);
    transform.Translate(direction * Time.deltaTime * speed);
}

        if (Input.GetKeyDown(KeyCode.D))
        {
            direction = new Vector3(horizontalMovement, 0, 0);
            transform.Translate(direction * Time.deltaTime * speed);
        }
// We use the codes to constraint the player movement within the scene
transform.position = new Vector3(Mathf.Clamp(transform.position.x, -9, 9f), 0.5f, Mathf.Clamp(transform.position.z, -3f, 3f));


    }
}

