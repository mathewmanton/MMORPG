using Mirror;
using UnityEngine;

public class PlayerController : NetworkBehaviour
{
    public float playerSpeed = 5f;
    public float turnSpeed;
    public float mouseSensitivity = 20f;
    public GameObject minimapCamera;

    private Rigidbody _playerRigidBody;
    private float _moveX;
    private float _moveZ;
    private float _mouseX;
    private GamePlayer _player;
    private Inventory _inventory;




    public override void OnStartLocalPlayer()
    {
        Instantiate<GameObject>(minimapCamera);
        _playerRigidBody = GetComponent<Rigidbody>();
        _player = GetComponent<GamePlayer>();
        _inventory = GetComponent<Inventory>();
        _inventory.SetupInventory();
    }

    // Update is called once per frame
    void Update()
    {
        //playerNameText.transform.LookAt(Camera.main.transform);
        //playerNameText.transform.localScale = new Vector3(-1, 1, 1);

        //Player on the running client
        if (isLocalPlayer)
        {
            PlayerMove();
            RotatePlayer();
        }
    }

    public void PlayerMove()
    {
        _moveZ = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * _player.speed * _moveZ);
    }

    public void RotatePlayer()
    {
        _moveX = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * _moveX);
    }

    public void RotatePlayerWithMouse()
    {
        if(Input.GetMouseButton(1))
        {
        }
    }
}
