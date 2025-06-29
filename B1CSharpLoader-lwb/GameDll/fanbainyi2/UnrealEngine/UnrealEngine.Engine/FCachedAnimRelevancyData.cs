using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.CachedAnimRelevancyData", "Engine", UnrealModuleType.Engine)]
public struct FCachedAnimRelevancyData
{
	private static bool StateMachineName_IsValid;

	private static int StateMachineName_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.CachedAnimRelevancyData:StateMachineName")]
	public FName StateMachineName;

	private static bool StateName_IsValid;

	private static int StateName_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.CachedAnimRelevancyData:StateName")]
	public FName StateName;

	private static bool FCachedAnimRelevancyData_IsValid;

	private static int FCachedAnimRelevancyData_StructSize;

	public FCachedAnimRelevancyData Copy()
	{
		return this;
	}

	public static FCachedAnimRelevancyData FromNative(IntPtr nativeBuffer)
	{
		return new FCachedAnimRelevancyData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCachedAnimRelevancyData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCachedAnimRelevancyData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCachedAnimRelevancyData(nativeBuffer + arrayIndex * FCachedAnimRelevancyData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCachedAnimRelevancyData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FCachedAnimRelevancyData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FCachedAnimRelevancyData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.CachedAnimRelevancyData");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, StateMachineName_Offset), StateMachineName);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, StateName_Offset), StateName);
	}

	public FCachedAnimRelevancyData(IntPtr nativeStruct)
	{
		if (!FCachedAnimRelevancyData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.CachedAnimRelevancyData");
			StateMachineName = default(FName);
			StateName = default(FName);
		}
		else
		{
			StateMachineName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, StateMachineName_Offset));
			StateName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, StateName_Offset));
		}
	}

	static FCachedAnimRelevancyData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FCachedAnimRelevancyData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCachedAnimRelevancyData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.CachedAnimRelevancyData");
		FCachedAnimRelevancyData_StructSize = NativeReflection.GetStructSize(intPtr);
		StateMachineName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StateMachineName");
		StateMachineName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StateMachineName", Classes.FNameProperty);
		StateName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StateName");
		StateName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StateName", Classes.FNameProperty);
		FCachedAnimRelevancyData_IsValid = intPtr != IntPtr.Zero && StateMachineName_IsValid && StateName_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.CachedAnimRelevancyData", FCachedAnimRelevancyData_IsValid);
	}
}
