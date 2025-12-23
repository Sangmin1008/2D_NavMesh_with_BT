using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using Random = System.Random;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private Tilemap tilemap;
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private int enemyCount = 10;

    private Vector3 _offset = new Vector3(0.5f, 0.5f, 0);
    private List<Vector3> _possibleTiles = new List<Vector3>();

    private void Awake()
    {
        tilemap.CompressBounds();
        CalculatePossibleTiles();

        for (int i = 0; i < enemyCount; i++)
        {
            int index = UnityEngine.Random.Range(0, _possibleTiles.Count);
            Instantiate(enemyPrefab, _possibleTiles[index],  Quaternion.identity, transform);
        }
    }

    private void CalculatePossibleTiles()
    {
        BoundsInt bounds = tilemap.cellBounds;
        TileBase[] allTiles = tilemap.GetTilesBlock(bounds);

        for (int y = 1; y < bounds.size.y - 1; y++)
        {
            for (int x = 1; x < bounds.size.x - 1; x++)
            {
                TileBase tile = allTiles[y * bounds.size.x + x];
                if (tile == null) continue;
                
                Vector3Int localPosition = bounds.position + new Vector3Int(x, y);
                Vector3 position = tilemap.CellToWorld(localPosition) + _offset;
                position.z = 0;
                _possibleTiles.Add(position);
            }
        }
    }
}
