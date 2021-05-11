using UnityEngine;

public class GameController : MonoBehaviour
{
    IPlayerFactory factory;
    IPlayer player;

    private void Awake()
    {
        GameObject cam = GameObject.FindGameObjectWithTag("MainCamera");
        factory = new PlayerFactory(new Weapon(), new MovementPlayer(transform, 6, 80, cam.transform, GetComponent<CharacterController>()));
    }

    private void Start()
    {
        player = factory.CreatePlayer(100);
    }

    private void Update()
    {
        player.Move.Move();
    }
}
