namespace Strings
{
    public static class Manipulations
    {
        /// <summary>
        /// Returns a greeting.
        /// </summary>
        public static string GetHelloGreeting1(string name)
        {
            return "Hello, " + name + "!";
        }

        /// <summary>
        /// Returns a greeting.
        /// </summary>
        public static string GetGreeting1(string greeting, string name)
        {
            return string.Concat(greeting, ", ", name.ToUpperInvariant(), "!");
        }

        /// <summary>
        /// Returns a greeting.
        /// </summary>
        public static string GetHelloGreeting2(string name)
        {
            return string.Concat("Hello, ", name.Trim(), "!");
        }

        /// <summary>
        /// Returns a greeting.
        /// </summary>
        public static string GetGreeting2(string greeting, string name)
        {
            return string.Concat(greeting.Trim(), ", ", name.ToLowerInvariant().Trim(), "!");
        }

        /// <summary>
        /// Returns a greeting.
        /// </summary>
        public static string GetHelloGreeting3(string template, string name)
        {
            return template.Replace("{name}", name, StringComparison.InvariantCulture);
        }

        /// <summary>
        /// Returns a greeting.
        /// </summary>
        public static string GetGreeting3(string template, string greeting, string name)
        {
            string s = template.Replace("{name}", name.ToUpperInvariant(), StringComparison.InvariantCulture);
            string y = s.Replace("{greeting}", greeting.ToLowerInvariant(), StringComparison.InvariantCulture);
            return y;
        }

        /// <summary>
        /// Returns refined code - without zero characters.
        /// </summary>
        public static string GetRefinedCode(string code)
        {
            return code.Remove(3, 3);
        }

        /// <summary>
        /// Returns refined date - without dash characters.
        /// </summary>
        public static string GetRefinedDate(string date)
        {
            return date.Replace("-", string.Empty, StringComparison.InvariantCulture);
        }
    }
}
