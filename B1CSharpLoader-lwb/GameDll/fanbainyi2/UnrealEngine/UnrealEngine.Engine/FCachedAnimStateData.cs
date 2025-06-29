using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.CachedAnimStateData", "Engine", UnrealModuleType.Engine)]
public struct FCachedAnimStateData
{
	private static bool StateMachineName_IsValid;

	private static int StateMachineName_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.CachedAnimStateData:StateMachineName")]
	public FName StateMachineName;

	private static bool StateName_IsValid;

	private static int StateName_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.CachedAnimStateData:StateName")]
	public FName StateName;

	private static bool FCachedAnimStateData_IsValid;

	private static int FCachedAnimStateData_StructSize;

	public FCachedAnimStateData Copy()
	{
		return this;
	}

	public static FCachedAnimStateData FromNative(IntPtr nativeBuffer)
	{
		return new FCachedAnimStateData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCachedAnimStateData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCachedAnimStateData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCachedAnimStateData(nativeBuffer + arrayIndex * FCachedAnimStateData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCachedAnimStateData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FCachedAnimStateData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FCachedAnimStateData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.CachedAnimStateData");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, StateMachineName_Offset), StateMachineName);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, StateName_Offset), StateName);
	}

	public FCachedAnimStateData(IntPtr nativeStruct)
	{
		if (!FCachedAnimStateData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.CachedAnimStateData");
			StateMachineName = default(FName);
			StateName = default(FName);
		}
		else
		{
			StateMachineName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, StateMachineName_Offset));
			StateName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, StateName_Offset));
		}
	}

	static FCachedAnimStateData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FCachedAnimStateData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCachedAnimStateData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.CachedAnimStateData");
		FCachedAnimStateData_StructSize = NativeReflection.GetStructSize(intPtr);
		StateMachineName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StateMachineName");
		StateMachineName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StateMachineName", Classes.FNameProperty);
		StateName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StateName");
		StateName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StateName", Classes.FNameProperty);
		FCachedAnimStateData_IsValid = intPtr != IntPtr.Zero && StateMachineName_IsValid && StateName_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.CachedAnimStateData", FCachedAnimStateData_IsValid);
	}
}
