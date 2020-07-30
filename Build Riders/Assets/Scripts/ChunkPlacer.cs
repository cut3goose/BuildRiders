using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChunkPlacer : MonoBehaviour
{
    public Transform CheckTransform;
    
    public ChunkScript[] ChunksPrefs;
    public ChunkScript FirstChunk;

    public List<ChunkScript> spawnedChunks = new List<ChunkScript>();
     private void Start()
    {
        spawnedChunks.Add(FirstChunk);
    }

    private void FixedUpdate()
    {
        if (CheckTransform.position.z > spawnedChunks[spawnedChunks.Count - 1].endPoint.position.z - 15)
        {
            SpawnChunk();
        }
    }

    private void SpawnChunk()
    {
        ChunkScript newChunk = Instantiate(ChunksPrefs[Random.Range(0, ChunksPrefs.Length)]);
        newChunk.transform.position = spawnedChunks[spawnedChunks.Count - 1].endPoint.position - newChunk.startPoint.localPosition;
        spawnedChunks.Add(newChunk);

        if (spawnedChunks.Count >= 5)
        {
            Destroy(spawnedChunks[0].gameObject.gameObject);
            spawnedChunks.RemoveAt(0);
        }
    }
}
