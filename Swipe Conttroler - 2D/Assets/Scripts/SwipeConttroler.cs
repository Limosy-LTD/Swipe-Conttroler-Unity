using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeConttroler : MonoBehaviour
{
    private Vector2 startPos;
    public Camera cam;

    public float maxPos;
    public float minPos;

    private void Start()
    {
        cam = GetComponent<Camera>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) startPos = cam.ScreenToWorldPoint(Input.mousePosition);
        else if (Input.GetMouseButton(0))
        {
            float pos = cam.ScreenToWorldPoint(Input.mousePosition).x - startPos.x; // If you need to scroll vertically then replace x with y
            transform.position = new Vector3(Mathf.Clamp(transform.position.x - pos, minPos, maxPos), transform.position.y, transform.position.z);
        }
    }
}
