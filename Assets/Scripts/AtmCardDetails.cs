using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class AtmCardDetails : MonoBehaviour
{

    public InputField typeAcctNum;
    public Text acctNumText;
    public InputField typePinNum;
    public Text acctPinText;

    string accountNumber;
    int pin;
    string firstName;
    string lastName;
    double balance;

    public AtmCardDetails(string cardNumber, int pin, string firstName, string lastName, double balance)
    {
        this.accountNumber = cardNumber;
        this.pin = pin;
        this.firstName = firstName;
        this.lastName = lastName;
        this.balance = balance;
    }

   

    public string getAccountNumber()
    {
        return accountNumber;
    }

    public int getPin()
    {
        return pin;
    }

    public string getFirstName()
    {
        return firstName;
    }

    public string getLastName()
    {
        return lastName;
    }

    public double getBalance()
    {
        return balance;
    }

    public void setAccountNumber(string newAccountNumber)
    {
        accountNumber = newAccountNumber;
    }

    public void setPin(int newPin)
    {
        pin = newPin;
    }

    public void setFirstName(string newFirstName)
    {
        firstName = newFirstName;
    }

    public void setLastName(string newLastName)
    {
        lastName = newLastName;
    }

    public void setBalance(double newBalance)
    {
        balance = newBalance;
    }

    private void deposit()
    {

        
    }





    public void List()
    {
        List<AtmCardDetails> bankAccounts = new List<AtmCardDetails>();
        bankAccounts.Add(new AtmCardDetails("2105420352", 1124, "emeka", "Adams", 100000));
        bankAccounts.Add(new AtmCardDetails("2108952352", 9904, "emeka", "Adams", 508800));
        bankAccounts.Add(new AtmCardDetails("2162520352", 1805, "emeka", "Adams", 25000));
        bankAccounts.Add(new AtmCardDetails("2199220252", 9073, "emeka", "Adams", 855000));
        bankAccounts.Add(new AtmCardDetails("2180080002", 5229, "emeka", "Adams", 1800));

        string acctNumTyped = "";
        AtmCardDetails currentUser;



        //while (true)
        //{
        //    try
        //    {
        //        acctNumTyped = acctNumText.text;

        //        currentUser = bankAccounts.

        //    }
        //    catch
        //    {

        //    }
        //}
    }




    // Input Details Here
    public void AcctNumInput()
    {
        acctNumText.text = typeAcctNum.text;
        Debug.Log(acctNumText.text);

    }

    public void PinNumberInput()
    {
      
        acctPinText.text = typePinNum.text;
        
        Debug.Log(acctPinText.text);
    }


    
   

    
}
