using CodeMonkey;
using CodeMonkey.Utils;
using UnityEngine;

public class GameLogic : MonoBehaviour
{
    private void Start()
    {
        Debug.Log("GameLogic.Init");

        CreateSprite(GameAssets.i.gun);
    }
    private static void CreateSprite(Sprite sprite)
    {
        UtilsClass.CreateWorldSprite("Sprite", sprite, Vector3.zero, new Vector3(20, 20), 0, Color.white);
    }
}
