using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereCreator : MonoBehaviour
{
    public GameObject spherePrefab;
    private float minX = -9f;
    private float maxX = 9f;
    private float minY = 10f;
    private float maxY = 14f;
    
    
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 randomPosition = new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), 8f);
            GameObject sphere = Instantiate(spherePrefab, randomPosition, Quaternion.identity);
            
        }
    }
    
}
