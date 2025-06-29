namespace System.Collections;

[__DynamicallyInvokable]
public static class StructuralComparisons
{
	private static volatile IComparer s_StructuralComparer;

	private static volatile IEqualityComparer s_StructuralEqualityComparer;

	[__DynamicallyInvokable]
	public static IComparer StructuralComparer
	{
		[__DynamicallyInvokable]
		get
		{
			IComparer comparer = s_StructuralComparer;
			if (comparer == null)
			{
				comparer = (s_StructuralComparer = new StructuralComparer());
			}
			return comparer;
		}
	}

	[__DynamicallyInvokable]
	public static IEqualityComparer StructuralEqualityComparer
	{
		[__DynamicallyInvokable]
		get
		{
			IEqualityComparer equalityComparer = s_StructuralEqualityComparer;
			if (equalityComparer == null)
			{
				equalityComparer = (s_StructuralEqualityComparer = new StructuralEqualityComparer());
			}
			return equalityComparer;
		}
	}
}
