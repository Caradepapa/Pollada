using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public enum GAMESTATE { STARTING, PLAYING, INTERMISSION, ENDING};
public class GameManager : MonoBehaviour
{
    //public GAMESTATE state = GAMESTATE.STARTING;
    private static GameManager instance;
    public static GameManager Instance
    {
        get
        {
            return instance;
        }
    }
    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
        }
        //    //player=FindObjectOfType<Player>();
    }
    //private void Update()
    //{
    //    switch (state)
    //    {
    //        case GAMESTATE, STARTING:
    //            break;
    //        case GAMESTATE, PLAYING:
    //            break;
    //        case GAMESTATE, INTERMISSION:
    //            //losePanel.SetActive(true);
    //            state = GAMESTATE.ENDING;
    //            break;
    //        case GAMESTATE.ENDING:
    //            break;
    //    }
    //}
    //public void AddScore(int score)
    //{
    //    points += score;
    //}
    //public void ChangeState(GAMESTATE newstate)
    //{
    //    state = newstate;
    //}
    // Start is called before the first frame update
    //void Start()
    //{
        
    //}

    //// Update is called once per frame
    //void Update()
    //{
        
    //}
}
