using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGWorldRayHitQueryParams", "PCG", UnrealModuleType.EnginePlugin)]
public struct FPCGWorldRayHitQueryParams
{
	private static bool IgnorePCGHits_IsValid;

	private static FFieldAddress IgnorePCGHits_PropertyAddress;

	private static int IgnorePCGHits_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGWorldCommonQueryParams:bIgnorePCGHits")]
	public bool IgnorePCGHits;

	private static bool IgnoreSelfHits_IsValid;

	private static FFieldAddress IgnoreSelfHits_PropertyAddress;

	private static int IgnoreSelfHits_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGWorldCommonQueryParams:bIgnoreSelfHits")]
	public bool IgnoreSelfHits;

	private static bool CollisionChannel_IsValid;

	private static FFieldAddress CollisionChannel_PropertyAddress;

	private static int CollisionChannel_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGWorldCommonQueryParams:CollisionChannel")]
	public ECollisionChannel CollisionChannel;

	private static bool TraceComplex_IsValid;

	private static FFieldAddress TraceComplex_PropertyAddress;

	private static int TraceComplex_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGWorldCommonQueryParams:bTraceComplex")]
	public bool TraceComplex;

	private static bool ActorTagFilter_IsValid;

	private static FFieldAddress ActorTagFilter_PropertyAddress;

	private static int ActorTagFilter_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGWorldCommonQueryParams:ActorTagFilter")]
	public EPCGWorldQueryFilterByTag ActorTagFilter;

	private static bool ActorTagsList_IsValid;

	private static int ActorTagsList_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/PCG.PCGWorldCommonQueryParams:ActorTagsList")]
	public string ActorTagsList;

	private static bool IgnoreLandscapeHits_IsValid;

	private static FFieldAddress IgnoreLandscapeHits_PropertyAddress;

	private static int IgnoreLandscapeHits_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGWorldCommonQueryParams:bIgnoreLandscapeHits")]
	public bool IgnoreLandscapeHits;

	private static bool GetReferenceToActorHit_IsValid;

	private static FFieldAddress GetReferenceToActorHit_PropertyAddress;

	private static int GetReferenceToActorHit_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGWorldCommonQueryParams:bGetReferenceToActorHit")]
	public bool GetReferenceToActorHit;

	private static bool OverrideDefaultParams_IsValid;

	private static FFieldAddress OverrideDefaultParams_PropertyAddress;

	private static int OverrideDefaultParams_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGWorldRayHitQueryParams:bOverrideDefaultParams")]
	public bool OverrideDefaultParams;

	private static bool RayOrigin_IsValid;

	private static int RayOrigin_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGWorldRayHitQueryParams:RayOrigin")]
	public FVector RayOrigin;

	private static bool RayDirection_IsValid;

	private static int RayDirection_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGWorldRayHitQueryParams:RayDirection")]
	public FVector RayDirection;

	private static bool RayLength_IsValid;

	private static int RayLength_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGWorldRayHitQueryParams:RayLength")]
	public double RayLength;

	private static bool ApplyMetadataFromLandscape_IsValid;

	private static FFieldAddress ApplyMetadataFromLandscape_PropertyAddress;

	private static int ApplyMetadataFromLandscape_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGWorldRayHitQueryParams:bApplyMetadataFromLandscape")]
	public bool ApplyMetadataFromLandscape;

	private static bool GetReferenceToPhysicalMaterial_IsValid;

	private static FFieldAddress GetReferenceToPhysicalMaterial_PropertyAddress;

	private static int GetReferenceToPhysicalMaterial_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGWorldRayHitQueryParams:bGetReferenceToPhysicalMaterial")]
	public bool GetReferenceToPhysicalMaterial;

	private static bool FPCGWorldRayHitQueryParams_IsValid;

	private static int FPCGWorldRayHitQueryParams_StructSize;

	public FPCGWorldRayHitQueryParams Copy()
	{
		return this;
	}

