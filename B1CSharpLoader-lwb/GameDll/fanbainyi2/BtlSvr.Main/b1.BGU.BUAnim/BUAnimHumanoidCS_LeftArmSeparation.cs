using System;
using UnrealEngine.Runtime;

namespace b1.BGU.BUAnim;

[UClass]
[Blueprintable]
[Abstract]
[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_LeftArmSeparation")]
public class BUAnimHumanoidCS_LeftArmSeparation : BUAnimHumanoidCS_LinkedInstanceBase
{
	private IBUC_ABPBodyBlendData BodyBlendData;

	private static bool LeftArmBlendWeight_IsValid;

	private static int LeftArmBlendWeight_Offset;

	[UProperty]
	[BlueprintReadOnly]
	[Category("DynamicBodyBlend")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_LeftArmSeparation:LeftArmBlendWeight")]
	public float LeftArmBlendWeight
	{
		get
		{
			CheckDestroyed();
			if (!LeftArmBlendWeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_LeftArmSeparation:LeftArmBlendWeight");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LeftArmBlendWeight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LeftArmBlendWeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_LeftArmSeparation:LeftArmBlendWeight");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LeftArmBlendWeight_Offset), value);
			}
		}
	}

	protected override void OnInitABPSetting()
	{
		if (!this.IsNullOrDestroyed())
		{
			InitData();
		}
	}

	protected override void LinkedGraphThreadUpdateAnimation(float DeltaTimeX)
	{
		UpdateData();
	}

	private void InitBUCData()
	{
		if (!(Owner == null) && ECSExtension.IsECSActor(Owner))
		{
			BodyBlendData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ABPBodyBlendData, BUC_ABPBodyBlendData>(Owner);
		}
	}

	private void InitData()
	{
		InitBUCData();
		if (BodyBlendData != null)
		{
			LeftArmBlendWeight = BodyBlendData.LeftArmBlendWeight;
		}
	}

	private void UpdateData()
	{
		if (BodyBlendData != null)
		{
			LeftArmBlendWeight = BodyBlendData.LeftArmBlendWeight;
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUAnimHumanoidCS_LeftArmSeparation");
		LeftArmBlendWeight_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LeftArmBlendWeight");
		LeftArmBlendWeight_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LeftArmBlendWeight", Classes.FFloatProperty);
	}

	static BUAnimHumanoidCS_LeftArmSeparation()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUAnimHumanoidCS_LeftArmSeparation)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUAnimHumanoidCS_LeftArmSeparation));
	}
}
