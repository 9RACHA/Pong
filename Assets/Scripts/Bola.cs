using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour {

  //Velocidad
  [SerializeField] private float velocidad = 30.0f;

  //Se ejecuta al arrancar
  void Start () {

    //Velocidad inicial hacia la derecha
    GetComponent<Rigidbody2D>().velocity = Vector2.right * velocidad;
  }

}
