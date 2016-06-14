using UnityEngine;
using System.Collections;

public class EXIT : MonoBehaviour {

	void Start () {

	}

    void Update()
    {
        if(Input.GetKey(KeyCode.Escape))
        //if (Application.platform == RuntimePlatform.Android && Input.GetKeyDown(KeyCode.Escape))
        {
           GameObject Oya_Object = GameObject.Find("Canvas");
           GameObject exitScene = Oya_Object.transform.FindChild("Exit").gameObject; 
           exitScene.SetActive(true);
        }
    }

    public void YES()
    {
        Application.Quit();
        return;
    }

    public void NO()
    {
        GameObject.Find("Exit").SetActive(false);
    }
}
