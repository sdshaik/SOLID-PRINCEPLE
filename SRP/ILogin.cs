using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_practice
{
    interface IUser //wrong way
    {
        bool Login(string username, string password);
        bool Register(string username, string password, string email);
        void LogError(string error);
        bool SendEmail(string message);
        //its not a correct way to add logerror and sendmail method in Iuser becuese 
        //logerror and sendmail is performing diffrent type of tasks then login and registration.
    }

    //correct way using SRP
    interface IUser2
    {
        bool Login(string Username, string Password);
        bool Register(string Username, string Password, string email);
    }
    interface ILogger
    {
        void Log(string error);
    }
    interface IMail
    {
        bool sendmail(string message);
    }

}
