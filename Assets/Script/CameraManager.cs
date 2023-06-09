using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    [SerializeField] GameObject playerRef;
    Vector3 refVelocity = Vector3.zero;
    float smoothTime = 0.2f;
    
    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
        Vector3 targetPosition = new Vector3(playerRef.transform.position.x + 8, playerRef.transform.position.y + 2 , -10);
        gameObject.transform.position = Vector3.SmoothDamp(gameObject.transform.position, targetPosition, ref refVelocity, smoothTime);

    }

}
