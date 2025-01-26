using UnityEngine;
using UnityEngine.UI;

public class Scoreboard : MonoBehaviour
{
    public Text scoreText; // Assign in Inspector
    private int score = 0;

    public void IncrementScore(int points)
    {
        score += points;
        scoreText.text = "Score: " + score;
    }

    private void OnTriggerEnter(Collider other)
    {
        // Assuming the bubble has a CollectibleBubble script
        CollectibleBubble bubble = other.GetComponent<CollectibleBubble>();
        if (bubble != null)
        {
            int points = CalculatePoints(bubble.SphereCollider.radius);
            IncrementScore(points);
        }
    }

    private int CalculatePoints(float radius)
    {
        // You can adjust this formula to suit your needs
        return (int)(radius * 10);
    }
}//test