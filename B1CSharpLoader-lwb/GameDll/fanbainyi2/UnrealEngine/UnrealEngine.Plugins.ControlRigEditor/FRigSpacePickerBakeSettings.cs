using System;
using UnrealEngine.Plugins.ControlRig;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRigEditor;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRigEditor.RigSpacePickerBakeSettings", "ControlRigEditor", UnrealModuleType.EnginePlugin)]
public struct FRigSpacePickerBakeSettings
{
	private static bool TargetSpace_IsValid;

	private static int TargetSpace_Offset;

	[UProperty(Flags = (PropFlags)6755468160532484uL)]
	[UMetaPath("/Script/ControlRigEditor.RigSpacePickerBakeSettings:TargetSpace")]
	public FRigElementKey TargetSpace;

	private static bool StartFrame_IsValid;

	private static int StartFrame_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/ControlRigEditor.RigSpacePickerBakeSettings:StartFrame")]
	public FFrameNumber StartFrame;

	private static bool EndFrame_IsValid;

	private static int EndFrame_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/ControlRigEditor.RigSpacePickerBakeSettings:EndFrame")]
	public FFrameNumber EndFrame;

	private static bool ReduceKeys_IsValid;

	private static FFieldAddress ReduceKeys_PropertyAddress;

	private static int ReduceKeys_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ControlRigEditor.RigSpacePickerBakeSettings:bReduceKeys")]
	public bool ReduceKeys;

	private static bool Tolerance_IsValid;

	private static int Tolerance_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ControlRigEditor.RigSpacePickerBakeSettings:Tolerance")]
	public float Tolerance;

	private static bool FRigSpacePickerBakeSettings_IsValid;

	private static int FRigSpacePickerBakeSettings_StructSize;

	public FRigSpacePickerBakeSettings Copy()
	{
		return this;
	}

	public static FRigSpacePickerBakeSettings FromNative(IntPtr nativeBuffer)
	{
		return new FRigSpacePickerBakeSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigSpacePickerBakeSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigSpacePickerBakeSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigSpacePickerBakeSettings(nativeBuffer + arrayIndex * FRigSpacePickerBakeSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigSpacePickerBakeSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigSpacePickerBakeSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigSpacePickerBakeSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRigEditor.RigSpacePickerBakeSettings");
			return;
		}
		FRigElementKey.ToNative(IntPtr.Add(nativeStruct, TargetSpace_Offset), TargetSpace);
		FFrameNumber.ToNative(IntPtr.Add(nativeStruct, StartFrame_Offset), StartFrame);
		FFrameNumber.ToNative(IntPtr.Add(nativeStruct, EndFrame_Offset), EndFrame);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ReduceKeys_Offset), 0, ReduceKeys_PropertyAddress.Address, ReduceKeys);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Tolerance_Offset), Tolerance);
	}

	public FRigSpacePickerBakeSettings(IntPtr nativeStruct)
	{
		if (!FRigSpacePickerBakeSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRigEditor.RigSpacePickerBakeSettings");
			TargetSpace = default(FRigElementKey);
			StartFrame = default(FFrameNumber);
			EndFrame = default(FFrameNumber);
			ReduceKeys = false;
			Tolerance = 0f;
		}
		else
		{
			TargetSpace = FRigElementKey.FromNative(IntPtr.Add(nativeStruct, TargetSpace_Offset));
			StartFrame = FFrameNumber.FromNative(IntPtr.Add(nativeStruct, StartFrame_Offset));
			EndFrame = FFrameNumber.FromNative(IntPtr.Add(nativeStruct, EndFrame_Offset));
			ReduceKeys = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ReduceKeys_Offset), 0, ReduceKeys_PropertyAddress.Address);
			Tolerance = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Tolerance_Offset));
		}
	}

	static FRigSpacePickerBakeSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigSpacePickerBakeSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigSpacePickerBakeSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRigEditor.RigSpacePickerBakeSettings");
		FRigSpacePickerBakeSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		TargetSpace_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TargetSpace");
		TargetSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TargetSpace", Classes.FStructProperty);
		StartFrame_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StartFrame");
		StartFrame_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StartFrame", Classes.FStructProperty);
		EndFrame_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "EndFrame");
		EndFrame_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "EndFrame", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ReduceKeys_PropertyAddress, intPtr, "bReduceKeys");
		ReduceKeys_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bReduceKeys");
		ReduceKeys_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bReduceKeys", Classes.FBoolProperty);
		Tolerance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Tolerance");
		Tolerance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Tolerance", Classes.FFloatProperty);
		FRigSpacePickerBakeSettings_IsValid = intPtr != IntPtr.Zero && TargetSpace_IsValid && StartFrame_IsValid && EndFrame_IsValid && ReduceKeys_IsValid && Tolerance_IsValid;
		NativeReflection.LogStructIsValid("/Script/ControlRigEditor.RigSpacePickerBakeSettings", FRigSpacePickerBakeSettings_IsValid);
	}
}
