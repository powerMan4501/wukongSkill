using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using b1.BGW;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.Runtime.Native;

namespace b1;

[UClass]
[BlueprintSpawnableComponent]
[USharpPath("/Script/b1-Managed.BGUSkillPreviewSystem")]
public class BGUSkillPreviewSystem : UBaseActorCompTickable
{
	private BUC_SkillPreviewData SkillPreviewData;

	private List<int> _SectorFilterList;

	private bool SetSectorFilterOver;

	private int ActualMapSize;

	private int ActualMapSizeForData;

	private float PointSize;

	private float LowPointSize;

	private string AttackerGuid;

	private AActor Attacker;

	private FTransform AttackerStartTrans;

	private AActor Target;

	private FTransform TargetStartTrans;

	private float DelayTimer;

	private bool bUsingSkill = true;

	private readonly int AttackerTeamIdx = -1;

	private readonly int TargetTeamIdx = -2;

	private const int LOWESTTESTMAPSIZE = 10;

	private string ZBBConfigPath;

	private bool InitOver;

	private int CurSkillIDIndex;

	private static bool AttackerClass_IsValid;

	private static int AttackerClass_Offset;

	private static bool SkillID_IsValid;

	private static int SkillID_Offset;

	private static bool SkillIDList_IsValid;

	private static int SkillIDList_Offset;

	private static FFieldAddress SkillIDList_PropertyAddress;

	private TArrayReadWriteMarshaler<int> SkillIDList_Marshaler;

	private static bool Delay_IsValid;

	private static int Delay_Offset;

	private static bool bDrawSweepCheckSphere_IsValid;

	private static int bDrawSweepCheckSphere_Offset;

	private static FFieldAddress bDrawSweepCheckSphere_PropertyAddress;

	private static bool bDrawSkillEffectArea_IsValid;

	private static int bDrawSkillEffectArea_Offset;

	private static FFieldAddress bDrawSkillEffectArea_PropertyAddress;

	private static bool bDrawBuffArea_IsValid;

	private static int bDrawBuffArea_Offset;

	private static FFieldAddress bDrawBuffArea_PropertyAddress;

	private static bool bDrawBulletCollision_IsValid;

	private static int bDrawBulletCollision_Offset;

	private static FFieldAddress bDrawBulletCollision_PropertyAddress;

	private static bool bDrawBulletDestroyPos_IsValid;

	private static int bDrawBulletDestroyPos_Offset;

	private static FFieldAddress bDrawBulletDestroyPos_PropertyAddress;

	private static bool TargetAddBati_IsValid;

	private static int TargetAddBati_Offset;

	private static FFieldAddress TargetAddBati_PropertyAddress;

	private static bool EnableZBBTest_IsValid;

	private static int EnableZBBTest_Offset;

	private static FFieldAddress EnableZBBTest_PropertyAddress;

	private static bool OpenLowDensityTest_IsValid;

	private static int OpenLowDensityTest_Offset;

	private static FFieldAddress OpenLowDensityTest_PropertyAddress;

	private static bool DistRange_IsValid;

	private static int DistRange_Offset;

	private static bool MapSize_IsValid;

	private static int MapSize_Offset;

	private static bool SectorFilterList_IsValid;

	private static int SectorFilterList_Offset;

	private static FFieldAddress SectorFilterList_PropertyAddress;

	private TArrayReadWriteMarshaler<int> SectorFilterList_Marshaler;

	private static bool DrawforDebug_IsValid;

	private static IntPtr DrawforDebug_FunctionAddress;

	private static int DrawforDebug_ParamsSize;

	private static bool DrawforDebug_DrawAll_IsValid;

	private static int DrawforDebug_DrawAll_Offset;

	private static FFieldAddress DrawforDebug_DrawAll_PropertyAddress;

	private static bool DrawforDebug_SectorNum_IsValid;

	private static int DrawforDebug_SectorNum_Offset;

	private static bool OnSetPreviewConfig_IsValid;

	private static IntPtr OnSetPreviewConfig_FunctionAddress;

	private static int OnSetPreviewConfig_ParamsSize;

	private static bool OnSetPreviewConfig_Config_IsValid;

	private static int OnSetPreviewConfig_Config_Offset;

	private static FFieldAddress OnSetPreviewConfig_Config_PropertyAddress;

	private static bool StopTestAndOutputConfig_IsValid;

	private static IntPtr StopTestAndOutputConfig_FunctionAddress;

	private static int StopTestAndOutputConfig_ParamsSize;

	private static bool BeginPlayInCS_IsValid;

	private static IntPtr BeginPlayInCS_FunctionAddress;

	private static int BeginPlayInCS_ParamsSize;

	private static bool TickComponentInCS_IsValid;

	private static IntPtr TickComponentInCS_FunctionAddress;

	private static int TickComponentInCS_ParamsSize;

	private static bool TickComponentInCS_DeltaTime_IsValid;

