using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCameraControl : MonoBehaviour {
    public Camera playerCamera;
    public PlayerInput inputManager;

    [SerializeField]
    private float cameraMaxSize = 1.7f, cameraMinSize = 0.1f;

    [SerializeField]
    float minX, maxX, minY, maxY;
    
    private void Update()
    {
        if(inputManager.GetMouseScroll() != 0)
        {
            playerCamera.orthographicSize += inputManager.GetMouseScroll() * 1.5f;
            playerCamera.orthographicSize = Mathf.Clamp(playerCamera.orthographicSize, cameraMinSize, cameraMaxSize);
        }
        
        if(inputManager.GetHorizontalInput() == 0 && inputManager.GetVerticalInput() == 0)
        {
            return;
        }

        playerCamera.transform.Translate(Vector3.right * inputManager.GetHorizontalInput() * Time.deltaTime);
        playerCamera.transform.Translate(Vector3.up * inputManager.GetVerticalInput() * Time.deltaTime);

        playerCamera.transform.position = new Vector3(Mathf.Clamp(playerCamera.transform.position.x, minX, maxX),
            Mathf.Clamp(playerCamera.transform.position.y, minY, maxY), playerCamera.transform.position.z);
    }
}
