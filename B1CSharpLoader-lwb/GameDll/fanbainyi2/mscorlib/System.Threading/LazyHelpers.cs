namespace System.Threading;

internal static class LazyHelpers<T>
{
	internal static Func<T> s_activatorFactorySelector = ActivatorFactorySelector;

	private static T ActivatorFactorySelector()
	{
		try
		{
			return (T)Activator.CreateInstance(typeof(T));
		}
		catch (MissingMethodException)
		{
			throw new MissingMemberException(Environment.GetResourceString("Lazy_CreateValue_NoParameterlessCtorForT"));
		}
	}
}
