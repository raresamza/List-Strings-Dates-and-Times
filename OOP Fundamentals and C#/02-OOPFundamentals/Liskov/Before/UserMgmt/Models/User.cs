﻿namespace Before.UserMgmt.Models;

public abstract class User
{
    public User(string username, string password)
    {
        Username = username;
        Password = password;
    }
    
    public string Username { get; set; }
    public string Password { get; set; }
    
    public abstract void ApproveWorkflow();

    public virtual bool CheckPasswordValid()
    {
        return Password.Length > 8;
    }
    
}