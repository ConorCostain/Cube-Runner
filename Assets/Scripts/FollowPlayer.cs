using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public Transform player;
    public Vector3 offset;
    private Vector3 pos;
	
	// Update is called once per frame
	void Update () {
        pos = player.position + offset;
        //pos.x = 0;
        transform.position = pos;
        

        
	}
}
