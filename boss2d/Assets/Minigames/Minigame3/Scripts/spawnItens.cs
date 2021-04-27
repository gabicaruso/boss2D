using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnItens : MonoBehaviour
{
    // public GameObject item1Prefab;
    // public GameObject item2Prefab;
    // public GameObject item3Prefab;
    public GameObject player;
    public GameObject badItem;

    public List<GameObject> ItemsToSpawn;

    // Start is called before the first frame update
    public float SpawnTime;
    //    public GameObject Object1;
    //    public GameObject Object2;

    // Use this for initialization
    void Start () {
        StartCoroutine(SpawnObject());
    }

    public IEnumerator SpawnObject() {
        int rand = 0;
        GameObject toSpawn;
        rand = Random.Range(0, ItemsToSpawn.Count);
        toSpawn = ItemsToSpawn[rand];
        int i = Random.Range (0, 6);
        Instantiate(toSpawn, new Vector3(Random.Range(-6f,6f),6,0), Quaternion.identity);
        yield return new WaitForSeconds(SpawnTime);
        Instantiate(badItem, new Vector3(Random.Range(-5.5f,5.5f),10,0), Quaternion.identity);
        StartCoroutine(SpawnObject());
    }

    
}
