using System;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("Challenge Succes")]
[UClass]
[USharpPath("/Script/b1-Managed.BED_QuestNode_ChallengeSuccess")]
public class BED_QuestNode_ChallengeSuccess : BED_QuestNode
{
	private static bool ChallengeId_IsValid;

	private static int ChallengeId_Offset;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_ChallengeSuccess:ChallengeId")]
	public int ChallengeId
	{
		get
		{
			CheckDestroyed();
			if (!ChallengeId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_ChallengeSuccess:ChallengeId");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ChallengeId_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ChallengeId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_ChallengeSuccess:ChallengeId");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ChallengeId_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		SetNodeCategory("Notifies");
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.QuestNode.ChallengeSuccess;
	}

	public override byte[] GetCustomData()
	{
		return new QuestCustom_ChallengeSuccess
		{
			ChallengeId = ChallengeId
		}.ToByteArray();
	}

	[USharpPath("/Script/b1-Managed.BED_QuestNode_ChallengeSuccess:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		return "";
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_QuestNode_ChallengeSuccess:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_QuestNode_ChallengeSuccess bED_QuestNode_ChallengeSuccess = GCHelper.Find<BED_QuestNode_ChallengeSuccess>(obj);
		string nodeDescriptionInCS_Implementation = bED_QuestNode_ChallengeSuccess.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_QuestNode_ChallengeSuccess");
		ChallengeId_Offset = NativeReflection.GetPropertyOffset(intPtr, "ChallengeId");
		ChallengeId_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ChallengeId", Classes.FIntProperty);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_QuestNode_ChallengeSuccess:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_QuestNode_ChallengeSuccess()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_QuestNode_ChallengeSuccess)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_QuestNode_ChallengeSuccess));
	}
}
