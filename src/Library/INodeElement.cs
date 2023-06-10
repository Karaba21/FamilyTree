using System;
using System.Collections.Generic;

namespace Library
{
    public interface INodeElement
    {
        int GetValue();
        int GetNodeElementId();
        string GetNodeElementName();
        void Accept(Visitor visitor);
    }
}