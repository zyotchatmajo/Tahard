using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorOver : MonoBehaviour
{
    Ray ray;
    RaycastHit hit;

    void Update() {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit)) {
            Debug.Log("Hola");
        }
    }

}
