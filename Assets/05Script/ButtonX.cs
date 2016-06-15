using UnityEngine;
using System.Collections;

public class ButtonX : MonoBehaviour {

    private GameObject ExitPanel;

    void Start()
    {
        ExitPanel = GameObject.Find("ExitWindow");
    }

    public void YES()
    {
        Debug.Log("AAAAA");
        Application.Quit();
        return;
    }

    public void NO()
    {
        ExitPanel.GetComponent<Canvas>().enabled = false;
    }
}
