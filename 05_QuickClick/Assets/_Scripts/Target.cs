﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{

    private Rigidbody _rigidbody;

    private float minForce = 12,
        maxForce = 16,
        maxTorque = 10,
        xRange = 4,
        ySpawnPos = -6;
    
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _rigidbody.AddForce(RandomForce(), ForceMode.Impulse);
        _rigidbody.AddTorque(RandomTorque(), RandomTorque(),
            RandomTorque(), ForceMode.Impulse);
        transform.position = RandomSpawnPos();
    }
    
    /// <summary>
    /// Genera un vector aleatorio en 3D
    /// </summary>
    /// <returns>Fuerza aleatoria para arriba</returns>
    private Vector3 RandomForce()
    {
        return Vector3.up * Random.Range(minForce, maxForce);
    }
    
    /// <summary>
    /// Genera un número aleatorio
    /// </summary>
    /// <returns>Valor aleatorio entre -maxTorque y maxTorque</returns>
    private float RandomTorque()
    {
        return Random.Range(-maxTorque, maxTorque);
    }
    
    /// <summary>
    /// Genera una posición aleatoria
    /// </summary>
    /// <returns>Posición aleatoria en 3D, con la coordenada z = 0</returns>
    private Vector3 RandomSpawnPos()
    {
        return new Vector3(Random.Range(-xRange,xRange), ySpawnPos);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}