using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUProceduralMapGenerator")]
public class BGUProceduralMapGenerator : BGUActorBaseCS
{
	private static bool ProceduralMapDataConfigComp_IsValid;

	private static int ProceduralMapDataConfigComp_Offset;

	private static bool OnProceduralStreamLevelLoaded_IsValid;

	private static IntPtr OnProceduralStreamLevelLoaded_FunctionAddress;

	private static int OnProceduralStreamLevelLoaded_ParamsSize;

	private static bool OnProceduralStreamLevelLoaded_id_IsValid;

	private static int OnProceduralStreamLevelLoaded_id_Offset;

	private static bool OnProceduralStreamLevelLoaded_linkage_IsValid;

	private static int OnProceduralStreamLevelLoaded_linkage_Offset;

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGUProceduralMapGenerator:ProceduralMapDataConfigComp")]
	public BUS_ProceduralMapGeneratorDataConfigComp ProceduralMapDataConfigComp
	{
		get
		{
			CheckDestroyed();
			if (!ProceduralMapDataConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUProceduralMapGenerator:ProceduralMapDataConfigComp");
				return null;
			}
			return UObjectMarshaler<BUS_ProceduralMapGeneratorDataConfigComp>.FromNative(IntPtr.Add(base.Address, ProceduralMapDataConfigComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ProceduralMapDataConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUProceduralMapGenerator:ProceduralMapDataConfigComp");
			}
			else
			{
				UObjectMarshaler<BUS_ProceduralMapGeneratorDataConfigComp>.ToNative(IntPtr.Add(base.Address, ProceduralMapDataConfigComp_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		ProceduralMapDataConfigComp = initializer.CreateDefaultSubobject<BUS_ProceduralMapGeneratorDataConfigComp>(this, B1GlobalFNames.ProceduralMapGeneratorDataConfigComp);
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddComp(new BUS_ProceduralMapGeneratorComp());
		base.ActorCompContainerCS.AddComp(new BUS_ProceduralMapGlobalSpawnerMgrComp());
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<BUS_ProceduralMapGeneratorDataComp>(this, B1GlobalFNames.ProceduralMapGeneratorDataComp);
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUProceduralMapGenerator:OnProceduralStreamLevelLoaded")]
	private void OnProceduralStreamLevelLoaded(int id, int linkage)
	{
		BUS_EventCollectionCS.Get(this).Evt_ProceduralMapLoaded?.Invoke(id);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUProceduralMapGenerator:OnProceduralStreamLevelLoaded")]
	private static void OnProceduralStreamLevelLoaded__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUProceduralMapGenerator bGUProceduralMapGenerator = GCHelper.Find<BGUProceduralMapGenerator>(obj);
		int id = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, OnProceduralStreamLevelLoaded_id_Offset));
		int linkage = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, OnProceduralStreamLevelLoaded_linkage_Offset));
		bGUProceduralMapGenerator.OnProceduralStreamLevelLoaded(id, linkage);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGUProceduralMapGenerator");
		ProceduralMapDataConfigComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "ProceduralMapDataConfigComp");
		ProceduralMapDataConfigComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ProceduralMapDataConfigComp", Classes.FObjectProperty);
		OnProceduralStreamLevelLoaded_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnProceduralStreamLevelLoaded");
		OnProceduralStreamLevelLoaded_ParamsSize = NativeReflection.GetFunctionParamsSize(OnProceduralStreamLevelLoaded_FunctionAddress);
		OnProceduralStreamLevelLoaded_id_Offset = NativeReflection.GetPropertyOffset(OnProceduralStreamLevelLoaded_FunctionAddress, "id");
		OnProceduralStreamLevelLoaded_id_IsValid = NativeReflection.ValidatePropertyClass(OnProceduralStreamLevelLoaded_FunctionAddress, "id", Classes.FIntProperty);
		OnProceduralStreamLevelLoaded_linkage_Offset = NativeReflection.GetPropertyOffset(OnProceduralStreamLevelLoaded_FunctionAddress, "linkage");
		OnProceduralStreamLevelLoaded_linkage_IsValid = NativeReflection.ValidatePropertyClass(OnProceduralStreamLevelLoaded_FunctionAddress, "linkage", Classes.FIntProperty);
		OnProceduralStreamLevelLoaded_IsValid = OnProceduralStreamLevelLoaded_FunctionAddress != IntPtr.Zero && OnProceduralStreamLevelLoaded_id_IsValid && OnProceduralStreamLevelLoaded_linkage_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUProceduralMapGenerator:OnProceduralStreamLevelLoaded", OnProceduralStreamLevelLoaded_IsValid);
	}

	static BGUProceduralMapGenerator()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUProceduralMapGenerator)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUProceduralMapGenerator));
	}
}
