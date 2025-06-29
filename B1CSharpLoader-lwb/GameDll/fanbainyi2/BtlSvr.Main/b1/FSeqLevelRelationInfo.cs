using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.SeqLevelRelationInfo")]
public struct FSeqLevelRelationInfo
{
	[UProperty]
	[VisibleAnywhere]
	[USharpPath("/Script/b1-Managed.SeqLevelRelationInfo:LevelName")]
	public string LevelName;

	[UProperty]
	[VisibleAnywhere]
	[USharpPath("/Script/b1-Managed.SeqLevelRelationInfo:RelationMovie")]
	public List<int> RelationMovie;

	private static int SeqLevelRelationInfo_StructSize;

	private static int SeqLevelRelationInfo_IsValid;

	private static bool LevelName_IsValid;

	private static int LevelName_Offset;

	private static bool RelationMovie_IsValid;

	private static int RelationMovie_Offset;

	private static FFieldAddress RelationMovie_PropertyAddress;

	public FSeqLevelRelationInfo Copy()
	{
		FSeqLevelRelationInfo result = this;
		if (RelationMovie != null)
		{
			result.RelationMovie = new List<int>(RelationMovie);
		}
		return result;
	}

	public static FSeqLevelRelationInfo FromNative(IntPtr nativeBuffer)
	{
		return new FSeqLevelRelationInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSeqLevelRelationInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSeqLevelRelationInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSeqLevelRelationInfo(IntPtr.Add(nativeBuffer, arrayIndex * SeqLevelRelationInfo_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSeqLevelRelationInfo value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * SeqLevelRelationInfo_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (SeqLevelRelationInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.SeqLevelRelationInfo");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, LevelName_Offset), LevelName);
		new TArrayCopyMarshaler<int>(1, RelationMovie_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(nativeStruct, RelationMovie_Offset), RelationMovie);
	}

	public FSeqLevelRelationInfo(IntPtr nativeStruct)
	{
		if (SeqLevelRelationInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.SeqLevelRelationInfo");
			LevelName = null;
			RelationMovie = null;
		}
		else
		{
			LevelName = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, LevelName_Offset));
			RelationMovie = new TArrayCopyMarshaler<int>(1, RelationMovie_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(nativeStruct, RelationMovie_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.SeqLevelRelationInfo");
		SeqLevelRelationInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		LevelName_Offset = NativeReflection.GetPropertyOffset(intPtr, "LevelName");
		LevelName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LevelName", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref RelationMovie_PropertyAddress, intPtr, "RelationMovie");
		RelationMovie_Offset = NativeReflection.GetPropertyOffset(intPtr, "RelationMovie");
		RelationMovie_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RelationMovie", Classes.FArrayProperty);
		SeqLevelRelationInfo_IsValid = ((intPtr != IntPtr.Zero && LevelName_IsValid && RelationMovie_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.SeqLevelRelationInfo", (byte)SeqLevelRelationInfo_IsValid != 0);
	}

	static FSeqLevelRelationInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FSeqLevelRelationInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSeqLevelRelationInfo));
	}
}
