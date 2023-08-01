using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollectorData : MonoBehaviour
{
    SaveData SaveData;
    Player Player;
    [SerializeField]
    Upgrade upgrade;
    WeapownSwitch weapownSwitch;
    [SerializeField]
    BilletData bullet;
    [SerializeField]
    BilletData bulletAK;
    [SerializeField] BilletData bulletRG;
    [SerializeField] BilletData bulletRelsotron;

    public SaveData saveData => SaveData;


    public void Awake()
    {
        Player = FindObjectOfType<Player>();
        weapownSwitch = FindObjectOfType<WeapownSwitch>();
    }

    public void Start()
    {
        SaveData = new SaveData();
    }
    public void CollectData()
    {
        SaveData.speed = Player.speed;
        SaveData.X = Player.transform.position.x;
        SaveData.Y = Player.transform.position.y;
        SaveData.Score = upgrade.count;
        //SaveData.unlockedWeapons = weapownSwitch.unlockedWeapons;
        SaveData.bullet = bullet.damage;
        SaveData.bulletAK = bulletAK.damage;
        SaveData.bulletRG = bulletRG.damage;
        SaveData.bulletRelsotron = bulletRelsotron.damage;
    }

    public void LoadPlayerData(SaveData LoadData)
    {
        Player.speed = LoadData.speed;
        Player.transform.position = new Vector2(LoadData.X, LoadData.Y);
        upgrade.count = LoadData.Score;
        //weapownSwitch.unlockedWeapons = SaveData.unlockedWeapons;
        bullet.damage = LoadData.bullet;
        bulletAK.damage = LoadData.bulletAK;
        bulletRG.damage = LoadData.bulletRG;
        bulletRelsotron.damage = LoadData.bulletRelsotron;
    }
}
