namespace newo_core_composition.Impl;

using System.CodeDom.Compiler;
using System.Data.Common;
using System.Text;
using Base;
using Interfaces;

internal class ConcreteCompositeElement : CompositeElement
{
    public ConcreteCompositeElement(string name, ICommonBehaviour behaviour) : base(name, behaviour)
    {
    }

    public override string Render(int indent = 0)
    {
        var locIndent = indent;
        StringBuilder builder = new StringBuilder();

        builder.Append($"- {this.Name}");

        foreach (var ceb in this.compositeElements)
        {
            builder.AppendLine();
            for(int i = 0; i <= locIndent; i++) builder.Append("\t");
            builder.Append(ceb.Render(locIndent+1));
        }

        return builder.ToString();
    }
}