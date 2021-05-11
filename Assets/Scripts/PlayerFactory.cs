using UnityEngine;


public class PlayerFactory : IPlayerFactory
{
    private readonly IWeapon _weapon;
    private readonly IMove _move;

    public PlayerFactory(IWeapon weapon, IMove move)
    {
        _weapon = weapon;
        _move = move;
    }

    public IPlayer CreatePlayer(int hp)
    {
        return new Player(hp, _weapon, _move);
    }
}
