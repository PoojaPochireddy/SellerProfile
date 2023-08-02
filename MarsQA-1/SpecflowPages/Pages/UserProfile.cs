using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages
{
    public class UserProfile 
    {
        public string ProfilePageValidation()
        {
            Thread.Sleep(1000);
            String title = Driver.driver.Title;
            Console.WriteLine(title);
            return title;
        }
        public bool UserValidation()
        {
            try
            {
                return false;
            }
            catch
            {
                return true;
            }

        }
    }

}
