using UnityEngine;
using TMPro;

public class ItemCollecter : MonoBehaviour
{
    public TextMeshProUGUI countText;  // Reference to the TextMeshPro text element to display the count
    public int itemCount;    // The number of items the player has collected so far

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Item"))
        {
            itemCount++;    // Increment the item count
            UpdateCountText();   // Update the TextMeshPro text element to display the new count
            Destroy(other.gameObject);  // Destroy the collected item
        }
    }

    // Updates the TextMeshPro text element to display the current item count
    private void UpdateCountText()
    {
        countText.text = "Diamonds: " + itemCount.ToString();
    }
}