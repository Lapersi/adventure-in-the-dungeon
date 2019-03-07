using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour {
     public GameObject mainMenu;


    private void Awake()
    {
        //mainMenu.SetActive(true);
    }

    // Update is called once per frame
    void Update () {

        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }
}
