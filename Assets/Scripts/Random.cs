using UnityEngine;
using UnityEngine.UI;

public class DisplayRandomText : MonoBehaviour
{
    public string[] texts = { "10% Discount", "20% Discount", "Free Sample", "Better Luck Next Time" };
    [SerializeField] private Text Result;

    public void Start()
    {
        int randomIndex = Random.Range(0, texts.Length); // Get a random index within the array bounds
        string randomText = texts[randomIndex]; // Access the text at the random index

        Result.text = randomText; // Assign the random text to the Text object
    }
}
