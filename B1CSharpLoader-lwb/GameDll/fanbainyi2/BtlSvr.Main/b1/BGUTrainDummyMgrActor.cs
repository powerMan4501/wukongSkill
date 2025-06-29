using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUTrainDummyMgrActor")]
internal class BGUTrainDummyMgrActor : BGUActorBaseCS
{
	private static bool ZBBTrainMgrConfigComp_IsValid;

	private static int ZBBTrainMgrConfigComp_Offset;

	private static bool BeginPlayCS_IsValid;

	private static IntPtr BeginPlayCS_FunctionAddress;

	private static int BeginPlayCS_ParamsSize;

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGUTrainDummyMgrActor:ZBBTrainMgrConfigComp")]
	private BUS_TrainDummyMgrConfigComp ZBBTrainMgrConfigComp
	{
		get
		{
			CheckDestroyed();
			if (!ZBBTrainMgrConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUTrainDummyMgrActor:ZBBTrainMgrConfigComp");
				return null;
			}
			return UObjectMarshaler<BUS_TrainDummyMgrConfigComp>.FromNative(IntPtr.Add(base.Address, ZBBTrainMgrConfigComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ZBBTrainMgrConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUTrainDummyMgrActor:ZBBTrainMgrConfigComp");
			}
			else
			{
				UObjectMarshaler<BUS_TrainDummyMgrConfigComp>.ToNative(IntPtr.Add(base.Address, ZBBTrainMgrConfigComp_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		ZBBTrainMgrConfigComp = initializer.CreateDefaultSubobject<BUS_TrainDummyMgrConfigComp>(this, B1GlobalFNames.ZBBTrainMgrConfigComp);
	}

	[USharpPath("/Script/b1-Managed.BGUTrainDummyMgrActor:BeginPlayCS")]
	protected override void BeginPlayCS_Implementation()
	{
		base.BeginPlayCS_Implementation();
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddComp(new BUS_TrainDummyMgrComp());
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<BUS_TrainDummyMgrDataComp>(this, B1GlobalFNames.ZBBTrainMgrDataComp);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUTrainDummyMgrActor:BeginPlayCS")]
	private static void BeginPlayCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BGUTrainDummyMgrActor bGUTrainDummyMgrActor = GCHelper.Find<b1.BGUTrainDummyMgrActor>(obj);
		bGUTrainDummyMgrActor.BeginPlayCS_Implementation();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGUTrainDummyMgrActor");
		ZBBTrainMgrConfigComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "ZBBTrainMgrConfigComp");
		ZBBTrainMgrConfigComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ZBBTrainMgrConfigComp", Classes.FObjectProperty);
		BeginPlayCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BeginPlayCS");
		BeginPlayCS_ParamsSize = NativeReflection.GetFunctionParamsSize(BeginPlayCS_FunctionAddress);
		BeginPlayCS_IsValid = BeginPlayCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUTrainDummyMgrActor:BeginPlayCS", BeginPlayCS_IsValid);
	}

	static BGUTrainDummyMgrActor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BGUTrainDummyMgrActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BGUTrainDummyMgrActor));
	}
}
