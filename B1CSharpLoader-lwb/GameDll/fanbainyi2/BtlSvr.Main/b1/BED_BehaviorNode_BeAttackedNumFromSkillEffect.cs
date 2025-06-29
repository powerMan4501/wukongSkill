using System;
using System.Text;
using b1.Plugins.Calliope;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("被某SkillEffect命中数次")]
[UClass]
[USharpPath("/Script/b1-Managed.BED_BehaviorNode_BeAttackedNumFromSkillEffect")]
public class BED_BehaviorNode_BeAttackedNumFromSkillEffect : BED_BehaviorNode_ListenerTrigger
{
	private static bool UnitType_IsValid;

	private static int UnitType_Offset;

	private static FFieldAddress UnitType_PropertyAddress;

	private static bool SmartUnit_IsValid;

	private static int SmartUnit_Offset;

	private static bool SkillEffectID_IsValid;

	private static int SkillEffectID_Offset;

	private static bool CompareOperationType_IsValid;

	private static int CompareOperationType_Offset;

	private static FFieldAddress CompareOperationType_PropertyAddress;

	private static bool BeHittedNum_IsValid;

	private static int BeHittedNum_Offset;

	private static bool TimeDuration_IsValid;

	private static int TimeDuration_Offset;

	private static bool IsSupportViewType_IsValid;

	private static IntPtr IsSupportViewType_FunctionAddress;

	private static int IsSupportViewType_ParamsSize;

	private static bool IsSupportViewType_InViewType_IsValid;

	private static int IsSupportViewType_InViewType_Offset;

	private static FFieldAddress IsSupportViewType_InViewType_PropertyAddress;

	private static bool IsSupportViewType_ReturnValue_IsValid;

	private static int IsSupportViewType_ReturnValue_Offset;

