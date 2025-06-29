using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUMeditationPointBase")]
public class BGUMeditationPointBase : BGUInteractiveActorBase
{
	private static bool MeditationPointConfigComp_IsValid;

	private static int MeditationPointConfigComp_Offset;

	private static bool ReceiveBeginPlay_IsValid;

	private static IntPtr ReceiveBeginPlay_FunctionAddress;

	private static int ReceiveBeginPlay_ParamsSize;

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUMeditationPointBase:MeditationPointConfigComp")]
	public BUS_MeditationPointConfigComp MeditationPointConfigComp
	{
		get
		{
			CheckDestroyed();
			if (!MeditationPointConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUMeditationPointBase:MeditationPointConfigComp");
				return null;
			}
			return UObjectMarshaler<BUS_MeditationPointConfigComp>.FromNative(IntPtr.Add(base.Address, MeditationPointConfigComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MeditationPointConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUMeditationPointBase:MeditationPointConfigComp");
			}
			else
			{
				UObjectMarshaler<BUS_MeditationPointConfigComp>.ToNative(IntPtr.Add(base.Address, MeditationPointConfigComp_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		MeditationPointConfigComp = initializer.CreateDefaultSubobject<BUS_MeditationPointConfigComp>(this, B1GlobalFNames.MeditationPointConfigSystem);
	}

	[USharpPath("/Script/b1-Managed.BGUMeditationPointBase:ReceiveBeginPlay")]
	protected override void ReceiveBeginPlay_Implementation()
	{
		base.ReceiveBeginPlay_Implementation();
		UBGUFunctionLibrary.BGUResetActorVelocity(this);
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddComp(new b1.BUS_MeditationPointCompImpl());
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<b1.BUS_MeditationPointDataComp>(this, B1GlobalFNames.MeditationPointDataComp);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUMeditationPointBase:ReceiveBeginPlay")]
	private static void ReceiveBeginPlay__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUMeditationPointBase bGUMeditationPointBase = GCHelper.Find<BGUMeditationPointBase>(obj);
		bGUMeditationPointBase.ReceiveBeginPlay_Implementation();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGUMeditationPointBase");
		MeditationPointConfigComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "MeditationPointConfigComp");
		MeditationPointConfigComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MeditationPointConfigComp", Classes.FObjectProperty);
		ReceiveBeginPlay_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveBeginPlay");
		ReceiveBeginPlay_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveBeginPlay_FunctionAddress);
		ReceiveBeginPlay_IsValid = ReceiveBeginPlay_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUMeditationPointBase:ReceiveBeginPlay", ReceiveBeginPlay_IsValid);
	}

	static BGUMeditationPointBase()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUMeditationPointBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUMeditationPointBase));
	}
}
