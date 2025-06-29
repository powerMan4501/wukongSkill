using System;
using System.Text;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("UnitStateTrigger")]
[Placeable(false)]
[USharpPath("/Script/b1-Managed.BED_BehaviorNode_UnitStateTrigger")]
internal class BED_BehaviorNode_UnitStateTrigger : b1.BED_BehaviorNode_Action
{
	private static bool UnitStateTrigger_IsValid;

	private static int UnitStateTrigger_Offset;

	private static FFieldAddress UnitStateTrigger_PropertyAddress;

	private static bool Time_IsValid;

	private static int Time_Offset;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_UnitStateTrigger:UnitStateTrigger")]
	public EBUStateTrigger UnitStateTrigger
	{
		get
		{
			CheckDestroyed();
			if (!UnitStateTrigger_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_UnitStateTrigger:UnitStateTrigger");
				return EBUStateTrigger.None;
			}
			return EnumMarshaler<EBUStateTrigger>.FromNative(IntPtr.Add(base.Address, UnitStateTrigger_Offset), 0, UnitStateTrigger_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UnitStateTrigger_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_UnitStateTrigger:UnitStateTrigger");
			}
			else
			{
				EnumMarshaler<EBUStateTrigger>.ToNative(IntPtr.Add(base.Address, UnitStateTrigger_Offset), 0, UnitStateTrigger_PropertyAddress.Address, value);
			}
		}
	}

	[Category("持续时间")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_UnitStateTrigger:Time")]
	public float Time
	{
		get
		{
			CheckDestroyed();
			if (!Time_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_UnitStateTrigger:Time");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Time_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Time_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_UnitStateTrigger:Time");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Time_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		base.Initialize(Initializer);
		Time = 0f;
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.BehaviorNode.UnitStateTrigger;
	}

	public override byte[] GetCustomData()
	{
		return new BehaviorCustom_UnitStateTrigger
		{
			UnitStateTrigger = (int)UnitStateTrigger,
			Time = Time
		}.ToByteArray();
	}

	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_UnitStateTrigger:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine($"UnitStateTrigger : {UnitStateTrigger}");
		stringBuilder.Append($"持续时间{Time}");
		return stringBuilder.ToString();
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_BehaviorNode_UnitStateTrigger:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BED_BehaviorNode_UnitStateTrigger bED_BehaviorNode_UnitStateTrigger = GCHelper.Find<b1.BED_BehaviorNode_UnitStateTrigger>(obj);
		string nodeDescriptionInCS_Implementation = bED_BehaviorNode_UnitStateTrigger.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_BehaviorNode_UnitStateTrigger");
		NativeReflection.GetPropertyRef(ref UnitStateTrigger_PropertyAddress, intPtr, "UnitStateTrigger");
		UnitStateTrigger_Offset = NativeReflection.GetPropertyOffset(intPtr, "UnitStateTrigger");
		UnitStateTrigger_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UnitStateTrigger", Classes.FEnumProperty);
		Time_Offset = NativeReflection.GetPropertyOffset(intPtr, "Time");
		Time_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Time", Classes.FFloatProperty);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_BehaviorNode_UnitStateTrigger:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_BehaviorNode_UnitStateTrigger()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BED_BehaviorNode_UnitStateTrigger)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BED_BehaviorNode_UnitStateTrigger));
	}
}
