using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipoB : MonoBehaviour {
    public delegate void CambiarColor();
    public CambiarColor cambiarColor;

    GameController controller;

    // Use this for initialization
    void Start () {
        controller = GameController.gameController;
        controller.tipoBCollision += randomColor;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void randomColor()
    {
        Renderer rend = GetComponent<Renderer>();
        rend.material.color = new Color(Random.value, Random.value, Random.value, 1.0f);
    }
}
