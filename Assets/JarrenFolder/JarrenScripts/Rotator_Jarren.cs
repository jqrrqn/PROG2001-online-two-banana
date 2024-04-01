using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator_Jarren : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        // Rotate the object on X, Y, and Z axes by specified amounts, adjusted for frame rate.
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }

}