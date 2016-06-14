using UnityEngine;
using System.Collections;

public class QUIT : MonoBehaviour {

    private GameObject Exit;

    void Start() {
        Exit = GameObject.Find("ExitWindow");

    }

    void OoenExitWindow()
    {
        Exit.GetComponent<Canvas>().enabled = true;
    }

	void CloseExitWindow ()
    {
        Exit.GetComponent<Canvas>().enabled = false;
	
	}

    //http://labs.gree.jp/blog/2014/12/12453/
}
