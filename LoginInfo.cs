//Author: Ramandeep Kaur

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homepage
{
    public static class LoginInfo
    {
        public static string Username;
        public static string id;
        public static string copies;//incremented copies
        public static string limit;//incremented limit

        public static string decrementCopies;
        public static string decrementLimit;
        public static string title;

        public static string availableCopies;
        public static string status;//status of book in members_book

        public static string dueDate;//book return date in members_book
        public static DateTime extendedDueDate;

        //used in overdues.cs
        public static int isbn;
        public static DateTime dueDate1;
        public static DateTime issueDate1;

        //used in payments.cs
        public static int isbn1;
        public static int days;

        //used in history_returned_books
        public static string date;
        




    }
}
