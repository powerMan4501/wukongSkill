using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.IKRig;

[UStruct(Flags = 4613)]
[BlueprintType]
[UMetaPath("/Script/IKRig.AnimNode_RetargetPoseFromMesh", "IKRig", UnrealModuleType.EnginePlugin)]
public struct FAnimNode_RetargetPoseFromMesh
{
	private static bool SourceMeshComponent_IsValid;

	private static int SourceMeshComponent_Offset;

	[UProperty(Flags = (PropFlags)7881369141649932uL)]
	[UMetaPath("/Script/IKRig.AnimNode_RetargetPoseFromMesh:SourceMeshComponent")]
	public TWeakObject<USkeletalMeshComponent> SourceMeshComponent;

	private static bool UseAttachedParent_IsValid;

	private static FFieldAddress UseAttachedParent_PropertyAddress;

	private static int UseAttachedParent_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/IKRig.AnimNode_RetargetPoseFromMesh:bUseAttachedParent")]
	public bool UseAttachedParent;

	private static bool IKRetargeterAsset_IsValid;

	private static int IKRetargeterAsset_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/IKRig.AnimNode_RetargetPoseFromMesh:IKRetargeterAsset")]
	public UIKRetargeter IKRetargeterAsset;

	private static bool FAnimNode_RetargetPoseFromMesh_IsValid;

	private static int FAnimNode_RetargetPoseFromMesh_StructSize;

	public FAnimNode_RetargetPoseFromMesh Copy()
	{
		return this;
	}

	public static FAnimNode_RetargetPoseFromMesh FromNative(IntPtr nativeBuffer)
	{
		return new FAnimNode_RetargetPoseFromMesh(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimNode_RetargetPoseFromMesh value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimNode_RetargetPoseFromMesh FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimNode_RetargetPoseFromMesh(nativeBuffer + arrayIndex * FAnimNode_RetargetPoseFromMesh_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimNode_RetargetPoseFromMesh value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAnimNode_RetargetPoseFromMesh_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAnimNode_RetargetPoseFromMesh_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/IKRig.AnimNode_RetargetPoseFromMesh");
			return;
		}
		TWeakObjectMarshaler<USkeletalMeshComponent>.ToNative(IntPtr.Add(nativeStruct, SourceMeshComponent_Offset), SourceMeshComponent);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, UseAttachedParent_Offset), 0, UseAttachedParent_PropertyAddress.Address, UseAttachedParent);
		UObjectMarshaler<UIKRetargeter>.ToNative(IntPtr.Add(nativeStruct, IKRetargeterAsset_Offset), IKRetargeterAsset);
	}

	public FAnimNode_RetargetPoseFromMesh(IntPtr nativeStruct)
	{
		if (!FAnimNode_RetargetPoseFromMesh_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/IKRig.AnimNode_RetargetPoseFromMesh");
			SourceMeshComponent = default(TWeakObject<USkeletalMeshComponent>);
			UseAttachedParent = false;
			IKRetargeterAsset = null;
		}
		else
		{
			SourceMeshComponent = TWeakObjectMarshaler<USkeletalMeshComponent>.FromNative(IntPtr.Add(nativeStruct, SourceMeshComponent_Offset));
			UseAttachedParent = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, UseAttachedParent_Offset), 0, UseAttachedParent_PropertyAddress.Address);
			IKRetargeterAsset = UObjectMarshaler<UIKRetargeter>.FromNative(IntPtr.Add(nativeStruct, IKRetargeterAsset_Offset));
		}
	}

	static FAnimNode_RetargetPoseFromMesh()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAnimNode_RetargetPoseFromMesh)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimNode_RetargetPoseFromMesh));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/IKRig.AnimNode_RetargetPoseFromMesh");
		FAnimNode_RetargetPoseFromMesh_StructSize = NativeReflection.GetStructSize(intPtr);
		SourceMeshComponent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SourceMeshComponent");
		SourceMeshComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SourceMeshComponent", Classes.FWeakObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref UseAttachedParent_PropertyAddress, intPtr, "bUseAttachedParent");
		UseAttachedParent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUseAttachedParent");
		UseAttachedParent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUseAttachedParent", Classes.FBoolProperty);
		IKRetargeterAsset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "IKRetargeterAsset");
		IKRetargeterAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "IKRetargeterAsset", Classes.FObjectProperty);
		FAnimNode_RetargetPoseFromMesh_IsValid = intPtr != IntPtr.Zero && SourceMeshComponent_IsValid && UseAttachedParent_IsValid && IKRetargeterAsset_IsValid;
		NativeReflection.LogStructIsValid("/Script/IKRig.AnimNode_RetargetPoseFromMesh", FAnimNode_RetargetPoseFromMesh_IsValid);
	}
}
