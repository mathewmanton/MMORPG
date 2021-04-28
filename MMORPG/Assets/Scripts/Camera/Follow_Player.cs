using UnityEngine;

public class Follow_Player : MonoBehaviour
{
    [SerializeField]
    public GameObject player;
    [SerializeField]
    public Vector3 offset;
    [SerializeField]
    public Space offsetPositionSpace = Space.Self;
    [SerializeField]
    public bool lookAt = false;

    // Update is called once per frame
    private void Update()
    {
        if (player)
        {
            // compute position
            if (offsetPositionSpace == Space.Self)
            {
                transform.position = player.transform.TransformPoint(offset);
            }
            else
            {
                transform.position = player.transform.position + offset;
            }

            // compute rotation
            if (lookAt)
            {
                transform.LookAt(player.transform);
            }
            else
            {
                transform.rotation = player.transform.rotation;
            }
        }
    }
}
