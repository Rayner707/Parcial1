using System;
using System.Reflection;

namespace Parcial1_RaynerJimmyTapiaCaballero.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}