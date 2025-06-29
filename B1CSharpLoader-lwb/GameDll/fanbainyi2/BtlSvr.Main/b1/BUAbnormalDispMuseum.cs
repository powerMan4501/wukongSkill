using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using BtlB1;
using BtlShare;
using GSDispLib;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.EditorScriptingUtilities;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUAbnormalDispMuseum")]
public class BUAbnormalDispMuseum : BGUActorBaseCS
{
	public Dictionary<ASkeletalMeshActor, List<int>> DBCReqIDList_Niagara = new Dictionary<ASkeletalMeshActor, List<int>>();

	public Dictionary<ASkeletalMeshActor, List<int>> DBCReqIDList_Mat = new Dictionary<ASkeletalMeshActor, List<int>>();

	public List<AActor> ImmueBoxList = new List<AActor>();

	public List<AActor> DebugStringActorList = new List<AActor>();

	private static bool Root_IsValid;

	private static int Root_Offset;

	private static bool SKMeshActors_IsValid;

	private static int SKMeshActors_Offset;

	private static FFieldAddress SKMeshActors_PropertyAddress;

	private TArrayReadWriteMarshaler<ASkeletalMeshActor> SKMeshActors_Marshaler;

	private static bool SKMeshActors_WithRowIndex_IsValid;

	private static int SKMeshActors_WithRowIndex_Offset;

	private static FFieldAddress SKMeshActors_WithRowIndex_PropertyAddress;

	private TMapReadWriteMarshaler<int, FGridRow_ForAbnormalDisp> SKMeshActors_WithRowIndex_Marshaler;

	private static bool SKMap_IsValid;

	private static int SKMap_Offset;

	private static FFieldAddress SKMap_PropertyAddress;

	private TMapReadWriteMarshaler<string, FTamerInfo_ForAbnormal> SKMap_Marshaler;

	private static bool SKMap_Conflict_IsValid;

	private static int SKMap_Conflict_Offset;

	private static FFieldAddress SKMap_Conflict_PropertyAddress;

	private TArrayReadWriteMarshaler<FTamerInfo_ForAbnormal> SKMap_Conflict_Marshaler;

	private static bool csvFilePath_IsValid;

	private static int csvFilePath_Offset;

	private static bool ImmueStaticMesh_IsValid;

	private static int ImmueStaticMesh_Offset;

	private static bool DebugNumerClass_IsValid;

	private static int DebugNumerClass_Offset;

	private static bool RowIndex_IsValid;

	private static int RowIndex_Offset;

	private static bool AttackerDispID_IsValid;

	private static int AttackerDispID_Offset;

	private static bool AbnormalType_IsValid;

	private static int AbnormalType_Offset;

	private static FFieldAddress AbnormalType_PropertyAddress;

	private static bool ActionTypeList_IsValid;

	private static int ActionTypeList_Offset;

	private static FFieldAddress ActionTypeList_PropertyAddress;

	private TArrayReadWriteMarshaler<EAbnromalDispActionType> ActionTypeList_Marshaler;

	private static bool ActionTypeList_FreezeExt_IsValid;

	private static int ActionTypeList_FreezeExt_Offset;

	private static FFieldAddress ActionTypeList_FreezeExt_PropertyAddress;

	private TArrayReadWriteMarshaler<BGW_GameDB.EAbnromalDispActionType_FreezeExt> ActionTypeList_FreezeExt_Marshaler;

	private static bool CurSelectedActors_IsValid;

	private static int CurSelectedActors_Offset;

	private static FFieldAddress CurSelectedActors_PropertyAddress;

	private TArrayReadWriteMarshaler<ASkeletalMeshActor> CurSelectedActors_Marshaler;

	private static bool Preview_IsValid;

	private static IntPtr Preview_FunctionAddress;

	private static int Preview_ParamsSize;

	private static bool SpawnGrid_IsValid;

	private static IntPtr SpawnGrid_FunctionAddress;

	private static int SpawnGrid_ParamsSize;

	private static bool UpdateData_IsValid;

	private static IntPtr UpdateData_FunctionAddress;

	private static int UpdateData_ParamsSize;

	private static bool GenSKMuseumData_IsValid;

	private static IntPtr GenSKMuseumData_FunctionAddress;

	private static int GenSKMuseumData_ParamsSize;

	private static bool ReceiveTick_IsValid;

	private static IntPtr ReceiveTick_FunctionAddress;

	private static int ReceiveTick_ParamsSize;

	private static bool ReceiveTick_DeltaSeconds_IsValid;

