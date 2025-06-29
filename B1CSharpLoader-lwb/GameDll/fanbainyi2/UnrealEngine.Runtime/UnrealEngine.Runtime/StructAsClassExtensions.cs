namespace UnrealEngine.Runtime;

public static class StructAsClassExtensions
{
	public static T Copy<T>(this T value) where T : StructAsClass, new()
	{
		T val = new T();
		val.Initialize();
		value.InternalCopyTo(val.Address);
		return val;
	}

	public static void CopyFrom<T>(this T value, T other) where T : StructAsClass
	{
		value.InternalCopyFromInstance(other);
	}
}
