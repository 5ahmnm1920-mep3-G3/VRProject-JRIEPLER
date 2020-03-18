using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Planet { Mars, Venus, Earth}


public class Door_Script : MonoBehaviour
{
    
    public Animator animator;
    public Planet planet;
    private string planetTag;
    public GameManager gameManager;


    private void Start()
    {
        switch (planet)
        {
            case Planet.Mars:
                planetTag = "Mars";
                break;
            case Planet.Venus:
                planetTag = "Venus";
                break;
            case Planet.Earth:
                planetTag = "Earth";
                break;
            default:
                break;
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (!other.collider.CompareTag(planetTag)) return;
        animator.enabled = true;
        gameManager.CompletetPlanet();
        Destroy(other.gameObject);
    }
}
