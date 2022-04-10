namespace newo_core_composition.Base;

using Interfaces;

internal abstract class CompositeElementBase
{
    public string Name { get; private set; }
    public ICommonBehaviour CommonBehaviour { get; private set; }

    protected CompositeElementBase(string name, ICommonBehaviour commonBehaviour)
    {
        this.Name = name;
        this.CommonBehaviour = commonBehaviour;
    }

    public abstract string Render(int indent = 0);
    public virtual void Behave()
    {
        this.CommonBehaviour.Behave();
    }
}