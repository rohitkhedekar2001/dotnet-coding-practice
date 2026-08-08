namespace Coding_Practice.Service
{
    public class BegginerrCodingQuestion : IBegginerrCodingQuestion
    {
        public string reverseastring(string abc)
        {
            string reverse = "";
            for (int i=abc.Length-1;i>=0;--i)
            {
                reverse+=abc[i];
            }
            return reverse;
        }

        
    }
}
