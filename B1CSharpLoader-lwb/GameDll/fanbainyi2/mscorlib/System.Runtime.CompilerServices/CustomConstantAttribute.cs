using System.Reflection;
using System.Runtime.InteropServices;

namespace System.Runtime.CompilerServices;

[Serializable]
[AttributeUsage(AttributeTargets.Field | AttributeTargets.Parameter, Inherited = false)]
[ComVisible(true)]
[__DynamicallyInvokable]
public abstract class CustomConstantAttribute : Attribute
{
	[__DynamicallyInvokable]
	public abstract object Value
	{
		[__DynamicallyInvokable]
		get;
	}

	internal static object GetRawConstant(CustomAttributeData attr)
	{
		foreach (CustomAttributeNamedArgument namedArgument in attr.NamedArguments)
		{
			if (namedArgument.MemberInfo.Name.Equals("Value"))
			{
				return namedArgument.TypedValue.Value;
			}
		}
		return DBNull.Value;
	}

	[__DynamicallyInvokable]
	protected CustomConstantAttribute()
	{
	}
}
