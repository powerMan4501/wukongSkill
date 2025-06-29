using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_IntervalTriggerConfigComp")]
public class BUS_IntervalTriggerConfigComp : UActorEditCompBase
{
	private static bool Timer_IsValid;

	private static int Timer_Offset;

	private static bool DuringTimer_IsValid;

	private static int DuringTimer_Offset;

	private static bool WarningTime_IsValid;

	private static int WarningTime_Offset;

	private static bool WarningBuffID_IsValid;

	private static int WarningBuffID_Offset;

	private static bool AddBuffList_IsValid;

	private static int AddBuffList_Offset;

	private static FFieldAddress AddBuffList_PropertyAddress;

	private TArrayReadWriteMarshaler<int> AddBuffList_Marshaler;

	private static bool SpAddBuff_IsValid;

	private static int SpAddBuff_Offset;

	private static bool SpUnits_IsValid;

	private static int SpUnits_Offset;

	private static FFieldAddress SpUnits_PropertyAddress;

	private TArrayReadWriteMarshaler<FGsActorGuidReference> SpUnits_Marshaler;

	private static bool PlayerAddBuffList_IsValid;

	private static int PlayerAddBuffList_Offset;

	private static FFieldAddress PlayerAddBuffList_PropertyAddress;

	private TArrayReadWriteMarshaler<int> PlayerAddBuffList_Marshaler;

	private static bool IgnoredChrs_IsValid;

	private static int IgnoredChrs_Offset;

	private static FFieldAddress IgnoredChrs_PropertyAddress;

	private TArrayReadWriteMarshaler<FGsActorGuidReference> IgnoredChrs_Marshaler;

	private static bool IgnoredPerceptionSettingChrs_IsValid;

	private static int IgnoredPerceptionSettingChrs_Offset;

	private static FFieldAddress IgnoredPerceptionSettingChrs_PropertyAddress;

	private TArrayReadWriteMarshaler<FGsActorGuidReference> IgnoredPerceptionSettingChrs_Marshaler;

	private static bool AIPerceptionSetting_IsValid;

	private static int AIPerceptionSetting_Offset;

	private static bool PostProcessMatConfig_IsValid;

