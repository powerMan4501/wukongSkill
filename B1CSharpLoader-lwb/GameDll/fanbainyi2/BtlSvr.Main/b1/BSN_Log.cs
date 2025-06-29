using System;
using b1.Plugins.Calliope;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("Log")]
[USharpPath("/Script/b1-Managed.BSN_Log")]
public class BSN_Log : UMovieSceneCalliopeNotifySection
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

	private static bool OnNotify_IsValid;

	private static IntPtr OnNotify_FunctionAddress;

	private static int OnNotify_ParamsSize;

	private static bool OnNotify_InPlayer_IsValid;

	private static int OnNotify_InPlayer_Offset;

	private static bool OnNotify_InStatus_IsValid;

	private static int OnNotify_InStatus_Offset;

	private static bool OnNotify_bInBackwards_IsValid;

	private static int OnNotify_bInBackwards_Offset;

	private static FFieldAddress OnNotify_bInBackwards_PropertyAddress;

	[EditDefaultsOnly]
	[Category("Log")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BSN_Log:Message")]
	private string Message
	{
		get
		{
			CheckDestroyed();
			if (!Message_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BSN_Log:Message");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, Message_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Message_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BSN_Log:Message");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, Message_Offset), value);
			}
		}
	}

	[EditDefaultsOnly]
	[UProperty]
	[Category("Log")]
	[USharpPath("/Script/b1-Managed.BSN_Log:bPrintToScreen")]
	private bool bPrintToScreen
	{
		get
		{
			CheckDestroyed();
			if (!bPrintToScreen_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BSN_Log:bPrintToScreen");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bPrintToScreen_Offset), 0, bPrintToScreen_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bPrintToScreen_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BSN_Log:bPrintToScreen");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bPrintToScreen_Offset), 0, bPrintToScreen_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditDefaultsOnly]
	[Category("Log")]
	[UMeta(MDProp.EditCondition, "bPrintToScreen")]
	[USharpPath("/Script/b1-Managed.BSN_Log:Duration")]
	private float Duration
	{
		get
		{
			CheckDestroyed();
			if (!Duration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BSN_Log:Duration");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Duration_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Duration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BSN_Log:Duration");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Duration_Offset), value);
			}
		}
	}

	[UProperty]
	[EditDefaultsOnly]
	[UMeta(MDProp.EditCondition, "bPrintToScreen")]
	[Category("Log")]
	[USharpPath("/Script/b1-Managed.BSN_Log:TextColor")]
	private FLinearColor TextColor
	{
		get
		{
			CheckDestroyed();
			if (!TextColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BSN_Log:TextColor");
				return default(FLinearColor);
			}
			return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(base.Address, TextColor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TextColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BSN_Log:TextColor");
			}
			else
			{
				BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(base.Address, TextColor_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BSN_Log:OnNotify")]
	protected override void OnNotify_Implementation(UCalliopeLevelSequencePlayer InPlayer, int InStatus, bool bInBackwards)
	{
		UGSE_EngineFuncLib.LogDbgWithColor(Message, bPrintToScreen, Duration, TextColor.ToFColor(srgb: true), -1);
	}

	[UFunctionInvoker("/Script/b1-Managed.BSN_Log:OnNotify")]
	private static void OnNotify__Invoker(IntPtr buffer, IntPtr obj)
	{
		BSN_Log bSN_Log = GCHelper.Find<BSN_Log>(obj);
		UCalliopeLevelSequencePlayer inPlayer = UObjectMarshaler<UCalliopeLevelSequencePlayer>.FromNative(IntPtr.Add(buffer, OnNotify_InPlayer_Offset));
		int inStatus = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, OnNotify_InStatus_Offset));
		bool bInBackwards = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnNotify_bInBackwards_Offset), 0, OnNotify_bInBackwards_PropertyAddress.Address);
		bSN_Log.OnNotify_Implementation(inPlayer, inStatus, bInBackwards);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BSN_Log");
		Message_Offset = NativeReflection.GetPropertyOffset(intPtr, "Message");
		Message_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Message", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref bPrintToScreen_PropertyAddress, intPtr, "bPrintToScreen");
		bPrintToScreen_Offset = NativeReflection.GetPropertyOffset(intPtr, "bPrintToScreen");
		bPrintToScreen_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bPrintToScreen", Classes.FBoolProperty);
		Duration_Offset = NativeReflection.GetPropertyOffset(intPtr, "Duration");
		Duration_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Duration", Classes.FFloatProperty);
		TextColor_Offset = NativeReflection.GetPropertyOffset(intPtr, "TextColor");
		TextColor_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TextColor", Classes.FStructProperty);
		OnNotify_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnNotify");
		OnNotify_ParamsSize = NativeReflection.GetFunctionParamsSize(OnNotify_FunctionAddress);
		OnNotify_InPlayer_Offset = NativeReflection.GetPropertyOffset(OnNotify_FunctionAddress, "InPlayer");
		OnNotify_InPlayer_IsValid = NativeReflection.ValidatePropertyClass(OnNotify_FunctionAddress, "InPlayer", Classes.FObjectProperty);
		OnNotify_InStatus_Offset = NativeReflection.GetPropertyOffset(OnNotify_FunctionAddress, "InStatus");
		OnNotify_InStatus_IsValid = NativeReflection.ValidatePropertyClass(OnNotify_FunctionAddress, "InStatus", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref OnNotify_bInBackwards_PropertyAddress, OnNotify_FunctionAddress, "bInBackwards");
		OnNotify_bInBackwards_Offset = NativeReflection.GetPropertyOffset(OnNotify_FunctionAddress, "bInBackwards");
		OnNotify_bInBackwards_IsValid = NativeReflection.ValidatePropertyClass(OnNotify_FunctionAddress, "bInBackwards", Classes.FBoolProperty);
		OnNotify_IsValid = OnNotify_FunctionAddress != IntPtr.Zero && OnNotify_InPlayer_IsValid && OnNotify_InStatus_IsValid && OnNotify_bInBackwards_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BSN_Log:OnNotify", OnNotify_IsValid);
	}

	static BSN_Log()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BSN_Log)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BSN_Log));
	}
}
