using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;


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

    public Text WelcInOpt;

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
    private double balance;
    public string randbal;


    private void Start()
    {

      
    }


    public void SignUp()
    {
        SignUpPage.SetActive(true);

        typeFirstNam.text = "";

        typeLastNam.text = "";

        typeInPin.text = "";


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
        int acctEnd = Random.Range(0000000, 9999999);
        int newBalance = Random.Range(5000, 1000000);
        newAcctNum = acctStrt + acctEnd.ToString();
        randbal = newBalance.ToString();

        PlayerPrefs.SetString(newAcctNum, newAcctNum + ";" + firstName + ";" + lastName + ";" + pintex + ";" + randbal + ";");



        string userData = PlayerPrefs.GetString(newAcctNum);

        string[] userDataList = userData.Split(';');
        
        string strtAcctNum = userDataList[0];
        string strtFirstName = userDataList[1];
        string strtLastName = userDataList[2];
        string strtAcctPin = userDataList[3];
        string strtBalance = userDataList[4];

        newAccountDetails.text = "Welcome " + strtLastName + " " + strtFirstName + "\n" + "Your new account number is " + strtAcctNum + "\n" + " Your Account Balance is " + strtBalance + "\n" + "Copy Your Details and Proceed";

        balance = double.Parse(strtBalance);

        SignUpPage.SetActive(false);
        newAccountDetailsPage.SetActive(true);
        PlayerPrefs.SetString("balance", balance.ToString());


    }



    // Input Details Here

    //AccountNumber
    public void AcctNumInput()
    {
        if (!PlayerPrefs.HasKey(typeAcctNum.text) )
        {
            acctConfirmationText.text = "Account Not Found";
        }
        else if (PlayerPrefs.HasKey(typeAcctNum.text))
        {
            
            string userData = PlayerPrefs.GetString(typeAcctNum.text);

            string[] userDataList = userData.Split(';');

            string strtAcctNum = userDataList[0];
            string strtFirstName = userDataList[1];

            

            //Debug.Log(strtAcctNum);

            if (typeAcctNum.text == strtAcctNum)
            {
                acctConfirmationText.text = "Welcome " + strtFirstName;

                WelcInOpt.text = "Welcome " + strtFirstName + " Choose an Option";

                StartCoroutine(LoadingPinPage());
            }
            else
            {
                acctConfirmationText.text = "Account Not Found";
            }
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

        string userData = PlayerPrefs.GetString(typeAcctNum.text);

        string[] userDataList = userData.Split(';');
        string strtFirstName = userDataList[1];
        string strtLastName = userDataList[2];
        string strtAcctPin = userDataList[3];


        if(typePinNum.text == strtAcctPin)
        {
            pinConfirmationText.text =  "That's Correct Proceed";
            StartCoroutine(LoadingOptionsPage());
        }
        else
        {
            pinConfirmationText.text = "Wrong Try Again";
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





    public void WtdrNum()
    {
        wtdrNumText.text = typeWtdrNum.text;




            try
        {

                
               
                if (double.Parse(PlayerPrefs.GetString("balance")) >= double.Parse(typeWtdrNum.text))
                {


                
                double wtdrw = double.Parse(typeWtdrNum.text);
                
                double acctbal = balance;
                
                double newbalance = acctbal - wtdrw;
                   
                balance = newbalance;

                PlayerPrefs.SetString("balance", balance.ToString());

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
        catch (FormatException)
        {
            Debug.Log("Chilling till you finish typing");
            // Return? Loop round? Whatever.
        }


    }






    public void Deposit()
    {
        PlayerPrefs.GetString("balance");

        double balaftdep = double.Parse(typeDepositNum.text) + double.Parse(PlayerPrefs.GetString("balance"));

        Debug.Log("stored balance is " + double.Parse(PlayerPrefs.GetString("balance")));
        Debug.Log("typed deposit is " + double.Parse(typeDepositNum.text));
       

        balance = balaftdep;

        PlayerPrefs.SetString("balance", balance.ToString());

        DepositConfText.text = "DEPOSIT SUCCESSFUL YOUR CURRENT BALANCE IS " + balance.ToString();
    }


    public void BalanceAmount()
    {


        wtdrNumText.text = typeWtdrNum.text;




        balanceAmountText.text = "YOUR BALANCE AMOUNT IS " + PlayerPrefs.GetString("balance");


     

    }
    public void ThankYouMessage()
    {
        string userData = PlayerPrefs.GetString(typeAcctNum.text);

        string[] userDataList = userData.Split(';');


        string strtFirstName = userDataList[1];
        string strtLastName = userDataList[2];

        //Debug.Log(PlayerPrefs.GetString("newAcctNum"));

        ThankYouText.text = "Thank You " + strtFirstName + " " + strtLastName + " FOR YOUR CONTINUOUS PATRONAGE";
    }





    public void BalanceButton()
    {
        optionsPage.SetActive(false);
        balanceAmountPage.SetActive(true);
        BalanceAmount();
    }
   
    public void WithdrawButton()
    {
        optionsPage.SetActive(false);
        withdrawalPage.SetActive(true);
        wtdrConfText.text = "HOW MUCH DO YOU WANT TO WITHDRAW?";
        typeWtdrNum.text = "";
        WtdrNum();
    }

    public void DepositButton()
    {
        optionsPage.SetActive(false);
        depositPage.SetActive(true);
        typeDepositNum.text = "";
        DepositConfText.text = "HOW MUCH DO YOU WANT TO DEPOSIT?";

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
        ThankYouMessage();

    }

    public void QuitApp()
    {
        Application.Quit();
    }











    
    public void Update()
    {

        SignIn();
        //BalanceAmount();


    }

}
