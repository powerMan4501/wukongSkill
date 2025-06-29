using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.BGU.BUAnim;

[Blueprintable]
[Abstract]
[UClass]
[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_UpperBodySeparation")]
public class BUAnimHumanoidCS_UpperBodySeparation : BUAnimHumanoidCS_LinkedInstanceBase
{
	private IBUC_ABPBodyBlendData BodyBlendData;

	private static bool UpperBodyBlendWeight_IsValid;

	private static int UpperBodyBlendWeight_Offset;

	private static bool BSUpperBodyBlendAdditive_IsValid;

	private static int BSUpperBodyBlendAdditive_Offset;

	private static bool BSUpperBodyBlendAdditiveX_IsValid;

	private static int BSUpperBodyBlendAdditiveX_Offset;

	private static bool BSUpperBodyBlendAdditiveY_IsValid;

	private static int BSUpperBodyBlendAdditiveY_Offset;

	[UProperty]
	[BlueprintReadOnly]
	[Category("DynamicBodyBlend")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_UpperBodySeparation:UpperBodyBlendWeight")]
	public float UpperBodyBlendWeight
	{
		get
		{
			CheckDestroyed();
			if (!UpperBodyBlendWeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_UpperBodySeparation:UpperBodyBlendWeight");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, UpperBodyBlendWeight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UpperBodyBlendWeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_UpperBodySeparation:UpperBodyBlendWeight");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, UpperBodyBlendWeight_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("DynamicBodyBlend")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_UpperBodySeparation:BSUpperBodyBlendAdditive")]
	public UBlendSpace BSUpperBodyBlendAdditive
	{
		get
		{
			CheckDestroyed();
			if (!BSUpperBodyBlendAdditive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_UpperBodySeparation:BSUpperBodyBlendAdditive");
				return null;
			}
			return UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(base.Address, BSUpperBodyBlendAdditive_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSUpperBodyBlendAdditive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_UpperBodySeparation:BSUpperBodyBlendAdditive");
			}
			else
			{
				UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(base.Address, BSUpperBodyBlendAdditive_Offset), value);
			}
		}
	}

	[Category("DynamicBodyBlend")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_UpperBodySeparation:BSUpperBodyBlendAdditiveX")]
	public float BSUpperBodyBlendAdditiveX
	{
		get
		{
			CheckDestroyed();
			if (!BSUpperBodyBlendAdditiveX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_UpperBodySeparation:BSUpperBodyBlendAdditiveX");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BSUpperBodyBlendAdditiveX_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSUpperBodyBlendAdditiveX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_UpperBodySeparation:BSUpperBodyBlendAdditiveX");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BSUpperBodyBlendAdditiveX_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("DynamicBodyBlend")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_UpperBodySeparation:BSUpperBodyBlendAdditiveY")]
	public float BSUpperBodyBlendAdditiveY
	{
		get
		{
			CheckDestroyed();
			if (!BSUpperBodyBlendAdditiveY_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_UpperBodySeparation:BSUpperBodyBlendAdditiveY");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BSUpperBodyBlendAdditiveY_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSUpperBodyBlendAdditiveY_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_UpperBodySeparation:BSUpperBodyBlendAdditiveY");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BSUpperBodyBlendAdditiveY_Offset), value);
			}
		}
	}

	protected override void OnInitABPSetting()
	{
		if (!this.IsNullOrDestroyed())
		{
			BUABPSettingData aBPSettingData = TopAnimInst.ABPSettingData;
			if (aBPSettingData != null)
			{
				InitBodyBlendSetting(aBPSettingData.BodyBlendSetting);
				InitData();
			}
		}
	}

	private void InitBodyBlendSetting(BUABPBodyBlendSettingData Setting)
	{
		BSUpperBodyBlendAdditive = Setting.BSUpperBodyBlendAdditive;
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
			UpperBodyBlendWeight = BodyBlendData.UpperBodyBlendWeight;
		}
	}

	private void UpdateData()
	{
		if (BodyBlendData != null)
		{
			UpperBodyBlendWeight = BodyBlendData.UpperBodyBlendWeight;
			BSUpperBodyBlendAdditiveX = BodyBlendData.BSUpperBodyBlendAdditiveX;
			BSUpperBodyBlendAdditiveY = BodyBlendData.BSUpperBodyBlendAdditiveY;
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUAnimHumanoidCS_UpperBodySeparation");
		UpperBodyBlendWeight_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "UpperBodyBlendWeight");
		UpperBodyBlendWeight_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "UpperBodyBlendWeight", Classes.FFloatProperty);
		BSUpperBodyBlendAdditive_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BSUpperBodyBlendAdditive");
		BSUpperBodyBlendAdditive_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BSUpperBodyBlendAdditive", Classes.FObjectProperty);
		BSUpperBodyBlendAdditiveX_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BSUpperBodyBlendAdditiveX");
		BSUpperBodyBlendAdditiveX_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BSUpperBodyBlendAdditiveX", Classes.FFloatProperty);
		BSUpperBodyBlendAdditiveY_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BSUpperBodyBlendAdditiveY");
		BSUpperBodyBlendAdditiveY_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BSUpperBodyBlendAdditiveY", Classes.FFloatProperty);
	}

	static BUAnimHumanoidCS_UpperBodySeparation()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUAnimHumanoidCS_UpperBodySeparation)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUAnimHumanoidCS_UpperBodySeparation));
	}
}
