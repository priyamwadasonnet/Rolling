using UnityEngine;

public class Delete : MonoBehaviour
{
    public float destroyYPosition = -5f; // Adjust this value based on your scene setup

    private void Update()
    {
        // Check if the Y position is below the destroyYPosition threshold
        if (transform.position.y < destroyYPosition)
        {
            Destroy(gameObject);
        }
    }
}
