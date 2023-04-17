//using System.Collections;
//using System.Collections.Generic;
//using TMPro;
//using UnityEngine;

//public class camera_grande : MonoBehaviour
//{
//    [SerializeField] private Camera cam;
//    [SerializeField] GameObject CamRef;
//    Vector3 refVelocity = Vector3.zero;
//    float smoothTime = 0.2f;
//    // Start is called before the first frame update
//    void Start()
//    {
        
//    }

//    // Update is called once per frame
//    void Update()
//    {
        
//    }
//    private void OnTriggerEnter2D(Collider2D collision)
//    {
//        if (collision.tag == ("Player"))
//        {
//            cam.GetComponent<CameraManager>().enabled = false;

//            Vector3 targetPosition = new Vector3(CamRef.transform.position.x + 8, CamRef.transform.position.y + 2, -10);

//            cam.transform.position = Vector3.SmoothDamp(gameObject.transform.position, targetPosition, ref refVelocity, smoothTime);
//            cam.GetComponents<Camera>().
//        }
//    }
//    private void OnTriggerExit2D(Collider2D collision)
//    {
//        cam.GetComponent<CameraManager>().enabled = true;
//    }

// }
