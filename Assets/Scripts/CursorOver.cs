using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorOver : MonoBehaviour
{
    float speed = 1;
    bool mouseOver = false;
    public Color start;
    public Color end;
    void OnMouseEnter() {
        mouseOver = true;
        transform.Rotate(speed, 0, 0);
    }

    void OnMouseExit() {
        mouseOver = false;
        transform.Rotate(0, 0, 0);
    }

}
