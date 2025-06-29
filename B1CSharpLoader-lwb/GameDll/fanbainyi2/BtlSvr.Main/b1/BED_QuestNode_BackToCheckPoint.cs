using System;
using b1.Plugins.Calliope;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("BackToCheckPoint")]
[UClass]
[Placeable(false)]
[USharpPath("/Script/b1-Managed.BED_QuestNode_BackToCheckPoint")]
public class BED_QuestNode_BackToCheckPoint : BED_QuestNode
{
	private static bool CheckPointId_IsValid;

	private static int CheckPointId_Offset;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("检查点标识")]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_BackToCheckPoint:CheckPointId")]
	public FName CheckPointId
	{
		get
		{
			CheckDestroyed();
			if (!CheckPointId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_BackToCheckPoint:CheckPointId");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, CheckPointId_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CheckPointId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_BackToCheckPoint:CheckPointId");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, CheckPointId_Offset), value);
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
		return B1CalliopeDef.QuestNode.BackToCheckPoint;
	}

	[USharpPath("/Script/b1-Managed.BED_QuestNode_BackToCheckPoint:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		return "主角传送到[" + CheckPointId.PlainName + "]检查点";
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_QuestNode_BackToCheckPoint:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_QuestNode_BackToCheckPoint bED_QuestNode_BackToCheckPoint = GCHelper.Find<BED_QuestNode_BackToCheckPoint>(obj);
		string nodeDescriptionInCS_Implementation = bED_QuestNode_BackToCheckPoint.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_QuestNode_BackToCheckPoint");
		CheckPointId_Offset = NativeReflection.GetPropertyOffset(intPtr, "CheckPointId");
		CheckPointId_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CheckPointId", Classes.FNameProperty);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_QuestNode_BackToCheckPoint:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_QuestNode_BackToCheckPoint()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_QuestNode_BackToCheckPoint)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_QuestNode_BackToCheckPoint));
	}
}