	private static int ReceiveTick_DeltaSeconds_Offset;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAbnormalDispMuseum:Root")]
	public USceneComponent Root
	{
		get
		{
			CheckDestroyed();
			if (!Root_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAbnormalDispMuseum:Root");
				return null;
			}
			return UObjectMarshaler<USceneComponent>.FromNative(IntPtr.Add(base.Address, Root_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Root_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAbnormalDispMuseum:Root");
			}
			else
			{
				UObjectMarshaler<USceneComponent>.ToNative(IntPtr.Add(base.Address, Root_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUAbnormalDispMuseum:SKMeshActors")]
	public TArrayReadWrite<ASkeletalMeshActor> SKMeshActors
	{
		get
		{
			CheckDestroyed();
			if (!SKMeshActors_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAbnormalDispMuseum:SKMeshActors");
				return null;
			}
			if (SKMeshActors_Marshaler == null)
			{
				SKMeshActors_Marshaler = new TArrayReadWriteMarshaler<ASkeletalMeshActor>(1, SKMeshActors_PropertyAddress, CachedMarshalingDelegates<ASkeletalMeshActor, UObjectMarshaler<ASkeletalMeshActor>>.FromNative, CachedMarshalingDelegates<ASkeletalMeshActor, UObjectMarshaler<ASkeletalMeshActor>>.ToNative);
			}
			return SKMeshActors_Marshaler.FromNative(IntPtr.Add(base.Address, SKMeshActors_Offset));
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUAbnormalDispMuseum:SKMeshActors_WithRowIndex")]
	public TMapReadWrite<int, FGridRow_ForAbnormalDisp> SKMeshActors_WithRowIndex
	{
		get
		{
			CheckDestroyed();
			if (!SKMeshActors_WithRowIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAbnormalDispMuseum:SKMeshActors_WithRowIndex");
				return null;
			}
			if (SKMeshActors_WithRowIndex_Marshaler == null)
			{
				SKMeshActors_WithRowIndex_Marshaler = new TMapReadWriteMarshaler<int, FGridRow_ForAbnormalDisp>(1, SKMeshActors_WithRowIndex_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative, CachedMarshalingDelegates<FGridRow_ForAbnormalDisp, FGridRow_ForAbnormalDisp>.FromNative, CachedMarshalingDelegates<FGridRow_ForAbnormalDisp, FGridRow_ForAbnormalDisp>.ToNative);
			}
			return SKMeshActors_WithRowIndex_Marshaler.FromNative(IntPtr.Add(base.Address, SKMeshActors_WithRowIndex_Offset));
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAbnormalDispMuseum:SKMap")]
	public TMapReadWrite<string, FTamerInfo_ForAbnormal> SKMap
	{
		get
		{
			CheckDestroyed();
			if (!SKMap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAbnormalDispMuseum:SKMap");
				return null;
			}
			if (SKMap_Marshaler == null)
			{
				SKMap_Marshaler = new TMapReadWriteMarshaler<string, FTamerInfo_ForAbnormal>(1, SKMap_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<FTamerInfo_ForAbnormal, FTamerInfo_ForAbnormal>.FromNative, CachedMarshalingDelegates<FTamerInfo_ForAbnormal, FTamerInfo_ForAbnormal>.ToNative);
			}
			return SKMap_Marshaler.FromNative(IntPtr.Add(base.Address, SKMap_Offset));
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUAbnormalDispMuseum:SKMap_Conflict")]
	public TArrayReadWrite<FTamerInfo_ForAbnormal> SKMap_Conflict
	{
		get
		{
			CheckDestroyed();
			if (!SKMap_Conflict_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAbnormalDispMuseum:SKMap_Conflict");
				return null;
			}
			if (SKMap_Conflict_Marshaler == null)
			{
				SKMap_Conflict_Marshaler = new TArrayReadWriteMarshaler<FTamerInfo_ForAbnormal>(1, SKMap_Conflict_PropertyAddress, CachedMarshalingDelegates<FTamerInfo_ForAbnormal, FTamerInfo_ForAbnormal>.FromNative, CachedMarshalingDelegates<FTamerInfo_ForAbnormal, FTamerInfo_ForAbnormal>.ToNative);
			}
			return SKMap_Conflict_Marshaler.FromNative(IntPtr.Add(base.Address, SKMap_Conflict_Offset));
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUAbnormalDispMuseum:csvFilePath")]
	public string csvFilePath
	{
		get
		{
			CheckDestroyed();
			if (!csvFilePath_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAbnormalDispMuseum:csvFilePath");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, csvFilePath_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!csvFilePath_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAbnormalDispMuseum:csvFilePath");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, csvFilePath_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("OCEANTest")]
	[DisplayName("免疫遮罩盒子")]
	[USharpPath("/Script/b1-Managed.BUAbnormalDispMuseum:ImmueStaticMesh")]
	public UStaticMesh ImmueStaticMesh
	{
		get
		{
			CheckDestroyed();
			if (!ImmueStaticMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAbnormalDispMuseum:ImmueStaticMesh");
				return null;
			}
			return UObjectMarshaler<UStaticMesh>.FromNative(IntPtr.Add(base.Address, ImmueStaticMesh_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ImmueStaticMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAbnormalDispMuseum:ImmueStaticMesh");
			}
			else
			{
				UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(base.Address, ImmueStaticMesh_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("OCEANTest")]
	[USharpPath("/Script/b1-Managed.BUAbnormalDispMuseum:DebugNumerClass")]
	public TSubclassOf<AActor> DebugNumerClass
	{
		get
		{
			CheckDestroyed();
			if (!DebugNumerClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAbnormalDispMuseum:DebugNumerClass");
				return default(TSubclassOf<AActor>);
			}
			return TSubclassOfMarshaler<AActor>.FromNative(IntPtr.Add(base.Address, DebugNumerClass_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DebugNumerClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAbnormalDispMuseum:DebugNumerClass");
			}
			else
			{
				TSubclassOfMarshaler<AActor>.ToNative(IntPtr.Add(base.Address, DebugNumerClass_Offset), value);
			}
		}
	}

	[DisplayName("测试行ID")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("OCEANTest")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAbnormalDispMuseum:RowIndex")]
	public int RowIndex
	{
		get
		{
			CheckDestroyed();
			if (!RowIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAbnormalDispMuseum:RowIndex");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, RowIndex_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RowIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAbnormalDispMuseum:RowIndex");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, RowIndex_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("OCEANTest")]
	[DisplayName("攻击者表现ID")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAbnormalDispMuseum:AttackerDispID")]
	public int AttackerDispID
	{
		get
		{
			CheckDestroyed();
			if (!AttackerDispID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAbnormalDispMuseum:AttackerDispID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, AttackerDispID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AttackerDispID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAbnormalDispMuseum:AttackerDispID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, AttackerDispID_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("OCEANTest")]
	[DisplayName("异常状态类型")]
	[USharpPath("/Script/b1-Managed.BUAbnormalDispMuseum:AbnormalType")]
	public EAbnormalStateType AbnormalType
	{
		get
		{
			CheckDestroyed();
			if (!AbnormalType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAbnormalDispMuseum:AbnormalType");
				return EAbnormalStateType.None;
			}
			return EnumMarshaler<EAbnormalStateType>.FromNative(IntPtr.Add(base.Address, AbnormalType_Offset), 0, AbnormalType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AbnormalType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAbnormalDispMuseum:AbnormalType");
			}
			else
			{
				EnumMarshaler<EAbnormalStateType>.ToNative(IntPtr.Add(base.Address, AbnormalType_Offset), 0, AbnormalType_PropertyAddress.Address, value);
			}
		}
	}

	[Category("OCEANTest")]
	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("表现类型")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUAbnormalDispMuseum:ActionTypeList")]
	public TArrayReadWrite<EAbnromalDispActionType> ActionTypeList
	{
		get
		{
			CheckDestroyed();
			if (!ActionTypeList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAbnormalDispMuseum:ActionTypeList");
				return null;
			}
			if (ActionTypeList_Marshaler == null)
			{
				ActionTypeList_Marshaler = new TArrayReadWriteMarshaler<EAbnromalDispActionType>(1, ActionTypeList_PropertyAddress, CachedMarshalingDelegates<EAbnromalDispActionType, EnumMarshaler<EAbnromalDispActionType>>.FromNative, CachedMarshalingDelegates<EAbnromalDispActionType, EnumMarshaler<EAbnromalDispActionType>>.ToNative);
			}
			return ActionTypeList_Marshaler.FromNative(IntPtr.Add(base.Address, ActionTypeList_Offset));
		}
	}

	[DisplayName("冰额外表现类型")]
	[Category("OCEANTest")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAbnormalDispMuseum:ActionTypeList_FreezeExt")]
	public TArrayReadWrite<BGW_GameDB.EAbnromalDispActionType_FreezeExt> ActionTypeList_FreezeExt
	{
		get
		{
			CheckDestroyed();
			if (!ActionTypeList_FreezeExt_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAbnormalDispMuseum:ActionTypeList_FreezeExt");
				return null;
			}
			if (ActionTypeList_FreezeExt_Marshaler == null)
			{
				ActionTypeList_FreezeExt_Marshaler = new TArrayReadWriteMarshaler<BGW_GameDB.EAbnromalDispActionType_FreezeExt>(1, ActionTypeList_FreezeExt_PropertyAddress, CachedMarshalingDelegates<BGW_GameDB.EAbnromalDispActionType_FreezeExt, EnumMarshaler<BGW_GameDB.EAbnromalDispActionType_FreezeExt>>.FromNative, CachedMarshalingDelegates<BGW_GameDB.EAbnromalDispActionType_FreezeExt, EnumMarshaler<BGW_GameDB.EAbnromalDispActionType_FreezeExt>>.ToNative);
			}
			return ActionTypeList_FreezeExt_Marshaler.FromNative(IntPtr.Add(base.Address, ActionTypeList_FreezeExt_Offset));
		}
	}

	[BlueprintReadWrite]
	[VisibleAnywhere]
	[UProperty]
	[DisplayName("当前涉及效果修改的实例列表")]
	[Category("调试可见")]
	[USharpPath("/Script/b1-Managed.BUAbnormalDispMuseum:CurSelectedActors")]
	public TArrayReadWrite<ASkeletalMeshActor> CurSelectedActors
	{
		get
		{
			CheckDestroyed();
			if (!CurSelectedActors_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAbnormalDispMuseum:CurSelectedActors");
				return null;
			}
			if (CurSelectedActors_Marshaler == null)
			{
				CurSelectedActors_Marshaler = new TArrayReadWriteMarshaler<ASkeletalMeshActor>(1, CurSelectedActors_PropertyAddress, CachedMarshalingDelegates<ASkeletalMeshActor, UObjectMarshaler<ASkeletalMeshActor>>.FromNative, CachedMarshalingDelegates<ASkeletalMeshActor, UObjectMarshaler<ASkeletalMeshActor>>.ToNative);
			}
			return CurSelectedActors_Marshaler.FromNative(IntPtr.Add(base.Address, CurSelectedActors_Offset));
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		base.PrimaryActorTick.SetCanEverTick(canEverTick: true);
		Root = initializer.CreateDefaultSubobject<USceneComponent>(this, B1GlobalFNames.Root);
		SetRootComponentCS(Root);
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<BUS_ActorBaseDataComp>(this, B1GlobalFNames.DataComp);
	}

	[UMeta(MDFunc.CallInEditor)]
	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BUAbnormalDispMuseum:GenSKMuseumData")]
	public void GenSKMuseumData()
	{
		if (string.IsNullOrEmpty(csvFilePath))
		{
			return;
		}
		SKMap_Conflict.Clear();
		SKMap.Clear();
		StreamReader streamReader = new StreamReader(csvFilePath);
		try
		{
			while (streamReader.Peek() > 0)
			{
				string[] array = streamReader.ReadLine().Split(',');
				if (array.Length < 10 || array[0] == "TamerFileName" || string.IsNullOrEmpty(array[3]))
				{
					continue;
				}
				FTamerInfo_ForAbnormal value = new FTamerInfo_ForAbnormal
				{
					SKMeshPath = array[3],
					TamerPath = array[1],
					TamerFileName = array[0],
					SKScale = float.Parse(array[4]),
					AbnormalDispID_Attacker = int.Parse(array[6]),
					AbnormalDispID_Victim = int.Parse(array[7])
				};
				if (SKMap.ContainsKey(value.TamerFileName))
				{
					continue;
				}
				value.TamerFileName.Contains("baijiang");
				bool flag = false;
				foreach (FTamerInfo_ForAbnormal value2 in SKMap.Values)
				{
					if (value2.SKMeshPath == value.SKMeshPath && FMath.Abs(value2.SKScale - value.SKScale) < 0.001f && value2.AbnormalDispID_Victim == value.AbnormalDispID_Victim)
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					SKMap.Add(value.TamerFileName, value);
				}
			}
			streamReader.Close();
		}
		catch
		{
			streamReader.Close();
		}
	}

	[UFunction]
	[UMeta(MDFunc.CallInEditor)]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BUAbnormalDispMuseum:SpawnGrid")]
	public void SpawnGrid()
	{
		foreach (ASkeletalMeshActor sKMeshActor in SKMeshActors)
		{
			if (sKMeshActor != null)
			{
				sKMeshActor.DestroyActor();
			}
		}
		SKMeshActors.Clear();
		SKMeshActors_WithRowIndex.Clear();
		foreach (string key in SKMap.Keys)
		{
			USkeletalMesh uSkeletalMesh = UObject.LoadObject<USkeletalMesh>(this, SKMap[key].SKMeshPath);
			if (uSkeletalMesh != null)
			{
				ASkeletalMeshActor aSkeletalMeshActor = UEditorLevelLibrary.SpawnActorFromClass(UClass.GetClass<ASkeletalMeshActor>(), FVector.ZeroVector, FRotator.ZeroRotator) as ASkeletalMeshActor;
				if (aSkeletalMeshActor != null)
				{
					aSkeletalMeshActor.SkeletalMeshComponent.SkeletalMesh = uSkeletalMesh;
					aSkeletalMeshActor.SetActorLabel(key);
					aSkeletalMeshActor.SetActorScale3D(FVector.OneVector * SKMap[key].SKScale);
					SKMeshActors.Add(aSkeletalMeshActor);
				}
			}
		}
		float num = 1000f;
		float num2 = 1000f;
		float num3 = 300f;
		float num4 = 20000f;
		Dictionary<ASkeletalMeshActor, float> dictionary = new Dictionary<ASkeletalMeshActor, float>();
		List<ASkeletalMeshActor> list = new List<ASkeletalMeshActor>();
		foreach (ASkeletalMeshActor sKMeshActor2 in SKMeshActors)
		{
			sKMeshActor2.GetActorBounds(bOnlyCollidingComponents: false, out var _, out var BoxExtent);
			if (BoxExtent.X >= num)
			{
				list.Add(sKMeshActor2);
			}
			else
			{
				dictionary.Add(sKMeshActor2, BoxExtent.Y);
			}
		}
		IOrderedEnumerable<KeyValuePair<ASkeletalMeshActor, float>> orderedEnumerable = dictionary.OrderBy(delegate(KeyValuePair<ASkeletalMeshActor, float> pair)
		{
			KeyValuePair<ASkeletalMeshActor, float> keyValuePair = pair;
			return keyValuePair.Value;
		});
		float num5 = 0f;
		FVector zeroVector = FVector.ZeroVector;
		float num6 = 0f;
		List<ASkeletalMeshActor> list2 = new List<ASkeletalMeshActor>();
		int num7 = 1;
		foreach (KeyValuePair<ASkeletalMeshActor, float> item in orderedEnumerable)
		{
			if (num6 >= num4)
			{
				FGridRow_ForAbnormalDisp value = default(FGridRow_ForAbnormalDisp);
				value.ActorList = new List<ASkeletalMeshActor>();
				value.ActorList.AddRange(list2);
				SKMeshActors_WithRowIndex.Add(num7, value);
				list2.Clear();
				num7++;
				zeroVector -= FVector.ForwardVector * (num5 + num2);
				num5 = 0f;
				num6 = 0f;
			}
			item.Key.GetActorBounds(bOnlyCollidingComponents: false, out var _, out var BoxExtent2);
			if (BoxExtent2.X > num5)
			{
				num5 = BoxExtent2.X;
			}
			float value2 = item.Value;
			FVector newLocation = zeroVector - FVector.RightVector * (num6 + value2 + num3);
			num6 += value2 * 2f + num3;
			item.Key.SetActorLocation(newLocation, bSweep: false, out var _, bTeleport: false);
			list2.Add(item.Key);
		}
		FGridRow_ForAbnormalDisp value3 = default(FGridRow_ForAbnormalDisp);
		value3.ActorList = new List<ASkeletalMeshActor>();
		value3.ActorList.AddRange(list2);
		SKMeshActors_WithRowIndex.Add(num7, value3);
		list2.Clear();
		num7++;
		zeroVector -= FVector.ForwardVector * (num5 + num2);
		num5 = 0f;
		num6 = 0f;
		foreach (ASkeletalMeshActor item2 in list)
		{
			item2.GetActorBounds(bOnlyCollidingComponents: false, out var _, out var BoxExtent3);
			float y = BoxExtent3.Y;
			FVector newLocation2 = zeroVector - FVector.RightVector * (num6 + y + num3) - FVector.ForwardVector * BoxExtent3.X;
			num6 += y * 2f + num3;
			item2.SetActorLocation(newLocation2, bSweep: false, out var _, bTeleport: false);
			list2.Add(item2);
		}
		FGridRow_ForAbnormalDisp value4 = default(FGridRow_ForAbnormalDisp);
		value4.ActorList = new List<ASkeletalMeshActor>();
		value4.ActorList.AddRange(list2);
		SKMeshActors_WithRowIndex.Add(num7, value4);
	}

	[UFunction]
	[Category("OCEANTest")]
	[BlueprintCallable]
	[UMeta(MDFunc.CallInEditor)]
	[USharpPath("/Script/b1-Managed.BUAbnormalDispMuseum:Preview")]
	public void Preview()
	{
		if (UBGUFunctionLibraryForCS.BGUGetIsInEditorPreview(base.World))
		{
			return;
		}
		EndCurEffect();
		CurSelectedActors.Clear();
		if (!SKMeshActors_WithRowIndex.TryGetValue(RowIndex, out var value))
		{
			return;
		}
		foreach (ASkeletalMeshActor actor in value.ActorList)
		{
			CurSelectedActors.Add(actor);
		}
		CastEffect();
	}

	[BlueprintCallable]
	[UMeta(MDFunc.CallInEditor)]
	[Category("OCEANTest")]
	[Tooltip("不更新SK信息和缩放信息")]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BUAbnormalDispMuseum:UpdateData")]
	public void UpdateData()
	{
		BGUFuncLibNonRuntime.LoadProtobufData<FUStUnitCommDesc>();
		BGUFuncLibNonRuntime.LoadProtobufData<FUStUnitBattleInfoExtendDesc>();
		foreach (string key in SKMap.Keys)
		{
			string tamerPath = SKMap[key].TamerPath;
			BUTamerActor bUTamerActor = UObject.LoadObject<BUTamerActor>(this, tamerPath);
			if (bUTamerActor == null)
			{
				continue;
			}
			FTamerInfo_ForAbnormal fTamerInfo_ForAbnormal = default(FTamerInfo_ForAbnormal);
			fTamerInfo_ForAbnormal = SKMap[key];
			fTamerInfo_ForAbnormal.ImmueList = new List<Birth_AbnormalStateImmueType>();
			fTamerInfo_ForAbnormal.ResID = bUTamerActor.ConfigInfoComp.UnitCDesc.ResID;
			fTamerInfo_ForAbnormal.AbnormalDispID_Attacker = 0;
			fTamerInfo_ForAbnormal.AbnormalDispID_Victim = 0;
			fTamerInfo_ForAbnormal.ErrorFlag = false;
			fTamerInfo_ForAbnormal.ErrorLog = "";
			foreach (Birth_AbnormalStateImmueType abnormalStateImmue in bUTamerActor.ExtendConfigComp.AbnormalStateImmueList)
			{
				fTamerInfo_ForAbnormal.ImmueList.Add(abnormalStateImmue);
			}
			FUStUnitCommDesc unitCommDesc = BGW_GameDB.GetUnitCommDesc(fTamerInfo_ForAbnormal.ResID);
			if (unitCommDesc == null)
			{
				fTamerInfo_ForAbnormal.ErrorFlag = true;
				fTamerInfo_ForAbnormal.ErrorLog = $"UnitComm表中查询不到ResID{fTamerInfo_ForAbnormal.ResID}";
			}
			else
			{
				int defaultBattleInfoExtendID = unitCommDesc.DefaultBattleInfoExtendID;
				int overrideID = bUTamerActor.ConfigInfoComp.UnitCDesc.OverrideID;
				int num = (fTamerInfo_ForAbnormal.FinnalExtendID = ((overrideID > 0) ? overrideID : defaultBattleInfoExtendID));
				FUStUnitBattleInfoExtendDesc unitBattleInfoExtendDesc = BGW_GameDB.GetUnitBattleInfoExtendDesc(num);
				if (unitBattleInfoExtendDesc == null)
				{
					fTamerInfo_ForAbnormal.ErrorFlag = true;
					fTamerInfo_ForAbnormal.ErrorLog = $"UnitBattleInfoExtend表中查询不到ExtendID{num}, Default{defaultBattleInfoExtendID}, Override{overrideID}";
				}
				else
				{
					fTamerInfo_ForAbnormal.AbnormalDispID_Attacker = unitBattleInfoExtendDesc.AbnormalDispAttackerID;
					fTamerInfo_ForAbnormal.AbnormalDispID_Victim = unitBattleInfoExtendDesc.AbnormalDispVictimID;
				}
			}
			SKMap[key] = fTamerInfo_ForAbnormal;
		}
	}

	[USharpPath("/Script/b1-Managed.BUAbnormalDispMuseum:ReceiveTick")]
	protected override void ReceiveTick_Implementation(float DeltaSeconds)
	{
		foreach (AActor immueBox in ImmueBoxList)
		{
			immueBox.GetActorBounds(bOnlyCollidingComponents: false, out var Origin, out var BoxExtent);
			USystemLibrary.DrawDebugBox(this, Origin, BoxExtent, FLinearColor.Red, immueBox.GetActorRotation(), 0f, 10f);
		}
	}

	public void CastEffect()
	{
		if (CurSelectedActors == null || CurSelectedActors.Count < 1)
		{
			return;
		}
		foreach (EAbnromalDispActionType actionType in ActionTypeList)
		{
			string text = "";
			BGWDataAsset_B1DBC bGWDataAsset_B1DBC = null;
			string name = "";
			BGWDataAsset_B1DBC bGWDataAsset_B1DBC2 = null;
			if (BGW_GameDB.GetAbnormalDispModifyInfo_Attacker(AbnormalType, actionType, 0, out var _, out var DBCPath))
			{
				text = DBCPath;
			}
			if (BGW_GameDB.GetAbnormalDispModifyInfo_Attacker(AbnormalType, actionType, AttackerDispID, out var ModifyType2, out var DBCPath2))
			{
				switch (ModifyType2)
				{
				case EAbnormalDispModifyType.Modify:
					name = DBCPath2;
					break;
				case EAbnormalDispModifyType.Override:
					text = DBCPath2;
					break;
				}
			}
			if (string.IsNullOrEmpty(text))
			{
				return;
			}
			bGWDataAsset_B1DBC = UObject.LoadObject<BGWDataAsset_B1DBC>(this, text);
			if (bGWDataAsset_B1DBC == null)
			{
				return;
			}
			bGWDataAsset_B1DBC2 = UObject.LoadObject<BGWDataAsset_B1DBC>(this, name);
			int num = 0;
			int num2 = 1;
			int num3 = 2;
			foreach (ASkeletalMeshActor curSelectedActor in CurSelectedActors)
			{
				if (curSelectedActor == null || curSelectedActor.SkeletalMeshComponent.SkeletalMesh == null)
				{
					continue;
				}
				string actorLabel = curSelectedActor.GetActorLabel();
				bool flag = false;
				if (!SKMap.TryGetValue(actorLabel, out var value))
				{
					continue;
				}
				switch (AbnormalType)
				{
				case EAbnormalStateType.Abnormal_Freeze:
					if (value.ImmueList.Contains(Birth_AbnormalStateImmueType.FreezeImmue))
					{
						flag = true;
					}
					break;
				case EAbnormalStateType.Abnormal_Burn:
					if (value.ImmueList.Contains(Birth_AbnormalStateImmueType.BurnImmue))
					{
						flag = true;
					}
					break;
				case EAbnormalStateType.Abnormal_Poison:
					if (value.ImmueList.Contains(Birth_AbnormalStateImmueType.PoisonImmue))
					{
						flag = true;
					}
					break;
				case EAbnormalStateType.Abnormal_Thunder:
					if (value.ImmueList.Contains(Birth_AbnormalStateImmueType.ThunderImmue))
					{
						flag = true;
					}
					break;
				}
				if (flag && ImmueStaticMesh != null)
				{
					FBox boundingBox = ImmueStaticMesh.GetBoundingBox();
					curSelectedActor.GetActorBounds(bOnlyCollidingComponents: false, out var Origin, out var BoxExtent);
					FRotator rotation = curSelectedActor.GetActorRotation();
					AStaticMeshActor aStaticMeshActor = base.World.SpawnActor<AStaticMeshActor>(ref Origin, ref rotation) as AStaticMeshActor;
					if (aStaticMeshActor != null)
					{
						aStaticMeshActor.SetMobility(EComponentMobility.Movable);
						aStaticMeshActor.StaticMeshComponent.StaticMesh = ImmueStaticMesh;
						FVector max = boundingBox.Max;
						FVector newLocation = Origin;
						aStaticMeshActor.SetActorLocation(newLocation, bSweep: false, out var _, bTeleport: false);
						FVector oneVector = FVector.OneVector;
						if (max.X != 0f)
						{
							oneVector.X = BoxExtent.X / max.X;
						}
						if (max.Y != 0f)
						{
							oneVector.Y = BoxExtent.Y / max.Y;
						}
						if (max.Z != 0f)
						{
							oneVector.Z = BoxExtent.Z / max.Z;
						}
						aStaticMeshActor.SetActorScale3D(oneVector);
						ImmueBoxList.Add(aStaticMeshActor);
					}
					continue;
				}
				List<UNiagaraComponent> list = new List<UNiagaraComponent>();
				foreach (BUC_DispLibDBC_PlayNiagara item11 in bGWDataAsset_B1DBC.PlayNiagara)
				{
					int item = (int)DispLib_EditorDBCPreviewToolActor.Editor_RquestPlayOneDBCCommonNiagara(SpawnData: new BUC_DispLibDBC_PlayNiagara(0f, DispLibDBCEndMode.ProcedureNotity, item11.Duration, item11.DelayTimeAfterStop, item11.DestroyTiming, item11.Template, FName.None, item11.AttachedTarget, item11.AttachedTargetSocketName, item11.OffsetInLocalSpace, item11.LocationOffset, item11.RotationOffset, item11.Scale, item11.SnapGround, item11.SnapGroundRotationMode, item11.DetachOnEndDispStageBegin, item11.EnableShadow, item11.TranslucentSortPriority, _ForcePoolModeNone: false, item11.PausePriority, item11.PauseMode, item11.EndStagePriority, 0, DispLibDBCNiagaraForceVisibleStateMode.ImmdSetCompVisibleState, item11.MetaString, item11.ScalabilitySettings), DBCRefParam: DispLibRefParam.Instance, MeshComp: curSelectedActor.SkeletalMeshComponent, AnimNotifyUniqueID: GetUniqueID(), MontageUniqueID: 0u);
					UNiagaraComponent dBCReturn_FirstNC = DispLibRefParam.Instance.DBCReturn_FirstNC;
					list.Add(dBCReturn_FirstNC);
					if (!DBCReqIDList_Niagara.ContainsKey(curSelectedActor))
					{
						DBCReqIDList_Niagara.Add(curSelectedActor, new List<int>());
					}
					DBCReqIDList_Niagara[curSelectedActor].Add(item);
				}
				foreach (BUC_DispLibDBC_PlayAdvanceNiagara item12 in bGWDataAsset_B1DBC.PlayAdvanceNiagara)
				{
					int item2 = (int)DispLib_EditorDBCPreviewToolActor.Editor_RquestPlayOneDBCCommonNiagara(SpawnData: new BUC_DispLibDBC_PlayNiagara(0f, DispLibDBCEndMode.ProcedureNotity, item12.Duration, item12.DelayTimeAfterStop, item12.DestroyTiming, item12.Template, FName.None, item12.AttachedTarget, item12.AttachedTargetSocketName, item12.OffsetInLocalSpace, item12.AttachedTargetLocationOffset, item12.AttachedTargetRotationOffset, item12.Scale, item12.SnapGround, item12.SnapGroundRotationMode, item12.DetachOnEndDispStageBegin, item12.EnableShadow, item12.TranslucentSortPriority, _ForcePoolModeNone: false, item12.PausePriority, item12.PauseMode, item12.EndStagePriority, 0, DispLibDBCNiagaraForceVisibleStateMode.ImmdSetCompVisibleState, item12.MetaString, item12.ScalabilitySettings), DBCRefParam: DispLibRefParam.Instance, MeshComp: curSelectedActor.SkeletalMeshComponent, AnimNotifyUniqueID: GetUniqueID(), MontageUniqueID: 0u);
					UNiagaraComponent dBCReturn_FirstNC2 = DispLibRefParam.Instance.DBCReturn_FirstNC;
					if (item12.SetSelfSKMeshParam)
					{
						UNiagaraFunctionLibrary.OverrideSystemUserVariableSkeletalMeshComponent(dBCReturn_FirstNC2, "User.GS_EfxSelfSkeletalMesh", curSelectedActor.SkeletalMeshComponent);
					}
					list.Add(dBCReturn_FirstNC2);
					if (!DBCReqIDList_Niagara.ContainsKey(curSelectedActor))
					{
						DBCReqIDList_Niagara.Add(curSelectedActor, new List<int>());
					}
					DBCReqIDList_Niagara[curSelectedActor].Add(item2);
				}
				foreach (BUC_DispLibDBC_ModifyMaterial item13 in bGWDataAsset_B1DBC.ModifyMaterial)
				{
					BUC_DispLibDBC_ModifyMaterial d = default(BUC_DispLibDBC_ModifyMaterial).SetCustomData(item13.FilterMode, item13.Delay, DispLibDBCEndMode.ProcedureNotity, item13.Duration, item13.DelayTimeAfterStop, item13.Template, item13.InheriParamsMode, item13.InheritScalarParam.ToList(), item13.InheritFLinearColorParam.ToList(), item13.InheritTextureParam.ToList(), item13.SetScalarParam.ToList(), item13.SetFLinearColorParam.ToList(), item13.SetTextureParam.ToList(), item13.SetPCurveScalarParam.ToList(), item13.SetPCurveFLinearColorParam.ToList(), item13.PausePriority, num, num, num);
					if (BWS_DispLibDBCManageComp.ValidateDBCModifyMaterial(d))
					{
						int item3 = (int)DispLib_EditorDBCPreviewToolActor.Editor_RequestApplyModMat(curSelectedActor.SkeletalMeshComponent, d, GetUniqueID(), 0u);
						if (!DBCReqIDList_Mat.ContainsKey(curSelectedActor))
						{
							DBCReqIDList_Mat.Add(curSelectedActor, new List<int>());
						}
						DBCReqIDList_Mat[curSelectedActor].Add(item3);
					}
				}
				if (bGWDataAsset_B1DBC2 != null)
				{
					foreach (BUC_DispLibDBC_ModifyMaterial item14 in bGWDataAsset_B1DBC2.ModifyMaterial)
					{
						BUC_DispLibDBC_ModifyMaterial d2 = default(BUC_DispLibDBC_ModifyMaterial).SetCustomData(item14.FilterMode, item14.Delay, DispLibDBCEndMode.ProcedureNotity, item14.Duration, item14.DelayTimeAfterStop, item14.Template, item14.InheriParamsMode, item14.InheritScalarParam.ToList(), item14.InheritFLinearColorParam.ToList(), item14.InheritTextureParam.ToList(), item14.SetScalarParam.ToList(), item14.SetFLinearColorParam.ToList(), item14.SetTextureParam.ToList(), item14.SetPCurveScalarParam.ToList(), item14.SetPCurveFLinearColorParam.ToList(), item14.PausePriority, num2, num2, num2);
						if (BWS_DispLibDBCManageComp.ValidateDBCModifyMaterial(d2))
						{
							int item4 = (int)DispLib_EditorDBCPreviewToolActor.Editor_RequestApplyModMat(curSelectedActor.SkeletalMeshComponent, d2, GetUniqueID(), 0u);
							if (!DBCReqIDList_Mat.ContainsKey(curSelectedActor))
							{
								DBCReqIDList_Mat.Add(curSelectedActor, new List<int>());
							}
							DBCReqIDList_Mat[curSelectedActor].Add(item4);
						}
					}
					foreach (BUC_DispLibDBC_ModifyNiagaraParams modifyNiagaraParam in bGWDataAsset_B1DBC2.ModifyNiagaraParams)
					{
						foreach (UNiagaraComponent item15 in list)
						{
							foreach (BUC_DispLibUtil_ModNiagara_NameAndBoolValue item16 in modifyNiagaraParam.SetBoolParam)
							{
								FName paramName = item16.ParamName;
								item15.SetBoolParameter(paramName, item16.Value);
							}
							foreach (BUC_DispLibUtil_ModifyNiagaraParams_FloatParam item17 in modifyNiagaraParam.SetFloatParam)
							{
								FName paramName2 = item17.ParamName;
								if (item17.ProcessValue.Mode == DispLibDBCAdvProcessModifyNiagaraParamUtilMode.Standard)
								{
									float value2 = item17.ProcessValue.Value;
									item15.SetVariableFloat(paramName2, value2);
								}
								else if (item17.ProcessValue.Mode == DispLibDBCAdvProcessModifyNiagaraParamUtilMode.TimedUCurve && !(item17.ProcessValue.Curve == null))
								{
									item17.ProcessValue.Curve.GetTimeRange(out var _, out var MaxTime);
									float floatValue = item17.ProcessValue.Curve.GetFloatValue(MaxTime);
									item15.SetVariableFloat(paramName2, floatValue);
								}
							}
							foreach (BUC_DispLibUtil_ModifyNiagaraParams_FloatParam item18 in modifyNiagaraParam.SetInt32Param)
							{
								FName paramName3 = item18.ParamName;
								if (item18.ProcessValue.Mode == DispLibDBCAdvProcessModifyNiagaraParamUtilMode.Standard)
								{
									float value3 = item18.ProcessValue.Value;
									item15.SetVariableInt(paramName3, (int)value3);
								}
								else if (item18.ProcessValue.Mode == DispLibDBCAdvProcessModifyNiagaraParamUtilMode.TimedUCurve && !(item18.ProcessValue.Curve == null))
								{
									item18.ProcessValue.Curve.GetTimeRange(out var _, out var MaxTime2);
									float floatValue2 = item18.ProcessValue.Curve.GetFloatValue(MaxTime2);
									item15.SetVariableFloat(paramName3, (int)floatValue2);
								}
							}
							foreach (BUC_DispLibUtil_ModifyNiagaraParams_FVectorParam item19 in modifyNiagaraParam.SetFVectorParam)
							{
								FName paramName4 = item19.ParamName;
								if (item19.ProcessValue.Mode == DispLibDBCAdvProcessModifyNiagaraParamUtilMode.Standard)
								{
									FVector value4 = item19.ProcessValue.Value;
									item15.SetVariableVec3(paramName4, value4);
								}
								else if (item19.ProcessValue.Mode == DispLibDBCAdvProcessModifyNiagaraParamUtilMode.TimedUCurve && !(item19.ProcessValue.Curve == null))
								{
									item19.ProcessValue.Curve.GetTimeRange(out var _, out var MaxTime3);
									FVector vectorValue = item19.ProcessValue.Curve.GetVectorValue(MaxTime3);
									item15.SetVariableVec3(paramName4, vectorValue);
								}
							}
							foreach (BUC_DispLibUtil_ModifyNiagaraParams_FLinearColorParam item20 in modifyNiagaraParam.SetFLinearColorParam)
							{
								FName paramName5 = item20.ParamName;
								if (item20.ProcessValue.Mode == DispLibDBCAdvProcessModifyNiagaraParamUtilMode.Standard)
								{
									FLinearColor value5 = item20.ProcessValue.Value;
									item15.SetVariableLinearColor(paramName5, value5);
								}
								else if (item20.ProcessValue.Mode == DispLibDBCAdvProcessModifyNiagaraParamUtilMode.TimedUCurve && !(item20.ProcessValue.Curve == null))
								{
									item20.ProcessValue.Curve.GetTimeRange(out var _, out var MaxTime4);
									FLinearColor linearColorValue = item20.ProcessValue.Curve.GetLinearColorValue(MaxTime4);
									item15.SetVariableLinearColor(paramName5, linearColorValue);
								}
							}
							if (modifyNiagaraParam.SetOverrideSelfMeshBones.Count > 0)
							{
								UGSE_RenderUtilFuncLib.OverrideSystemUserVariableSKMFilteredBones(item15, "User.GS_EfxSelfSkeletalMesh", modifyNiagaraParam.SetOverrideSelfMeshBones.ToList());
							}
							if (modifyNiagaraParam.SetOverrideSelfMeshSockets.Count > 0)
							{
								UGSE_RenderUtilFuncLib.OverrideSystemUserVariableSKMFilteredSockets(item15, "User.GS_EfxSelfSkeletalMesh", modifyNiagaraParam.SetOverrideSelfMeshSockets.ToList());
							}
						}
					}
				}
				int abnormalDispID_Victim = value.AbnormalDispID_Victim;
				if (BGW_GameDB.GetAbnormalDispModifyInfo_Victim(AbnormalType, actionType, abnormalDispID_Victim, out var ModifyType3, out var DBCPath3) && ModifyType3 == EAbnormalDispModifyType.Modify)
				{
					BGWDataAsset_B1DBC bGWDataAsset_B1DBC3 = UObject.LoadObject<BGWDataAsset_B1DBC>(this, DBCPath3);
					if (bGWDataAsset_B1DBC3 == null)
					{
						continue;
					}
					foreach (BUC_DispLibDBC_ModifyMaterial item21 in bGWDataAsset_B1DBC3.ModifyMaterial)
					{
						BUC_DispLibDBC_ModifyMaterial d3 = default(BUC_DispLibDBC_ModifyMaterial).SetCustomData(item21.FilterMode, item21.Delay, DispLibDBCEndMode.ProcedureNotity, item21.Duration, item21.DelayTimeAfterStop, item21.Template, item21.InheriParamsMode, item21.InheritScalarParam.ToList(), item21.InheritFLinearColorParam.ToList(), item21.InheritTextureParam.ToList(), item21.SetScalarParam.ToList(), item21.SetFLinearColorParam.ToList(), item21.SetTextureParam.ToList(), item21.SetPCurveScalarParam.ToList(), item21.SetPCurveFLinearColorParam.ToList(), item21.PausePriority, num3, num3, num3);
						if (BWS_DispLibDBCManageComp.ValidateDBCModifyMaterial(d3))
						{
							int item5 = (int)DispLib_EditorDBCPreviewToolActor.Editor_RequestApplyModMat(curSelectedActor.SkeletalMeshComponent, d3, GetUniqueID(), 0u);
							if (!DBCReqIDList_Mat.ContainsKey(curSelectedActor))
							{
								DBCReqIDList_Mat.Add(curSelectedActor, new List<int>());
							}
							DBCReqIDList_Mat[curSelectedActor].Add(item5);
						}
					}
					foreach (BUC_DispLibDBC_ModifyNiagaraParams modifyNiagaraParam2 in bGWDataAsset_B1DBC3.ModifyNiagaraParams)
					{
						foreach (UNiagaraComponent item22 in list)
						{
							foreach (BUC_DispLibUtil_ModNiagara_NameAndBoolValue item23 in modifyNiagaraParam2.SetBoolParam)
							{
								FName paramName6 = item23.ParamName;
								item22.SetBoolParameter(paramName6, item23.Value);
							}
							foreach (BUC_DispLibUtil_ModifyNiagaraParams_FloatParam item24 in modifyNiagaraParam2.SetFloatParam)
							{
								FName paramName7 = item24.ParamName;
								if (item24.ProcessValue.Mode == DispLibDBCAdvProcessModifyNiagaraParamUtilMode.Standard)
								{
									float value6 = item24.ProcessValue.Value;
									item22.SetVariableFloat(paramName7, value6);
								}
								else if (item24.ProcessValue.Mode == DispLibDBCAdvProcessModifyNiagaraParamUtilMode.TimedUCurve && !(item24.ProcessValue.Curve == null))
								{
									item24.ProcessValue.Curve.GetTimeRange(out var _, out var MaxTime5);
									float floatValue3 = item24.ProcessValue.Curve.GetFloatValue(MaxTime5);
									item22.SetVariableFloat(paramName7, floatValue3);
								}
							}
							foreach (BUC_DispLibUtil_ModifyNiagaraParams_FloatParam item25 in modifyNiagaraParam2.SetInt32Param)
							{
								FName paramName8 = item25.ParamName;
								if (item25.ProcessValue.Mode == DispLibDBCAdvProcessModifyNiagaraParamUtilMode.Standard)
								{
									float value7 = item25.ProcessValue.Value;
									item22.SetVariableInt(paramName8, (int)value7);
								}
								else if (item25.ProcessValue.Mode == DispLibDBCAdvProcessModifyNiagaraParamUtilMode.TimedUCurve && !(item25.ProcessValue.Curve == null))
								{
									item25.ProcessValue.Curve.GetTimeRange(out var _, out var MaxTime6);
									float floatValue4 = item25.ProcessValue.Curve.GetFloatValue(MaxTime6);
									item22.SetVariableFloat(paramName8, (int)floatValue4);
								}
							}
							foreach (BUC_DispLibUtil_ModifyNiagaraParams_FVectorParam item26 in modifyNiagaraParam2.SetFVectorParam)
							{
								FName paramName9 = item26.ParamName;
								if (item26.ProcessValue.Mode == DispLibDBCAdvProcessModifyNiagaraParamUtilMode.Standard)
								{
									FVector value8 = item26.ProcessValue.Value;
									item22.SetVariableVec3(paramName9, value8);
								}
								else if (item26.ProcessValue.Mode == DispLibDBCAdvProcessModifyNiagaraParamUtilMode.TimedUCurve && !(item26.ProcessValue.Curve == null))
								{
									item26.ProcessValue.Curve.GetTimeRange(out var _, out var MaxTime7);
									FVector vectorValue2 = item26.ProcessValue.Curve.GetVectorValue(MaxTime7);
									item22.SetVariableVec3(paramName9, vectorValue2);
								}
							}
							foreach (BUC_DispLibUtil_ModifyNiagaraParams_FLinearColorParam item27 in modifyNiagaraParam2.SetFLinearColorParam)
							{
								FName paramName10 = item27.ParamName;
								if (item27.ProcessValue.Mode == DispLibDBCAdvProcessModifyNiagaraParamUtilMode.Standard)
								{
									FLinearColor value9 = item27.ProcessValue.Value;
									item22.SetVariableLinearColor(paramName10, value9);
								}
								else if (item27.ProcessValue.Mode == DispLibDBCAdvProcessModifyNiagaraParamUtilMode.TimedUCurve && !(item27.ProcessValue.Curve == null))
								{
									item27.ProcessValue.Curve.GetTimeRange(out var _, out var MaxTime8);
									FLinearColor linearColorValue2 = item27.ProcessValue.Curve.GetLinearColorValue(MaxTime8);
									item22.SetVariableLinearColor(paramName10, linearColorValue2);
								}
							}
							if (modifyNiagaraParam2.SetOverrideSelfMeshBones.Count > 0)
							{
								UGSE_RenderUtilFuncLib.OverrideSystemUserVariableSKMFilteredBones(item22, "User.GS_EfxSelfSkeletalMesh", modifyNiagaraParam2.SetOverrideSelfMeshBones.ToList());
							}
							if (modifyNiagaraParam2.SetOverrideSelfMeshSockets.Count > 0)
							{
								UGSE_RenderUtilFuncLib.OverrideSystemUserVariableSKMFilteredSockets(item22, "User.GS_EfxSelfSkeletalMesh", modifyNiagaraParam2.SetOverrideSelfMeshSockets.ToList());
							}
						}
					}
				}
				curSelectedActor.GetActorBounds(bOnlyCollidingComponents: false, out var Origin2, out var BoxExtent2);
				FVector pos = Origin2 + FVector.UpVector * BoxExtent2.Z;
				DrawDebugString(value.AbnormalDispID_Victim, pos, curSelectedActor.GetActorRotation());
			}
		}
		foreach (BGW_GameDB.EAbnromalDispActionType_FreezeExt item28 in ActionTypeList_FreezeExt)
		{
			string text2 = "";
			BGWDataAsset_B1DBC bGWDataAsset_B1DBC4 = null;
			string name2 = "";
			BGWDataAsset_B1DBC bGWDataAsset_B1DBC5 = null;
			if (BGW_GameDB.GetAbnormalDispModifyInfo_FreezeExt_Attacker(item28, 0, out var _, out var DBCPath4))
			{
				text2 = DBCPath4;
			}
			if (BGW_GameDB.GetAbnormalDispModifyInfo_FreezeExt_Attacker(item28, AttackerDispID, out var ModifyType5, out var DBCPath5))
			{
				switch (ModifyType5)
				{
				case EAbnormalDispModifyType.Modify:
					name2 = DBCPath5;
					break;
				case EAbnormalDispModifyType.Override:
					text2 = DBCPath5;
					break;
				}
			}
			if (string.IsNullOrEmpty(text2))
			{
				break;
			}
			bGWDataAsset_B1DBC4 = UObject.LoadObject<BGWDataAsset_B1DBC>(this, text2);
			if (bGWDataAsset_B1DBC4 == null)
			{
				break;
			}
			bGWDataAsset_B1DBC5 = UObject.LoadObject<BGWDataAsset_B1DBC>(this, name2);
			int num4 = 0;
			int num5 = 1;
			int num6 = 2;
			foreach (ASkeletalMeshActor curSelectedActor2 in CurSelectedActors)
			{
				if (curSelectedActor2 == null || curSelectedActor2.SkeletalMeshComponent.SkeletalMesh == null)
				{
					continue;
				}
				string actorLabel2 = curSelectedActor2.GetActorLabel();
				bool flag2 = false;
				if (!SKMap.TryGetValue(actorLabel2, out var value10))
				{
					continue;
				}
				switch (AbnormalType)
				{
				case EAbnormalStateType.Abnormal_Freeze:
					if (value10.ImmueList.Contains(Birth_AbnormalStateImmueType.FreezeImmue))
					{
						flag2 = true;
					}
					break;
				case EAbnormalStateType.Abnormal_Burn:
					if (value10.ImmueList.Contains(Birth_AbnormalStateImmueType.BurnImmue))
					{
						flag2 = true;
					}
					break;
				case EAbnormalStateType.Abnormal_Poison:
					if (value10.ImmueList.Contains(Birth_AbnormalStateImmueType.PoisonImmue))
					{
						flag2 = true;
					}
					break;
				case EAbnormalStateType.Abnormal_Thunder:
					if (value10.ImmueList.Contains(Birth_AbnormalStateImmueType.ThunderImmue))
					{
						flag2 = true;
					}
					break;
				}
				if (flag2 && ImmueStaticMesh != null)
				{
					FBox boundingBox2 = ImmueStaticMesh.GetBoundingBox();
					curSelectedActor2.GetActorBounds(bOnlyCollidingComponents: false, out var Origin3, out var BoxExtent3);
					FRotator rotation2 = curSelectedActor2.GetActorRotation();
					AStaticMeshActor aStaticMeshActor2 = base.World.SpawnActor<AStaticMeshActor>(ref Origin3, ref rotation2) as AStaticMeshActor;
					if (aStaticMeshActor2 != null)
					{
						aStaticMeshActor2.SetMobility(EComponentMobility.Movable);
						aStaticMeshActor2.StaticMeshComponent.StaticMesh = ImmueStaticMesh;
						FVector max2 = boundingBox2.Max;
						FVector newLocation2 = Origin3;
						aStaticMeshActor2.SetActorLocation(newLocation2, bSweep: false, out var _, bTeleport: false);
						FVector oneVector2 = FVector.OneVector;
						if (max2.X != 0f)
						{
							oneVector2.X = BoxExtent3.X / max2.X;
						}
						if (max2.Y != 0f)
						{
							oneVector2.Y = BoxExtent3.Y / max2.Y;
						}
						if (max2.Z != 0f)
						{
							oneVector2.Z = BoxExtent3.Z / max2.Z;
						}
						aStaticMeshActor2.SetActorScale3D(oneVector2);
						ImmueBoxList.Add(aStaticMeshActor2);
					}
					continue;
				}
				List<UNiagaraComponent> list2 = new List<UNiagaraComponent>();
				foreach (BUC_DispLibDBC_PlayNiagara item29 in bGWDataAsset_B1DBC4.PlayNiagara)
				{
					int item6 = (int)DispLib_EditorDBCPreviewToolActor.Editor_RquestPlayOneDBCCommonNiagara(SpawnData: new BUC_DispLibDBC_PlayNiagara(0f, DispLibDBCEndMode.ProcedureNotity, item29.Duration, item29.DelayTimeAfterStop, item29.DestroyTiming, item29.Template, FName.None, item29.AttachedTarget, item29.AttachedTargetSocketName, item29.OffsetInLocalSpace, item29.LocationOffset, item29.RotationOffset, item29.Scale, item29.SnapGround, item29.SnapGroundRotationMode, item29.DetachOnEndDispStageBegin, item29.EnableShadow, item29.TranslucentSortPriority, _ForcePoolModeNone: false, item29.PausePriority, item29.PauseMode, item29.EndStagePriority, 0, DispLibDBCNiagaraForceVisibleStateMode.ImmdSetCompVisibleState, item29.MetaString, item29.ScalabilitySettings), DBCRefParam: DispLibRefParam.Instance, MeshComp: curSelectedActor2.SkeletalMeshComponent, AnimNotifyUniqueID: GetUniqueID(), MontageUniqueID: 0u);
					UNiagaraComponent dBCReturn_FirstNC3 = DispLibRefParam.Instance.DBCReturn_FirstNC;
					list2.Add(dBCReturn_FirstNC3);
					if (!DBCReqIDList_Niagara.ContainsKey(curSelectedActor2))
					{
						DBCReqIDList_Niagara.Add(curSelectedActor2, new List<int>());
					}
					DBCReqIDList_Niagara[curSelectedActor2].Add(item6);
				}
				foreach (BUC_DispLibDBC_PlayAdvanceNiagara item30 in bGWDataAsset_B1DBC4.PlayAdvanceNiagara)
				{
					int item7 = (int)DispLib_EditorDBCPreviewToolActor.Editor_RquestPlayOneDBCCommonNiagara(SpawnData: new BUC_DispLibDBC_PlayNiagara(0f, DispLibDBCEndMode.ProcedureNotity, item30.Duration, item30.DelayTimeAfterStop, item30.DestroyTiming, item30.Template, FName.None, item30.AttachedTarget, item30.AttachedTargetSocketName, item30.OffsetInLocalSpace, item30.AttachedTargetLocationOffset, item30.AttachedTargetRotationOffset, item30.Scale, item30.SnapGround, item30.SnapGroundRotationMode, item30.DetachOnEndDispStageBegin, item30.EnableShadow, item30.TranslucentSortPriority, _ForcePoolModeNone: false, item30.PausePriority, item30.PauseMode, item30.EndStagePriority, 0, DispLibDBCNiagaraForceVisibleStateMode.ImmdSetCompVisibleState, item30.MetaString, item30.ScalabilitySettings), DBCRefParam: DispLibRefParam.Instance, MeshComp: curSelectedActor2.SkeletalMeshComponent, AnimNotifyUniqueID: GetUniqueID(), MontageUniqueID: 0u);
					UNiagaraComponent dBCReturn_FirstNC4 = DispLibRefParam.Instance.DBCReturn_FirstNC;
					if (item30.SetSelfSKMeshParam)
					{
						UNiagaraFunctionLibrary.OverrideSystemUserVariableSkeletalMeshComponent(dBCReturn_FirstNC4, "User.GS_EfxSelfSkeletalMesh", curSelectedActor2.SkeletalMeshComponent);
					}
					list2.Add(dBCReturn_FirstNC4);
					if (!DBCReqIDList_Niagara.ContainsKey(curSelectedActor2))
					{
						DBCReqIDList_Niagara.Add(curSelectedActor2, new List<int>());
					}
					DBCReqIDList_Niagara[curSelectedActor2].Add(item7);
				}
				foreach (BUC_DispLibDBC_ModifyMaterial item31 in bGWDataAsset_B1DBC4.ModifyMaterial)
				{
					BUC_DispLibDBC_ModifyMaterial d4 = default(BUC_DispLibDBC_ModifyMaterial).SetCustomData(item31.FilterMode, item31.Delay, DispLibDBCEndMode.ProcedureNotity, item31.Duration, item31.DelayTimeAfterStop, item31.Template, item31.InheriParamsMode, item31.InheritScalarParam.ToList(), item31.InheritFLinearColorParam.ToList(), item31.InheritTextureParam.ToList(), item31.SetScalarParam.ToList(), item31.SetFLinearColorParam.ToList(), item31.SetTextureParam.ToList(), item31.SetPCurveScalarParam.ToList(), item31.SetPCurveFLinearColorParam.ToList(), item31.PausePriority, num4, num4, num4);
					if (BWS_DispLibDBCManageComp.ValidateDBCModifyMaterial(d4))
					{
						int item8 = (int)DispLib_EditorDBCPreviewToolActor.Editor_RequestApplyModMat(curSelectedActor2.SkeletalMeshComponent, d4, GetUniqueID(), 0u);
						if (!DBCReqIDList_Mat.ContainsKey(curSelectedActor2))
						{
							DBCReqIDList_Mat.Add(curSelectedActor2, new List<int>());
						}
						DBCReqIDList_Mat[curSelectedActor2].Add(item8);
					}
				}
				if (bGWDataAsset_B1DBC5 != null)
				{
					foreach (BUC_DispLibDBC_ModifyMaterial item32 in bGWDataAsset_B1DBC5.ModifyMaterial)
					{
						BUC_DispLibDBC_ModifyMaterial d5 = default(BUC_DispLibDBC_ModifyMaterial).SetCustomData(item32.FilterMode, item32.Delay, DispLibDBCEndMode.ProcedureNotity, item32.Duration, item32.DelayTimeAfterStop, item32.Template, item32.InheriParamsMode, item32.InheritScalarParam.ToList(), item32.InheritFLinearColorParam.ToList(), item32.InheritTextureParam.ToList(), item32.SetScalarParam.ToList(), item32.SetFLinearColorParam.ToList(), item32.SetTextureParam.ToList(), item32.SetPCurveScalarParam.ToList(), item32.SetPCurveFLinearColorParam.ToList(), item32.PausePriority, num5, num5, num5);
						if (BWS_DispLibDBCManageComp.ValidateDBCModifyMaterial(d5))
						{
							int item9 = (int)DispLib_EditorDBCPreviewToolActor.Editor_RequestApplyModMat(curSelectedActor2.SkeletalMeshComponent, d5, GetUniqueID(), 0u);
							if (!DBCReqIDList_Mat.ContainsKey(curSelectedActor2))
							{
								DBCReqIDList_Mat.Add(curSelectedActor2, new List<int>());
							}
							DBCReqIDList_Mat[curSelectedActor2].Add(item9);
						}
					}
					foreach (BUC_DispLibDBC_ModifyNiagaraParams modifyNiagaraParam3 in bGWDataAsset_B1DBC5.ModifyNiagaraParams)
					{
						foreach (UNiagaraComponent item33 in list2)
						{
							foreach (BUC_DispLibUtil_ModNiagara_NameAndBoolValue item34 in modifyNiagaraParam3.SetBoolParam)
							{
								FName paramName11 = item34.ParamName;
								item33.SetBoolParameter(paramName11, item34.Value);
							}
							foreach (BUC_DispLibUtil_ModifyNiagaraParams_FloatParam item35 in modifyNiagaraParam3.SetFloatParam)
							{
								FName paramName12 = item35.ParamName;
								if (item35.ProcessValue.Mode == DispLibDBCAdvProcessModifyNiagaraParamUtilMode.Standard)
								{
									float value11 = item35.ProcessValue.Value;
									item33.SetVariableFloat(paramName12, value11);
								}
								else if (item35.ProcessValue.Mode == DispLibDBCAdvProcessModifyNiagaraParamUtilMode.TimedUCurve && !(item35.ProcessValue.Curve == null))
								{
									item35.ProcessValue.Curve.GetTimeRange(out var _, out var MaxTime9);
									float floatValue5 = item35.ProcessValue.Curve.GetFloatValue(MaxTime9);
									item33.SetVariableFloat(paramName12, floatValue5);
								}
							}
							foreach (BUC_DispLibUtil_ModifyNiagaraParams_FloatParam item36 in modifyNiagaraParam3.SetInt32Param)
							{
								FName paramName13 = item36.ParamName;
								if (item36.ProcessValue.Mode == DispLibDBCAdvProcessModifyNiagaraParamUtilMode.Standard)
								{
									float value12 = item36.ProcessValue.Value;
									item33.SetVariableInt(paramName13, (int)value12);
								}
								else if (item36.ProcessValue.Mode == DispLibDBCAdvProcessModifyNiagaraParamUtilMode.TimedUCurve && !(item36.ProcessValue.Curve == null))
								{
									item36.ProcessValue.Curve.GetTimeRange(out var _, out var MaxTime10);
									float floatValue6 = item36.ProcessValue.Curve.GetFloatValue(MaxTime10);
									item33.SetVariableFloat(paramName13, (int)floatValue6);
								}
							}
							foreach (BUC_DispLibUtil_ModifyNiagaraParams_FVectorParam item37 in modifyNiagaraParam3.SetFVectorParam)
							{
								FName paramName14 = item37.ParamName;
								if (item37.ProcessValue.Mode == DispLibDBCAdvProcessModifyNiagaraParamUtilMode.Standard)
								{
									FVector value13 = item37.ProcessValue.Value;
									item33.SetVariableVec3(paramName14, value13);
								}
								else if (item37.ProcessValue.Mode == DispLibDBCAdvProcessModifyNiagaraParamUtilMode.TimedUCurve && !(item37.ProcessValue.Curve == null))
								{
									item37.ProcessValue.Curve.GetTimeRange(out var _, out var MaxTime11);
									FVector vectorValue3 = item37.ProcessValue.Curve.GetVectorValue(MaxTime11);
									item33.SetVariableVec3(paramName14, vectorValue3);
								}
							}
							foreach (BUC_DispLibUtil_ModifyNiagaraParams_FLinearColorParam item38 in modifyNiagaraParam3.SetFLinearColorParam)
							{
								FName paramName15 = item38.ParamName;
								if (item38.ProcessValue.Mode == DispLibDBCAdvProcessModifyNiagaraParamUtilMode.Standard)
								{
									FLinearColor value14 = item38.ProcessValue.Value;
									item33.SetVariableLinearColor(paramName15, value14);
								}
								else if (item38.ProcessValue.Mode == DispLibDBCAdvProcessModifyNiagaraParamUtilMode.TimedUCurve && !(item38.ProcessValue.Curve == null))
								{
									item38.ProcessValue.Curve.GetTimeRange(out var _, out var MaxTime12);
									FLinearColor linearColorValue3 = item38.ProcessValue.Curve.GetLinearColorValue(MaxTime12);
									item33.SetVariableLinearColor(paramName15, linearColorValue3);
								}
							}
							if (modifyNiagaraParam3.SetOverrideSelfMeshBones.Count > 0)
							{
								UGSE_RenderUtilFuncLib.OverrideSystemUserVariableSKMFilteredBones(item33, "User.GS_EfxSelfSkeletalMesh", modifyNiagaraParam3.SetOverrideSelfMeshBones.ToList());
							}
							if (modifyNiagaraParam3.SetOverrideSelfMeshSockets.Count > 0)
							{
								UGSE_RenderUtilFuncLib.OverrideSystemUserVariableSKMFilteredSockets(item33, "User.GS_EfxSelfSkeletalMesh", modifyNiagaraParam3.SetOverrideSelfMeshSockets.ToList());
							}
						}
					}
				}
				int abnormalDispID_Victim2 = value10.AbnormalDispID_Victim;
				if (BGW_GameDB.GetAbnormalDispModifyInfo_FreezeExt_Victim(item28, abnormalDispID_Victim2, out var ModifyType6, out var DBCPath6) && ModifyType6 == EAbnormalDispModifyType.Modify)
				{
					BGWDataAsset_B1DBC bGWDataAsset_B1DBC6 = UObject.LoadObject<BGWDataAsset_B1DBC>(this, DBCPath6);
					if (bGWDataAsset_B1DBC6 == null)
					{
						continue;
					}
					foreach (BUC_DispLibDBC_ModifyMaterial item39 in bGWDataAsset_B1DBC6.ModifyMaterial)
					{
						BUC_DispLibDBC_ModifyMaterial d6 = default(BUC_DispLibDBC_ModifyMaterial).SetCustomData(item39.FilterMode, item39.Delay, DispLibDBCEndMode.ProcedureNotity, item39.Duration, item39.DelayTimeAfterStop, item39.Template, item39.InheriParamsMode, item39.InheritScalarParam.ToList(), item39.InheritFLinearColorParam.ToList(), item39.InheritTextureParam.ToList(), item39.SetScalarParam.ToList(), item39.SetFLinearColorParam.ToList(), item39.SetTextureParam.ToList(), item39.SetPCurveScalarParam.ToList(), item39.SetPCurveFLinearColorParam.ToList(), item39.PausePriority, num6, num6, num6);
						if (BWS_DispLibDBCManageComp.ValidateDBCModifyMaterial(d6))
						{
							int item10 = (int)DispLib_EditorDBCPreviewToolActor.Editor_RequestApplyModMat(curSelectedActor2.SkeletalMeshComponent, d6, GetUniqueID(), 0u);
							if (!DBCReqIDList_Mat.ContainsKey(curSelectedActor2))
							{
								DBCReqIDList_Mat.Add(curSelectedActor2, new List<int>());
							}
							DBCReqIDList_Mat[curSelectedActor2].Add(item10);
						}
					}
					foreach (BUC_DispLibDBC_ModifyNiagaraParams modifyNiagaraParam4 in bGWDataAsset_B1DBC6.ModifyNiagaraParams)
					{
						foreach (UNiagaraComponent item40 in list2)
						{
							foreach (BUC_DispLibUtil_ModNiagara_NameAndBoolValue item41 in modifyNiagaraParam4.SetBoolParam)
							{
								FName paramName16 = item41.ParamName;
								item40.SetBoolParameter(paramName16, item41.Value);
							}
							foreach (BUC_DispLibUtil_ModifyNiagaraParams_FloatParam item42 in modifyNiagaraParam4.SetFloatParam)
							{
								FName paramName17 = item42.ParamName;
								if (item42.ProcessValue.Mode == DispLibDBCAdvProcessModifyNiagaraParamUtilMode.Standard)
								{
									float value15 = item42.ProcessValue.Value;
									item40.SetVariableFloat(paramName17, value15);
								}
								else if (item42.ProcessValue.Mode == DispLibDBCAdvProcessModifyNiagaraParamUtilMode.TimedUCurve && !(item42.ProcessValue.Curve == null))
								{
									item42.ProcessValue.Curve.GetTimeRange(out var _, out var MaxTime13);
									float floatValue7 = item42.ProcessValue.Curve.GetFloatValue(MaxTime13);
									item40.SetVariableFloat(paramName17, floatValue7);
								}
							}
							foreach (BUC_DispLibUtil_ModifyNiagaraParams_FloatParam item43 in modifyNiagaraParam4.SetInt32Param)
							{
								FName paramName18 = item43.ParamName;
								if (item43.ProcessValue.Mode == DispLibDBCAdvProcessModifyNiagaraParamUtilMode.Standard)
								{
									float value16 = item43.ProcessValue.Value;
									item40.SetVariableInt(paramName18, (int)value16);
								}
								else if (item43.ProcessValue.Mode == DispLibDBCAdvProcessModifyNiagaraParamUtilMode.TimedUCurve && !(item43.ProcessValue.Curve == null))
								{
									item43.ProcessValue.Curve.GetTimeRange(out var _, out var MaxTime14);
									float floatValue8 = item43.ProcessValue.Curve.GetFloatValue(MaxTime14);
									item40.SetVariableFloat(paramName18, (int)floatValue8);
								}
							}
							foreach (BUC_DispLibUtil_ModifyNiagaraParams_FVectorParam item44 in modifyNiagaraParam4.SetFVectorParam)
							{
								FName paramName19 = item44.ParamName;
								if (item44.ProcessValue.Mode == DispLibDBCAdvProcessModifyNiagaraParamUtilMode.Standard)
								{
									FVector value17 = item44.ProcessValue.Value;
									item40.SetVariableVec3(paramName19, value17);
								}
								else if (item44.ProcessValue.Mode == DispLibDBCAdvProcessModifyNiagaraParamUtilMode.TimedUCurve && !(item44.ProcessValue.Curve == null))
								{
									item44.ProcessValue.Curve.GetTimeRange(out var _, out var MaxTime15);
									FVector vectorValue4 = item44.ProcessValue.Curve.GetVectorValue(MaxTime15);
									item40.SetVariableVec3(paramName19, vectorValue4);
								}
							}
							foreach (BUC_DispLibUtil_ModifyNiagaraParams_FLinearColorParam item45 in modifyNiagaraParam4.SetFLinearColorParam)
							{
								FName paramName20 = item45.ParamName;
								if (item45.ProcessValue.Mode == DispLibDBCAdvProcessModifyNiagaraParamUtilMode.Standard)
								{
									FLinearColor value18 = item45.ProcessValue.Value;
									item40.SetVariableLinearColor(paramName20, value18);
								}
								else if (item45.ProcessValue.Mode == DispLibDBCAdvProcessModifyNiagaraParamUtilMode.TimedUCurve && !(item45.ProcessValue.Curve == null))
								{
									item45.ProcessValue.Curve.GetTimeRange(out var _, out var MaxTime16);
									FLinearColor linearColorValue4 = item45.ProcessValue.Curve.GetLinearColorValue(MaxTime16);
									item40.SetVariableLinearColor(paramName20, linearColorValue4);
								}
							}
							if (modifyNiagaraParam4.SetOverrideSelfMeshBones.Count > 0)
							{
								UGSE_RenderUtilFuncLib.OverrideSystemUserVariableSKMFilteredBones(item40, "User.GS_EfxSelfSkeletalMesh", modifyNiagaraParam4.SetOverrideSelfMeshBones.ToList());
							}
							if (modifyNiagaraParam4.SetOverrideSelfMeshSockets.Count > 0)
							{
								UGSE_RenderUtilFuncLib.OverrideSystemUserVariableSKMFilteredSockets(item40, "User.GS_EfxSelfSkeletalMesh", modifyNiagaraParam4.SetOverrideSelfMeshSockets.ToList());
							}
						}
					}
				}
				curSelectedActor2.GetActorBounds(bOnlyCollidingComponents: false, out var Origin4, out var BoxExtent4);
				FVector pos2 = Origin4 + FVector.UpVector * BoxExtent4.Z;
				DrawDebugString(value10.AbnormalDispID_Victim, pos2, curSelectedActor2.GetActorRotation());
			}
		}
	}

	public void EndCurEffect()
	{
		foreach (KeyValuePair<ASkeletalMeshActor, List<int>> item in DBCReqIDList_Niagara)
		{
			if (!(item.Key != null))
			{
				continue;
			}
			foreach (int item2 in item.Value)
			{
				DispLib_EditorDBCPreviewToolActor.Editor_Rquest_End_Niagara_ByDBCID(item.Key.SkeletalMeshComponent, (uint)item2, int.MaxValue, ForceDestroyComponent: true);
			}
		}
		DBCReqIDList_Niagara.Clear();
		foreach (KeyValuePair<ASkeletalMeshActor, List<int>> item3 in DBCReqIDList_Mat)
		{
			if (!(item3.Key != null))
			{
				continue;
			}
			foreach (int item4 in item3.Value)
			{
				DispLib_EditorDBCPreviewToolActor.Editor_Request_End_ModMat_ByDBCID((uint)item4, item3.Key.SkeletalMeshComponent);
			}
		}
		DBCReqIDList_Mat.Clear();
		foreach (AActor immueBox in ImmueBoxList)
		{
			if (immueBox != null)
			{
				immueBox.DestroyActor();
			}
		}
		ImmueBoxList.Clear();
		DestroyStringActor();
	}

	public void DrawDebugString(int Number, FVector Pos, FRotator Rot)
	{
		AActor aActor = base.World.SpawnActor(DebugNumerClass.Value, ref Pos, ref Rot);
		if (!(aActor != null))
		{
			return;
		}
		UStaticMeshComponent componentByClass = aActor.GetComponentByClass<UStaticMeshComponent>();
		if (componentByClass != null)
		{
			List<UMaterialInterface> materials = componentByClass.GetMaterials();
			for (int i = 0; i < materials.Count; i++)
			{
				UMaterialInstanceDynamic uMaterialInstanceDynamic = materials[i] as UMaterialInstanceDynamic;
				if (uMaterialInstanceDynamic == null)
				{
					uMaterialInstanceDynamic = componentByClass.CreateDynamicMaterialInstance(i, materials[i], FName.None);
				}
				if (!(uMaterialInstanceDynamic == null))
				{
					uMaterialInstanceDynamic.SetScalarParameterValue(new FName("Number"), Number);
				}
			}
		}
		DebugStringActorList.Add(aActor);
	}

	private void DestroyStringActor()
	{
		foreach (AActor debugStringActor in DebugStringActorList)
		{
			if (debugStringActor != null)
			{
				debugStringActor.DestroyActor();
			}
		}
		DebugStringActorList.Clear();
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAbnormalDispMuseum:Preview")]
	private static void Preview__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAbnormalDispMuseum bUAbnormalDispMuseum = GCHelper.Find<BUAbnormalDispMuseum>(obj);
		bUAbnormalDispMuseum.Preview();
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAbnormalDispMuseum:SpawnGrid")]
	private static void SpawnGrid__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAbnormalDispMuseum bUAbnormalDispMuseum = GCHelper.Find<BUAbnormalDispMuseum>(obj);
		bUAbnormalDispMuseum.SpawnGrid();
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAbnormalDispMuseum:UpdateData")]
	private static void UpdateData__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAbnormalDispMuseum bUAbnormalDispMuseum = GCHelper.Find<BUAbnormalDispMuseum>(obj);
		bUAbnormalDispMuseum.UpdateData();
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAbnormalDispMuseum:GenSKMuseumData")]
	private static void GenSKMuseumData__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAbnormalDispMuseum bUAbnormalDispMuseum = GCHelper.Find<BUAbnormalDispMuseum>(obj);
		bUAbnormalDispMuseum.GenSKMuseumData();
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAbnormalDispMuseum:ReceiveTick")]
	private static void ReceiveTick__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAbnormalDispMuseum bUAbnormalDispMuseum = GCHelper.Find<BUAbnormalDispMuseum>(obj);
		float deltaSeconds = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, ReceiveTick_DeltaSeconds_Offset));
		bUAbnormalDispMuseum.ReceiveTick_Implementation(deltaSeconds);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUAbnormalDispMuseum");
		Root_Offset = NativeReflection.GetPropertyOffset(intPtr, "Root");
		Root_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Root", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref SKMeshActors_PropertyAddress, intPtr, "SKMeshActors");
		SKMeshActors_Offset = NativeReflection.GetPropertyOffset(intPtr, "SKMeshActors");
		SKMeshActors_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SKMeshActors", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref SKMeshActors_WithRowIndex_PropertyAddress, intPtr, "SKMeshActors_WithRowIndex");
		SKMeshActors_WithRowIndex_Offset = NativeReflection.GetPropertyOffset(intPtr, "SKMeshActors_WithRowIndex");
		SKMeshActors_WithRowIndex_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SKMeshActors_WithRowIndex", Classes.FMapProperty);
		NativeReflection.GetPropertyRef(ref SKMap_PropertyAddress, intPtr, "SKMap");
		SKMap_Offset = NativeReflection.GetPropertyOffset(intPtr, "SKMap");
		SKMap_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SKMap", Classes.FMapProperty);
		NativeReflection.GetPropertyRef(ref SKMap_Conflict_PropertyAddress, intPtr, "SKMap_Conflict");
		SKMap_Conflict_Offset = NativeReflection.GetPropertyOffset(intPtr, "SKMap_Conflict");
		SKMap_Conflict_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SKMap_Conflict", Classes.FArrayProperty);
		csvFilePath_Offset = NativeReflection.GetPropertyOffset(intPtr, "csvFilePath");
		csvFilePath_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "csvFilePath", Classes.FStrProperty);
		ImmueStaticMesh_Offset = NativeReflection.GetPropertyOffset(intPtr, "ImmueStaticMesh");
		ImmueStaticMesh_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ImmueStaticMesh", Classes.FObjectProperty);
		DebugNumerClass_Offset = NativeReflection.GetPropertyOffset(intPtr, "DebugNumerClass");
		DebugNumerClass_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DebugNumerClass", Classes.FClassProperty);
		RowIndex_Offset = NativeReflection.GetPropertyOffset(intPtr, "RowIndex");
		RowIndex_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RowIndex", Classes.FIntProperty);
		AttackerDispID_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttackerDispID");
		AttackerDispID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttackerDispID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref AbnormalType_PropertyAddress, intPtr, "AbnormalType");
		AbnormalType_Offset = NativeReflection.GetPropertyOffset(intPtr, "AbnormalType");
		AbnormalType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AbnormalType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref ActionTypeList_PropertyAddress, intPtr, "ActionTypeList");
		ActionTypeList_Offset = NativeReflection.GetPropertyOffset(intPtr, "ActionTypeList");
		ActionTypeList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ActionTypeList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref ActionTypeList_FreezeExt_PropertyAddress, intPtr, "ActionTypeList_FreezeExt");
		ActionTypeList_FreezeExt_Offset = NativeReflection.GetPropertyOffset(intPtr, "ActionTypeList_FreezeExt");
		ActionTypeList_FreezeExt_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ActionTypeList_FreezeExt", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref CurSelectedActors_PropertyAddress, intPtr, "CurSelectedActors");
		CurSelectedActors_Offset = NativeReflection.GetPropertyOffset(intPtr, "CurSelectedActors");
		CurSelectedActors_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CurSelectedActors", Classes.FArrayProperty);
		Preview_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Preview");
		Preview_ParamsSize = NativeReflection.GetFunctionParamsSize(Preview_FunctionAddress);
		Preview_IsValid = Preview_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAbnormalDispMuseum:Preview", Preview_IsValid);
		SpawnGrid_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SpawnGrid");
		SpawnGrid_ParamsSize = NativeReflection.GetFunctionParamsSize(SpawnGrid_FunctionAddress);
		SpawnGrid_IsValid = SpawnGrid_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAbnormalDispMuseum:SpawnGrid", SpawnGrid_IsValid);
		UpdateData_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UpdateData");
		UpdateData_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateData_FunctionAddress);
		UpdateData_IsValid = UpdateData_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAbnormalDispMuseum:UpdateData", UpdateData_IsValid);
		GenSKMuseumData_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GenSKMuseumData");
		GenSKMuseumData_ParamsSize = NativeReflection.GetFunctionParamsSize(GenSKMuseumData_FunctionAddress);
		GenSKMuseumData_IsValid = GenSKMuseumData_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAbnormalDispMuseum:GenSKMuseumData", GenSKMuseumData_IsValid);
		ReceiveTick_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveTick");
		ReceiveTick_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveTick_FunctionAddress);
		ReceiveTick_DeltaSeconds_Offset = NativeReflection.GetPropertyOffset(ReceiveTick_FunctionAddress, "DeltaSeconds");
		ReceiveTick_DeltaSeconds_IsValid = NativeReflection.ValidatePropertyClass(ReceiveTick_FunctionAddress, "DeltaSeconds", Classes.FFloatProperty);
		ReceiveTick_IsValid = ReceiveTick_FunctionAddress != IntPtr.Zero && ReceiveTick_DeltaSeconds_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAbnormalDispMuseum:ReceiveTick", ReceiveTick_IsValid);
	}

	static BUAbnormalDispMuseum()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUAbnormalDispMuseum)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUAbnormalDispMuseum));
	}
}