	public static FPCGWorldRayHitQueryParams FromNative(IntPtr nativeBuffer)
	{
		return new FPCGWorldRayHitQueryParams(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FPCGWorldRayHitQueryParams value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FPCGWorldRayHitQueryParams FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FPCGWorldRayHitQueryParams(nativeBuffer + arrayIndex * FPCGWorldRayHitQueryParams_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FPCGWorldRayHitQueryParams value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FPCGWorldRayHitQueryParams_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FPCGWorldRayHitQueryParams_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/PCG.PCGWorldRayHitQueryParams");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, OverrideDefaultParams_Offset), 0, OverrideDefaultParams_PropertyAddress.Address, OverrideDefaultParams);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, RayOrigin_Offset), RayOrigin);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, RayDirection_Offset), RayDirection);
		BlittableTypeMarshaler<double>.ToNative(IntPtr.Add(nativeStruct, RayLength_Offset), RayLength);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ApplyMetadataFromLandscape_Offset), 0, ApplyMetadataFromLandscape_PropertyAddress.Address, ApplyMetadataFromLandscape);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, GetReferenceToPhysicalMaterial_Offset), 0, GetReferenceToPhysicalMaterial_PropertyAddress.Address, GetReferenceToPhysicalMaterial);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IgnorePCGHits_Offset), 0, IgnorePCGHits_PropertyAddress.Address, IgnorePCGHits);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IgnoreSelfHits_Offset), 0, IgnoreSelfHits_PropertyAddress.Address, IgnoreSelfHits);
		EnumMarshaler<ECollisionChannel>.ToNative(IntPtr.Add(nativeStruct, CollisionChannel_Offset), 0, CollisionChannel_PropertyAddress.Address, CollisionChannel);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, TraceComplex_Offset), 0, TraceComplex_PropertyAddress.Address, TraceComplex);
		EnumMarshaler<EPCGWorldQueryFilterByTag>.ToNative(IntPtr.Add(nativeStruct, ActorTagFilter_Offset), 0, ActorTagFilter_PropertyAddress.Address, ActorTagFilter);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, ActorTagsList_Offset), ActorTagsList);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IgnoreLandscapeHits_Offset), 0, IgnoreLandscapeHits_PropertyAddress.Address, IgnoreLandscapeHits);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, GetReferenceToActorHit_Offset), 0, GetReferenceToActorHit_PropertyAddress.Address, GetReferenceToActorHit);
	}

	public FPCGWorldRayHitQueryParams(IntPtr nativeStruct)
	{
		if (!FPCGWorldRayHitQueryParams_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/PCG.PCGWorldRayHitQueryParams");
			OverrideDefaultParams = false;
			RayOrigin = default(FVector);
			RayDirection = default(FVector);
			RayLength = 0.0;
			ApplyMetadataFromLandscape = false;
			GetReferenceToPhysicalMaterial = false;
			IgnorePCGHits = false;
			IgnoreSelfHits = false;
			CollisionChannel = ECollisionChannel.ECC_WorldStatic;
			TraceComplex = false;
			ActorTagFilter = EPCGWorldQueryFilterByTag.NoTagFilter;
			ActorTagsList = FStringMarshaler.DefaultString;
			IgnoreLandscapeHits = false;
			GetReferenceToActorHit = false;
		}
		else
		{
			OverrideDefaultParams = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, OverrideDefaultParams_Offset), 0, OverrideDefaultParams_PropertyAddress.Address);
			RayOrigin = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, RayOrigin_Offset));
			RayDirection = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, RayDirection_Offset));
			RayLength = BlittableTypeMarshaler<double>.FromNative(IntPtr.Add(nativeStruct, RayLength_Offset));
			ApplyMetadataFromLandscape = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ApplyMetadataFromLandscape_Offset), 0, ApplyMetadataFromLandscape_PropertyAddress.Address);
			GetReferenceToPhysicalMaterial = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, GetReferenceToPhysicalMaterial_Offset), 0, GetReferenceToPhysicalMaterial_PropertyAddress.Address);
			IgnorePCGHits = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IgnorePCGHits_Offset), 0, IgnorePCGHits_PropertyAddress.Address);
			IgnoreSelfHits = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IgnoreSelfHits_Offset), 0, IgnoreSelfHits_PropertyAddress.Address);
			CollisionChannel = EnumMarshaler<ECollisionChannel>.FromNative(IntPtr.Add(nativeStruct, CollisionChannel_Offset), 0, CollisionChannel_PropertyAddress.Address);
			TraceComplex = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, TraceComplex_Offset), 0, TraceComplex_PropertyAddress.Address);
			ActorTagFilter = EnumMarshaler<EPCGWorldQueryFilterByTag>.FromNative(IntPtr.Add(nativeStruct, ActorTagFilter_Offset), 0, ActorTagFilter_PropertyAddress.Address);
			ActorTagsList = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, ActorTagsList_Offset));
			IgnoreLandscapeHits = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IgnoreLandscapeHits_Offset), 0, IgnoreLandscapeHits_PropertyAddress.Address);
			GetReferenceToActorHit = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, GetReferenceToActorHit_Offset), 0, GetReferenceToActorHit_PropertyAddress.Address);
		}
	}

	static FPCGWorldRayHitQueryParams()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FPCGWorldRayHitQueryParams)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FPCGWorldRayHitQueryParams));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/PCG.PCGWorldRayHitQueryParams");
		FPCGWorldRayHitQueryParams_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref IgnorePCGHits_PropertyAddress, intPtr, "bIgnorePCGHits");
		IgnorePCGHits_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIgnorePCGHits");
		IgnorePCGHits_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIgnorePCGHits", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IgnoreSelfHits_PropertyAddress, intPtr, "bIgnoreSelfHits");
		IgnoreSelfHits_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIgnoreSelfHits");
		IgnoreSelfHits_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIgnoreSelfHits", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CollisionChannel_PropertyAddress, intPtr, "CollisionChannel");
		CollisionChannel_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CollisionChannel");
		CollisionChannel_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CollisionChannel", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref TraceComplex_PropertyAddress, intPtr, "bTraceComplex");
		TraceComplex_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bTraceComplex");
		TraceComplex_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bTraceComplex", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ActorTagFilter_PropertyAddress, intPtr, "ActorTagFilter");
		ActorTagFilter_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ActorTagFilter");
		ActorTagFilter_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ActorTagFilter", Classes.FEnumProperty);
		ActorTagsList_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ActorTagsList");
		ActorTagsList_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ActorTagsList", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref IgnoreLandscapeHits_PropertyAddress, intPtr, "bIgnoreLandscapeHits");
		IgnoreLandscapeHits_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIgnoreLandscapeHits");
		IgnoreLandscapeHits_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIgnoreLandscapeHits", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetReferenceToActorHit_PropertyAddress, intPtr, "bGetReferenceToActorHit");
		GetReferenceToActorHit_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bGetReferenceToActorHit");
		GetReferenceToActorHit_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bGetReferenceToActorHit", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref OverrideDefaultParams_PropertyAddress, intPtr, "bOverrideDefaultParams");
		OverrideDefaultParams_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bOverrideDefaultParams");
		OverrideDefaultParams_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bOverrideDefaultParams", Classes.FBoolProperty);
		RayOrigin_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RayOrigin");
		RayOrigin_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RayOrigin", Classes.FStructProperty);
		RayDirection_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RayDirection");
		RayDirection_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RayDirection", Classes.FStructProperty);
		RayLength_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RayLength");
		RayLength_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RayLength", Classes.FDoubleProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyMetadataFromLandscape_PropertyAddress, intPtr, "bApplyMetadataFromLandscape");
		ApplyMetadataFromLandscape_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bApplyMetadataFromLandscape");
		ApplyMetadataFromLandscape_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bApplyMetadataFromLandscape", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetReferenceToPhysicalMaterial_PropertyAddress, intPtr, "bGetReferenceToPhysicalMaterial");
		GetReferenceToPhysicalMaterial_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bGetReferenceToPhysicalMaterial");
		GetReferenceToPhysicalMaterial_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bGetReferenceToPhysicalMaterial", Classes.FBoolProperty);
		FPCGWorldRayHitQueryParams_IsValid = intPtr != IntPtr.Zero && OverrideDefaultParams_IsValid && RayOrigin_IsValid && RayDirection_IsValid && RayLength_IsValid && ApplyMetadataFromLandscape_IsValid && GetReferenceToPhysicalMaterial_IsValid && IgnorePCGHits_IsValid && IgnoreSelfHits_IsValid && CollisionChannel_IsValid && TraceComplex_IsValid && ActorTagFilter_IsValid && ActorTagsList_IsValid && IgnoreLandscapeHits_IsValid && GetReferenceToActorHit_IsValid;
		NativeReflection.LogStructIsValid("/Script/PCG.PCGWorldRayHitQueryParams", FPCGWorldRayHitQueryParams_IsValid);
	}
}
