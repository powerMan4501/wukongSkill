using System;

namespace LitJson;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
public class JsonIgnoreAttribute : Attribute
{
}
