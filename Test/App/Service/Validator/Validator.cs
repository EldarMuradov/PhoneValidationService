using System;
using System.Text.RegularExpressions;

namespace Test.App.Service
{
    internal sealed class Validator : IValidator
    {
        public Validator() => _regex = new(_pattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);

        #region Vars

        private readonly string _pattern = @"\(\d*\)\-\d{3}\-\d{4}";

        private Regex _regex;

        #endregion

        #region Methods

        public void IsValid(ref string input, out bool isValid)
        {
            isValid = _regex.IsMatch(input);
            Console.WriteLine($"Completed with a result: {isValid}");
        }

        public void ReceiveMessage(ref string args, out bool isValid) => IsValid(ref args, out isValid);

        #endregion
    }
}
