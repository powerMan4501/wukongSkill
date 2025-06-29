using System;
using System.Text;
using b1.Plugins.Calliope;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("被杀时_监听被杀者")]
[USharpPath("/Script/b1-Managed.BED_BehaviorNode_BeKilled")]
public class BED_BehaviorNode_BeKilled : BED_BehaviorNode_ListenerTrigger
{
	private static bool UnitType_Victim_IsValid;

	private static int UnitType_Victim_Offset;

	private static FFieldAddress UnitType_Victim_PropertyAddress;

	private static bool SmartUnit_Victim_IsValid;

	private static int SmartUnit_Victim_Offset;

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
	[DisplayName("监听单位")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_BeKilled:UnitType_Victim")]
	public EDetectedUnitType UnitType_Victim
	{
		get
		{
			CheckDestroyed();
			if (!UnitType_Victim_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_BeKilled:UnitType_Victim");
				return EDetectedUnitType.Self;
			}
			return EnumMarshaler<EDetectedUnitType>.FromNative(IntPtr.Add(base.Address, UnitType_Victim_Offset), 0, UnitType_Victim_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UnitType_Victim_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_BeKilled:UnitType_Victim");
			}
			else
			{
				EnumMarshaler<EDetectedUnitType>.ToNative(IntPtr.Add(base.Address, UnitType_Victim_Offset), 0, UnitType_Victim_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("SmartUnit")]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_BeKilled:SmartUnit_Victim")]
	public FGsSmartParam SmartUnit_Victim
	{
		get
		{
			CheckDestroyed();
			if (!SmartUnit_Victim_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_BeKilled:SmartUnit_Victim");
				return default(FGsSmartParam);
			}
			return FGsSmartParam.FromNative(IntPtr.Add(base.Address, SmartUnit_Victim_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SmartUnit_Victim_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_BeKilled:SmartUnit_Victim");
			}
			else
			{
				FGsSmartParam.ToNative(IntPtr.Add(base.Address, SmartUnit_Victim_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("攻击者")]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_BeKilled:UnitType_Attacker")]
	public EDetectedUnitType UnitType_Attacker
	{
		get
		{
			CheckDestroyed();
			if (!UnitType_Attacker_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_BeKilled:UnitType_Attacker");
				return EDetectedUnitType.Self;
			}
			return EnumMarshaler<EDetectedUnitType>.FromNative(IntPtr.Add(base.Address, UnitType_Attacker_Offset), 0, UnitType_Attacker_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UnitType_Attacker_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_BeKilled:UnitType_Attacker");
			}
			else
			{
				EnumMarshaler<EDetectedUnitType>.ToNative(IntPtr.Add(base.Address, UnitType_Attacker_Offset), 0, UnitType_Attacker_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("SmartUnit_攻击者")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_BeKilled:SmartUnit_Attacker")]
	public FGsSmartParam SmartUnit_Attacker
	{
		get
		{
			CheckDestroyed();
			if (!SmartUnit_Attacker_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_BeKilled:SmartUnit_Attacker");
				return default(FGsSmartParam);
			}
			return FGsSmartParam.FromNative(IntPtr.Add(base.Address, SmartUnit_Attacker_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SmartUnit_Attacker_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_BeKilled:SmartUnit_Attacker");
			}
			else
			{
				FGsSmartParam.ToNative(IntPtr.Add(base.Address, SmartUnit_Attacker_Offset), value);
			}
		}
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.BehaviorNode.BeKilled;
	}

	public override byte[] GetCustomData()
	{
		return new BehaviorCustom_BeKilled
		{
			VictimUnitType = (int)UnitType_Victim,
			VictimSmartUnitGuid = ConvertGUID_UnitCollection(SmartUnit_Victim.ConfigGuid),
			AttackerUnitType = (int)UnitType_Attacker,
			AttackerSmartUnitGuid = ConvertGUID_UnitCollection(SmartUnit_Attacker.ConfigGuid)
		}.ToByteArray();
	}

	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_BeKilled:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		StringBuilder stringBuilder = new StringBuilder();
		switch (UnitType_Victim)
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
		stringBuilder.AppendLine("被杀死");
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

	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_BeKilled:IsSupportViewType")]
	protected override bool IsSupportViewType_Implementation(ECalliopeViewType InViewType)
	{
		if (InViewType == ECalliopeViewType.Dialogue || InViewType == ECalliopeViewType.Behavior)
		{
			return true;
		}
		return false;
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_BehaviorNode_BeKilled:IsSupportViewType")]
	private static void IsSupportViewType__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_BehaviorNode_BeKilled bED_BehaviorNode_BeKilled = GCHelper.Find<BED_BehaviorNode_BeKilled>(obj);
		ECalliopeViewType inViewType = EnumMarshaler<ECalliopeViewType>.FromNative(IntPtr.Add(buffer, IsSupportViewType_InViewType_Offset), 0, IsSupportViewType_InViewType_PropertyAddress.Address);
		bool value = bED_BehaviorNode_BeKilled.IsSupportViewType_Implementation(inViewType);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, IsSupportViewType_ReturnValue_Offset), 0, IsSupportViewType_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_BehaviorNode_BeKilled:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_BehaviorNode_BeKilled bED_BehaviorNode_BeKilled = GCHelper.Find<BED_BehaviorNode_BeKilled>(obj);
		string nodeDescriptionInCS_Implementation = bED_BehaviorNode_BeKilled.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_BehaviorNode_BeKilled");
		NativeReflection.GetPropertyRef(ref UnitType_Victim_PropertyAddress, intPtr, "UnitType_Victim");
		UnitType_Victim_Offset = NativeReflection.GetPropertyOffset(intPtr, "UnitType_Victim");
		UnitType_Victim_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UnitType_Victim", Classes.FEnumProperty);
		SmartUnit_Victim_Offset = NativeReflection.GetPropertyOffset(intPtr, "SmartUnit_Victim");
		SmartUnit_Victim_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SmartUnit_Victim", Classes.FStructProperty);
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
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_BehaviorNode_BeKilled:IsSupportViewType", IsSupportViewType_IsValid);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_BehaviorNode_BeKilled:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_BehaviorNode_BeKilled()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_BehaviorNode_BeKilled)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_BehaviorNode_BeKilled));
	}
}
