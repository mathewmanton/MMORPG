using Mirror;
using UnityEngine;

public class Minimap : MonoBehaviour
{
    public float yOffset;
    private GameObject localPlayer;
    private Vector3 position;

    private void Start()
    {
        localPlayer = NetworkClient.localPlayer.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        position = localPlayer.transform.position;
        position.y = yOffset;
        transform.position = position;
    }
}
