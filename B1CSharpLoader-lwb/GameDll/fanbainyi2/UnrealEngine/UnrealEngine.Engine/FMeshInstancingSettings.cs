using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.MeshInstancingSettings", "Engine", UnrealModuleType.Engine)]
public struct FMeshInstancingSettings
{
	private static bool ActorClassToUse_IsValid;

	private static int ActorClassToUse_Offset;

	[UProperty(Flags = (PropFlags)7881369174671877uL)]
	[UMetaPath("/Script/Engine.MeshInstancingSettings:ActorClassToUse")]
	public TSubclassOf<AActor> ActorClassToUse;

	private static bool InstanceReplacementThreshold_IsValid;

	private static int InstanceReplacementThreshold_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MeshInstancingSettings:InstanceReplacementThreshold")]
	public int InstanceReplacementThreshold;

	private static bool SkipMeshesWithVertexColors_IsValid;

	private static FFieldAddress SkipMeshesWithVertexColors_PropertyAddress;

	private static int SkipMeshesWithVertexColors_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MeshInstancingSettings:bSkipMeshesWithVertexColors")]
	public bool SkipMeshesWithVertexColors;

	private static bool UseHLODVolumes_IsValid;

	private static FFieldAddress UseHLODVolumes_PropertyAddress;

	private static int UseHLODVolumes_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MeshInstancingSettings:bUseHLODVolumes")]
	public bool UseHLODVolumes;

	private static bool ISMComponentToUse_IsValid;

	private static int ISMComponentToUse_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/Engine.MeshInstancingSettings:ISMComponentToUse")]
	public TSubclassOf<UInstancedStaticMeshComponent> ISMComponentToUse;

	private static bool FMeshInstancingSettings_IsValid;

	private static int FMeshInstancingSettings_StructSize;

	public FMeshInstancingSettings Copy()
	{
		return this;
	}

	public static FMeshInstancingSettings FromNative(IntPtr nativeBuffer)
	{
		return new FMeshInstancingSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FMeshInstancingSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FMeshInstancingSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FMeshInstancingSettings(nativeBuffer + arrayIndex * FMeshInstancingSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FMeshInstancingSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FMeshInstancingSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FMeshInstancingSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.MeshInstancingSettings");
			return;
		}
		TSubclassOfMarshaler<AActor>.ToNative(IntPtr.Add(nativeStruct, ActorClassToUse_Offset), ActorClassToUse);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, InstanceReplacementThreshold_Offset), InstanceReplacementThreshold);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, SkipMeshesWithVertexColors_Offset), 0, SkipMeshesWithVertexColors_PropertyAddress.Address, SkipMeshesWithVertexColors);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, UseHLODVolumes_Offset), 0, UseHLODVolumes_PropertyAddress.Address, UseHLODVolumes);
		TSubclassOfMarshaler<UInstancedStaticMeshComponent>.ToNative(IntPtr.Add(nativeStruct, ISMComponentToUse_Offset), ISMComponentToUse);
	}

	public FMeshInstancingSettings(IntPtr nativeStruct)
	{
		if (!FMeshInstancingSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.MeshInstancingSettings");
			ActorClassToUse = default(TSubclassOf<AActor>);
			InstanceReplacementThreshold = 0;
			SkipMeshesWithVertexColors = false;
			UseHLODVolumes = false;
			ISMComponentToUse = default(TSubclassOf<UInstancedStaticMeshComponent>);
		}
		else
		{
			ActorClassToUse = TSubclassOfMarshaler<AActor>.FromNative(IntPtr.Add(nativeStruct, ActorClassToUse_Offset));
			InstanceReplacementThreshold = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, InstanceReplacementThreshold_Offset));
			SkipMeshesWithVertexColors = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, SkipMeshesWithVertexColors_Offset), 0, SkipMeshesWithVertexColors_PropertyAddress.Address);
			UseHLODVolumes = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, UseHLODVolumes_Offset), 0, UseHLODVolumes_PropertyAddress.Address);
			ISMComponentToUse = TSubclassOfMarshaler<UInstancedStaticMeshComponent>.FromNative(IntPtr.Add(nativeStruct, ISMComponentToUse_Offset));
		}
	}

	static FMeshInstancingSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FMeshInstancingSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FMeshInstancingSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.MeshInstancingSettings");
		FMeshInstancingSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		ActorClassToUse_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ActorClassToUse");
		ActorClassToUse_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ActorClassToUse", Classes.FClassProperty);
		InstanceReplacementThreshold_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InstanceReplacementThreshold");
		InstanceReplacementThreshold_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InstanceReplacementThreshold", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SkipMeshesWithVertexColors_PropertyAddress, intPtr, "bSkipMeshesWithVertexColors");
		SkipMeshesWithVertexColors_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bSkipMeshesWithVertexColors");
		SkipMeshesWithVertexColors_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bSkipMeshesWithVertexColors", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref UseHLODVolumes_PropertyAddress, intPtr, "bUseHLODVolumes");
		UseHLODVolumes_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUseHLODVolumes");
		UseHLODVolumes_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUseHLODVolumes", Classes.FBoolProperty);
		ISMComponentToUse_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ISMComponentToUse");
		ISMComponentToUse_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ISMComponentToUse", Classes.FClassProperty);
		FMeshInstancingSettings_IsValid = intPtr != IntPtr.Zero && ActorClassToUse_IsValid && InstanceReplacementThreshold_IsValid && SkipMeshesWithVertexColors_IsValid && UseHLODVolumes_IsValid && ISMComponentToUse_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.MeshInstancingSettings", FMeshInstancingSettings_IsValid);
	}
}
