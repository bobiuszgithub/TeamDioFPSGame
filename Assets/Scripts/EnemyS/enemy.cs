using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class enemy : MonoBehaviour
{

    public NavMeshAgent Enemy;
    public Transform player;
    public float EnemyHp;
    public GameObject PlayerInfo;
    private CharacterInfo info;
    [SerializeField] private float timer = 5;

    public float enemySpeed;


    public bool PlayerinSight = false; 

    public Slider ENEMYHPUI;


   
    public GameObject drop;


    void Start()
    {


        
        if (PlayerInfo != null)
        {
            info = PlayerInfo.GetComponent<CharacterInfo>();
        }
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

            if (drop != null)
            {
                Instantiate(drop, this.transform.position, this.transform.rotation);
            }
            Destroy(gameObject);
        }


    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Sword")
        {
            EnemyHp = EnemyHp - 20;
            ENEMYHPUI.value = EnemyHp;
        }
        if (other.gameObject.tag == "PistolBullet")
        {
            EnemyHp = EnemyHp - 25;
            ENEMYHPUI.value = EnemyHp;
        }
        if (other.gameObject.tag == "SMGBullet")
        {
            EnemyHp = EnemyHp - 30;
            ENEMYHPUI.value = EnemyHp;
        }
        if (other.gameObject.tag == "ShotgunBullet")
        {
            EnemyHp = EnemyHp - 35;
            ENEMYHPUI.value = EnemyHp;
        }
        if (other.gameObject.tag == "Explosion")
        {
            EnemyHp = EnemyHp - 100;
            ENEMYHPUI.value = EnemyHp;
        }
        if (other.gameObject.tag == "Player")
        {
            if (info != null)
            {
                info.HP = info.HP - 10;
                info.jatekoselete.value = info.HP;
                info.HPtext.text = info.HP.ToString();
            }
        }

    }


}
