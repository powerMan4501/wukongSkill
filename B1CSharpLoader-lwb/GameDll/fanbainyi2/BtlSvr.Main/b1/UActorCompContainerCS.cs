using System;
using System.Collections.Generic;
using b1.BGW;
using b1.ECS;
using b1.GameState;
using b1.Profile;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.ActorCompContainerCS")]
public class UActorCompContainerCS : UBaseActorComp
{
	public bool bHasCacheData;

	public AActor Owner;

	public Entity Entity;

	private Chunk EntityChunk;

	private int EntityIndexInChunk;

	public BGW_ECSWorld ECSWorld;

	public BGW_PauseGameMgr PauseGameMgr;

	public BGS_GSEventCollection BGSEventCollection;

	public BGW_EventCollection BGWEventCollection;

	public BUS_GSEventCollection BUSEventCollection;

	public IBUC_TickRateData TickRateData;

	public BGW_PreloadAssetMgr PreloadAssetMgr;

	public BGGGameStateB1 GameState;

	protected List<UActorCompBaseUObj> Comps = new List<UActorCompBaseUObj>();

	protected List<UActorCompBaseCS> CompCSs = new List<UActorCompBaseCS>();

	protected List<UActorCompBaseUObj> CompsToBeginPlay = new List<UActorCompBaseUObj>();

	protected List<UActorCompBaseCS> CompCSsToBeginPlay = new List<UActorCompBaseCS>();

	public bool HasBeginPlay;

	public bool HasLateBeginPlay;

	private const bool bDisableUnitCompFlagFilter = false;

	private const bool bEnableCompForTest = true;

	private int OwnerRole;

	public int OwnerNetRole;

	private static bool CompsRef_IsValid;

	private static int CompsRef_Offset;

	private static FFieldAddress CompsRef_PropertyAddress;

	private TArrayReadWriteMarshaler<UActorCompBaseUObj> CompsRef_Marshaler;

	private static bool bUserForUnit_IsValid;

	private static int bUserForUnit_Offset;

	private static FFieldAddress bUserForUnit_PropertyAddress;

	private static bool EndPlayInCS_IsValid;

	private static IntPtr EndPlayInCS_FunctionAddress;

	private static int EndPlayInCS_ParamsSize;

	private static bool EndPlayInCS_EndPlayReason_IsValid;

	private static int EndPlayInCS_EndPlayReason_Offset;

	private static FFieldAddress EndPlayInCS_EndPlayReason_PropertyAddress;

	private static bool ApplyWorldOffsetCS_IsValid;

	private static IntPtr ApplyWorldOffsetCS_FunctionAddress;

	private static int ApplyWorldOffsetCS_ParamsSize;

	private static bool ApplyWorldOffsetCS_InOffset_IsValid;

	private static int ApplyWorldOffsetCS_InOffset_Offset;

	private static FFieldAddress ApplyWorldOffsetCS_InOffset_PropertyAddress;

	private static bool ApplyWorldOffsetCS_bWorldShift_IsValid;

	private static int ApplyWorldOffsetCS_bWorldShift_Offset;

	private static FFieldAddress ApplyWorldOffsetCS_bWorldShift_PropertyAddress;

