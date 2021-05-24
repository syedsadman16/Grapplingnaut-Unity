using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMovement : MonoBehaviour
{
    PlayerMovement playerMovement;
    //public GameObject positions;
    public Vector3 positions;
    public GameObject character;
    public float speed;
    public GameObject explosionPrefab;

    void Start()
    {
        playerMovement = GameObject.FindObjectOfType<PlayerMovement>();
    }

    void Update()
    {
        //.transform.position
        if (transform.position == positions)
        {
            //Instantiate(explosionPrefab, gameObject.transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
     
        transform.position = Vector3.MoveTowards(transform.position, positions, Time.deltaTime * speed);

    }

    private void OnCollisionEnter(Collision collision)
    {

        Debug.Log("Collisison" + collision.gameObject.name);
        GameObject player = character.transform.GetChild(0).gameObject;

        if (collision.gameObject.name == player.name)
        {
            Instantiate(explosionPrefab, gameObject.transform.position, Quaternion.identity);
            Destroy(this.gameObject);
            //playerMovement.Die();
        }
    }

}
