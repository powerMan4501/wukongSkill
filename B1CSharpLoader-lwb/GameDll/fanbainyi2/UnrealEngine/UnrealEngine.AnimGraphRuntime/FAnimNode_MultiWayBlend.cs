using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraphRuntime;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/AnimGraphRuntime.AnimNode_MultiWayBlend", "AnimGraphRuntime", UnrealModuleType.Engine)]
public struct FAnimNode_MultiWayBlend
{
	private static bool Poses_IsValid;

	private static FFieldAddress Poses_PropertyAddress;

	private static int Poses_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_MultiWayBlend:Poses")]
	public List<FPoseLink> Poses;

	private static bool DesiredAlphas_IsValid;

	private static FFieldAddress DesiredAlphas_PropertyAddress;

	private static int DesiredAlphas_Offset;

	[UProperty(Flags = (PropFlags)4503599627371077uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_MultiWayBlend:DesiredAlphas")]
	public List<float> DesiredAlphas;

	private static bool AlphaScaleBias_IsValid;

	private static int AlphaScaleBias_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_MultiWayBlend:AlphaScaleBias")]
	public FInputScaleBias AlphaScaleBias;

	private static bool AdditiveNode_IsValid;

	private static FFieldAddress AdditiveNode_PropertyAddress;

	private static int AdditiveNode_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_MultiWayBlend:bAdditiveNode")]
	public bool AdditiveNode;

	private static bool NormalizeAlpha_IsValid;

	private static FFieldAddress NormalizeAlpha_PropertyAddress;

	private static int NormalizeAlpha_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_MultiWayBlend:bNormalizeAlpha")]
	public bool NormalizeAlpha;

	private static bool FAnimNode_MultiWayBlend_IsValid;

	private static int FAnimNode_MultiWayBlend_StructSize;

	public FAnimNode_MultiWayBlend Copy()
	{
		FAnimNode_MultiWayBlend result = this;
		if (Poses != null)
		{
			result.Poses = new List<FPoseLink>(Poses);
		}
		if (DesiredAlphas != null)
		{
			result.DesiredAlphas = new List<float>(DesiredAlphas);
		}
		return result;
	}

	public static FAnimNode_MultiWayBlend FromNative(IntPtr nativeBuffer)
	{
		return new FAnimNode_MultiWayBlend(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimNode_MultiWayBlend value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimNode_MultiWayBlend FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimNode_MultiWayBlend(nativeBuffer + arrayIndex * FAnimNode_MultiWayBlend_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimNode_MultiWayBlend value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAnimNode_MultiWayBlend_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAnimNode_MultiWayBlend_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.AnimNode_MultiWayBlend");
			return;
		}
		new TArrayCopyMarshaler<FPoseLink>(1, Poses_PropertyAddress, CachedMarshalingDelegates<FPoseLink, FPoseLink>.FromNative, CachedMarshalingDelegates<FPoseLink, FPoseLink>.ToNative).ToNative(IntPtr.Add(nativeStruct, Poses_Offset), Poses);
		new TArrayCopyMarshaler<float>(1, DesiredAlphas_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).ToNative(IntPtr.Add(nativeStruct, DesiredAlphas_Offset), DesiredAlphas);
		FInputScaleBias.ToNative(IntPtr.Add(nativeStruct, AlphaScaleBias_Offset), AlphaScaleBias);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, AdditiveNode_Offset), 0, AdditiveNode_PropertyAddress.Address, AdditiveNode);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, NormalizeAlpha_Offset), 0, NormalizeAlpha_PropertyAddress.Address, NormalizeAlpha);
	}

	public FAnimNode_MultiWayBlend(IntPtr nativeStruct)
	{
		if (!FAnimNode_MultiWayBlend_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.AnimNode_MultiWayBlend");
			Poses = null;
			DesiredAlphas = null;
			AlphaScaleBias = default(FInputScaleBias);
			AdditiveNode = false;
			NormalizeAlpha = false;
		}
		else
		{
			Poses = new TArrayCopyMarshaler<FPoseLink>(1, Poses_PropertyAddress, CachedMarshalingDelegates<FPoseLink, FPoseLink>.FromNative, CachedMarshalingDelegates<FPoseLink, FPoseLink>.ToNative).FromNative(IntPtr.Add(nativeStruct, Poses_Offset));
			DesiredAlphas = new TArrayCopyMarshaler<float>(1, DesiredAlphas_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).FromNative(IntPtr.Add(nativeStruct, DesiredAlphas_Offset));
			AlphaScaleBias = FInputScaleBias.FromNative(IntPtr.Add(nativeStruct, AlphaScaleBias_Offset));
			AdditiveNode = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, AdditiveNode_Offset), 0, AdditiveNode_PropertyAddress.Address);
			NormalizeAlpha = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, NormalizeAlpha_Offset), 0, NormalizeAlpha_PropertyAddress.Address);
		}
	}

	static FAnimNode_MultiWayBlend()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAnimNode_MultiWayBlend)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimNode_MultiWayBlend));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AnimGraphRuntime.AnimNode_MultiWayBlend");
		FAnimNode_MultiWayBlend_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref Poses_PropertyAddress, intPtr, "Poses");
		Poses_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Poses");
		Poses_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Poses", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref DesiredAlphas_PropertyAddress, intPtr, "DesiredAlphas");
		DesiredAlphas_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DesiredAlphas");
		DesiredAlphas_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DesiredAlphas", Classes.FArrayProperty);
		AlphaScaleBias_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AlphaScaleBias");
		AlphaScaleBias_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AlphaScaleBias", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AdditiveNode_PropertyAddress, intPtr, "bAdditiveNode");
		AdditiveNode_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAdditiveNode");
		AdditiveNode_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAdditiveNode", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref NormalizeAlpha_PropertyAddress, intPtr, "bNormalizeAlpha");
		NormalizeAlpha_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bNormalizeAlpha");
		NormalizeAlpha_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bNormalizeAlpha", Classes.FBoolProperty);
		FAnimNode_MultiWayBlend_IsValid = intPtr != IntPtr.Zero && Poses_IsValid && DesiredAlphas_IsValid && AlphaScaleBias_IsValid && AdditiveNode_IsValid && NormalizeAlpha_IsValid;
		NativeReflection.LogStructIsValid("/Script/AnimGraphRuntime.AnimNode_MultiWayBlend", FAnimNode_MultiWayBlend_IsValid);
	}
}
