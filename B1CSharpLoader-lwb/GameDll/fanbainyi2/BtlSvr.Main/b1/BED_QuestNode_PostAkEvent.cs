using System;
using System.Linq;
using b1.Plugins.AkAudio;
using b1.Plugins.Calliope;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("Post AkEvent")]
[UClass]
[USharpPath("/Script/b1-Managed.BED_QuestNode_PostAkEvent")]
public class BED_QuestNode_PostAkEvent : BED_QuestNode
{
	private static bool AkEvent_IsValid;

	private static int AkEvent_Offset;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[Category("PostAkEvent")]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_PostAkEvent:AkEvent")]
	public TSoftObject<UAkAudioEvent> AkEvent
	{
		get
		{
			CheckDestroyed();
			if (!AkEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_PostAkEvent:AkEvent");
				return default(TSoftObject<UAkAudioEvent>);
			}
			return TSoftObjectMarshaler<UAkAudioEvent>.FromNative(IntPtr.Add(base.Address, AkEvent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AkEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_PostAkEvent:AkEvent");
			}
			else
			{
				TSoftObjectMarshaler<UAkAudioEvent>.ToNative(IntPtr.Add(base.Address, AkEvent_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		SetNodeCategory("Gameplay");
		SetNodeStyle(ECalliopeNodeStyle.Default);
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.QuestNode.PostAkEvent;
	}

	[USharpPath("/Script/b1-Managed.BED_QuestNode_PostAkEvent:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		if (!AkEvent.IsNull)
		{
			return "播放声音 : [" + AkEvent.AssetPathName.Split('.').Last() + "]";
		}
		return "未配置声音文件";
	}

	public override byte[] GetCustomData()
	{
		QuestCustom_PostAkEvent questCustom_PostAkEvent = new QuestCustom_PostAkEvent();
		if (!AkEvent.IsNull)
		{
			questCustom_PostAkEvent.AkEventPath = AkEvent.LongPackageName;
		}
		return questCustom_PostAkEvent.ToByteArray();
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_QuestNode_PostAkEvent:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_QuestNode_PostAkEvent bED_QuestNode_PostAkEvent = GCHelper.Find<BED_QuestNode_PostAkEvent>(obj);
		string nodeDescriptionInCS_Implementation = bED_QuestNode_PostAkEvent.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_QuestNode_PostAkEvent");
		AkEvent_Offset = NativeReflection.GetPropertyOffset(intPtr, "AkEvent");
		AkEvent_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AkEvent", Classes.FSoftObjectProperty);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_QuestNode_PostAkEvent:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_QuestNode_PostAkEvent()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_QuestNode_PostAkEvent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_QuestNode_PostAkEvent));
	}
}
