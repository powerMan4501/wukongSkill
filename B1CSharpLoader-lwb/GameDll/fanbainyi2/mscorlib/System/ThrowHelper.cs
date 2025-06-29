using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Security;

namespace System;

internal static class ThrowHelper
{
	internal static void ThrowArgumentOutOfRangeException()
	{
		ThrowArgumentOutOfRangeException(ExceptionArgument.index, ExceptionResource.ArgumentOutOfRange_Index);
	}

	internal static void ThrowWrongKeyTypeArgumentException(object key, Type targetType)
	{
		throw new ArgumentException(Environment.GetResourceString("Arg_WrongType", key, targetType), "key");
	}

	internal static void ThrowWrongValueTypeArgumentException(object value, Type targetType)
	{
		throw new ArgumentException(Environment.GetResourceString("Arg_WrongType", value, targetType), "value");
	}

	internal static void ThrowKeyNotFoundException()
	{
		throw new KeyNotFoundException();
	}

	internal static void ThrowArgumentException(ExceptionResource resource)
	{
		throw new ArgumentException(Environment.GetResourceString(GetResourceName(resource)));
	}

	internal static void ThrowArgumentException(ExceptionResource resource, ExceptionArgument argument)
	{
		throw new ArgumentException(Environment.GetResourceString(GetResourceName(resource)), GetArgumentName(argument));
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
		if (CompatibilitySwitches.IsAppEarlierThanWindowsPhone8)
		{
			throw new ArgumentOutOfRangeException(GetArgumentName(argument), string.Empty);
		}
		throw new ArgumentOutOfRangeException(GetArgumentName(argument), Environment.GetResourceString(GetResourceName(resource)));
	}

	internal static void ThrowInvalidOperationException(ExceptionResource resource)
	{
		throw new InvalidOperationException(Environment.GetResourceString(GetResourceName(resource)));
	}

	internal static void ThrowSerializationException(ExceptionResource resource)
	{
		throw new SerializationException(Environment.GetResourceString(GetResourceName(resource)));
	}

	internal static void ThrowSecurityException(ExceptionResource resource)
	{
		throw new SecurityException(Environment.GetResourceString(GetResourceName(resource)));
	}

	internal static void ThrowNotSupportedException(ExceptionResource resource)
	{
		throw new NotSupportedException(Environment.GetResourceString(GetResourceName(resource)));
	}

	internal static void ThrowUnauthorizedAccessException(ExceptionResource resource)
	{
		throw new UnauthorizedAccessException(Environment.GetResourceString(GetResourceName(resource)));
	}

