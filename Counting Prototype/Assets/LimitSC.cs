using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitSC : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Sphere"))
        {
            Destroy(other.gameObject);
        }
    }
}
