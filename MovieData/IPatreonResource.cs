using System;
using System.Collections.Generic;
using System.Text;
using MovieData.Models;

namespace MovieData
{
    public interface IPatreonResource
    {

        Patreon GetById(int id);
        Patreon GetPatreon(string loginName, string userPassword);
        void Add(Patreon newUser);
        string GetFirstName(int id);
        string GetLastName(int id);
        string GetAddress(int id);
        string GetEmailAddress(int id);
        string GetPhoneNumber(int id);
        bool IsLoginNameUnique(string proposedLoginName);

    }
}
