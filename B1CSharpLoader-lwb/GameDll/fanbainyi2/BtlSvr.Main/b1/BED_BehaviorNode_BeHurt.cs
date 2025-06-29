using System;
using System.Text;
using b1.Plugins.Calliope;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("受伤时")]
[USharpPath("/Script/b1-Managed.BED_BehaviorNode_BeHurt")]
public class BED_BehaviorNode_BeHurt : BED_BehaviorNode_ListenerTrigger
{
	private static bool UnitType_IsValid;

	private static int UnitType_Offset;

	private static FFieldAddress UnitType_PropertyAddress;

	private static bool SmartUnit_IsValid;

	private static int SmartUnit_Offset;

	private static bool CompareOperationType_IsValid;

	private static int CompareOperationType_Offset;

	private static FFieldAddress CompareOperationType_PropertyAddress;

	private static bool DmgValue_IsValid;

	private static int DmgValue_Offset;

	private static bool UnitType_Attacker_IsValid;

	private static int UnitType_Attacker_Offset;

	private static FFieldAddress UnitType_Attacker_PropertyAddress;

	private static bool SmartUnit_Attacker_IsValid;

	private static int SmartUnit_Attacker_Offset;

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

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("监听单位")]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_BeHurt:UnitType")]
	public EDetectedUnitType UnitType
	{
		get
		{
			CheckDestroyed();
			if (!UnitType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_BeHurt:UnitType");
				return EDetectedUnitType.Self;
			}
			return EnumMarshaler<EDetectedUnitType>.FromNative(IntPtr.Add(base.Address, UnitType_Offset), 0, UnitType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UnitType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_BeHurt:UnitType");
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
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_BeHurt:SmartUnit")]
	public FGsSmartParam SmartUnit
	{
		get
		{
			CheckDestroyed();
			if (!SmartUnit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_BeHurt:SmartUnit");
				return default(FGsSmartParam);
			}
			return FGsSmartParam.FromNative(IntPtr.Add(base.Address, SmartUnit_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SmartUnit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_BeHurt:SmartUnit");
			}
			else
			{
				FGsSmartParam.ToNative(IntPtr.Add(base.Address, SmartUnit_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("比较值类型")]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_BeHurt:CompareOperationType")]
	public EValueCompareOperationType CompareOperationType
	{
		get
		{
			CheckDestroyed();
			if (!CompareOperationType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_BeHurt:CompareOperationType");
				return EValueCompareOperationType.EqualTo;
			}
			return EnumMarshaler<EValueCompareOperationType>.FromNative(IntPtr.Add(base.Address, CompareOperationType_Offset), 0, CompareOperationType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CompareOperationType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_BeHurt:CompareOperationType");
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
	[DisplayName("伤害值")]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_BeHurt:DmgValue")]
	public int DmgValue
	{
		get
		{
			CheckDestroyed();
			if (!DmgValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_BeHurt:DmgValue");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, DmgValue_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DmgValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_BeHurt:DmgValue");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, DmgValue_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("攻击者")]
	[EditAnywhere]
	[Tooltip("填空则不需要判断Attacker")]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_BeHurt:UnitType_Attacker")]
	public EDetectedUnitType UnitType_Attacker
	{
		get
		{
			CheckDestroyed();
			if (!UnitType_Attacker_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_BeHurt:UnitType_Attacker");
				return EDetectedUnitType.Self;
			}
			return EnumMarshaler<EDetectedUnitType>.FromNative(IntPtr.Add(base.Address, UnitType_Attacker_Offset), 0, UnitType_Attacker_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UnitType_Attacker_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_BeHurt:UnitType_Attacker");
			}
			else
			{
				EnumMarshaler<EDetectedUnitType>.ToNative(IntPtr.Add(base.Address, UnitType_Attacker_Offset), 0, UnitType_Attacker_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("SmartUnit_攻击者")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_BeHurt:SmartUnit_Attacker")]
	public FGsSmartParam SmartUnit_Attacker
	{
		get
		{
			CheckDestroyed();
			if (!SmartUnit_Attacker_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_BeHurt:SmartUnit_Attacker");
				return default(FGsSmartParam);
			}
			return FGsSmartParam.FromNative(IntPtr.Add(base.Address, SmartUnit_Attacker_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SmartUnit_Attacker_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_BeHurt:SmartUnit_Attacker");
			}
			else
			{
				FGsSmartParam.ToNative(IntPtr.Add(base.Address, SmartUnit_Attacker_Offset), value);
			}
		}
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.BehaviorNode.BeHurt;
	}

	public override byte[] GetCustomData()
	{
		return new BehaviorCustom_BeHurt
		{
			VictimUnitType = (int)UnitType,
			VictimSmartUnitGuid = ConvertGUID_UnitCollection(SmartUnit.ConfigGuid),
			CompareOperation = (int)CompareOperationType,
			DmgValue = DmgValue,
			AttackerUnitType = (int)UnitType_Attacker,
			AttackerSmartUnitGuid = ConvertGUID_UnitCollection(SmartUnit_Attacker.ConfigGuid)
		}.ToByteArray();
	}

	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_BeHurt:GetNodeDescriptionInCS")]
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
		stringBuilder.AppendLine($"受到的伤害值:{CompareOperationType.ToString()} {DmgValue}");
		switch (UnitType_Attacker)
		{
		case EDetectedUnitType.Self:
			stringBuilder.AppendLine("攻击者是自身");
			break;
		case EDetectedUnitType.Target:
			stringBuilder.AppendLine("攻击者是目标");
			break;
		case EDetectedUnitType.Master:
			stringBuilder.AppendLine("攻击者是Master");
			break;
		case EDetectedUnitType.Player:
			stringBuilder.AppendLine("攻击者是主角");
			break;
		case EDetectedUnitType.UseSmartUnit:
			stringBuilder.AppendLine("攻击者是SmartUnit");
			break;
		}
		return stringBuilder.ToString();
	}

	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_BeHurt:IsSupportViewType")]
	protected override bool IsSupportViewType_Implementation(ECalliopeViewType InViewType)
	{
		if (InViewType == ECalliopeViewType.Dialogue || InViewType == ECalliopeViewType.Behavior)
		{
			return true;
		}
		return false;
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_BehaviorNode_BeHurt:IsSupportViewType")]
	private static void IsSupportViewType__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_BehaviorNode_BeHurt bED_BehaviorNode_BeHurt = GCHelper.Find<BED_BehaviorNode_BeHurt>(obj);
		ECalliopeViewType inViewType = EnumMarshaler<ECalliopeViewType>.FromNative(IntPtr.Add(buffer, IsSupportViewType_InViewType_Offset), 0, IsSupportViewType_InViewType_PropertyAddress.Address);
		bool value = bED_BehaviorNode_BeHurt.IsSupportViewType_Implementation(inViewType);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, IsSupportViewType_ReturnValue_Offset), 0, IsSupportViewType_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_BehaviorNode_BeHurt:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_BehaviorNode_BeHurt bED_BehaviorNode_BeHurt = GCHelper.Find<BED_BehaviorNode_BeHurt>(obj);
		string nodeDescriptionInCS_Implementation = bED_BehaviorNode_BeHurt.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_BehaviorNode_BeHurt");
		NativeReflection.GetPropertyRef(ref UnitType_PropertyAddress, intPtr, "UnitType");
		UnitType_Offset = NativeReflection.GetPropertyOffset(intPtr, "UnitType");
		UnitType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UnitType", Classes.FEnumProperty);
		SmartUnit_Offset = NativeReflection.GetPropertyOffset(intPtr, "SmartUnit");
		SmartUnit_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SmartUnit", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref CompareOperationType_PropertyAddress, intPtr, "CompareOperationType");
		CompareOperationType_Offset = NativeReflection.GetPropertyOffset(intPtr, "CompareOperationType");
		CompareOperationType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CompareOperationType", Classes.FEnumProperty);
		DmgValue_Offset = NativeReflection.GetPropertyOffset(intPtr, "DmgValue");
		DmgValue_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DmgValue", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref UnitType_Attacker_PropertyAddress, intPtr, "UnitType_Attacker");
		UnitType_Attacker_Offset = NativeReflection.GetPropertyOffset(intPtr, "UnitType_Attacker");
		UnitType_Attacker_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UnitType_Attacker", Classes.FEnumProperty);
		SmartUnit_Attacker_Offset = NativeReflection.GetPropertyOffset(intPtr, "SmartUnit_Attacker");
		SmartUnit_Attacker_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SmartUnit_Attacker", Classes.FStructProperty);
		IsSupportViewType_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsSupportViewType");
		IsSupportViewType_ParamsSize = NativeReflection.GetFunctionParamsSize(IsSupportViewType_FunctionAddress);
		NativeReflection.GetPropertyRef(ref IsSupportViewType_InViewType_PropertyAddress, IsSupportViewType_FunctionAddress, "InViewType");
		IsSupportViewType_InViewType_Offset = NativeReflection.GetPropertyOffset(IsSupportViewType_FunctionAddress, "InViewType");
		IsSupportViewType_InViewType_IsValid = NativeReflection.ValidatePropertyClass(IsSupportViewType_FunctionAddress, "InViewType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref IsSupportViewType_ReturnValue_PropertyAddress, IsSupportViewType_FunctionAddress, "ReturnValue");
		IsSupportViewType_ReturnValue_Offset = NativeReflection.GetPropertyOffset(IsSupportViewType_FunctionAddress, "ReturnValue");
		IsSupportViewType_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(IsSupportViewType_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsSupportViewType_IsValid = IsSupportViewType_FunctionAddress != IntPtr.Zero && IsSupportViewType_InViewType_IsValid && IsSupportViewType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_BehaviorNode_BeHurt:IsSupportViewType", IsSupportViewType_IsValid);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_BehaviorNode_BeHurt:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_BehaviorNode_BeHurt()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_BehaviorNode_BeHurt)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_BehaviorNode_BeHurt));
	}
}
