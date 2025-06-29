using System;
using b1.Plugins.Calliope;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.SummonReq")]
public struct FSummonReq
{
	[UProperty]
	[USharpPath("/Script/b1-Managed.SummonReq:SummonType")]
	public ESummonType SummonType;

	[UProperty]
	[USharpPath("/Script/b1-Managed.SummonReq:SummonGuid")]
	public FCalliopeGuid SummonGuid;

	[UProperty]
	[USharpPath("/Script/b1-Managed.SummonReq:SummonID")]
	public int SummonID;

	[UProperty]
	[USharpPath("/Script/b1-Managed.SummonReq:SummonCount")]
	public int SummonCount;

	[UProperty]
	[USharpPath("/Script/b1-Managed.SummonReq:Summoner")]
	public AActor Summoner;

	[UProperty]
	[USharpPath("/Script/b1-Managed.SummonReq:bTeleportSelf")]
	public bool bTeleportSelf;

	[UProperty]
	[USharpPath("/Script/b1-Managed.SummonReq:bConfuseSelf")]
	public bool bConfuseSelf;

	[UProperty]
	[USharpPath("/Script/b1-Managed.SummonReq:EffectCaster")]
	public AActor EffectCaster;

	[UProperty]
	[USharpPath("/Script/b1-Managed.SummonReq:BuffOwner")]
	public AActor BuffOwner;

	[UProperty]
	[USharpPath("/Script/b1-Managed.SummonReq:HitLocation")]
	public FVector HitLocation;

	[UProperty]
	[USharpPath("/Script/b1-Managed.SummonReq:SpawnPointRot")]
	public FRotator SpawnPointRot;

	[UProperty]
	[USharpPath("/Script/b1-Managed.SummonReq:ContinueBehaviorInfo")]
	public FContinueBehaviorInfo ContinueBehaviorInfo;

	[UProperty]
	[USharpPath("/Script/b1-Managed.SummonReq:bUseContinuousRefresh")]
	public bool bUseContinuousRefresh;

	[UProperty]
	[USharpPath("/Script/b1-Managed.SummonReq:SpawnConfigWrap")]
	public FSummonSpawnConfigWrap SpawnConfigWrap;

	private static int SummonReq_StructSize;

	private static int SummonReq_IsValid;

	private static bool SummonType_IsValid;

	private static int SummonType_Offset;

	private static FFieldAddress SummonType_PropertyAddress;

	private static bool SummonGuid_IsValid;

	private static int SummonGuid_Offset;

	private static bool SummonID_IsValid;

	private static int SummonID_Offset;

	private static bool SummonCount_IsValid;

	private static int SummonCount_Offset;

	private static bool Summoner_IsValid;

	private static int Summoner_Offset;

	private static bool bTeleportSelf_IsValid;

	private static int bTeleportSelf_Offset;

	private static FFieldAddress bTeleportSelf_PropertyAddress;

	private static bool bConfuseSelf_IsValid;

	private static int bConfuseSelf_Offset;

	private static FFieldAddress bConfuseSelf_PropertyAddress;

	private static bool EffectCaster_IsValid;

	private static int EffectCaster_Offset;

	private static bool BuffOwner_IsValid;

	private static int BuffOwner_Offset;

	private static bool HitLocation_IsValid;

	private static int HitLocation_Offset;

	private static bool SpawnPointRot_IsValid;

	private static int SpawnPointRot_Offset;

	private static bool ContinueBehaviorInfo_IsValid;

	private static int ContinueBehaviorInfo_Offset;

	private static bool bUseContinuousRefresh_IsValid;

	private static int bUseContinuousRefresh_Offset;

	private static FFieldAddress bUseContinuousRefresh_PropertyAddress;

	private static bool SpawnConfigWrap_IsValid;

	private static int SpawnConfigWrap_Offset;

	public FSummonReq Copy()
	{
		return this;
	}