	internal static void ThrowObjectDisposedException(string objectName, ExceptionResource resource)
	{
		throw new ObjectDisposedException(objectName, Environment.GetResourceString(GetResourceName(resource)));
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
			ExceptionArgument.list => "list", 
			ExceptionArgument.converter => "converter", 
			ExceptionArgument.count => "count", 
			ExceptionArgument.dictionary => "dictionary", 
			ExceptionArgument.dictionaryCreationThreshold => "dictionaryCreationThreshold", 
			ExceptionArgument.index => "index", 
			ExceptionArgument.info => "info", 
			ExceptionArgument.key => "key", 
			ExceptionArgument.match => "match", 
			ExceptionArgument.obj => "obj", 
			ExceptionArgument.queue => "queue", 
			ExceptionArgument.stack => "stack", 
			ExceptionArgument.startIndex => "startIndex", 
			ExceptionArgument.value => "value", 
			ExceptionArgument.name => "name", 
			ExceptionArgument.mode => "mode", 
			ExceptionArgument.item => "item", 
			ExceptionArgument.options => "options", 
			ExceptionArgument.view => "view", 
			ExceptionArgument.sourceBytesToCopy => "sourceBytesToCopy", 
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
			ExceptionResource.ArgumentOutOfRange_BiggerThanCollection => "ArgumentOutOfRange_BiggerThanCollection", 
			ExceptionResource.ArgumentOutOfRange_Count => "ArgumentOutOfRange_Count", 
			ExceptionResource.ArgumentOutOfRange_Index => "ArgumentOutOfRange_Index", 
			ExceptionResource.ArgumentOutOfRange_InvalidThreshold => "ArgumentOutOfRange_InvalidThreshold", 
			ExceptionResource.ArgumentOutOfRange_ListInsert => "ArgumentOutOfRange_ListInsert", 
			ExceptionResource.ArgumentOutOfRange_NeedNonNegNum => "ArgumentOutOfRange_NeedNonNegNum", 
			ExceptionResource.ArgumentOutOfRange_SmallCapacity => "ArgumentOutOfRange_SmallCapacity", 
			ExceptionResource.Arg_ArrayPlusOffTooSmall => "Arg_ArrayPlusOffTooSmall", 
			ExceptionResource.Arg_RankMultiDimNotSupported => "Arg_RankMultiDimNotSupported", 
			ExceptionResource.Arg_NonZeroLowerBound => "Arg_NonZeroLowerBound", 
			ExceptionResource.Argument_InvalidArrayType => "Argument_InvalidArrayType", 
			ExceptionResource.Argument_InvalidOffLen => "Argument_InvalidOffLen", 
			ExceptionResource.Argument_ItemNotExist => "Argument_ItemNotExist", 
			ExceptionResource.InvalidOperation_CannotRemoveFromStackOrQueue => "InvalidOperation_CannotRemoveFromStackOrQueue", 
			ExceptionResource.InvalidOperation_EmptyQueue => "InvalidOperation_EmptyQueue", 
			ExceptionResource.InvalidOperation_EnumOpCantHappen => "InvalidOperation_EnumOpCantHappen", 
			ExceptionResource.InvalidOperation_EnumFailedVersion => "InvalidOperation_EnumFailedVersion", 
			ExceptionResource.InvalidOperation_EmptyStack => "InvalidOperation_EmptyStack", 
			ExceptionResource.InvalidOperation_EnumNotStarted => "InvalidOperation_EnumNotStarted", 
			ExceptionResource.InvalidOperation_EnumEnded => "InvalidOperation_EnumEnded", 
			ExceptionResource.NotSupported_KeyCollectionSet => "NotSupported_KeyCollectionSet", 
			ExceptionResource.NotSupported_ReadOnlyCollection => "NotSupported_ReadOnlyCollection", 
			ExceptionResource.NotSupported_ValueCollectionSet => "NotSupported_ValueCollectionSet", 
			ExceptionResource.NotSupported_SortedListNestedWrite => "NotSupported_SortedListNestedWrite", 
			ExceptionResource.Serialization_InvalidOnDeser => "Serialization_InvalidOnDeser", 
			ExceptionResource.Serialization_MissingKeys => "Serialization_MissingKeys", 
			ExceptionResource.Serialization_NullKey => "Serialization_NullKey", 
			ExceptionResource.Argument_InvalidType => "Argument_InvalidType", 
			ExceptionResource.Argument_InvalidArgumentForComparison => "Argument_InvalidArgumentForComparison", 
			ExceptionResource.InvalidOperation_NoValue => "InvalidOperation_NoValue", 
			ExceptionResource.InvalidOperation_RegRemoveSubKey => "InvalidOperation_RegRemoveSubKey", 
			ExceptionResource.Arg_RegSubKeyAbsent => "Arg_RegSubKeyAbsent", 
			ExceptionResource.Arg_RegSubKeyValueAbsent => "Arg_RegSubKeyValueAbsent", 
			ExceptionResource.Arg_RegKeyDelHive => "Arg_RegKeyDelHive", 
			ExceptionResource.Security_RegistryPermission => "Security_RegistryPermission", 
			ExceptionResource.Arg_RegSetStrArrNull => "Arg_RegSetStrArrNull", 
			ExceptionResource.Arg_RegSetMismatchedKind => "Arg_RegSetMismatchedKind", 
			ExceptionResource.UnauthorizedAccess_RegistryNoWrite => "UnauthorizedAccess_RegistryNoWrite", 
			ExceptionResource.ObjectDisposed_RegKeyClosed => "ObjectDisposed_RegKeyClosed", 
			ExceptionResource.Arg_RegKeyStrLenBug => "Arg_RegKeyStrLenBug", 
			ExceptionResource.Argument_InvalidRegistryKeyPermissionCheck => "Argument_InvalidRegistryKeyPermissionCheck", 
			ExceptionResource.NotSupported_InComparableType => "NotSupported_InComparableType", 
			ExceptionResource.Argument_InvalidRegistryOptionsCheck => "Argument_InvalidRegistryOptionsCheck", 
			ExceptionResource.Argument_InvalidRegistryViewCheck => "Argument_InvalidRegistryViewCheck", 
			_ => string.Empty, 
		};
	}
}
