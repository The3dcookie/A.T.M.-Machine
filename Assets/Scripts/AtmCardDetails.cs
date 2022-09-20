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
    public GameObject SignUpPage;
    public GameObject newAccountDetailsPage;

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

    public InputField typeFirstNam;
    public Text firstNameText;

    public InputField typeLastNam;
    public Text LastNameText;

    public InputField typeInPin;
    public Text pinText;

    public InputField newAccountDetails;
    public Text newAccountDetailsText;


    public Text balanceAmountText;

    public Text ThankYouText;


    public string accnt;
    public int pinnum;

    public string accountNumber;
    public string newAcctNum;
    
    public int pin;
    public string pintex;
    public string accdetspag;


    public string firstName;
    public string lastName;
    public double balance;
    public string randbal;


    private void Start()
    {

      
    }


    public void SignUp()
    {
        SignUpPage.SetActive(true);

    }
    public void SignIn()
    {
        typeFirstNam.text= firstNameText.text;
        
        typeLastNam.text = LastNameText.text;

        typeInPin.text = pinText.text;

        newAccountDetails.text = newAccountDetailsText.text;

        firstName = firstNameText.text;
        lastName = LastNameText.text;
        pintex = pinText.text;


        accdetspag = newAccountDetailsText.text;






}

public void CreateAccount()
    {

        string acctStrt = "210";
        int acctEnd = /*Random.Range(0000000, 9999999)*/5420352;
        int newBalance = /*Random.Range(5000, 100000000)*/ 10000000;
        newAcctNum = acctStrt + acctEnd.ToString();
        randbal = newBalance.ToString();






        PlayerPrefs.SetString("newAcctNum", newAcctNum + ";" + firstName + ";" + lastName + ";" + pintex + ";" + randbal + ";");



        string userData = PlayerPrefs.GetString("newAcctNum");

        string[] userDataList = userData.Split(';');
        
        string strtAcctNum = userDataList[0];
        string strtFirstName = userDataList[1];
        string strtLastName = userDataList[2];
        string strtAcctPin = userDataList[3];
        string strtBalance = userDataList[4];
        Debug.Log(PlayerPrefs.GetString("newAcctNum"));
        Debug.Log("Welcome " + strtLastName + " " + strtFirstName + " " + "Your new account number is " + strtAcctNum + "." + " Your Account Balance is " + strtBalance );
        Debug.Log(strtLastName);

        if (PlayerPrefs.GetString("newAcctNum") == null)
        {
            Debug.Log("Doesn't Exist");
        }
        else
        {
            Debug.Log("Exists");
        }

        newAccountDetails.text = "Welcome " + strtLastName + " " + strtFirstName + "\n" + "Your new account number is " + strtAcctNum + "\n" + " Your Account Balance is " + strtBalance + "\n" + "Click To Anywhere Proceed" + "\n" + "No Energy To Create a Proceed Button";

        SignUpPage.SetActive(false);
        newAccountDetailsPage.SetActive(true);

       
    }



    // Input Details Here

    //AccountNumber
    public void AcctNumInput()
    {
        string userData = PlayerPrefs.GetString("newAcctNum");

        string[] userDataList = userData.Split(';');

        string strtAcctNum = userDataList[0];
        string strtFirstName = userDataList[1];

        if (typeAcctNum.text == strtAcctNum)
        {
            acctConfirmationText.text = "Welcome " + strtFirstName;

            StartCoroutine(LoadingPinPage());
        }
        else
        {
            acctConfirmationText.text = "Account Not Found";
        }
    }


    IEnumerator LoadingPinPage()
    {
        
            
            
        yield return new WaitForSeconds(1f);
        

        homePage.SetActive(false);
        inputPin.SetActive(true);

       



    }
    // End of Account related stuff


    //PinNumber
    public void PinNumberInput()
    {

        string userData = PlayerPrefs.GetString("newAcctNum");

        string[] userDataList = userData.Split(';');
        string strtFirstName = userDataList[1];
        string strtLastName = userDataList[2];
        string strtAcctPin = userDataList[3];


        if(typePinNum.text == strtAcctPin)
        {
            pinConfirmationText.text = "So You're Really " + strtFirstName +" "+ strtLastName;
            StartCoroutine(LoadingOptionsPage());
        }
        else
        {
            pinConfirmationText.text = "Incorrect Pin";
        }
        //StartCoroutine(LoadingOptionsPage());
        //for (int i = 3; i != pin; i++)
        //{
        //    pinConfirmationText.text = "Stop Trying To Steal";
        //}

        //Debug.Log(acctPinText.text);
    }

    IEnumerator LoadingOptionsPage()
    {

          
        yield return new WaitForSeconds(2f);

          
        inputPin.SetActive(false);
           
        optionsPage.SetActive(true);
        
    




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
        SignUpPage.SetActive(false);
        newAccountDetailsPage.SetActive(false);
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
        SignIn();
        //CreateAccount();



        //acctPinText.text = typePinNum.text;
        //int pinasu;
        //bool isParsable = Int32.TryParse(firstName, pinasu);
        //pinnum = pinasu;

        //if (isParsable)
        //{
        //Debug.Log(newAccountDetailsText.text);
        //}

        //Debug.Log(accdetspag);

        //if (int.Parse(typePinNum.text) == pinnum)
        //{


        //Debug.Log(lastName);
        //Debug.Log(firstName);
        //}

        //Debug.Log(typePinNum.text);
        //Debug.Log(pinnum);

    }

}
