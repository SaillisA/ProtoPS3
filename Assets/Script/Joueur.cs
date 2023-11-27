using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Joueur : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject joueur;
    public GameObject cam;
    public Image cameraJoueur;

    public GameObject imageboutontest;



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }




    //Fonctions pour les boutons de deplacements

    public void JoueurDroite()
    {
        joueur.gameObject.transform.position = joueur.gameObject.transform.position + Vector3.right * 0.07f;
    }
    public void JoueurGauche()
    {
        joueur.gameObject.transform.position = joueur.gameObject.transform.position + Vector3.left * 0.07f;
    }
    public void JoueurAvant()
    {
        joueur.gameObject.transform.position = joueur.gameObject.transform.position + Vector3.forward * 0.07f;
    }
    public void JoueurDerriere()
    {
        joueur.gameObject.transform.position = joueur.gameObject.transform.position + Vector3.back * 0.07f;
    }

    //fonctions pour les boutons de camera

    public void CameraHaut()
    {
        cameraJoueur.gameObject.transform.Rotate(-1, 0, 0);  
    }
    public void CameraDroite()
    {
        joueur.gameObject.transform.Rotate(0,1,0);
    }
    //joueur.gameObject.transform.rotation
    public void CameraGauche()
    {
        joueur.gameObject.transform.Rotate(0,-1,0); 
    }
    public void CameraBas()
    {
        cameraJoueur.gameObject.transform.Rotate(1,0,0);
    }
}
