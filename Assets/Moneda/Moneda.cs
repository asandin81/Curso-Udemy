using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moneda : MonoBehaviour {


    public static int contador = 0;
	// Use this for initialization
	void Start () {
        Moneda.contador++;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Algo choco con la moneda.");
        Moneda.contador--;
        if (Moneda.contador == 0)
        {
            Debug.Log("El juego ha termindado");
            GameObject gameManager = GameObject.Find("GameManager");
            Destroy(gameManager);

            GameObject[] fireworksSystem = GameObject.FindGameObjectsWithTag("fireworks");
            foreach (GameObject fireworks in fireworksSystem)
            {
                fireworks.GetComponent<ParticleSystem>().Play();
            }
        }
    }
}
