using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigLocalAndGlobalTransform", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigLocalAndGlobalTransform
{
	private static bool Local_IsValid;

	private static int Local_Offset;

	[UProperty(Flags = (PropFlags)4503668346847253uL)]
	[UMetaPath("/Script/ControlRig.RigLocalAndGlobalTransform:Local")]
	public FRigComputedTransform Local;

	private static bool Global_IsValid;

	private static int Global_Offset;

	[UProperty(Flags = (PropFlags)4503668346847253uL)]
	[UMetaPath("/Script/ControlRig.RigLocalAndGlobalTransform:Global")]
	public FRigComputedTransform Global;

	private static bool FRigLocalAndGlobalTransform_IsValid;

	private static int FRigLocalAndGlobalTransform_StructSize;

	public FRigLocalAndGlobalTransform Copy()
	{
		return this;
	}

	public static FRigLocalAndGlobalTransform FromNative(IntPtr nativeBuffer)
	{
		return new FRigLocalAndGlobalTransform(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigLocalAndGlobalTransform value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigLocalAndGlobalTransform FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigLocalAndGlobalTransform(nativeBuffer + arrayIndex * FRigLocalAndGlobalTransform_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigLocalAndGlobalTransform value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigLocalAndGlobalTransform_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigLocalAndGlobalTransform_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigLocalAndGlobalTransform");
			return;
		}
		FRigComputedTransform.ToNative(IntPtr.Add(nativeStruct, Local_Offset), Local);
		FRigComputedTransform.ToNative(IntPtr.Add(nativeStruct, Global_Offset), Global);
	}

	public FRigLocalAndGlobalTransform(IntPtr nativeStruct)
	{
		if (!FRigLocalAndGlobalTransform_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigLocalAndGlobalTransform");
			Local = default(FRigComputedTransform);
			Global = default(FRigComputedTransform);
		}
		else
		{
			Local = FRigComputedTransform.FromNative(IntPtr.Add(nativeStruct, Local_Offset));
			Global = FRigComputedTransform.FromNative(IntPtr.Add(nativeStruct, Global_Offset));
		}
	}

	static FRigLocalAndGlobalTransform()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigLocalAndGlobalTransform)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigLocalAndGlobalTransform));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigLocalAndGlobalTransform");
		FRigLocalAndGlobalTransform_StructSize = NativeReflection.GetStructSize(intPtr);
		Local_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Local");
		Local_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Local", Classes.FStructProperty);
		Global_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Global");
		Global_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Global", Classes.FStructProperty);
		FRigLocalAndGlobalTransform_IsValid = intPtr != IntPtr.Zero && Local_IsValid && Global_IsValid;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigLocalAndGlobalTransform", FRigLocalAndGlobalTransform_IsValid);
	}
}
