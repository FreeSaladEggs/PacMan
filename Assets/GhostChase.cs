using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class GhostChase : MonoBehaviour
{
    private void OnDisable()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Node node = other.GetComponent<Node>();

        // Do nothing while the ghost is frightened
        if (node != null && enabled )
        {
            Vector2 direction = Vector2.zero;
            float minDistance = float.MaxValue;

            // Find the available direction that moves closet to pacman
            foreach (Vector2 availableDirection in node.availableDirections)
            {
             
                Vector3 newPosition = transform.position + new Vector3(availableDirection.x, availableDirection.y);
                

                
            }

            
        }
    }
}
