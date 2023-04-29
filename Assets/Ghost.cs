using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour
{

    public Movement movement { get; private set; }
    
    public GhostScatter scatter { get; private set; }
    public GhostChase chase { get; private set; }

    public GhostBehaviour initialBehavior;
    public Transform target;
    public int points = 200;

    private void Awake()
    {
        movement = GetComponent<Movement>();
     
        scatter = GetComponent<GhostScatter>();
        chase = GetComponent<GhostChase>();
      
    }

    private void Start()
    {
        ResetState();
    }

    public void ResetState()
    {
        gameObject.SetActive(true);
        movement.ResetState();

       


        if (initialBehavior != null)
        {
            initialBehavior.Enable();
        }
    }

    public void SetPosition(Vector3 position)
    {
        
        position.z = transform.position.z;
        transform.position = position;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Pacman"))
        {
           
                FindObjectOfType<GameManager>().PacmanEaten();
            
        }
    }

}
