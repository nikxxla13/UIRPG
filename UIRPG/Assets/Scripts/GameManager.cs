using Unity.PlasticSCM.Editor.UI;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Player player;
    public Enemy enemy;
    public Character character;
    void start()
    {
        player.Shout();
        Debug.Log("player name" + player.CharName);
        enemy.Shout();
        character.Shout();
    }
    
}
