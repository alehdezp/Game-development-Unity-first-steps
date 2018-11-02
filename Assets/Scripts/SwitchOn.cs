using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchOn : MonoBehaviour {

    GameController controller;

    private bool isOn;
    private Light lt;

    // Use this for initialization
    void Start()
    {
        
        controller = GameController.gameController;
        controller.switchOnOff += OnOff;

        isOn = true;
        lt = GetComponent<Light>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnOff()
    {
        isOn = !isOn;
        lt.enabled = isOn;
    }
}
