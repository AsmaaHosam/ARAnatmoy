using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activate : MonoBehaviour
{
    public Canvas canvas;
    // Start is called before the first frame update
    void Start()
    {
        canvas.gameObject.SetActive(true);
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        canvas.gameObject.transform.LookAt(Camera.main.transform);
        canvas.gameObject.transform.rotation = Quaternion.Euler(0, Camera.main.transform.eulerAngles.y, 0);
    }
}
