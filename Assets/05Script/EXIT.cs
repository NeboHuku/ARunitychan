using UnityEngine;
using System.Collections;

public class EXIT : MonoBehaviour {

	void Start () {
        GameObject.Find("Exit").SetActive(false);
            	
	}

    void Update()
    {
        if (Application.platform == RuntimePlatform.Android && Input.GetKey(KeyCode.Escape))
        {
            GameObject.Find("Exit").SetActive(true);
            return;

        }

    }

    public void YES()
    {
        Application.Quit();
    }

    public void NO()
    {
        GameObject.Find("Exit").SetActive(false);
        return;
    }
		
}
