/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClasses.MementoPattern;

public interface IMyMemento
{
}


public class MyMemento : IMyMemento
{
  private int _balance;

  public MyMemento(int balance)
  {
    _balance = balance;
  }
}

public class MyBankAccount
{
  private int balance;
  private IMyMementoCareTaker _myMementoCareTaker;

  public MyBankAccount(IMyMementoCareTaker myMementoCareTaker)
  {
    _myMementoCareTaker = myMementoCareTaker;
  }

  public MyMemento Deposit(int amount)
  {
    balance += amount;
    var m = new MyMemento(balance);
    _myMementoCareTaker.Add(m);
    return m;
  }

}

public interface IMyMementoCareTaker
{
  public void Undo();
  public void Redo();
  public void Add(IMyMemento myMemento);
}

public class MyMementoCareTaker : IMyMementoCareTaker
{
  private List<MyMemento> changes = new List<MyMemento>();
  public void Redo()
  {

  }

  public void Undo()
  {

  }

  public void Add(IMyMemento myMemento)
  {
    changes.Add(myMemento);
  }
}
*/