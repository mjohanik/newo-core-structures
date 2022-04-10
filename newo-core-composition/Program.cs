namespace newo_core_composition
{
    using System;
    using Base;
    using Impl;
    using Interfaces;

    internal class Program
    {
        static void Main(string[] args)
        {
            var commonBehaviour = new StringRenderer();
            CompositeElement cce0 = new ConcreteCompositeElement("root0", commonBehaviour);
            CompositeElement cce1 = new ConcreteCompositeElement("middleman0", commonBehaviour);
            ConcreteLeafCompositeElement cce2 = new ConcreteLeafCompositeElement("leaf1", commonBehaviour);
            ConcreteLeafCompositeElement cce3 = new ConcreteLeafCompositeElement("leaf2", commonBehaviour);

            cce0.AddChild(cce1);
            cce0.AddChild(cce2);
            cce1.AddChild(cce3);
            cce0.Render();

            Console.WriteLine(cce0.Render());
        }
    }
}