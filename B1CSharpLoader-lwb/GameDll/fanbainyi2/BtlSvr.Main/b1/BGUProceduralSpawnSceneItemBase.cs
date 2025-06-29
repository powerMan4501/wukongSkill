using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUProceduralSpawnSceneItemBase")]
public class BGUProceduralSpawnSceneItemBase : BGUActorBaseCS
{
	private static bool ProceduralSpawnSceneItemDataConfigComp_IsValid;

	private static int ProceduralSpawnSceneItemDataConfigComp_Offset;

	private static bool OnConstructionCS_IsValid;

	private static IntPtr OnConstructionCS_FunctionAddress;

	private static int OnConstructionCS_ParamsSize;

	private static bool OnConstructionCS_Transform_IsValid;

	private static int OnConstructionCS_Transform_Offset;

	private static FFieldAddress OnConstructionCS_Transform_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGUProceduralSpawnSceneItemBase:ProceduralSpawnSceneItemDataConfigComp")]
	public BUS_ProceduralSpawnSceneItemDataConfigComp ProceduralSpawnSceneItemDataConfigComp
	{
		get
		{
			CheckDestroyed();
			if (!ProceduralSpawnSceneItemDataConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUProceduralSpawnSceneItemBase:ProceduralSpawnSceneItemDataConfigComp");
				return null;
			}
			return UObjectMarshaler<BUS_ProceduralSpawnSceneItemDataConfigComp>.FromNative(IntPtr.Add(base.Address, ProceduralSpawnSceneItemDataConfigComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ProceduralSpawnSceneItemDataConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUProceduralSpawnSceneItemBase:ProceduralSpawnSceneItemDataConfigComp");
			}
			else
			{
				UObjectMarshaler<BUS_ProceduralSpawnSceneItemDataConfigComp>.ToNative(IntPtr.Add(base.Address, ProceduralSpawnSceneItemDataConfigComp_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		initializer.CreateDefaultSubobject<UBGUDebugCircleComponent>(this, B1GlobalFNames.DebugCircleComponent);
		ProceduralSpawnSceneItemDataConfigComp = initializer.CreateDefaultSubobject<BUS_ProceduralSpawnSceneItemDataConfigComp>(this, B1GlobalFNames.ProceduralSpawnSceneItemDataConfigComp);
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddComp(new BUS_ProceduralSpawnSceneItemComp());
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<BUS_ProceduralSpawnSceneItemDataComp>(this, B1GlobalFNames.ProceduralSpawnSceneItemDataComp);
	}

	[USharpPath("/Script/b1-Managed.BGUProceduralSpawnSceneItemBase:OnConstructionCS")]
	protected override void OnConstructionCS_Implementation(FTransform Transform)
	{
		base.OnConstructionCS_Implementation(Transform);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUProceduralSpawnSceneItemBase:OnConstructionCS")]
	private static void OnConstructionCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUProceduralSpawnSceneItemBase bGUProceduralSpawnSceneItemBase = GCHelper.Find<BGUProceduralSpawnSceneItemBase>(obj);
		FTransform transform = BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(buffer, OnConstructionCS_Transform_Offset));
		bGUProceduralSpawnSceneItemBase.OnConstructionCS_Implementation(transform);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGUProceduralSpawnSceneItemBase");
		ProceduralSpawnSceneItemDataConfigComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "ProceduralSpawnSceneItemDataConfigComp");
		ProceduralSpawnSceneItemDataConfigComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ProceduralSpawnSceneItemDataConfigComp", Classes.FObjectProperty);
		OnConstructionCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnConstructionCS");
		OnConstructionCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnConstructionCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnConstructionCS_Transform_PropertyAddress, OnConstructionCS_FunctionAddress, "Transform");
		OnConstructionCS_Transform_Offset = NativeReflection.GetPropertyOffset(OnConstructionCS_FunctionAddress, "Transform");
		OnConstructionCS_Transform_IsValid = NativeReflection.ValidatePropertyClass(OnConstructionCS_FunctionAddress, "Transform", Classes.FStructProperty);
		OnConstructionCS_IsValid = OnConstructionCS_FunctionAddress != IntPtr.Zero && OnConstructionCS_Transform_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUProceduralSpawnSceneItemBase:OnConstructionCS", OnConstructionCS_IsValid);
	}

	static BGUProceduralSpawnSceneItemBase()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUProceduralSpawnSceneItemBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUProceduralSpawnSceneItemBase));
	}
}
