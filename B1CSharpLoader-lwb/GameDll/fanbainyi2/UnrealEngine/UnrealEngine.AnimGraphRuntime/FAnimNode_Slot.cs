using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraphRuntime;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/AnimGraphRuntime.AnimNode_Slot", "AnimGraphRuntime", UnrealModuleType.Engine)]
public struct FAnimNode_Slot
{
	private static bool Source_IsValid;

	private static int Source_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_Slot:Source")]
	public FPoseLink Source;

	private static bool SlotName_IsValid;

	private static int SlotName_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_Slot:SlotName")]
	public FName SlotName;

	private static bool AlwaysUpdateSourcePose_IsValid;

	private static FFieldAddress AlwaysUpdateSourcePose_PropertyAddress;

	private static int AlwaysUpdateSourcePose_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_Slot:bAlwaysUpdateSourcePose")]
	public bool AlwaysUpdateSourcePose;

	private static bool FAnimNode_Slot_IsValid;

	private static int FAnimNode_Slot_StructSize;

	public FAnimNode_Slot Copy()
	{
		return this;
	}

	public static FAnimNode_Slot FromNative(IntPtr nativeBuffer)
	{
		return new FAnimNode_Slot(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimNode_Slot value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimNode_Slot FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimNode_Slot(nativeBuffer + arrayIndex * FAnimNode_Slot_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimNode_Slot value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAnimNode_Slot_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAnimNode_Slot_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.AnimNode_Slot");
			return;
		}
		FPoseLink.ToNative(IntPtr.Add(nativeStruct, Source_Offset), Source);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, SlotName_Offset), SlotName);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, AlwaysUpdateSourcePose_Offset), 0, AlwaysUpdateSourcePose_PropertyAddress.Address, AlwaysUpdateSourcePose);
	}

	public FAnimNode_Slot(IntPtr nativeStruct)
	{
		if (!FAnimNode_Slot_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.AnimNode_Slot");
			Source = default(FPoseLink);
			SlotName = default(FName);
			AlwaysUpdateSourcePose = false;
		}
		else
		{
			Source = FPoseLink.FromNative(IntPtr.Add(nativeStruct, Source_Offset));
			SlotName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, SlotName_Offset));
			AlwaysUpdateSourcePose = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, AlwaysUpdateSourcePose_Offset), 0, AlwaysUpdateSourcePose_PropertyAddress.Address);
		}
	}

	static FAnimNode_Slot()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAnimNode_Slot)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimNode_Slot));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AnimGraphRuntime.AnimNode_Slot");
		FAnimNode_Slot_StructSize = NativeReflection.GetStructSize(intPtr);
		Source_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Source");
		Source_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Source", Classes.FStructProperty);
		SlotName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SlotName");
		SlotName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SlotName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AlwaysUpdateSourcePose_PropertyAddress, intPtr, "bAlwaysUpdateSourcePose");
		AlwaysUpdateSourcePose_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAlwaysUpdateSourcePose");
		AlwaysUpdateSourcePose_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAlwaysUpdateSourcePose", Classes.FBoolProperty);
		FAnimNode_Slot_IsValid = intPtr != IntPtr.Zero && Source_IsValid && SlotName_IsValid && AlwaysUpdateSourcePose_IsValid;
		NativeReflection.LogStructIsValid("/Script/AnimGraphRuntime.AnimNode_Slot", FAnimNode_Slot_IsValid);
	}
}