	public static FSummonReq FromNative(IntPtr nativeBuffer)
	{
		return new FSummonReq(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSummonReq value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSummonReq FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSummonReq(IntPtr.Add(nativeBuffer, arrayIndex * SummonReq_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSummonReq value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * SummonReq_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (SummonReq_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.SummonReq");
			return;
		}
		EnumMarshaler<ESummonType>.ToNative(IntPtr.Add(nativeStruct, SummonType_Offset), 0, SummonType_PropertyAddress.Address, SummonType);
		FCalliopeGuid.ToNative(IntPtr.Add(nativeStruct, SummonGuid_Offset), SummonGuid);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, SummonID_Offset), SummonID);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, SummonCount_Offset), SummonCount);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(nativeStruct, Summoner_Offset), Summoner);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bTeleportSelf_Offset), 0, bTeleportSelf_PropertyAddress.Address, bTeleportSelf);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bConfuseSelf_Offset), 0, bConfuseSelf_PropertyAddress.Address, bConfuseSelf);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(nativeStruct, EffectCaster_Offset), EffectCaster);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(nativeStruct, BuffOwner_Offset), BuffOwner);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, HitLocation_Offset), HitLocation);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(nativeStruct, SpawnPointRot_Offset), SpawnPointRot);
		FContinueBehaviorInfo.ToNative(IntPtr.Add(nativeStruct, ContinueBehaviorInfo_Offset), ContinueBehaviorInfo);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bUseContinuousRefresh_Offset), 0, bUseContinuousRefresh_PropertyAddress.Address, bUseContinuousRefresh);
		FSummonSpawnConfigWrap.ToNative(IntPtr.Add(nativeStruct, SpawnConfigWrap_Offset), SpawnConfigWrap);
	}

	public FSummonReq(IntPtr nativeStruct)
	{
		if (SummonReq_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.SummonReq");
			SummonType = ESummonType.Normal;
			SummonGuid = default(FCalliopeGuid);
			SummonID = 0;
			SummonCount = 0;
			Summoner = null;
			bTeleportSelf = false;
			bConfuseSelf = false;
			EffectCaster = null;
			BuffOwner = null;
			HitLocation = default(FVector);
			SpawnPointRot = default(FRotator);
			ContinueBehaviorInfo = default(FContinueBehaviorInfo);
			bUseContinuousRefresh = false;
			SpawnConfigWrap = default(FSummonSpawnConfigWrap);
		}
		else
		{
			SummonType = EnumMarshaler<ESummonType>.FromNative(IntPtr.Add(nativeStruct, SummonType_Offset), 0, SummonType_PropertyAddress.Address);
			SummonGuid = FCalliopeGuid.FromNative(IntPtr.Add(nativeStruct, SummonGuid_Offset));
			SummonID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, SummonID_Offset));
			SummonCount = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, SummonCount_Offset));
			Summoner = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(nativeStruct, Summoner_Offset));
			bTeleportSelf = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bTeleportSelf_Offset), 0, bTeleportSelf_PropertyAddress.Address);
			bConfuseSelf = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bConfuseSelf_Offset), 0, bConfuseSelf_PropertyAddress.Address);
			EffectCaster = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(nativeStruct, EffectCaster_Offset));
			BuffOwner = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(nativeStruct, BuffOwner_Offset));
			HitLocation = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, HitLocation_Offset));
			SpawnPointRot = BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(nativeStruct, SpawnPointRot_Offset));
			ContinueBehaviorInfo = FContinueBehaviorInfo.FromNative(IntPtr.Add(nativeStruct, ContinueBehaviorInfo_Offset));
			bUseContinuousRefresh = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bUseContinuousRefresh_Offset), 0, bUseContinuousRefresh_PropertyAddress.Address);
			SpawnConfigWrap = FSummonSpawnConfigWrap.FromNative(IntPtr.Add(nativeStruct, SpawnConfigWrap_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.SummonReq");
		SummonReq_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref SummonType_PropertyAddress, intPtr, "SummonType");
		SummonType_Offset = NativeReflection.GetPropertyOffset(intPtr, "SummonType");
		SummonType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SummonType", Classes.FEnumProperty);
		SummonGuid_Offset = NativeReflection.GetPropertyOffset(intPtr, "SummonGuid");
		SummonGuid_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SummonGuid", Classes.FStructProperty);
		SummonID_Offset = NativeReflection.GetPropertyOffset(intPtr, "SummonID");
		SummonID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SummonID", Classes.FIntProperty);
		SummonCount_Offset = NativeReflection.GetPropertyOffset(intPtr, "SummonCount");
		SummonCount_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SummonCount", Classes.FIntProperty);
		Summoner_Offset = NativeReflection.GetPropertyOffset(intPtr, "Summoner");
		Summoner_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Summoner", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref bTeleportSelf_PropertyAddress, intPtr, "bTeleportSelf");
		bTeleportSelf_Offset = NativeReflection.GetPropertyOffset(intPtr, "bTeleportSelf");
		bTeleportSelf_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bTeleportSelf", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bConfuseSelf_PropertyAddress, intPtr, "bConfuseSelf");
		bConfuseSelf_Offset = NativeReflection.GetPropertyOffset(intPtr, "bConfuseSelf");
		bConfuseSelf_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bConfuseSelf", Classes.FBoolProperty);
		EffectCaster_Offset = NativeReflection.GetPropertyOffset(intPtr, "EffectCaster");
		EffectCaster_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EffectCaster", Classes.FObjectProperty);
		BuffOwner_Offset = NativeReflection.GetPropertyOffset(intPtr, "BuffOwner");
		BuffOwner_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BuffOwner", Classes.FObjectProperty);
		HitLocation_Offset = NativeReflection.GetPropertyOffset(intPtr, "HitLocation");
		HitLocation_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "HitLocation", Classes.FStructProperty);
		SpawnPointRot_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpawnPointRot");
		SpawnPointRot_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpawnPointRot", Classes.FStructProperty);
		ContinueBehaviorInfo_Offset = NativeReflection.GetPropertyOffset(intPtr, "ContinueBehaviorInfo");
		ContinueBehaviorInfo_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ContinueBehaviorInfo", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref bUseContinuousRefresh_PropertyAddress, intPtr, "bUseContinuousRefresh");
		bUseContinuousRefresh_Offset = NativeReflection.GetPropertyOffset(intPtr, "bUseContinuousRefresh");
		bUseContinuousRefresh_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bUseContinuousRefresh", Classes.FBoolProperty);
		SpawnConfigWrap_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpawnConfigWrap");
		SpawnConfigWrap_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpawnConfigWrap", Classes.FStructProperty);
		SummonReq_IsValid = ((intPtr != IntPtr.Zero && SummonType_IsValid && SummonGuid_IsValid && SummonID_IsValid && SummonCount_IsValid && Summoner_IsValid && bTeleportSelf_IsValid && bConfuseSelf_IsValid && EffectCaster_IsValid && BuffOwner_IsValid && HitLocation_IsValid && SpawnPointRot_IsValid && ContinueBehaviorInfo_IsValid && bUseContinuousRefresh_IsValid && SpawnConfigWrap_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.SummonReq", (byte)SummonReq_IsValid != 0);
	}

	static FSummonReq()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FSummonReq)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSummonReq));
	}
}
