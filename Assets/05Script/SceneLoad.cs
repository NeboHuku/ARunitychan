using UnityEngine;

public class SceneLoad : MonoBehaviour {

    void Update()
    {
        //if (Input.GetKey(KeyCode.Escape) && Application.loadedLevelName!="Menu")
        if (Application.platform == RuntimePlatform.Android && Input.GetKey(KeyCode.Escape) && Application.loadedLevelName!="Menu")
        {
            Application.LoadLevel("Menu");

        }

    }

    // Use this for initialization
    public void Button3D () {
        Application.LoadLevel("3Dunitychan");

    }
	
	// Update is called once per frame
	public void ButtonSD () {
        Application.LoadLevel("SDunitychan");


    }
}
