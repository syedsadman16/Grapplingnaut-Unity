using UnityEngine;


/*
 * The purpose of GroundSpawner script is to get new GroundTile
 * objects every time the user leaves the BoxCollider of the 
 * current GroundTile.
 * 
 * HOW TO USE:
 * Create a GameObject for the starting point of the GroundTiles and 
 * assign this script in the Inspector
 */ 
public class GroundSpawner : MonoBehaviour {

    /* Pass in the GroundTile Prefab */
    [SerializeField] GameObject groundTile;

    /* Decide how many GroundTiles to spawn at render */
    public int spawnCount;

    Vector3 nextSpawnPoint;
    


    public void SpawnTile (bool spawnItems)
    {
        GameObject temp = Instantiate(groundTile, nextSpawnPoint, Quaternion.identity);

        // Get the SpawnPoint GameObject from the GrondTile script
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;
        
    }

   
    private void Start () {
        for (int i = 0; i < spawnCount; i++) {
            SpawnTile(true);  
        }
    }

 
}