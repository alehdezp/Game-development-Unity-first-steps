using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public delegate void eventDelegate();

public class GameController : MonoBehaviour {
    public static GameController gameController;
    public event eventDelegate tipoBCollision;
    public event eventDelegate switchOnOff;

    private FirstPersonScript fps;
    private int power = 0;
    public Text powerText;

    private void Awake()
    {
        if (gameController == null)
        {
            gameController = this;
            DontDestroyOnLoad(this);
        }
        else if (gameController != this)
        {
            Destroy(gameObject);
        }
        powerText.text = "Power: " + power;
        fps = GameObject.FindGameObjectWithTag("Player").GetComponent<FirstPersonScript>();
        fps.actualizarPoder = addPower;
        fps.onItemCollision = fpsItemCollision;
    }

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.E))
        {
            switchOnOff();
        }
    }

    void addPower(int x)
    {
        fps.power += x;
        power = fps.power;
        powerText.text = "Power: " + power;
    }

    void fpsItemCollision(Collision col)
    {
        if (col.gameObject.tag == "TipoA")
        {
            fps.actualizarPoder(10);
        }
        else if (col.gameObject.tag == "TipoB")
        {
            fps.actualizarPoder(-5);
            tipoBCollision();
        }
    }

}
