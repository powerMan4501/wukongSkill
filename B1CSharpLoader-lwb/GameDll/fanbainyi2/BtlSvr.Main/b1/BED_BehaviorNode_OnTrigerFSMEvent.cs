using System;
using b1.Plugins.Calliope;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("OnTrigerFSMEvent")]
[USharpPath("/Script/b1-Managed.BED_BehaviorNode_OnTrigerFSMEvent")]
internal class BED_BehaviorNode_OnTrigerFSMEvent : BED_BehaviorNode
{
	private static bool EventTag_IsValid;

	private static int EventTag_Offset;

	private static bool IsSupportViewType_IsValid;

	private static IntPtr IsSupportViewType_FunctionAddress;

	private static int IsSupportViewType_ParamsSize;

	private static bool IsSupportViewType_InViewType_IsValid;

	private static int IsSupportViewType_InViewType_Offset;

	private static FFieldAddress IsSupportViewType_InViewType_PropertyAddress;

	private static bool IsSupportViewType_ReturnValue_IsValid;

	private static int IsSupportViewType_ReturnValue_Offset;

	private static FFieldAddress IsSupportViewType_ReturnValue_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_OnTrigerFSMEvent:EventTag")]
	public FGameplayTag EventTag
	{
		get
		{
			CheckDestroyed();
			if (!EventTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_OnTrigerFSMEvent:EventTag");
				return default(FGameplayTag);
			}
			return BlittableTypeMarshaler<FGameplayTag>.FromNative(IntPtr.Add(base.Address, EventTag_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EventTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_OnTrigerFSMEvent:EventTag");
			}
			else
			{
				BlittableTypeMarshaler<FGameplayTag>.ToNative(IntPtr.Add(base.Address, EventTag_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		SetNodeCategory("FSMState");
		SetNodeStyle(ECalliopeNodeStyle.InOut);
		base.InputPins.Clear();
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.BehaviorNode.OnTrigerFSMEvent;
	}

	public override byte[] GetCustomData()
	{
		return new BehaviorCustom_OnTrigerFSMEvent
		{
			EventName = EventTag.TagName.ToString()
		}.ToByteArray();
	}

	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_OnTrigerFSMEvent:IsSupportViewType")]
	protected override bool IsSupportViewType_Implementation(ECalliopeViewType InViewType)
	{
		if (InViewType == ECalliopeViewType.Dialogue || InViewType == ECalliopeViewType.Behavior)
		{
			return true;
		}
		return false;
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_BehaviorNode_OnTrigerFSMEvent:IsSupportViewType")]
	private static void IsSupportViewType__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BED_BehaviorNode_OnTrigerFSMEvent bED_BehaviorNode_OnTrigerFSMEvent = GCHelper.Find<b1.BED_BehaviorNode_OnTrigerFSMEvent>(obj);
		ECalliopeViewType inViewType = EnumMarshaler<ECalliopeViewType>.FromNative(IntPtr.Add(buffer, IsSupportViewType_InViewType_Offset), 0, IsSupportViewType_InViewType_PropertyAddress.Address);
		bool value = bED_BehaviorNode_OnTrigerFSMEvent.IsSupportViewType_Implementation(inViewType);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, IsSupportViewType_ReturnValue_Offset), 0, IsSupportViewType_ReturnValue_PropertyAddress.Address, value);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_BehaviorNode_OnTrigerFSMEvent");
		EventTag_Offset = NativeReflection.GetPropertyOffset(intPtr, "EventTag");
		EventTag_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EventTag", Classes.FStructProperty);
		IsSupportViewType_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsSupportViewType");
		IsSupportViewType_ParamsSize = NativeReflection.GetFunctionParamsSize(IsSupportViewType_FunctionAddress);
		NativeReflection.GetPropertyRef(ref IsSupportViewType_InViewType_PropertyAddress, IsSupportViewType_FunctionAddress, "InViewType");
		IsSupportViewType_InViewType_Offset = NativeReflection.GetPropertyOffset(IsSupportViewType_FunctionAddress, "InViewType");
		IsSupportViewType_InViewType_IsValid = NativeReflection.ValidatePropertyClass(IsSupportViewType_FunctionAddress, "InViewType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref IsSupportViewType_ReturnValue_PropertyAddress, IsSupportViewType_FunctionAddress, "ReturnValue");
		IsSupportViewType_ReturnValue_Offset = NativeReflection.GetPropertyOffset(IsSupportViewType_FunctionAddress, "ReturnValue");
		IsSupportViewType_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(IsSupportViewType_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsSupportViewType_IsValid = IsSupportViewType_FunctionAddress != IntPtr.Zero && IsSupportViewType_InViewType_IsValid && IsSupportViewType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_BehaviorNode_OnTrigerFSMEvent:IsSupportViewType", IsSupportViewType_IsValid);
	}

	static BED_BehaviorNode_OnTrigerFSMEvent()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BED_BehaviorNode_OnTrigerFSMEvent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BED_BehaviorNode_OnTrigerFSMEvent));
	}
}
