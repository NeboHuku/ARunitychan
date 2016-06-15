using UnityEngine;
using System.Collections;

public class EXIT : MonoBehaviour
{

    private GameObject ExitPanel;
    //bool One = false;

    void Start()
    {
        //void Awake(){

        ExitPanel = GameObject.Find("ExitWindow");
        ExitPanel.GetComponent<Canvas>().enabled = false;
    }

    void Update()
    {

        if (Application.platform == RuntimePlatform.Android && Input.GetKeyDown(KeyCode.Escape))
        //if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {

                ExitPanel.GetComponent<Canvas>().enabled = true;

                /*if (One == false)
                {
                    ExitPanel.GetComponent<Canvas>().enabled = true;
                    One = true;
                }*/
            }
        }
    }
}
