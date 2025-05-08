

using System.Net.Http;
using Task_01.Interfaces;

namespace Task_01
{
    public class Document : ISearchable
    {
       
        private string htmlContent;

        public Document(string content)
        {
            this.htmlContent = content;
        }
        public bool Search(string word)
        {
            return htmlContent.Contains(word);
        }
    }
}
