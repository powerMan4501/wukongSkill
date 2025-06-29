using System;
using System.Text;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("添加Buff")]
[UClass]
[USharpPath("/Script/b1-Managed.BED_BehaviorNode_AddBuff")]
internal class BED_BehaviorNode_AddBuff : b1.BED_BehaviorNode_Action
{
	private static bool BuffID_IsValid;

	private static int BuffID_Offset;

	private static bool BuffLayer_IsValid;

	private static int BuffLayer_Offset;

	private static bool BuffDuration_IsValid;

	private static int BuffDuration_Offset;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_AddBuff:BuffID")]
	public int BuffID
	{
		get
		{
			CheckDestroyed();
			if (!BuffID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_AddBuff:BuffID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, BuffID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BuffID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_AddBuff:BuffID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, BuffID_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UMeta(MDProp.ClampMin, "1")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_AddBuff:BuffLayer")]
	public int BuffLayer
	{
		get
		{
			CheckDestroyed();
			if (!BuffLayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_AddBuff:BuffLayer");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, BuffLayer_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BuffLayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_AddBuff:BuffLayer");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, BuffLayer_Offset), value);
			}
		}
	}

	[Tooltip("-1:不移除 ； 0：读Buff表中配置")]
	[DisplayName("Buff持续时间(毫秒)")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_AddBuff:BuffDuration")]
	public int BuffDuration
	{
		get
		{
			CheckDestroyed();
			if (!BuffDuration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_AddBuff:BuffDuration");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, BuffDuration_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BuffDuration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_AddBuff:BuffDuration");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, BuffDuration_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		base.Initialize(Initializer);
		BuffLayer = 1;
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.BehaviorNode.AddBuff;
	}

	public override byte[] GetCustomData()
	{
		return new BehaviorCustom_AddBuff
		{
			BuffId = BuffID,
			BuffLayer = BuffLayer,
			BuffDuration = BuffDuration
		}.ToByteArray();
	}

	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_AddBuff:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine($"添加Buff：{BuffID}（{BuffLayer}层)");
		stringBuilder.Append("持续时间：");
		if (BuffDuration < 0)
		{
			stringBuilder.Append("无限");
		}
		else if (BuffDuration == 0)
		{
			stringBuilder.Append("与表中配置一致");
		}
		else
		{
			stringBuilder.Append(BuffDuration);
		}
		return stringBuilder.ToString();
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_BehaviorNode_AddBuff:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BED_BehaviorNode_AddBuff bED_BehaviorNode_AddBuff = GCHelper.Find<b1.BED_BehaviorNode_AddBuff>(obj);
		string nodeDescriptionInCS_Implementation = bED_BehaviorNode_AddBuff.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_BehaviorNode_AddBuff");
		BuffID_Offset = NativeReflection.GetPropertyOffset(intPtr, "BuffID");
		BuffID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BuffID", Classes.FIntProperty);
		BuffLayer_Offset = NativeReflection.GetPropertyOffset(intPtr, "BuffLayer");
		BuffLayer_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BuffLayer", Classes.FIntProperty);
		BuffDuration_Offset = NativeReflection.GetPropertyOffset(intPtr, "BuffDuration");
		BuffDuration_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BuffDuration", Classes.FIntProperty);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_BehaviorNode_AddBuff:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_BehaviorNode_AddBuff()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BED_BehaviorNode_AddBuff)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BED_BehaviorNode_AddBuff));
	}
}
