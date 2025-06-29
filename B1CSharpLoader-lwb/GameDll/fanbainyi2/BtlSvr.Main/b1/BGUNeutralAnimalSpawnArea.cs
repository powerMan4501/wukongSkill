using System;
using UnrealEngine.AIModule;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUNeutralAnimalSpawnArea")]
public class BGUNeutralAnimalSpawnArea : BGUAreaBase
{
	private static bool NeutralAnimalAreaConfigInfoComp_IsValid;

	private static int NeutralAnimalAreaConfigInfoComp_Offset;

	private static bool TerritoryInfos_IsValid;

	private static int TerritoryInfos_Offset;

	private static FFieldAddress TerritoryInfos_PropertyAddress;

	private TMapReadWriteMarshaler<string, FNeutralAnimalTerritoryInfo> TerritoryInfos_Marshaler;

	private static bool PreviewActor_IsValid;

	private static int PreviewActor_Offset;

	private static bool PresetPoints_EQS_IsValid;

	private static int PresetPoints_EQS_Offset;

	private static bool QueryConfig_IsValid;

	private static int QueryConfig_Offset;

	private static FFieldAddress QueryConfig_PropertyAddress;

	private TArrayReadWriteMarshaler<FGSEnvNamedValue> QueryConfig_Marshaler;

	private static bool GeneratedEQSActors_IsValid;

	private static int GeneratedEQSActors_Offset;

	private static FFieldAddress GeneratedEQSActors_PropertyAddress;

	private TArrayReadWriteMarshaler<TSoftObject<AActor>> GeneratedEQSActors_Marshaler;

	private static bool CustomAddingActors_IsValid;

	private static int CustomAddingActors_Offset;

	private static FFieldAddress CustomAddingActors_PropertyAddress;

	private TArrayReadWriteMarshaler<TSoftObject<AActor>> CustomAddingActors_Marshaler;

	private static bool ReceiveDestroyed_IsValid;

	private static IntPtr ReceiveDestroyed_FunctionAddress;

