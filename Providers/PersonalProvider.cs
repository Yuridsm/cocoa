using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cocoa.Services;
using cocoa.Interfaces;
using System.Text;

namespace cocoa.Providers
{
    public class PersonalProvider : PersonalInfoService
    {
        private readonly IPersonalInfo _personalInfo;
        public PersonalProvider(IPersonalInfo personalInfo)
        {
            _personalInfo = personalInfo;
        }
        private void SignUp(string firstName, string lastName, int age, string description)
        {
            _personalInfo.firstName = firstName;
            _personalInfo.lastName = lastName;
            _personalInfo.age = age;
            _personalInfo.description = description;
        }

        private void SetInfo()
        {
            SignUp("Yuri", "Melo", 22, "Description...");
        }

        public string GetInfo()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("First Name : " + _personalInfo.firstName);
            builder.Append("\nLast Name : " + _personalInfo.lastName);
            builder.Append("\nAge : " + _personalInfo.age);
            builder.Append("\nDescription : " + _personalInfo.description);
            return builder.ToString();
        }
    }
}
