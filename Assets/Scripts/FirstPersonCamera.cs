using UnityEngine;

public class FirstPersonCamera : MonoBehaviour
{
    public Transform player;
    private  float mouseSensitivity = 100f;
    public float cameraPitch = 0f;
    public float defaultFOV = 60f;
    public Camera mainCamera;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.visible = true;
        player = transform.parent;
        Cursor.lockState = CursorLockMode.Locked;
        mainCamera = GetComponentInChildren<Camera>();
        mainCamera.fieldOfView = defaultFOV;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        cameraPitch -= Input.GetAxis("Mouse Y") * mouseSensitivity * Time.fixedDeltaTime;
        cameraPitch = Mathf.Clamp(cameraPitch, -90f, 90f);
        mainCamera.transform.localRotation = Quaternion.Euler(cameraPitch, 0f, 0f);
        player.Rotate(Vector3.up * Input.GetAxis("Mouse X") * mouseSensitivity * Time.fixedDeltaTime);

    }
}
