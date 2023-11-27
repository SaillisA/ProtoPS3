using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joueur : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject joueur;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKey(KeyCode.RightArrow))
        {
            joueur.gameObject.transform.position = joueur.gameObject.transform.position + Vector3.right * 3;
        }
    }
}
