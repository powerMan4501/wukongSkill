using System;
using System.Text;
using b1.Plugins.Calliope;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("当单位变身时")]
[USharpPath("/Script/b1-Managed.BED_BehaviorNode_OnUnitTrans")]
public class BED_BehaviorNode_OnUnitTrans : BED_BehaviorNode_ListenerTrigger
{
	private static bool UnitType_IsValid;

	private static int UnitType_Offset;

	private static FFieldAddress UnitType_PropertyAddress;

	private static bool SmartUnit_IsValid;

	private static int SmartUnit_Offset;

	private static bool TransType_IsValid;

	private static int TransType_Offset;

	private static FFieldAddress TransType_PropertyAddress;

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

	[DisplayName("监听单位")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_OnUnitTrans:UnitType")]
	public EDetectedUnitType UnitType
	{
		get
		{
			CheckDestroyed();
			if (!UnitType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_OnUnitTrans:UnitType");
				return EDetectedUnitType.Self;
			}
			return EnumMarshaler<EDetectedUnitType>.FromNative(IntPtr.Add(base.Address, UnitType_Offset), 0, UnitType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UnitType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_OnUnitTrans:UnitType");
			}
			else
			{
				EnumMarshaler<EDetectedUnitType>.ToNative(IntPtr.Add(base.Address, UnitType_Offset), 0, UnitType_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("SmartUnit")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_OnUnitTrans:SmartUnit")]
	public FGsSmartParam SmartUnit
	{
		get
		{
			CheckDestroyed();
			if (!SmartUnit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_OnUnitTrans:SmartUnit");
				return default(FGsSmartParam);
			}
			return FGsSmartParam.FromNative(IntPtr.Add(base.Address, SmartUnit_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SmartUnit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_OnUnitTrans:SmartUnit");
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
	[DisplayName("变身类型")]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_OnUnitTrans:TransType")]
	public EPlayerTransEndType TransType
	{
		get
		{
			CheckDestroyed();
			if (!TransType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_OnUnitTrans:TransType");
				return EPlayerTransEndType.None;
			}
			return EnumMarshaler<EPlayerTransEndType>.FromNative(IntPtr.Add(base.Address, TransType_Offset), 0, TransType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!TransType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_OnUnitTrans:TransType");
			}
			else
			{
				EnumMarshaler<EPlayerTransEndType>.ToNative(IntPtr.Add(base.Address, TransType_Offset), 0, TransType_PropertyAddress.Address, value);
			}
		}
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.BehaviorNode.OnUnitTrans;
	}

	public override byte[] GetCustomData()
	{
		return new BehaviorCustom_OnUnitTrans
		{
			UnitType = (int)UnitType,
			SmartUnitGuid = ConvertGUID_UnitCollection(SmartUnit.ConfigGuid),
			TransType = (int)TransType
		}.ToByteArray();
	}

	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_OnUnitTrans:GetNodeDescriptionInCS")]
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
		stringBuilder.AppendLine("变身类型: " + TransType);
		return stringBuilder.ToString();
	}

	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_OnUnitTrans:IsSupportViewType")]
	protected override bool IsSupportViewType_Implementation(ECalliopeViewType InViewType)
	{
		if (InViewType == ECalliopeViewType.Dialogue || InViewType == ECalliopeViewType.Behavior)
		{
			return true;
		}
		return false;
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_BehaviorNode_OnUnitTrans:IsSupportViewType")]
	private static void IsSupportViewType__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_BehaviorNode_OnUnitTrans bED_BehaviorNode_OnUnitTrans = GCHelper.Find<BED_BehaviorNode_OnUnitTrans>(obj);
		ECalliopeViewType inViewType = EnumMarshaler<ECalliopeViewType>.FromNative(IntPtr.Add(buffer, IsSupportViewType_InViewType_Offset), 0, IsSupportViewType_InViewType_PropertyAddress.Address);
		bool value = bED_BehaviorNode_OnUnitTrans.IsSupportViewType_Implementation(inViewType);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, IsSupportViewType_ReturnValue_Offset), 0, IsSupportViewType_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_BehaviorNode_OnUnitTrans:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_BehaviorNode_OnUnitTrans bED_BehaviorNode_OnUnitTrans = GCHelper.Find<BED_BehaviorNode_OnUnitTrans>(obj);
		string nodeDescriptionInCS_Implementation = bED_BehaviorNode_OnUnitTrans.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_BehaviorNode_OnUnitTrans");
		NativeReflection.GetPropertyRef(ref UnitType_PropertyAddress, intPtr, "UnitType");
		UnitType_Offset = NativeReflection.GetPropertyOffset(intPtr, "UnitType");
		UnitType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UnitType", Classes.FEnumProperty);
		SmartUnit_Offset = NativeReflection.GetPropertyOffset(intPtr, "SmartUnit");
		SmartUnit_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SmartUnit", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref TransType_PropertyAddress, intPtr, "TransType");
		TransType_Offset = NativeReflection.GetPropertyOffset(intPtr, "TransType");
		TransType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TransType", Classes.FEnumProperty);
		IsSupportViewType_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsSupportViewType");
		IsSupportViewType_ParamsSize = NativeReflection.GetFunctionParamsSize(IsSupportViewType_FunctionAddress);
		NativeReflection.GetPropertyRef(ref IsSupportViewType_InViewType_PropertyAddress, IsSupportViewType_FunctionAddress, "InViewType");
		IsSupportViewType_InViewType_Offset = NativeReflection.GetPropertyOffset(IsSupportViewType_FunctionAddress, "InViewType");
		IsSupportViewType_InViewType_IsValid = NativeReflection.ValidatePropertyClass(IsSupportViewType_FunctionAddress, "InViewType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref IsSupportViewType_ReturnValue_PropertyAddress, IsSupportViewType_FunctionAddress, "ReturnValue");
		IsSupportViewType_ReturnValue_Offset = NativeReflection.GetPropertyOffset(IsSupportViewType_FunctionAddress, "ReturnValue");
		IsSupportViewType_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(IsSupportViewType_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsSupportViewType_IsValid = IsSupportViewType_FunctionAddress != IntPtr.Zero && IsSupportViewType_InViewType_IsValid && IsSupportViewType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_BehaviorNode_OnUnitTrans:IsSupportViewType", IsSupportViewType_IsValid);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_BehaviorNode_OnUnitTrans:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_BehaviorNode_OnUnitTrans()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_BehaviorNode_OnUnitTrans)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_BehaviorNode_OnUnitTrans));
	}
}
