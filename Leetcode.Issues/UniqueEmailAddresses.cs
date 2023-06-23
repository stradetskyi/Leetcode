using System.Collections.Generic;

namespace Leetcode.Issues
{
    /// <summary>
    /// 929. Unique Email Addresses https://leetcode.com/problems/unique-email-addresses/
    /// </summary>
    public class UniqueEmailAddresses
    {
        public int NumUniqueEmails(string[] emails)
        {
            var uniqueEmails = new HashSet<string>();

            foreach (var email in emails)
            {
                var emailParts = email.Split('@');
                var localName = emailParts[0];
                var domainName = emailParts[1];

                var localNameParts = localName.Split('+');
                var localNameWithoutPlus = localNameParts[0];
                var localNameWithoutDots = localNameWithoutPlus.Replace(".", "");

                var uniqueEmail = localNameWithoutDots + "@" + domainName;
                uniqueEmails.Add(uniqueEmail);
            }

            return uniqueEmails.Count;
        }
    }
}
