using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{

    Rigidbody rb;
    [SerializeField] float speedFactor = 1;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float xOffset = Input.GetAxis("Horizontal") * Time.deltaTime * speedFactor;
        float zOffset = Input.GetAxis("Vertical") * Time.deltaTime * speedFactor;

        float xtranslate = transform.position.x + xOffset;
        float ztranslate = transform.position.z + zOffset;

        Vector3 newMouse = new Vector3(Input.mousePosition.x, 0, Input.mousePosition.y);
        Vector3 worldMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.LookAt(worldMouse);
        Debug.Log(worldMouse);
        




        transform.position = new Vector3(xtranslate, 0, ztranslate);

    }
}
