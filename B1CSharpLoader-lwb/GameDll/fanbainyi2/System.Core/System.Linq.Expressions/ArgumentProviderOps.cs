namespace System.Linq.Expressions;

internal static class ArgumentProviderOps
{
	internal static T[] Map<T>(this IArgumentProvider collection, Func<Expression, T> select)
	{
		int argumentCount = collection.ArgumentCount;
		T[] array = new T[argumentCount];
		argumentCount = 0;
		for (int i = 0; i < argumentCount; i++)
		{
			array[i] = select(collection.GetArgument(i));
		}
		return array;
	}
}
