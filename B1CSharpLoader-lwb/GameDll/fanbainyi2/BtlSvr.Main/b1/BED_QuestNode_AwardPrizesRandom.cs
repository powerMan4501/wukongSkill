using System;
using b1.Plugins.Calliope;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[NotBlueprintable]
[DisplayName("Award Prizes Random")]
[USharpPath("/Script/b1-Managed.BED_QuestNode_AwardPrizesRandom")]
public class BED_QuestNode_AwardPrizesRandom : BED_QuestNode
{
	private static bool RandomCount_IsValid;

	private static int RandomCount_Offset;

	private static bool SuccessLimit_IsValid;

	private static int SuccessLimit_Offset;

	private static bool NormalProbability_IsValid;

	private static int NormalProbability_Offset;

	private static bool FirstProbability_IsValid;

	private static int FirstProbability_Offset;

	private static bool SecondProbability_IsValid;

	private static int SecondProbability_Offset;

	private static bool EventId_IsValid;

	private static int EventId_Offset;

	private static bool RefreshDelta_IsValid;

	private static int RefreshDelta_Offset;

	private static bool AwardCd_IsValid;

	private static int AwardCd_Offset;

	private static bool PostPropertyChanged_IsValid;

	private static IntPtr PostPropertyChanged_FunctionAddress;

	private static int PostPropertyChanged_ParamsSize;

	private static bool PostPropertyChanged_MemberName_IsValid;

	private static int PostPropertyChanged_MemberName_Offset;

	private static FFieldAddress PostPropertyChanged_MemberName_PropertyAddress;

	private static bool PostPropertyChanged_PropertyName_IsValid;

	private static int PostPropertyChanged_PropertyName_Offset;

