using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickEmpezar : MonoBehaviour {

    void Start()
    {
        
    }

	public void onClick()
    {
        Application.LoadLevel(1);
    }
}
