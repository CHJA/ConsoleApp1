using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.开发版
{
    class Dev
    {
        static void Main()
        {
            Console.WriteLine("开发版：這是一行測試語句！");
            Console.WriteLine("Windows 輸入法 繁體/简体 轉換快捷鍵：Ctrl+Shift+F");

            Book book = new Book();
            Console.WriteLine("書名：{0}",book.DisplayName());
            Console.WriteLine("版本號：{0}",book.DisplayVersion());

            Console.ReadLine();
        }
    }

    class Book
    {
        /// <summary>
        /// 版本号：0.0.00
        /// </summary>
        private string version;

        /// <summary>
        /// 名称
        /// </summary>
        private string name;

        public virtual string Version { get => version; set => version = value; }
        public virtual string Name { get => name; set => name = value; }

        private string GetVersion()
        {
            return Version;
        }

        private void SetVersion(string value)
        {
            Version = value;
        }

        private string GetName()
        {
            return Name;
        }

        private void SetName(string value)
        {
            Name = value;
        }

        public string DisplayVersion()
        {
            return GetVersion();
        }

        public string DisplayName()
        {
            return GetName();
        }

        public Book()
        {
            SetName("Git Tutorial");
            SetVersion("0.0.01");
        }

    }
}
