using UnityEngine;
using System.Collections;

public class EXIT : MonoBehaviour
{

    private GameObject ExitPanel;
    bool One = false;

    void Start()
    {
        ExitPanel = GameObject.Find("ExitWindow");
        ExitPanel.GetComponent<Canvas>().enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        //if (Application.platform == RuntimePlatform.Android && Input.GetKeyDown(KeyCode.Escape))
        {
            if (One == false)
            {
                //GameObject Oya_Object = GameObject.Find("Front");
                //GameObject exitPanel = Oya_Object.transform.FindChild("Exit").gameObject;
                //exitPanel.SetActive(true);

                //ExitPanel.GetComponent<Canvas>().enabled = true;
                OpenPanel();
                One = true;
            }
        }
    }

    void OpenPanel()
    {
        ExitPanel.GetComponent<Canvas>().enabled = true;
    }

    public void YES()
    {
        Application.Quit();
        return;
    }

    public void NO()
    {
        ExitPanel.GetComponent<Canvas>().enabled = false;
        One = false;
    }

}
