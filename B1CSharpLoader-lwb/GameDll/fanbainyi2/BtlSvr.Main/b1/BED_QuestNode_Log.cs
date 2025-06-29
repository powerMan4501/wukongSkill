using System;
using b1.Plugins.Calliope;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("Log")]
[NotBlueprintable]
[UClass]
[USharpPath("/Script/b1-Managed.BED_QuestNode_Log")]
public class BED_QuestNode_Log : BED_QuestNode
{
	private static bool Message_IsValid;

	private static int Message_Offset;

	private static bool bPrintToScreen_IsValid;

	private static int bPrintToScreen_Offset;

	private static FFieldAddress bPrintToScreen_PropertyAddress;

	private static bool Duration_IsValid;

	private static int Duration_Offset;

	private static bool TextColor_IsValid;

	private static int TextColor_Offset;

	private static bool IsSupportViewType_IsValid;

	private static IntPtr IsSupportViewType_FunctionAddress;

	private static int IsSupportViewType_ParamsSize;

	private static bool IsSupportViewType_InViewType_IsValid;

	private static int IsSupportViewType_InViewType_Offset;

	private static FFieldAddress IsSupportViewType_InViewType_PropertyAddress;

	private static bool IsSupportViewType_ReturnValue_IsValid;

	private static int IsSupportViewType_ReturnValue_Offset;

	private static FFieldAddress IsSupportViewType_ReturnValue_PropertyAddress;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[UProperty]
	[EditDefaultsOnly]
	[Category("Calliope")]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_Log:Message")]
	private string Message
	{
		get
		{
			CheckDestroyed();
			if (!Message_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_Log:Message");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, Message_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Message_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_Log:Message");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, Message_Offset), value);
			}
		}
	}

	[UProperty]
	[EditDefaultsOnly]
	[Category("Calliope")]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_Log:bPrintToScreen")]
	private bool bPrintToScreen
	{
		get
		{
			CheckDestroyed();
			if (!bPrintToScreen_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_Log:bPrintToScreen");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bPrintToScreen_Offset), 0, bPrintToScreen_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bPrintToScreen_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_Log:bPrintToScreen");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bPrintToScreen_Offset), 0, bPrintToScreen_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditDefaultsOnly]
	[Category("Calliope")]
	[UMeta(MDProp.EditCondition, "bPrintToScreen")]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_Log:Duration")]
	private float Duration
	{
		get
		{
			CheckDestroyed();
			if (!Duration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_Log:Duration");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Duration_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Duration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_Log:Duration");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Duration_Offset), value);
			}
		}
	}

	[Category("Calliope")]
	[UMeta(MDProp.EditCondition, "bPrintToScreen")]
	[EditDefaultsOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_Log:TextColor")]
	private FLinearColor TextColor
	{
		get
		{
			CheckDestroyed();
			if (!TextColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_Log:TextColor");
				return default(FLinearColor);
			}
			return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(base.Address, TextColor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TextColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_Log:TextColor");
			}
			else
			{
				BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(base.Address, TextColor_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		Message = "Log!";
		bPrintToScreen = true;
		Duration = 5f;
		TextColor = FLinearColor.Yellow;
		SetNodeCategory("Utils");
	}

	[USharpPath("/Script/b1-Managed.BED_QuestNode_Log:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		return Message;
	}

	public override byte[] GetCustomData()
	{
		return new QuestCustom_Log
		{
			Message = Message,
			IsPrintToScreen = bPrintToScreen,
			Duration = Duration,
			TextColorR = TextColor.R,
			TextColorG = TextColor.G,
			TextColorB = TextColor.B,
			TextColorA = TextColor.A
		}.ToByteArray();
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.QuestNode.Log;
	}

	[USharpPath("/Script/b1-Managed.BED_QuestNode_Log:IsSupportViewType")]
	protected override bool IsSupportViewType_Implementation(ECalliopeViewType InViewType)
	{
		if (InViewType == ECalliopeViewType.Quest || InViewType == ECalliopeViewType.Task)
		{
			return true;
		}
		return false;
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_QuestNode_Log:IsSupportViewType")]
	private static void IsSupportViewType__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_QuestNode_Log bED_QuestNode_Log = GCHelper.Find<BED_QuestNode_Log>(obj);
		ECalliopeViewType inViewType = EnumMarshaler<ECalliopeViewType>.FromNative(IntPtr.Add(buffer, IsSupportViewType_InViewType_Offset), 0, IsSupportViewType_InViewType_PropertyAddress.Address);
		bool value = bED_QuestNode_Log.IsSupportViewType_Implementation(inViewType);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, IsSupportViewType_ReturnValue_Offset), 0, IsSupportViewType_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_QuestNode_Log:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_QuestNode_Log bED_QuestNode_Log = GCHelper.Find<BED_QuestNode_Log>(obj);
		string nodeDescriptionInCS_Implementation = bED_QuestNode_Log.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_QuestNode_Log");
		Message_Offset = NativeReflection.GetPropertyOffset(intPtr, "Message");
		Message_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Message", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref bPrintToScreen_PropertyAddress, intPtr, "bPrintToScreen");
		bPrintToScreen_Offset = NativeReflection.GetPropertyOffset(intPtr, "bPrintToScreen");
		bPrintToScreen_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bPrintToScreen", Classes.FBoolProperty);
		Duration_Offset = NativeReflection.GetPropertyOffset(intPtr, "Duration");
		Duration_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Duration", Classes.FFloatProperty);
		TextColor_Offset = NativeReflection.GetPropertyOffset(intPtr, "TextColor");
		TextColor_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TextColor", Classes.FStructProperty);
		IsSupportViewType_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsSupportViewType");
		IsSupportViewType_ParamsSize = NativeReflection.GetFunctionParamsSize(IsSupportViewType_FunctionAddress);
		NativeReflection.GetPropertyRef(ref IsSupportViewType_InViewType_PropertyAddress, IsSupportViewType_FunctionAddress, "InViewType");
		IsSupportViewType_InViewType_Offset = NativeReflection.GetPropertyOffset(IsSupportViewType_FunctionAddress, "InViewType");
		IsSupportViewType_InViewType_IsValid = NativeReflection.ValidatePropertyClass(IsSupportViewType_FunctionAddress, "InViewType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref IsSupportViewType_ReturnValue_PropertyAddress, IsSupportViewType_FunctionAddress, "ReturnValue");
		IsSupportViewType_ReturnValue_Offset = NativeReflection.GetPropertyOffset(IsSupportViewType_FunctionAddress, "ReturnValue");
		IsSupportViewType_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(IsSupportViewType_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsSupportViewType_IsValid = IsSupportViewType_FunctionAddress != IntPtr.Zero && IsSupportViewType_InViewType_IsValid && IsSupportViewType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_QuestNode_Log:IsSupportViewType", IsSupportViewType_IsValid);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_QuestNode_Log:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_QuestNode_Log()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_QuestNode_Log)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_QuestNode_Log));
	}
}
