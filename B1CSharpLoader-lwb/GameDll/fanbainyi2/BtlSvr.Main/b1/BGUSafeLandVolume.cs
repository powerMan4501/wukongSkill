using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUSafeLandVolume")]
internal class BGUSafeLandVolume : BGUActorBaseCS
{
	private static bool SafeLandBox_IsValid;

	private static int SafeLandBox_Offset;

	private static bool BeginPlayCS_IsValid;

	private static IntPtr BeginPlayCS_FunctionAddress;

	private static int BeginPlayCS_ParamsSize;

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUSafeLandVolume:SafeLandBox")]
	public UBoxComponent SafeLandBox
	{
		get
		{
			CheckDestroyed();
			if (!SafeLandBox_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSafeLandVolume:SafeLandBox");
				return null;
			}
			return UObjectMarshaler<UBoxComponent>.FromNative(IntPtr.Add(base.Address, SafeLandBox_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SafeLandBox_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSafeLandVolume:SafeLandBox");
			}
			else
			{
				UObjectMarshaler<UBoxComponent>.ToNative(IntPtr.Add(base.Address, SafeLandBox_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		SafeLandBox = initializer.CreateDefaultSubobject<UBoxComponent>(this, B1GlobalFNames.SafeLandBox);
		SetRootComponentCS(SafeLandBox);
		SafeLandBox.SetCollisionProfileName(B1GlobalFNames.Trigger);
	}

	[USharpPath("/Script/b1-Managed.BGUSafeLandVolume:BeginPlayCS")]
	protected override void BeginPlayCS_Implementation()
	{
		base.BeginPlayCS_Implementation();
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddCompUObj<BUS_SafeLandVolumeComp>();
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<BUS_ActorBaseDataComp>(this, B1GlobalFNames.SafeLandVolumeDataComp);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUSafeLandVolume:BeginPlayCS")]
	private static void BeginPlayCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BGUSafeLandVolume bGUSafeLandVolume = GCHelper.Find<b1.BGUSafeLandVolume>(obj);
		bGUSafeLandVolume.BeginPlayCS_Implementation();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGUSafeLandVolume");
		SafeLandBox_Offset = NativeReflection.GetPropertyOffset(intPtr, "SafeLandBox");
		SafeLandBox_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SafeLandBox", Classes.FObjectProperty);
		BeginPlayCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BeginPlayCS");
		BeginPlayCS_ParamsSize = NativeReflection.GetFunctionParamsSize(BeginPlayCS_FunctionAddress);
		BeginPlayCS_IsValid = BeginPlayCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUSafeLandVolume:BeginPlayCS", BeginPlayCS_IsValid);
	}

	static BGUSafeLandVolume()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BGUSafeLandVolume)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BGUSafeLandVolume));
	}
}
