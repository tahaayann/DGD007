using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    Color testColor;

    private Vector3 position;
    private Vector3 offset;
    private float scale;
    
    
    // Start is called before the first frame update
    void Start()
    {
        testColor = new Color(0.3f, 0.5f, 1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPoint = (position + offset) * scale;
    }
}
