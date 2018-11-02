using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FirstPersonScript : MonoBehaviour {
    public delegate void ActualizarPoder(int addPower);
    public ActualizarPoder actualizarPoder;

    public delegate void OnItemCollision(Collision col);
    public OnItemCollision onItemCollision;

    GameController controller;
    public int power = 0;
    
	// Use this for initialization
	void Start () {
        controller = GameController.gameController;
        
    }
	
	// Update is called once per frame
	void Update () {

	}

    void addPower(int x)
    { 
        power += x;
    }

    void OnCollisionEnter(Collision collision)
    {
        onItemCollision(collision);
    }



}
