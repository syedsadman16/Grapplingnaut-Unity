using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crosshair_Controller : MonoBehaviour
{
    public GameObject RedCrosshair;
    public GameObject GreenCrosshair;
    public RaycastHit hit;
    public Transform camera;
    public LayerMask whatIsGrappleable;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (camera != null) // Check if camera is not null
        {
            if (Physics.Raycast(camera.position, camera.forward, out hit, 40f, whatIsGrappleable)) // camera.position/forward --> transform.position/forward
            {
                if (hit.transform.tag == "Grappable")
                {
                    //   Debug.Log("Green Crosshair");
                    RedCrosshair.gameObject.SetActive(false);
                    GreenCrosshair.gameObject.SetActive(true);
                }

            }
            else
            {
                //   Debug.Log("Red crosshair");
                RedCrosshair.gameObject.SetActive(true);
                GreenCrosshair.gameObject.SetActive(false);
            }

        }
    }

}
