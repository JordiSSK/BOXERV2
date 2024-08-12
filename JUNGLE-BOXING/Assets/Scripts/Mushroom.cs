using UnityEngine;
using TMPro; 

public class Mushroom : MonoBehaviour
{
    public TextMeshProUGUI counterText; 
    private int counter = 0;

    void Start()
    {
        UpdateCounterText();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) 
        {
            counter++;
            UpdateCounterText();
            Destroy(gameObject); 
        }
    }

    void UpdateCounterText()
    {
        counterText.text = "Keys: " + counter;
    }
}


