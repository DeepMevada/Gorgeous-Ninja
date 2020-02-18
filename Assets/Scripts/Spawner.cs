using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform[] positions;
    public GameObject enemy;
    private void Awake()
    {
        for(int i = 0; i < positions.Length; i++)
        {
            Instantiate(enemy, positions[i].position, positions[i].rotation);
        }
    }
}