	private static int TickComponentInCS_DeltaTime_Offset;

	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Preview Config | General")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUSkillPreviewSystem:AttackerClass")]
	public TSubclassOf<BUTamerActor> AttackerClass
	{
		get
		{
			CheckDestroyed();
			if (!AttackerClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSkillPreviewSystem:AttackerClass");
				return default(TSubclassOf<BUTamerActor>);
			}
			return TSubclassOfMarshaler<BUTamerActor>.FromNative(IntPtr.Add(base.Address, AttackerClass_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AttackerClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSkillPreviewSystem:AttackerClass");
			}
			else
			{
				TSubclassOfMarshaler<BUTamerActor>.ToNative(IntPtr.Add(base.Address, AttackerClass_Offset), value);
			}
		}
	}

	[Category("Preview Config | General")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUSkillPreviewSystem:SkillID")]
	public int SkillID
	{
		get
		{
			CheckDestroyed();
			if (!SkillID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSkillPreviewSystem:SkillID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, SkillID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SkillID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSkillPreviewSystem:SkillID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, SkillID_Offset), value);
			}
		}
	}

	[Category("Preview Config | General")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[Tooltip("会优先使用SkillIDList中的数据，没有合并SkillID，原因是ZBB那边还没来得及改，先这样临时用着")]
	[USharpPath("/Script/b1-Managed.BGUSkillPreviewSystem:SkillIDList")]
	public TArrayReadWrite<int> SkillIDList
	{
		get
		{
			CheckDestroyed();
			if (!SkillIDList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSkillPreviewSystem:SkillIDList");
				return null;
			}
			if (SkillIDList_Marshaler == null)
			{
				SkillIDList_Marshaler = new TArrayReadWriteMarshaler<int>(1, SkillIDList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return SkillIDList_Marshaler.FromNative(IntPtr.Add(base.Address, SkillIDList_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Preview Config | General")]
	[USharpPath("/Script/b1-Managed.BGUSkillPreviewSystem:Delay")]
	private float Delay
	{
		get
		{
			CheckDestroyed();
			if (!Delay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSkillPreviewSystem:Delay");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Delay_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Delay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSkillPreviewSystem:Delay");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Delay_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[Category("Preview Config | Draw")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUSkillPreviewSystem:bDrawSweepCheckSphere")]
	private bool bDrawSweepCheckSphere
	{
		get
		{
			CheckDestroyed();
			if (!bDrawSweepCheckSphere_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSkillPreviewSystem:bDrawSweepCheckSphere");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bDrawSweepCheckSphere_Offset), 0, bDrawSweepCheckSphere_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bDrawSweepCheckSphere_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSkillPreviewSystem:bDrawSweepCheckSphere");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bDrawSweepCheckSphere_Offset), 0, bDrawSweepCheckSphere_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Preview Config | Draw")]
	[USharpPath("/Script/b1-Managed.BGUSkillPreviewSystem:bDrawSkillEffectArea")]
	private bool bDrawSkillEffectArea
	{
		get
		{
			CheckDestroyed();
			if (!bDrawSkillEffectArea_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSkillPreviewSystem:bDrawSkillEffectArea");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bDrawSkillEffectArea_Offset), 0, bDrawSkillEffectArea_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bDrawSkillEffectArea_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSkillPreviewSystem:bDrawSkillEffectArea");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bDrawSkillEffectArea_Offset), 0, bDrawSkillEffectArea_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Preview Config | Draw")]
	[USharpPath("/Script/b1-Managed.BGUSkillPreviewSystem:bDrawBuffArea")]
	private bool bDrawBuffArea
	{
		get
		{
			CheckDestroyed();
			if (!bDrawBuffArea_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSkillPreviewSystem:bDrawBuffArea");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bDrawBuffArea_Offset), 0, bDrawBuffArea_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bDrawBuffArea_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSkillPreviewSystem:bDrawBuffArea");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bDrawBuffArea_Offset), 0, bDrawBuffArea_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Preview Config | Draw")]
	[USharpPath("/Script/b1-Managed.BGUSkillPreviewSystem:bDrawBulletCollision")]
	private bool bDrawBulletCollision
	{
		get
		{
			CheckDestroyed();
			if (!bDrawBulletCollision_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSkillPreviewSystem:bDrawBulletCollision");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bDrawBulletCollision_Offset), 0, bDrawBulletCollision_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bDrawBulletCollision_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSkillPreviewSystem:bDrawBulletCollision");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bDrawBulletCollision_Offset), 0, bDrawBulletCollision_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Preview Config | Draw")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUSkillPreviewSystem:bDrawBulletDestroyPos")]
	private bool bDrawBulletDestroyPos
	{
		get
		{
			CheckDestroyed();
			if (!bDrawBulletDestroyPos_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSkillPreviewSystem:bDrawBulletDestroyPos");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bDrawBulletDestroyPos_Offset), 0, bDrawBulletDestroyPos_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bDrawBulletDestroyPos_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSkillPreviewSystem:bDrawBulletDestroyPos");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bDrawBulletDestroyPos_Offset), 0, bDrawBulletDestroyPos_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Preview Config | ZangBaBa")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGUSkillPreviewSystem:TargetAddBati")]
	private bool TargetAddBati
	{
		get
		{
			CheckDestroyed();
			if (!TargetAddBati_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSkillPreviewSystem:TargetAddBati");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, TargetAddBati_Offset), 0, TargetAddBati_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!TargetAddBati_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSkillPreviewSystem:TargetAddBati");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, TargetAddBati_Offset), 0, TargetAddBati_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Preview Config | ZangBaBa")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGUSkillPreviewSystem:EnableZBBTest")]
	private bool EnableZBBTest
	{
		get
		{
			CheckDestroyed();
			if (!EnableZBBTest_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSkillPreviewSystem:EnableZBBTest");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableZBBTest_Offset), 0, EnableZBBTest_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableZBBTest_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSkillPreviewSystem:EnableZBBTest");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableZBBTest_Offset), 0, EnableZBBTest_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[Category("Preview Config | ZangBaBa")]
	[UMeta(MDProp.EditCondition, "EnableZBBTest")]
	[Tooltip("是否打开粗采样过滤测试")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUSkillPreviewSystem:OpenLowDensityTest")]
	private bool OpenLowDensityTest
	{
		get
		{
			CheckDestroyed();
			if (!OpenLowDensityTest_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSkillPreviewSystem:OpenLowDensityTest");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, OpenLowDensityTest_Offset), 0, OpenLowDensityTest_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!OpenLowDensityTest_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSkillPreviewSystem:OpenLowDensityTest");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, OpenLowDensityTest_Offset), 0, OpenLowDensityTest_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Preview Config | ZangBaBa")]
	[UMeta(MDProp.EditCondition, "EnableZBBTest")]
	[Tooltip("测试距离范围")]
	[USharpPath("/Script/b1-Managed.BGUSkillPreviewSystem:DistRange")]
	private FVector2D DistRange
	{
		get
		{
			CheckDestroyed();
			if (!DistRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSkillPreviewSystem:DistRange");
				return default(FVector2D);
			}
			return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(base.Address, DistRange_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DistRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSkillPreviewSystem:DistRange");
			}
			else
			{
				BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(base.Address, DistRange_Offset), value);
			}
		}
	}

	[Tooltip("采样矩阵密度")]
	[UProperty]
	[EditAnywhere]
	[Category("Preview Config | ZangBaBa")]
	[UMeta(MDProp.EditCondition, "EnableZBBTest")]
	[USharpPath("/Script/b1-Managed.BGUSkillPreviewSystem:MapSize")]
	private int MapSize
	{
		get
		{
			CheckDestroyed();
			if (!MapSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSkillPreviewSystem:MapSize");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, MapSize_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MapSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSkillPreviewSystem:MapSize");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, MapSize_Offset), value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "EnableZBBTest")]
	[UProperty]
	[EditAnywhere]
	[Category("Preview Config | ZangBaBa")]
	[Tooltip("人为过滤扇区")]
	[USharpPath("/Script/b1-Managed.BGUSkillPreviewSystem:SectorFilterList")]
	private TArrayReadWrite<int> SectorFilterList
	{
		get
		{
			CheckDestroyed();
			if (!SectorFilterList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSkillPreviewSystem:SectorFilterList");
				return null;
			}
			if (SectorFilterList_Marshaler == null)
			{
				SectorFilterList_Marshaler = new TArrayReadWriteMarshaler<int>(1, SectorFilterList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return SectorFilterList_Marshaler.FromNative(IntPtr.Add(base.Address, SectorFilterList_Offset));
		}
	}

	[USharpPath("/Script/b1-Managed.BGUSkillPreviewSystem:BeginPlayInCS")]
	protected override void BeginPlayInCS_Implementation()
	{
		SkillPreviewData = new BUC_SkillPreviewData();
	}

	private void SetSectorFilter(List<int> FilterList, bool UseTArray)
	{
		if (SetSectorFilterOver)
		{
			return;
		}
		_SectorFilterList = new List<int>();
		if (UseTArray)
		{
			for (int i = 0; i < SectorFilterList.Count; i++)
			{
				_SectorFilterList.Add(SectorFilterList[i]);
			}
		}
		else
		{
			for (int j = 0; j < FilterList.Count; j++)
			{
				_SectorFilterList.Add(FilterList[j]);
			}
		}
		SetSectorFilterOver = true;
	}

	public void Init()
	{
		if (EnableZBBTest)
		{
			SetSectorFilter(null, UseTArray: true);
			CreateAttacker();
			CreateTarget();
		}
	}

	[USharpPath("/Script/b1-Managed.BGUSkillPreviewSystem:TickComponentInCS")]
	protected override void TickComponentInCS_Implementation(float DeltaTime)
	{
		base.TickComponentInCS_Implementation(DeltaTime);
		if (!InitOver)
		{
			Init();
			InitOver = true;
		}
		if (Attacker == null)
		{
			Attacker = BGU_DataUtil.GetActorByGuid(GetOwner(), AttackerGuid);
			if (!(Attacker != null))
			{
				return;
			}
			BGUFunctionLibraryCS.BGUSetUnitSimpleState(Attacker, EBGUSimpleState.ImmueDamage, IsRemove: false);
			BGUCharacterCS bGUCharacterCS = Attacker as BGUCharacterCS;
			if (bGUCharacterCS != null)
			{
				bGUCharacterCS.SetTeamIDInCS(AttackerTeamIdx);
			}
			BGUFunctionLibraryCS.BGUSetUnitSimpleState(Attacker, EBGUSimpleState.ImmueDamage, IsRemove: false);
			BUS_EventCollectionCS.Get(Attacker).Evt_AIPauseBT.Invoke(P1: true);
			BUS_EventCollectionCS.Get(Attacker).Evt_AIPerceptionSetting.Invoke(P1: false);
			BUS_EventCollectionCS.Get(Attacker)?.Evt_OnSetZangBaBaOwner.Invoke(GetOwner());
			BGW_EventCollection.Get(Attacker)?.Evt_BGW_SetIgnorePreload();
			InitDebugConfig();
			BGUFunctionLibraryCS.BGUSetUnitSimpleState(Target, EBGUSimpleState.ImmueDamage, IsRemove: false);
			if (TargetAddBati)
			{
				BGUFunctionLibraryCS.BGUSetUnitSimpleState(Target, EBGUSimpleState.ImmueStiff, IsRemove: false);
			}
			if (Target != null)
			{
				BGUCharacterCS bGUCharacterCS2 = Target as BGUCharacterCS;
				if (bGUCharacterCS2 != null)
				{
					bGUCharacterCS2.SetTeamIDInCS(TargetTeamIdx);
					BUS_EventCollectionCS.Get(bGUCharacterCS2).Evt_SetAttrFloat.Invoke(EBGUAttrFloat.HpMaxBase, 100000f);
					BUS_EventCollectionCS.Get(bGUCharacterCS2).Evt_SetAttrFloat.Invoke(EBGUAttrFloat.Hp, 100000f);
				}
			}
			ZBBConfigPath = FPaths.ProjectDir + "\\ZBBConfigs";
			SkillPreviewData.AllZBBInfos = GenerateCircleGridByMapSize(MapSize, isActualTest: true);
			if (OpenLowDensityTest)
			{
				SkillPreviewData.LowerDensityZBBInfos = GenerateCircleGridByMapSize(10, isActualTest: false);
				List<int> list = new List<int>();
				foreach (int sectorFilter in _SectorFilterList)
				{
					list.Add(sectorFilter);
				}
				CloseInvalidSector(SkillPreviewData.LowerDensityZBBInfos, list);
			}
			else
			{
				SkillPreviewData.LowDensityTestOver = true;
				CloseInvalidSector(SkillPreviewData.AllZBBInfos, _SectorFilterList);
			}
		}
		if (EnableZBBTest)
		{
			if (SkillPreviewData.ZBBConfigSaveOver)
			{
				return;
			}
			if (SkillPreviewData.ZBBTestOver)
			{
				SaveCurZBBConfigInXml();
				SkillPreviewData.ZBBConfigSaveOver = true;
				return;
			}
			if (!SkillPreviewData.LowDensityTestOver)
			{
				if (SkillPreviewData.CurSpawnIdx >= SkillPreviewData.LowerDensityZBBInfos.Count)
				{
					LowDensityTestOver();
					SkillPreviewData.CurSpawnIdx = 0;
					return;
				}
				if (!SkillPreviewData.LowerDensityZBBInfos[SkillPreviewData.CurSpawnIdx].NeedTest)
				{
					SkillPreviewData.CurSpawnIdx++;
					return;
				}
			}
			else
			{
				if (SkillPreviewData.CurSpawnIdx >= SkillPreviewData.AllZBBInfos.Count)
				{
					SaveCurZBBConfigInXml();
					SkillPreviewData.ZBBConfigSaveOver = true;
					return;
				}
				if (!SkillPreviewData.AllZBBInfos[SkillPreviewData.CurSpawnIdx].NeedTest)
				{
					int num = -1;
					for (int i = SkillPreviewData.CurSpawnIdx; i < SkillPreviewData.AllZBBInfos.Count; i++)
					{
						if (SkillPreviewData.AllZBBInfos[i].NeedTest)
						{
							num = i;
							break;
						}
					}
					if (num == -1)
					{
						SkillPreviewData.CurSpawnIdx = SkillPreviewData.AllZBBInfos.Count;
						return;
					}
					SkillPreviewData.CurSpawnIdx = num;
				}
			}
		}
		if (DelayTimer >= 0f)
		{
			DelayTimer -= DeltaTime;
			if (!(DelayTimer <= 0f))
			{
				return;
			}
			if (EnableZBBTest)
			{
				if (SkillPreviewData.CurSpawnIdx >= SkillPreviewData.AllZBBInfos.Count)
				{
					SkillPreviewData.ZBBTestOver = true;
					return;
				}
				SkillPreviewData.CurSkillStartTime = GetOwner().World.GetTimeSeconds();
				if (SkillPreviewData.LowDensityTestOver)
				{
					StartPreview(SkillPreviewData.AllZBBInfos[SkillPreviewData.CurSpawnIdx].Position * PointSize);
				}
				else
				{
					StartPreview(SkillPreviewData.LowerDensityZBBInfos[SkillPreviewData.CurSpawnIdx].Position * LowPointSize);
				}
			}
			else
			{
				StartPreview();
			}
		}
		else
		{
			CheckSkillFinish();
		}
	}

	private void InitDebugConfig()
	{
		FSkillPreviewConfig skillPreviewConfig = new FSkillPreviewConfig
		{
			bDrawSweepCheckSphere = bDrawSweepCheckSphere,
			bDrawSkillEffectArea = bDrawSkillEffectArea,
			bDrawBuffArea = bDrawBuffArea,
			bDrawBulletCollision = bDrawBulletCollision,
			bDrawBulletDestroyPos = bDrawBulletDestroyPos
		};
		BUS_EventCollectionCS.Get(Attacker).Evt_SetSkillPreviewConfig.Invoke(skillPreviewConfig);
	}

	private void StartPreview(FVector Offset = default(FVector))
	{
		BGUFuncLibActorTransformCS.BGUSetActorTransform(Attacker, AttackerStartTrans, bSweep: false, bTeleport: false);
		if (!EnableZBBTest)
		{
			BUS_EventCollectionCS.Get(Target)?.Evt_SetActorTransform.Invoke(TargetStartTrans, bSweep: false, bTeleport: false);
		}
		else
		{
			FTransform fTransform = default(FTransform);
			fTransform.Scale3D = new FVector(1.0, 1.0, 1.0);
			fTransform.Translation = Offset + new FVector(BGUFuncLibActorTransformCS.BGUGetActorLocation(Attacker).X, BGUFuncLibActorTransformCS.BGUGetActorLocation(Attacker).Y, BGUFuncLibActorTransformCS.BGUGetActorLocation(Target).Z);
			fTransform.Rotation = new FQuat(UMathLibrary.FindLookAtRotation(fTransform.Translation, BGUFuncLibActorTransformCS.BGUGetActorLocation(Attacker)));
			Target.SetActorLocation(fTransform.GetLocation(), bSweep: false, out var _, bTeleport: false);
			Target.SetActorRotation(fTransform.GetRotation().Quat_Rotator(), bTeleportPhysics: false);
		}
		AttackerUseSkill();
	}

	private void CheckSkillFinish()
	{
		if (bUsingSkill && !BGU_DataUtil.GetReadOnlyData<BUC_UnitStateData>(Attacker).HasState(EBGUUnitState.Attacking))
		{
			bUsingSkill = false;
			DelayTimer = Delay;
			if (EnableZBBTest)
			{
				SkillPreviewData.CurSpawnIdx++;
			}
		}
	}

	private void AttackerUseSkill()
	{
		BUS_EventCollectionCS.Get(Attacker).Evt_AICatchTarget.Invoke(Target, ETargetSourceType.None, SkipWakeUp: true);
		int skillID = SkillID;
		if (SkillIDList.Count > 0)
		{
			if (CurSkillIDIndex >= SkillIDList.Count)
			{
				CurSkillIDIndex = 0;
			}
			skillID = SkillIDList[CurSkillIDIndex];
			CurSkillIDIndex++;
		}
		BGUFuncLibAICS.BGURequestAIUseSkillWithSkillID_CSharp(Attacker, skillID, ECastSkillSourceType.SkillPreview);
		bUsingSkill = true;
		BUS_EventCollectionCS.Get(Attacker).Evt_ResetSkillCD.Invoke();
	}

	private void CreateAttacker()
	{
		AttackerStartTrans = UGSE_CharacterFuncLib.GetSceneComponentTransformByName(GetOwner(), "AttackerPos");
		FVector location = AttackerStartTrans.GetLocation();
		FRotator rotation = AttackerStartTrans.GetLocation().Rotation();
		AttackerGuid = BGU_UnrealWorldUtil.RequestSpawnUnit(UGSE_EngineFuncLib.GetWorldFromObj(GetOwner()), AttackerClass.Value, new FTransform(rotation, location), null);
	}

	private void CreateTarget()
	{
		TStrongObjectPtr<UClass> tStrongObjectPtr = new TStrongObjectPtr<UClass>();
		tStrongObjectPtr.Set(BGW_PreloadAssetMgr.Get(GetOwner()).TryGetCachedResourceObj<UClass>("Blueprint'/Game/00Main/Design/Units/Player/Unit_Player_Wukong.Unit_Player_Wukong_C'", ELoadResourceType.SyncLoadAndCache));
		TargetStartTrans = UGSE_CharacterFuncLib.GetSceneComponentTransformByName(GetOwner(), "TargetPos");
		FVector location = TargetStartTrans.GetLocation();
		FRotator rotation = TargetStartTrans.GetLocation().Rotation();
		FActorSpawnParametersInterop parameters = new FActorSpawnParametersInterop
		{
			SpawnCollisionHandlingOverride = ESpawnActorCollisionHandlingMethod.AdjustIfPossibleButAlwaysSpawn
		};
		UWorld worldFromObj = UGSE_EngineFuncLib.GetWorldFromObj(GetOwner());
		Target = worldFromObj.SpawnActor(tStrongObjectPtr.Get(), ref location, ref rotation, ref parameters);
	}

	public void LowDensityTestOver()
	{
		Dictionary<int, List<UnitZBBInfo>> dictionary = new Dictionary<int, List<UnitZBBInfo>>();
		dictionary = BGUSkillPreviewHelper.ZBBSectorCollector(SkillPreviewData.LowerDensityZBBInfos);
		if (dictionary == null)
		{
			return;
		}
		List<int> list = new List<int>();
		for (int i = 0; i < 8; i++)
		{
			if (_SectorFilterList != null && _SectorFilterList.Contains(i))
			{
				continue;
			}
			int num = 0;
			if (dictionary.Count > 0)
			{
				foreach (UnitZBBInfo item in dictionary[i])
				{
					if (item.Effective)
					{
						num++;
					}
				}
			}
			if (num == 0)
			{
				list.Add(i);
			}
		}
		if (_SectorFilterList.Count > 0)
		{
			foreach (int sectorFilter in _SectorFilterList)
			{
				list.Add(sectorFilter);
			}
		}
		if (list != null)
		{
			CloseInvalidSector(SkillPreviewData.AllZBBInfos, list);
		}
		SkillPreviewData.LowDensityTestOver = true;
	}

	public void CloseInvalidSector(List<UnitZBBInfo> _ZBBInfos, List<int> FilterSectors)
	{
		if (FilterSectors == null)
		{
			return;
		}
		for (int i = 0; i < _ZBBInfos.Count; i++)
		{
			FVector position = _ZBBInfos[i].Position;
			int num = (int)(FMath.Acos(position.X / FMath.Sqrt(position.X * position.X + position.Y * position.Y)) * 180f / (float)Math.PI) / 45;
			if (_ZBBInfos[i].Position.Y < 0f)
			{
				num = 7 - num;
			}
			if (FilterSectors.Contains(num))
			{
				UnitZBBInfo value = _ZBBInfos[i];
				value.NeedTest = false;
				_ZBBInfos[i] = value;
			}
		}
	}

	public List<UnitZBBInfo> GenerateCircleGridByMapSize(int mapSize, bool isActualTest)
	{
		if (mapSize < 2)
		{
			return null;
		}
		ActualMapSize = ((mapSize % 2 == 0) ? (mapSize + 1) : mapSize);
		float num = 2f * DistRange.Y / (float)(ActualMapSize - 1);
		if (isActualTest)
		{
			ActualMapSizeForData = ActualMapSize;
			PointSize = num;
		}
		else
		{
			LowPointSize = num;
		}
		List<UnitZBBInfo> list = new List<UnitZBBInfo>();
		FVector fVector = new FVector(-ActualMapSize / 2, -ActualMapSize / 2, 0.0);
		for (int i = 0; i < ActualMapSize; i++)
		{
			for (int j = 0; j < ActualMapSize; j++)
			{
				FVector fVector2 = fVector + new FVector(i, j, 0.0);
				float num2 = FVector.Dist2D(fVector2, new FVector(0.0, 0.0, 0.0));
				list.Add(new UnitZBBInfo
				{
					NeedTest = true,
					Effective = false,
					Position = fVector2,
					Distance = num2 * num,
					HitTimer = -1f
				});
			}
		}
		for (int k = 0; k < list.Count; k++)
		{
			float distance = list[k].Distance;
			if (distance < DistRange.X)
			{
				list.RemoveAt(k);
				k--;
			}
			else if (distance > DistRange.Y)
			{
				list.RemoveAt(k);
				k--;
			}
		}
		return list;
	}

	private void SaveCurZBBConfigInXml()
	{
		string path = ZBBConfigPath + "\\" + SkillID + ".xml";
		XmlSerializer xmlSerializer = new XmlSerializer(typeof(OneZBBConfig));
		FileStream fileStream = File.Create(path);
		SkillPreviewData.ZBBDataForXml.SkillID = SkillID;
		SkillPreviewData.ZBBDataForXml.MapSize = ActualMapSizeForData;
		SkillPreviewData.ZBBDataForXml.MapRealRadius_Left = DistRange.X;
		SkillPreviewData.ZBBDataForXml.MapRealRadius_Right = DistRange.Y;
		SkillPreviewData.ZBBDataForXml.AllZBBInfos = new List<UnitZBBInfo>();
		SkillPreviewData.ZBBDataForXml.AllZBBInfos = SkillPreviewData.AllZBBInfos;
		xmlSerializer.Serialize(fileStream, SkillPreviewData.ZBBDataForXml);
		fileStream.Close();
	}

	public void OnSendInfoToZBB(HitForZBBInfo hitInfo)
	{
		if (SkillPreviewData.LowDensityTestOver)
		{
			if (!SkillPreviewData.AllZBBInfos[SkillPreviewData.CurSpawnIdx].Effective)
			{
				UnitZBBInfo value = SkillPreviewData.AllZBBInfos[SkillPreviewData.CurSpawnIdx];
				value.Effective = true;
				value.HitTimer = hitInfo.HitWorldTime - SkillPreviewData.CurSkillStartTime;
				value.NotifyBeginTime = new List<string> { $"{hitInfo.NotifyBeginTime:f2}" };
				SkillPreviewData.AllZBBInfos[SkillPreviewData.CurSpawnIdx] = value;
			}
			else
			{
				SkillPreviewData.AllZBBInfos[SkillPreviewData.CurSpawnIdx].NotifyBeginTime.Add($"{hitInfo.NotifyBeginTime:f2}");
			}
		}
		else if (!SkillPreviewData.LowerDensityZBBInfos[SkillPreviewData.CurSpawnIdx].Effective)
		{
			UnitZBBInfo value2 = SkillPreviewData.AllZBBInfos[SkillPreviewData.CurSpawnIdx];
			value2.Effective = true;
			value2.HitTimer = hitInfo.HitWorldTime - SkillPreviewData.CurSkillStartTime;
			value2.NotifyBeginTime = new List<string> { $"{hitInfo.NotifyBeginTime:f2}" };
			SkillPreviewData.LowerDensityZBBInfos[SkillPreviewData.CurSpawnIdx] = value2;
		}
		else
		{
			SkillPreviewData.LowerDensityZBBInfos[SkillPreviewData.CurSpawnIdx].NotifyBeginTime.Add($"{hitInfo.NotifyBeginTime:f2}");
		}
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUSkillPreviewSystem:DrawforDebug")]
	public void DrawforDebug(bool DrawAll, int SectorNum)
	{
		if (!DrawAll)
		{
			return;
		}
		FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(GetOwner());
		foreach (UnitZBBInfo allZBBInfo in SkillPreviewData.AllZBBInfos)
		{
			if (allZBBInfo.NeedTest)
			{
				FVector centerPos = allZBBInfo.Position * PointSize + fVector;
				UBGUFunctionLibraryForCS.BGUDrawDebugCircle(GetOwner().World, centerPos, 10f);
			}
		}
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUSkillPreviewSystem:StopTestAndOutputConfig")]
	public void StopTestAndOutputConfig()
	{
		SkillPreviewData.ZBBTestOver = true;
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUSkillPreviewSystem:OnSetPreviewConfig")]
	public void OnSetPreviewConfig(ZBBPreviewConfig Config)
	{
		AttackerClass = Config.AttackerClass;
		SkillID = Config.SkillID;
		Delay = Config.Delay;
		TargetAddBati = Config.TargetAddBati;
		EnableZBBTest = Config.EnableZBBTest;
		OpenLowDensityTest = Config.OpenLowDensityTest;
		DistRange = Config.DistRange;
		MapSize = Config.MapSize;
		if (Config.SectorFilterList != null)
		{
			SetSectorFilter(Config.SectorFilterList, UseTArray: false);
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUSkillPreviewSystem:DrawforDebug")]
	private static void DrawforDebug__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUSkillPreviewSystem bGUSkillPreviewSystem = GCHelper.Find<BGUSkillPreviewSystem>(obj);
		bool drawAll = BoolMarshaler.FromNative(IntPtr.Add(buffer, DrawforDebug_DrawAll_Offset), 0, DrawforDebug_DrawAll_PropertyAddress.Address);
		int sectorNum = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, DrawforDebug_SectorNum_Offset));
		bGUSkillPreviewSystem.DrawforDebug(drawAll, sectorNum);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUSkillPreviewSystem:OnSetPreviewConfig")]
	private static void OnSetPreviewConfig__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUSkillPreviewSystem bGUSkillPreviewSystem = GCHelper.Find<BGUSkillPreviewSystem>(obj);
		ZBBPreviewConfig config = ZBBPreviewConfig.FromNative(IntPtr.Add(buffer, OnSetPreviewConfig_Config_Offset));
		bGUSkillPreviewSystem.OnSetPreviewConfig(config);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUSkillPreviewSystem:StopTestAndOutputConfig")]
	private static void StopTestAndOutputConfig__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUSkillPreviewSystem bGUSkillPreviewSystem = GCHelper.Find<BGUSkillPreviewSystem>(obj);
		bGUSkillPreviewSystem.StopTestAndOutputConfig();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUSkillPreviewSystem:BeginPlayInCS")]
	private static void BeginPlayInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUSkillPreviewSystem bGUSkillPreviewSystem = GCHelper.Find<BGUSkillPreviewSystem>(obj);
		bGUSkillPreviewSystem.BeginPlayInCS_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUSkillPreviewSystem:TickComponentInCS")]
	private static void TickComponentInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUSkillPreviewSystem bGUSkillPreviewSystem = GCHelper.Find<BGUSkillPreviewSystem>(obj);
		float deltaTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, TickComponentInCS_DeltaTime_Offset));
		bGUSkillPreviewSystem.TickComponentInCS_Implementation(deltaTime);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGUSkillPreviewSystem");
		AttackerClass_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttackerClass");
		AttackerClass_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttackerClass", Classes.FClassProperty);
		SkillID_Offset = NativeReflection.GetPropertyOffset(intPtr, "SkillID");
		SkillID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SkillID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref SkillIDList_PropertyAddress, intPtr, "SkillIDList");
		SkillIDList_Offset = NativeReflection.GetPropertyOffset(intPtr, "SkillIDList");
		SkillIDList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SkillIDList", Classes.FArrayProperty);
		Delay_Offset = NativeReflection.GetPropertyOffset(intPtr, "Delay");
		Delay_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Delay", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref bDrawSweepCheckSphere_PropertyAddress, intPtr, "bDrawSweepCheckSphere");
		bDrawSweepCheckSphere_Offset = NativeReflection.GetPropertyOffset(intPtr, "bDrawSweepCheckSphere");
		bDrawSweepCheckSphere_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bDrawSweepCheckSphere", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bDrawSkillEffectArea_PropertyAddress, intPtr, "bDrawSkillEffectArea");
		bDrawSkillEffectArea_Offset = NativeReflection.GetPropertyOffset(intPtr, "bDrawSkillEffectArea");
		bDrawSkillEffectArea_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bDrawSkillEffectArea", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bDrawBuffArea_PropertyAddress, intPtr, "bDrawBuffArea");
		bDrawBuffArea_Offset = NativeReflection.GetPropertyOffset(intPtr, "bDrawBuffArea");
		bDrawBuffArea_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bDrawBuffArea", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bDrawBulletCollision_PropertyAddress, intPtr, "bDrawBulletCollision");
		bDrawBulletCollision_Offset = NativeReflection.GetPropertyOffset(intPtr, "bDrawBulletCollision");
		bDrawBulletCollision_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bDrawBulletCollision", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bDrawBulletDestroyPos_PropertyAddress, intPtr, "bDrawBulletDestroyPos");
		bDrawBulletDestroyPos_Offset = NativeReflection.GetPropertyOffset(intPtr, "bDrawBulletDestroyPos");
		bDrawBulletDestroyPos_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bDrawBulletDestroyPos", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref TargetAddBati_PropertyAddress, intPtr, "TargetAddBati");
		TargetAddBati_Offset = NativeReflection.GetPropertyOffset(intPtr, "TargetAddBati");
		TargetAddBati_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TargetAddBati", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref EnableZBBTest_PropertyAddress, intPtr, "EnableZBBTest");
		EnableZBBTest_Offset = NativeReflection.GetPropertyOffset(intPtr, "EnableZBBTest");
		EnableZBBTest_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EnableZBBTest", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref OpenLowDensityTest_PropertyAddress, intPtr, "OpenLowDensityTest");
		OpenLowDensityTest_Offset = NativeReflection.GetPropertyOffset(intPtr, "OpenLowDensityTest");
		OpenLowDensityTest_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OpenLowDensityTest", Classes.FBoolProperty);
		DistRange_Offset = NativeReflection.GetPropertyOffset(intPtr, "DistRange");
		DistRange_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DistRange", Classes.FStructProperty);
		MapSize_Offset = NativeReflection.GetPropertyOffset(intPtr, "MapSize");
		MapSize_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MapSize", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref SectorFilterList_PropertyAddress, intPtr, "SectorFilterList");
		SectorFilterList_Offset = NativeReflection.GetPropertyOffset(intPtr, "SectorFilterList");
		SectorFilterList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SectorFilterList", Classes.FArrayProperty);
		DrawforDebug_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "DrawforDebug");
		DrawforDebug_ParamsSize = NativeReflection.GetFunctionParamsSize(DrawforDebug_FunctionAddress);
		NativeReflection.GetPropertyRef(ref DrawforDebug_DrawAll_PropertyAddress, DrawforDebug_FunctionAddress, "DrawAll");
		DrawforDebug_DrawAll_Offset = NativeReflection.GetPropertyOffset(DrawforDebug_FunctionAddress, "DrawAll");
		DrawforDebug_DrawAll_IsValid = NativeReflection.ValidatePropertyClass(DrawforDebug_FunctionAddress, "DrawAll", Classes.FBoolProperty);
		DrawforDebug_SectorNum_Offset = NativeReflection.GetPropertyOffset(DrawforDebug_FunctionAddress, "SectorNum");
		DrawforDebug_SectorNum_IsValid = NativeReflection.ValidatePropertyClass(DrawforDebug_FunctionAddress, "SectorNum", Classes.FIntProperty);
		DrawforDebug_IsValid = DrawforDebug_FunctionAddress != IntPtr.Zero && DrawforDebug_DrawAll_IsValid && DrawforDebug_SectorNum_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUSkillPreviewSystem:DrawforDebug", DrawforDebug_IsValid);
		OnSetPreviewConfig_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnSetPreviewConfig");
		OnSetPreviewConfig_ParamsSize = NativeReflection.GetFunctionParamsSize(OnSetPreviewConfig_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnSetPreviewConfig_Config_PropertyAddress, OnSetPreviewConfig_FunctionAddress, "Config");
		OnSetPreviewConfig_Config_Offset = NativeReflection.GetPropertyOffset(OnSetPreviewConfig_FunctionAddress, "Config");
		OnSetPreviewConfig_Config_IsValid = NativeReflection.ValidatePropertyClass(OnSetPreviewConfig_FunctionAddress, "Config", Classes.FStructProperty);
		OnSetPreviewConfig_IsValid = OnSetPreviewConfig_FunctionAddress != IntPtr.Zero && OnSetPreviewConfig_Config_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUSkillPreviewSystem:OnSetPreviewConfig", OnSetPreviewConfig_IsValid);
		StopTestAndOutputConfig_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "StopTestAndOutputConfig");
		StopTestAndOutputConfig_ParamsSize = NativeReflection.GetFunctionParamsSize(StopTestAndOutputConfig_FunctionAddress);
		StopTestAndOutputConfig_IsValid = StopTestAndOutputConfig_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUSkillPreviewSystem:StopTestAndOutputConfig", StopTestAndOutputConfig_IsValid);
		BeginPlayInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BeginPlayInCS");
		BeginPlayInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(BeginPlayInCS_FunctionAddress);
		BeginPlayInCS_IsValid = BeginPlayInCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUSkillPreviewSystem:BeginPlayInCS", BeginPlayInCS_IsValid);
		TickComponentInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "TickComponentInCS");
		TickComponentInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(TickComponentInCS_FunctionAddress);
		TickComponentInCS_DeltaTime_Offset = NativeReflection.GetPropertyOffset(TickComponentInCS_FunctionAddress, "DeltaTime");
		TickComponentInCS_DeltaTime_IsValid = NativeReflection.ValidatePropertyClass(TickComponentInCS_FunctionAddress, "DeltaTime", Classes.FFloatProperty);
		TickComponentInCS_IsValid = TickComponentInCS_FunctionAddress != IntPtr.Zero && TickComponentInCS_DeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUSkillPreviewSystem:TickComponentInCS", TickComponentInCS_IsValid);
	}

	static BGUSkillPreviewSystem()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUSkillPreviewSystem)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUSkillPreviewSystem));
	}
}
