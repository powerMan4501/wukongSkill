using System;
using System.Collections.Generic;
using b1.Plugins.Calliope;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("按权重随机")]
[USharpPath("/Script/b1-Managed.BED_BehaviorNode_WeightRandom")]
internal class BED_BehaviorNode_WeightRandom : BED_BehaviorNode
{
	private static bool Weights_IsValid;

	private static int Weights_Offset;

	private static FFieldAddress Weights_PropertyAddress;

	private TArrayReadWriteMarshaler<b1.FWeightConfig> Weights_Marshaler;

	private static bool IsSupportViewType_IsValid;

	private static IntPtr IsSupportViewType_FunctionAddress;

	private static int IsSupportViewType_ParamsSize;

	private static bool IsSupportViewType_InViewType_IsValid;

	private static int IsSupportViewType_InViewType_Offset;

	private static FFieldAddress IsSupportViewType_InViewType_PropertyAddress;

	private static bool IsSupportViewType_ReturnValue_IsValid;

	private static int IsSupportViewType_ReturnValue_Offset;

	private static FFieldAddress IsSupportViewType_ReturnValue_PropertyAddress;

	private static bool OnRefreshAssetInCS_IsValid;

	private static IntPtr OnRefreshAssetInCS_FunctionAddress;

	private static int OnRefreshAssetInCS_ParamsSize;

	private static bool GetContextOutputsInCS_IsValid;

	private static IntPtr GetContextOutputsInCS_FunctionAddress;

	private static int GetContextOutputsInCS_ParamsSize;

	private static bool GetContextOutputsInCS_ReturnValue_IsValid;

	private static int GetContextOutputsInCS_ReturnValue_Offset;