	private static FFieldAddress PostPropertyChanged_PropertyName_PropertyAddress;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[Tooltip("最大随机次数")]
	[Category("Award Prizes Random Config")]
	[EditDefaultsOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_AwardPrizesRandom:RandomCount")]
	protected int RandomCount
	{
		get
		{
			CheckDestroyed();
			if (!RandomCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_AwardPrizesRandom:RandomCount");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, RandomCount_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RandomCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_AwardPrizesRandom:RandomCount");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, RandomCount_Offset), value);
			}
		}
	}

	[UProperty]
	[EditDefaultsOnly]
	[Category("Award Prizes Random Config")]
	[Tooltip("最大可触发次数，默认：1")]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_AwardPrizesRandom:SuccessLimit")]
	protected int SuccessLimit
	{
		get
		{
			CheckDestroyed();
			if (!SuccessLimit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_AwardPrizesRandom:SuccessLimit");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, SuccessLimit_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SuccessLimit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_AwardPrizesRandom:SuccessLimit");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, SuccessLimit_Offset), value);
			}
		}
	}

	[UProperty]
	[EditDefaultsOnly]
	[Category("Award Prizes Random Config")]
	[Tooltip("普通人中奖概率")]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_AwardPrizesRandom:NormalProbability")]
	protected int NormalProbability
	{
		get
		{
			CheckDestroyed();
			if (!NormalProbability_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_AwardPrizesRandom:NormalProbability");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, NormalProbability_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NormalProbability_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_AwardPrizesRandom:NormalProbability");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, NormalProbability_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("Award Prizes Random Config")]
	[Tooltip("一级猎人中奖概率")]
	[EditDefaultsOnly]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_AwardPrizesRandom:FirstProbability")]
	protected int FirstProbability
	{
		get
		{
			CheckDestroyed();
			if (!FirstProbability_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_AwardPrizesRandom:FirstProbability");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, FirstProbability_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FirstProbability_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_AwardPrizesRandom:FirstProbability");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, FirstProbability_Offset), value);
			}
		}
	}

	[UProperty]
	[EditDefaultsOnly]
	[Category("Award Prizes Random Config")]
	[Tooltip("二级猎人中奖概率")]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_AwardPrizesRandom:SecondProbability")]
	protected int SecondProbability
	{
		get
		{
			CheckDestroyed();
			if (!SecondProbability_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_AwardPrizesRandom:SecondProbability");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, SecondProbability_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SecondProbability_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_AwardPrizesRandom:SecondProbability");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, SecondProbability_Offset), value);
			}
		}
	}

	[UProperty]
	[EditDefaultsOnly]
	[Tooltip("事件ID")]
	[Category("Award Prizes Random Config")]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_AwardPrizesRandom:EventId")]
	protected int EventId
	{
		get
		{
			CheckDestroyed();
			if (!EventId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_AwardPrizesRandom:EventId");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, EventId_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EventId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_AwardPrizesRandom:EventId");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, EventId_Offset), value);
			}
		}
	}

	[UProperty]
	[EditDefaultsOnly]
	[Category("Award Prizes Random Config")]
	[Tooltip("刷新间隔")]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_AwardPrizesRandom:RefreshDelta")]
	protected int RefreshDelta
	{
		get
		{
			CheckDestroyed();
			if (!RefreshDelta_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_AwardPrizesRandom:RefreshDelta");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, RefreshDelta_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RefreshDelta_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_AwardPrizesRandom:RefreshDelta");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, RefreshDelta_Offset), value);
			}
		}
	}

	[UProperty]
	[EditDefaultsOnly]
	[Category("Award Prizes Random Config")]
	[Tooltip("中奖CD")]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_AwardPrizesRandom:AwardCd")]
	protected int AwardCd
	{
		get
		{
			CheckDestroyed();
			if (!AwardCd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_AwardPrizesRandom:AwardCd");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, AwardCd_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AwardCd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_AwardPrizesRandom:AwardCd");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, AwardCd_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		base.Initialize(Initializer);
		SetNodeCategory("Notifies");
		SetNodeStyle(ECalliopeNodeStyle.Condition);
		base.InputPins.Clear();
		base.InputPins.Add(new FCalliopePin
		{
			PinName = BGW_FlowUtils.PinName.Enable
		});
		base.InputPins.Add(new FCalliopePin
		{
			PinName = BGW_FlowUtils.PinName.Disable
		});
		base.OutputPins.Clear();
		base.OutputPins.Add(new FCalliopePin
		{
			PinName = BGW_FlowUtils.PinName.Success
		});
		base.OutputPins.Add(new FCalliopePin
		{
			PinName = BGW_FlowUtils.PinName.Completed
		});
		base.OutputPins.Add(new FCalliopePin
		{
			PinName = BGW_FlowUtils.PinName.Enabled
		});
		base.OutputPins.Add(new FCalliopePin
		{
			PinName = BGW_FlowUtils.PinName.Disabled
		});
		SuccessLimit = 1;
	}

	[USharpPath("/Script/b1-Managed.BED_QuestNode_AwardPrizesRandom:PostPropertyChanged")]
	protected override void PostPropertyChanged_Implementation(string MemberName, string PropertyName)
	{
	}

	[USharpPath("/Script/b1-Managed.BED_QuestNode_AwardPrizesRandom:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		string identityPath = null;
		return $"{GetIdentityDescription(identityPath)}\r\n SuccessLimit:{SuccessLimit}";
	}

	public override byte[] GetCustomData()
	{
		return new QuestCustom_AwardPrizesRandom
		{
			RandomCount = RandomCount,
			NormalProbability = NormalProbability,
			FirstProbability = FirstProbability,
			SecondProbability = SecondProbability,
			EventId = EventId,
			RefreshDelta = RefreshDelta,
			AwardCd = AwardCd
		}.ToByteArray();
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.QuestNode.AwardPrizesRandom;
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_QuestNode_AwardPrizesRandom:PostPropertyChanged")]
	private static void PostPropertyChanged__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_QuestNode_AwardPrizesRandom bED_QuestNode_AwardPrizesRandom = GCHelper.Find<BED_QuestNode_AwardPrizesRandom>(obj);
		string memberName = FStringMarshaler.FromNative(IntPtr.Add(buffer, PostPropertyChanged_MemberName_Offset));
		string propertyName = FStringMarshaler.FromNative(IntPtr.Add(buffer, PostPropertyChanged_PropertyName_Offset));
		bED_QuestNode_AwardPrizesRandom.PostPropertyChanged_Implementation(memberName, propertyName);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_QuestNode_AwardPrizesRandom:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_QuestNode_AwardPrizesRandom bED_QuestNode_AwardPrizesRandom = GCHelper.Find<BED_QuestNode_AwardPrizesRandom>(obj);
		string nodeDescriptionInCS_Implementation = bED_QuestNode_AwardPrizesRandom.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_QuestNode_AwardPrizesRandom");
		RandomCount_Offset = NativeReflection.GetPropertyOffset(intPtr, "RandomCount");
		RandomCount_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RandomCount", Classes.FIntProperty);
		SuccessLimit_Offset = NativeReflection.GetPropertyOffset(intPtr, "SuccessLimit");
		SuccessLimit_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SuccessLimit", Classes.FIntProperty);
		NormalProbability_Offset = NativeReflection.GetPropertyOffset(intPtr, "NormalProbability");
		NormalProbability_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NormalProbability", Classes.FIntProperty);
		FirstProbability_Offset = NativeReflection.GetPropertyOffset(intPtr, "FirstProbability");
		FirstProbability_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FirstProbability", Classes.FIntProperty);
		SecondProbability_Offset = NativeReflection.GetPropertyOffset(intPtr, "SecondProbability");
		SecondProbability_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SecondProbability", Classes.FIntProperty);
		EventId_Offset = NativeReflection.GetPropertyOffset(intPtr, "EventId");
		EventId_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EventId", Classes.FIntProperty);
		RefreshDelta_Offset = NativeReflection.GetPropertyOffset(intPtr, "RefreshDelta");
		RefreshDelta_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RefreshDelta", Classes.FIntProperty);
		AwardCd_Offset = NativeReflection.GetPropertyOffset(intPtr, "AwardCd");
		AwardCd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AwardCd", Classes.FIntProperty);
		PostPropertyChanged_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PostPropertyChanged");
		PostPropertyChanged_ParamsSize = NativeReflection.GetFunctionParamsSize(PostPropertyChanged_FunctionAddress);
		NativeReflection.GetPropertyRef(ref PostPropertyChanged_MemberName_PropertyAddress, PostPropertyChanged_FunctionAddress, "MemberName");
		PostPropertyChanged_MemberName_Offset = NativeReflection.GetPropertyOffset(PostPropertyChanged_FunctionAddress, "MemberName");
		PostPropertyChanged_MemberName_IsValid = NativeReflection.ValidatePropertyClass(PostPropertyChanged_FunctionAddress, "MemberName", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref PostPropertyChanged_PropertyName_PropertyAddress, PostPropertyChanged_FunctionAddress, "PropertyName");
		PostPropertyChanged_PropertyName_Offset = NativeReflection.GetPropertyOffset(PostPropertyChanged_FunctionAddress, "PropertyName");
		PostPropertyChanged_PropertyName_IsValid = NativeReflection.ValidatePropertyClass(PostPropertyChanged_FunctionAddress, "PropertyName", Classes.FStrProperty);
		PostPropertyChanged_IsValid = PostPropertyChanged_FunctionAddress != IntPtr.Zero && PostPropertyChanged_MemberName_IsValid && PostPropertyChanged_PropertyName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_QuestNode_AwardPrizesRandom:PostPropertyChanged", PostPropertyChanged_IsValid);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_QuestNode_AwardPrizesRandom:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_QuestNode_AwardPrizesRandom()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_QuestNode_AwardPrizesRandom)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_QuestNode_AwardPrizesRandom));
	}
}
