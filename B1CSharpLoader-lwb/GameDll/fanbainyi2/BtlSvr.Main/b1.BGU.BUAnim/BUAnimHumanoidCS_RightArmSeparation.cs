using System;
using UnrealEngine.Runtime;

namespace b1.BGU.BUAnim;

[Abstract]
[Blueprintable]
[UClass]
[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_RightArmSeparation")]
public class BUAnimHumanoidCS_RightArmSeparation : BUAnimHumanoidCS_LinkedInstanceBase
{
	private IBUC_ABPBodyBlendData BodyBlendData;

	private static bool RightArmBlendWeight_IsValid;

	private static int RightArmBlendWeight_Offset;

	[UProperty]
	[BlueprintReadOnly]
	[Category("DynamicBodyBlend")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_RightArmSeparation:RightArmBlendWeight")]
	public float RightArmBlendWeight
	{
		get
		{
			CheckDestroyed();
			if (!RightArmBlendWeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_RightArmSeparation:RightArmBlendWeight");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, RightArmBlendWeight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RightArmBlendWeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_RightArmSeparation:RightArmBlendWeight");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, RightArmBlendWeight_Offset), value);
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
			RightArmBlendWeight = BodyBlendData.RightArmBlendWeight;
		}
	}

	private void UpdateData()
	{
		if (BodyBlendData != null)
		{
			RightArmBlendWeight = BodyBlendData.RightArmBlendWeight;
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUAnimHumanoidCS_RightArmSeparation");
		RightArmBlendWeight_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "RightArmBlendWeight");
		RightArmBlendWeight_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "RightArmBlendWeight", Classes.FFloatProperty);
	}

	static BUAnimHumanoidCS_RightArmSeparation()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUAnimHumanoidCS_RightArmSeparation)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUAnimHumanoidCS_RightArmSeparation));
	}
}
