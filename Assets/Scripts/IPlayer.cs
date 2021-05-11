
public interface IPlayer
{
    int Hp { get; set; }
    IWeapon Weapon { get; set; }
    //MovementPlayer Movement { get; set; }
    IMove Move { get; }
    //IJump Jump { get;  }
}
