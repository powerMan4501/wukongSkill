using System.Collections.Generic;

namespace System.Collections.ObjectModel;

internal static class ReadOnlyDictionaryHelpers
{
	internal static void CopyToNonGenericICollectionHelper<T>(ICollection<T> collection, Array array, int index)
	{
		if (array == null)
		{
			ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
		}
		if (array.Rank != 1)
		{
			ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_RankMultiDimNotSupported);
		}
		if (array.GetLowerBound(0) != 0)
		{
			ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_NonZeroLowerBound);
		}
		if (index < 0)
		{
			ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.arrayIndex, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
		}
		if (array.Length - index < collection.Count)
		{
			ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_ArrayPlusOffTooSmall);
		}
		if (collection is ICollection collection2)
		{
			collection2.CopyTo(array, index);
			return;
		}
		if (array is T[] array2)
		{
			collection.CopyTo(array2, index);
			return;
		}
		Type elementType = array.GetType().GetElementType();
		Type typeFromHandle = typeof(T);
		if (!elementType.IsAssignableFrom(typeFromHandle) && !typeFromHandle.IsAssignableFrom(elementType))
		{
			ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidArrayType);
		}
		object[] array3 = array as object[];
		if (array3 == null)
		{
			ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidArrayType);
		}
		try
		{
			foreach (T item in collection)
			{
				array3[index++] = item;
			}
		}
		catch (ArrayTypeMismatchException)
		{
			ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidArrayType);
		}
	}
}
