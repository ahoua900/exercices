using System;
namespace exercice_1
{
    public class ClassOne
    {
        public int content;

        public void ConvertToChaine()
        {
            var result = Convert.ToString(content);
        }
        public void ConvertToDouble()
        {
            Console.WriteLine("conversion en double");
        }
        public void ConvertToFloat()
        {
            Console.WriteLine("conversion en float");
        }
        public void ConvertToCar()
        {
            Console.WriteLine("conversion en car");
        }


    }
    public class ClassTwo
    {
        public string content;

        public void ConvertToInteger()
        {
            
        }
        public void Capitalize()
        {
            var capi =  content.Substring(0, 1).ToUpper();
        }
        public void minimize()
        {
            var min = content.ToLower();
        }
        public void maximize()
        {
            var max = content.ToUpper();
        }
        public void RevokeOnStart(int a )
        {
            var trimo = content.Trim();
            content.Remove(a,-1);

        

        }
    }
}
