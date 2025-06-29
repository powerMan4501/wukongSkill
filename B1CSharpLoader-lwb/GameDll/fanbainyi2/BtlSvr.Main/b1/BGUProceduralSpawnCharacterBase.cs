using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUProceduralSpawnCharacterBase")]
public class BGUProceduralSpawnCharacterBase : BGUActorBaseCS
{
	private static bool ProceduralSpawnCharacterDataConfigComp_IsValid;

	private static int ProceduralSpawnCharacterDataConfigComp_Offset;

	private static bool OnConstructionCS_IsValid;

	private static IntPtr OnConstructionCS_FunctionAddress;

	private static int OnConstructionCS_ParamsSize;

	private static bool OnConstructionCS_Transform_IsValid;

	private static int OnConstructionCS_Transform_Offset;

	private static FFieldAddress OnConstructionCS_Transform_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGUProceduralSpawnCharacterBase:ProceduralSpawnCharacterDataConfigComp")]
	public BUS_ProceduralSpawnCharacterDataConfigComp ProceduralSpawnCharacterDataConfigComp
	{
		get
		{
			CheckDestroyed();
			if (!ProceduralSpawnCharacterDataConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUProceduralSpawnCharacterBase:ProceduralSpawnCharacterDataConfigComp");
				return null;
			}
			return UObjectMarshaler<BUS_ProceduralSpawnCharacterDataConfigComp>.FromNative(IntPtr.Add(base.Address, ProceduralSpawnCharacterDataConfigComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ProceduralSpawnCharacterDataConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUProceduralSpawnCharacterBase:ProceduralSpawnCharacterDataConfigComp");
			}
			else
			{
				UObjectMarshaler<BUS_ProceduralSpawnCharacterDataConfigComp>.ToNative(IntPtr.Add(base.Address, ProceduralSpawnCharacterDataConfigComp_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		initializer.CreateDefaultSubobject<UBGUDebugCircleComponent>(this, B1GlobalFNames.DebugCircleComponent);
		ProceduralSpawnCharacterDataConfigComp = initializer.CreateDefaultSubobject<BUS_ProceduralSpawnCharacterDataConfigComp>(this, B1GlobalFNames.ProceduralSpawnCharacterDataConfigComp);
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddComp(new BUS_ProceduralSpawnCharacterComp());
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<BUS_ProceduralSpawnCharacterDataComp>(this, B1GlobalFNames.ProceduralSpawnCharacterDataComp);
	}

	[USharpPath("/Script/b1-Managed.BGUProceduralSpawnCharacterBase:OnConstructionCS")]
	protected override void OnConstructionCS_Implementation(FTransform Transform)
	{
		base.OnConstructionCS_Implementation(Transform);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUProceduralSpawnCharacterBase:OnConstructionCS")]
	private static void OnConstructionCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUProceduralSpawnCharacterBase bGUProceduralSpawnCharacterBase = GCHelper.Find<BGUProceduralSpawnCharacterBase>(obj);
		FTransform transform = BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(buffer, OnConstructionCS_Transform_Offset));
		bGUProceduralSpawnCharacterBase.OnConstructionCS_Implementation(transform);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGUProceduralSpawnCharacterBase");
		ProceduralSpawnCharacterDataConfigComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "ProceduralSpawnCharacterDataConfigComp");
		ProceduralSpawnCharacterDataConfigComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ProceduralSpawnCharacterDataConfigComp", Classes.FObjectProperty);
		OnConstructionCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnConstructionCS");
		OnConstructionCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnConstructionCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnConstructionCS_Transform_PropertyAddress, OnConstructionCS_FunctionAddress, "Transform");
		OnConstructionCS_Transform_Offset = NativeReflection.GetPropertyOffset(OnConstructionCS_FunctionAddress, "Transform");
		OnConstructionCS_Transform_IsValid = NativeReflection.ValidatePropertyClass(OnConstructionCS_FunctionAddress, "Transform", Classes.FStructProperty);
		OnConstructionCS_IsValid = OnConstructionCS_FunctionAddress != IntPtr.Zero && OnConstructionCS_Transform_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUProceduralSpawnCharacterBase:OnConstructionCS", OnConstructionCS_IsValid);
	}

	static BGUProceduralSpawnCharacterBase()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUProceduralSpawnCharacterBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUProceduralSpawnCharacterBase));
	}
}
