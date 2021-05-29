using System;
using System.Linq;

class Person
{
    protected string firstName;
    protected string lastName;
    protected int id;

    public Person() { }
    public Person(string firstName, string lastName, int identification)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.id = identification;
    }
    public void printPerson()
    {
        Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
    }
}

class Student : Person
{
    private int[] testScores;

    /*	
    *   Class Constructor
    *   
    *   Parameters: 
    *   firstName - A string denoting the Person's first name.
    *   lastName - A string denoting the Person's last name.
    *   id - An integer denoting the Person's ID number.
    *   scores - An array of integers denoting the Person's test scores.
    */
    // Write your constructor here
    public Student(string firstName, string lastName, int id, int[] score) : base(firstName, lastName, id)
    {
        this.testScores = score;
    }
    /*	
    *   Method Name: Calculate
    *   Return: A character denoting the grade.
    */
    // Write your method here
    public string Calculate()
    {
        int avgMarks = 0, count = 0, i = 0;
        for (i = 0; i < testScores.Length; i++)
        {
            count += testScores[i];
        }
        avgMarks = count / i;

        if (avgMarks >= 90 && avgMarks <= 100)
        {
            return "O";
        }
        else if (avgMarks >= 80 && avgMarks < 90)
        {
            return "E";
        }
        else if (avgMarks >= 70 && avgMarks < 80)
        {
            return "A";
        }
        else if (avgMarks >= 55 && avgMarks < 70)
        {
            return "P";
        }
        else if (avgMarks >= 40 && avgMarks < 55)
        {
            return "D";
        }
        else
        {
            return "T";
        }
        return "";
    }
}

class Solution {