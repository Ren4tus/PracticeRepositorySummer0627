using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    [SerializeField]
    private GameObject Player;

    public Vector3 Offset;
    public float CameraRotation;
    // Start is called before the first frame update
    void Start()
    {
        this.transform.rotation = Quaternion.Euler(CameraRotation, 0, 0);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Player.transform.position + Offset;
    }
}
