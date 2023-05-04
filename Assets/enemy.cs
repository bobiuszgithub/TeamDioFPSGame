using System.Diagnostics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.TextCore.Text;
using UnityEngine.UI;

public class enemy : MonoBehaviour
{

    public NavMeshAgent Enemy;
    public Transform player;
    public float EnemyHp;
    public GameObject PlayerInfo;
    private CharacterInfo info;
    [SerializeField] private float timer = 5;
   // private float bulletTime;

    //public GameObject enemyBullet;
    //public Transform spawnPoint;
    public float enemySpeed;
    // Start is called before the first frame update

    public bool PlayerinSight;


    public Slider ENEMYHPUI;

    void Start()
    {
        PlayerinSight = false;
        info = PlayerInfo.GetComponent<CharacterInfo>();
        ENEMYHPUI.maxValue = EnemyHp;
        ENEMYHPUI.value = EnemyHp;
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerinSight)
        {
            Enemy.SetDestination(player.position);
        }
        
        if (EnemyHp <= 0)
        {
            Destroy(gameObject);
        }
        //ShootAtPlayer();
       
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Bullet")
        {
            EnemyHp = EnemyHp - 1;
            ENEMYHPUI.value = EnemyHp;
        }
        if (other.gameObject.tag == "Player")
        {
            info.HP = info.HP - 10;
            info.jatekoselete.value = info.HP;
            info.HPtext.text = info.HP.ToString();
        }
    }
    //private void OnCollisionEnter(Collision collision)
    //{
        

    //}
 

    //void ShootAtPlayer()
    //{
    //    bulletTime = bulletTime-Time.deltaTime;
    //    if (bulletTime > 0) return;
    //    bulletTime = timer;

    //    GameObject bulletObj = Instantiate(enemyBullet, spawnPoint.transform.position, spawnPoint.transform.rotation) as GameObject;
    //    Rigidbody bulletRig = bulletObj.GetComponent<Rigidbody>();
    //    bulletRig.AddForce(bulletRig.transform.forward * enemySpeed);
    //    Destroy(bulletObj, 5f);
    //}

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject.tag == "Player")
    //    {
    //        Destroy(bulledObj);
    //    }
    //}


}
