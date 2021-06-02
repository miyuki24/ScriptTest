using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss{
    private int hp = 100;
    private int power = 25;
    private int mp = 53;

    public void Attack() {
        Debug.Log(this.power + "のダメージを与えた");
    }

    public void Defence(int damage) {
        Debug.Log(damage + "のダメージを受けた");
    }


    public void Magic(){
        for(int i = 0; i <= 10; i++) {
            mp -= 5;
        }
        if (this.mp >= 5) {
            mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp + "。");
        } else {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
    }
}

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start(){
        Boss lastboss = new Boss();
        lastboss.Attack();
        lastboss.Defence(3);

        int[] array = {1,2,3,4,5};
        for(int i = 0; i < 5; i++) {
            Debug.Log(array[i]);
        }
        for(int i = 4; i >= 0; i--) {
            Debug.Log(array[i]);
        }

        lastboss.Magic();
    }

    // Update is called once per frame
    void Update(){
    }
}
