using System.Reflection;

namespace System.Diagnostics.Tracing;

internal static class EnumHelper<UnderlyingType>
{
	private delegate UnderlyingType Transformer<ValueType>(ValueType value);

	private static class Caster<ValueType>
	{
		public static readonly Transformer<ValueType> Instance = (Transformer<ValueType>)Statics.CreateDelegate(typeof(Transformer<ValueType>), EnumHelper<UnderlyingType>.IdentityInfo);
	}

	private static readonly MethodInfo IdentityInfo = Statics.GetDeclaredStaticMethod(typeof(EnumHelper<UnderlyingType>), "Identity");

	public static UnderlyingType Cast<ValueType>(ValueType value)
	{
		return Caster<ValueType>.Instance(value);
	}

	internal static UnderlyingType Identity(UnderlyingType value)
	{
		return value;
	}
}
