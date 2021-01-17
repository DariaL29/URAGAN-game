using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecoManagerLeft : MonoBehaviour
{
    public GameObject[] decoPrefabs;
     public float zSpawn = 0;
    public float tileLength = 5;
    public int numberOfdecos = 3;
    private List<GameObject> activeDecos = new List<GameObject>();


    //   public Transform playerTransform;
    void Start()
    {

        for (int i = 0; i < numberOfdecos; i++)
        {
            if (i < 2)
                SpawnTile(0);
            else
                SpawnTile(Random.Range(0, decoPrefabs.Length));
        }


    }
    void Update()
    {



    }
    public void SpawnTile(int tileIndex)
    {

        GameObject go = Instantiate(decoPrefabs[tileIndex], transform.forward * zSpawn, transform.rotation);
        activeDecos.Add(go);
        zSpawn += tileLength;
    }

    private void DeleteTile()
    {
        Destroy(activeDecos[0]);
        activeDecos.RemoveAt(0);
    }
}

