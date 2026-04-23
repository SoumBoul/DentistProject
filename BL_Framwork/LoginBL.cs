using System;
using DAL_Framwork;
using DTO_Framwork;

namespace BL_Framwork
{
    public class LoginBL
    {
          static public bool LoginWithUserNameAndPassWord(string username,string password)
          {

            return LoginDAL.LoginWithUserNameAndPassword(username, password);
        
          }

          static public string FindImageUser(string username)
          {

            return LoginDAL.FindImageUser(username);

          }
        


    }
}
