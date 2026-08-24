using UnityEngine;

public class Workshop : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        As01_SyntaxIf();
        As02_StringComparisonExample();
        As03_NumberComparisonExample();
        As04_AndOrOperatorExample();
        As05_GuessingNumberExample();
        As06_GuessingNumberMoreOrLessExample();
        As07_VerifyIdentityExample();
    }

    // ---------------------------------------------------------|| As_01

    public bool isSixOClock;
    public void As01_SyntaxIf()
    {
        if (isSixOClock)
        {
            Debug.Log("The door open");
        }

        Debug.Log("Knock Knock!");
    }

    // ---------------------------------------------------------|| As_02

    public string password;
    public void As02_StringComparisonExample()
    {
        if (password == "IDK")
        {
            Debug.Log("Password is correct");
        }

        if (password != "IDK")
        {
            Debug.Log("Password is incorrect");
        }
    }

    // ---------------------------------------------------------|| As_03

    public int as03Number;
    public void As03_NumberComparisonExample()
    {   
        // ---------------------|| >
        if (as03Number > 10)
        {
            Debug.Log("My number > 10");
        }

        // ---------------------|| >=
        if (as03Number >= 10)
        {
            Debug.Log("My number >= 10");
        }

        // ---------------------|| <
        if (as03Number < 10)
        {
            Debug.Log("My number < 10");
        }

        // ---------------------|| <=
        if (as03Number <= 10)
        {
            Debug.Log("My number <= 10");
        }

        // ---------------------|| ==
        if (as03Number == 10)
        {
            Debug.Log("My number == 10");
        }

        // ---------------------|| !=
        if (as03Number != 10)
        {
            Debug.Log("My number != 10");
        }
    }

    // ---------------------------------------------------------|| As_04

    public int as04Number;
    public void As04_AndOrOperatorExample()
    {
        if (as04Number > 8 && as04Number < 12)
        {
            Debug.Log("My number 8 > < 12");
        }

        if (as04Number < 8 || as04Number > 12)
        {
            Debug.Log("My number 8 || 12");
        }
    }

    // ---------------------------------------------------------|| As_05

    public int as05GuessingNumber;
    public int as05RandomNumber;
    public void As05_GuessingNumberExample()
    {
        if (as05GuessingNumber == as05RandomNumber)
        {
            Debug.Log("Congreatulation");
        }

        else
        {
            Debug.Log("Try agine");
        }
    }

    // ---------------------------------------------------------|| As_06

    public int as06GuessingNumber;
    public int as06RandomNumber;
    public void As06_GuessingNumberMoreOrLessExample()
    {
        // ----------|| (หลักการคล้ายๆภาษา Lua)
        if (as06GuessingNumber < as06RandomNumber)
        {
            Debug.Log("Too Low");
        }

        else if (as06GuessingNumber > as06RandomNumber)
        {
            Debug.Log("Too Hight");
        }

        else
        {
            Debug.Log("Congreatulation");
        }
        // ----------||
    }

    // ---------------------------------------------------------|| As_06

    public string as07Username;
    public string as07Password;
    public int as07Age;
    public bool as07IsPaid;
    public void As07_VerifyIdentityExample()
    {
        if (as07Username == "user" && as07Password == "user123")
        {
            Debug.Log("You have accessed");

            if (as07IsPaid)
            {
                Debug.Log("VIP member");
            }

            else
            {
                Debug.Log("Free member");
            }

            if (as07Age >= 18)
            {
                Debug.Log("You have access to exclusive content");
            }
        }

        else
        {
            Debug.Log("You are guest");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
