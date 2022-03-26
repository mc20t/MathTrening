using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Script : MonoBehaviour
{
    public GameObject BtnEnt;
    public InputField InpRes;
    public Text Example;
    public int i;
    public int k = 0;
    public int num_1;
    public int num_2;

    void Start()
    {
        i = Random.Range(0, 4);
        if (i == 0)
            Summa();
        else if (i == 1)
            Deff();
        else if (i == 2)
            Sqrt_2();
        else if (i == 3)
            Sqrt_3();
    }

    public void Enter()
    {
        if (k == 0)
        {
            if (i == 0)
            {
                if (InpRes.text == (num_1 + num_2).ToString())
                {
                    InpRes.text = string.Empty;
                    Menu(k);
                }
            }
            else if (i == 1)
            {
                if (InpRes.text == (num_1 - num_2).ToString())
                {
                    InpRes.text = string.Empty;
                    Menu(k);
                }
            }
            else if (i == 2)
            {
                if (InpRes.text == (num_1).ToString())
                {
                    InpRes.text = string.Empty;
                    Menu(k);
                }
            }
            else if (i == 3)
            {
                if (InpRes.text == (num_1).ToString())
                {
                    InpRes.text = string.Empty;
                    Menu(k);
                }
            }
        }
        else if (k == 1)
        {
            if (i == 0)
            {
                if (InpRes.text == (num_1 + num_2).ToString())
                {
                    InpRes.text = string.Empty;
                    Menu(k);
                }
            }
            else if (i == 1)
            {
                if (InpRes.text == (num_1 - num_2).ToString())
                {
                    InpRes.text = string.Empty;
                    Menu(k);
                }
            }
        }
        else if (k == 2)
        {
            if (i == 0)
            {
                if (InpRes.text == (num_1).ToString())
                {
                    InpRes.text = string.Empty;
                    Menu(k);
                }
            }
            else if (i == 1)
            {
                if (InpRes.text == (num_1).ToString())
                {
                    InpRes.text = string.Empty;
                    Menu(k);
                }
            }
        }
        else if (k == 3)
        {
            if (InpRes.text == (num_1).ToString())
            {
                InpRes.text = string.Empty;
                Sqrt_3();
            }
        }
        else if (k == 4)
        {
            if (InpRes.text == (num_1).ToString())
            {
                InpRes.text = string.Empty;
                Sqrt_2();
            }
        }
        else if (k == 5)
        {
            if (InpRes.text == (num_1 + num_2).ToString())
            {
                InpRes.text = string.Empty;
                Summa();
            }
        }
        else if (k == 6)
        {
            if (InpRes.text == (num_1 - num_2).ToString())
            {
                InpRes.text = string.Empty;
                Deff();
            }
        }
        
    }

    public void Menu(int index) 
    {
        if (index == 0)
        {
            k = index;
            i = Random.Range(0, 4);
            if (i == 0)
                Summa();
            else if (i == 1)
                Deff();
            else if (i == 2)
                Sqrt_2();
            else if (i == 3)
                Sqrt_3();
        }
        else if (index == 1)
        {
            k = index;
            i = Random.Range(0, 2);
            if (i == 0)
                Summa();
            else if (i == 1)
                Deff();
        }
        else if (index == 2)
        {
            k = index;
            i = Random.Range(0, 2);
            if (i == 0)
                Sqrt_2();
            else if (i == 1)
                Sqrt_3();
        }
        else if (index == 3)
        {
            k = index;
            Sqrt_3();
        }
        else if (index == 4)
        {
            k = index;
            Sqrt_2();
        }
        else if (index == 5)
        {
            k = index;
            Summa();
        }
        else if (index == 6)
        {
            k = index;
            Deff();
        }
        
    }

    public void Summa()
    {
        num_1 = Random.Range(100, 1000);
        num_2 = Random.Range(100, 1000);
        Example.text = $"{num_1} + {num_2}";
    }

    public void Deff()
    {
        num_1 = Random.Range(100, 1000);
        num_2 = Random.Range(100, 1000);
        Example.text = $"{num_1} - {num_2}";
    }

    public void Sqrt_2()
    {
        num_1 = Random.Range(10, 100);
        num_2 = num_1 * num_1;
        Example.text = $"Sqrt^2 ({num_2})";
    }

    public void Sqrt_3()
    {
        num_1 = Random.Range(10, 100);
        num_2 = num_1 * num_1 * num_1;
        Example.text = $"Sqrt^3 ({num_2})";
    }
    
}