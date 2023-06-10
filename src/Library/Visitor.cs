using System;
using System.Collections.Generic;


namespace Library
{
   public abstract class Visitor
    {
    
    public int FinalResult { get; set; }

    public abstract void Visit(Node node);

    public abstract void Visit(INodeElement person);

    }
}