using System.Collections.Generic;
using System.Runtime.Serialization;

namespace System;

internal static class ThrowHelper
{
	internal static void ThrowWrongKeyTypeArgumentException(object key, Type targetType)
	{
		throw new ArgumentException(SR.GetString("Arg_WrongType", key, targetType), "key");
	}

	internal static void ThrowWrongValueTypeArgumentException(object value, Type targetType)
	{
		throw new ArgumentException(SR.GetString("Arg_WrongType", value, targetType), "value");
	}

	internal static void ThrowKeyNotFoundException()
	{
		throw new KeyNotFoundException();
	}

	internal static void ThrowArgumentException(ExceptionResource resource)
	{
		throw new ArgumentException(SR.GetString(GetResourceName(resource)));
	}

	internal static void ThrowArgumentNullException(ExceptionArgument argument)
	{
		throw new ArgumentNullException(GetArgumentName(argument));
	}

	internal static void ThrowArgumentOutOfRangeException(ExceptionArgument argument)
	{
		throw new ArgumentOutOfRangeException(GetArgumentName(argument));
	}

	internal static void ThrowArgumentOutOfRangeException(ExceptionArgument argument, ExceptionResource resource)
	{
		throw new ArgumentOutOfRangeException(GetArgumentName(argument), SR.GetString(GetResourceName(resource)));
	}

	internal static void ThrowInvalidOperationException(ExceptionResource resource)
	{
		throw new InvalidOperationException(SR.GetString(GetResourceName(resource)));
	}

	internal static void ThrowSerializationException(ExceptionResource resource)
	{
		throw new SerializationException(SR.GetString(GetResourceName(resource)));
	}

	internal static void ThrowNotSupportedException(ExceptionResource resource)
	{
		throw new NotSupportedException(SR.GetString(GetResourceName(resource)));
	}

	internal static void IfNullAndNullsAreIllegalThenThrow<T>(object value, ExceptionArgument argName)
	{
		if (value == null && default(T) != null)
		{
			ThrowArgumentNullException(argName);
		}
	}

	internal static string GetArgumentName(ExceptionArgument argument)
	{
		string text = null;
		return argument switch
		{
			ExceptionArgument.array => "array", 
			ExceptionArgument.arrayIndex => "arrayIndex", 
			ExceptionArgument.capacity => "capacity", 
			ExceptionArgument.collection => "collection", 
			ExceptionArgument.converter => "converter", 
			ExceptionArgument.count => "count", 
			ExceptionArgument.dictionary => "dictionary", 
			ExceptionArgument.index => "index", 
			ExceptionArgument.info => "info", 
			ExceptionArgument.key => "key", 
			ExceptionArgument.match => "match", 
			ExceptionArgument.obj => "obj", 
			ExceptionArgument.queue => "queue", 
			ExceptionArgument.stack => "stack", 
			ExceptionArgument.startIndex => "startIndex", 
			ExceptionArgument.value => "value", 
			ExceptionArgument.item => "item", 
			_ => string.Empty, 
		};
	}

	internal static string GetResourceName(ExceptionResource resource)
	{
		string text = null;
		return resource switch
		{
			ExceptionResource.Argument_ImplementIComparable => "Argument_ImplementIComparable", 
			ExceptionResource.Argument_AddingDuplicate => "Argument_AddingDuplicate", 
			ExceptionResource.ArgumentOutOfRange_Index => "ArgumentOutOfRange_Index", 
			ExceptionResource.ArgumentOutOfRange_NeedNonNegNum => "ArgumentOutOfRange_NeedNonNegNum", 
			ExceptionResource.ArgumentOutOfRange_NeedNonNegNumRequired => "ArgumentOutOfRange_NeedNonNegNumRequired", 
			ExceptionResource.ArgumentOutOfRange_SmallCapacity => "ArgumentOutOfRange_SmallCapacity", 
			ExceptionResource.Arg_ArrayPlusOffTooSmall => "Arg_ArrayPlusOffTooSmall", 
			ExceptionResource.Arg_RankMultiDimNotSupported => "Arg_MultiRank", 
			ExceptionResource.Arg_NonZeroLowerBound => "Arg_NonZeroLowerBound", 
			ExceptionResource.Argument_InvalidArrayType => "Invalid_Array_Type", 
			ExceptionResource.Argument_InvalidOffLen => "Argument_InvalidOffLen", 
			ExceptionResource.InvalidOperation_CannotRemoveFromStackOrQueue => "InvalidOperation_CannotRemoveFromStackOrQueue", 
			ExceptionResource.InvalidOperation_EmptyCollection => "InvalidOperation_EmptyCollection", 
			ExceptionResource.InvalidOperation_EmptyQueue => "InvalidOperation_EmptyQueue", 
			ExceptionResource.InvalidOperation_EnumOpCantHappen => "InvalidOperation_EnumOpCantHappen", 
			ExceptionResource.InvalidOperation_EnumFailedVersion => "InvalidOperation_EnumFailedVersion", 
			ExceptionResource.InvalidOperation_EmptyStack => "InvalidOperation_EmptyStack", 
			ExceptionResource.InvalidOperation_EnumNotStarted => "InvalidOperation_EnumNotStarted", 
			ExceptionResource.InvalidOperation_EnumEnded => "InvalidOperation_EnumEnded", 
			ExceptionResource.NotSupported_KeyCollectionSet => "NotSupported_KeyCollectionSet", 
			ExceptionResource.NotSupported_SortedListNestedWrite => "NotSupported_SortedListNestedWrite", 
			ExceptionResource.Serialization_InvalidOnDeser => "Serialization_InvalidOnDeser", 
			ExceptionResource.Serialization_MissingValues => "Serialization_MissingValues", 
			ExceptionResource.Serialization_MismatchedCount => "Serialization_MismatchedCount", 
			ExceptionResource.NotSupported_ValueCollectionSet => "NotSupported_ValueCollectionSet", 
			_ => string.Empty, 
		};
	}
}
