using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Rendering;

public class MapTileGenerator : SingletonBehavior<MapTileGenerator>
{
    public void Start()
    {
        TilePool = new Queue<GameObject>();
        SpawnTiles = new List<GameObject>();
        AddTile(new Vector2(0,0));
        AddTile(new Vector2(-TileSizeX,0));
        AddTile(new Vector2(TileSizeX,0));
        AddTile(new Vector2(0,-TileSizeY));
        AddTile(new Vector2(0,TileSizeY));
        AddTile(new Vector2(-TileSizeX,-TileSizeY));
        AddTile(new Vector2(TileSizeX,-TileSizeY));
        AddTile(new Vector2(-TileSizeX,TileSizeY));
        AddTile(new Vector2(TileSizeX,TileSizeY));
    }
    public void Update()
    {
        foreach(var t in SpawnTiles)
        {
            CheckMove(t);
        }
    }
    private void CheckMove(GameObject tile)
    {
        var p = GameManager.Instance.player;
        if(p.Position.x > tile.transform.position.x+TileSizeX)
        {
            tile.transform.position += new Vector3(TileSizeX*2,0);
        }
        if(p.Position.x < tile.transform.position.x-TileSizeX)
        {
            tile.transform.position += new Vector3(-TileSizeX*2,0);
        }
        if(p.Position.y > tile.transform.position.y+TileSizeY)
        {
            tile.transform.position += new Vector3(0,TileSizeY*2);
        }
        if(p.Position.y < tile.transform.position.y-TileSizeY)
        {
            tile.transform.position += new Vector3(0,-TileSizeY*2);
        }
    }
    private void AddTile(Vector2 pos)
    {
        var t = PullTile();
        t.transform.position = pos;
        SpawnTiles.Add(t);
    }
    private void RemoveTile(GameObject tile)
    {
        SpawnTiles.Remove(tile);
        tile.SetActive(false);
        TilePool.Enqueue(tile);
    }
    private GameObject PullTile()
    {
        if(TilePool.Count > 0)
        {
            var obj = TilePool.Dequeue();
            obj.SetActive(true);
            return obj;
        }
        var newT = Instantiate(tilePrefab);
        return newT;
    }
    public float minX;
    public float minY;
    public float maxX;
    public float maxY;
    public float cX;
    public float cY;
    public List<GameObject> SpawnTiles;
    public Queue<GameObject> TilePool;
    public const float TileSizeX = 27;
    public const float TileSizeY = 19;
    public GameObject tilePrefab;
}