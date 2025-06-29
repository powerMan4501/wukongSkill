using System;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("Log")]
[NotBlueprintable]
[USharpPath("/Script/b1-Managed.BED_ProcessStateNode_Log")]
public class BED_ProcessStateNode_Log : BED_ProcessStateNode
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

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[UProperty]
	[Category("Calliope")]
	[EditDefaultsOnly]
	[USharpPath("/Script/b1-Managed.BED_ProcessStateNode_Log:Message")]
	private string Message
	{
		get
		{
			CheckDestroyed();
			if (!Message_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessStateNode_Log:Message");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, Message_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Message_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessStateNode_Log:Message");
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
	[USharpPath("/Script/b1-Managed.BED_ProcessStateNode_Log:bPrintToScreen")]
	private bool bPrintToScreen
	{
		get
		{
			CheckDestroyed();
			if (!bPrintToScreen_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessStateNode_Log:bPrintToScreen");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bPrintToScreen_Offset), 0, bPrintToScreen_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bPrintToScreen_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessStateNode_Log:bPrintToScreen");
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
	[USharpPath("/Script/b1-Managed.BED_ProcessStateNode_Log:Duration")]
	private float Duration
	{
		get
		{
			CheckDestroyed();
			if (!Duration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessStateNode_Log:Duration");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Duration_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Duration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessStateNode_Log:Duration");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Duration_Offset), value);
			}
		}
	}

	[UProperty]
	[UMeta(MDProp.EditCondition, "bPrintToScreen")]
	[Category("Calliope")]
	[EditDefaultsOnly]
	[USharpPath("/Script/b1-Managed.BED_ProcessStateNode_Log:TextColor")]
	private FLinearColor TextColor
	{
		get
		{
			CheckDestroyed();
			if (!TextColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessStateNode_Log:TextColor");
				return default(FLinearColor);
			}
			return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(base.Address, TextColor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TextColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessStateNode_Log:TextColor");
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

	[USharpPath("/Script/b1-Managed.BED_ProcessStateNode_Log:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		return Message;
	}

	public override byte[] GetCustomData()
	{
		return new ProcessStateCustom_Log
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
		return "Process.State.Log";
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_ProcessStateNode_Log:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_ProcessStateNode_Log bED_ProcessStateNode_Log = GCHelper.Find<BED_ProcessStateNode_Log>(obj);
		string nodeDescriptionInCS_Implementation = bED_ProcessStateNode_Log.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_ProcessStateNode_Log");
		Message_Offset = NativeReflection.GetPropertyOffset(intPtr, "Message");
		Message_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Message", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref bPrintToScreen_PropertyAddress, intPtr, "bPrintToScreen");
		bPrintToScreen_Offset = NativeReflection.GetPropertyOffset(intPtr, "bPrintToScreen");
		bPrintToScreen_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bPrintToScreen", Classes.FBoolProperty);
		Duration_Offset = NativeReflection.GetPropertyOffset(intPtr, "Duration");
		Duration_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Duration", Classes.FFloatProperty);
		TextColor_Offset = NativeReflection.GetPropertyOffset(intPtr, "TextColor");
		TextColor_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TextColor", Classes.FStructProperty);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_ProcessStateNode_Log:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_ProcessStateNode_Log()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_ProcessStateNode_Log)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_ProcessStateNode_Log));
	}
}
