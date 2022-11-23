using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] private GameObject player;
    public float xdist = 4f;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(player.transform.position.x + xdist, transform.position.y, transform.position.z);
    }
}
