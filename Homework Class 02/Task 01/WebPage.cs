

using System.Runtime.CompilerServices;
using Task_01.Interfaces;

namespace Task_01
{
    public class WebPage : ISearchable
    {
        private string content;

        public WebPage(string content)
        {
            this.content = content;
        }
        public bool Search(string word)
        {
            return content.Contains(word);
        }
    }
}
