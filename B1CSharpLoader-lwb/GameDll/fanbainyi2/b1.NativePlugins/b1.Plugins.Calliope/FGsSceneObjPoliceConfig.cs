using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1.Plugins.Calliope;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Calliope.GsSceneObjPoliceConfig", "Calliope", UnrealModuleType.GamePlugin)]
public struct FGsSceneObjPoliceConfig
{
	private static bool DynamicObstacleCollection_IsValid;

	private static FFieldAddress DynamicObstacleCollection_PropertyAddress;

	private static int DynamicObstacleCollection_Offset;

	[UProperty(Flags = (PropFlags)4503599627371077uL)]
	[UMetaPath("/Script/Calliope.GsSceneObjPoliceConfig:DynamicObstacleCollection")]
	public List<FGsDynamicObstaclePoliceConfig> DynamicObstacleCollection;

	private static bool OverlapCollection_IsValid;

	private static FFieldAddress OverlapCollection_PropertyAddress;

	private static int OverlapCollection_Offset;

	[UProperty(Flags = (PropFlags)4503599627371077uL)]
	[UMetaPath("/Script/Calliope.GsSceneObjPoliceConfig:OverlapCollection")]
	public List<FGsOverlapPoliceConfig> OverlapCollection;

	private static bool InteractorCollection_IsValid;

	private static FFieldAddress InteractorCollection_PropertyAddress;

	private static int InteractorCollection_Offset;

	[UProperty(Flags = (PropFlags)4503599627371077uL)]
	[UMetaPath("/Script/Calliope.GsSceneObjPoliceConfig:InteractorCollection")]
	public List<FGsInteractorPoliceConfig> InteractorCollection;

	private static bool SpawnerCollection_IsValid;

	private static FFieldAddress SpawnerCollection_PropertyAddress;

	private static int SpawnerCollection_Offset;

	[UProperty(Flags = (PropFlags)4503599627371077uL)]
	[UMetaPath("/Script/Calliope.GsSceneObjPoliceConfig:SpawnerCollection")]
	public List<FGsSpawnerPoliceConfig> SpawnerCollection;

	private static bool UnitCollection_IsValid;

	private static FFieldAddress UnitCollection_PropertyAddress;

	private static int UnitCollection_Offset;

	[UProperty(Flags = (PropFlags)4503599627371077uL)]
	[UMetaPath("/Script/Calliope.GsSceneObjPoliceConfig:UnitCollection")]
	public List<FGsUnitPoliceConfig> UnitCollection;

	private static bool GroupUnitCollection_IsValid;

	private static FFieldAddress GroupUnitCollection_PropertyAddress;

	private static int GroupUnitCollection_Offset;

	[UProperty(Flags = (PropFlags)4503599627371077uL)]
	[UMetaPath("/Script/Calliope.GsSceneObjPoliceConfig:GroupUnitCollection")]
	public List<FGsUnitPoliceConfig> GroupUnitCollection;

	private static bool NPCUnitCollection_IsValid;

	private static FFieldAddress NPCUnitCollection_PropertyAddress;

	private static int NPCUnitCollection_Offset;

	[UProperty(Flags = (PropFlags)4503599627371077uL)]
	[UMetaPath("/Script/Calliope.GsSceneObjPoliceConfig:NPCUnitCollection")]
	public List<FGsNPCUnitPoliceConfig> NPCUnitCollection;

	private static bool StreamingLevelCollection_IsValid;

	private static FFieldAddress StreamingLevelCollection_PropertyAddress;

	private static int StreamingLevelCollection_Offset;

	[UProperty(Flags = (PropFlags)4503599627371077uL)]
	[UMetaPath("/Script/Calliope.GsSceneObjPoliceConfig:StreamingLevelCollection")]
	public List<FGsStreamingLevelPoliceConfig> StreamingLevelCollection;

	private static bool StreamingLevelStateConfigCollection_IsValid;

	private static FFieldAddress StreamingLevelStateConfigCollection_PropertyAddress;

	private static int StreamingLevelStateConfigCollection_Offset;

	[UProperty(Flags = (PropFlags)4503599627371077uL)]
	[UMetaPath("/Script/Calliope.GsSceneObjPoliceConfig:StreamingLevelStateConfigCollection")]
	public List<FGsStreamingLevelStateConfigPoliceConfig> StreamingLevelStateConfigCollection;

	private static bool FGsSceneObjPoliceConfig_IsValid;

	private static int FGsSceneObjPoliceConfig_StructSize;

