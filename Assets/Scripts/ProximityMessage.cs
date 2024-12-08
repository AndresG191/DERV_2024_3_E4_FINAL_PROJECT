using UnityEngine;
using TMPro; // Asegúrate de incluir esta línea para usar TextMeshProUGUI

public class ProximityMessage : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI messageText; // Usar SerializedField para TextMeshProUGUI

    private void Start()
    {
        // Verificar si el messageText está asignado
        if (messageText == null)
        {
            Debug.LogError("Message Text no está asignado en el Inspector");
            return;
        }

        // Asegurarse de que el mensaje esté oculto al inicio
        messageText.gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Mostrar el mensaje cuando el jugador entre en la zona
            messageText.text = "Has entrado en la zona de la estación espacial"; // Mensaje a mostrar
            messageText.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Ocultar el mensaje cuando el jugador salga de la zona
            messageText.gameObject.SetActive(false);
        }
    }
}
