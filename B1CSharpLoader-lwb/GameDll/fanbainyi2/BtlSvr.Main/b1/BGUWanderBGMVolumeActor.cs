using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUWanderBGMVolumeActor")]
public class BGUWanderBGMVolumeActor : BGUActorBaseCS
{
	private static bool WanderBGMVolumeComp_IsValid;

	private static int WanderBGMVolumeComp_Offset;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUWanderBGMVolumeActor:WanderBGMVolumeComp")]
	public BUS_WanderBGMVolumeComp WanderBGMVolumeComp
	{
		get
		{
			CheckDestroyed();
			if (!WanderBGMVolumeComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUWanderBGMVolumeActor:WanderBGMVolumeComp");
				return null;
			}
			return UObjectMarshaler<BUS_WanderBGMVolumeComp>.FromNative(IntPtr.Add(base.Address, WanderBGMVolumeComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WanderBGMVolumeComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUWanderBGMVolumeActor:WanderBGMVolumeComp");
			}
			else
			{
				UObjectMarshaler<BUS_WanderBGMVolumeComp>.ToNative(IntPtr.Add(base.Address, WanderBGMVolumeComp_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		WanderBGMVolumeComp = initializer.CreateDefaultSubobject<BUS_WanderBGMVolumeComp>(this, B1GlobalFNames.WanderBGMVolumeComp);
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddComp(new BUS_WanderBGMVolumeCompImpl());
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<BUS_BGMVolumeDataComp>(this, B1GlobalFNames.BGMVolumeDataComp);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGUWanderBGMVolumeActor");
		WanderBGMVolumeComp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "WanderBGMVolumeComp");
		WanderBGMVolumeComp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "WanderBGMVolumeComp", Classes.FObjectProperty);
	}

	static BGUWanderBGMVolumeActor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUWanderBGMVolumeActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUWanderBGMVolumeActor));
	}
}
