using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelRenderer : MonoBehaviour
{
    [SerializeField] private SpriteRenderer tileRef;
    private List<SpriteRenderer> tiles;
    private bool[,] map =
    {
        { false, false, false}, 
        { false, true, false}, 
        { false, true, false}
    };

    void Start()
    {
        for (int i = 0; i < map.GetLength(0); i++)
        {
            for (int j = 0; j < map.GetLength(1); j++)
            {
                var tile = Instantiate(tileRef, transform);
                tile.transform.localPosition = new Vector3(i, j);
                tile.color = map[i, j] ? Color.black : Color.white;
            }
        }
    }

   
}
