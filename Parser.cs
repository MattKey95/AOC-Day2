using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AOC_Day2
{
    public class Parser
    {
        private string _path;

        public Parser(string path)
        {
            _path = path;
        }

        public IEnumerable<int> Parse()
        {
            using(StreamReader sr = new StreamReader(_path))
            {
                var program = sr.ReadToEnd();
                return ConvertToInt(program.Split(','));
            }
        }

        private IEnumerable<int> ConvertToInt(IEnumerable<string> target)
        {
            foreach(var item in target)
            {
                yield return int.Parse(item);
            }
        }
    }
}
