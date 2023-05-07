using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTankMovement : MonoBehaviour
{
    [SerializeField] GameObject SelectionRing;
    // Start is called before the first frame update
    void Start()
    {
        SelectionRing.GetComponent<SpriteRenderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseEnter()
    {
        SelectionRing.GetComponent<SpriteRenderer>().enabled = true;
    }

    private void OnMouseExit()
    {
        SelectionRing.GetComponent<SpriteRenderer>().enabled = false;
    }
}
