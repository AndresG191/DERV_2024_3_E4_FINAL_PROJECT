using UnityEngine;
using TMPro;

public class PlanetInfo : MonoBehaviour
{
    [SerializeField] private GameObject infoPanel;  
    [SerializeField] private TextMeshProUGUI planetNameText;  
    [SerializeField] private TextMeshProUGUI planetInfoText;  
    [SerializeField] private TextMeshProUGUI planetMassText;
    [SerializeField] private TextMeshProUGUI planetRadiusText;
    [SerializeField] private TextMeshProUGUI planetGravityText;
    [SerializeField] private TextMeshProUGUI planetOrbitText;
    [SerializeField] private TextMeshProUGUI planetRotationText;
    [SerializeField] private TextMeshProUGUI planetAtmosphereText;
    [SerializeField] private TextMeshProUGUI planetMoonsText;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.CompareTag("Planet"))
                {
                    ShowInfo(hit.transform.gameObject);
                }
            }
        }
    }

    void ShowInfo(GameObject planet)
    {
        // Obtener información del componente PlanetData
        PlanetData planetData = planet.GetComponent<PlanetData>();

        string planetName = planet.name;
        string planetInfo = "Hola " + planetName + "\n";
        planetInfo += "Descripción: " + planetData.description + "\n";
        planetInfo += "Masa: " + planetData.mass + "\n";
        planetInfo += "Radio: " + planetData.radius + "\n";
        planetInfo += "Gravedad: " + planetData.gravity + "\n";
        planetInfo += "Periodo Orbital: " + planetData.orbitPeriod + "\n";
        planetInfo += "Periodo de Rotación: " + planetData.rotationPeriod + "\n";
        planetInfo += "Atmósfera: " + planetData.atmosphere + "\n";
        planetInfo += "Número de Lunas: " + planetData.numberOfMoons + "\n";

        // Asignar la información a los componentes UI correspondientes
        planetNameText.text = planetName;
        planetInfoText.text = planetInfo;
        planetMassText.text = "Masa: " + planetData.mass;
        planetRadiusText.text = "Radio: " + planetData.radius;
        planetGravityText.text = "Gravedad: " + planetData.gravity;
        planetOrbitText.text = "Periodo Orbital: " + planetData.orbitPeriod;
        planetRotationText.text = "Periodo de Rotación: " + planetData.rotationPeriod;
        planetAtmosphereText.text = "Atmósfera: " + planetData.atmosphere;
        planetMoonsText.text = "Número de Lunas: " + planetData.numberOfMoons;

        infoPanel.SetActive(true);
    }
}