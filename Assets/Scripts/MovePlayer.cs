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
        float xtranslate = Input.GetAxis("Horizontal") * Time.deltaTime;
        float ztranslate = Input.GetAxis("Vertical") * Time.deltaTime;

        rb.velocity = new Vector3(xtranslate * speedFactor, 0, ztranslate * speedFactor);

    }
}
