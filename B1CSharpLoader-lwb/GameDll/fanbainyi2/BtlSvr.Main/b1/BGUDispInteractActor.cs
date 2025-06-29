using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUDispInteractActor")]
public class BGUDispInteractActor : BGUActorBaseCS, IECSWorldObj
{
	private static bool AttachTo_IsValid;

	private static int AttachTo_Offset;

	private static bool InteractDrawConfigComp_IsValid;

	private static int InteractDrawConfigComp_Offset;

	private static bool BeginPlayCS_IsValid;

	private static IntPtr BeginPlayCS_FunctionAddress;

	private static int BeginPlayCS_ParamsSize;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGUDispInteractActor:AttachTo")]
	public AActor AttachTo
	{
		get
		{
			CheckDestroyed();
			if (!AttachTo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUDispInteractActor:AttachTo");
				return null;
			}
			return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(base.Address, AttachTo_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AttachTo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUDispInteractActor:AttachTo");
			}
			else
			{
				UObjectMarshaler<AActor>.ToNative(IntPtr.Add(base.Address, AttachTo_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGUDispInteractActor:InteractDrawConfigComp")]
	public BUS_InteractDrawConfigComp InteractDrawConfigComp
	{
		get
		{
			CheckDestroyed();
			if (!InteractDrawConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUDispInteractActor:InteractDrawConfigComp");
				return null;
			}
			return UObjectMarshaler<BUS_InteractDrawConfigComp>.FromNative(IntPtr.Add(base.Address, InteractDrawConfigComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InteractDrawConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUDispInteractActor:InteractDrawConfigComp");
			}
			else
			{
				UObjectMarshaler<BUS_InteractDrawConfigComp>.ToNative(IntPtr.Add(base.Address, InteractDrawConfigComp_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		BaseInitialize(initializer);
		InteractDrawConfigComp = initializer.CreateDefaultSubobject<BUS_InteractDrawConfigComp>(this, B1GlobalFNames.InteractDrawConfigComp);
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddComp(new BUS_InteractDrawComp());
	}

	[USharpPath("/Script/b1-Managed.BGUDispInteractActor:BeginPlayCS")]
	protected override void BeginPlayCS_Implementation()
	{
		base.BeginPlayCS_Implementation();
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<BUS_DispInteractBaseDataComp>(this, B1GlobalFNames.DispInteractDataComp);
	}

	private void BaseInitialize(FObjectInitializer initializer)
	{
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUDispInteractActor:BeginPlayCS")]
	private static void BeginPlayCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUDispInteractActor bGUDispInteractActor = GCHelper.Find<BGUDispInteractActor>(obj);
		bGUDispInteractActor.BeginPlayCS_Implementation();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGUDispInteractActor");
		AttachTo_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttachTo");
		AttachTo_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttachTo", Classes.FObjectProperty);
		InteractDrawConfigComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "InteractDrawConfigComp");
		InteractDrawConfigComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InteractDrawConfigComp", Classes.FObjectProperty);
		BeginPlayCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BeginPlayCS");
		BeginPlayCS_ParamsSize = NativeReflection.GetFunctionParamsSize(BeginPlayCS_FunctionAddress);
		BeginPlayCS_IsValid = BeginPlayCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUDispInteractActor:BeginPlayCS", BeginPlayCS_IsValid);
	}

	static BGUDispInteractActor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUDispInteractActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUDispInteractActor));
	}
}
