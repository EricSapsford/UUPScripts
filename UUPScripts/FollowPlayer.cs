using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public Transform player;
    public Vector3 offset;

    void Update() {
        // Test log per frame
        // Debug.Log(player.position);
        transform.position = player.position + offset;
    }
}
