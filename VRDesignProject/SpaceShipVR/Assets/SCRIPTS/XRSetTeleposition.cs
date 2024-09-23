using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XRSetTeleposition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Ottieni la posizione attuale del giocatore
        Vector3 playerPosition = transform.position;

        // Mantieni l'asse Y a 0
        playerPosition.y = 2.15f;

        // Applica la nuova posizione con Y bloccato a 0
        transform.position = playerPosition;
    }
}
