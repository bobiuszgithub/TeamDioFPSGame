using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.PlasticSCM.Editor.WebApi;
using Unity.VisualScripting;
using UnityEngine;

public class BossLogic : MonoBehaviour
{
    [SerializeField] int maxHealth = 1000;
    private int health;
    [SerializeField] GameObject target;
    [SerializeField] float fireRate = 5;
    [SerializeField] GameObject mainProjectile;
    [SerializeField] GameObject shootingLocation;
    [SerializeField] GameObject shootingCrystal;
    [SerializeField] GameObject healthCrystal1;
    [SerializeField] GameObject healthCrystal2;
    [SerializeField] float mainPivotSpeed = 0.5f;
    [SerializeField] float shootingCrystalPivotSpeed = 1f;
    [SerializeField] GameObject shockWaveLocation;
    [SerializeField] GameObject shockWave;
    [SerializeField] GameObject RotatingWallObject;
    [SerializeField] GameObject RotatingWallSpawnLocation;
    [SerializeField] GameObject FallingCrystalObject;
    


    private bool canShoot = true;
    public bool playerIsInRoom = false;

    [SerializeField] float NumberOfRotatingWalls = 4;
    [SerializeField] int NumberOfFallingCrystals = 5;
    [SerializeField] float TimeBetweenFallingCrystals = 1.5f;
    [SerializeField] float FallingCrystalsHeight = 10f;
    //[SerializeField] float RotatingWallSpeed = 1;
    [SerializeField] float rotateAttackLenght = 7f;
    [SerializeField] float randomAttackResetTime = 5;
    [SerializeField] float TimeBetweenShockWave = 1;
    [SerializeField] float NumberOfShockWaves = 5;
    private bool isDoingSpecialAttack = false;
    private bool canRandomAttack = false;

    void Start()
    {        
        health = maxHealth;        
    }

    void Update()
    {
        if (playerIsInRoom)
        {
            RotateHandler();
            CheckHP();

            if (canShoot && !isDoingSpecialAttack)
            {
                Fire();
                canShoot = false;
                Invoke(nameof(ResetCanShoot), fireRate);
            }

            if (canRandomAttack)
            {
                StartRandomAttack();
                canRandomAttack = false;
            }
        }        
    }

    private void Fire()
    {
        Instantiate(mainProjectile, shootingLocation.transform.position, shootingCrystal.transform.rotation);
    }

    public void PlayerEnteredRoom()
    {
        Invoke(nameof(ResetRandomAttack), randomAttackResetTime);
        playerIsInRoom = true;
        Debug.Log("megjöttem");
    }

    private void CheckHP()
    {
        Debug.Log(health);
        if (health <= 0)
        {
            Destroy(gameObject);            
        }
        else if (health <= (maxHealth / 3)*1)
        {
            Destroy(healthCrystal1);
        }
        else if (health <= (maxHealth / 3) * 2)
        {
            Destroy(healthCrystal2);
        }
    }

    private void RotateHandler()
    {
        Vector3 playerCrystalDirection = target.transform.position - shootingCrystal.transform.position;
        float crystalRotationStep = shootingCrystalPivotSpeed * Time.deltaTime;
        Vector3 newCrystalLookDirection = Vector3.RotateTowards(shootingCrystal.transform.forward, playerCrystalDirection, crystalRotationStep, 0f);
        shootingCrystal.transform.rotation = Quaternion.LookRotation(newCrystalLookDirection);

        Vector3 playerDirection = new Vector3(target.transform.position.x, transform.position.y, target.transform.position.z) - transform.position;
        float mainRotationStep = mainPivotSpeed * Time.deltaTime;
        Vector3 newLookDirection = Vector3.RotateTowards(transform.forward, playerDirection, mainRotationStep, 0f);
        transform.rotation = Quaternion.LookRotation(newLookDirection);
    }

    private void ResetCanShoot()
    {
        canShoot = true;
    }

    private void StartRandomAttack()
    {
        float x = UnityEngine.Random.Range(0, 2);
        if (x == 0)
        {
            RotatingWall();            
        }
        else if (x == 1)
        {
            FallingCrystalAttack();
        }
        else if (x == 2)
        {
            ShockWave();
        }
    }

    private void FallingCrystalAttack()
    {
        canRandomAttack = false;
        isDoingSpecialAttack = true;
        for (int i = 0; i < NumberOfFallingCrystals; i++)
        {
            Invoke(nameof(SpawnFallingCrystal), TimeBetweenFallingCrystals * i);
        }
        Invoke(nameof(EndOfRandomAttack), TimeBetweenFallingCrystals * NumberOfFallingCrystals + 1.5f);
        Invoke(nameof(ResetRandomAttack), TimeBetweenFallingCrystals * NumberOfFallingCrystals + 1.5f + randomAttackResetTime);
    }

    private void SpawnFallingCrystal()
    {
        Vector3 temp = new Vector3(0, FallingCrystalsHeight, 0);
        Instantiate(FallingCrystalObject, target.transform.position + temp, target.transform.rotation);
    }

    private void RotatingWall()
    {
        canRandomAttack = false;
        isDoingSpecialAttack = true;
        for (int i = 0; i < NumberOfRotatingWalls; i++)
        {
            SpawnRotatingWall();
        }
        Invoke(nameof(EndOfRandomAttack), rotateAttackLenght);
        Invoke(nameof(ResetRandomAttack), rotateAttackLenght + randomAttackResetTime + 1);
    }

    private void SpawnRotatingWall()
    {
        RotatingWallSpawnLocation.transform.RotateAround(transform.position, transform.up, 360 / NumberOfRotatingWalls);

        Instantiate(RotatingWallObject, RotatingWallSpawnLocation.transform.position, RotatingWallSpawnLocation.transform.rotation);
    }

    private void ShockWave()
    {
        canRandomAttack = false;
        isDoingSpecialAttack = true;
        for (int i = 0; i < NumberOfShockWaves; i++)
        {
            Invoke(nameof(SpawnShockWave), TimeBetweenShockWave * i);
        }
        Invoke(nameof(EndOfRandomAttack), TimeBetweenShockWave + NumberOfShockWaves + 2);
        Invoke(nameof(ResetRandomAttack), TimeBetweenShockWave + NumberOfShockWaves + 2 + randomAttackResetTime);
    }

    private void SpawnShockWave()
    {
        Instantiate(shockWave, shockWaveLocation.transform.position, shockWaveLocation.transform.rotation);
    }

    private void EndOfRandomAttack()
    {
        isDoingSpecialAttack = false;
    }

    private void ResetRandomAttack()
    {        
        canRandomAttack = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PistolBullet")
        {
            health = health - 60;
        }
        else if(other.gameObject.tag == "SMGBullet")
        {
            health = health - 30;
        }
        else if(other.gameObject.tag == "ShotgunBullet")
        {
            health = health - 40;
        }
        else if (other.gameObject.tag == "Rocket")
        {
            other.gameObject.GetComponent<rocket>().Explode();
        }
        else if(other.gameObject.tag == "Explosion")
        {
            health = health - 100;
        }
        Debug.Log(health);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Rocket")
        {
            collision.gameObject.GetComponent<rocket>().Explode();
        }
    }
}
