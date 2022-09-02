using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastEmitter : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit2D hit = Physics2D.GetRayIntersection(ray);

        if(hit.collider != null)
        {
            Debug.Log(hit.collider.name);
        }
        else
        {
            Debug.Log("Rien touché");
        }
    }
}
