using System;
using UnrealEngine.AnimGraphRuntime;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.BGU.BUAnim;

[Abstract]
[Blueprintable]
[UClass]
[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AnimCurveBodySeparation")]
public class BUAnimHumanoidCS_AnimCurveBodySeparation : BUAnimHumanoidCS_LinkedInstanceBase
{
	private IBUC_ABPBodyBlendData BodyBlendData;

	private IBUC_ABPCharacterData ChrData;

	private bool bCanUseBodySeparation;

	private float SwitchBodySeparationBlendTime;

	private static bool BodyBlendWeight_Leg_IsValid;

	private static int BodyBlendWeight_Leg_Offset;

	private static bool BodyBlendWeight_Pelvis_IsValid;

	private static int BodyBlendWeight_Pelvis_Offset;

	private static bool BodyBlendWeight_Spine_IsValid;

	private static int BodyBlendWeight_Spine_Offset;

	private static bool BodyBlendWeight_Head_IsValid;

	private static int BodyBlendWeight_Head_Offset;

	private static bool BodyBlendWeight_ArmL_IsValid;

	private static int BodyBlendWeight_ArmL_Offset;

	private static bool BodyBlendWeight_ArmR_IsValid;

	private static int BodyBlendWeight_ArmR_Offset;

	private static bool BodyBlendWeight_ArmL_LocalSpace_IsValid;

	private static int BodyBlendWeight_ArmL_LocalSpace_Offset;

	private static bool BodyBlendWeight_ArmR_LocalSpace_IsValid;

	private static int BodyBlendWeight_ArmR_LocalSpace_Offset;

	private static bool BodySeparationBlendAlpha_IsValid;

	private static int BodySeparationBlendAlpha_Offset;

	private static bool InitBodySeparationBlend_IsValid;

	private static IntPtr InitBodySeparationBlend_FunctionAddress;

	private static int InitBodySeparationBlend_ParamsSize;

	private static bool InitBodySeparationBlend_Context_IsValid;

	private static int InitBodySeparationBlend_Context_Offset;

	private static FFieldAddress InitBodySeparationBlend_Context_PropertyAddress;

	private static bool InitBodySeparationBlend_Node_IsValid;

	private static int InitBodySeparationBlend_Node_Offset;

	private static FFieldAddress InitBodySeparationBlend_Node_PropertyAddress;

	private static bool UpdateBodySeparationBlend_IsValid;

	private static IntPtr UpdateBodySeparationBlend_FunctionAddress;

	private static int UpdateBodySeparationBlend_ParamsSize;

	private static bool UpdateBodySeparationBlend_Context_IsValid;

	private static int UpdateBodySeparationBlend_Context_Offset;

	private static FFieldAddress UpdateBodySeparationBlend_Context_PropertyAddress;

	private static bool UpdateBodySeparationBlend_Node_IsValid;

	private static int UpdateBodySeparationBlend_Node_Offset;

	private static FFieldAddress UpdateBodySeparationBlend_Node_PropertyAddress;

	[BlueprintReadOnly]
	[UProperty]
	[Category("Body Split")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AnimCurveBodySeparation:BodyBlendWeight_Leg")]
	public float BodyBlendWeight_Leg
	{
		get
		{
			CheckDestroyed();
			if (!BodyBlendWeight_Leg_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AnimCurveBodySeparation:BodyBlendWeight_Leg");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BodyBlendWeight_Leg_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BodyBlendWeight_Leg_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AnimCurveBodySeparation:BodyBlendWeight_Leg");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BodyBlendWeight_Leg_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("Body Split")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AnimCurveBodySeparation:BodyBlendWeight_Pelvis")]
	public float BodyBlendWeight_Pelvis
	{
		get
		{
			CheckDestroyed();
			if (!BodyBlendWeight_Pelvis_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AnimCurveBodySeparation:BodyBlendWeight_Pelvis");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BodyBlendWeight_Pelvis_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BodyBlendWeight_Pelvis_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AnimCurveBodySeparation:BodyBlendWeight_Pelvis");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BodyBlendWeight_Pelvis_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Body Split")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AnimCurveBodySeparation:BodyBlendWeight_Spine")]
	public float BodyBlendWeight_Spine
	{
		get
		{
			CheckDestroyed();
			if (!BodyBlendWeight_Spine_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AnimCurveBodySeparation:BodyBlendWeight_Spine");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BodyBlendWeight_Spine_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BodyBlendWeight_Spine_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AnimCurveBodySeparation:BodyBlendWeight_Spine");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BodyBlendWeight_Spine_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Body Split")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AnimCurveBodySeparation:BodyBlendWeight_Head")]
	public float BodyBlendWeight_Head
	{
		get
		{
			CheckDestroyed();
			if (!BodyBlendWeight_Head_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AnimCurveBodySeparation:BodyBlendWeight_Head");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BodyBlendWeight_Head_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BodyBlendWeight_Head_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AnimCurveBodySeparation:BodyBlendWeight_Head");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BodyBlendWeight_Head_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Body Split")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AnimCurveBodySeparation:BodyBlendWeight_ArmL")]
	public float BodyBlendWeight_ArmL
	{
		get
		{
			CheckDestroyed();
			if (!BodyBlendWeight_ArmL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AnimCurveBodySeparation:BodyBlendWeight_ArmL");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BodyBlendWeight_ArmL_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BodyBlendWeight_ArmL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AnimCurveBodySeparation:BodyBlendWeight_ArmL");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BodyBlendWeight_ArmL_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Body Split")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AnimCurveBodySeparation:BodyBlendWeight_ArmR")]
	public float BodyBlendWeight_ArmR
	{
		get
		{
			CheckDestroyed();
			if (!BodyBlendWeight_ArmR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AnimCurveBodySeparation:BodyBlendWeight_ArmR");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BodyBlendWeight_ArmR_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BodyBlendWeight_ArmR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AnimCurveBodySeparation:BodyBlendWeight_ArmR");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BodyBlendWeight_ArmR_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("Body Split")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AnimCurveBodySeparation:BodyBlendWeight_ArmL_LocalSpace")]
	public float BodyBlendWeight_ArmL_LocalSpace
	{
		get
		{
			CheckDestroyed();
			if (!BodyBlendWeight_ArmL_LocalSpace_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AnimCurveBodySeparation:BodyBlendWeight_ArmL_LocalSpace");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BodyBlendWeight_ArmL_LocalSpace_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BodyBlendWeight_ArmL_LocalSpace_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AnimCurveBodySeparation:BodyBlendWeight_ArmL_LocalSpace");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BodyBlendWeight_ArmL_LocalSpace_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Body Split")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AnimCurveBodySeparation:BodyBlendWeight_ArmR_LocalSpace")]
	public float BodyBlendWeight_ArmR_LocalSpace
	{
		get
		{
			CheckDestroyed();
			if (!BodyBlendWeight_ArmR_LocalSpace_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AnimCurveBodySeparation:BodyBlendWeight_ArmR_LocalSpace");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BodyBlendWeight_ArmR_LocalSpace_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BodyBlendWeight_ArmR_LocalSpace_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AnimCurveBodySeparation:BodyBlendWeight_ArmR_LocalSpace");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BodyBlendWeight_ArmR_LocalSpace_Offset), value);
			}
		}
	}

	[Category("Body Split")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AnimCurveBodySeparation:BodySeparationBlendAlpha")]
	public float BodySeparationBlendAlpha
	{
		get
		{
			CheckDestroyed();
			if (!BodySeparationBlendAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AnimCurveBodySeparation:BodySeparationBlendAlpha");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BodySeparationBlendAlpha_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BodySeparationBlendAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimHumanoidCS_AnimCurveBodySeparation:BodySeparationBlendAlpha");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BodySeparationBlendAlpha_Offset), value);
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
			ChrData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ABPCharacterData, BUC_ABPCharacterData>(Owner);
		}
	}

	private void InitData()
	{
		InitBUCData();
		bCanUseBodySeparation = false;
	}

	private void UpdateData()
	{
		if (BodyBlendData != null)
		{
			BodyBlendWeight_Leg = BodyBlendData.BodySplitBlendWeight_Leg;
			BodyBlendWeight_Pelvis = BodyBlendData.BodySplitBlendWeight_Pelvis;
			BodyBlendWeight_Spine = BodyBlendData.BodySplitBlendWeight_Spine;
			BodyBlendWeight_Head = BodyBlendData.BodySplitBlendWeight_Head;
			BodyBlendWeight_ArmL = BodyBlendData.BodySplitBlendWeight_ArmL;
			BodyBlendWeight_ArmR = BodyBlendData.BodySplitBlendWeight_ArmR;
			BodyBlendWeight_ArmL_LocalSpace = BodyBlendData.BodySplitBlendWeight_ArmL_LS;
			BodyBlendWeight_ArmR_LocalSpace = BodyBlendData.BodySplitBlendWeight_ArmR_LS;
		}
	}

	[UFunction]
	[BlueprintCallable]
	[Category("Thread Safe")]
	[UMeta(MDClass.BlueprintThreadSafe)]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AnimCurveBodySeparation:InitBodySeparationBlend")]
	private void InitBodySeparationBlend(ref FAnimUpdateContext Context, ref FAnimNodeReference Node)
	{
		BodySeparationBlendAlpha = 0f;
	}

	[BlueprintCallable]
	[UMeta(MDClass.BlueprintThreadSafe)]
	[UFunction]
	[Category("Thread Safe")]
	[USharpPath("/Script/b1-Managed.BUAnimHumanoidCS_AnimCurveBodySeparation:UpdateBodySeparationBlend")]
	private void UpdateBodySeparationBlend(ref FAnimUpdateContext Context, ref FAnimNodeReference Node)
	{
		if (BodyBlendData != null && TopAnimInst != null && bCanUseBodySeparation != BodyBlendData.bCanUseBodySeparation)
		{
			bCanUseBodySeparation = BodyBlendData.bCanUseBodySeparation;
			UAnimMontage currentActiveMontage = TopAnimInst.GetCurrentActiveMontage();
			if (currentActiveMontage != null)
			{
				SwitchBodySeparationBlendTime = (bCanUseBodySeparation ? currentActiveMontage.GetDefaultBlendOutTime() : currentActiveMontage.GetDefaultBlendInTime());
			}
		}
		float target = (bCanUseBodySeparation ? 1f : 0f);
		BodySeparationBlendAlpha = FMath.FInterpConstantTo(BodySeparationBlendAlpha, target, UAnimExecutionContextLibrary.GetDeltaTime(Context), 1f / SwitchBodySeparationBlendTime);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimHumanoidCS_AnimCurveBodySeparation:InitBodySeparationBlend")]
	private static void InitBodySeparationBlend__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAnimHumanoidCS_AnimCurveBodySeparation bUAnimHumanoidCS_AnimCurveBodySeparation = GCHelper.Find<BUAnimHumanoidCS_AnimCurveBodySeparation>(obj);
		FAnimUpdateContext Context = StructAsClassMarshaler<FAnimUpdateContext>.FromNative(IntPtr.Add(buffer, InitBodySeparationBlend_Context_Offset));
		FAnimNodeReference Node = StructAsClassMarshaler<FAnimNodeReference>.FromNative(IntPtr.Add(buffer, InitBodySeparationBlend_Node_Offset));
		bUAnimHumanoidCS_AnimCurveBodySeparation.InitBodySeparationBlend(ref Context, ref Node);
		StructAsClassMarshaler<FAnimUpdateContext>.ToNative(IntPtr.Add(buffer, InitBodySeparationBlend_Context_Offset), Context);
		StructAsClassMarshaler<FAnimNodeReference>.ToNative(IntPtr.Add(buffer, InitBodySeparationBlend_Node_Offset), Node);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimHumanoidCS_AnimCurveBodySeparation:UpdateBodySeparationBlend")]
	private static void UpdateBodySeparationBlend__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAnimHumanoidCS_AnimCurveBodySeparation bUAnimHumanoidCS_AnimCurveBodySeparation = GCHelper.Find<BUAnimHumanoidCS_AnimCurveBodySeparation>(obj);
		FAnimUpdateContext Context = StructAsClassMarshaler<FAnimUpdateContext>.FromNative(IntPtr.Add(buffer, UpdateBodySeparationBlend_Context_Offset));
		FAnimNodeReference Node = StructAsClassMarshaler<FAnimNodeReference>.FromNative(IntPtr.Add(buffer, UpdateBodySeparationBlend_Node_Offset));
		bUAnimHumanoidCS_AnimCurveBodySeparation.UpdateBodySeparationBlend(ref Context, ref Node);
		StructAsClassMarshaler<FAnimUpdateContext>.ToNative(IntPtr.Add(buffer, UpdateBodySeparationBlend_Context_Offset), Context);
		StructAsClassMarshaler<FAnimNodeReference>.ToNative(IntPtr.Add(buffer, UpdateBodySeparationBlend_Node_Offset), Node);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUAnimHumanoidCS_AnimCurveBodySeparation");
		BodyBlendWeight_Leg_Offset = NativeReflection.GetPropertyOffset(intPtr, "BodyBlendWeight_Leg");
		BodyBlendWeight_Leg_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BodyBlendWeight_Leg", Classes.FFloatProperty);
		BodyBlendWeight_Pelvis_Offset = NativeReflection.GetPropertyOffset(intPtr, "BodyBlendWeight_Pelvis");
		BodyBlendWeight_Pelvis_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BodyBlendWeight_Pelvis", Classes.FFloatProperty);
		BodyBlendWeight_Spine_Offset = NativeReflection.GetPropertyOffset(intPtr, "BodyBlendWeight_Spine");
		BodyBlendWeight_Spine_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BodyBlendWeight_Spine", Classes.FFloatProperty);
		BodyBlendWeight_Head_Offset = NativeReflection.GetPropertyOffset(intPtr, "BodyBlendWeight_Head");
		BodyBlendWeight_Head_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BodyBlendWeight_Head", Classes.FFloatProperty);
		BodyBlendWeight_ArmL_Offset = NativeReflection.GetPropertyOffset(intPtr, "BodyBlendWeight_ArmL");
		BodyBlendWeight_ArmL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BodyBlendWeight_ArmL", Classes.FFloatProperty);
		BodyBlendWeight_ArmR_Offset = NativeReflection.GetPropertyOffset(intPtr, "BodyBlendWeight_ArmR");
		BodyBlendWeight_ArmR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BodyBlendWeight_ArmR", Classes.FFloatProperty);
		BodyBlendWeight_ArmL_LocalSpace_Offset = NativeReflection.GetPropertyOffset(intPtr, "BodyBlendWeight_ArmL_LocalSpace");
		BodyBlendWeight_ArmL_LocalSpace_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BodyBlendWeight_ArmL_LocalSpace", Classes.FFloatProperty);
		BodyBlendWeight_ArmR_LocalSpace_Offset = NativeReflection.GetPropertyOffset(intPtr, "BodyBlendWeight_ArmR_LocalSpace");
		BodyBlendWeight_ArmR_LocalSpace_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BodyBlendWeight_ArmR_LocalSpace", Classes.FFloatProperty);
		BodySeparationBlendAlpha_Offset = NativeReflection.GetPropertyOffset(intPtr, "BodySeparationBlendAlpha");
		BodySeparationBlendAlpha_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BodySeparationBlendAlpha", Classes.FFloatProperty);
		InitBodySeparationBlend_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "InitBodySeparationBlend");
		InitBodySeparationBlend_ParamsSize = NativeReflection.GetFunctionParamsSize(InitBodySeparationBlend_FunctionAddress);
		NativeReflection.GetPropertyRef(ref InitBodySeparationBlend_Context_PropertyAddress, InitBodySeparationBlend_FunctionAddress, "Context");
		InitBodySeparationBlend_Context_Offset = NativeReflection.GetPropertyOffset(InitBodySeparationBlend_FunctionAddress, "Context");
		InitBodySeparationBlend_Context_IsValid = NativeReflection.ValidatePropertyClass(InitBodySeparationBlend_FunctionAddress, "Context", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref InitBodySeparationBlend_Node_PropertyAddress, InitBodySeparationBlend_FunctionAddress, "Node");
		InitBodySeparationBlend_Node_Offset = NativeReflection.GetPropertyOffset(InitBodySeparationBlend_FunctionAddress, "Node");
		InitBodySeparationBlend_Node_IsValid = NativeReflection.ValidatePropertyClass(InitBodySeparationBlend_FunctionAddress, "Node", Classes.FStructProperty);
		InitBodySeparationBlend_IsValid = InitBodySeparationBlend_FunctionAddress != IntPtr.Zero && InitBodySeparationBlend_Context_IsValid && InitBodySeparationBlend_Node_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimHumanoidCS_AnimCurveBodySeparation:InitBodySeparationBlend", InitBodySeparationBlend_IsValid);
		UpdateBodySeparationBlend_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UpdateBodySeparationBlend");
		UpdateBodySeparationBlend_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateBodySeparationBlend_FunctionAddress);
		NativeReflection.GetPropertyRef(ref UpdateBodySeparationBlend_Context_PropertyAddress, UpdateBodySeparationBlend_FunctionAddress, "Context");
		UpdateBodySeparationBlend_Context_Offset = NativeReflection.GetPropertyOffset(UpdateBodySeparationBlend_FunctionAddress, "Context");
		UpdateBodySeparationBlend_Context_IsValid = NativeReflection.ValidatePropertyClass(UpdateBodySeparationBlend_FunctionAddress, "Context", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref UpdateBodySeparationBlend_Node_PropertyAddress, UpdateBodySeparationBlend_FunctionAddress, "Node");
		UpdateBodySeparationBlend_Node_Offset = NativeReflection.GetPropertyOffset(UpdateBodySeparationBlend_FunctionAddress, "Node");
		UpdateBodySeparationBlend_Node_IsValid = NativeReflection.ValidatePropertyClass(UpdateBodySeparationBlend_FunctionAddress, "Node", Classes.FStructProperty);
		UpdateBodySeparationBlend_IsValid = UpdateBodySeparationBlend_FunctionAddress != IntPtr.Zero && UpdateBodySeparationBlend_Context_IsValid && UpdateBodySeparationBlend_Node_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimHumanoidCS_AnimCurveBodySeparation:UpdateBodySeparationBlend", UpdateBodySeparationBlend_IsValid);
	}

	static BUAnimHumanoidCS_AnimCurveBodySeparation()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUAnimHumanoidCS_AnimCurveBodySeparation)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUAnimHumanoidCS_AnimCurveBodySeparation));
	}
}
