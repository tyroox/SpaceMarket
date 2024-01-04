using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomObjectSpawner : MonoBehaviour
{

    public GameObject[] myObjects;
    public float secondsBetweenSpawn;
    public float elapsedTime = 0.0f;

    void Update()
    {
        elapsedTime += Time.deltaTime;

        if (elapsedTime > secondsBetweenSpawn)
        {
            elapsedTime = 0;            

            int randomIndex = Random.Range(0, myObjects.Length);
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-1.3f, 1.3f), 5, Random.Range(-1f, 2f));
            Instantiate(myObjects[randomIndex], randomSpawnPosition, Quaternion.identity);
            
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.collider.gameObject, 5);
    }
}