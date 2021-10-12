using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Target : MonoBehaviour
{
    [Header("Set Dynamically")]

    public Text scoreGT;

    // Start is called before the first frame update
    void Start()
    {
        GameObject scoreGO = GameObject.Find("ScoreCounter");

        scoreGT = scoreGO.gameObject.GetComponent<Text>();

        scoreGT.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
       

    }
    void OnCollisionEnter(Collision coll)
    {
        GameObject collidedWith = coll.gameObject;

        if (collidedWith.tag == "ProjectileHero")
        {
            Destroy(collidedWith);

            int score = int.Parse(scoreGT.text);

            score += -50;

            scoreGT.text = score.ToString();

            if (score > HighScore.score)
            {
                HighScore.score = score;
            }
        }
    }
}