	public FGsSceneObjPoliceConfig Copy()
	{
		FGsSceneObjPoliceConfig result = this;
		if (DynamicObstacleCollection != null)
		{
			result.DynamicObstacleCollection = new List<FGsDynamicObstaclePoliceConfig>(DynamicObstacleCollection);
		}
		if (OverlapCollection != null)
		{
			result.OverlapCollection = new List<FGsOverlapPoliceConfig>(OverlapCollection);
		}
		if (InteractorCollection != null)
		{
			result.InteractorCollection = new List<FGsInteractorPoliceConfig>(InteractorCollection);
		}
		if (SpawnerCollection != null)
		{
			result.SpawnerCollection = new List<FGsSpawnerPoliceConfig>(SpawnerCollection);
		}
		if (UnitCollection != null)
		{
			result.UnitCollection = new List<FGsUnitPoliceConfig>(UnitCollection);
		}
		if (GroupUnitCollection != null)
		{
			result.GroupUnitCollection = new List<FGsUnitPoliceConfig>(GroupUnitCollection);
		}
		if (NPCUnitCollection != null)
		{
			result.NPCUnitCollection = new List<FGsNPCUnitPoliceConfig>(NPCUnitCollection);
		}
		if (StreamingLevelCollection != null)
		{
			result.StreamingLevelCollection = new List<FGsStreamingLevelPoliceConfig>(StreamingLevelCollection);
		}
		if (StreamingLevelStateConfigCollection != null)
		{
			result.StreamingLevelStateConfigCollection = new List<FGsStreamingLevelStateConfigPoliceConfig>(StreamingLevelStateConfigCollection);
		}
		return result;
	}

	public static FGsSceneObjPoliceConfig FromNative(IntPtr nativeBuffer)
	{
		return new FGsSceneObjPoliceConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGsSceneObjPoliceConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGsSceneObjPoliceConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGsSceneObjPoliceConfig(nativeBuffer + arrayIndex * FGsSceneObjPoliceConfig_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGsSceneObjPoliceConfig value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGsSceneObjPoliceConfig_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGsSceneObjPoliceConfig_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Calliope.GsSceneObjPoliceConfig");
			return;
		}
		new TArrayCopyMarshaler<FGsDynamicObstaclePoliceConfig>(1, DynamicObstacleCollection_PropertyAddress, CachedMarshalingDelegates<FGsDynamicObstaclePoliceConfig, FGsDynamicObstaclePoliceConfig>.FromNative, CachedMarshalingDelegates<FGsDynamicObstaclePoliceConfig, FGsDynamicObstaclePoliceConfig>.ToNative).ToNative(IntPtr.Add(nativeStruct, DynamicObstacleCollection_Offset), DynamicObstacleCollection);
		new TArrayCopyMarshaler<FGsOverlapPoliceConfig>(1, OverlapCollection_PropertyAddress, CachedMarshalingDelegates<FGsOverlapPoliceConfig, FGsOverlapPoliceConfig>.FromNative, CachedMarshalingDelegates<FGsOverlapPoliceConfig, FGsOverlapPoliceConfig>.ToNative).ToNative(IntPtr.Add(nativeStruct, OverlapCollection_Offset), OverlapCollection);
		new TArrayCopyMarshaler<FGsInteractorPoliceConfig>(1, InteractorCollection_PropertyAddress, CachedMarshalingDelegates<FGsInteractorPoliceConfig, FGsInteractorPoliceConfig>.FromNative, CachedMarshalingDelegates<FGsInteractorPoliceConfig, FGsInteractorPoliceConfig>.ToNative).ToNative(IntPtr.Add(nativeStruct, InteractorCollection_Offset), InteractorCollection);
		new TArrayCopyMarshaler<FGsSpawnerPoliceConfig>(1, SpawnerCollection_PropertyAddress, CachedMarshalingDelegates<FGsSpawnerPoliceConfig, FGsSpawnerPoliceConfig>.FromNative, CachedMarshalingDelegates<FGsSpawnerPoliceConfig, FGsSpawnerPoliceConfig>.ToNative).ToNative(IntPtr.Add(nativeStruct, SpawnerCollection_Offset), SpawnerCollection);
		new TArrayCopyMarshaler<FGsUnitPoliceConfig>(1, UnitCollection_PropertyAddress, CachedMarshalingDelegates<FGsUnitPoliceConfig, FGsUnitPoliceConfig>.FromNative, CachedMarshalingDelegates<FGsUnitPoliceConfig, FGsUnitPoliceConfig>.ToNative).ToNative(IntPtr.Add(nativeStruct, UnitCollection_Offset), UnitCollection);
		new TArrayCopyMarshaler<FGsUnitPoliceConfig>(1, GroupUnitCollection_PropertyAddress, CachedMarshalingDelegates<FGsUnitPoliceConfig, FGsUnitPoliceConfig>.FromNative, CachedMarshalingDelegates<FGsUnitPoliceConfig, FGsUnitPoliceConfig>.ToNative).ToNative(IntPtr.Add(nativeStruct, GroupUnitCollection_Offset), GroupUnitCollection);
		new TArrayCopyMarshaler<FGsNPCUnitPoliceConfig>(1, NPCUnitCollection_PropertyAddress, CachedMarshalingDelegates<FGsNPCUnitPoliceConfig, FGsNPCUnitPoliceConfig>.FromNative, CachedMarshalingDelegates<FGsNPCUnitPoliceConfig, FGsNPCUnitPoliceConfig>.ToNative).ToNative(IntPtr.Add(nativeStruct, NPCUnitCollection_Offset), NPCUnitCollection);
		new TArrayCopyMarshaler<FGsStreamingLevelPoliceConfig>(1, StreamingLevelCollection_PropertyAddress, CachedMarshalingDelegates<FGsStreamingLevelPoliceConfig, FGsStreamingLevelPoliceConfig>.FromNative, CachedMarshalingDelegates<FGsStreamingLevelPoliceConfig, FGsStreamingLevelPoliceConfig>.ToNative).ToNative(IntPtr.Add(nativeStruct, StreamingLevelCollection_Offset), StreamingLevelCollection);
		new TArrayCopyMarshaler<FGsStreamingLevelStateConfigPoliceConfig>(1, StreamingLevelStateConfigCollection_PropertyAddress, CachedMarshalingDelegates<FGsStreamingLevelStateConfigPoliceConfig, FGsStreamingLevelStateConfigPoliceConfig>.FromNative, CachedMarshalingDelegates<FGsStreamingLevelStateConfigPoliceConfig, FGsStreamingLevelStateConfigPoliceConfig>.ToNative).ToNative(IntPtr.Add(nativeStruct, StreamingLevelStateConfigCollection_Offset), StreamingLevelStateConfigCollection);
	}

