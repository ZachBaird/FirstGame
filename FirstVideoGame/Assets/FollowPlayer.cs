using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;

    void Update()
    {
        // Certain objects can be accessed within a script, usually with a lowercase/camel-casing
        //  structure. For example, gameObject refers to this script's respective game object. In
        //  this case, we are using "transform", which refers to the transform of our camera since
        //  that's where this script sits.
        transform.position = player.position + offset;
    }
}
