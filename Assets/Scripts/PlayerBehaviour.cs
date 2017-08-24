using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour {

    //変数定義
    [SerializeField]
    public float flap = 100f;
    [SerializeField]
    public float scroll = 5f;
    float direction = 0f;
    Rigidbody2D rb2d;
    bool jump = false;
    List<string> jump_tag = new List<string>();

    // Use this for initialization
    void Start()
    {
        //コンポーネント読み込み
        rb2d = GetComponent<Rigidbody2D>();
        jump_tag.Add("non active object");//jump_tagに対象となるtagを追加
        jump_tag.Add("move lift");
        //jump_tag.Add("");

    }

    //プロパティー
    public List<string>Jump_tag
    {
        get { return this.jump_tag; }  //取得用
        private set { this.jump_tag = value; } //値入力用
    }


    // Update is called once per frame
    void Update()
    {

        //キーボード操作
        if (Input.GetKey(KeyCode.RightArrow))
        {
            direction = 1f;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            direction = -1f;
        }
        else
        {
            direction = 0f;
        }


        //キャラのy軸のdirection方向にscrollの力をかける
        rb2d.velocity = new Vector2(scroll * direction, rb2d.velocity.y);

        //ジャンプ判定
        if (Input.GetKeyDown(KeyCode.UpArrow) && !jump)
        {
            rb2d.AddForce(Vector2.up * flap);
            jump = true;
        }

    }

    //指定したtagのついたobjectに接触するとjumpをfalseにする
/*    void OnCollisionEnter2D(Collision2D other)
    {
        foreach (string n in jump_tag)
        {
            if (other.gameObject.CompareTag(n))
            {
                jump = false;
            }
        }
    }
    */
}
