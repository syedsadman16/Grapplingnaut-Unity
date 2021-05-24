using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileSpawner : MonoBehaviour
{

    public GameObject projectile;
    public int projectileCount;
    private BoxCollider collider;
    public GameObject terrain;
    public int speed;


    // Start is called before the first frame update
    void Start()
    {
        collider = terrain.GetComponent<BoxCollider>(); // Get this tiles collider
       // SpawnProjectile();
    }

    /*
    public void SpawnProjectile()
    {
        Vector3 beginSpawnPoint = RandomProjectileCoordinate();
        Vector3 endSpawnPoint = new Vector3(collider.bounds.max.x, 5, 5);

        Instantiate(projectile, endSpawnPoint, Quaternion.identity, transform);
        projectile.GetComponent<ProjectileMovement>().positions = beginSpawnPoint; // Move towards front tile
        projectile.GetComponent<ProjectileMovement>().speed = speed;

    }
    */
    /*
    // Random spawn locations for projectiles
    Vector3 RandomProjectileCoordinate()
    {
        int x = (int)collider.bounds.min.x;
        int y = 2;
        int z = 0;
        float spacing = 2f;

        y = (int)Random.Range(collider.bounds.max.y / 2, collider.bounds.max.y);
        z = (int)Random.Range(collider.bounds.min.z + 2, collider.bounds.max.z - 2);
        */
        /* Generate new coordinate with some padding */
       // Vector3 coord = new Vector3(x, y, z + (z * spacing));

        /* Get new coordinate if it already exists */
      //  if (prevPoints.Contains(coord)) return RandomCoordinate();

       // return coord;
   // }

    

}
