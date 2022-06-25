using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnControler : MonoBehaviour
{
    public Transform spawnTarget;
    public GameObject spawnTargetPrefab;

    public void SpawnFood()
    {
        Instantiate(spawnTargetPrefab, spawnTarget.position, Quaternion.identity);

    }



}
