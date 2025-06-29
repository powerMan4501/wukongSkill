using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.CachedAnimTransitionData", "Engine", UnrealModuleType.Engine)]
public struct FCachedAnimTransitionData
{
	private static bool StateMachineName_IsValid;

	private static int StateMachineName_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.CachedAnimTransitionData:StateMachineName")]
	public FName StateMachineName;

	private static bool FromStateName_IsValid;

	private static int FromStateName_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.CachedAnimTransitionData:FromStateName")]
	public FName FromStateName;

	private static bool ToStateName_IsValid;

	private static int ToStateName_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.CachedAnimTransitionData:ToStateName")]
	public FName ToStateName;

	private static bool FCachedAnimTransitionData_IsValid;

	private static int FCachedAnimTransitionData_StructSize;

	public FCachedAnimTransitionData Copy()
	{
		return this;
	}

	public static FCachedAnimTransitionData FromNative(IntPtr nativeBuffer)
	{
		return new FCachedAnimTransitionData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCachedAnimTransitionData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCachedAnimTransitionData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCachedAnimTransitionData(nativeBuffer + arrayIndex * FCachedAnimTransitionData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCachedAnimTransitionData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FCachedAnimTransitionData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FCachedAnimTransitionData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.CachedAnimTransitionData");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, StateMachineName_Offset), StateMachineName);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, FromStateName_Offset), FromStateName);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, ToStateName_Offset), ToStateName);
	}

	public FCachedAnimTransitionData(IntPtr nativeStruct)
	{
		if (!FCachedAnimTransitionData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.CachedAnimTransitionData");
			StateMachineName = default(FName);
			FromStateName = default(FName);
			ToStateName = default(FName);
		}
		else
		{
			StateMachineName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, StateMachineName_Offset));
			FromStateName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, FromStateName_Offset));
			ToStateName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, ToStateName_Offset));
		}
	}

	static FCachedAnimTransitionData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FCachedAnimTransitionData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCachedAnimTransitionData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.CachedAnimTransitionData");
		FCachedAnimTransitionData_StructSize = NativeReflection.GetStructSize(intPtr);
		StateMachineName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StateMachineName");
		StateMachineName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StateMachineName", Classes.FNameProperty);
		FromStateName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FromStateName");
		FromStateName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FromStateName", Classes.FNameProperty);
		ToStateName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ToStateName");
		ToStateName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ToStateName", Classes.FNameProperty);
		FCachedAnimTransitionData_IsValid = intPtr != IntPtr.Zero && StateMachineName_IsValid && FromStateName_IsValid && ToStateName_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.CachedAnimTransitionData", FCachedAnimTransitionData_IsValid);
	}
}
