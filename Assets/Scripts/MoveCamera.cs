using UnityEngine;

public class MoveCamera : MonoBehaviour {

    public Transform player;

    void Update() {
        if (!PauseMenu.isPaused)
        {
            transform.position = player.transform.position;
        }
       
    }
}