	public FGsSceneObjPoliceConfig(IntPtr nativeStruct)
	{
		if (!FGsSceneObjPoliceConfig_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Calliope.GsSceneObjPoliceConfig");
			DynamicObstacleCollection = null;
			OverlapCollection = null;
			InteractorCollection = null;
			SpawnerCollection = null;
			UnitCollection = null;
			GroupUnitCollection = null;
			NPCUnitCollection = null;
			StreamingLevelCollection = null;
			StreamingLevelStateConfigCollection = null;
		}
		else
		{
			DynamicObstacleCollection = new TArrayCopyMarshaler<FGsDynamicObstaclePoliceConfig>(1, DynamicObstacleCollection_PropertyAddress, CachedMarshalingDelegates<FGsDynamicObstaclePoliceConfig, FGsDynamicObstaclePoliceConfig>.FromNative, CachedMarshalingDelegates<FGsDynamicObstaclePoliceConfig, FGsDynamicObstaclePoliceConfig>.ToNative).FromNative(IntPtr.Add(nativeStruct, DynamicObstacleCollection_Offset));
			OverlapCollection = new TArrayCopyMarshaler<FGsOverlapPoliceConfig>(1, OverlapCollection_PropertyAddress, CachedMarshalingDelegates<FGsOverlapPoliceConfig, FGsOverlapPoliceConfig>.FromNative, CachedMarshalingDelegates<FGsOverlapPoliceConfig, FGsOverlapPoliceConfig>.ToNative).FromNative(IntPtr.Add(nativeStruct, OverlapCollection_Offset));
			InteractorCollection = new TArrayCopyMarshaler<FGsInteractorPoliceConfig>(1, InteractorCollection_PropertyAddress, CachedMarshalingDelegates<FGsInteractorPoliceConfig, FGsInteractorPoliceConfig>.FromNative, CachedMarshalingDelegates<FGsInteractorPoliceConfig, FGsInteractorPoliceConfig>.ToNative).FromNative(IntPtr.Add(nativeStruct, InteractorCollection_Offset));
			SpawnerCollection = new TArrayCopyMarshaler<FGsSpawnerPoliceConfig>(1, SpawnerCollection_PropertyAddress, CachedMarshalingDelegates<FGsSpawnerPoliceConfig, FGsSpawnerPoliceConfig>.FromNative, CachedMarshalingDelegates<FGsSpawnerPoliceConfig, FGsSpawnerPoliceConfig>.ToNative).FromNative(IntPtr.Add(nativeStruct, SpawnerCollection_Offset));
			UnitCollection = new TArrayCopyMarshaler<FGsUnitPoliceConfig>(1, UnitCollection_PropertyAddress, CachedMarshalingDelegates<FGsUnitPoliceConfig, FGsUnitPoliceConfig>.FromNative, CachedMarshalingDelegates<FGsUnitPoliceConfig, FGsUnitPoliceConfig>.ToNative).FromNative(IntPtr.Add(nativeStruct, UnitCollection_Offset));
			GroupUnitCollection = new TArrayCopyMarshaler<FGsUnitPoliceConfig>(1, GroupUnitCollection_PropertyAddress, CachedMarshalingDelegates<FGsUnitPoliceConfig, FGsUnitPoliceConfig>.FromNative, CachedMarshalingDelegates<FGsUnitPoliceConfig, FGsUnitPoliceConfig>.ToNative).FromNative(IntPtr.Add(nativeStruct, GroupUnitCollection_Offset));
			NPCUnitCollection = new TArrayCopyMarshaler<FGsNPCUnitPoliceConfig>(1, NPCUnitCollection_PropertyAddress, CachedMarshalingDelegates<FGsNPCUnitPoliceConfig, FGsNPCUnitPoliceConfig>.FromNative, CachedMarshalingDelegates<FGsNPCUnitPoliceConfig, FGsNPCUnitPoliceConfig>.ToNative).FromNative(IntPtr.Add(nativeStruct, NPCUnitCollection_Offset));
			StreamingLevelCollection = new TArrayCopyMarshaler<FGsStreamingLevelPoliceConfig>(1, StreamingLevelCollection_PropertyAddress, CachedMarshalingDelegates<FGsStreamingLevelPoliceConfig, FGsStreamingLevelPoliceConfig>.FromNative, CachedMarshalingDelegates<FGsStreamingLevelPoliceConfig, FGsStreamingLevelPoliceConfig>.ToNative).FromNative(IntPtr.Add(nativeStruct, StreamingLevelCollection_Offset));
			StreamingLevelStateConfigCollection = new TArrayCopyMarshaler<FGsStreamingLevelStateConfigPoliceConfig>(1, StreamingLevelStateConfigCollection_PropertyAddress, CachedMarshalingDelegates<FGsStreamingLevelStateConfigPoliceConfig, FGsStreamingLevelStateConfigPoliceConfig>.FromNative, CachedMarshalingDelegates<FGsStreamingLevelStateConfigPoliceConfig, FGsStreamingLevelStateConfigPoliceConfig>.ToNative).FromNative(IntPtr.Add(nativeStruct, StreamingLevelStateConfigCollection_Offset));
		}
	}

