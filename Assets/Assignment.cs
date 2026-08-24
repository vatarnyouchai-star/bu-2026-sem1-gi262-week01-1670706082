using UnityEngine;

public class Assignment : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        As01_CheckNumberSign();
        As02_GetDayName();
        As03_ValidatePassword();
        As04_GetGrade();
        As05_IsLeapYear();
        As06_Calculate();
        As07_GetSeason();
        As08_PurchasingSystemExample();
        As09_RockPaperScissorsExample();
        As10_CalculateWeaponDamage();
        As11_DeterminePlayerRank();
    }

    // ---------------------------------------------------------|| As_01

    public int as01Number;
    public void As01_CheckNumberSign()
    {
        if (as01Number > 0)
        {
            Debug.Log("Positive");
        }
        else if (as01Number < 0)
        {
            Debug.Log("Negative");
        }
        else
        {
            Debug.Log("Zero");
        }
    }

    // ---------------------------------------------------------|| As_02

    public int as02Day;
    public void As02_GetDayName()
    {
        switch (as02Day)
        {
            case 1:
                Debug.Log("Monday");
                break;

            case 2:
                Debug.Log("Tuesday");
                break;

            case 3:
                Debug.Log("Wednesday");
                break;

            case 4:
                Debug.Log("Thursday");
                break;

            case 5:
                Debug.Log("Friday");
                break;

            case 6:
                Debug.Log("Saturday");
                break;

            case 7:
                Debug.Log("Sunday");
                break;

            default:
                Debug.Log("Invalid day");
                break;
        }
    }

    // ---------------------------------------------------------|| As_03

    public string as03InputPassword;
    public string as03CorrectPassword;
    public void As03_ValidatePassword()
    {
        if (as03InputPassword == as03CorrectPassword)
        {
            Debug.Log("True");
        }
        else
        {
            Debug.Log("False");
        }
    }

    // ---------------------------------------------------------|| As_04

    public int as04Score;
    public void As04_GetGrade()
    {
        if (as04Score >= 80)
        {
            Debug.Log("A");
        }
        else if (as04Score >= 70)
        {
            Debug.Log("B");
        }
        else if (as04Score >= 60)
        {
            Debug.Log("C");
        }
        else if (as04Score >= 50)
        {
            Debug.Log("D");
        }
        else
        {
            Debug.Log("F");
        }
    }

    // ---------------------------------------------------------|| As_05

    public int as05Year;
    public void As05_IsLeapYear()
    {
        if ((as05Year % 400 == 0) ||
            (as05Year % 4 == 0 && as05Year % 100 != 0))
        {
            Debug.Log("True");
        }
        else
        {
            Debug.Log("False");
        }
    }

    // ---------------------------------------------------------|| As_06

    public double as06Num1;
    public char as06Op;
    public double as06Num2;
    public void As06_Calculate()
    {
        double result = 0;

        switch (as06Op)
        {
            case '+':
                result = as06Num1 + as06Num2;
                Debug.Log("Result: " + result);
                break;

            case '-':
                result = as06Num1 - as06Num2;
                Debug.Log("Result: " + result);
                break;

            case '*':
                result = as06Num1 * as06Num2;
                Debug.Log("Result: " + result);
                break;

            case '/':
                if (as06Num2 != 0)
                {
                    result = as06Num1 / as06Num2;
                    Debug.Log("Result: " + result);
                }
                else
                {
                    Debug.Log("Cannot divide by zero");
                }
                break;

            default:
                Debug.Log("Invalid operator");
                break;
        }
    }

    // ---------------------------------------------------------|| As_07

    public int as07Month;
    public void As07_GetSeason()
    {
        switch (as07Month)
        {
            case 12:
            case 1:
            case 2:
                Debug.Log("Winter");
                break;

            case 3:
            case 4:
            case 5:
                Debug.Log("Spring");
                break;

            case 6:
            case 7:
            case 8:
                Debug.Log("Summer");
                break;

            case 9:
            case 10:
            case 11:
                Debug.Log("Autumn");
                break;

            default:
                Debug.Log("Invalid month");
                break;
        }
    }

    // ---------------------------------------------------------|| As_08

    public int as08Quantity;
    public int as08Price;
    public int as08Payment;
    public void As08_PurchasingSystemExample()
    {
        int totalPrice = as08Quantity * as08Price;

        if (as08Payment >= totalPrice)
        {
            int change = as08Payment - totalPrice;

            Debug.Log("Total Price: " + totalPrice);
            Debug.Log("Payment: " + as08Payment);
            Debug.Log("Change: " + change);
        }
        else
        {
            int remaining = totalPrice - as08Payment;

            Debug.Log("Total Price: " + totalPrice);
            Debug.Log("Payment is not enough");
            Debug.Log("Remaining: " + remaining);
        }
    }

    // ---------------------------------------------------------|| As_09

    public int as09UserChoice;
    public int as09ComputerChoice;
    public void As09_RockPaperScissorsExample()
    {
        if (as09UserChoice < 1 || as09UserChoice > 3 ||
            as09ComputerChoice < 1 || as09ComputerChoice > 3)
        {
            Debug.Log("Invalid choice");
            return;
        }

        if (as09UserChoice == as09ComputerChoice)
        {
            Debug.Log("Draw");
        }
        else if (
            (as09UserChoice == 1 && as09ComputerChoice == 3) ||
            (as09UserChoice == 2 && as09ComputerChoice == 1) ||
            (as09UserChoice == 3 && as09ComputerChoice == 2)
        )
        {
            Debug.Log("You Win");
        }
        else
        {
            Debug.Log("Computer Win");
        }
    }

    // ---------------------------------------------------------|| As_10

    public string as10WeaponType;
    public int as10BaseDamage;
    public void As10_CalculateWeaponDamage()
    {
        int damage = as10BaseDamage;

        switch (as10WeaponType.ToLower())
        {
            case "sword":
                damage = as10BaseDamage + 10;
                break;

            case "axe":
                damage = as10BaseDamage + 15;
                break;

            case "bow":
                damage = as10BaseDamage + 5;
                break;

            default:
                Debug.Log("Unknown weapon type");
                return;
        }

        Debug.Log("Damage: " + damage);
    }

    // ---------------------------------------------------------|| As_11

    public int as11Score;
    public int as11CompletionTime;
    public void As11_DeterminePlayerRank()
    {
        if (as11Score >= 90 && as11CompletionTime <= 60)
        {
            Debug.Log("S Rank");
        }
        else if (as11Score >= 80 && as11CompletionTime <= 90)
        {
            Debug.Log("A Rank");
        }
        else if (as11Score >= 70 && as11CompletionTime <= 120)
        {
            Debug.Log("B Rank");
        }
        else if (as11Score >= 60)
        {
            Debug.Log("C Rank");
        }
        else
        {
            Debug.Log("D Rank");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}