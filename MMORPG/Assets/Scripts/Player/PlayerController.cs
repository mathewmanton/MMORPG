using UnityEngine;

public class PlayerController
{
    public GamePlayer player;
    public Rigidbody playerRigidBody;
    public float turnSpeed;
    private float moveX;
    private float moveZ;
    [SerializeField]
    private GameObject playerNameText;
    bool isLocalPlayer;

    // Start is called before the first frame update
    public void OnStartLocalPlayer()
    {
        //Camera.main.GetComponent<Follow_Player>().player = gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        playerNameText.transform.LookAt(Camera.main.transform);
        playerNameText.transform.localScale = new Vector3(-1, 1, 1);

        //Player on the running client
        if (isLocalPlayer)
        {
            moveX = Input.GetAxis("Horizontal");
            moveZ = Input.GetAxis("Vertical");
            //transform.Translate(Vector3.forward * Time.deltaTime * player.speed * moveZ);
            //transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * moveX);
        }
    }
}
