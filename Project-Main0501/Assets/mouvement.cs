using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouvement : MonoBehaviour
{
    public Vector3 front = new Vector3(1, 0, 0);
    public Vector3 back = new Vector3(-1, 0, 0);

    private Rigidbody rg;
    public float jumpspeed = 5.0F;  // vitesse de saut
    public float runningSpeed; //vitesse de run


    void Start()
    {
        rg = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Mouvement avant/arrière
        if (Input.GetKey(KeyCode.Z))
        {
            transform.Translate(front * runningSpeed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(back * runningSpeed);
        }

        // Rotation
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(Vector3.up, -1);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up, 1);
        }

        // Saute lorsqu'on appuie sur la touche espace 
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rg.AddForce(Vector3.up * jumpspeed, ForceMode.Impulse);
        }

        //change la vitesse en appuyant sur shift
        if (Input.GetKey(KeyCode.LeftShift)) {
            runningSpeed = 0.05F;
        } else {
            runningSpeed = 0.01F;
        }
    }
}
