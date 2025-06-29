using System;
using b1.Plugins.Calliope;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("切换眼球AO")]
[USharpPath("/Script/b1-Managed.PerformerAction_SwitchEyeAimOffsetIndex")]
public class UPerformerAction_SwitchEyeAimOffsetIndex : UPerformerActionBase
{
	private static bool Performer_IsValid;

	private static int Performer_Offset;

	private static bool Index_IsValid;

	private static int Index_Offset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.PerformerAction_SwitchEyeAimOffsetIndex:Performer")]
	public FGsSmartParam Performer
	{
		get
		{
			CheckDestroyed();
			if (!Performer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.PerformerAction_SwitchEyeAimOffsetIndex:Performer");
				return default(FGsSmartParam);
			}
			return FGsSmartParam.FromNative(IntPtr.Add(base.Address, Performer_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Performer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.PerformerAction_SwitchEyeAimOffsetIndex:Performer");
			}
			else
			{
				FGsSmartParam.ToNative(IntPtr.Add(base.Address, Performer_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.PerformerAction_SwitchEyeAimOffsetIndex:Index")]
	public int Index
	{
		get
		{
			CheckDestroyed();
			if (!Index_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.PerformerAction_SwitchEyeAimOffsetIndex:Index");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, Index_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Index_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.PerformerAction_SwitchEyeAimOffsetIndex:Index");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, Index_Offset), value);
			}
		}
	}

	protected override bool DoAction()
	{
		if (base.ControlComp.GetParamActorGuid(Performer.ConfigGuid, out var OutActorGuid))
		{
			BGUPerformerActorCS bGUPerformerActorCS = BGU_DataUtil.GetActorByGuid(this, OutActorGuid) as BGUPerformerActorCS;
			if (bGUPerformerActorCS != null)
			{
				BUAnimPerformer bUAnimPerformer = bGUPerformerActorCS.Mesh.GetAnimInstance() as BUAnimPerformer;
				if (bUAnimPerformer != null)
				{
					bUAnimPerformer.SetEyeAimOffsetIndex(Index);
				}
			}
		}
		return true;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.PerformerAction_SwitchEyeAimOffsetIndex");
		Performer_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Performer");
		Performer_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Performer", Classes.FStructProperty);
		Index_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Index");
		Index_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Index", Classes.FIntProperty);
	}

	static UPerformerAction_SwitchEyeAimOffsetIndex()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(UPerformerAction_SwitchEyeAimOffsetIndex)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPerformerAction_SwitchEyeAimOffsetIndex));
	}
}