	static FGsSceneObjPoliceConfig()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGsSceneObjPoliceConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGsSceneObjPoliceConfig));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Calliope.GsSceneObjPoliceConfig");
		FGsSceneObjPoliceConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref DynamicObstacleCollection_PropertyAddress, intPtr, "DynamicObstacleCollection");
		DynamicObstacleCollection_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DynamicObstacleCollection");
		DynamicObstacleCollection_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DynamicObstacleCollection", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref OverlapCollection_PropertyAddress, intPtr, "OverlapCollection");
		OverlapCollection_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OverlapCollection");
		OverlapCollection_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OverlapCollection", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref InteractorCollection_PropertyAddress, intPtr, "InteractorCollection");
		InteractorCollection_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InteractorCollection");
		InteractorCollection_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InteractorCollection", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SpawnerCollection_PropertyAddress, intPtr, "SpawnerCollection");
		SpawnerCollection_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SpawnerCollection");
		SpawnerCollection_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SpawnerCollection", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref UnitCollection_PropertyAddress, intPtr, "UnitCollection");
		UnitCollection_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UnitCollection");
		UnitCollection_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UnitCollection", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GroupUnitCollection_PropertyAddress, intPtr, "GroupUnitCollection");
		GroupUnitCollection_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GroupUnitCollection");
		GroupUnitCollection_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GroupUnitCollection", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref NPCUnitCollection_PropertyAddress, intPtr, "NPCUnitCollection");
		NPCUnitCollection_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NPCUnitCollection");
		NPCUnitCollection_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NPCUnitCollection", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref StreamingLevelCollection_PropertyAddress, intPtr, "StreamingLevelCollection");
		StreamingLevelCollection_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StreamingLevelCollection");
		StreamingLevelCollection_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StreamingLevelCollection", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref StreamingLevelStateConfigCollection_PropertyAddress, intPtr, "StreamingLevelStateConfigCollection");
		StreamingLevelStateConfigCollection_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StreamingLevelStateConfigCollection");
		StreamingLevelStateConfigCollection_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StreamingLevelStateConfigCollection", Classes.FArrayProperty);
		FGsSceneObjPoliceConfig_IsValid = intPtr != IntPtr.Zero && DynamicObstacleCollection_IsValid && OverlapCollection_IsValid && InteractorCollection_IsValid && SpawnerCollection_IsValid && UnitCollection_IsValid && GroupUnitCollection_IsValid && NPCUnitCollection_IsValid && StreamingLevelCollection_IsValid && StreamingLevelStateConfigCollection_IsValid;
		NativeReflection.LogStructIsValid("/Script/Calliope.GsSceneObjPoliceConfig", FGsSceneObjPoliceConfig_IsValid);
	}
}
