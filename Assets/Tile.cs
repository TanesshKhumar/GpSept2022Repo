using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public TileData data;
    [SerializeField] SpriteRenderer spriteRenderer;
    
    public void SetTileColor()
    {
        if (data.type == TileType.RED)
        {
            spriteRenderer.color = Color.red;
        }
        else if (data.type == TileType.BLUE)
        {
            spriteRenderer.color = Color.blue;
        }
        else if(data.type == TileType.YELLOW){

            spriteRenderer.color = Color.yellow;
        }
        }
}
