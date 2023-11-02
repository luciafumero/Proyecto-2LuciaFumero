using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigo : MonoBehaviour
{
    public float speed;
    Transform objetivo;
    float tiempoDePartida = 0.0f;
    bool estaJugando = true;
    [SerializeField]
    GameObject mensajefall;

    void Start()
    {
        objetivo = GameObject.FindGameObjectWithTag("jugador").GetComponent<Transform>();
    }
    
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, objetivo.position, speed * Time.deltaTime);
        if (estaJugando)
        {
            tiempoDePartida = Time.deltaTime;
        }
    }

    private void OnTriggerEnter(Collider Derrota)
    {
        if (Derrota.tag == "jugador")
        {
            Time.timeScale = 0;
            estaJugando = false;
            mensajefall.SetActive(true);
        }
    }
}