	private static FFieldAddress GetContextOutputsInCS_ReturnValue_PropertyAddress;

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("权重配置")]
	[UProperty]
	[Tooltip("按权重比例随机")]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_WeightRandom:Weights")]
	public TArrayReadWrite<b1.FWeightConfig> Weights
	{
		get
		{
			CheckDestroyed();
			if (!Weights_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_WeightRandom:Weights");
				return null;
			}
			if (Weights_Marshaler == null)
			{
				Weights_Marshaler = new TArrayReadWriteMarshaler<b1.FWeightConfig>(1, Weights_PropertyAddress, CachedMarshalingDelegates<b1.FWeightConfig, BlittableTypeMarshaler<b1.FWeightConfig>>.FromNative, CachedMarshalingDelegates<b1.FWeightConfig, BlittableTypeMarshaler<b1.FWeightConfig>>.ToNative);
			}
			return Weights_Marshaler.FromNative(IntPtr.Add(base.Address, Weights_Offset));
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		base.Initialize(Initializer);
		SetNodeCategory("ConditionOnce");
		SetNodeStyle(ECalliopeNodeStyle.Latent);
		base.OutputPins.Clear();
		base.SupportsContextPins = true;
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.BehaviorNode.WeightRandom;
	}

	public override byte[] GetCustomData()
	{
		BehaviorCustom_WeightRandom behaviorCustom_WeightRandom = new BehaviorCustom_WeightRandom();
		for (int i = 0; i < Weights.Count; i++)
		{
			b1.FWeightConfig fWeightConfig = Weights[i];
			BehaviorCustom_WeightPin item = new BehaviorCustom_WeightPin
			{
				PinName = GetPinName(i, fWeightConfig.Comment),
				Weight = fWeightConfig.Weight
			};
			behaviorCustom_WeightRandom.WeightPins.Add(item);
		}
		return behaviorCustom_WeightRandom.ToByteArray();
	}

	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_WeightRandom:OnRefreshAssetInCS")]
	protected override void OnRefreshAssetInCS_Implementation()
	{
		float num = 0f;
		foreach (b1.FWeightConfig weight in Weights)
		{
			num += (float)weight.Weight;
		}
		for (int i = 0; i < Weights.Count; i++)
		{
			b1.FWeightConfig value = Weights[i];
			value.RandomValue = (float)value.Weight / num * 100f;
			Weights[i] = value;
		}
	}

	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_WeightRandom:GetContextOutputsInCS")]
	protected override List<FName> GetContextOutputsInCS_Implementation()
	{
		List<FName> list = new List<FName>();
		for (int i = 0; i < Weights.Count; i++)
		{
			list.Add(new FName(GetPinName(i, Weights[i].Comment)));
		}
		return list;
	}

	private string GetPinName(int Index, FName Comment)
	{
		if (Comment != FName.None)
		{
			return $"{Comment} : {Index}";
		}
		return Index.ToString();
	}

	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_WeightRandom:IsSupportViewType")]
	protected override bool IsSupportViewType_Implementation(ECalliopeViewType InViewType)
	{
		if (InViewType == ECalliopeViewType.Dialogue || InViewType == ECalliopeViewType.Behavior)
		{
			return true;
		}
		return false;
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_BehaviorNode_WeightRandom:IsSupportViewType")]
	private static void IsSupportViewType__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BED_BehaviorNode_WeightRandom bED_BehaviorNode_WeightRandom = GCHelper.Find<b1.BED_BehaviorNode_WeightRandom>(obj);
		ECalliopeViewType inViewType = EnumMarshaler<ECalliopeViewType>.FromNative(IntPtr.Add(buffer, IsSupportViewType_InViewType_Offset), 0, IsSupportViewType_InViewType_PropertyAddress.Address);
		bool value = bED_BehaviorNode_WeightRandom.IsSupportViewType_Implementation(inViewType);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, IsSupportViewType_ReturnValue_Offset), 0, IsSupportViewType_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_BehaviorNode_WeightRandom:OnRefreshAssetInCS")]
	private static void OnRefreshAssetInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BED_BehaviorNode_WeightRandom bED_BehaviorNode_WeightRandom = GCHelper.Find<b1.BED_BehaviorNode_WeightRandom>(obj);
		bED_BehaviorNode_WeightRandom.OnRefreshAssetInCS_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_BehaviorNode_WeightRandom:GetContextOutputsInCS")]
	private static void GetContextOutputsInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BED_BehaviorNode_WeightRandom bED_BehaviorNode_WeightRandom = GCHelper.Find<b1.BED_BehaviorNode_WeightRandom>(obj);
		TArrayCopyMarshaler<FName> tArrayCopyMarshaler = new TArrayCopyMarshaler<FName>(1, GetContextOutputsInCS_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
		List<FName> contextOutputsInCS_Implementation = bED_BehaviorNode_WeightRandom.GetContextOutputsInCS_Implementation();
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, GetContextOutputsInCS_ReturnValue_Offset), contextOutputsInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_BehaviorNode_WeightRandom");
		NativeReflection.GetPropertyRef(ref Weights_PropertyAddress, intPtr, "Weights");
		Weights_Offset = NativeReflection.GetPropertyOffset(intPtr, "Weights");
		Weights_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Weights", Classes.FArrayProperty);
		IsSupportViewType_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsSupportViewType");
		IsSupportViewType_ParamsSize = NativeReflection.GetFunctionParamsSize(IsSupportViewType_FunctionAddress);
		NativeReflection.GetPropertyRef(ref IsSupportViewType_InViewType_PropertyAddress, IsSupportViewType_FunctionAddress, "InViewType");
		IsSupportViewType_InViewType_Offset = NativeReflection.GetPropertyOffset(IsSupportViewType_FunctionAddress, "InViewType");
		IsSupportViewType_InViewType_IsValid = NativeReflection.ValidatePropertyClass(IsSupportViewType_FunctionAddress, "InViewType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref IsSupportViewType_ReturnValue_PropertyAddress, IsSupportViewType_FunctionAddress, "ReturnValue");
		IsSupportViewType_ReturnValue_Offset = NativeReflection.GetPropertyOffset(IsSupportViewType_FunctionAddress, "ReturnValue");
		IsSupportViewType_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(IsSupportViewType_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsSupportViewType_IsValid = IsSupportViewType_FunctionAddress != IntPtr.Zero && IsSupportViewType_InViewType_IsValid && IsSupportViewType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_BehaviorNode_WeightRandom:IsSupportViewType", IsSupportViewType_IsValid);
		OnRefreshAssetInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnRefreshAssetInCS");
		OnRefreshAssetInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnRefreshAssetInCS_FunctionAddress);
		OnRefreshAssetInCS_IsValid = OnRefreshAssetInCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_BehaviorNode_WeightRandom:OnRefreshAssetInCS", OnRefreshAssetInCS_IsValid);
		GetContextOutputsInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetContextOutputsInCS");
		GetContextOutputsInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetContextOutputsInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetContextOutputsInCS_ReturnValue_PropertyAddress, GetContextOutputsInCS_FunctionAddress, "ReturnValue");
		GetContextOutputsInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetContextOutputsInCS_FunctionAddress, "ReturnValue");
		GetContextOutputsInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetContextOutputsInCS_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetContextOutputsInCS_IsValid = GetContextOutputsInCS_FunctionAddress != IntPtr.Zero && GetContextOutputsInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_BehaviorNode_WeightRandom:GetContextOutputsInCS", GetContextOutputsInCS_IsValid);
	}

	static BED_BehaviorNode_WeightRandom()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BED_BehaviorNode_WeightRandom)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BED_BehaviorNode_WeightRandom));
	}
}
