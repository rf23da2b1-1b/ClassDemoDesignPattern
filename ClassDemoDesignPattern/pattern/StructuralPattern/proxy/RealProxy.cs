﻿using System;
using System.Collections.Generic;

namespace ClassDemoDesignPatterns.pattern.StructuralPattern.proxy
{
    class RealProxy:IDemoProxy
    {
        private List<String> _data = new List<string>();
        public void InsertString(string str)
        {
            _data.Add(str);
        }

        public List<string> GetAll()
        {
            return new List<string>(_data);
        }
    }
}
