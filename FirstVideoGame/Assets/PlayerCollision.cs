using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;

    void OnCollisionEnter(Collision collisionInfo)
    {
        switch(collisionInfo.collider.tag)
        {
            case "Obstacle":
                movement.enabled = false;
                break;
            default:
                break;
        }
    }
}
