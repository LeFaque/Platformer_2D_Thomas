using UnityEngine;
using System.Collections;

public class camera_boss : MonoBehaviour
{

    public Camera Main_Camera;
    void Start()
    {
        GetComponent<Camera>().enabled = false;
        //camera.GetComponent<camera_boss>().enabled = false;
        // camera.GetComponent<CameraManager>().enabled = true;  
    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    GetComponent<Camera>().enabled = true;
    //    Main_Camera.enabled = false;
    //}
    public void ActiveBossCamera()
    {
        GetComponent<Camera>().enabled = true;
        Main_Camera.enabled = false;
    }

    public void DeactiveBossCamera()
    {
        GetComponent<Camera>().enabled = false;
        Main_Camera.enabled = true;
    }
}