using System;
using b1.Plugins.Calliope;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("Quit Game")]
[UClass]
[USharpPath("/Script/b1-Managed.BED_QuestNode_QuitGame")]
internal class BED_QuestNode_QuitGame : BED_QuestNode
{
	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	public override void Initialize(FObjectInitializer Initializer)
	{
		SetNodeCategory("Auto Test");
		SetNodeStyle(ECalliopeNodeStyle.Default);
		base.OutputPins.Clear();
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.QuestNode.QuitGame;
	}

	public override byte[] GetCustomData()
	{
		return new byte[0];
	}

	[USharpPath("/Script/b1-Managed.BED_QuestNode_QuitGame:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		return "";
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_QuestNode_QuitGame:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BED_QuestNode_QuitGame bED_QuestNode_QuitGame = GCHelper.Find<b1.BED_QuestNode_QuitGame>(obj);
		string nodeDescriptionInCS_Implementation = bED_QuestNode_QuitGame.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BED_QuestNode_QuitGame");
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_QuestNode_QuitGame:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_QuestNode_QuitGame()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BED_QuestNode_QuitGame)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BED_QuestNode_QuitGame));
	}
}
