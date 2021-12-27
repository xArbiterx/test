using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    public class Class1
    {
        private const string PROP = "prop";
        private const string CLASS = "class";

        private const string DECLARE = "public %s %s {get; set;}";

        public static void Test1()
        {
            string xml = "<xxx><xxx1></xxx1><xxx11></xxx11><xxxx/><aaaa><aaa1></aaa1></aaaa></xxx>";
            xml = xml.Trim();
            List<string> classList = new List<string>();
            Queue<string> nameTextQueue = new();

            int start = 0, end = 0;
            bool sFlag = false;
            for (int i = 0; i < xml.Length; i++)
            {
                var word = xml[i];

                if (word == '<')
                {
                    if (sFlag)
                    {
                        throw new Exception("");
                    }
                    start = i + 1;
                    sFlag = true;
                }
                else if (word == '>')
                {
                    if (!sFlag)
                    {
                        throw new Exception("");
                    }
                    end = i;
                    var tagText = xml[start..end].Trim(' ');
                    if (tagText.Length == 0)
                    {
                        throw new Exception();
                    }
                    nameTextQueue.Enqueue(tagText);
                    sFlag = false;
                }
            }

            //当前对象栈 (节点名称)
            Stack<string> stack = new();
            // 字典（父节点名称，（栈（子节点名称，类型<字段或者对象>）））
            List<KeyValuePair<string, KeyValuePair<string, string>>> dic = new();

            Stack<string> currStack = new();
            string lastName = "";
            while (nameTextQueue.Count > 0)
            {
                var currText = nameTextQueue.Dequeue();
                var textArr = currText.Split(" ");

                if (currText.Last() == '/')
                {
                    dic.Add(new KeyValuePair<string, KeyValuePair<string, string>>(stack.Peek(), new KeyValuePair<string, string>(textArr[0].Replace("/", ""), PROP)));
                }
                else if (!textArr[0].Contains("/"))
                {
                    currStack.Push(textArr[0]);
                    if (lastName == "")
                    {
                        lastName = textArr[0];
                    }
                    else
                    {
                        lastName = textArr[0];
                    }
                    stack.Push(lastName);

                }
                else if (textArr[0] == "/" + currStack.Peek())
                {
                    //是则是属性，否则是class
                    if (currStack.Peek() == lastName)
                    {
                        stack.Pop();
                        if (stack.Count > 0)
                        {
                            dic.Add(new KeyValuePair<string, KeyValuePair<string, string>>(stack.Peek(), new KeyValuePair<string, string>(currStack.Pop(), PROP)));
                        }
                    }
                    else
                    {
                        if (stack.Count > 0 && (stack.Peek() == currStack.Peek() || stack.Peek() == lastName))
                        {
                            stack.Pop();
                        }
                        classList.Add(currStack.Peek());
                        if (stack.Count > 0)
                        {
                            dic.Add(new KeyValuePair<string, KeyValuePair<string, string>>(stack.Peek(), new KeyValuePair<string, string>(currStack.Pop(), CLASS)));
                        }
                        else
                        {
                            dic.Add(new KeyValuePair<string, KeyValuePair<string, string>>("", new KeyValuePair<string, string>(currStack.Pop(), CLASS)));
                        }

                    }
                }
                else
                {
                    throw new Exception();
                }
            }
            StringBuilder sb = new StringBuilder();

            
        }
    }
}
