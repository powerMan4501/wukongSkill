using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.RelationLevelInfo")]
public struct FRelationLevelInfo
{
	[VisibleAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.RelationLevelInfo:LevelName")]
	public string LevelName;

	[VisibleAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.RelationLevelInfo:RelationInfo")]
	public string RelationInfo;

	private static int RelationLevelInfo_StructSize;

	private static int RelationLevelInfo_IsValid;

	private static bool LevelName_IsValid;

	private static int LevelName_Offset;

	private static bool RelationInfo_IsValid;

	private static int RelationInfo_Offset;

	public FRelationLevelInfo Copy()
	{
		return this;
	}

	public static FRelationLevelInfo FromNative(IntPtr nativeBuffer)
	{
		return new FRelationLevelInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRelationLevelInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRelationLevelInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRelationLevelInfo(IntPtr.Add(nativeBuffer, arrayIndex * RelationLevelInfo_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRelationLevelInfo value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * RelationLevelInfo_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (RelationLevelInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.RelationLevelInfo");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, LevelName_Offset), LevelName);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, RelationInfo_Offset), RelationInfo);
	}

	public FRelationLevelInfo(IntPtr nativeStruct)
	{
		if (RelationLevelInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.RelationLevelInfo");
			LevelName = null;
			RelationInfo = null;
		}
		else
		{
			LevelName = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, LevelName_Offset));
			RelationInfo = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, RelationInfo_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.RelationLevelInfo");
		RelationLevelInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		LevelName_Offset = NativeReflection.GetPropertyOffset(intPtr, "LevelName");
		LevelName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LevelName", Classes.FStrProperty);
		RelationInfo_Offset = NativeReflection.GetPropertyOffset(intPtr, "RelationInfo");
		RelationInfo_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RelationInfo", Classes.FStrProperty);
		RelationLevelInfo_IsValid = ((intPtr != IntPtr.Zero && LevelName_IsValid && RelationInfo_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.RelationLevelInfo", (byte)RelationLevelInfo_IsValid != 0);
	}

	static FRelationLevelInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FRelationLevelInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRelationLevelInfo));
	}
}
