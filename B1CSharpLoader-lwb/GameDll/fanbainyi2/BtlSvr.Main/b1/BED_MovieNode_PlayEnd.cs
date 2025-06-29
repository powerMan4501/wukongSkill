using System;
using System.Text;
using b1.Plugins.Calliope;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("播放结束")]
[UClass]
[USharpPath("/Script/b1-Managed.BED_MovieNode_PlayEnd")]
internal class BED_MovieNode_PlayEnd : BED_MovieNode
{
	private static bool CameraBlendOutTime_IsValid;

	private static int CameraBlendOutTime_Offset;

	private static bool CameraBlendOutFunction_IsValid;

	private static int CameraBlendOutFunction_Offset;

	private static FFieldAddress CameraBlendOutFunction_PropertyAddress;

	private static bool CameraBlendOutFuncExp_IsValid;

	private static int CameraBlendOutFuncExp_Offset;

	private static bool BlendOutBeforeCamera_IsValid;

	private static int BlendOutBeforeCamera_Offset;

	private static FFieldAddress BlendOutBeforeCamera_PropertyAddress;

	private static bool ResetSpringArmRotationWay_IsValid;

	private static int ResetSpringArmRotationWay_Offset;

	private static FFieldAddress ResetSpringArmRotationWay_PropertyAddress;

	private static bool CustomControllerRotation_IsValid;

