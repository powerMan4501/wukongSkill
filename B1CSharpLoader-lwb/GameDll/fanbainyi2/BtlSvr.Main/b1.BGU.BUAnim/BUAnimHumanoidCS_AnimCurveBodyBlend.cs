using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.BGU.BUAnim;

[Abstract]
[Blueprintable]
[UClass]
[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AnimCurveBodyBlend")]
public class BUAnimHumanoidCS_AnimCurveBodyBlend : BUAnimHumanoidCS_LinkedInstanceBase
{
	private IBUC_ABPBodyBlendData BodyBlendData;

	private static bool ASCurveBodyBlendUpperBody_IsValid;

	private static int ASCurveBodyBlendUpperBody_Offset;

	private static bool CurveBodyBlendUpperBodyWeight_IsValid;

	private static int CurveBodyBlendUpperBodyWeight_Offset;

	private static bool ASCurveBodyBlendLeftArm_IsValid;

	private static int ASCurveBodyBlendLeftArm_Offset;

	private static bool CurveBodyBlendLeftArmWeight_IsValid;

	private static int CurveBodyBlendLeftArmWeight_Offset;

	private static bool ASCurveBodyBlendRightArm_IsValid;

	private static int ASCurveBodyBlendRightArm_Offset;

	private static bool CurveBodyBlendRightArmWeight_IsValid;

	private static int CurveBodyBlendRightArmWeight_Offset;

	private static bool ASCurveBodyBlendLeftLeg_IsValid;

	private static int ASCurveBodyBlendLeftLeg_Offset;

	private static bool CurveBodyBlendLeftLegWeight_IsValid;

	private static int CurveBodyBlendLeftLegWeight_Offset;

	private static bool ASCurveBodyBlendRightLeg_IsValid;

	private static int ASCurveBodyBlendRightLeg_Offset;

	private static bool CurveBodyBlendRightLegWeight_IsValid;

	private static int CurveBodyBlendRightLegWeight_Offset;

	[Category("DynamicBodyBlend")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AnimCurveBodyBlend:ASCurveBodyBlendUpperBody")]
	public UAnimSequenceBase ASCurveBodyBlendUpperBody
	{
		get
		{
			CheckDestroyed();
			if (!ASCurveBodyBlendUpperBody_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AnimCurveBodyBlend:ASCurveBodyBlendUpperBody");
				return null;
			}
			return UObjectMarshaler<UAnimSequenceBase>.FromNative(IntPtr.Add(base.Address, ASCurveBodyBlendUpperBody_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASCurveBodyBlendUpperBody_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AnimCurveBodyBlend:ASCurveBodyBlendUpperBody");
			}
			else
			{
				UObjectMarshaler<UAnimSequenceBase>.ToNative(IntPtr.Add(base.Address, ASCurveBodyBlendUpperBody_Offset), value);
			}
		}
	}

	[Category("DynamicBodyBlend")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AnimCurveBodyBlend:CurveBodyBlendUpperBodyWeight")]
	public float CurveBodyBlendUpperBodyWeight
	{
		get
		{
			CheckDestroyed();
			if (!CurveBodyBlendUpperBodyWeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AnimCurveBodyBlend:CurveBodyBlendUpperBodyWeight");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CurveBodyBlendUpperBodyWeight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CurveBodyBlendUpperBodyWeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AnimCurveBodyBlend:CurveBodyBlendUpperBodyWeight");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CurveBodyBlendUpperBodyWeight_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("DynamicBodyBlend")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AnimCurveBodyBlend:ASCurveBodyBlendLeftArm")]
	public UAnimSequenceBase ASCurveBodyBlendLeftArm
	{
		get
		{
			CheckDestroyed();
			if (!ASCurveBodyBlendLeftArm_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AnimCurveBodyBlend:ASCurveBodyBlendLeftArm");
				return null;
			}
			return UObjectMarshaler<UAnimSequenceBase>.FromNative(IntPtr.Add(base.Address, ASCurveBodyBlendLeftArm_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASCurveBodyBlendLeftArm_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AnimCurveBodyBlend:ASCurveBodyBlendLeftArm");
			}
			else
			{
				UObjectMarshaler<UAnimSequenceBase>.ToNative(IntPtr.Add(base.Address, ASCurveBodyBlendLeftArm_Offset), value);
			}
		}
	}

	[Category("DynamicBodyBlend")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AnimCurveBodyBlend:CurveBodyBlendLeftArmWeight")]
	public float CurveBodyBlendLeftArmWeight
	{
		get
		{
			CheckDestroyed();
			if (!CurveBodyBlendLeftArmWeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AnimCurveBodyBlend:CurveBodyBlendLeftArmWeight");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CurveBodyBlendLeftArmWeight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CurveBodyBlendLeftArmWeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AnimCurveBodyBlend:CurveBodyBlendLeftArmWeight");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CurveBodyBlendLeftArmWeight_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("DynamicBodyBlend")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AnimCurveBodyBlend:ASCurveBodyBlendRightArm")]
	public UAnimSequenceBase ASCurveBodyBlendRightArm
	{
		get
		{
			CheckDestroyed();
			if (!ASCurveBodyBlendRightArm_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AnimCurveBodyBlend:ASCurveBodyBlendRightArm");
				return null;
			}
			return UObjectMarshaler<UAnimSequenceBase>.FromNative(IntPtr.Add(base.Address, ASCurveBodyBlendRightArm_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASCurveBodyBlendRightArm_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AnimCurveBodyBlend:ASCurveBodyBlendRightArm");
			}
			else
			{
				UObjectMarshaler<UAnimSequenceBase>.ToNative(IntPtr.Add(base.Address, ASCurveBodyBlendRightArm_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("DynamicBodyBlend")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AnimCurveBodyBlend:CurveBodyBlendRightArmWeight")]
	public float CurveBodyBlendRightArmWeight
	{
		get
		{
			CheckDestroyed();
			if (!CurveBodyBlendRightArmWeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AnimCurveBodyBlend:CurveBodyBlendRightArmWeight");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CurveBodyBlendRightArmWeight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CurveBodyBlendRightArmWeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AnimCurveBodyBlend:CurveBodyBlendRightArmWeight");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CurveBodyBlendRightArmWeight_Offset), value);
			}
		}
	}

	[Category("DynamicBodyBlend")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AnimCurveBodyBlend:ASCurveBodyBlendLeftLeg")]
	public UAnimSequenceBase ASCurveBodyBlendLeftLeg
	{
		get
		{
			CheckDestroyed();
			if (!ASCurveBodyBlendLeftLeg_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AnimCurveBodyBlend:ASCurveBodyBlendLeftLeg");
				return null;
			}
			return UObjectMarshaler<UAnimSequenceBase>.FromNative(IntPtr.Add(base.Address, ASCurveBodyBlendLeftLeg_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASCurveBodyBlendLeftLeg_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AnimCurveBodyBlend:ASCurveBodyBlendLeftLeg");
			}
			else
			{
				UObjectMarshaler<UAnimSequenceBase>.ToNative(IntPtr.Add(base.Address, ASCurveBodyBlendLeftLeg_Offset), value);
			}
		}
	}

	[Category("DynamicBodyBlend")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AnimCurveBodyBlend:CurveBodyBlendLeftLegWeight")]
	public float CurveBodyBlendLeftLegWeight
	{
		get
		{
			CheckDestroyed();
			if (!CurveBodyBlendLeftLegWeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AnimCurveBodyBlend:CurveBodyBlendLeftLegWeight");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CurveBodyBlendLeftLegWeight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CurveBodyBlendLeftLegWeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AnimCurveBodyBlend:CurveBodyBlendLeftLegWeight");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CurveBodyBlendLeftLegWeight_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("DynamicBodyBlend")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AnimCurveBodyBlend:ASCurveBodyBlendRightLeg")]
	public UAnimSequenceBase ASCurveBodyBlendRightLeg
	{
		get
		{
			CheckDestroyed();
			if (!ASCurveBodyBlendRightLeg_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AnimCurveBodyBlend:ASCurveBodyBlendRightLeg");
				return null;
			}
			return UObjectMarshaler<UAnimSequenceBase>.FromNative(IntPtr.Add(base.Address, ASCurveBodyBlendRightLeg_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASCurveBodyBlendRightLeg_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AnimCurveBodyBlend:ASCurveBodyBlendRightLeg");
			}
			else
			{
				UObjectMarshaler<UAnimSequenceBase>.ToNative(IntPtr.Add(base.Address, ASCurveBodyBlendRightLeg_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("DynamicBodyBlend")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AnimCurveBodyBlend:CurveBodyBlendRightLegWeight")]
	public float CurveBodyBlendRightLegWeight
	{
		get
		{
			CheckDestroyed();
			if (!CurveBodyBlendRightLegWeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AnimCurveBodyBlend:CurveBodyBlendRightLegWeight");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CurveBodyBlendRightLegWeight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CurveBodyBlendRightLegWeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AnimCurveBodyBlend:CurveBodyBlendRightLegWeight");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CurveBodyBlendRightLegWeight_Offset), value);
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
	}

	private void UpdateData()
	{
		if (BodyBlendData != null)
		{
			ASCurveBodyBlendUpperBody = BodyBlendData.AnimCurveBodyBlendUpperBody;
			ASCurveBodyBlendLeftArm = BodyBlendData.AnimCurveBodyBlendLeftArm;
			ASCurveBodyBlendRightArm = BodyBlendData.AnimCurveBodyBlendRightArm;
			ASCurveBodyBlendLeftLeg = BodyBlendData.AnimCurveBodyBlendLeftLeg;
			ASCurveBodyBlendRightLeg = BodyBlendData.AnimCurveBodyBlendRightLeg;
			CurveBodyBlendUpperBodyWeight = BodyBlendData.CurveBodyBlendUpperBodyWeight;
			CurveBodyBlendLeftArmWeight = BodyBlendData.CurveBodyBlendLeftArmWeight;
			CurveBodyBlendRightArmWeight = BodyBlendData.CurveBodyBlendRightArmWeight;
			CurveBodyBlendLeftLegWeight = BodyBlendData.CurveBodyBlendLeftLegWeight;
			CurveBodyBlendRightLegWeight = BodyBlendData.CurveBodyBlendRightLegWeight;
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUAnimHumanoidCS_AnimCurveBodyBlend");
		ASCurveBodyBlendUpperBody_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ASCurveBodyBlendUpperBody");
		ASCurveBodyBlendUpperBody_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ASCurveBodyBlendUpperBody", Classes.FObjectProperty);
		CurveBodyBlendUpperBodyWeight_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CurveBodyBlendUpperBodyWeight");
		CurveBodyBlendUpperBodyWeight_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CurveBodyBlendUpperBodyWeight", Classes.FFloatProperty);
		ASCurveBodyBlendLeftArm_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ASCurveBodyBlendLeftArm");
		ASCurveBodyBlendLeftArm_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ASCurveBodyBlendLeftArm", Classes.FObjectProperty);
		CurveBodyBlendLeftArmWeight_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CurveBodyBlendLeftArmWeight");
		CurveBodyBlendLeftArmWeight_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CurveBodyBlendLeftArmWeight", Classes.FFloatProperty);
		ASCurveBodyBlendRightArm_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ASCurveBodyBlendRightArm");
		ASCurveBodyBlendRightArm_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ASCurveBodyBlendRightArm", Classes.FObjectProperty);
		CurveBodyBlendRightArmWeight_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CurveBodyBlendRightArmWeight");
		CurveBodyBlendRightArmWeight_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CurveBodyBlendRightArmWeight", Classes.FFloatProperty);
		ASCurveBodyBlendLeftLeg_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ASCurveBodyBlendLeftLeg");
		ASCurveBodyBlendLeftLeg_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ASCurveBodyBlendLeftLeg", Classes.FObjectProperty);
		CurveBodyBlendLeftLegWeight_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CurveBodyBlendLeftLegWeight");
		CurveBodyBlendLeftLegWeight_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CurveBodyBlendLeftLegWeight", Classes.FFloatProperty);
		ASCurveBodyBlendRightLeg_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ASCurveBodyBlendRightLeg");
		ASCurveBodyBlendRightLeg_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ASCurveBodyBlendRightLeg", Classes.FObjectProperty);
		CurveBodyBlendRightLegWeight_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CurveBodyBlendRightLegWeight");
		CurveBodyBlendRightLegWeight_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CurveBodyBlendRightLegWeight", Classes.FFloatProperty);
	}

	static BUAnimHumanoidCS_AnimCurveBodyBlend()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUAnimHumanoidCS_AnimCurveBodyBlend)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUAnimHumanoidCS_AnimCurveBodyBlend));
	}
}
