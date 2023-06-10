using System;
using System.Collections.Generic;

namespace Library
{
    public class CalcLongestPersName : IComputable
    {
        private Node Node { get; set; }

        public CalcLongestPersName(Node node)
        {
            Node = node;
        }

        public int Calc()
        {
            Visitor visitor = new CalcLongestNamePersVisitor();
            this.Node.Accept(visitor);
            return visitor.FinalResult;
        }
    }

    public class CalculateOldestFamilyMember : IComputable
    {
        private Node Node { get; set; }

        public CalculateOldestFamilyMember(Node node)
        {
            Node = node;
        }

        public int Calc()
        {
            Visitor visitor = new CalcOldestNamePersVisitor();
            this.Node.Accept(visitor);
            return visitor.FinalResult;
        }
    }

    public class CalculatePersonAge : IComputable
    {
        private Node Node { get; set; }

        public CalculatePersonAge(Node node)
        {
            Node = node;
        }

        public int Calc()
        {
            Visitor visitor = new CalculatePersonAgeVisitor();
            this.Node.Accept(visitor);
            return visitor.FinalResult;
        }
    }

    public class Calculator 
    {
        private IComputable CalculationStrategy { get; set; }
        public Calculator(IComputable calculationStrategy)
        {
            this.CalculationStrategy = calculationStrategy;
        }

        public int Calc()
        {
            int result = this.CalculationStrategy.Calc();
            return result;
        }
    }
}