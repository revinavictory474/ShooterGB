
public interface IPlayer
{
    int Hp { get; set; }
    IWeapon Weapon { get; set; }
    IMove Move();
    IJump Jump();
}