	private static int CustomControllerRotation_Offset;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[Category("Movie")]
	[DisplayName("淡出时间")]
	[USharpPath("/Script/b1-Managed.BED_MovieNode_PlayEnd:CameraBlendOutTime")]
	public float CameraBlendOutTime
	{
		get
		{
			CheckDestroyed();
			if (!CameraBlendOutTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_PlayEnd:CameraBlendOutTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CameraBlendOutTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CameraBlendOutTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_PlayEnd:CameraBlendOutTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CameraBlendOutTime_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[Category("Movie")]
	[DisplayName("淡出函数")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BED_MovieNode_PlayEnd:CameraBlendOutFunction")]
	public EViewTargetBlendFunction CameraBlendOutFunction
	{
		get
		{
			CheckDestroyed();
			if (!CameraBlendOutFunction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_PlayEnd:CameraBlendOutFunction");
				return EViewTargetBlendFunction.VTBlend_Linear;
			}
			return EnumMarshaler<EViewTargetBlendFunction>.FromNative(IntPtr.Add(base.Address, CameraBlendOutFunction_Offset), 0, CameraBlendOutFunction_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CameraBlendOutFunction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_PlayEnd:CameraBlendOutFunction");
			}
			else
			{
				EnumMarshaler<EViewTargetBlendFunction>.ToNative(IntPtr.Add(base.Address, CameraBlendOutFunction_Offset), 0, CameraBlendOutFunction_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("淡出系数")]
	[Category("Movie")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_MovieNode_PlayEnd:CameraBlendOutFuncExp")]
	public float CameraBlendOutFuncExp
	{
		get
		{
			CheckDestroyed();
			if (!CameraBlendOutFuncExp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_PlayEnd:CameraBlendOutFuncExp");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CameraBlendOutFuncExp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CameraBlendOutFuncExp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_PlayEnd:CameraBlendOutFuncExp");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CameraBlendOutFuncExp_Offset), value);
			}
		}
	}

	[Category("Movie")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BED_MovieNode_PlayEnd:BlendOutBeforeCamera")]
	public bool BlendOutBeforeCamera
	{
		get
		{
			CheckDestroyed();
			if (!BlendOutBeforeCamera_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_PlayEnd:BlendOutBeforeCamera");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, BlendOutBeforeCamera_Offset), 0, BlendOutBeforeCamera_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!BlendOutBeforeCamera_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_PlayEnd:BlendOutBeforeCamera");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, BlendOutBeforeCamera_Offset), 0, BlendOutBeforeCamera_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("重置镜头朝向方式")]
	[Category("Movie")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_MovieNode_PlayEnd:ResetSpringArmRotationWay")]
	public EResetSpringArmRotationWay ResetSpringArmRotationWay
	{
		get
		{
			CheckDestroyed();
			if (!ResetSpringArmRotationWay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_PlayEnd:ResetSpringArmRotationWay");
				return EResetSpringArmRotationWay.None;
			}
			return EnumMarshaler<EResetSpringArmRotationWay>.FromNative(IntPtr.Add(base.Address, ResetSpringArmRotationWay_Offset), 0, ResetSpringArmRotationWay_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ResetSpringArmRotationWay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_PlayEnd:ResetSpringArmRotationWay");
			}
			else
			{
				EnumMarshaler<EResetSpringArmRotationWay>.ToNative(IntPtr.Add(base.Address, ResetSpringArmRotationWay_Offset), 0, ResetSpringArmRotationWay_PropertyAddress.Address, value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "ResetSpringArmRotationWay == EResetSpringArmRotationWay::UseCustomRotation")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[Category("Movie")]
	[DisplayName("自定义镜头朝向")]
	[USharpPath("/Script/b1-Managed.BED_MovieNode_PlayEnd:CustomControllerRotation")]
	public FRotator CustomControllerRotation
	{
		get
		{
			CheckDestroyed();
			if (!CustomControllerRotation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_PlayEnd:CustomControllerRotation");
				return default(FRotator);
			}
			return BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(base.Address, CustomControllerRotation_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CustomControllerRotation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_PlayEnd:CustomControllerRotation");
			}
			else
			{
				BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(base.Address, CustomControllerRotation_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		base.Initialize(Initializer);
		SetNodeCategory("Route");
		SetNodeStyle(ECalliopeNodeStyle.InOut);
		base.OutputPins.Clear();
		CameraBlendOutTime = 2f;
		CameraBlendOutFunction = EViewTargetBlendFunction.VTBlend_EaseInOut;
		CameraBlendOutFuncExp = 1.5f;
		ResetSpringArmRotationWay = EResetSpringArmRotationWay.Reset2NearestRotation;
		BlendOutBeforeCamera = true;
		CustomControllerRotation = FRotator.ZeroRotator;
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.MovieNode.PlayEnd;
	}

	[USharpPath("/Script/b1-Managed.BED_MovieNode_PlayEnd:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine($"Camera : BlendOutTime：{CameraBlendOutTime} Exp: {CameraBlendOutFuncExp} \nNeedRotate: {ResetSpringArmRotationWay}");
		return stringBuilder.ToString();
	}

	public override uint GetCustomDataVersion()
	{
		return 1u;
	}

	public override byte[] GetCustomData()
	{
		return new MovieCustom_PlayEndV1
		{
			CameraBlendOutTime = CameraBlendOutTime,
			CameraBlendOutFunc = (byte)CameraBlendOutFunction,
			CameraBlendOutExp = CameraBlendOutFuncExp,
			BlendOutBeforeCamera = BlendOutBeforeCamera,
			ResetSpringArmRotationWay = (int)ResetSpringArmRotationWay,
			CustomControllerRotationPitch = CustomControllerRotation.Pitch,
			CustomControllerRotationYaw = CustomControllerRotation.Yaw,
			CustomControllerRotationRoll = CustomControllerRotation.Roll
		}.ToByteArray();
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_MovieNode_PlayEnd:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BED_MovieNode_PlayEnd bED_MovieNode_PlayEnd = GCHelper.Find<b1.BED_MovieNode_PlayEnd>(obj);
		string nodeDescriptionInCS_Implementation = bED_MovieNode_PlayEnd.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_MovieNode_PlayEnd");
		CameraBlendOutTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "CameraBlendOutTime");
		CameraBlendOutTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CameraBlendOutTime", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref CameraBlendOutFunction_PropertyAddress, intPtr, "CameraBlendOutFunction");
		CameraBlendOutFunction_Offset = NativeReflection.GetPropertyOffset(intPtr, "CameraBlendOutFunction");
		CameraBlendOutFunction_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CameraBlendOutFunction", Classes.FEnumProperty);
		CameraBlendOutFuncExp_Offset = NativeReflection.GetPropertyOffset(intPtr, "CameraBlendOutFuncExp");
		CameraBlendOutFuncExp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CameraBlendOutFuncExp", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref BlendOutBeforeCamera_PropertyAddress, intPtr, "BlendOutBeforeCamera");
		BlendOutBeforeCamera_Offset = NativeReflection.GetPropertyOffset(intPtr, "BlendOutBeforeCamera");
		BlendOutBeforeCamera_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BlendOutBeforeCamera", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref ResetSpringArmRotationWay_PropertyAddress, intPtr, "ResetSpringArmRotationWay");
		ResetSpringArmRotationWay_Offset = NativeReflection.GetPropertyOffset(intPtr, "ResetSpringArmRotationWay");
		ResetSpringArmRotationWay_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ResetSpringArmRotationWay", Classes.FEnumProperty);
		CustomControllerRotation_Offset = NativeReflection.GetPropertyOffset(intPtr, "CustomControllerRotation");
		CustomControllerRotation_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CustomControllerRotation", Classes.FStructProperty);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_MovieNode_PlayEnd:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_MovieNode_PlayEnd()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BED_MovieNode_PlayEnd)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BED_MovieNode_PlayEnd));
	}
}
