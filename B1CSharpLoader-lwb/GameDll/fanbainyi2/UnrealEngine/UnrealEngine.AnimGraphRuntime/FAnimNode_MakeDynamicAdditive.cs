using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraphRuntime;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/AnimGraphRuntime.AnimNode_MakeDynamicAdditive", "AnimGraphRuntime", UnrealModuleType.Engine)]
public struct FAnimNode_MakeDynamicAdditive
{
	private static bool Base__IsValid;

	private static int Base__Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_MakeDynamicAdditive:Base")]
	public FPoseLink Base_;

	private static bool Additive_IsValid;

	private static int Additive_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_MakeDynamicAdditive:Additive")]
	public FPoseLink Additive;

	private static bool MeshSpaceAdditive_IsValid;

	private static FFieldAddress MeshSpaceAdditive_PropertyAddress;

	private static int MeshSpaceAdditive_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_MakeDynamicAdditive:bMeshSpaceAdditive")]
	public bool MeshSpaceAdditive;

	private static bool FAnimNode_MakeDynamicAdditive_IsValid;

	private static int FAnimNode_MakeDynamicAdditive_StructSize;

	public FAnimNode_MakeDynamicAdditive Copy()
	{
		return this;
	}

	public static FAnimNode_MakeDynamicAdditive FromNative(IntPtr nativeBuffer)
	{
		return new FAnimNode_MakeDynamicAdditive(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimNode_MakeDynamicAdditive value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimNode_MakeDynamicAdditive FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimNode_MakeDynamicAdditive(nativeBuffer + arrayIndex * FAnimNode_MakeDynamicAdditive_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimNode_MakeDynamicAdditive value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAnimNode_MakeDynamicAdditive_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAnimNode_MakeDynamicAdditive_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.AnimNode_MakeDynamicAdditive");
			return;
		}
		FPoseLink.ToNative(IntPtr.Add(nativeStruct, Base__Offset), Base_);
		FPoseLink.ToNative(IntPtr.Add(nativeStruct, Additive_Offset), Additive);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, MeshSpaceAdditive_Offset), 0, MeshSpaceAdditive_PropertyAddress.Address, MeshSpaceAdditive);
	}

	public FAnimNode_MakeDynamicAdditive(IntPtr nativeStruct)
	{
		if (!FAnimNode_MakeDynamicAdditive_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.AnimNode_MakeDynamicAdditive");
			Base_ = default(FPoseLink);
			Additive = default(FPoseLink);
			MeshSpaceAdditive = false;
		}
		else
		{
			Base_ = FPoseLink.FromNative(IntPtr.Add(nativeStruct, Base__Offset));
			Additive = FPoseLink.FromNative(IntPtr.Add(nativeStruct, Additive_Offset));
			MeshSpaceAdditive = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, MeshSpaceAdditive_Offset), 0, MeshSpaceAdditive_PropertyAddress.Address);
		}
	}

	static FAnimNode_MakeDynamicAdditive()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAnimNode_MakeDynamicAdditive)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimNode_MakeDynamicAdditive));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AnimGraphRuntime.AnimNode_MakeDynamicAdditive");
		FAnimNode_MakeDynamicAdditive_StructSize = NativeReflection.GetStructSize(intPtr);
		Base__Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Base");
		Base__IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Base", Classes.FStructProperty);
		Additive_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Additive");
		Additive_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Additive", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref MeshSpaceAdditive_PropertyAddress, intPtr, "bMeshSpaceAdditive");
		MeshSpaceAdditive_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bMeshSpaceAdditive");
		MeshSpaceAdditive_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bMeshSpaceAdditive", Classes.FBoolProperty);
		FAnimNode_MakeDynamicAdditive_IsValid = intPtr != IntPtr.Zero && Base__IsValid && Additive_IsValid && MeshSpaceAdditive_IsValid;
		NativeReflection.LogStructIsValid("/Script/AnimGraphRuntime.AnimNode_MakeDynamicAdditive", FAnimNode_MakeDynamicAdditive_IsValid);
	}
}
