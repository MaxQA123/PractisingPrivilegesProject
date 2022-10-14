using NUnit.Allure.Attributes;
using PractisingPrivileges.Helpers;
using PractisingPrivilegesProject.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractisingPrivilegesProject.PageObjects.DemoPage
{
    public partial class DemoTest
    {
        [AllureStep("SigningInAsClinician")]
        public DemoTest SigningInAsClinician()
        {
            InputGeneral.InputFunctionWithClear(FieldInputEmailLogInPg, TestDataClinician.EMAIL_DEMO_TEST);
            InputGeneral.InputFunctionWithClear(FieldInputPasswordLogInPg, TestDataGeneral.generalPassword);
            Button.Click(ButtonSignInLogInPg);

            return this;
        }

        [AllureStep("GetDemoFirstNameFromUserProfile")]
        public string GetDemoFirstNameFromUserProfile()
        {
            WaitUntil.WaitSomeInterval(3000);
            string getFirstName = TextNameRoleOnHeader.Text.Substring(0, TextNameRoleOnHeader.Text.IndexOf(" "));
            string firstNameActual = getFirstName.ToString();

            Console.WriteLine(firstNameActual);

            return firstNameActual;
        }

        [AllureStep("DemoRandom")]
        public DemoTest DemoRandom()
        {
            string[] RandomFirstName = { "sgsg", "dfghfgh", "34543t", "sdf", "3453" };
            Random random = new Random();
            random.Next(0, RandomFirstName.Length - 1);
            //Console.WriteLine("Случайное число = " + a + "\nСоотвертствующая строка = " + RandomFirstName[a]);
            return this;
        }

        [AllureStep("RandomPriceMinInteger")]
        public static string RandomNumberCharacter(int size)
        {
            Random random = new Random();
            const string chars = "1234567890*&^%$#@!";
            return new string(Enumerable.Repeat(chars, size)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        [AllureStep("DemoRandom")]
        public void button1_Click(object sender, EventArgs e)
        {
            string[] people = { "Tom", "Bob", "Sam", "Tim", "Tomas", "Bill" };

            var selectedPeople = people.Where(p => p.ToUpper().StartsWith("T")).OrderBy(p => p);

            foreach (string person in selectedPeople)
                Console.WriteLine(person);
        }
    }
}
