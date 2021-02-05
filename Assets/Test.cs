using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    void Start()
    {
        int[] array = new int[5];

        array[0] = 10;
        array[1] = 20;
        array[2] = 30;
        array[3] = 40;
        array[4] = 50;

        for (int i =4; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }

        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }

        Boss lastboss = new Boss();

        lastboss.Attack();
        lastboss.Defence(3);
        {
            int mp = 53;
            for (int i = 0; i < 11; i++)
            {
                lastboss.Magic(5);
            }
        }
        

    }
}
public class Boss
{
    private int hp = 100;
    private int power = 25;
    private int mpmp = 53;

    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        this.hp -= damage;
    }

    public void Magic (int mp)
    {
        this.mpmp -= mp;
        if (mpmp > 0)
        {
            Debug.Log("魔法攻撃をした。残りMPは" + mpmp);
        }
        else
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }

    }
}