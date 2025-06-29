using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.SpiderSpawnPointData")]
public struct SpiderSpawnPointData
{
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.SpiderSpawnPointData:Tag")]
	public FName Tag;

	[UProperty]
	[EditAnywhere]
	[Tooltip("配置时按照触发顺序排列")]
	[USharpPath("/Script/b1-Managed.SpiderSpawnPointData:SpiderSpawnPoints")]
	public List<ATargetPoint> SpiderSpawnPoints;

	private static int SpiderSpawnPointData_StructSize;

	private static int SpiderSpawnPointData_IsValid;

	private static bool Tag_IsValid;

	private static int Tag_Offset;

	private static bool SpiderSpawnPoints_IsValid;

	private static int SpiderSpawnPoints_Offset;

	private static FFieldAddress SpiderSpawnPoints_PropertyAddress;

	public SpiderSpawnPointData Copy()
	{
		SpiderSpawnPointData result = this;
		if (SpiderSpawnPoints != null)
		{
			result.SpiderSpawnPoints = new List<ATargetPoint>(SpiderSpawnPoints);
		}
		return result;
	}

	public static SpiderSpawnPointData FromNative(IntPtr nativeBuffer)
	{
		return new SpiderSpawnPointData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, SpiderSpawnPointData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static SpiderSpawnPointData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new SpiderSpawnPointData(IntPtr.Add(nativeBuffer, arrayIndex * SpiderSpawnPointData_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, SpiderSpawnPointData value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * SpiderSpawnPointData_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (SpiderSpawnPointData_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.SpiderSpawnPointData");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, Tag_Offset), Tag);
		new TArrayCopyMarshaler<ATargetPoint>(1, SpiderSpawnPoints_PropertyAddress, CachedMarshalingDelegates<ATargetPoint, UObjectMarshaler<ATargetPoint>>.FromNative, CachedMarshalingDelegates<ATargetPoint, UObjectMarshaler<ATargetPoint>>.ToNative).ToNative(IntPtr.Add(nativeStruct, SpiderSpawnPoints_Offset), SpiderSpawnPoints);
	}

	public SpiderSpawnPointData(IntPtr nativeStruct)
	{
		if (SpiderSpawnPointData_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.SpiderSpawnPointData");
			Tag = default(FName);
			SpiderSpawnPoints = null;
		}
		else
		{
			Tag = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, Tag_Offset));
			SpiderSpawnPoints = new TArrayCopyMarshaler<ATargetPoint>(1, SpiderSpawnPoints_PropertyAddress, CachedMarshalingDelegates<ATargetPoint, UObjectMarshaler<ATargetPoint>>.FromNative, CachedMarshalingDelegates<ATargetPoint, UObjectMarshaler<ATargetPoint>>.ToNative).FromNative(IntPtr.Add(nativeStruct, SpiderSpawnPoints_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.SpiderSpawnPointData");
		SpiderSpawnPointData_StructSize = NativeReflection.GetStructSize(intPtr);
		Tag_Offset = NativeReflection.GetPropertyOffset(intPtr, "Tag");
		Tag_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Tag", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref SpiderSpawnPoints_PropertyAddress, intPtr, "SpiderSpawnPoints");
		SpiderSpawnPoints_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpiderSpawnPoints");
		SpiderSpawnPoints_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpiderSpawnPoints", Classes.FArrayProperty);
		SpiderSpawnPointData_IsValid = ((intPtr != IntPtr.Zero && Tag_IsValid && SpiderSpawnPoints_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.SpiderSpawnPointData", (byte)SpiderSpawnPointData_IsValid != 0);
	}

	static SpiderSpawnPointData()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(SpiderSpawnPointData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(SpiderSpawnPointData));
	}
}
