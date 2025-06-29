using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraphRuntime;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/AnimGraphRuntime.AnimNode_PoseSnapshot", "AnimGraphRuntime", UnrealModuleType.Engine)]
public struct FAnimNode_PoseSnapshot
{
	private static bool SnapshotName_IsValid;

	private static int SnapshotName_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_PoseSnapshot:SnapshotName")]
	public FName SnapshotName;

	private static bool Snapshot_IsValid;

	private static int Snapshot_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_PoseSnapshot:Snapshot")]
	public FPoseSnapshot Snapshot;

	private static bool Mode_IsValid;

	private static FFieldAddress Mode_PropertyAddress;

	private static int Mode_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_PoseSnapshot:Mode")]
	public ESnapshotSourceMode Mode;

	private static bool FAnimNode_PoseSnapshot_IsValid;

	private static int FAnimNode_PoseSnapshot_StructSize;

	public FAnimNode_PoseSnapshot Copy()
	{
		return this;
	}

	public static FAnimNode_PoseSnapshot FromNative(IntPtr nativeBuffer)
	{
		return new FAnimNode_PoseSnapshot(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimNode_PoseSnapshot value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimNode_PoseSnapshot FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimNode_PoseSnapshot(nativeBuffer + arrayIndex * FAnimNode_PoseSnapshot_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimNode_PoseSnapshot value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAnimNode_PoseSnapshot_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAnimNode_PoseSnapshot_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.AnimNode_PoseSnapshot");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, SnapshotName_Offset), SnapshotName);
		FPoseSnapshot.ToNative(IntPtr.Add(nativeStruct, Snapshot_Offset), Snapshot);
		EnumMarshaler<ESnapshotSourceMode>.ToNative(IntPtr.Add(nativeStruct, Mode_Offset), 0, Mode_PropertyAddress.Address, Mode);
	}

	public FAnimNode_PoseSnapshot(IntPtr nativeStruct)
	{
		if (!FAnimNode_PoseSnapshot_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.AnimNode_PoseSnapshot");
			SnapshotName = default(FName);
			Snapshot = default(FPoseSnapshot);
			Mode = ESnapshotSourceMode.NamedSnapshot;
		}
		else
		{
			SnapshotName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, SnapshotName_Offset));
			Snapshot = FPoseSnapshot.FromNative(IntPtr.Add(nativeStruct, Snapshot_Offset));
			Mode = EnumMarshaler<ESnapshotSourceMode>.FromNative(IntPtr.Add(nativeStruct, Mode_Offset), 0, Mode_PropertyAddress.Address);
		}
	}

	static FAnimNode_PoseSnapshot()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAnimNode_PoseSnapshot)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimNode_PoseSnapshot));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AnimGraphRuntime.AnimNode_PoseSnapshot");
		FAnimNode_PoseSnapshot_StructSize = NativeReflection.GetStructSize(intPtr);
		SnapshotName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SnapshotName");
		SnapshotName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SnapshotName", Classes.FNameProperty);
		Snapshot_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Snapshot");
		Snapshot_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Snapshot", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Mode_PropertyAddress, intPtr, "Mode");
		Mode_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Mode");
		Mode_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Mode", Classes.FEnumProperty);
		FAnimNode_PoseSnapshot_IsValid = intPtr != IntPtr.Zero && SnapshotName_IsValid && Snapshot_IsValid && Mode_IsValid;
		NativeReflection.LogStructIsValid("/Script/AnimGraphRuntime.AnimNode_PoseSnapshot", FAnimNode_PoseSnapshot_IsValid);
	}
}
