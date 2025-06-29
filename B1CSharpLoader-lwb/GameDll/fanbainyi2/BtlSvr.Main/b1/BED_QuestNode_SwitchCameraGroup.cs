using System;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("Switch Camera Group")]
[UClass]
[USharpPath("/Script/b1-Managed.BED_QuestNode_SwitchCameraGroup")]
internal class BED_QuestNode_SwitchCameraGroup : BED_QuestNode
{
	private static bool CameraGroupID_IsValid;

	private static int CameraGroupID_Offset;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[Category("Settings")]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_SwitchCameraGroup:CameraGroupID")]
	public int CameraGroupID
	{
		get
		{
			CheckDestroyed();
			if (!CameraGroupID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_SwitchCameraGroup:CameraGroupID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, CameraGroupID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CameraGroupID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_SwitchCameraGroup:CameraGroupID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, CameraGroupID_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		CameraGroupID = -1;
		SetNodeCategory("Notifies");
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.QuestNode.SwitchCameraGroup;
	}

	public override byte[] GetCustomData()
	{
		return new QuestCustom_SwitchCameraGroup
		{
			CameraGroupId = CameraGroupID
		}.ToByteArray();
	}

	[USharpPath("/Script/b1-Managed.BED_QuestNode_SwitchCameraGroup:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		return $"Camera Group ID: {CameraGroupID}";
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_QuestNode_SwitchCameraGroup:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BED_QuestNode_SwitchCameraGroup bED_QuestNode_SwitchCameraGroup = GCHelper.Find<b1.BED_QuestNode_SwitchCameraGroup>(obj);
		string nodeDescriptionInCS_Implementation = bED_QuestNode_SwitchCameraGroup.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_QuestNode_SwitchCameraGroup");
		CameraGroupID_Offset = NativeReflection.GetPropertyOffset(intPtr, "CameraGroupID");
		CameraGroupID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CameraGroupID", Classes.FIntProperty);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_QuestNode_SwitchCameraGroup:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_QuestNode_SwitchCameraGroup()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BED_QuestNode_SwitchCameraGroup)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BED_QuestNode_SwitchCameraGroup));
	}
}
