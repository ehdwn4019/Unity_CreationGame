﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //싱글톤
    public static GameManager instance = null;

    //[SerializeField] Monster monster;
    //[SerializeField] Boss boss;
    //[SerializeField] Player player;

    #region 프로퍼티들

    //public Monster Monster
    //{
    //    get
    //    {
    //        return monster;
    //    }
    //}
    //public Boss Boss
    //{
    //    get
    //    {
    //        return boss;
    //    }
    //}
    //public Player Player
    //{
    //    get
    //    {
    //        return player;
    //    }
    //}

    #endregion

    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if(instance!=this)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void EndGame()
    {
        //if(player.IsDie)
        //{
        //    //SceneManager.LoadScene("TEST");
        //    SceneController.instance.GoStartScene();
        //}
    }
}