using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RayCastEmitter : MonoBehaviour
{
    //nombre de mouvements 0-255
    public byte moves {
        get
        {
            return Moves;
        }
        set
        {
            Debug.Log("Moves is changed by " + value);
            moveTextGUI.text = value.ToString();
            Moves = value;
        }
    }
    private byte Moves;

    public GameObject  moveTextGameobjectInterface;

    //Le text de l'interface
    private TextMeshProUGUI moveTextGUI;

    private void Start()
    {
        moveTextGUI = moveTextGameobjectInterface.GetComponent<TextMeshProUGUI>();

        moves = 10;
    }


    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            if(moves > 0) { 
                moves--;

                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

                RaycastHit2D hit = Physics2D.GetRayIntersection(ray);

                if (hit.collider != null)
                {
                    Debug.Log(hit.collider.name);
                    Destroy(hit.collider.gameObject);
                }
                else
                {
                    Debug.Log("Rien touché");
                }
            }
            else
            {
                Debug.Log("Plus de coups");
            }
        }
    }
}
