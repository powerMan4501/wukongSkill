using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;

namespace System.Runtime.CompilerServices;

[Serializable]
[AttributeUsage(AttributeTargets.Field | AttributeTargets.Parameter, Inherited = false)]
[ComVisible(true)]
[__DynamicallyInvokable]
public sealed class DecimalConstantAttribute : Attribute
{
	private decimal dec;

	[__DynamicallyInvokable]
	public decimal Value
	{
		[__DynamicallyInvokable]
		get
		{
			return dec;
		}
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public DecimalConstantAttribute(byte scale, byte sign, uint hi, uint mid, uint low)
	{
		dec = new decimal((int)low, (int)mid, (int)hi, sign != 0, scale);
	}

	[__DynamicallyInvokable]
	public DecimalConstantAttribute(byte scale, byte sign, int hi, int mid, int low)
	{
		dec = new decimal(low, mid, hi, sign != 0, scale);
	}

	internal static decimal GetRawDecimalConstant(CustomAttributeData attr)
	{
		foreach (CustomAttributeNamedArgument namedArgument in attr.NamedArguments)
		{
			if (namedArgument.MemberInfo.Name.Equals("Value"))
			{
				return (decimal)namedArgument.TypedValue.Value;
			}
		}
		ParameterInfo[] parameters = attr.Constructor.GetParameters();
		IList<CustomAttributeTypedArgument> constructorArguments = attr.ConstructorArguments;
		if (parameters[2].ParameterType == typeof(uint))
		{
			int lo = (int)(uint)constructorArguments[4].Value;
			int mid = (int)(uint)constructorArguments[3].Value;
			int hi = (int)(uint)constructorArguments[2].Value;
			byte b = (byte)constructorArguments[1].Value;
			byte scale = (byte)constructorArguments[0].Value;
			return new decimal(lo, mid, hi, b != 0, scale);
		}
		int lo2 = (int)constructorArguments[4].Value;
		int mid2 = (int)constructorArguments[3].Value;
		int hi2 = (int)constructorArguments[2].Value;
		byte b2 = (byte)constructorArguments[1].Value;
		byte scale2 = (byte)constructorArguments[0].Value;
		return new decimal(lo2, mid2, hi2, b2 != 0, scale2);
	}
}
