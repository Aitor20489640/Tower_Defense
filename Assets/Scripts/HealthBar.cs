using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    // The TextMesh Component
    private TextMesh tm;
    // Start is called before the first frame update
    void Start()
    {
        tm = GetComponent<TextMesh>();
    }

    // Update is called once per frame
    void Update()
    {
        // Face the Camera
        transform.forward = Camera.main.transform.forward;
    }
    
    // Tells the current health based on the lenght of the textMesh
    public int Current()
    {
        return tm.text.Length;
    }

    public void Decrease()
    {
        if (Current() > 1)
        {
            tm.text = tm.text.Remove(tm.text.Length - 1);
        }
        else
        {
            Destroy(transform.parent.GameObject());
        }
    }
}
