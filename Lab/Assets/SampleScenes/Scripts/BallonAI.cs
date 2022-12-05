using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class BallonAI : MonoBehaviour
{
    public List<Transform> points;
    public int nextID;
    int idChangeValue = 1;
    public float speed = 2;
    private UIManager UIMgr;
    public GameManager GM;
    [SerializeField] GameObject balloonPrefab;    
    // [SerializeField] Sprite[] balloonSprites;
    // private SpriteRenderer spriteRenderer;
    private Rigidbody2D rb;
    public Vector2 moveValue;
    public Collider2D balloon;
    const int NUM_Ballons = 5;
    private float direction = 1;
    private Vector3 movement;
    void Start()
    {
    }
    private void Reset()
    {
        Init();
    }
    private void Init()
    {
        GetComponent<BoxCollider2D>().isTrigger = true;

        GameObject root = new GameObject(name + "_root");

        root.transform.position = transform.position;

        transform.SetParent(root.transform);

        GameObject waypoints = new GameObject("Waypoints");

        waypoints.transform.SetParent(root.transform);
        waypoints.transform.position = root.transform.position;

        GameObject p1 = new GameObject("Point1"); 
        p1.transform.SetParent(waypoints.transform);
        p1.transform.position = root.transform.position;

        GameObject p2 = new GameObject("Point2"); 
        p2.transform.SetParent(waypoints.transform);
        p2.transform.position = root.transform.position;

        points = new List<Transform>();
        points.Add(p1.transform);
        points.Add(p2.transform);
    }

    private void Update(){
        MoveToNextPoint();
    }

    void MoveToNextPoint(){
        Transform goalPoint = points[nextID];
        if(goalPoint.transform.position.x > transform.position.x){
            transform.localScale = new Vector3(-1, 1, 1);
        }else{
            transform.localScale = new Vector3(1, 1, 1);
        }

        transform.position = Vector2.MoveTowards(transform.position,goalPoint.position, speed*Time.deltaTime);

        if(Vector2.Distance(transform.position, goalPoint.position) < 1f)
        {
            if(nextID == points.Count - 1)
                idChangeValue = -1;
            if(nextID ==0 )
                idChangeValue = 1;
                
            nextID += idChangeValue;
        }
    }
        private void OnTriggerEnter2D (Collider2D collision)
    {
        if(collision.gameObject.tag == "bullet")
        {
            AudioManager.instance.PlaySFX("popping");    
            GM.AddScore();
            Destroy(gameObject);

    }
    }
        void Spawn()
    {
        int xMin = -21;
        int xMax = 0;
        int yMin = 0;
        int yMax = 8;
        Vector2 position = new Vector2(Random.Range(xMin, xMax), Random.Range(yMin, yMax));
        Instantiate(balloonPrefab, position, Quaternion.identity);
        Instantiate(balloonPrefab, transform.position, transform.rotation);
    }
}