	private static int ReceiveDestroyed_ParamsSize;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGUNeutralAnimalSpawnArea:NeutralAnimalAreaConfigInfoComp")]
	public BUS_NeutralAnimalAreaConfigInfoComp NeutralAnimalAreaConfigInfoComp
	{
		get
		{
			CheckDestroyed();
			if (!NeutralAnimalAreaConfigInfoComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUNeutralAnimalSpawnArea:NeutralAnimalAreaConfigInfoComp");
				return null;
			}
			return UObjectMarshaler<BUS_NeutralAnimalAreaConfigInfoComp>.FromNative(IntPtr.Add(base.Address, NeutralAnimalAreaConfigInfoComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NeutralAnimalAreaConfigInfoComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUNeutralAnimalSpawnArea:NeutralAnimalAreaConfigInfoComp");
			}
			else
			{
				UObjectMarshaler<BUS_NeutralAnimalAreaConfigInfoComp>.ToNative(IntPtr.Add(base.Address, NeutralAnimalAreaConfigInfoComp_Offset), value);
			}
		}
	}

	[Category("预置点集 | 领地信息")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGUNeutralAnimalSpawnArea:TerritoryInfos")]
	public TMapReadWrite<string, FNeutralAnimalTerritoryInfo> TerritoryInfos
	{
		get
		{
			CheckDestroyed();
			if (!TerritoryInfos_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUNeutralAnimalSpawnArea:TerritoryInfos");
				return null;
			}
			if (TerritoryInfos_Marshaler == null)
			{
				TerritoryInfos_Marshaler = new TMapReadWriteMarshaler<string, FNeutralAnimalTerritoryInfo>(1, TerritoryInfos_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<FNeutralAnimalTerritoryInfo, FNeutralAnimalTerritoryInfo>.FromNative, CachedMarshalingDelegates<FNeutralAnimalTerritoryInfo, FNeutralAnimalTerritoryInfo>.ToNative);
			}
			return TerritoryInfos_Marshaler.FromNative(IntPtr.Add(base.Address, TerritoryInfos_Offset));
		}
	}

	[BlueprintReadWrite]
	[Category("预置点集")]
	[DisplayName("点预览Actor")]
	[UProperty]
	[EditDefaultsOnly]
	[USharpPath("/Script/b1-Managed.BGUNeutralAnimalSpawnArea:PreviewActor")]
	public TSubclassOf<AActor> PreviewActor
	{
		get
		{
			CheckDestroyed();
			if (!PreviewActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUNeutralAnimalSpawnArea:PreviewActor");
				return default(TSubclassOf<AActor>);
			}
			return TSubclassOfMarshaler<AActor>.FromNative(IntPtr.Add(base.Address, PreviewActor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PreviewActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUNeutralAnimalSpawnArea:PreviewActor");
			}
			else
			{
				TSubclassOfMarshaler<AActor>.ToNative(IntPtr.Add(base.Address, PreviewActor_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("预置点集 | EQS生成")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("预置点集EQS")]
	[USharpPath("/Script/b1-Managed.BGUNeutralAnimalSpawnArea:PresetPoints_EQS")]
	public UEnvQuery PresetPoints_EQS
	{
		get
		{
			CheckDestroyed();
			if (!PresetPoints_EQS_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUNeutralAnimalSpawnArea:PresetPoints_EQS");
				return null;
			}
			return UObjectMarshaler<UEnvQuery>.FromNative(IntPtr.Add(base.Address, PresetPoints_EQS_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PresetPoints_EQS_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUNeutralAnimalSpawnArea:PresetPoints_EQS");
			}
			else
			{
				UObjectMarshaler<UEnvQuery>.ToNative(IntPtr.Add(base.Address, PresetPoints_EQS_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[Category("预置点集 | EQS生成")]
	[DisplayName("EQS模板参数")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUNeutralAnimalSpawnArea:QueryConfig")]
	public TArrayReadWrite<FGSEnvNamedValue> QueryConfig
	{
		get
		{
			CheckDestroyed();
			if (!QueryConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUNeutralAnimalSpawnArea:QueryConfig");
				return null;
			}
			if (QueryConfig_Marshaler == null)
			{
				QueryConfig_Marshaler = new TArrayReadWriteMarshaler<FGSEnvNamedValue>(1, QueryConfig_PropertyAddress, CachedMarshalingDelegates<FGSEnvNamedValue, FGSEnvNamedValue>.FromNative, CachedMarshalingDelegates<FGSEnvNamedValue, FGSEnvNamedValue>.ToNative);
			}
			return QueryConfig_Marshaler.FromNative(IntPtr.Add(base.Address, QueryConfig_Offset));
		}
	}

	[UProperty]
	[VisibleAnywhere]
	[Category("预置点集 | EQS生成")]
	[USharpPath("/Script/b1-Managed.BGUNeutralAnimalSpawnArea:GeneratedEQSActors")]
	public TArrayReadWrite<TSoftObject<AActor>> GeneratedEQSActors
	{
		get
		{
			CheckDestroyed();
			if (!GeneratedEQSActors_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUNeutralAnimalSpawnArea:GeneratedEQSActors");
				return null;
			}
			if (GeneratedEQSActors_Marshaler == null)
			{
				GeneratedEQSActors_Marshaler = new TArrayReadWriteMarshaler<TSoftObject<AActor>>(1, GeneratedEQSActors_PropertyAddress, CachedMarshalingDelegates<TSoftObject<AActor>, TSoftObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<TSoftObject<AActor>, TSoftObjectMarshaler<AActor>>.ToNative);
			}
			return GeneratedEQSActors_Marshaler.FromNative(IntPtr.Add(base.Address, GeneratedEQSActors_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("预置点集 | 手动添加")]
	[USharpPath("/Script/b1-Managed.BGUNeutralAnimalSpawnArea:CustomAddingActors")]
	public TArrayReadWrite<TSoftObject<AActor>> CustomAddingActors
	{
		get
		{
			CheckDestroyed();
			if (!CustomAddingActors_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUNeutralAnimalSpawnArea:CustomAddingActors");
				return null;
			}
			if (CustomAddingActors_Marshaler == null)
			{
				CustomAddingActors_Marshaler = new TArrayReadWriteMarshaler<TSoftObject<AActor>>(1, CustomAddingActors_PropertyAddress, CachedMarshalingDelegates<TSoftObject<AActor>, TSoftObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<TSoftObject<AActor>, TSoftObjectMarshaler<AActor>>.ToNative);
			}
			return CustomAddingActors_Marshaler.FromNative(IntPtr.Add(base.Address, CustomAddingActors_Offset));
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		base.BasicConfigInfoComp.AreaType = EAreaType.Volume;
		base.BasicConfigInfoComp.bNotifyGraph = false;
		NeutralAnimalAreaConfigInfoComp = initializer.CreateDefaultSubobject<BUS_NeutralAnimalAreaConfigInfoComp>(this, B1GlobalFNames.NeutralAnimalAreaConfigInfoComp);
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddComp(new BUS_NeutralAnimalAreaLogicComp());
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<BUS_NeutralAnimalSpawnAreaDataComp>(this, B1GlobalFNames.DataComp);
	}

	[USharpPath("/Script/b1-Managed.BGUNeutralAnimalSpawnArea:ReceiveDestroyed")]
	protected override void ReceiveDestroyed_Implementation()
	{
		base.ReceiveDestroyed_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUNeutralAnimalSpawnArea:ReceiveDestroyed")]
	private static void ReceiveDestroyed__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUNeutralAnimalSpawnArea bGUNeutralAnimalSpawnArea = GCHelper.Find<BGUNeutralAnimalSpawnArea>(obj);
		bGUNeutralAnimalSpawnArea.ReceiveDestroyed_Implementation();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGUNeutralAnimalSpawnArea");
		NeutralAnimalAreaConfigInfoComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "NeutralAnimalAreaConfigInfoComp");
		NeutralAnimalAreaConfigInfoComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NeutralAnimalAreaConfigInfoComp", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref TerritoryInfos_PropertyAddress, intPtr, "TerritoryInfos");
		TerritoryInfos_Offset = NativeReflection.GetPropertyOffset(intPtr, "TerritoryInfos");
		TerritoryInfos_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TerritoryInfos", Classes.FMapProperty);
		PreviewActor_Offset = NativeReflection.GetPropertyOffset(intPtr, "PreviewActor");
		PreviewActor_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PreviewActor", Classes.FClassProperty);
		PresetPoints_EQS_Offset = NativeReflection.GetPropertyOffset(intPtr, "PresetPoints_EQS");
		PresetPoints_EQS_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PresetPoints_EQS", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref QueryConfig_PropertyAddress, intPtr, "QueryConfig");
		QueryConfig_Offset = NativeReflection.GetPropertyOffset(intPtr, "QueryConfig");
		QueryConfig_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "QueryConfig", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref GeneratedEQSActors_PropertyAddress, intPtr, "GeneratedEQSActors");
		GeneratedEQSActors_Offset = NativeReflection.GetPropertyOffset(intPtr, "GeneratedEQSActors");
		GeneratedEQSActors_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "GeneratedEQSActors", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref CustomAddingActors_PropertyAddress, intPtr, "CustomAddingActors");
		CustomAddingActors_Offset = NativeReflection.GetPropertyOffset(intPtr, "CustomAddingActors");
		CustomAddingActors_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CustomAddingActors", Classes.FArrayProperty);
		ReceiveDestroyed_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveDestroyed");
		ReceiveDestroyed_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveDestroyed_FunctionAddress);
		ReceiveDestroyed_IsValid = ReceiveDestroyed_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUNeutralAnimalSpawnArea:ReceiveDestroyed", ReceiveDestroyed_IsValid);
	}

	static BGUNeutralAnimalSpawnArea()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUNeutralAnimalSpawnArea)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUNeutralAnimalSpawnArea));
	}
}
