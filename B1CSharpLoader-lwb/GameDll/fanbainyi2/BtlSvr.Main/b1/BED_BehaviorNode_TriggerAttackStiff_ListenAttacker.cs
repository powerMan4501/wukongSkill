using System;
using System.Text;
using b1.Plugins.Calliope;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("造成硬直时")]
[USharpPath("/Script/b1-Managed.BED_BehaviorNode_TriggerAttackStiff_ListenAttacker")]
public class BED_BehaviorNode_TriggerAttackStiff_ListenAttacker : BED_BehaviorNode_ListenerTrigger
{
	private static bool UnitType_IsValid;

	private static int UnitType_Offset;

	private static FFieldAddress UnitType_PropertyAddress;

	private static bool SmartUnit_IsValid;

	private static int SmartUnit_Offset;

	private static bool CompareOperationType_IsValid;

	private static int CompareOperationType_Offset;

	private static FFieldAddress CompareOperationType_PropertyAddress;

	private static bool StiffLevel_IsValid;

	private static int StiffLevel_Offset;

	private static bool UnitType_Victim_IsValid;

	private static int UnitType_Victim_Offset;

	private static FFieldAddress UnitType_Victim_PropertyAddress;

	private static bool SmartUnit_Victim_IsValid;

	private static int SmartUnit_Victim_Offset;

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
	[DisplayName("监听单位")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_TriggerAttackStiff_ListenAttacker:UnitType")]
	public EDetectedUnitType UnitType
	{
		get
		{
			CheckDestroyed();
			if (!UnitType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_TriggerAttackStiff_ListenAttacker:UnitType");
				return EDetectedUnitType.Self;
			}
			return EnumMarshaler<EDetectedUnitType>.FromNative(IntPtr.Add(base.Address, UnitType_Offset), 0, UnitType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UnitType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_TriggerAttackStiff_ListenAttacker:UnitType");
			}
			else
			{
				EnumMarshaler<EDetectedUnitType>.ToNative(IntPtr.Add(base.Address, UnitType_Offset), 0, UnitType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("SmartUnit")]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_TriggerAttackStiff_ListenAttacker:SmartUnit")]
	public FGsSmartParam SmartUnit
	{
		get
		{
			CheckDestroyed();
			if (!SmartUnit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_TriggerAttackStiff_ListenAttacker:SmartUnit");
				return default(FGsSmartParam);
			}
			return FGsSmartParam.FromNative(IntPtr.Add(base.Address, SmartUnit_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SmartUnit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_TriggerAttackStiff_ListenAttacker:SmartUnit");
			}
			else
			{
				FGsSmartParam.ToNative(IntPtr.Add(base.Address, SmartUnit_Offset), value);
			}
		}
	}

	[DisplayName("比较值类型")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_TriggerAttackStiff_ListenAttacker:CompareOperationType")]
	public EValueCompareOperationType CompareOperationType
	{
		get
		{
			CheckDestroyed();
			if (!CompareOperationType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_TriggerAttackStiff_ListenAttacker:CompareOperationType");
				return EValueCompareOperationType.EqualTo;
			}
			return EnumMarshaler<EValueCompareOperationType>.FromNative(IntPtr.Add(base.Address, CompareOperationType_Offset), 0, CompareOperationType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CompareOperationType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_TriggerAttackStiff_ListenAttacker:CompareOperationType");
			}
			else
			{
				EnumMarshaler<EValueCompareOperationType>.ToNative(IntPtr.Add(base.Address, CompareOperationType_Offset), 0, CompareOperationType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("StiffLevel")]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_TriggerAttackStiff_ListenAttacker:StiffLevel")]
	public int StiffLevel
	{
		get
		{
			CheckDestroyed();
			if (!StiffLevel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_TriggerAttackStiff_ListenAttacker:StiffLevel");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, StiffLevel_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StiffLevel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_TriggerAttackStiff_ListenAttacker:StiffLevel");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, StiffLevel_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[DisplayName("受击者")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_TriggerAttackStiff_ListenAttacker:UnitType_Victim")]
	public EDetectedUnitType UnitType_Victim
	{
		get
		{
			CheckDestroyed();
			if (!UnitType_Victim_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_TriggerAttackStiff_ListenAttacker:UnitType_Victim");
				return EDetectedUnitType.Self;
			}
			return EnumMarshaler<EDetectedUnitType>.FromNative(IntPtr.Add(base.Address, UnitType_Victim_Offset), 0, UnitType_Victim_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UnitType_Victim_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_TriggerAttackStiff_ListenAttacker:UnitType_Victim");
			}
			else
			{
				EnumMarshaler<EDetectedUnitType>.ToNative(IntPtr.Add(base.Address, UnitType_Victim_Offset), 0, UnitType_Victim_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("SmartUnit_受击者")]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_TriggerAttackStiff_ListenAttacker:SmartUnit_Victim")]
	public FGsSmartParam SmartUnit_Victim
	{
		get
		{
			CheckDestroyed();
			if (!SmartUnit_Victim_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_TriggerAttackStiff_ListenAttacker:SmartUnit_Victim");
				return default(FGsSmartParam);
			}
			return FGsSmartParam.FromNative(IntPtr.Add(base.Address, SmartUnit_Victim_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SmartUnit_Victim_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_TriggerAttackStiff_ListenAttacker:SmartUnit_Victim");
			}
			else
			{
				FGsSmartParam.ToNative(IntPtr.Add(base.Address, SmartUnit_Victim_Offset), value);
			}
		}
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.BehaviorNode.TriggerAttackStiff_ListenAttacker;
	}

	public override byte[] GetCustomData()
	{
		return new BehaviorCustom_TriggerAttackStiff_ListenAttacker
		{
			AttackerUnitType = (int)UnitType,
			AttackerSmartUnitGuid = ConvertGUID_UnitCollection(SmartUnit.ConfigGuid),
			CompareOperation = (int)CompareOperationType,
			StiffLevel = StiffLevel,
			VictimUnitType = (int)UnitType_Victim,
			VictimSmartUnitGuid = ConvertGUID_UnitCollection(SmartUnit_Victim.ConfigGuid)
		}.ToByteArray();
	}

	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_TriggerAttackStiff_ListenAttacker:GetNodeDescriptionInCS")]
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
		stringBuilder.AppendLine($"StiffLevel:{CompareOperationType.ToString()} {StiffLevel}");
		switch (UnitType_Victim)
		{
		case EDetectedUnitType.Self:
			stringBuilder.AppendLine("受击者是自身");
			break;
		case EDetectedUnitType.Target:
			stringBuilder.AppendLine("受击者是目标");
			break;
		case EDetectedUnitType.Master:
			stringBuilder.AppendLine("受击者是Master");
			break;
		case EDetectedUnitType.Player:
			stringBuilder.AppendLine("受击者是主角");
			break;
		case EDetectedUnitType.UseSmartUnit:
			stringBuilder.AppendLine("受击者是SmartUnit");
			break;
		}
		return stringBuilder.ToString();
	}

	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_TriggerAttackStiff_ListenAttacker:IsSupportViewType")]
	protected override bool IsSupportViewType_Implementation(ECalliopeViewType InViewType)
	{
		if (InViewType == ECalliopeViewType.Dialogue || InViewType == ECalliopeViewType.Behavior)
		{
			return true;
		}
		return false;
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_BehaviorNode_TriggerAttackStiff_ListenAttacker:IsSupportViewType")]
	private static void IsSupportViewType__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_BehaviorNode_TriggerAttackStiff_ListenAttacker bED_BehaviorNode_TriggerAttackStiff_ListenAttacker = GCHelper.Find<BED_BehaviorNode_TriggerAttackStiff_ListenAttacker>(obj);
		ECalliopeViewType inViewType = EnumMarshaler<ECalliopeViewType>.FromNative(IntPtr.Add(buffer, IsSupportViewType_InViewType_Offset), 0, IsSupportViewType_InViewType_PropertyAddress.Address);
		bool value = bED_BehaviorNode_TriggerAttackStiff_ListenAttacker.IsSupportViewType_Implementation(inViewType);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, IsSupportViewType_ReturnValue_Offset), 0, IsSupportViewType_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_BehaviorNode_TriggerAttackStiff_ListenAttacker:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_BehaviorNode_TriggerAttackStiff_ListenAttacker bED_BehaviorNode_TriggerAttackStiff_ListenAttacker = GCHelper.Find<BED_BehaviorNode_TriggerAttackStiff_ListenAttacker>(obj);
		string nodeDescriptionInCS_Implementation = bED_BehaviorNode_TriggerAttackStiff_ListenAttacker.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_BehaviorNode_TriggerAttackStiff_ListenAttacker");
		NativeReflection.GetPropertyRef(ref UnitType_PropertyAddress, intPtr, "UnitType");
		UnitType_Offset = NativeReflection.GetPropertyOffset(intPtr, "UnitType");
		UnitType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UnitType", Classes.FEnumProperty);
		SmartUnit_Offset = NativeReflection.GetPropertyOffset(intPtr, "SmartUnit");
		SmartUnit_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SmartUnit", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref CompareOperationType_PropertyAddress, intPtr, "CompareOperationType");
		CompareOperationType_Offset = NativeReflection.GetPropertyOffset(intPtr, "CompareOperationType");
		CompareOperationType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CompareOperationType", Classes.FEnumProperty);
		StiffLevel_Offset = NativeReflection.GetPropertyOffset(intPtr, "StiffLevel");
		StiffLevel_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "StiffLevel", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref UnitType_Victim_PropertyAddress, intPtr, "UnitType_Victim");
		UnitType_Victim_Offset = NativeReflection.GetPropertyOffset(intPtr, "UnitType_Victim");
		UnitType_Victim_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UnitType_Victim", Classes.FEnumProperty);
		SmartUnit_Victim_Offset = NativeReflection.GetPropertyOffset(intPtr, "SmartUnit_Victim");
		SmartUnit_Victim_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SmartUnit_Victim", Classes.FStructProperty);
		IsSupportViewType_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsSupportViewType");
		IsSupportViewType_ParamsSize = NativeReflection.GetFunctionParamsSize(IsSupportViewType_FunctionAddress);
		NativeReflection.GetPropertyRef(ref IsSupportViewType_InViewType_PropertyAddress, IsSupportViewType_FunctionAddress, "InViewType");
		IsSupportViewType_InViewType_Offset = NativeReflection.GetPropertyOffset(IsSupportViewType_FunctionAddress, "InViewType");
		IsSupportViewType_InViewType_IsValid = NativeReflection.ValidatePropertyClass(IsSupportViewType_FunctionAddress, "InViewType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref IsSupportViewType_ReturnValue_PropertyAddress, IsSupportViewType_FunctionAddress, "ReturnValue");
		IsSupportViewType_ReturnValue_Offset = NativeReflection.GetPropertyOffset(IsSupportViewType_FunctionAddress, "ReturnValue");
		IsSupportViewType_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(IsSupportViewType_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsSupportViewType_IsValid = IsSupportViewType_FunctionAddress != IntPtr.Zero && IsSupportViewType_InViewType_IsValid && IsSupportViewType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_BehaviorNode_TriggerAttackStiff_ListenAttacker:IsSupportViewType", IsSupportViewType_IsValid);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_BehaviorNode_TriggerAttackStiff_ListenAttacker:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_BehaviorNode_TriggerAttackStiff_ListenAttacker()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_BehaviorNode_TriggerAttackStiff_ListenAttacker)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_BehaviorNode_TriggerAttackStiff_ListenAttacker));
	}
}
