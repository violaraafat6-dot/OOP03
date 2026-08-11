using System.Numerics;
using System.Xml.Linq;

namespace OOP03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region question1
            //            a) What is the difference between Method Overloading and Method Overriding?

            //Method Overloading:
            //Having multiple methods with the same name in the same class but with different parameters

            //Method Overriding:
            //A derived class provides a specific implementation of a method that already exists in the base class


            //            b) What is the difference between Static Binding and Dynamic Binding?

            //Static Binding:
            //The method to execute is determined at compile time

            //Dynamic Binding:
            //The method to execute is determined at runtime depending on the actual object

            #endregion

            #region question2

//            a) What is the purpose of the sealed keyword when applied to a class?

//A sealed class cannot be inherited.It stops the inheritance chain

//b) What is the difference between a sealed class and a sealed method?

//A sealed class prevents other classes from inheriting from it.

//A sealed method prevents further overriding of that method in derived classes

//c) Can a sealed method be overridden? Why?
//No.A sealed method cannot be overridden because the sealed keyword prevents further overriding down the inheritance chain


            #endregion
        }
    }
}
