using System;
using System.Collections.Generic;
using System.Text;
using b1.Plugins.Calliope;
using BtlB1;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1.Editor.Calliope.Behavior.Nodes;

[UClass]
[DisplayName("AiConversation")]
[USharpPath("/Script/b1-Managed.BED_BehaviorNode_AiConversation")]
internal class BED_BehaviorNode_AiConversation : b1.BED_BehaviorNode_Action
{
	private static bool AiConversationContentIDList_IsValid;

	private static int AiConversationContentIDList_Offset;

	private static FFieldAddress AiConversationContentIDList_PropertyAddress;

	private TArrayReadWriteMarshaler<int> AiConversationContentIDList_Marshaler;

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

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[Category("AiConversation")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_AiConversation:AiConversationContentIDList")]
	public TArrayReadWrite<int> AiConversationContentIDList
	{
		get
		{
			CheckDestroyed();
			if (!AiConversationContentIDList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_AiConversation:AiConversationContentIDList");
				return null;
			}
			if (AiConversationContentIDList_Marshaler == null)
			{
				AiConversationContentIDList_Marshaler = new TArrayReadWriteMarshaler<int>(1, AiConversationContentIDList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return AiConversationContentIDList_Marshaler.FromNative(IntPtr.Add(base.Address, AiConversationContentIDList_Offset));
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		base.Initialize(Initializer);
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.BehaviorNode.AiConversation;
	}

	public override byte[] GetCustomData()
	{
		BehaviorCustom_AiConversation behaviorCustom_AiConversation = new BehaviorCustom_AiConversation();
		if (AiConversationContentIDList.Count > 0)
		{
			int[] array = new int[AiConversationContentIDList.Count];
			for (int i = 0; i < AiConversationContentIDList.Count; i++)
			{
				array[i] = AiConversationContentIDList[i];
			}
			behaviorCustom_AiConversation.ContentIdList.Clear();
			behaviorCustom_AiConversation.ContentIdList.AddRange(array);
		}
		return behaviorCustom_AiConversation.ToByteArray();
	}

	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_AiConversation:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		StringBuilder stringBuilder = new StringBuilder();
		List<int> list = new List<int>();
		list = BGUFuncLibAiConversation.AnalysisAiConversationIDList(AiConversationContentIDList.ToList());
		if (list.Count > 0)
		{
			for (int i = 0; i < list.Count; i++)
			{
				string text = "";
				FUStAiConversationContentDesc descDataNoneRunTime_AiConversationContentDesc = BGUFuncLibNonRuntime.GetDescDataNoneRunTime_AiConversationContentDesc(list[i]);
				text = ((descDataNoneRunTime_AiConversationContentDesc == null) ? list[i].ToString() : (list[i] + " : " + descDataNoneRunTime_AiConversationContentDesc.Subtitle));
				stringBuilder.AppendLine(text);
			}
		}
		else
		{
			stringBuilder.AppendLine("null");
		}
		return stringBuilder.ToString();
	}

	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_AiConversation:OnRefreshAssetInCS")]
	protected override void OnRefreshAssetInCS_Implementation()
	{
		BGUFuncLibNonRuntime.LoadProtobufDataNoneRunTime_AiConversationContentDesc();
	}

	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_AiConversation:IsSupportViewType")]
	protected override bool IsSupportViewType_Implementation(ECalliopeViewType InViewType)
	{
		if (InViewType == ECalliopeViewType.Dialogue || InViewType == ECalliopeViewType.Behavior)
		{
			return true;
		}
		return false;
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_BehaviorNode_AiConversation:IsSupportViewType")]
	private static void IsSupportViewType__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.Editor.Calliope.Behavior.Nodes.BED_BehaviorNode_AiConversation bED_BehaviorNode_AiConversation = GCHelper.Find<b1.Editor.Calliope.Behavior.Nodes.BED_BehaviorNode_AiConversation>(obj);
		ECalliopeViewType inViewType = EnumMarshaler<ECalliopeViewType>.FromNative(IntPtr.Add(buffer, IsSupportViewType_InViewType_Offset), 0, IsSupportViewType_InViewType_PropertyAddress.Address);
		bool value = bED_BehaviorNode_AiConversation.IsSupportViewType_Implementation(inViewType);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, IsSupportViewType_ReturnValue_Offset), 0, IsSupportViewType_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_BehaviorNode_AiConversation:OnRefreshAssetInCS")]
	private static void OnRefreshAssetInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.Editor.Calliope.Behavior.Nodes.BED_BehaviorNode_AiConversation bED_BehaviorNode_AiConversation = GCHelper.Find<b1.Editor.Calliope.Behavior.Nodes.BED_BehaviorNode_AiConversation>(obj);
		bED_BehaviorNode_AiConversation.OnRefreshAssetInCS_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_BehaviorNode_AiConversation:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.Editor.Calliope.Behavior.Nodes.BED_BehaviorNode_AiConversation bED_BehaviorNode_AiConversation = GCHelper.Find<b1.Editor.Calliope.Behavior.Nodes.BED_BehaviorNode_AiConversation>(obj);
		string nodeDescriptionInCS_Implementation = bED_BehaviorNode_AiConversation.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_BehaviorNode_AiConversation");
		NativeReflection.GetPropertyRef(ref AiConversationContentIDList_PropertyAddress, intPtr, "AiConversationContentIDList");
		AiConversationContentIDList_Offset = NativeReflection.GetPropertyOffset(intPtr, "AiConversationContentIDList");
		AiConversationContentIDList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AiConversationContentIDList", Classes.FArrayProperty);
		IsSupportViewType_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsSupportViewType");
		IsSupportViewType_ParamsSize = NativeReflection.GetFunctionParamsSize(IsSupportViewType_FunctionAddress);
		NativeReflection.GetPropertyRef(ref IsSupportViewType_InViewType_PropertyAddress, IsSupportViewType_FunctionAddress, "InViewType");
		IsSupportViewType_InViewType_Offset = NativeReflection.GetPropertyOffset(IsSupportViewType_FunctionAddress, "InViewType");
		IsSupportViewType_InViewType_IsValid = NativeReflection.ValidatePropertyClass(IsSupportViewType_FunctionAddress, "InViewType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref IsSupportViewType_ReturnValue_PropertyAddress, IsSupportViewType_FunctionAddress, "ReturnValue");
		IsSupportViewType_ReturnValue_Offset = NativeReflection.GetPropertyOffset(IsSupportViewType_FunctionAddress, "ReturnValue");
		IsSupportViewType_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(IsSupportViewType_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsSupportViewType_IsValid = IsSupportViewType_FunctionAddress != IntPtr.Zero && IsSupportViewType_InViewType_IsValid && IsSupportViewType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_BehaviorNode_AiConversation:IsSupportViewType", IsSupportViewType_IsValid);
		OnRefreshAssetInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnRefreshAssetInCS");
		OnRefreshAssetInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnRefreshAssetInCS_FunctionAddress);
		OnRefreshAssetInCS_IsValid = OnRefreshAssetInCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_BehaviorNode_AiConversation:OnRefreshAssetInCS", OnRefreshAssetInCS_IsValid);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_BehaviorNode_AiConversation:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_BehaviorNode_AiConversation()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.Editor.Calliope.Behavior.Nodes.BED_BehaviorNode_AiConversation)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.Editor.Calliope.Behavior.Nodes.BED_BehaviorNode_AiConversation));
	}
}
