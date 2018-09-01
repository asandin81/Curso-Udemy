using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {

    public float maxTime = 60f;
    private float countDown = 0f;
	// Use this for initialization
	void Start () {
        countDown = maxTime;
	}
	
	// Update is called once per frame
	void Update () {
        countDown = countDown - Time.deltaTime;
        Debug.Log("Cuenta atras : " + countDown);
        if(countDown <= 0){
            Debug.Log("You Lose");

            Moneda.contador = 0;
            SceneManager.LoadScene("SampleScene");
        }
	}
}
