using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchObject : MonoBehaviour
{
    public GameObject match;
    public GameObject correctText;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        Pickupable script = other.GetComponent<Pickupable>();

        if (script != null)
        {
            if (other.gameObject == match)
            {
                correctText.SetActive(true);
                Destroy(script);
                GetComponent<AudioSource>().Play();
                Invoke("HideText", 5f);
            }
        }
    }

    private void HideText()
    {
        correctText.SetActive(false);
    }
}