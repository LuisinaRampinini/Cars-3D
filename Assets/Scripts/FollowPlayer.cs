
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;

    private Vector3 offset = new Vector3(0, 4, -5);
    
    private void Update()
    {
        this.transform.position = player.transform.position
                                  + offset;
    }
}
    

    
