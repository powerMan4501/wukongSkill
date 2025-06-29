using System;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUDynamicSDFGenerator")]
public class BGUDynamicSDFGenerator : BGUActorBaseCS
{
	private static bool DefaultRootComp_IsValid;

	private static int DefaultRootComp_Offset;

	private static bool AttachTo_IsValid;

	private static int AttachTo_Offset;

	private static bool NS_DynamicSDF_Generator_IsValid;

	private static int NS_DynamicSDF_Generator_Offset;

	private static bool BeginPlayCS_IsValid;

	private static IntPtr BeginPlayCS_FunctionAddress;

	private static int BeginPlayCS_ParamsSize;

	[UProperty]
	[VisibleAnywhere]
	[USharpPath("/Script/b1-Managed.BGUDynamicSDFGenerator:DefaultRootComp")]
	private USceneComponent DefaultRootComp
	{
		get
		{
			CheckDestroyed();
			if (!DefaultRootComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUDynamicSDFGenerator:DefaultRootComp");
				return null;
			}
			return UObjectMarshaler<USceneComponent>.FromNative(IntPtr.Add(base.Address, DefaultRootComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DefaultRootComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUDynamicSDFGenerator:DefaultRootComp");
			}
			else
			{
				UObjectMarshaler<USceneComponent>.ToNative(IntPtr.Add(base.Address, DefaultRootComp_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUDynamicSDFGenerator:AttachTo")]
	public AActor AttachTo
	{
		get
		{
			CheckDestroyed();
			if (!AttachTo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUDynamicSDFGenerator:AttachTo");
				return null;
			}
			return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(base.Address, AttachTo_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AttachTo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUDynamicSDFGenerator:AttachTo");
			}
			else
			{
				UObjectMarshaler<AActor>.ToNative(IntPtr.Add(base.Address, AttachTo_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUDynamicSDFGenerator:NS_DynamicSDF_Generator")]
	protected UNiagaraComponent NS_DynamicSDF_Generator
	{
		get
		{
			CheckDestroyed();
			if (!NS_DynamicSDF_Generator_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUDynamicSDFGenerator:NS_DynamicSDF_Generator");
				return null;
			}
			return UObjectMarshaler<UNiagaraComponent>.FromNative(IntPtr.Add(base.Address, NS_DynamicSDF_Generator_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NS_DynamicSDF_Generator_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUDynamicSDFGenerator:NS_DynamicSDF_Generator");
			}
			else
			{
				UObjectMarshaler<UNiagaraComponent>.ToNative(IntPtr.Add(base.Address, NS_DynamicSDF_Generator_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		BaseInitialize(initializer);
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddComp(new BUS_DynamicSDFDataProcessComp());
	}

	[USharpPath("/Script/b1-Managed.BGUDynamicSDFGenerator:BeginPlayCS")]
	protected override void BeginPlayCS_Implementation()
	{
		base.BeginPlayCS_Implementation();
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<BUS_DynamicSDFDataProcessBaseDataComp>(this, B1GlobalFNames.DynamicSDFDataProcessBaseDataComp);
	}

	private void BaseInitialize(FObjectInitializer initializer)
	{
		DefaultRootComp = initializer.CreateDefaultSubobject<USceneComponent>(this, B1GlobalFNames.DefaultRootComp);
		SetRootComponentCS(DefaultRootComp);
		NS_DynamicSDF_Generator = initializer.CreateDefaultSubobject<UNiagaraComponent>(this, B1GlobalFNames.NS_DynamicSDF_Generator);
		NS_DynamicSDF_Generator.AttachToComponent(base.RootComponent, FName.None, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, bWeldSimulatedBodies: false);
	}

	public UNiagaraComponent Get_NS_DynamicSDF_Generator()
	{
		return NS_DynamicSDF_Generator;
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUDynamicSDFGenerator:BeginPlayCS")]
	private static void BeginPlayCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUDynamicSDFGenerator bGUDynamicSDFGenerator = GCHelper.Find<BGUDynamicSDFGenerator>(obj);
		bGUDynamicSDFGenerator.BeginPlayCS_Implementation();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGUDynamicSDFGenerator");
		DefaultRootComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "DefaultRootComp");
		DefaultRootComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DefaultRootComp", Classes.FObjectProperty);
		AttachTo_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttachTo");
		AttachTo_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttachTo", Classes.FObjectProperty);
		NS_DynamicSDF_Generator_Offset = NativeReflection.GetPropertyOffset(intPtr, "NS_DynamicSDF_Generator");
		NS_DynamicSDF_Generator_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NS_DynamicSDF_Generator", Classes.FObjectProperty);
		BeginPlayCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BeginPlayCS");
		BeginPlayCS_ParamsSize = NativeReflection.GetFunctionParamsSize(BeginPlayCS_FunctionAddress);
		BeginPlayCS_IsValid = BeginPlayCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUDynamicSDFGenerator:BeginPlayCS", BeginPlayCS_IsValid);
	}

	static BGUDynamicSDFGenerator()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUDynamicSDFGenerator)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUDynamicSDFGenerator));
	}
}
