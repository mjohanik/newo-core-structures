namespace newo_core_composition.Impl;

using Base;
using Interfaces;

internal class ConcreteLeafCompositeElement : CompositeElementBase
{
    public ConcreteLeafCompositeElement(string name, ICommonBehaviour behaviour) : base(name, behaviour)
    {
    }

    public override string Render(int indent = 0)
    {
        return $"- {this.Name}";
    }
}

internal class RenderableItem
{
    public RenderableItem(string name)
    {
        this.Name = name;
    }

    public string Name { get; private set; }
}