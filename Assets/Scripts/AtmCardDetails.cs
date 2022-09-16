using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class AtmCardDetails : MonoBehaviour
{


    public GameObject homePage;
    public GameObject inputPin;
    public GameObject optionsPage;
    public GameObject balanceAmountPage;
    public GameObject withdrawalPage;
    public GameObject depositPage;
    public GameObject transferPage;
    public GameObject accountNumberPage;
    public GameObject thankYouPage;

    public bool ishomePageActive;



    public InputField typeAcctNum;
    public Text acctNumText;
    public Text acctConfirmationText;


    public InputField typePinNum;
    public Text acctPinText;
    public Text pinConfirmationText;

    public InputField typeWtdrNum;
    public Text wtdrNumText;
    public Text wtdrConfText;

    public InputField typeDepositNum;
    public Text DepositNumText;
    public Text DepositConfText;

    public Text balanceAmountText;

    public Text ThankYouText;


    public string accnt;
    public int pinnum;

    public string accountNumber = "2105420352";
    
    public int pin = 1212;
    
    public string firstName;
    public string lastName;
    public double balance;



    // Input Details Here

    //AccountNumber
    public void AcctNumInput()
    {
        ////string man = "2105420354";
       
        ////Debug.Log(acctNumText.text);
        ////Debug.Log(typeAcctNum.text);
        ////Debug.Log(man);
        //if (typeAcctNum.text == accountNumber)
        //{

        //    //Debug.Log("matching");
        //    acctConfirmationText.text = "WELCOME BACK " + firstName;

        //    StartCoroutine(LoadingPinPage());
        //}
        //else
        //{
        //    //Debug.Log("NotMatching");
        //    acctConfirmationText.text = "ACCOUNT NOT FOUND TRY AGAIN";
        //}


        //List

        List<string> AccountNumber = new List<string>();

        AccountNumber.Add("2105420352");
        AccountNumber.Add("2162520352");
        AccountNumber.Add("2199220252");
        AccountNumber.Add("2180080002");
        AccountNumber.Add("2105663841");

        List<int> AccountNumberPin = new List<int>();
        AccountNumberPin.Add(1212);
        AccountNumberPin.Add(5512);
        AccountNumberPin.Add(8433);
        AccountNumberPin.Add(5358);
        AccountNumberPin.Add(5833);

        List<string> AccountName = new List<string>();
        AccountName.Add("Mr. Elvis Emezi");
        AccountName.Add("Mrs. Isaac Idejoku");
        AccountName.Add("Miss. Faustina Earnest");
        AccountName.Add("Master. Alucard Aniston");
        AccountName.Add("Dr. Bibeola Adejola");

        List<double> AccountBalance = new List<double>();
        AccountBalance.Add(1500000);
        AccountBalance.Add(75286);
        AccountBalance.Add(528466);
        AccountBalance.Add(2200);
        AccountBalance.Add(10000);

        acctNumText.text = typeAcctNum.text;
        accnt = typeAcctNum.text;

        acctPinText.text = typePinNum.text;
        //int pinasu = int.Parse(typePinNum.text);
        //pinnum = pinasu;



        //Account Number and Pin Check
        if (AccountNumber.Contains(accnt) == true)
        {
            Debug.Log("worked");
            int index = AccountNumber.IndexOf(accnt);
            StartCoroutine(LoadingPinPage());

            

            acctConfirmationText.text = "WELCOME BACK " + AccountName[index];

            


            if (AccountNumberPin[index] == pinnum)
            {
                Debug.Log(pinnum);
                Debug.Log("Welcome " + AccountName[index] + " YOUR ACCOUNT BALANCE IS " + AccountBalance[index]);
            }
            else
            {
                Debug.Log(accnt);
            }

        }
        else
        {
            Debug.Log("NotMatching");
            acctConfirmationText.text = "ACCOUNT NOT FOUND TRY AGAIN";

        }

    }


    IEnumerator LoadingPinPage()
    {
        
            
            
        yield return new WaitForSeconds(2f);
        

        homePage.SetActive(false);
        inputPin.SetActive(true);

       



    }
    // End of Account related stuff


    //PinNumber
    public void PinNumberInput()
    {

        
        //StartCoroutine(LoadingOptionsPage());
        //for (int i = 3; i != pin; i++)
        //{
        //    pinConfirmationText.text = "Stop Trying To Steal";
        //}

        //Debug.Log(acctPinText.text);
    }

    IEnumerator LoadingOptionsPage()
    {

        acctPinText.text = typePinNum.text;
        if (typePinNum.text == pin.ToString())
        {
            pinConfirmationText.text = "Correct Pin";

            yield return new WaitForSeconds(2f);

            inputPin.SetActive(false);
            optionsPage.SetActive(true);
        }
        else
        {
            pinConfirmationText.text = "Incorrect Pin";
        }




    }
    // End of Pin related stuff



    public void BalanceButton()
    {
        optionsPage.SetActive(false);
        balanceAmountPage.SetActive(true);
    }

    public void WithdrawButton()
    {
        optionsPage.SetActive(false);
        withdrawalPage.SetActive(true);
        wtdrConfText.text = "HOW MUCH DO YOU WANT TO WITHDRAW?";
    }


    public void WtdrNum()
    {
        wtdrNumText.text = typeWtdrNum.text;


        if (balance >= double.Parse(typeWtdrNum.text))
        {
            

            double wtdrw = double.Parse(typeWtdrNum.text);
            double acctbal = balance;
            double newbalance = acctbal - wtdrw;
            balance = newbalance;

            //Debug.Log(typeWtdrNum.text);
            Debug.Log("YOU CAN WITHDRAW");
            Debug.Log("YOUR BALANCE IS " + newbalance);
            wtdrConfText.text = "YOUR CURRENT BALANCE IS " + newbalance.ToString();
        }
        else if (balance <= double.Parse(typeWtdrNum.text)) 
        {
            wtdrConfText.text = "STOP YOU CANT WITHDRAW STOP TRYING TO STEAL";
            //Debug.Log("STOP YOU CANT WITHDRAW STOP TRYING TO STEAL");
        }
        else
        {
            wtdrConfText.text = "INCORRECT INPUT";
            //Debug.Log("INCORRECT INPUT");
        }


    }

    public void DepositButton()
    {
        optionsPage.SetActive(false);
        depositPage.SetActive(true);
    }

    public void Deposit()
    {
        DepositNumText.text = typeDepositNum.text;

        double depositholder = balance;
        double deposited = double.Parse(typeDepositNum.text);

        double balafdep = deposited + depositholder; 

        balance = balafdep;

        Debug.Log(typeDepositNum.text);
        Debug.Log(balance);
        Debug.Log(balafdep);
        DepositConfText.text = "DEPOSIT SUCCESSFUL YOUR CURRENT BALANCE IS " + balance.ToString();
    }

    public void TransferButton()
    {
        optionsPage.SetActive(false);
        transferPage.SetActive(true);
    }

    public void ExitButton()
    {
        optionsPage.SetActive(false);
        inputPin.SetActive(false);
        balanceAmountPage.SetActive(false);
        depositPage.SetActive(false);
        withdrawalPage.SetActive(false);
        transferPage.SetActive(false);
        thankYouPage.SetActive(false);
        homePage.SetActive(true);
        accountNumberPage.SetActive(true);
        typePinNum.text = " ";
        typeAcctNum.text = " ";
        pinConfirmationText.text = " ";
        acctConfirmationText.text = " ";
        ishomePageActive = true;
     
    }

    public void OptionsPage()
    {
        optionsPage.SetActive(true);
        inputPin.SetActive(false);
        balanceAmountPage.SetActive(false);
        depositPage.SetActive(false);
        withdrawalPage.SetActive(false);
        transferPage.SetActive(false);
        thankYouPage.SetActive(false);
        accountNumberPage.SetActive(false);
    }

    public void NextButton()
    {
        optionsPage.SetActive(true);
        balanceAmountPage.SetActive(false);
        depositPage.SetActive(false);
        withdrawalPage.SetActive(false);
        transferPage.SetActive(false);


    }

    public void AfterBalanceButton()
    {
        balanceAmountPage.SetActive(false);
        thankYouPage.SetActive(true);

    }

    public void QuitApp()
    {
        Application.Quit();
    }




    //SUB MENUS LOCATED HERE
    public void ThankYouMessage()
    {
        ThankYouText.text = "THANK YOU " + firstName + " FOR YOUR CONTINUOUS PATRONAGE";
    }

    public void BalanceAmount()
    {
        //balanceAmount.SetActive(true);

        balanceAmountText.text = "YOUR BALANCE AMOUNT IS " + balance.ToString();
        //Debug.Log(balanceAmountText.text);
    }



    
    public void Update()
    {
        BalanceAmount();
        ThankYouMessage();



        //acctPinText.text = typePinNum.text;
        //int pinasu;
        //bool isParsable = Int32.TryParse(firstName, pinasu);
        //pinnum = pinasu;

        //if (isParsable)
        //{
        //    Debug.Log("matched");
        //}

        //if (int.Parse(typePinNum.text) == pinnum)
        //{
        //    Debug.Log("matched");
        //}

        Debug.Log(typePinNum.text);
        Debug.Log(pinnum);

    }
    private void Start()
    {
       
    }
}
