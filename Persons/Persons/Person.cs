﻿using System;

class Person
{
    private string name;
    private int age;
    private string email;

    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            if(value == null || value.Trim() == "")
            {
                throw new ArgumentNullException("Invalid name");
            }
            else
            {
                this.name = value;
            }
        }
    }

    public int Age
    {
        get
        {
            return this.age;
        }
        set
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentOutOfRangeException("Invalid age");
            }
            else
            {
                this.age = value;
            }
        }
    }

    public string Email
    {
        get
        {
            return this.email;
        }
        set
        {
            if (String.IsNullOrEmpty(value))
            {
                this.email = "(not set)";
            }
            else if (value.Contains("@"))
            {
                this.email = value;
            }
            else
            {
                throw new ArgumentException("Invalid Email !");
            }
        }
    }

    public Person(string name, int age, string email)
    {
        this.Name = name;
        this.Age = age;
        this.Email = email;
    }

    public Person(string name, int age) : this (name, age, null)
    {

    }

    public override string ToString()
    {
        return string.Format("Name:{0}\nAge:{1}\nEmail:{2}\n",this.Name,this.Age,this.Email); 
    }
}