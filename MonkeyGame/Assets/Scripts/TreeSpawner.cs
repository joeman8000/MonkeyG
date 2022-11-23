using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeSpawner : MonoBehaviour
{
    public GameObject prefab;
    public float spawnRate = 1f;
    public float minHeight = -3f;
    public float maxHeight = 0f;
    public float minDistance = 20f;
    public float maxDistance = 25f;
    //[SerializeField] private GameObject player;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Spawn")
        {
            //Invoke(nameof(Spawn), spawnRate);
            Spawn();
        }
    }
    private void Spawn()
    {
        GameObject trees = Instantiate(prefab, transform.position, Quaternion.identity);
        trees.transform.position = Vector3.up * Random.Range(minHeight, maxHeight);
        trees.transform.position = Vector3.right * Random.Range(minDistance + this.transform.position.x, maxDistance + this.transform.position.x);
    }
}
