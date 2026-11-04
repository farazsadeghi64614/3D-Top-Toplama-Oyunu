
using UnityEngine;

public class CheckerboardGenerator : MonoBehaviour
{
    [Header("Board Materials")]
    public Material lightMaterial;
    public Material darkMaterial;

    [Header("Board Settings")]
    public int gridSize = 10;
    public float tileSize = 2.8f;
    public float tileHeight = 0.1f;
    public float boardY = 0.05f;

    void Start()
    {
        GenerateBoard();
    }

    void GenerateBoard()
    {
        // Remove previously generated tiles
        for (int i = transform.childCount - 1; i >= 0; i--)
        {
            Destroy(transform.GetChild(i).gameObject);
        }

        // Generate a centered checkerboard
        for (int x = 0; x < gridSize; x++)
        {
            for (int z = 0; z < gridSize; z++)
            {
                GameObject tile = GameObject.CreatePrimitive(PrimitiveType.Cube);

                tile.name = "Tile_" + x + "_" + z;
                tile.transform.SetParent(transform);

                float posX = (x - (gridSize - 1) / 2f) * tileSize;
                float posZ = (z - (gridSize - 1) / 2f) * tileSize;

                tile.transform.position = new Vector3(
                    posX,
                    boardY,
                    posZ
                );

                tile.transform.localScale = new Vector3(
                    tileSize,
                    tileHeight,
                    tileSize
                );

                Renderer rend = tile.GetComponent<Renderer>();

                if ((x + z) % 2 == 0)
                {
                    rend.material = lightMaterial;
                }
                else
                {
                    rend.material = darkMaterial;
                }
            }
        }
    }
}
