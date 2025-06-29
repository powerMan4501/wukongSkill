using System;
using System.Text;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("演员: 移除Buff")]
[USharpPath("/Script/b1-Managed.BED_MovieNode_PerformerRemoveBuff")]
internal class BED_MovieNode_PerformerRemoveBuff : b1.BED_MovieNode_PerformerAction
{
	private static bool BuffID_IsValid;

	private static int BuffID_Offset;

	private static bool BuffLayer_IsValid;

	private static int BuffLayer_Offset;

	private static bool bTriggerRemoveEffect_IsValid;

	private static int bTriggerRemoveEffect_Offset;

	private static FFieldAddress bTriggerRemoveEffect_PropertyAddress;

	private static bool bPlayerAsPerformer_IsValid;

	private static int bPlayerAsPerformer_Offset;

	private static FFieldAddress bPlayerAsPerformer_PropertyAddress;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[Category("Movie")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BED_MovieNode_PerformerRemoveBuff:BuffID")]
	public int BuffID
	{
		get
		{
			CheckDestroyed();
			if (!BuffID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_PerformerRemoveBuff:BuffID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, BuffID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BuffID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_PerformerRemoveBuff:BuffID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, BuffID_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Movie")]
	[UMeta(MDProp.ClampMin, "1")]
	[USharpPath("/Script/b1-Managed.BED_MovieNode_PerformerRemoveBuff:BuffLayer")]
	public int BuffLayer
	{
		get
		{
			CheckDestroyed();
			if (!BuffLayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_PerformerRemoveBuff:BuffLayer");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, BuffLayer_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BuffLayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_PerformerRemoveBuff:BuffLayer");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, BuffLayer_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Movie")]
	[DisplayName("是否触发移除效果")]
	[USharpPath("/Script/b1-Managed.BED_MovieNode_PerformerRemoveBuff:bTriggerRemoveEffect")]
	public bool bTriggerRemoveEffect
	{
		get
		{
			CheckDestroyed();
			if (!bTriggerRemoveEffect_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_PerformerRemoveBuff:bTriggerRemoveEffect");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bTriggerRemoveEffect_Offset), 0, bTriggerRemoveEffect_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bTriggerRemoveEffect_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_PerformerRemoveBuff:bTriggerRemoveEffect");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bTriggerRemoveEffect_Offset), 0, bTriggerRemoveEffect_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("Player作为演员")]
	[Category("Movie")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BED_MovieNode_PerformerRemoveBuff:bPlayerAsPerformer")]
	public bool bPlayerAsPerformer
	{
		get
		{
			CheckDestroyed();
			if (!bPlayerAsPerformer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_PerformerRemoveBuff:bPlayerAsPerformer");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bPlayerAsPerformer_Offset), 0, bPlayerAsPerformer_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bPlayerAsPerformer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_PerformerRemoveBuff:bPlayerAsPerformer");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bPlayerAsPerformer_Offset), 0, bPlayerAsPerformer_PropertyAddress.Address, value);
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
		return B1CalliopeDef.MovieNode.PerformerRemoveBuff;
	}

	[USharpPath("/Script/b1-Managed.BED_MovieNode_PerformerRemoveBuff:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine("演员： " + base.Performer.TagName.PlainName);
		stringBuilder.Append($"移除buff：{BuffID}（{BuffLayer}层)");
		if (!bTriggerRemoveEffect)
		{
			stringBuilder.Append("\nnote: 仅移除buff但不移除效果");
		}
		return stringBuilder.ToString();
	}

	public override byte[] GetCustomData()
	{
		return new MovieCustom_PerformerRemoveBuff
		{
			PerformerGuid = base.Performer.TagName.PlainName,
			BuffId = BuffID,
			BuffLayer = BuffLayer,
			IsTriggerRemoveEffect = bTriggerRemoveEffect,
			IsPlayerAsPerformer = bPlayerAsPerformer
		}.ToByteArray();
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_MovieNode_PerformerRemoveBuff:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BED_MovieNode_PerformerRemoveBuff bED_MovieNode_PerformerRemoveBuff = GCHelper.Find<b1.BED_MovieNode_PerformerRemoveBuff>(obj);
		string nodeDescriptionInCS_Implementation = bED_MovieNode_PerformerRemoveBuff.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_MovieNode_PerformerRemoveBuff");
		BuffID_Offset = NativeReflection.GetPropertyOffset(intPtr, "BuffID");
		BuffID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BuffID", Classes.FIntProperty);
		BuffLayer_Offset = NativeReflection.GetPropertyOffset(intPtr, "BuffLayer");
		BuffLayer_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BuffLayer", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref bTriggerRemoveEffect_PropertyAddress, intPtr, "bTriggerRemoveEffect");
		bTriggerRemoveEffect_Offset = NativeReflection.GetPropertyOffset(intPtr, "bTriggerRemoveEffect");
		bTriggerRemoveEffect_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bTriggerRemoveEffect", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bPlayerAsPerformer_PropertyAddress, intPtr, "bPlayerAsPerformer");
		bPlayerAsPerformer_Offset = NativeReflection.GetPropertyOffset(intPtr, "bPlayerAsPerformer");
		bPlayerAsPerformer_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bPlayerAsPerformer", Classes.FBoolProperty);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_MovieNode_PerformerRemoveBuff:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_MovieNode_PerformerRemoveBuff()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BED_MovieNode_PerformerRemoveBuff)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BED_MovieNode_PerformerRemoveBuff));
	}
}
