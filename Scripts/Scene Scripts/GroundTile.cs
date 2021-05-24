using UnityEngine;
using System.Collections;
using System.Collections.Generic;


/*
 * This script deals with everything that happens inside the 
 * GroundTile. Set up box colliders, generate objects and 
 * projectiles, and o  on. 
 * 
 * HOW TO USE:
 * This script should be assigned to the GroundTile itself
 */
public class GroundTile : MonoBehaviour {

    GroundSpawner groundSpawner;

    /* Load asteroids and projectiles 
     * serializable: so that Unity can save and load those values */
    [SerializeField] GameObject rockPrefab_Small; 
    [SerializeField] GameObject rockPrefab_Medium;
    [SerializeField] GameObject rockPrefab_Large;
    [SerializeField] GameObject HardStar; // QUOC ADDED
    public GameObject projectile;
    public int asteroidCount;
    public int projectileCount;
    public int speed;
    public int HardStarCount; // QUOC ADDED
    public GameObject terrain;
  //  public GameObject portal;
  //  public float Score_To_Display_Portal;
    float score;
   // int portalSpawned;

    private List<Vector3> prevPoints;
    private BoxCollider collider;

  
    private void Start ()
    {
        groundSpawner = GameObject.FindObjectOfType<GroundSpawner>(); // Find GroundSpawner Game Object
        prevPoints = new List<Vector3>(); // Init list to track previous pointss
        collider = terrain.GetComponent<BoxCollider>(); // Get this tiles collider

        SpawnObstacle(rockPrefab_Small, asteroidCount);
        SpawnObstacle(HardStar, HardStarCount); // QUOC ADDED 

        /*
        portalSpawned = PlayerPrefs.GetInt("portalSpawned", 0);
        
        if (portalSpawned == 1)
        {
            Debug.Log("Spawn Portal");
            PlayerPrefs.SetInt("portalSpawned", 0);
            GameObject tmp = Instantiate(portal);
            tmp.gameObject.transform.position = new Vector3(collider.bounds.min.x, collider.bounds.max.y/2, collider.bounds.min.z / 3); // Spawn  
        }
        */


        //W StartCoroutine(Delay());

    }

    void Update()
    {
/*
        score = PlayerPrefs.GetFloat("score", 0);

        if (score > Score_To_Display_Portal && score < (Score_To_Display_Portal + 0.01))
        {
            PlayerPrefs.SetInt("portalSpawned", 1);
        }
*/

    }


    /* Once player leaves tile, generate more */
    private void OnTriggerExit (Collider other)
    {
        groundSpawner.SpawnTile(true);
   
    }




    private void OnTriggerEnter(Collider other)
    {
       // projectile.GetComponent<ProjectileMovement>().speed = 100;
       // StartCoroutine(Delay());
    }






    /* Spawn Grapple object of type "obj" for set "amount" of times */
    public void SpawnObstacle (GameObject obj, int amount)
    {

       

        for (int i = 0; i < amount; i++)
        {
            GameObject tmp = Instantiate(obj);
            Vector3 randomPoint = RandomCoordinate(); // Get random spawn coordinate
            prevPoints.Add(randomPoint); // Track coordinate to prevent overlap
            tmp.gameObject.transform.position = new Vector3(randomPoint.x, randomPoint.y, randomPoint.z); // Spawn

        }

       
        /*
        // Choose a random point to spawn the asteroids
        int obstacleSpawnIndex = Random.Range(12, 112);
        Transform spawnPoint_obstacle = transform.GetChild(obstacleSpawnIndex).transform;

        // Randomize the sizes of the asteroids
        int random = Random.Range(0, 10);
        if(random < 2)
        {
            Instantiate(rockPrefab_Small, spawnPoint_obstacle.position, Quaternion.identity, transform);
        }
        else if (random >= 2 && random < 4)
        {
            Instantiate(rockPrefab_Medium, spawnPoint_obstacle.position, Quaternion.identity, transform);
        }
        else
        {
            Instantiate(rockPrefab_Large, spawnPoint_obstacle.position, Quaternion.identity, transform);
        }
        */
    }


  
  // Random coordinates for asteroids
    Vector3 RandomCoordinate()
    {
        int x = 0;
        int y = 0;
        int z = 0;
        float spacing = 0.1f;

        x = (int) Random.Range(collider.bounds.min.x + 2 , collider.bounds.max.x - 2);
        y = (int) Random.Range(collider.bounds.max.y / 2 , collider.bounds.max.y);
        z = (int) Random.Range(collider.bounds.min.z + 2 , collider.bounds.max.z - 2);

        /* Generate new coordinate with some padding */
        Vector3 coord = new Vector3(x + (x * spacing), y + (y * spacing), z + (z * spacing));

        /* Get new coordinate if it already exists */
        if (prevPoints.Contains(coord)) return RandomCoordinate();

        return coord;
    }



}