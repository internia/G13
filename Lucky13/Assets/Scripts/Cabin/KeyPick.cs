using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPick : MonoBehaviour
{
    public GameObject key;
    public GameObject mat;
    public GameObject leaveMat;

    public void Update()
    {
        if (key.activeInHierarchy == false)
        {
            mat.SetActive(false);
            leaveMat.SetActive(true);
        }
    }
    
}
