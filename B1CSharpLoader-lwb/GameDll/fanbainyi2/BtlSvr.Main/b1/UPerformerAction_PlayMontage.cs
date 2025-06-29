using System;
using b1.Plugins.Calliope;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("演员播放动画")]
[USharpPath("/Script/b1-Managed.PerformerAction_PlayMontage")]
public class UPerformerAction_PlayMontage : UPerformerActionBase
{
	private static bool Performer_IsValid;

	private static int Performer_Offset;

	private static bool Montage_IsValid;

	private static int Montage_Offset;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.PerformerAction_PlayMontage:Performer")]
	public FGsSmartParam Performer
	{
		get
		{
			CheckDestroyed();
			if (!Performer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.PerformerAction_PlayMontage:Performer");
				return default(FGsSmartParam);
			}
			return FGsSmartParam.FromNative(IntPtr.Add(base.Address, Performer_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Performer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.PerformerAction_PlayMontage:Performer");
			}
			else
			{
				FGsSmartParam.ToNative(IntPtr.Add(base.Address, Performer_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.PerformerAction_PlayMontage:Montage")]
	public UAnimMontage Montage
	{
		get
		{
			CheckDestroyed();
			if (!Montage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.PerformerAction_PlayMontage:Montage");
				return null;
			}
			return UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(base.Address, Montage_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Montage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.PerformerAction_PlayMontage:Montage");
			}
			else
			{
				UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(base.Address, Montage_Offset), value);
			}
		}
	}

	protected override bool DoAction()
	{
		if (Montage == null)
		{
			return true;
		}
		if (base.ControlComp.GetParamActorGuid(Performer.ConfigGuid, out var OutActorGuid))
		{
			BGUPerformerActorCS bGUPerformerActorCS = BGU_DataUtil.GetActorByGuid(this, OutActorGuid) as BGUPerformerActorCS;
			if (bGUPerformerActorCS != null)
			{
				BGUFuncLibAnim.BGUActorTryPlayMontage(bGUPerformerActorCS, Montage, FName.None);
			}
		}
		return true;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.PerformerAction_PlayMontage");
		Performer_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Performer");
		Performer_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Performer", Classes.FStructProperty);
		Montage_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Montage");
		Montage_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Montage", Classes.FObjectProperty);
	}

	static UPerformerAction_PlayMontage()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(UPerformerAction_PlayMontage)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPerformerAction_PlayMontage));
	}
}
