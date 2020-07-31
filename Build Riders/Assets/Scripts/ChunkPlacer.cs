using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChunkPlacer : MonoBehaviour
{
    public Transform CheckTransform;
    public int spawnDistance = 15;
    public int despawnCount = 5;
    public ChunkScript[] ChunksPrefs;
    public ChunkScript FirstChunk;

    private List<ChunkScript> spawnedChunks = new List<ChunkScript>();
     private void Start()
    {
        spawnedChunks.Add(FirstChunk);
    }

    private void FixedUpdate()
    {
        if (CheckTransform.position.z > spawnedChunks[spawnedChunks.Count - 1].endPoint.position.z - spawnDistance)
        {
            SpawnChunk();
        }
    }

    private void SpawnChunk()
    {
        ChunkScript newChunk = Instantiate(ChunksPrefs[Random.Range(0, ChunksPrefs.Length)]);
        newChunk.transform.position = spawnedChunks[spawnedChunks.Count - 1].endPoint.position - newChunk.startPoint.localPosition;
        spawnedChunks.Add(newChunk);

        if (spawnedChunks.Count >= despawnCount)
        {
            Destroy(spawnedChunks[0].gameObject.gameObject);
            spawnedChunks.RemoveAt(0);
        }
    }
}
