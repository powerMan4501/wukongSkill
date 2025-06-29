using System;
using System.Collections.Generic;
using UnrealEngine.AIModule;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.SpawnWaveUnitConfig")]
public struct FSpawnWaveUnitConfig
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("生成点选点方式")]
	[USharpPath("/Script/b1-Managed.SpawnWaveUnitConfig:SpawnPointType")]
	public ESpawnPointType SpawnPointType;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.SpawnWaveUnitConfig:EQSTemplate")]
	public UEnvQuery EQSTemplate;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.SpawnWaveUnitConfig:QueryConfig")]
	public List<FGSEnvNamedValue> QueryConfig;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.SpawnWaveUnitConfig:LocalSpaceType")]
	public ESpawnWaveLocalSpaceType LocalSpaceType;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.SpawnWaveUnitConfig:LocalSpaceOffset")]
	public FVector LocalSpaceOffset;

	[VisibleAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.SpawnWaveUnitConfig:UnitType")]
	public TSubclassOf<BGUCharacterCS> UnitType;

	[UProperty]
	[EditAnywhere]
	[Tooltip("生成单位类型")]
	[BlueprintReadWrite]
	[DisplayName("生成单位类型")]
	[USharpPath("/Script/b1-Managed.SpawnWaveUnitConfig:TamerClass")]
	public TSubclassOf<BUTamerActor> TamerClass;

	[Tooltip("生成单位位置")]
	[DisplayName("生成点")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.SpawnWaveUnitConfig:SpawnPoints")]
	public List<TSoftObject<BGUBattlePaceSpawnPointActor>> SpawnPoints;

	[BlueprintReadWrite]
	[EditAnywhere]
	[Tooltip("出生Buff")]
	[UProperty]
	[DisplayName("出生Buff")]
	[USharpPath("/Script/b1-Managed.SpawnWaveUnitConfig:BirthBuff")]
	public List<int> BirthBuff;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("单位出生动画（可选）")]
	[USharpPath("/Script/b1-Managed.SpawnWaveUnitConfig:SpawnMontage")]
	public UAnimMontage SpawnMontage;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("单位出生时是否面向玩家")]
	[USharpPath("/Script/b1-Managed.SpawnWaveUnitConfig:bIsFacePlayer")]
	public bool bIsFacePlayer;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("单位出生时是否设置玩家为目标")]
	[USharpPath("/Script/b1-Managed.SpawnWaveUnitConfig:bIsCatchPlayer")]
	public bool bIsCatchPlayer;

	[UProperty]
	[VisibleAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.SpawnWaveUnitConfig:SpawnMaster")]
	public TSoftObject<BGUCharacterCS> SpawnMaster;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("单位Master（可选）")]
	[USharpPath("/Script/b1-Managed.SpawnWaveUnitConfig:MasterTamer")]
	public TSoftObject<BUTamerActor> MasterTamer;

	private static int SpawnWaveUnitConfig_StructSize;

	private static int SpawnWaveUnitConfig_IsValid;

	private static bool SpawnPointType_IsValid;

	private static int SpawnPointType_Offset;

	private static FFieldAddress SpawnPointType_PropertyAddress;

	private static bool EQSTemplate_IsValid;

	private static int EQSTemplate_Offset;

	private static bool QueryConfig_IsValid;

	private static int QueryConfig_Offset;

	private static FFieldAddress QueryConfig_PropertyAddress;

	private static bool LocalSpaceType_IsValid;

	private static int LocalSpaceType_Offset;

	private static FFieldAddress LocalSpaceType_PropertyAddress;

	private static bool LocalSpaceOffset_IsValid;

	private static int LocalSpaceOffset_Offset;

	private static bool UnitType_IsValid;

	private static int UnitType_Offset;

	private static bool TamerClass_IsValid;

	private static int TamerClass_Offset;

	private static bool SpawnPoints_IsValid;

	private static int SpawnPoints_Offset;

	private static FFieldAddress SpawnPoints_PropertyAddress;

	private static bool BirthBuff_IsValid;

	private static int BirthBuff_Offset;

	private static FFieldAddress BirthBuff_PropertyAddress;

	private static bool SpawnMontage_IsValid;

	private static int SpawnMontage_Offset;

	private static bool bIsFacePlayer_IsValid;

	private static int bIsFacePlayer_Offset;

	private static FFieldAddress bIsFacePlayer_PropertyAddress;

	private static bool bIsCatchPlayer_IsValid;

	private static int bIsCatchPlayer_Offset;

	private static FFieldAddress bIsCatchPlayer_PropertyAddress;

	private static bool SpawnMaster_IsValid;

	private static int SpawnMaster_Offset;

	private static bool MasterTamer_IsValid;

	private static int MasterTamer_Offset;

	public FSpawnWaveUnitConfig Copy()
	{
		FSpawnWaveUnitConfig result = this;
		if (QueryConfig != null)
		{
			result.QueryConfig = new List<FGSEnvNamedValue>(QueryConfig);
		}
		if (SpawnPoints != null)
		{
			result.SpawnPoints = new List<TSoftObject<BGUBattlePaceSpawnPointActor>>(SpawnPoints);
		}
		if (BirthBuff != null)
		{
			result.BirthBuff = new List<int>(BirthBuff);
		}
		return result;
	}

	public static FSpawnWaveUnitConfig FromNative(IntPtr nativeBuffer)
	{
		return new FSpawnWaveUnitConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSpawnWaveUnitConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSpawnWaveUnitConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSpawnWaveUnitConfig(IntPtr.Add(nativeBuffer, arrayIndex * SpawnWaveUnitConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSpawnWaveUnitConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * SpawnWaveUnitConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (SpawnWaveUnitConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.SpawnWaveUnitConfig");
			return;
		}
		EnumMarshaler<ESpawnPointType>.ToNative(IntPtr.Add(nativeStruct, SpawnPointType_Offset), 0, SpawnPointType_PropertyAddress.Address, SpawnPointType);
		UObjectMarshaler<UEnvQuery>.ToNative(IntPtr.Add(nativeStruct, EQSTemplate_Offset), EQSTemplate);
		new TArrayCopyMarshaler<FGSEnvNamedValue>(1, QueryConfig_PropertyAddress, CachedMarshalingDelegates<FGSEnvNamedValue, FGSEnvNamedValue>.FromNative, CachedMarshalingDelegates<FGSEnvNamedValue, FGSEnvNamedValue>.ToNative).ToNative(IntPtr.Add(nativeStruct, QueryConfig_Offset), QueryConfig);
		EnumMarshaler<ESpawnWaveLocalSpaceType>.ToNative(IntPtr.Add(nativeStruct, LocalSpaceType_Offset), 0, LocalSpaceType_PropertyAddress.Address, LocalSpaceType);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, LocalSpaceOffset_Offset), LocalSpaceOffset);
		TSubclassOfMarshaler<BGUCharacterCS>.ToNative(IntPtr.Add(nativeStruct, UnitType_Offset), UnitType);
		TSubclassOfMarshaler<BUTamerActor>.ToNative(IntPtr.Add(nativeStruct, TamerClass_Offset), TamerClass);
		new TArrayCopyMarshaler<TSoftObject<BGUBattlePaceSpawnPointActor>>(1, SpawnPoints_PropertyAddress, CachedMarshalingDelegates<TSoftObject<BGUBattlePaceSpawnPointActor>, TSoftObjectMarshaler<BGUBattlePaceSpawnPointActor>>.FromNative, CachedMarshalingDelegates<TSoftObject<BGUBattlePaceSpawnPointActor>, TSoftObjectMarshaler<BGUBattlePaceSpawnPointActor>>.ToNative).ToNative(IntPtr.Add(nativeStruct, SpawnPoints_Offset), SpawnPoints);
		new TArrayCopyMarshaler<int>(1, BirthBuff_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(nativeStruct, BirthBuff_Offset), BirthBuff);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(nativeStruct, SpawnMontage_Offset), SpawnMontage);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bIsFacePlayer_Offset), 0, bIsFacePlayer_PropertyAddress.Address, bIsFacePlayer);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bIsCatchPlayer_Offset), 0, bIsCatchPlayer_PropertyAddress.Address, bIsCatchPlayer);
		TSoftObjectMarshaler<BGUCharacterCS>.ToNative(IntPtr.Add(nativeStruct, SpawnMaster_Offset), SpawnMaster);
		TSoftObjectMarshaler<BUTamerActor>.ToNative(IntPtr.Add(nativeStruct, MasterTamer_Offset), MasterTamer);
	}

	public FSpawnWaveUnitConfig(IntPtr nativeStruct)
	{
		if (SpawnWaveUnitConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.SpawnWaveUnitConfig");
			SpawnPointType = ESpawnPointType.UseSpawnPoints;
			EQSTemplate = null;
			QueryConfig = null;
			LocalSpaceType = ESpawnWaveLocalSpaceType.LocalPlayer;
			LocalSpaceOffset = default(FVector);
			UnitType = default(TSubclassOf<BGUCharacterCS>);
			TamerClass = default(TSubclassOf<BUTamerActor>);
			SpawnPoints = null;
			BirthBuff = null;
			SpawnMontage = null;
			bIsFacePlayer = false;
			bIsCatchPlayer = false;
			SpawnMaster = default(TSoftObject<BGUCharacterCS>);
			MasterTamer = default(TSoftObject<BUTamerActor>);
		}
		else
		{
			SpawnPointType = EnumMarshaler<ESpawnPointType>.FromNative(IntPtr.Add(nativeStruct, SpawnPointType_Offset), 0, SpawnPointType_PropertyAddress.Address);
			EQSTemplate = UObjectMarshaler<UEnvQuery>.FromNative(IntPtr.Add(nativeStruct, EQSTemplate_Offset));
			QueryConfig = new TArrayCopyMarshaler<FGSEnvNamedValue>(1, QueryConfig_PropertyAddress, CachedMarshalingDelegates<FGSEnvNamedValue, FGSEnvNamedValue>.FromNative, CachedMarshalingDelegates<FGSEnvNamedValue, FGSEnvNamedValue>.ToNative).FromNative(IntPtr.Add(nativeStruct, QueryConfig_Offset));
			LocalSpaceType = EnumMarshaler<ESpawnWaveLocalSpaceType>.FromNative(IntPtr.Add(nativeStruct, LocalSpaceType_Offset), 0, LocalSpaceType_PropertyAddress.Address);
			LocalSpaceOffset = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, LocalSpaceOffset_Offset));
			UnitType = TSubclassOfMarshaler<BGUCharacterCS>.FromNative(IntPtr.Add(nativeStruct, UnitType_Offset));
			TamerClass = TSubclassOfMarshaler<BUTamerActor>.FromNative(IntPtr.Add(nativeStruct, TamerClass_Offset));
			SpawnPoints = new TArrayCopyMarshaler<TSoftObject<BGUBattlePaceSpawnPointActor>>(1, SpawnPoints_PropertyAddress, CachedMarshalingDelegates<TSoftObject<BGUBattlePaceSpawnPointActor>, TSoftObjectMarshaler<BGUBattlePaceSpawnPointActor>>.FromNative, CachedMarshalingDelegates<TSoftObject<BGUBattlePaceSpawnPointActor>, TSoftObjectMarshaler<BGUBattlePaceSpawnPointActor>>.ToNative).FromNative(IntPtr.Add(nativeStruct, SpawnPoints_Offset));
			BirthBuff = new TArrayCopyMarshaler<int>(1, BirthBuff_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(nativeStruct, BirthBuff_Offset));
			SpawnMontage = UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(nativeStruct, SpawnMontage_Offset));
			bIsFacePlayer = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bIsFacePlayer_Offset), 0, bIsFacePlayer_PropertyAddress.Address);
			bIsCatchPlayer = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bIsCatchPlayer_Offset), 0, bIsCatchPlayer_PropertyAddress.Address);
			SpawnMaster = TSoftObjectMarshaler<BGUCharacterCS>.FromNative(IntPtr.Add(nativeStruct, SpawnMaster_Offset));
			MasterTamer = TSoftObjectMarshaler<BUTamerActor>.FromNative(IntPtr.Add(nativeStruct, MasterTamer_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.SpawnWaveUnitConfig");
		SpawnWaveUnitConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref SpawnPointType_PropertyAddress, intPtr, "SpawnPointType");
		SpawnPointType_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpawnPointType");
		SpawnPointType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpawnPointType", Classes.FEnumProperty);
		EQSTemplate_Offset = NativeReflection.GetPropertyOffset(intPtr, "EQSTemplate");
		EQSTemplate_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EQSTemplate", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref QueryConfig_PropertyAddress, intPtr, "QueryConfig");
		QueryConfig_Offset = NativeReflection.GetPropertyOffset(intPtr, "QueryConfig");
		QueryConfig_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "QueryConfig", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref LocalSpaceType_PropertyAddress, intPtr, "LocalSpaceType");
		LocalSpaceType_Offset = NativeReflection.GetPropertyOffset(intPtr, "LocalSpaceType");
		LocalSpaceType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LocalSpaceType", Classes.FEnumProperty);
		LocalSpaceOffset_Offset = NativeReflection.GetPropertyOffset(intPtr, "LocalSpaceOffset");
		LocalSpaceOffset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LocalSpaceOffset", Classes.FStructProperty);
		UnitType_Offset = NativeReflection.GetPropertyOffset(intPtr, "UnitType");
		UnitType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UnitType", Classes.FClassProperty);
		TamerClass_Offset = NativeReflection.GetPropertyOffset(intPtr, "TamerClass");
		TamerClass_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TamerClass", Classes.FClassProperty);
		NativeReflection.GetPropertyRef(ref SpawnPoints_PropertyAddress, intPtr, "SpawnPoints");
		SpawnPoints_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpawnPoints");
		SpawnPoints_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpawnPoints", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref BirthBuff_PropertyAddress, intPtr, "BirthBuff");
		BirthBuff_Offset = NativeReflection.GetPropertyOffset(intPtr, "BirthBuff");
		BirthBuff_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BirthBuff", Classes.FArrayProperty);
		SpawnMontage_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpawnMontage");
		SpawnMontage_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpawnMontage", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref bIsFacePlayer_PropertyAddress, intPtr, "bIsFacePlayer");
		bIsFacePlayer_Offset = NativeReflection.GetPropertyOffset(intPtr, "bIsFacePlayer");
		bIsFacePlayer_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bIsFacePlayer", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bIsCatchPlayer_PropertyAddress, intPtr, "bIsCatchPlayer");
		bIsCatchPlayer_Offset = NativeReflection.GetPropertyOffset(intPtr, "bIsCatchPlayer");
		bIsCatchPlayer_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bIsCatchPlayer", Classes.FBoolProperty);
		SpawnMaster_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpawnMaster");
		SpawnMaster_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpawnMaster", Classes.FSoftObjectProperty);
		MasterTamer_Offset = NativeReflection.GetPropertyOffset(intPtr, "MasterTamer");
		MasterTamer_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MasterTamer", Classes.FSoftObjectProperty);
		SpawnWaveUnitConfig_IsValid = ((intPtr != IntPtr.Zero && SpawnPointType_IsValid && EQSTemplate_IsValid && QueryConfig_IsValid && LocalSpaceType_IsValid && LocalSpaceOffset_IsValid && UnitType_IsValid && TamerClass_IsValid && SpawnPoints_IsValid && BirthBuff_IsValid && SpawnMontage_IsValid && bIsFacePlayer_IsValid && bIsCatchPlayer_IsValid && SpawnMaster_IsValid && MasterTamer_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.SpawnWaveUnitConfig", (byte)SpawnWaveUnitConfig_IsValid != 0);
	}

	static FSpawnWaveUnitConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FSpawnWaveUnitConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSpawnWaveUnitConfig));
	}
}
