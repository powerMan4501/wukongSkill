using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.CachedAnimAssetPlayerData", "Engine", UnrealModuleType.Engine)]
public struct FCachedAnimAssetPlayerData
{
	private static bool StateMachineName_IsValid;

	private static int StateMachineName_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.CachedAnimAssetPlayerData:StateMachineName")]
	public FName StateMachineName;

	private static bool StateName_IsValid;

	private static int StateName_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.CachedAnimAssetPlayerData:StateName")]
	public FName StateName;

	private static bool FCachedAnimAssetPlayerData_IsValid;

	private static int FCachedAnimAssetPlayerData_StructSize;

	public FCachedAnimAssetPlayerData Copy()
	{
		return this;
	}

	public static FCachedAnimAssetPlayerData FromNative(IntPtr nativeBuffer)
	{
		return new FCachedAnimAssetPlayerData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCachedAnimAssetPlayerData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCachedAnimAssetPlayerData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCachedAnimAssetPlayerData(nativeBuffer + arrayIndex * FCachedAnimAssetPlayerData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCachedAnimAssetPlayerData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FCachedAnimAssetPlayerData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FCachedAnimAssetPlayerData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.CachedAnimAssetPlayerData");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, StateMachineName_Offset), StateMachineName);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, StateName_Offset), StateName);
	}

	public FCachedAnimAssetPlayerData(IntPtr nativeStruct)
	{
		if (!FCachedAnimAssetPlayerData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.CachedAnimAssetPlayerData");
			StateMachineName = default(FName);
			StateName = default(FName);
		}
		else
		{
			StateMachineName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, StateMachineName_Offset));
			StateName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, StateName_Offset));
		}
	}

	static FCachedAnimAssetPlayerData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FCachedAnimAssetPlayerData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCachedAnimAssetPlayerData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.CachedAnimAssetPlayerData");
		FCachedAnimAssetPlayerData_StructSize = NativeReflection.GetStructSize(intPtr);
		StateMachineName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StateMachineName");
		StateMachineName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StateMachineName", Classes.FNameProperty);
		StateName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StateName");
		StateName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StateName", Classes.FNameProperty);
		FCachedAnimAssetPlayerData_IsValid = intPtr != IntPtr.Zero && StateMachineName_IsValid && StateName_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.CachedAnimAssetPlayerData", FCachedAnimAssetPlayerData_IsValid);
	}
}
