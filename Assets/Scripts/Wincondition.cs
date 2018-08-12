using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Wincondition : MonoBehaviour
{
    bool win = false;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (!win && GameObject.FindObjectsOfType<Pickupable>().Length == 0)
        {
            win = true;

            Invoke("NextScene", 5);
        }
    }

    void NextScene()
    {
        SceneManager.LoadScene("3Denvironment", LoadSceneMode.Additive);
    }
}
