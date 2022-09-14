using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robot : MonoBehaviour
{
    public GameObject robot;
    void Start()
    {
    }

    void Update()
    {
    }

    public void RotateLeft()
    {
        robot.transform.Rotate(0.0f, 10.0f, 0.0f, Space.Self);
    }

    public void RotateRight()
    {
        robot.transform.Rotate(0.0f, -10.0f, 0.0f, Space.Self);
    }

    public void TranslateUp()
    {
        robot.transform.Translate(Vector3.up * Time.deltaTime * 10, Space.World);
    }

    public void TranslateDown()
    {
        robot.transform.Translate(Vector3.down * Time.deltaTime * 10, Space.World);
    }

    public void TranslateLeft()
    {
        robot.transform.Translate(Vector3.left * Time.deltaTime * 10, Space.World);
    }

    public void TranslateRight()
    {
        robot.transform.Translate(Vector3.right * Time.deltaTime * 10, Space.World);
    }

    public void Scale(float magnitud)
    {
        Vector3 changerscale = new Vector3(magnitud, magnitud, magnitud);

        robot.transform.localScale += changerscale;
    }
}