	private static FFieldAddress IsSupportViewType_ReturnValue_PropertyAddress;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("监听单位")]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_BeAttackedNumFromSkillEffect:UnitType")]
	public EDetectedUnitType UnitType
	{
		get
		{
			CheckDestroyed();
			if (!UnitType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_BeAttackedNumFromSkillEffect:UnitType");
				return EDetectedUnitType.Self;
			}
			return EnumMarshaler<EDetectedUnitType>.FromNative(IntPtr.Add(base.Address, UnitType_Offset), 0, UnitType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UnitType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_BeAttackedNumFromSkillEffect:UnitType");
			}
			else
			{
				EnumMarshaler<EDetectedUnitType>.ToNative(IntPtr.Add(base.Address, UnitType_Offset), 0, UnitType_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[DisplayName("SmartUnit")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_BeAttackedNumFromSkillEffect:SmartUnit")]
	public FGsSmartParam SmartUnit
	{
		get
		{
			CheckDestroyed();
			if (!SmartUnit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_BeAttackedNumFromSkillEffect:SmartUnit");
				return default(FGsSmartParam);
			}
			return FGsSmartParam.FromNative(IntPtr.Add(base.Address, SmartUnit_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SmartUnit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_BeAttackedNumFromSkillEffect:SmartUnit");
			}
			else
			{
				FGsSmartParam.ToNative(IntPtr.Add(base.Address, SmartUnit_Offset), value);
			}
		}
	}

	[DisplayName("受击来源SkillEffetID")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_BeAttackedNumFromSkillEffect:SkillEffectID")]
	public int SkillEffectID
	{
		get
		{
			CheckDestroyed();
			if (!SkillEffectID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_BeAttackedNumFromSkillEffect:SkillEffectID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, SkillEffectID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SkillEffectID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_BeAttackedNumFromSkillEffect:SkillEffectID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, SkillEffectID_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("比较值类型")]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_BeAttackedNumFromSkillEffect:CompareOperationType")]
	public EValueCompareOperationType CompareOperationType
	{
		get
		{
			CheckDestroyed();
			if (!CompareOperationType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_BeAttackedNumFromSkillEffect:CompareOperationType");
				return EValueCompareOperationType.EqualTo;
			}
			return EnumMarshaler<EValueCompareOperationType>.FromNative(IntPtr.Add(base.Address, CompareOperationType_Offset), 0, CompareOperationType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CompareOperationType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_BeAttackedNumFromSkillEffect:CompareOperationType");
			}
			else
			{
				EnumMarshaler<EValueCompareOperationType>.ToNative(IntPtr.Add(base.Address, CompareOperationType_Offset), 0, CompareOperationType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("受击次数")]
	[Tooltip("只有触发了硬直才会进入计数")]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_BeAttackedNumFromSkillEffect:BeHittedNum")]
	public int BeHittedNum
	{
		get
		{
			CheckDestroyed();
			if (!BeHittedNum_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_BeAttackedNumFromSkillEffect:BeHittedNum");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, BeHittedNum_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BeHittedNum_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_BeAttackedNumFromSkillEffect:BeHittedNum");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, BeHittedNum_Offset), value);
			}
		}
	}

	[UProperty]
	[DisplayName("受击计时区间")]
	[Tooltip("多少秒内受击次数达标")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_BeAttackedNumFromSkillEffect:TimeDuration")]
	public float TimeDuration
	{
		get
		{
			CheckDestroyed();
			if (!TimeDuration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_BeAttackedNumFromSkillEffect:TimeDuration");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, TimeDuration_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TimeDuration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_BeAttackedNumFromSkillEffect:TimeDuration");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, TimeDuration_Offset), value);
			}
		}
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.BehaviorNode.BeAttackedNumFromSkillEffect;
	}

	public override byte[] GetCustomData()
	{
		return new BehaviorCustom_BeAttackedNumFromSkillEffect
		{
			UnitType = (int)UnitType,
			SmartUnitGuid = ConvertGUID_UnitCollection(SmartUnit.ConfigGuid),
			SkillEffectId = SkillEffectID,
			CompareOperation = (int)CompareOperationType,
			BeHittedNum = BeHittedNum,
			TimeDuration = TimeDuration
		}.ToByteArray();
	}

	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_BeAttackedNumFromSkillEffect:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		StringBuilder stringBuilder = new StringBuilder();
		switch (UnitType)
		{
		case EDetectedUnitType.Self:
			stringBuilder.AppendLine("检测自身");
			break;
		case EDetectedUnitType.Target:
			stringBuilder.AppendLine("检测目标");
			break;
		case EDetectedUnitType.Master:
			stringBuilder.AppendLine("检测Master");
			break;
		case EDetectedUnitType.Player:
			stringBuilder.AppendLine("检测主角");
			break;
		case EDetectedUnitType.UseSmartUnit:
			stringBuilder.AppendLine("检测SmartUnit");
			break;
		}
		if (TimeDuration > 0f)
		{
			stringBuilder.AppendLine(TimeDuration + " 秒内");
		}
		stringBuilder.AppendLine("被 SkillEffectID:" + SkillEffectID + " 命中次数");
		stringBuilder.AppendLine($"{CompareOperationType.ToString()} {BeHittedNum} 次");
		return stringBuilder.ToString();
	}

	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_BeAttackedNumFromSkillEffect:IsSupportViewType")]
	protected override bool IsSupportViewType_Implementation(ECalliopeViewType InViewType)
	{
		if (InViewType == ECalliopeViewType.Dialogue || InViewType == ECalliopeViewType.Behavior)
		{
			return true;
		}
		return false;
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_BehaviorNode_BeAttackedNumFromSkillEffect:IsSupportViewType")]
	private static void IsSupportViewType__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_BehaviorNode_BeAttackedNumFromSkillEffect bED_BehaviorNode_BeAttackedNumFromSkillEffect = GCHelper.Find<BED_BehaviorNode_BeAttackedNumFromSkillEffect>(obj);
		ECalliopeViewType inViewType = EnumMarshaler<ECalliopeViewType>.FromNative(IntPtr.Add(buffer, IsSupportViewType_InViewType_Offset), 0, IsSupportViewType_InViewType_PropertyAddress.Address);
		bool value = bED_BehaviorNode_BeAttackedNumFromSkillEffect.IsSupportViewType_Implementation(inViewType);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, IsSupportViewType_ReturnValue_Offset), 0, IsSupportViewType_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_BehaviorNode_BeAttackedNumFromSkillEffect:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_BehaviorNode_BeAttackedNumFromSkillEffect bED_BehaviorNode_BeAttackedNumFromSkillEffect = GCHelper.Find<BED_BehaviorNode_BeAttackedNumFromSkillEffect>(obj);
		string nodeDescriptionInCS_Implementation = bED_BehaviorNode_BeAttackedNumFromSkillEffect.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_BehaviorNode_BeAttackedNumFromSkillEffect");
		NativeReflection.GetPropertyRef(ref UnitType_PropertyAddress, intPtr, "UnitType");
		UnitType_Offset = NativeReflection.GetPropertyOffset(intPtr, "UnitType");
		UnitType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UnitType", Classes.FEnumProperty);
		SmartUnit_Offset = NativeReflection.GetPropertyOffset(intPtr, "SmartUnit");
		SmartUnit_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SmartUnit", Classes.FStructProperty);
		SkillEffectID_Offset = NativeReflection.GetPropertyOffset(intPtr, "SkillEffectID");
		SkillEffectID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SkillEffectID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref CompareOperationType_PropertyAddress, intPtr, "CompareOperationType");
		CompareOperationType_Offset = NativeReflection.GetPropertyOffset(intPtr, "CompareOperationType");
		CompareOperationType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CompareOperationType", Classes.FEnumProperty);
		BeHittedNum_Offset = NativeReflection.GetPropertyOffset(intPtr, "BeHittedNum");
		BeHittedNum_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BeHittedNum", Classes.FIntProperty);
		TimeDuration_Offset = NativeReflection.GetPropertyOffset(intPtr, "TimeDuration");
		TimeDuration_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TimeDuration", Classes.FFloatProperty);
		IsSupportViewType_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsSupportViewType");
		IsSupportViewType_ParamsSize = NativeReflection.GetFunctionParamsSize(IsSupportViewType_FunctionAddress);
		NativeReflection.GetPropertyRef(ref IsSupportViewType_InViewType_PropertyAddress, IsSupportViewType_FunctionAddress, "InViewType");
		IsSupportViewType_InViewType_Offset = NativeReflection.GetPropertyOffset(IsSupportViewType_FunctionAddress, "InViewType");
		IsSupportViewType_InViewType_IsValid = NativeReflection.ValidatePropertyClass(IsSupportViewType_FunctionAddress, "InViewType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref IsSupportViewType_ReturnValue_PropertyAddress, IsSupportViewType_FunctionAddress, "ReturnValue");
		IsSupportViewType_ReturnValue_Offset = NativeReflection.GetPropertyOffset(IsSupportViewType_FunctionAddress, "ReturnValue");
		IsSupportViewType_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(IsSupportViewType_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsSupportViewType_IsValid = IsSupportViewType_FunctionAddress != IntPtr.Zero && IsSupportViewType_InViewType_IsValid && IsSupportViewType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_BehaviorNode_BeAttackedNumFromSkillEffect:IsSupportViewType", IsSupportViewType_IsValid);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_BehaviorNode_BeAttackedNumFromSkillEffect:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_BehaviorNode_BeAttackedNumFromSkillEffect()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_BehaviorNode_BeAttackedNumFromSkillEffect)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_BehaviorNode_BeAttackedNumFromSkillEffect));
	}
}
