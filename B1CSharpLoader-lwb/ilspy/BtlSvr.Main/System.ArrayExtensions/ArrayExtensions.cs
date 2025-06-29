namespace System.ArrayExtensions;

public static class ArrayExtensions
{
	public static void ForEach(this Array array, Action<Array, int[]> action)
	{
		if (array.LongLength != 0L)
		{
			System.ArrayExtensions.ArrayTraverse arrayTraverse = new System.ArrayExtensions.ArrayTraverse(array);
			do
			{
				action(array, arrayTraverse.Position);
			}
			while (arrayTraverse.Step());
		}
	}
}
