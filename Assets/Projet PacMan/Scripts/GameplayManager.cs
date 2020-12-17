using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameplayManager : MonoBehaviour
{
    public static GameplayManager Instance;

    public GameObject Player;
    public Text scoreTxt;
    public Text pacgumTxt;
    public Text scoreTxtW;
    public Text pacgumTxtW;
    //public Text timeTxt;
    public float Score = 0;
    public float pacgum = 0;
    public Tilemap tilemap;
    public Grid grid;
    public BoundsInt bounds;
    private Node[][] myGraph;
    private Vector3Int origin;
    public GameObject Pacgum;
    public Sprite tilevide;
    public GameObject panelGameOver;
    public GameObject panelWin;
    public GameObject spawnerblinky;
    public GameObject spawnerinky;
    public GameObject spawnerpinky;
    public GameObject spawnerclyde;
    public float max;


    // Start is called before the first frame update
    void Start()
    {
        Level();
    }

    // Update is called once per frame
    void Awake()//if not exist an instance, the instance is this, if exist an instance our instance is destroy
    {
        if (Instance == null)
        { Instance = this; }
        else if (Instance != null)
        { Destroy(gameObject); }
    }

    public void Update()//if pacgum not exist, use ShoWin function
    {
        if (pacgum >= max)
        {
            Instance.ShowWin();
        }
    }
    void Level() //separate tile floor and tile wall
    {

        float cellsize = grid.cellSize.x;
        bounds = tilemap.cellBounds;
        myGraph = new Node[bounds.size.x][];
        List<Node> myList = new List<Node>();

        for(int i=0; i < bounds.size.x; i++) //create node list between x,y coordinates
        {
            myGraph[i] = new Node[bounds.size.y];
        }

        origin = tilemap.origin;

            foreach (Vector3Int pos in bounds.allPositionsWithin) //foreach position on tile in tilemap
            {
                TileBase basetruc = tilemap.GetTile(pos);

                var worldPos = (Vector3)pos;

                if (basetruc == null)
                {
                continue;
                }

                else
                {
                    var tile = ((Tile)basetruc);

                    if(tile.sprite == tilevide) //if the actual sprite is equal at the sprite in parameter,
                    {
                        var posInMap = pos - origin;
                        myGraph[posInMap.x][posInMap.y] = new Node(posInMap.x * 100 + posInMap.y);
                        myList.Add(myGraph[posInMap.x][posInMap.y]);
                        Instantiate(Pacgum, worldPos * cellsize, Quaternion.identity);// instantiate the pacgum on all tile floor
                    }
                }
            }

            /*for(int i = 0; i < myList.Count; i++)
            {
                if 
            }*/
    }

    public void ShowGameOver()//the panel GameOver is active and it show number of pacgum eaten and the score
    {
        panelGameOver.SetActive(true);
        scoreTxt.text = "Score:" + Score;
        pacgumTxt.text = "Pacgum:" + pacgum;
        Time.timeScale = 0f;
    }

    public void ShowWin()//the panel Win is active and it show number of pacgum eaten and the score
    {
        panelWin.SetActive(true);
        scoreTxtW.text = "Score:" + Score;
        pacgumTxtW.text = "Pacgum:" + pacgum;
        Time.timeScale = 0f;
    }

    public void OnClick_Menu()//if click the buton Menu, we go to Menu scene
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }
    public void OnClick_Retry()//if click the buton Retry, we revive the game scene
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
    }

}
