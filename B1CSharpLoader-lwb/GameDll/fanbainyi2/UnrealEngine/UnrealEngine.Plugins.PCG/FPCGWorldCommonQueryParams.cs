using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGWorldCommonQueryParams", "PCG", UnrealModuleType.EnginePlugin)]
public struct FPCGWorldCommonQueryParams
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

	private static bool FPCGWorldCommonQueryParams_IsValid;

	private static int FPCGWorldCommonQueryParams_StructSize;

	public FPCGWorldCommonQueryParams Copy()
	{
		return this;
	}

	public static FPCGWorldCommonQueryParams FromNative(IntPtr nativeBuffer)
	{
		return new FPCGWorldCommonQueryParams(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FPCGWorldCommonQueryParams value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FPCGWorldCommonQueryParams FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FPCGWorldCommonQueryParams(nativeBuffer + arrayIndex * FPCGWorldCommonQueryParams_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FPCGWorldCommonQueryParams value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FPCGWorldCommonQueryParams_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FPCGWorldCommonQueryParams_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/PCG.PCGWorldCommonQueryParams");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IgnorePCGHits_Offset), 0, IgnorePCGHits_PropertyAddress.Address, IgnorePCGHits);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IgnoreSelfHits_Offset), 0, IgnoreSelfHits_PropertyAddress.Address, IgnoreSelfHits);
		EnumMarshaler<ECollisionChannel>.ToNative(IntPtr.Add(nativeStruct, CollisionChannel_Offset), 0, CollisionChannel_PropertyAddress.Address, CollisionChannel);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, TraceComplex_Offset), 0, TraceComplex_PropertyAddress.Address, TraceComplex);
		EnumMarshaler<EPCGWorldQueryFilterByTag>.ToNative(IntPtr.Add(nativeStruct, ActorTagFilter_Offset), 0, ActorTagFilter_PropertyAddress.Address, ActorTagFilter);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, ActorTagsList_Offset), ActorTagsList);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IgnoreLandscapeHits_Offset), 0, IgnoreLandscapeHits_PropertyAddress.Address, IgnoreLandscapeHits);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, GetReferenceToActorHit_Offset), 0, GetReferenceToActorHit_PropertyAddress.Address, GetReferenceToActorHit);
	}

	public FPCGWorldCommonQueryParams(IntPtr nativeStruct)
	{
		if (!FPCGWorldCommonQueryParams_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/PCG.PCGWorldCommonQueryParams");
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

	static FPCGWorldCommonQueryParams()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FPCGWorldCommonQueryParams)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FPCGWorldCommonQueryParams));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/PCG.PCGWorldCommonQueryParams");
		FPCGWorldCommonQueryParams_StructSize = NativeReflection.GetStructSize(intPtr);
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
		FPCGWorldCommonQueryParams_IsValid = intPtr != IntPtr.Zero && IgnorePCGHits_IsValid && IgnoreSelfHits_IsValid && CollisionChannel_IsValid && TraceComplex_IsValid && ActorTagFilter_IsValid && ActorTagsList_IsValid && IgnoreLandscapeHits_IsValid && GetReferenceToActorHit_IsValid;
		NativeReflection.LogStructIsValid("/Script/PCG.PCGWorldCommonQueryParams", FPCGWorldCommonQueryParams_IsValid);
	}
}
