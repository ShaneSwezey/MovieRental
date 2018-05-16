using System;
using System.Collections.Generic;
using System.Text;
using MovieData.Models;

namespace MovieData
{
    public interface IPatreonResource
    {
        // Return Patreon Model with repsect to pateron id
        Patreon GetById(int id);
        // Returns Patreon Model by login name and password
        Patreon GetPatreon(string loginName, string userPassword);
        // Adds a patreon 
        void Add(Patreon newUser);
        // Returns first name of patreon
        string GetFirstName(int id);
        // Returns last name of patreon
        string GetLastName(int id);
        // Returns address of patreon
        string GetAddress(int id);
        // Returns email address of patreon
        string GetEmailAddress(int id);
        // Returns phone number of patreon
        string GetPhoneNumber(int id);
        // Returns if login name is unqiue 
        bool IsLoginNameUnique(string proposedLoginName);

    }
}