	private static int PostProcessMatConfig_Offset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Trigger")]
	[DisplayName("间隔时间")]
	[USharpPath("/Script/b1-Managed.BUS_IntervalTriggerConfigComp:Timer")]
	public float Timer
	{
		get
		{
			CheckDestroyed();
			if (!Timer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_IntervalTriggerConfigComp:Timer");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Timer_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Timer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_IntervalTriggerConfigComp:Timer");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Timer_Offset), value);
			}
		}
	}

	[Category("Trigger")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("持续时间")]
	[USharpPath("/Script/b1-Managed.BUS_IntervalTriggerConfigComp:DuringTimer")]
	public float DuringTimer
	{
		get
		{
			CheckDestroyed();
			if (!DuringTimer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_IntervalTriggerConfigComp:DuringTimer");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DuringTimer_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DuringTimer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_IntervalTriggerConfigComp:DuringTimer");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DuringTimer_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Trigger")]
	[DisplayName("预警时间")]
	[USharpPath("/Script/b1-Managed.BUS_IntervalTriggerConfigComp:WarningTime")]
	public float WarningTime
	{
		get
		{
			CheckDestroyed();
			if (!WarningTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_IntervalTriggerConfigComp:WarningTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, WarningTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WarningTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_IntervalTriggerConfigComp:WarningTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, WarningTime_Offset), value);
			}
		}
	}

	[DisplayName("预警Effect")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[Category("Trigger")]
	[USharpPath("/Script/b1-Managed.BUS_IntervalTriggerConfigComp:WarningBuffID")]
	public int WarningBuffID
	{
		get
		{
			CheckDestroyed();
			if (!WarningBuffID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_IntervalTriggerConfigComp:WarningBuffID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, WarningBuffID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WarningBuffID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_IntervalTriggerConfigComp:WarningBuffID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, WarningBuffID_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("Action")]
	[DisplayName("需要给怪添加的Buff")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_IntervalTriggerConfigComp:AddBuffList")]
	public TArrayReadWrite<int> AddBuffList
	{
		get
		{
			CheckDestroyed();
			if (!AddBuffList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_IntervalTriggerConfigComp:AddBuffList");
				return null;
			}
			if (AddBuffList_Marshaler == null)
			{
				AddBuffList_Marshaler = new TArrayReadWriteMarshaler<int>(1, AddBuffList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return AddBuffList_Marshaler.FromNative(IntPtr.Add(base.Address, AddBuffList_Offset));
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Action")]
	[DisplayName("特殊红眼效果Buff")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_IntervalTriggerConfigComp:SpAddBuff")]
	public int SpAddBuff
	{
		get
		{
			CheckDestroyed();
			if (!SpAddBuff_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_IntervalTriggerConfigComp:SpAddBuff");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, SpAddBuff_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpAddBuff_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_IntervalTriggerConfigComp:SpAddBuff");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, SpAddBuff_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Action")]
	[DisplayName("特殊红眼单位")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_IntervalTriggerConfigComp:SpUnits")]
	public TArrayReadWrite<FGsActorGuidReference> SpUnits
	{
		get
		{
			CheckDestroyed();
			if (!SpUnits_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_IntervalTriggerConfigComp:SpUnits");
				return null;
			}
			if (SpUnits_Marshaler == null)
			{
				SpUnits_Marshaler = new TArrayReadWriteMarshaler<FGsActorGuidReference>(1, SpUnits_PropertyAddress, CachedMarshalingDelegates<FGsActorGuidReference, FGsActorGuidReference>.FromNative, CachedMarshalingDelegates<FGsActorGuidReference, FGsActorGuidReference>.ToNative);
			}
			return SpUnits_Marshaler.FromNative(IntPtr.Add(base.Address, SpUnits_Offset));
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[DisplayName("需要给主角添加的Buff")]
	[Category("Action")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_IntervalTriggerConfigComp:PlayerAddBuffList")]
	public TArrayReadWrite<int> PlayerAddBuffList
	{
		get
		{
			CheckDestroyed();
			if (!PlayerAddBuffList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_IntervalTriggerConfigComp:PlayerAddBuffList");
				return null;
			}
			if (PlayerAddBuffList_Marshaler == null)
			{
				PlayerAddBuffList_Marshaler = new TArrayReadWriteMarshaler<int>(1, PlayerAddBuffList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return PlayerAddBuffList_Marshaler.FromNative(IntPtr.Add(base.Address, PlayerAddBuffList_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Action")]
	[DisplayName("需要忽略掉的单位")]
	[USharpPath("/Script/b1-Managed.BUS_IntervalTriggerConfigComp:IgnoredChrs")]
	public TArrayReadWrite<FGsActorGuidReference> IgnoredChrs
	{
		get
		{
			CheckDestroyed();
			if (!IgnoredChrs_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_IntervalTriggerConfigComp:IgnoredChrs");
				return null;
			}
			if (IgnoredChrs_Marshaler == null)
			{
				IgnoredChrs_Marshaler = new TArrayReadWriteMarshaler<FGsActorGuidReference>(1, IgnoredChrs_PropertyAddress, CachedMarshalingDelegates<FGsActorGuidReference, FGsActorGuidReference>.FromNative, CachedMarshalingDelegates<FGsActorGuidReference, FGsActorGuidReference>.ToNative);
			}
			return IgnoredChrs_Marshaler.FromNative(IntPtr.Add(base.Address, IgnoredChrs_Offset));
		}
	}

	[EditAnywhere]
	[UProperty]
	[DisplayName("只忽略掉感知设置的单位")]
	[BlueprintReadWrite]
	[Category("Action")]
	[USharpPath("/Script/b1-Managed.BUS_IntervalTriggerConfigComp:IgnoredPerceptionSettingChrs")]
	public TArrayReadWrite<FGsActorGuidReference> IgnoredPerceptionSettingChrs
	{
		get
		{
			CheckDestroyed();
			if (!IgnoredPerceptionSettingChrs_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_IntervalTriggerConfigComp:IgnoredPerceptionSettingChrs");
				return null;
			}
			if (IgnoredPerceptionSettingChrs_Marshaler == null)
			{
				IgnoredPerceptionSettingChrs_Marshaler = new TArrayReadWriteMarshaler<FGsActorGuidReference>(1, IgnoredPerceptionSettingChrs_PropertyAddress, CachedMarshalingDelegates<FGsActorGuidReference, FGsActorGuidReference>.FromNative, CachedMarshalingDelegates<FGsActorGuidReference, FGsActorGuidReference>.ToNative);
			}
			return IgnoredPerceptionSettingChrs_Marshaler.FromNative(IntPtr.Add(base.Address, IgnoredPerceptionSettingChrs_Offset));
		}
	}

	[UProperty]
	[DisplayName("感知系统设置")]
	[Category("Action")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_IntervalTriggerConfigComp:AIPerceptionSetting")]
	public BGWDataAsset_AIPerceptionConfig AIPerceptionSetting
	{
		get
		{
			CheckDestroyed();
			if (!AIPerceptionSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_IntervalTriggerConfigComp:AIPerceptionSetting");
				return null;
			}
			return UObjectMarshaler<BGWDataAsset_AIPerceptionConfig>.FromNative(IntPtr.Add(base.Address, AIPerceptionSetting_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AIPerceptionSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_IntervalTriggerConfigComp:AIPerceptionSetting");
			}
			else
			{
				UObjectMarshaler<BGWDataAsset_AIPerceptionConfig>.ToNative(IntPtr.Add(base.Address, AIPerceptionSetting_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[Category("Action")]
	[DisplayName("后处理材质")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_IntervalTriggerConfigComp:PostProcessMatConfig")]
	public BGWDataAsset_PostProcessMatSetting PostProcessMatConfig
	{
		get
		{
			CheckDestroyed();
			if (!PostProcessMatConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_IntervalTriggerConfigComp:PostProcessMatConfig");
				return null;
			}
			return UObjectMarshaler<BGWDataAsset_PostProcessMatSetting>.FromNative(IntPtr.Add(base.Address, PostProcessMatConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PostProcessMatConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_IntervalTriggerConfigComp:PostProcessMatConfig");
			}
			else
			{
				UObjectMarshaler<BGWDataAsset_PostProcessMatSetting>.ToNative(IntPtr.Add(base.Address, PostProcessMatConfig_Offset), value);
			}
		}
	}

	public override void OnDataConvert(AActor Owner)
	{
		BUC_IntervalTriggerData bUC_IntervalTriggerData = RequireWritableData<BUC_IntervalTriggerData>();
		bUC_IntervalTriggerData.CachedIntervalTriggerTime = Timer;
		bUC_IntervalTriggerData.CachedIntervalTriggerDuringTime = DuringTimer;
		bUC_IntervalTriggerData.DuringTimer = bUC_IntervalTriggerData.CachedIntervalTriggerDuringTime;
		bUC_IntervalTriggerData.Timer = bUC_IntervalTriggerData.CachedIntervalTriggerTime;
		bUC_IntervalTriggerData.AddBuffList = new List<int>();
		foreach (int addBuff in AddBuffList)
		{
			bUC_IntervalTriggerData.AddBuffList.Add(addBuff);
		}
		bUC_IntervalTriggerData.SpBuffID = SpAddBuff;
		bUC_IntervalTriggerData.SpGuidList = new List<string>();
		foreach (FGsActorGuidReference spUnit in SpUnits)
		{
			bUC_IntervalTriggerData.SpGuidList.Add(spUnit.ActorGuid);
		}
		bUC_IntervalTriggerData.PlayerAddBuffList = new List<int>();
		foreach (int playerAddBuff in PlayerAddBuffList)
		{
			bUC_IntervalTriggerData.PlayerAddBuffList.Add(playerAddBuff);
		}
		bUC_IntervalTriggerData.AIPerceptionConfig = AIPerceptionSetting;
		bUC_IntervalTriggerData.PostProcessMatConfig = PostProcessMatConfig;
		bUC_IntervalTriggerData.WarningTime = WarningTime;
		bUC_IntervalTriggerData.WarningBuffID = WarningBuffID;
		bUC_IntervalTriggerData.IgnoredGuidList = new List<string>();
		foreach (FGsActorGuidReference ignoredChr in IgnoredChrs)
		{
			bUC_IntervalTriggerData.IgnoredGuidList.Add(ignoredChr.ActorGuid);
		}
		bUC_IntervalTriggerData.IgnoredPerceptionSettingGuidList = new List<string>();
		foreach (FGsActorGuidReference ignoredPerceptionSettingChr in IgnoredPerceptionSettingChrs)
		{
			bUC_IntervalTriggerData.IgnoredPerceptionSettingGuidList.Add(ignoredPerceptionSettingChr.ActorGuid);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUS_IntervalTriggerConfigComp");
		Timer_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Timer");
		Timer_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Timer", Classes.FFloatProperty);
		DuringTimer_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DuringTimer");
		DuringTimer_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DuringTimer", Classes.FFloatProperty);
		WarningTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "WarningTime");
		WarningTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "WarningTime", Classes.FFloatProperty);
		WarningBuffID_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "WarningBuffID");
		WarningBuffID_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "WarningBuffID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref AddBuffList_PropertyAddress, unrealStruct, "AddBuffList");
		AddBuffList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AddBuffList");
		AddBuffList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AddBuffList", Classes.FArrayProperty);
		SpAddBuff_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SpAddBuff");
		SpAddBuff_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SpAddBuff", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref SpUnits_PropertyAddress, unrealStruct, "SpUnits");
		SpUnits_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SpUnits");
		SpUnits_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SpUnits", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref PlayerAddBuffList_PropertyAddress, unrealStruct, "PlayerAddBuffList");
		PlayerAddBuffList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PlayerAddBuffList");
		PlayerAddBuffList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PlayerAddBuffList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref IgnoredChrs_PropertyAddress, unrealStruct, "IgnoredChrs");
		IgnoredChrs_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IgnoredChrs");
		IgnoredChrs_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IgnoredChrs", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref IgnoredPerceptionSettingChrs_PropertyAddress, unrealStruct, "IgnoredPerceptionSettingChrs");
		IgnoredPerceptionSettingChrs_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IgnoredPerceptionSettingChrs");
		IgnoredPerceptionSettingChrs_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IgnoredPerceptionSettingChrs", Classes.FArrayProperty);
		AIPerceptionSetting_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AIPerceptionSetting");
		AIPerceptionSetting_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AIPerceptionSetting", Classes.FObjectProperty);
		PostProcessMatConfig_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PostProcessMatConfig");
		PostProcessMatConfig_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PostProcessMatConfig", Classes.FObjectProperty);
	}

	static BUS_IntervalTriggerConfigComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_IntervalTriggerConfigComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_IntervalTriggerConfigComp));
	}
}
