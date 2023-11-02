using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coleccionables : MonoBehaviour
{ 
    void Update()
    {
        transform.Rotate(Vector3.right * 45f * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("jugador"))
        {
            gameObject.SetActive(false);
        }
    }
}
