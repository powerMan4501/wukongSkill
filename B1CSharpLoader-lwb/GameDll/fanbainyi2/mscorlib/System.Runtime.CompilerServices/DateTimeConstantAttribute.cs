using System.Reflection;
using System.Runtime.InteropServices;

namespace System.Runtime.CompilerServices;

[Serializable]
[AttributeUsage(AttributeTargets.Field | AttributeTargets.Parameter, Inherited = false)]
[ComVisible(true)]
[__DynamicallyInvokable]
public sealed class DateTimeConstantAttribute : CustomConstantAttribute
{
	private DateTime date;

	[__DynamicallyInvokable]
	public override object Value
	{
		[__DynamicallyInvokable]
		get
		{
			return date;
		}
	}

	[__DynamicallyInvokable]
	public DateTimeConstantAttribute(long ticks)
	{
		date = new DateTime(ticks);
	}

	internal static DateTime GetRawDateTimeConstant(CustomAttributeData attr)
	{
		foreach (CustomAttributeNamedArgument namedArgument in attr.NamedArguments)
		{
			if (namedArgument.MemberInfo.Name.Equals("Value"))
			{
				return new DateTime((long)namedArgument.TypedValue.Value);
			}
		}
		return new DateTime((long)attr.ConstructorArguments[0].Value);
	}
}
