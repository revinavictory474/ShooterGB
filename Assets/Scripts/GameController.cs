using UnityEngine;

public class GameController : MonoBehaviour
{
    private Player player;

    private void Awake()
    {
        IPlayerFactory playerFactory = new PlayerFactory();
        player = playerFactory.Create();    
    }

}
