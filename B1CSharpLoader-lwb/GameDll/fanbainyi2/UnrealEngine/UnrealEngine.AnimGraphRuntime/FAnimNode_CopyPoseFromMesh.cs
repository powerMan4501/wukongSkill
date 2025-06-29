using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraphRuntime;

[UStruct(Flags = 4613)]
[BlueprintType]
[UMetaPath("/Script/AnimGraphRuntime.AnimNode_CopyPoseFromMesh", "AnimGraphRuntime", UnrealModuleType.Engine)]
public struct FAnimNode_CopyPoseFromMesh
{
	private static bool SourceMeshComponent_IsValid;

	private static int SourceMeshComponent_Offset;

	[UProperty(Flags = (PropFlags)7881369141649932uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_CopyPoseFromMesh:SourceMeshComponent")]
	public TWeakObject<USkeletalMeshComponent> SourceMeshComponent;

	private static bool UseAttachedParent_IsValid;

	private static FFieldAddress UseAttachedParent_PropertyAddress;

	private static int UseAttachedParent_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_CopyPoseFromMesh:bUseAttachedParent")]
	public bool UseAttachedParent;

	private static bool CopyCurves_IsValid;

	private static FFieldAddress CopyCurves_PropertyAddress;

	private static int CopyCurves_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_CopyPoseFromMesh:bCopyCurves")]
	public bool CopyCurves;

	private static bool CopyCustomAttributes_IsValid;

	private static FFieldAddress CopyCustomAttributes_PropertyAddress;

	private static int CopyCustomAttributes_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_CopyPoseFromMesh:bCopyCustomAttributes")]
	public bool CopyCustomAttributes;

	private static bool UseMeshPose_IsValid;

	private static FFieldAddress UseMeshPose_PropertyAddress;

	private static int UseMeshPose_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_CopyPoseFromMesh:bUseMeshPose")]
	public bool UseMeshPose;

	private static bool RootBoneToCopy_IsValid;

	private static int RootBoneToCopy_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_CopyPoseFromMesh:RootBoneToCopy")]
	public FName RootBoneToCopy;

	private static bool FAnimNode_CopyPoseFromMesh_IsValid;

	private static int FAnimNode_CopyPoseFromMesh_StructSize;

	public FAnimNode_CopyPoseFromMesh Copy()
	{
		return this;
	}

	public static FAnimNode_CopyPoseFromMesh FromNative(IntPtr nativeBuffer)
	{
		return new FAnimNode_CopyPoseFromMesh(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimNode_CopyPoseFromMesh value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimNode_CopyPoseFromMesh FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimNode_CopyPoseFromMesh(nativeBuffer + arrayIndex * FAnimNode_CopyPoseFromMesh_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimNode_CopyPoseFromMesh value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAnimNode_CopyPoseFromMesh_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAnimNode_CopyPoseFromMesh_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.AnimNode_CopyPoseFromMesh");
			return;
		}
		TWeakObjectMarshaler<USkeletalMeshComponent>.ToNative(IntPtr.Add(nativeStruct, SourceMeshComponent_Offset), SourceMeshComponent);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, UseAttachedParent_Offset), 0, UseAttachedParent_PropertyAddress.Address, UseAttachedParent);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, CopyCurves_Offset), 0, CopyCurves_PropertyAddress.Address, CopyCurves);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, CopyCustomAttributes_Offset), 0, CopyCustomAttributes_PropertyAddress.Address, CopyCustomAttributes);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, UseMeshPose_Offset), 0, UseMeshPose_PropertyAddress.Address, UseMeshPose);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, RootBoneToCopy_Offset), RootBoneToCopy);
	}

	public FAnimNode_CopyPoseFromMesh(IntPtr nativeStruct)
	{
		if (!FAnimNode_CopyPoseFromMesh_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.AnimNode_CopyPoseFromMesh");
			SourceMeshComponent = default(TWeakObject<USkeletalMeshComponent>);
			UseAttachedParent = false;
			CopyCurves = false;
			CopyCustomAttributes = false;
			UseMeshPose = false;
			RootBoneToCopy = default(FName);
		}
		else
		{
			SourceMeshComponent = TWeakObjectMarshaler<USkeletalMeshComponent>.FromNative(IntPtr.Add(nativeStruct, SourceMeshComponent_Offset));
			UseAttachedParent = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, UseAttachedParent_Offset), 0, UseAttachedParent_PropertyAddress.Address);
			CopyCurves = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, CopyCurves_Offset), 0, CopyCurves_PropertyAddress.Address);
			CopyCustomAttributes = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, CopyCustomAttributes_Offset), 0, CopyCustomAttributes_PropertyAddress.Address);
			UseMeshPose = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, UseMeshPose_Offset), 0, UseMeshPose_PropertyAddress.Address);
			RootBoneToCopy = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, RootBoneToCopy_Offset));
		}
	}

	static FAnimNode_CopyPoseFromMesh()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAnimNode_CopyPoseFromMesh)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimNode_CopyPoseFromMesh));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AnimGraphRuntime.AnimNode_CopyPoseFromMesh");
		FAnimNode_CopyPoseFromMesh_StructSize = NativeReflection.GetStructSize(intPtr);
		SourceMeshComponent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SourceMeshComponent");
		SourceMeshComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SourceMeshComponent", Classes.FWeakObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref UseAttachedParent_PropertyAddress, intPtr, "bUseAttachedParent");
		UseAttachedParent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUseAttachedParent");
		UseAttachedParent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUseAttachedParent", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CopyCurves_PropertyAddress, intPtr, "bCopyCurves");
		CopyCurves_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCopyCurves");
		CopyCurves_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCopyCurves", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CopyCustomAttributes_PropertyAddress, intPtr, "bCopyCustomAttributes");
		CopyCustomAttributes_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCopyCustomAttributes");
		CopyCustomAttributes_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCopyCustomAttributes", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref UseMeshPose_PropertyAddress, intPtr, "bUseMeshPose");
		UseMeshPose_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUseMeshPose");
		UseMeshPose_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUseMeshPose", Classes.FBoolProperty);
		RootBoneToCopy_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RootBoneToCopy");
		RootBoneToCopy_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RootBoneToCopy", Classes.FNameProperty);
		FAnimNode_CopyPoseFromMesh_IsValid = intPtr != IntPtr.Zero && SourceMeshComponent_IsValid && UseAttachedParent_IsValid && CopyCurves_IsValid && CopyCustomAttributes_IsValid && UseMeshPose_IsValid && RootBoneToCopy_IsValid;
		NativeReflection.LogStructIsValid("/Script/AnimGraphRuntime.AnimNode_CopyPoseFromMesh", FAnimNode_CopyPoseFromMesh_IsValid);
	}
}
