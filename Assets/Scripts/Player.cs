using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private PlantSO m_selectedPlant;

    [SerializeField] private List<PlantSO> m_plants;
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            
        }
    }
}
