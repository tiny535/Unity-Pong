using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarMovementScriptP2 : MonoBehaviour
{
    private float HORIZONTAL_OFFSET = 9.5f;
    private float VERTICAL_BOUNDARY = 4.45f;
    public float movementSpeed = 5;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(HORIZONTAL_OFFSET, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) && transform.position.y < VERTICAL_BOUNDARY) {
            transform.position = transform.position + (Vector3.up * movementSpeed) * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.DownArrow) && transform.position.y > -VERTICAL_BOUNDARY) {
            transform.position = transform.position + (Vector3.down * movementSpeed) * Time.deltaTime;
        }
    }
}
