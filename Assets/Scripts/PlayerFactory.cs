using UnityEngine;


public class PlayerFactory : IPlayerFactory
{
    public Player Create()
    {
        var player = Object.Instantiate(Resources.Load<Player>("Player"));
        return player;
    }
}
