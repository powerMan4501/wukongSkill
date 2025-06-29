using System;
using b1.Plugins.AkAudio;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUNarrator")]
public class BGUNarrator : BGUActorBaseCS
{
	private static bool AkComp_IsValid;

	private static int AkComp_Offset;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGUNarrator:AkComp")]
	public UAkComponent AkComp
	{
		get
		{
			CheckDestroyed();
			if (!AkComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUNarrator:AkComp");
				return null;
			}
			return UObjectMarshaler<UAkComponent>.FromNative(IntPtr.Add(base.Address, AkComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AkComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUNarrator:AkComp");
			}
			else
			{
				UObjectMarshaler<UAkComponent>.ToNative(IntPtr.Add(base.Address, AkComp_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		AkComp = initializer.CreateDefaultSubobject<UAkComponent>(this, B1GlobalFNames.Ak);
		AkComp.SetAttenuationScalingFactor(0f);
		AkComp.OcclusionCollisionChannel = (EAkCollisionChannel)27;
		SetRootComponentCS(AkComp);
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddCompUObj<b1.BUS_AKMgrComp>(1);
		base.ActorCompContainerCS.AddComp(new BUS_AIConversationCompl(), 1);
		base.ActorCompContainerCS.AddCompUObj<b1.BUS_UIControlSystemV2>(1);
		base.ActorCompContainerCS.AddComp(new BUS_BattleInfoComp(), 1);
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<BUS_NarratorDataComp>(this, B1GlobalFNames.NarratorDataComp);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGUNarrator");
		AkComp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AkComp");
		AkComp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AkComp", Classes.FObjectProperty);
	}

	static BGUNarrator()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUNarrator)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUNarrator));
	}
}
