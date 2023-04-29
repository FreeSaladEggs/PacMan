using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pacman : MonoBehaviour
{
    // Start is called before the first frame update
   
 
    public new Collider2D collider { get; private set; }
    public Movement movement { get; private set; }

    private void Awake()
    {
        
        collider = GetComponent<Collider2D>();
        movement = GetComponent<Movement>();
    }

    private void Update()
    {
        // Set the new direction based on the current input
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            movement.SetDirection(Vector2.up);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            movement.SetDirection(Vector2.down);
        }
        else if ( Input.GetKeyDown(KeyCode.LeftArrow))
        {
            movement.SetDirection(Vector2.left);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            movement.SetDirection(Vector2.right);
        }

        // Rotate pacman to face the movement direction
        float angle = Mathf.Atan2(movement.direction.y, movement.direction.x);
        transform.rotation = Quaternion.AngleAxis(angle * Mathf.Rad2Deg, Vector3.forward);
    }

    public void ResetState()
    {
        enabled = true;
        collider.enabled = true;
        
 
        movement.ResetState();
        gameObject.SetActive(true);
    }

    public void DeathSequence()
    {
        enabled = false;
 
        collider.enabled = false;
        movement.enabled = false;
       
    }
}
