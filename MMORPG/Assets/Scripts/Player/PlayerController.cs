using Mirror;
using UnityEngine;

public class PlayerController : NetworkBehaviour
{
    public float playerSpeed = 5f;
    public GamePlayer _player;
    public float turnSpeed;
    public float mouseSensitivity = 20f;
    public GameObject minimapCamera;

    private Rigidbody _playerRigidBody;
    private float _moveX;
    private float _moveZ;
    private float _mouseX;




    public override void OnStartLocalPlayer()
    {
        Instantiate<GameObject>(minimapCamera);
        _playerRigidBody = GetComponent<Rigidbody>();
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
        _moveX = Input.GetAxis("Horizontal");
        _moveZ = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * playerSpeed * _moveZ);
    }

    public void RotatePlayer()
    {
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * _moveX);
    }

    public void RotatePlayerWithMouse()
    {
        if(Input.GetMouseButton(1))
        {
        }
    }
}
