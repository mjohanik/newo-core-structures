namespace newo_core_composition.Base;

using Interfaces;

internal abstract class CompositeElement : CompositeElementBase
{
    protected readonly ICollection<CompositeElementBase> compositeElements = new List<CompositeElementBase>();

    public CompositeElement(string name, ICommonBehaviour commonBehaviour) : base(name, commonBehaviour)
    {
    }

    public void AddChild(CompositeElementBase ceb)
    {
        this.compositeElements.Add(ceb);
    }

    public void RemoveChild(CompositeElementBase ceb)
    {
        this.compositeElements.Remove(ceb);
    }
}