using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class BankAccountDetails : MonoBehaviour
{



        private void Start()
    {
   
      
    }

    private void Update()
    {

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

        //int pinoc = 1212;

        //if (AccountNumber.Contains("2105420352") == true)
        //{

        //    int index = AccountNumber.IndexOf("2105420352");



        //    //Debug.Log(AccountNumberPin[0]);
        //    //Debug.Log(AccountNumber.IndexOf("2105420352"));

        //    if (AccountNumberPin[index] == pinoc)
        //    {

        //        Debug.Log("Welcome " + AccountName[index] + " YOUR ACCOUNT BALANCE IS " + AccountBalance[index]);
        //    }
        //    else
        //    {
        //        Debug.Log("Wrong Pin");
        //    }


        //}
        //else
        //{
        //    Debug.Log("Account not found");
        //}

        //if (AccountNumberPin[0] == 1212)
        //{
        //    //Debug.Log(AccountName[0]);
        //}

        //bool isInside = AccountNumber.Contains("2180080002");
        //Debug.Log(isInside);
        //Debug.Log("It Is " + AccountNumber.Contains("2180080002"));

        //int  AccountNumber.Count = accountNumberPosition;
        //int accountPinPosition = AccountNumberPin.Count;

        //accountNumberPosition = accountPinPosition;


        //Debug.Log(AccountNumberPin.Count);

    }




    private void Pasted()
    {

        //public BankAccountDetails(string accountNumber, int pin, string firstName, string lastName, double balance)
        //{
        //    this.accountNumber = accountNumber;
        //    this.pin = pin;
        //    this.firstName = firstName;
        //    this.lastName = lastName;
        //    this.balance = balance;
        //}






        // static void Main (string[] args)
        //{
        //    List<BankAccountDetails> bankAccounts = new List<BankAccountDetails>();


        //    bankAccounts.Add(new BankAccountDetails("2105420352", 1124, "emeka", "Adams", 100000));
        //    bankAccounts.Add(new BankAccountDetails("2108952352", 9904, "nenji", "Jiye", 508800));
        //    bankAccounts.Add(new BankAccountDetails("2162520352", 1805, "Dracula", "Spanyard", 25000));
        //    bankAccounts.Add(new BankAccountDetails("2199220252", 9073, "Alucard", "Emezi", 855000));
        //    bankAccounts.Add(new BankAccountDetails("2180080002", 5229, "Delilah", "Shubel", 1800));




        //    Debug.Log(bankAccounts.Contains(new BankAccountDetails("2105420352", 1124, "emeka", "Adams", 100000)));
        //    Debug.Log("Checkers");
        //}

        //void Update()
        //{


        //    //if (Input.GetKeyDown(KeyCode.Space))
        //    //{
        //    //    bankAccounts.Add(new BankAccountDetails("ii", Random.Range(1000, 9999), "hanah", "moorehead", Random.Range(5000, 1000000)));



        //    //    Debug.Log("is generating new account details");

        //    //}
        //}
    }


}
