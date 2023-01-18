using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Asteroid settings")]

public class AsteroidManager : ScriptableObject
{
    //Asteroid
    [SerializeField] public int health = 100;
    [SerializeField] public float _minAsteroidForce;
    [SerializeField] public float _maxAsteroidForce;
    [SerializeField] public float _minAsteroidSize;
    [SerializeField] public float _maxAsteroidSize;
    [SerializeField] public float _minAsteroidTorque;
    [SerializeField] public float _maxAsteroidTorque;

    //Asteroid spawner
    [SerializeField] public float _minAsteroidSpawnTime;
    [SerializeField] public float _maxAsteroidSpawnTime;
    [SerializeField] public int _minAsteroidSpawnAmount;
    [SerializeField] public int _maxAsteroidSpawnAmount;


}
