using UnityEngine;
using TMPro; 

public class ProximityMessage : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI messageText; 

    private void Start()
    {
        if (messageText == null)
        {
            Debug.LogError("Message Text no está asignado en el Inspector");
            return;
        }

        messageText.gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            messageText.text = "Has entrado en la zona de la estación espacial"; 
            messageText.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            messageText.gameObject.SetActive(false);
        }
    }
}
