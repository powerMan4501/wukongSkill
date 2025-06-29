using System;
using System.Text;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("演员: 添加Buff")]
[USharpPath("/Script/b1-Managed.BED_MovieNode_PerformerAddBuff")]
internal class BED_MovieNode_PerformerAddBuff : b1.BED_MovieNode_PerformerAction
{
	private static bool BuffID_IsValid;

	private static int BuffID_Offset;

	private static bool BuffLayer_IsValid;

	private static int BuffLayer_Offset;

	private static bool BuffDuration_IsValid;

	private static int BuffDuration_Offset;

	private static bool bPlayerAsPerformer_IsValid;

	private static int bPlayerAsPerformer_Offset;

	private static FFieldAddress bPlayerAsPerformer_PropertyAddress;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[Category("Movie")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_MovieNode_PerformerAddBuff:BuffID")]
	public int BuffID
	{
		get
		{
			CheckDestroyed();
			if (!BuffID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_PerformerAddBuff:BuffID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, BuffID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BuffID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_PerformerAddBuff:BuffID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, BuffID_Offset), value);
			}
		}
	}

	[Category("Movie")]
	[UMeta(MDProp.ClampMin, "1")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_MovieNode_PerformerAddBuff:BuffLayer")]
	public int BuffLayer
	{
		get
		{
			CheckDestroyed();
			if (!BuffLayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_PerformerAddBuff:BuffLayer");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, BuffLayer_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BuffLayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_PerformerAddBuff:BuffLayer");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, BuffLayer_Offset), value);
			}
		}
	}

	[DisplayName("Buff持续时间(毫秒)")]
	[EditAnywhere]
	[Category("Movie")]
	[UProperty]
	[Tooltip("-1:不移除 ； 0：读Buff表中配置")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BED_MovieNode_PerformerAddBuff:BuffDuration")]
	public int BuffDuration
	{
		get
		{
			CheckDestroyed();
			if (!BuffDuration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_PerformerAddBuff:BuffDuration");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, BuffDuration_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BuffDuration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_PerformerAddBuff:BuffDuration");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, BuffDuration_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("Movie")]
	[DisplayName("Player作为演员")]
	[USharpPath("/Script/b1-Managed.BED_MovieNode_PerformerAddBuff:bPlayerAsPerformer")]
	public bool bPlayerAsPerformer
	{
		get
		{
			CheckDestroyed();
			if (!bPlayerAsPerformer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_PerformerAddBuff:bPlayerAsPerformer");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bPlayerAsPerformer_Offset), 0, bPlayerAsPerformer_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bPlayerAsPerformer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_PerformerAddBuff:bPlayerAsPerformer");
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
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.MovieNode.PerformerAddBuff;
	}

	[USharpPath("/Script/b1-Managed.BED_MovieNode_PerformerAddBuff:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		StringBuilder stringBuilder = new StringBuilder();
		if (bPlayerAsPerformer)
		{
			stringBuilder.AppendLine("演员： Player");
		}
		else
		{
			stringBuilder.AppendLine("演员： " + base.Performer.TagName.PlainName);
		}
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

	public override byte[] GetCustomData()
	{
		return new MovieCustom_PerformerAddBuff
		{
			PerformerGuid = base.Performer.TagName.PlainName,
			BuffId = BuffID,
			BuffLayer = BuffLayer,
			BuffDuration = BuffDuration,
			IsPlayerAsPerformer = bPlayerAsPerformer
		}.ToByteArray();
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_MovieNode_PerformerAddBuff:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BED_MovieNode_PerformerAddBuff bED_MovieNode_PerformerAddBuff = GCHelper.Find<b1.BED_MovieNode_PerformerAddBuff>(obj);
		string nodeDescriptionInCS_Implementation = bED_MovieNode_PerformerAddBuff.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_MovieNode_PerformerAddBuff");
		BuffID_Offset = NativeReflection.GetPropertyOffset(intPtr, "BuffID");
		BuffID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BuffID", Classes.FIntProperty);
		BuffLayer_Offset = NativeReflection.GetPropertyOffset(intPtr, "BuffLayer");
		BuffLayer_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BuffLayer", Classes.FIntProperty);
		BuffDuration_Offset = NativeReflection.GetPropertyOffset(intPtr, "BuffDuration");
		BuffDuration_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BuffDuration", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref bPlayerAsPerformer_PropertyAddress, intPtr, "bPlayerAsPerformer");
		bPlayerAsPerformer_Offset = NativeReflection.GetPropertyOffset(intPtr, "bPlayerAsPerformer");
		bPlayerAsPerformer_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bPlayerAsPerformer", Classes.FBoolProperty);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_MovieNode_PerformerAddBuff:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_MovieNode_PerformerAddBuff()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BED_MovieNode_PerformerAddBuff)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BED_MovieNode_PerformerAddBuff));
	}
}
