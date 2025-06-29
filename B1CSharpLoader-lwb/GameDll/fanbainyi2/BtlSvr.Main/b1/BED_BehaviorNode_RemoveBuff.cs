using System;
using System.Text;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("移除Buff")]
[USharpPath("/Script/b1-Managed.BED_BehaviorNode_RemoveBuff")]
internal class BED_BehaviorNode_RemoveBuff : b1.BED_BehaviorNode_Action
{
	private static bool BuffID_IsValid;

	private static int BuffID_Offset;

	private static bool BuffLayer_IsValid;

	private static int BuffLayer_Offset;

	private static bool bTriggerRemoveEffect_IsValid;

	private static int bTriggerRemoveEffect_Offset;

	private static FFieldAddress bTriggerRemoveEffect_PropertyAddress;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_RemoveBuff:BuffID")]
	public int BuffID
	{
		get
		{
			CheckDestroyed();
			if (!BuffID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_RemoveBuff:BuffID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, BuffID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BuffID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_RemoveBuff:BuffID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, BuffID_Offset), value);
			}
		}
	}

	[UMeta(MDProp.ClampMin, "1")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_RemoveBuff:BuffLayer")]
	public int BuffLayer
	{
		get
		{
			CheckDestroyed();
			if (!BuffLayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_RemoveBuff:BuffLayer");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, BuffLayer_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BuffLayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_RemoveBuff:BuffLayer");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, BuffLayer_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[DisplayName("是否触发移除效果")]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_RemoveBuff:bTriggerRemoveEffect")]
	public bool bTriggerRemoveEffect
	{
		get
		{
			CheckDestroyed();
			if (!bTriggerRemoveEffect_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_RemoveBuff:bTriggerRemoveEffect");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bTriggerRemoveEffect_Offset), 0, bTriggerRemoveEffect_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bTriggerRemoveEffect_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_RemoveBuff:bTriggerRemoveEffect");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bTriggerRemoveEffect_Offset), 0, bTriggerRemoveEffect_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		base.Initialize(Initializer);
		BuffLayer = 1;
		bTriggerRemoveEffect = true;
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.BehaviorNode.RemoveBuff;
	}

	public override byte[] GetCustomData()
	{
		return new BehaviorCustom_RemoveBuff
		{
			BuffId = BuffID,
			BuffLayer = BuffLayer,
			IsTriggerRemoveEffect = bTriggerRemoveEffect
		}.ToByteArray();
	}

	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_RemoveBuff:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append($"移除buff：{BuffID}（{BuffLayer}层)");
		if (!bTriggerRemoveEffect)
		{
			stringBuilder.Append("\nnote: 仅移除buff但不移除效果");
		}
		return stringBuilder.ToString();
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_BehaviorNode_RemoveBuff:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BED_BehaviorNode_RemoveBuff bED_BehaviorNode_RemoveBuff = GCHelper.Find<b1.BED_BehaviorNode_RemoveBuff>(obj);
		string nodeDescriptionInCS_Implementation = bED_BehaviorNode_RemoveBuff.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_BehaviorNode_RemoveBuff");
		BuffID_Offset = NativeReflection.GetPropertyOffset(intPtr, "BuffID");
		BuffID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BuffID", Classes.FIntProperty);
		BuffLayer_Offset = NativeReflection.GetPropertyOffset(intPtr, "BuffLayer");
		BuffLayer_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BuffLayer", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref bTriggerRemoveEffect_PropertyAddress, intPtr, "bTriggerRemoveEffect");
		bTriggerRemoveEffect_Offset = NativeReflection.GetPropertyOffset(intPtr, "bTriggerRemoveEffect");
		bTriggerRemoveEffect_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bTriggerRemoveEffect", Classes.FBoolProperty);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_BehaviorNode_RemoveBuff:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_BehaviorNode_RemoveBuff()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BED_BehaviorNode_RemoveBuff)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BED_BehaviorNode_RemoveBuff));
	}
}
