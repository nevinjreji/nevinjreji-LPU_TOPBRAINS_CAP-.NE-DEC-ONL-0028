using System;

namespace Day6Assignment
{
    class Book
    {
        #region Fields
        string title;
        string author;
        int numPages;
        DateTime dueDate;
        DateTime returnedDate;
        #endregion
        public Book(string title , string author , int numPages , DateTime dueDate , DateTime returnedDate)
        {
            this.title = title;
            this.author = author;
            this.numPages = numPages;
            this.dueDate = dueDate;
            this.returnedDate = returnedDate;
        }
        public double AveragePagesReadPerDay(int daysToRead)
        {
            double averagePagesRead = numPages / daysToRead;
            return averagePagesRead;
        }
        public double CalculateLateFee(double dailyLateFee)
        {   
            int numOfDaysLate = (returnedDate - dueDate).Days;
            return numOfDaysLate * dailyLateFee;
        }

    }
}