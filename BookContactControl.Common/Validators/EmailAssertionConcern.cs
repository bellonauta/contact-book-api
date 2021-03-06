using BookContactControl.Common;
using System;
using System.Text.RegularExpressions;

namespace BookContactControl.Common.Validators
{
    public class EmailAssertionConcern
    {
        public static void AssertIsValid(string email, string message)
        {
            if (!Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase))
                throw new InvalidOperationException(message);
        }
    }
}