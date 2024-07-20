using UnityEngine;

public class InstantiateRandomPrefabs : MonoBehaviour
{
    public GameObject[] prefabsToSpawn; // Array of prefabs to spawn
    public Vector3[] spawnPositions; // Array of Vector3 positions
    public float delay = 1f; // Time in seconds to wait before spawning

    private float timer;

    void Start()
    {
        timer = delay; // Initialize timer in Start

        // Ensure prefabs and spawn positions have the same length
        if (prefabsToSpawn.Length != spawnPositions.Length)
        {
            Debug.LogError("Number of prefabs and spawn positions must be equal!");
        }
    }

    void Update()
    {
        timer -= Time.deltaTime; // Count down timer each frame

        if (timer <= 0) // Check if delay has passed
        {
            if (prefabsToSpawn.Length > 0 && spawnPositions.Length > 0)
            {
                int randomIndex = Random.Range(0, prefabsToSpawn.Length); // Choose random prefab and position index

                // Spawn the chosen prefab at the corresponding position
                Instantiate(prefabsToSpawn[randomIndex], spawnPositions[randomIndex], Quaternion.identity);
            }
            else
            {
                Debug.LogError("Missing prefabs or spawn positions for " + gameObject.name);
            }

            timer = delay; // Reset timer for potential respawns
        }
    }
}
