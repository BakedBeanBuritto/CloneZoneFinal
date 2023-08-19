using UnityEngine;

public class PinkTagGate : MonoBehaviour
{
    public string allowedTag = "Pink";

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(allowedTag))
        {
            Debug.Log(other.name + " is allowed to enter.");
            // Put your code here to handle the player entering the area.
        }
        else
        {
            Debug.Log(other.name + " is not allowed to enter.");
            // Put your code here to handle the player being denied entry.
        }
    }
}
