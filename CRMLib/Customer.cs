namespace CRMLib;
public class Customer
{
public int Id{get;set;}
public string FirstName{get;set;}
public string LastName{get;set;}
public long ContactNumber{get;set;}
public string Email{get;set;}

public Customer(){
    this.Id=1;
this.FirstName="Abhay";
this.LastName="Navale";
this.ContactNumber=9075966080;
this.Email="navale.abhay12@gmail.com";
}

public Customer(int id,string firstname,string lastname,long monumber,string em){
    this.Id=id;
    this.FirstName=firstname;
    this.LastName=lastname;
    this.ContactNumber=monumber;
    this.Email=em;
}

    public override string ToString()
    {
        return this.Id+"***"+this.FirstName+"***"+this.LastName+"***"+this.ContactNumber+"***"+this.Email;
    }


}