	[UProperty(Flags = PropFlags.Transient)]
	[USharpPath("/Script/b1-Managed.ActorCompContainerCS:CompsRef")]
	private TArrayReadWrite<UActorCompBaseUObj> CompsRef
	{
		get
		{
			CheckDestroyed();
			if (!CompsRef_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.ActorCompContainerCS:CompsRef");
				return null;
			}
			if (CompsRef_Marshaler == null)
			{
				CompsRef_Marshaler = new TArrayReadWriteMarshaler<UActorCompBaseUObj>(1, CompsRef_PropertyAddress, CachedMarshalingDelegates<UActorCompBaseUObj, UObjectMarshaler<UActorCompBaseUObj>>.FromNative, CachedMarshalingDelegates<UActorCompBaseUObj, UObjectMarshaler<UActorCompBaseUObj>>.ToNative);
			}
			return CompsRef_Marshaler.FromNative(IntPtr.Add(base.Address, CompsRef_Offset));
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.ActorCompContainerCS:bUserForUnit")]
	public bool bUserForUnit
	{
		get
		{
			CheckDestroyed();
			if (!bUserForUnit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.ActorCompContainerCS:bUserForUnit");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bUserForUnit_Offset), 0, bUserForUnit_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bUserForUnit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.ActorCompContainerCS:bUserForUnit");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bUserForUnit_Offset), 0, bUserForUnit_PropertyAddress.Address, value);
			}
		}
	}

	private EUnitTagType UnitTemplateType { get; set; }

	private int NeedRule { get; set; }

	private int AlterRule { get; set; }

	private int OnlyTestRule { get; set; }

	private EActorCompAlterFlag AlterTags { get; set; }

	private EActorCompRejectFlag RejectTags { get; set; }

	private int CompCount { get; set; }

	private int ProjectileExtAbilityMask { get; set; }

	private int ProjectileDiableAbilityMask { get; set; }

	public void InitCacheData()
	{
		Owner = GetOwner();
		if (Owner is IECSWorldObj iECSWorldObj)
		{
			Entity = iECSWorldObj.ECSEntity;
		}
		if (!Entity.IsNull())
		{
			bHasCacheData = true;
			ECSWorld = BGW_ECSWorld.Get(Owner);
			if (!Entity.IsNull())
			{
				EntityChunk = ECSWorld.GetEntityChunk(Entity);
				EntityIndexInChunk = Entity.IndexInChunk;
			}
			PauseGameMgr = BGW_PauseGameMgr.Get(Owner);
			BGSEventCollection = BGS_GSEventCollection.Get(Owner);
			BGWEventCollection = BGW_EventCollection.Get(Owner);
			BUSEventCollection = BUS_EventCollectionCS.Get(Owner);
			TickRateData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_TickRateData>(Owner);
			PreloadAssetMgr = BGW_PreloadAssetMgr.Get(Owner);
			GameState = UGameplayStatics.GetGameState(Owner) as BGGGameStateB1;
		}
	}

	public object GetDataByEntityChunk(int TypeIndex, Entity Ent)
	{
		if (EntityChunk == null)
		{
			if (Ent.IsNull())
			{
				return null;
			}
			return BGU_DataUtil.GetUnPersistentReadOnlyData(Ent, TypeIndex);
		}
		return EntityChunk.GetObjectOrDataSafe(TypeIndex, EntityIndexInChunk);
	}

	public T AddCompDo<T>(T NewComp) where T : UActorCompBaseCS
	{
		if (!bHasCacheData)
		{
			InitCacheData();
		}
		if (ECSWorld == null)
		{
			return null;
		}
		NewComp.Init(this);
		CompCSs.Add(NewComp);
		CompCSsToBeginPlay.Add(NewComp);
		if (GSE_ProfileUtil.sOpenProfiler)
		{
			_ = GSE_ProfileUtil.sOpenProfileBeginPlay;
		}
		NewComp.OnAttach();
		if (GSE_ProfileUtil.sOpenProfiler)
		{
			_ = GSE_ProfileUtil.sOpenProfileBeginPlay;
		}
		ECSWorld.SetObject(Entity, TypeManager.GetTypeIndex<T>(), NewComp);
		return NewComp;
	}

	protected int GetOwnerRole()
	{
		if (OwnerRole == 0)
		{
			OwnerRole = BGUFuncLibReplication.GetActorNetRole(GetOwner());
		}
		return OwnerRole;
	}

	public T AddComp<T>(T NewComp, int NetRole = int.MaxValue, int RejectNetRoleFilter = 0) where T : UActorCompBaseCS
	{
		int ownerRole = GetOwnerRole();
		NewComp.NetRoleFilter = NetRole;
		NewComp.RejectNetRoleFilter = RejectNetRoleFilter;
		NewComp.OwnerNetRole = ownerRole;
		return AddCompDo(NewComp);
	}

	public void InitialCompSet(EUnitTagType InUnitTemplateType, EActorCompAlterFlag InAlterTags, EActorCompRejectFlag InRejectTags)
	{
		UnitTemplateType = InUnitTemplateType;
		AlterTags = InAlterTags;
		RejectTags = InRejectTags;
		switch (InUnitTemplateType)
		{
		case EUnitTagType.NormalMonster:
			NeedRule = 557056;
			AlterRule = 278528;
			OnlyTestRule = 139264;
			break;
		case EUnitTagType.SmallMonster:
			NeedRule = 524288;
			AlterRule = 262144;
			OnlyTestRule = 131072;
			break;
		case EUnitTagType.Boss:
			NeedRule = 32768;
			AlterRule = 16384;
			OnlyTestRule = 8192;
			break;
		case EUnitTagType.Wukong:
			NeedRule = int.MinValue;
			AlterRule = 1073741824;
			OnlyTestRule = 536870912;
			break;
		case EUnitTagType.ClonedWukong:
			NeedRule = 8388608;
			AlterRule = 4194304;
			OnlyTestRule = 2097152;
			break;
		case EUnitTagType.TransitionPlayer:
			NeedRule = 134217728;
			AlterRule = 67108864;
			OnlyTestRule = 33554432;
			break;
		case EUnitTagType.JSDS:
			NeedRule = 8421376;
			AlterRule = 4210688;
			OnlyTestRule = 2105344;
			break;
		case EUnitTagType.YangJian:
			NeedRule = 8421376;
			AlterRule = 4210688;
			OnlyTestRule = 2105344;
			break;
		}
		CompCount = 0;
	}

	public void InitialCompSet_Projectile(int _ProjectileExtAbilityMask, int _ProjectileDiableAbilityMask)
	{
		ProjectileExtAbilityMask = _ProjectileExtAbilityMask;
		ProjectileDiableAbilityMask = _ProjectileDiableAbilityMask;
	}

	public bool CheckCanAddComp(int UnitAddRule = -2004320256, EActorCompAlterFlag CompAlterTags = (EActorCompAlterFlag)0L, EActorCompRejectFlag CompRejectTags = (EActorCompRejectFlag)0L, int NetRoleFilter = int.MaxValue, int RejectNetRoleFilter = 0)
	{
		if (((UnitAddRule & NeedRule) != 0 && (CompRejectTags & RejectTags) == (EActorCompRejectFlag)0L) || ((UnitAddRule & AlterRule) != 0 && (CompAlterTags & AlterTags) != (EActorCompAlterFlag)0L) || (UnitAddRule & OnlyTestRule) != 0)
		{
			return true;
		}
		return false;
	}

	public T RegisterUnitComp<T>(int UnitAddRule = -2004320256, EActorCompAlterFlag CompAlterTags = (EActorCompAlterFlag)0L, EActorCompRejectFlag CompRejectTags = (EActorCompRejectFlag)0L, int NetRoleFilter = int.MaxValue, int RejectNetRoleFilter = 0) where T : UActorCompBaseCS, new()
	{
		if (CheckCanAddComp(UnitAddRule, CompAlterTags, CompRejectTags, NetRoleFilter, RejectNetRoleFilter))
		{
			T newComp = new T();
			return AddComp(newComp, NetRoleFilter, RejectNetRoleFilter);
		}
		return null;
	}

	public T RegisterUnitCompUObj<T>(int UnitAddRule = -2004320256, EActorCompAlterFlag CompAlterTags = (EActorCompAlterFlag)0L, EActorCompRejectFlag CompRejectTags = (EActorCompRejectFlag)0L, int NetRoleFilter = int.MaxValue, int RejectNetRoleFilter = 0) where T : UActorCompBaseUObj
	{
		if (CheckCanAddComp(UnitAddRule, CompAlterTags, CompRejectTags, NetRoleFilter, RejectNetRoleFilter))
		{
			return AddCompUObj<T>(NetRoleFilter, RejectNetRoleFilter);
		}
		return null;
	}

	public T RegisterProjectileComp<T>(EProjectileAbilityType ProjectileAbilityType = EProjectileAbilityType.Default, EProjectileDisableAbilityType DisableAbilityType = EProjectileDisableAbilityType.Default, int NetRoleFilter = int.MaxValue, int RejectNetRoleFilter = 0) where T : UActorCompBaseCS, new()
	{
		if (ProjectileAbilityType == EProjectileAbilityType.Default || ((uint)ProjectileAbilityType & (uint)ProjectileExtAbilityMask) != 0)
		{
			if (DisableAbilityType != EProjectileDisableAbilityType.Default && ((uint)ProjectileAbilityType & (uint)ProjectileDiableAbilityMask) != 0)
			{
				return null;
			}
			T newComp = new T();
			return AddComp(newComp, NetRoleFilter, RejectNetRoleFilter);
		}
		return null;
	}

	public T RegisterProjectileCompUObj<T>(EProjectileAbilityType ProjectileAbilityType = EProjectileAbilityType.Default, EProjectileDisableAbilityType DisableAbilityType = EProjectileDisableAbilityType.Default, int NetRoleFilter = int.MaxValue, int RejectNetRoleFilter = 0) where T : UActorCompBaseUObj
	{
		if (ProjectileAbilityType == EProjectileAbilityType.Default || ((uint)ProjectileAbilityType & (uint)ProjectileExtAbilityMask) != 0)
		{
			if (DisableAbilityType != EProjectileDisableAbilityType.Default && ((uint)DisableAbilityType & (uint)ProjectileDiableAbilityMask) != 0)
			{
				return null;
			}
			return AddCompUObj<T>(NetRoleFilter, RejectNetRoleFilter);
		}
		return null;
	}

	public T AddCompUObjDo<T>(T NewComp) where T : UActorCompBaseUObj
	{
		if (!bHasCacheData)
		{
			InitCacheData();
		}
		if (ECSWorld == null)
		{
			return null;
		}
		if (GSE_ProfileUtil.sOpenProfiler)
		{
			_ = GSE_ProfileUtil.sOpenProfileBeginPlay;
		}
		if (GSE_ProfileUtil.sOpenProfiler)
		{
			_ = GSE_ProfileUtil.sOpenProfileBeginPlay;
		}
		NewComp.Init(this);
		CompsRef.Add(NewComp);
		Comps.Add(NewComp);
		CompsToBeginPlay.Add(NewComp);
		if (GSE_ProfileUtil.sOpenProfiler)
		{
			_ = GSE_ProfileUtil.sOpenProfileBeginPlay;
		}
		NewComp.OnAttach();
		if (GSE_ProfileUtil.sOpenProfiler)
		{
			_ = GSE_ProfileUtil.sOpenProfileBeginPlay;
		}
		ECSWorld.SetObject(Entity, TypeManager.GetTypeIndex<T>(), NewComp);
		return NewComp;
	}

	public void FreshActorNetRole(int NewActorRole)
	{
		int count = Comps.Count;
		int count2 = CompCSs.Count;
		OwnerNetRole = NewActorRole;
		for (int i = 0; i < count; i++)
		{
			bool flag = Comps[i].IsNetActive();
			Comps[i].OwnerNetRole = NewActorRole;
			if (HasLateBeginPlay && flag != Comps[i].IsNetActive())
			{
				if (flag)
				{
					Comps[i].OnNetDeActive();
				}
				else
				{
					Comps[i].OnNetActive();
				}
			}
		}
		for (int j = 0; j < count2; j++)
		{
			bool flag2 = CompCSs[j].IsNetActive();
			CompCSs[j].OwnerNetRole = NewActorRole;
			if (HasLateBeginPlay && flag2 != CompCSs[j].IsNetActive())
			{
				if (flag2)
				{
					CompCSs[j].OnNetDeActive();
				}
				else
				{
					CompCSs[j].OnNetActive();
				}
			}
		}
		RecalculateCanTick();
	}

	public T AddCompUObj<T>(int NetRoleFilter = int.MaxValue, int RejectNetRoleFilter = 0) where T : UActorCompBaseUObj
	{
		int ownerRole = GetOwnerRole();
		T val = UObject.NewObject<T>(this);
		val.NetRoleFilter = NetRoleFilter;
		val.OwnerNetRole = ownerRole;
		val.RejectNetRoleFilter = RejectNetRoleFilter;
		AddCompUObjDo(val);
		return val;
	}

	public void PreCallECSCompBeginPlay()
	{
		HasBeginPlay = true;
	}

	public void CallECSCompPreBeginPlay()
	{
		int count = CompsToBeginPlay.Count;
		int count2 = CompCSsToBeginPlay.Count;
		for (int i = 0; i < count; i++)
		{
			if (GSE_ProfileUtil.sOpenProfiler)
			{
				_ = GSE_ProfileUtil.sOpenProfileBeginPlay;
			}
			CompsToBeginPlay[i].PreBeginPlay();
			if (GSE_ProfileUtil.sOpenProfiler)
			{
				_ = GSE_ProfileUtil.sOpenProfileBeginPlay;
			}
		}
		for (int j = 0; j < count2; j++)
		{
			if (GSE_ProfileUtil.sOpenProfiler)
			{
				_ = GSE_ProfileUtil.sOpenProfileBeginPlay;
			}
			CompCSsToBeginPlay[j].PreBeginPlay();
			if (GSE_ProfileUtil.sOpenProfiler)
			{
				_ = GSE_ProfileUtil.sOpenProfileBeginPlay;
			}
		}
	}

	public void CallECSCompBeginPlay()
	{
		int count = CompsToBeginPlay.Count;
		int count2 = CompCSsToBeginPlay.Count;
		for (int i = 0; i < count2; i++)
		{
			if (GSE_ProfileUtil.sOpenProfiler)
			{
				_ = GSE_ProfileUtil.sOpenProfileBeginPlay;
			}
			CompCSsToBeginPlay[i].OnBeginPlay();
			if (CompCSsToBeginPlay[i].IsNetActive())
			{
				CompCSsToBeginPlay[i].OnNetActive();
			}
			else
			{
				CompCSsToBeginPlay[i].OnNetDeActive();
			}
			if (GSE_ProfileUtil.sOpenProfiler)
			{
				_ = GSE_ProfileUtil.sOpenProfileBeginPlay;
			}
		}
		for (int j = 0; j < count; j++)
		{
			if (GSE_ProfileUtil.sOpenProfiler)
			{
				_ = GSE_ProfileUtil.sOpenProfileBeginPlay;
			}
			CompsToBeginPlay[j].OnBeginPlay();
			if (CompsToBeginPlay[j].IsNetActive())
			{
				CompsToBeginPlay[j].OnNetActive();
			}
			else
			{
				CompsToBeginPlay[j].OnNetDeActive();
			}
			if (GSE_ProfileUtil.sOpenProfiler)
			{
				_ = GSE_ProfileUtil.sOpenProfileBeginPlay;
			}
		}
		RecalculateCanTick();
	}

	public void CallECSCompLateBeginPlay()
	{
		int count = CompsToBeginPlay.Count;
		int count2 = CompCSsToBeginPlay.Count;
		for (int i = 0; i < count2; i++)
		{
			if (GSE_ProfileUtil.sOpenProfiler)
			{
				_ = GSE_ProfileUtil.sOpenProfileBeginPlay;
			}
			CompCSsToBeginPlay[i].LateBeginPlay();
			if (GSE_ProfileUtil.sOpenProfiler)
			{
				_ = GSE_ProfileUtil.sOpenProfileBeginPlay;
			}
		}
		for (int j = 0; j < count; j++)
		{
			if (GSE_ProfileUtil.sOpenProfiler)
			{
				_ = GSE_ProfileUtil.sOpenProfileBeginPlay;
			}
			CompsToBeginPlay[j].LateBeginPlay();
			if (GSE_ProfileUtil.sOpenProfiler)
			{
				_ = GSE_ProfileUtil.sOpenProfileBeginPlay;
			}
		}
		CompsToBeginPlay.Clear();
		CompCSsToBeginPlay.Clear();
		HasLateBeginPlay = true;
		SetAllCompCanTick(CanTick: true);
	}

	public void RecalculateCanTick()
	{
		int count = Comps.Count;
		int count2 = CompCSs.Count;
		for (int i = 0; i < count; i++)
		{
			Comps[i].RecalculateCanTick();
		}
		for (int j = 0; j < count2; j++)
		{
			CompCSs[j].RecalculateCanTick();
		}
	}

	public void SetAllCompCanTick(bool CanTick)
	{
		RecalculateCanTick();
	}

	public void SetAllCompCustomTimeDilation(float CustomTimeDilation)
	{
		int count = Comps.Count;
		int count2 = CompCSs.Count;
		for (int i = 0; i < count; i++)
		{
			Comps[i].SetCustomTimeDilation(CustomTimeDilation);
		}
		for (int j = 0; j < count2; j++)
		{
			CompCSs[j].SetCustomTimeDilation(CustomTimeDilation);
		}
	}

	[USharpPath("/Script/b1-Managed.ActorCompContainerCS:EndPlayInCS")]
	protected override void EndPlayInCS_Implementation(EEndPlayReason EndPlayReason)
	{
		int count = Comps.Count;
		for (int i = 0; i < count; i++)
		{
			if (Comps[i].IsNetActive())
			{
				Comps[i].OnNetDeActive();
			}
			Comps[i].OnEndPlay(EndPlayReason);
		}
		int count2 = CompCSs.Count;
		for (int j = 0; j < count2; j++)
		{
			if (CompCSs[j].IsNetActive())
			{
				CompCSs[j].OnNetDeActive();
			}
			CompCSs[j].OnEndPlay(EndPlayReason);
		}
		HasBeginPlay = false;
		HasLateBeginPlay = false;
		SetAllCompCanTick(CanTick: false);
		Comps.Clear();
		CompCSs.Clear();
		CompsRef.Clear();
		CompCSsToBeginPlay.Clear();
		CompsToBeginPlay.Clear();
		ECSWorld = null;
		Entity = Entity.Null;
		EntityChunk = null;
		EntityIndexInChunk = 0;
		Owner = null;
		bHasCacheData = false;
	}

	[USharpPath("/Script/b1-Managed.ActorCompContainerCS:ApplyWorldOffsetCS")]
	protected override void ApplyWorldOffsetCS_Implementation(FVector InOffset, bool bWorldShift)
	{
		int count = Comps.Count;
		for (int i = 0; i < count; i++)
		{
			Comps[i].ApplyWorldOffset(InOffset, bWorldShift);
		}
		int count2 = CompCSs.Count;
		for (int j = 0; j < count2; j++)
		{
			CompCSs[j].ApplyWorldOffset(InOffset, bWorldShift);
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.ActorCompContainerCS:EndPlayInCS")]
	private static void EndPlayInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		UActorCompContainerCS uActorCompContainerCS = GCHelper.Find<UActorCompContainerCS>(obj);
		EEndPlayReason endPlayReason = EnumMarshaler<EEndPlayReason>.FromNative(IntPtr.Add(buffer, EndPlayInCS_EndPlayReason_Offset), 0, EndPlayInCS_EndPlayReason_PropertyAddress.Address);
		uActorCompContainerCS.EndPlayInCS_Implementation(endPlayReason);
	}

	[UFunctionInvoker("/Script/b1-Managed.ActorCompContainerCS:ApplyWorldOffsetCS")]
	private static void ApplyWorldOffsetCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		UActorCompContainerCS uActorCompContainerCS = GCHelper.Find<UActorCompContainerCS>(obj);
		FVector inOffset = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(buffer, ApplyWorldOffsetCS_InOffset_Offset));
		bool bWorldShift = BoolMarshaler.FromNative(IntPtr.Add(buffer, ApplyWorldOffsetCS_bWorldShift_Offset), 0, ApplyWorldOffsetCS_bWorldShift_PropertyAddress.Address);
		uActorCompContainerCS.ApplyWorldOffsetCS_Implementation(inOffset, bWorldShift);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.ActorCompContainerCS");
		NativeReflection.GetPropertyRef(ref CompsRef_PropertyAddress, intPtr, "CompsRef");
		CompsRef_Offset = NativeReflection.GetPropertyOffset(intPtr, "CompsRef");
		CompsRef_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CompsRef", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref bUserForUnit_PropertyAddress, intPtr, "bUserForUnit");
		bUserForUnit_Offset = NativeReflection.GetPropertyOffset(intPtr, "bUserForUnit");
		bUserForUnit_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bUserForUnit", Classes.FBoolProperty);
		EndPlayInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "EndPlayInCS");
		EndPlayInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(EndPlayInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref EndPlayInCS_EndPlayReason_PropertyAddress, EndPlayInCS_FunctionAddress, "EndPlayReason");
		EndPlayInCS_EndPlayReason_Offset = NativeReflection.GetPropertyOffset(EndPlayInCS_FunctionAddress, "EndPlayReason");
		EndPlayInCS_EndPlayReason_IsValid = NativeReflection.ValidatePropertyClass(EndPlayInCS_FunctionAddress, "EndPlayReason", Classes.FEnumProperty);
		EndPlayInCS_IsValid = EndPlayInCS_FunctionAddress != IntPtr.Zero && EndPlayInCS_EndPlayReason_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.ActorCompContainerCS:EndPlayInCS", EndPlayInCS_IsValid);
		ApplyWorldOffsetCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ApplyWorldOffsetCS");
		ApplyWorldOffsetCS_ParamsSize = NativeReflection.GetFunctionParamsSize(ApplyWorldOffsetCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref ApplyWorldOffsetCS_InOffset_PropertyAddress, ApplyWorldOffsetCS_FunctionAddress, "InOffset");
		ApplyWorldOffsetCS_InOffset_Offset = NativeReflection.GetPropertyOffset(ApplyWorldOffsetCS_FunctionAddress, "InOffset");
		ApplyWorldOffsetCS_InOffset_IsValid = NativeReflection.ValidatePropertyClass(ApplyWorldOffsetCS_FunctionAddress, "InOffset", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref ApplyWorldOffsetCS_bWorldShift_PropertyAddress, ApplyWorldOffsetCS_FunctionAddress, "bWorldShift");
		ApplyWorldOffsetCS_bWorldShift_Offset = NativeReflection.GetPropertyOffset(ApplyWorldOffsetCS_FunctionAddress, "bWorldShift");
		ApplyWorldOffsetCS_bWorldShift_IsValid = NativeReflection.ValidatePropertyClass(ApplyWorldOffsetCS_FunctionAddress, "bWorldShift", Classes.FBoolProperty);
		ApplyWorldOffsetCS_IsValid = ApplyWorldOffsetCS_FunctionAddress != IntPtr.Zero && ApplyWorldOffsetCS_InOffset_IsValid && ApplyWorldOffsetCS_bWorldShift_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.ActorCompContainerCS:ApplyWorldOffsetCS", ApplyWorldOffsetCS_IsValid);
	}

	static UActorCompContainerCS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(UActorCompContainerCS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UActorCompContainerCS));
	}
}
