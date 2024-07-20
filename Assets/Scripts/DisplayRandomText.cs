using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public string[] texts = { "10% discount", "20% discount", "Free Sample", "Better Luck Next Time" };

    public void Awake()
    {
        int randomIndex = Random.Range(0, texts.Length);
        string randomText = texts[randomIndex];
    }
}
