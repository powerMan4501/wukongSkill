using System;
using System.Collections.Generic;
using System.Linq;
using b1.BGW;
using b1.Plugins.GSInput;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.EnhancedInput;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.InputActionEventReceiver")]
public class UInputActionEventReceiver : UGSInputTargetBinding
{
	private static bool FetchDebugInfo_IsValid;

	private static IntPtr FetchDebugInfo_FunctionAddress;

	private static int FetchDebugInfo_ParamsSize;

	private static bool FetchDebugInfo_DebugLines_IsValid;

	private static int FetchDebugInfo_DebugLines_Offset;

	private static FFieldAddress FetchDebugInfo_DebugLines_PropertyAddress;

	private static bool FetchDebugInfo_DebugColors_IsValid;

	private static int FetchDebugInfo_DebugColors_Offset;

	private static FFieldAddress FetchDebugInfo_DebugColors_PropertyAddress;

	private static bool InputActionTrigger_IsValid;

	private static IntPtr InputActionTrigger_FunctionAddress;

	private static int InputActionTrigger_ParamsSize;

	private static bool InputActionTrigger_ActionName_IsValid;

	private static int InputActionTrigger_ActionName_Offset;

	private static FFieldAddress InputActionTrigger_ActionName_PropertyAddress;

	private static bool InputActionTrigger_TriggerEvent_IsValid;

	private static int InputActionTrigger_TriggerEvent_Offset;

	private static FFieldAddress InputActionTrigger_TriggerEvent_PropertyAddress;

	private static bool InputActionTrigger_InputActionValueType_IsValid;

	private static int InputActionTrigger_InputActionValueType_Offset;

	private static FFieldAddress InputActionTrigger_InputActionValueType_PropertyAddress;

	private static bool InputActionTrigger_InputActionValue_IsValid;

	private static int InputActionTrigger_InputActionValue_Offset;

	private static FFieldAddress InputActionTrigger_InputActionValue_PropertyAddress;

	private static bool TryGetInlineTexture_IsValid;

	private static IntPtr TryGetInlineTexture_FunctionAddress;

	private static int TryGetInlineTexture_ParamsSize;

	private static bool TryGetInlineTexture_ActionTag_IsValid;

	private static int TryGetInlineTexture_ActionTag_Offset;

	private static FFieldAddress TryGetInlineTexture_ActionTag_PropertyAddress;

	private static bool TryGetInlineTexture_MarkUpType_IsValid;

	private static int TryGetInlineTexture_MarkUpType_Offset;

	private static FFieldAddress TryGetInlineTexture_MarkUpType_PropertyAddress;

	private static bool TryGetInlineTexture_InlineTexture_IsValid;

	private static int TryGetInlineTexture_InlineTexture_Offset;

	private static bool TryGetInlineTexture_InlineChordTexture_IsValid;

	private static int TryGetInlineTexture_InlineChordTexture_Offset;

	private static bool TryGetInlineTexture_ConnectTexture_IsValid;

	private static int TryGetInlineTexture_ConnectTexture_Offset;

	private static bool TryGetInlineTexture_ReturnValue_IsValid;

	private static int TryGetInlineTexture_ReturnValue_Offset;

	private static FFieldAddress TryGetInlineTexture_ReturnValue_PropertyAddress;

	private static bool IsInputDebuggerOpen_IsValid;

	private static IntPtr IsInputDebuggerOpen_FunctionAddress;

	private static int IsInputDebuggerOpen_ParamsSize;

	private static bool IsInputDebuggerOpen_ReturnValue_IsValid;

	private static int IsInputDebuggerOpen_ReturnValue_Offset;

	private static FFieldAddress IsInputDebuggerOpen_ReturnValue_PropertyAddress;

	private static bool TryGetTextureByAction_IsValid;

	private static IntPtr TryGetTextureByAction_FunctionAddress;

	private static int TryGetTextureByAction_ParamsSize;

	private static bool TryGetTextureByAction_InputAction_IsValid;

	private static int TryGetTextureByAction_InputAction_Offset;

	private static bool TryGetTextureByAction_Offset_IsValid;

	private static int TryGetTextureByAction_Offset_Offset;

	private static bool TryGetTextureByAction_Texture_IsValid;

	private static int TryGetTextureByAction_Texture_Offset;

	private static bool TryGetTextureByAction_BgType_IsValid;

	private static int TryGetTextureByAction_BgType_Offset;

	private static bool TryGetTextureByAction_ChordOffset_IsValid;

	private static int TryGetTextureByAction_ChordOffset_Offset;

	private static bool TryGetTextureByAction_ChordTexture_IsValid;

	private static int TryGetTextureByAction_ChordTexture_Offset;

	private static bool TryGetTextureByAction_ConnectTexture_IsValid;

	private static int TryGetTextureByAction_ConnectTexture_Offset;

	private static bool TryGetTextureByAction_NoneTexture_IsValid;

	private static int TryGetTextureByAction_NoneTexture_Offset;

	private static bool TryGetTextureByAction_ReturnValue_IsValid;

	private static int TryGetTextureByAction_ReturnValue_Offset;

	private static FFieldAddress TryGetTextureByAction_ReturnValue_PropertyAddress;

	private static bool TryGetTextureInfoByName_IsValid;

	private static IntPtr TryGetTextureInfoByName_FunctionAddress;

	private static int TryGetTextureInfoByName_ParamsSize;

	private static bool TryGetTextureInfoByName_Name_IsValid;

	private static int TryGetTextureInfoByName_Name_Offset;

	private static FFieldAddress TryGetTextureInfoByName_Name_PropertyAddress;

	private static bool TryGetTextureInfoByName_Offset_IsValid;

	private static int TryGetTextureInfoByName_Offset_Offset;

	private static bool TryGetTextureInfoByName_BgType_IsValid;

	private static int TryGetTextureInfoByName_BgType_Offset;

	private static bool TryGetTextureInfoByName_ReturnValue_IsValid;

	private static int TryGetTextureInfoByName_ReturnValue_Offset;

	private static FFieldAddress TryGetTextureInfoByName_ReturnValue_PropertyAddress;

	private static bool GetRichTextInlineIconInfo_IsValid;

	private static IntPtr GetRichTextInlineIconInfo_FunctionAddress;

	private static int GetRichTextInlineIconInfo_ParamsSize;

	private static bool GetRichTextInlineIconInfo_BasePixelHeight_IsValid;

	private static int GetRichTextInlineIconInfo_BasePixelHeight_Offset;

	private static bool GetRichTextInlineIconInfo_BaselineOffset_IsValid;

	private static int GetRichTextInlineIconInfo_BaselineOffset_Offset;

	private static bool GetRichTextInlineIconInfo_ConnectIconOffset_IsValid;

	private static int GetRichTextInlineIconInfo_ConnectIconOffset_Offset;

	private static bool PostApplicationActivationChanged_IsValid;

	private static IntPtr PostApplicationActivationChanged_FunctionAddress;

	private static int PostApplicationActivationChanged_ParamsSize;

	private static bool PostApplicationActivationChanged_IsActive_IsValid;

	private static int PostApplicationActivationChanged_IsActive_Offset;

	private static FFieldAddress PostApplicationActivationChanged_IsActive_PropertyAddress;

	private BGW_EnhancedInputMgrV2 InputMgr => GetOuter() as BGW_EnhancedInputMgrV2;

	private FInputActionProcessor InputActionProcessor => InputMgr?.InputActionProcessor;

	private FInputIconTracker InputIconTracker => InputMgr?.InputIconTracker;

	private FInputDebugTracker InputDebugTracker => InputMgr?.InputDebugTracker;

	private FInputTypeTracker InputTypeTracker => InputMgr?.InputTypeTracker;

	[USharpPath("/Script/b1-Managed.InputActionEventReceiver:InputActionTrigger")]
	protected override void InputActionTrigger_Implementation(string ActionName, ETriggerEvent TriggerEvent, EInputActionValueType InputActionValueType, FVector InputActionValue)
	{
		InputActionProcessor?.InputActionTrigger(ActionName, TriggerEvent, InputActionValueType, InputActionValue);
	}

	[USharpPath("/Script/b1-Managed.InputActionEventReceiver:TryGetTextureByAction")]
	protected override bool TryGetTextureByAction_Implementation(UInputAction InputAction, out float Offset, out UTexture2D Texture, out int BgType, out float ChordOffset, out UTexture2D ChordTexture, out UTexture2D ConnectTexture, out UTexture2D NoneTexture)
	{
		return InputIconTracker.TryGetTextureByAction(InputAction, out Offset, out Texture, out BgType, out ChordOffset, out ChordTexture, out ConnectTexture, out NoneTexture);
	}

	[USharpPath("/Script/b1-Managed.InputActionEventReceiver:TryGetTextureInfoByName")]
	protected override bool TryGetTextureInfoByName_Implementation(string Name, out float Offset, out int BgType)
	{
		return InputIconTracker.TryGetTextureInfoByName(Name, out Offset, out BgType);
	}

	[USharpPath("/Script/b1-Managed.InputActionEventReceiver:TryGetInlineTexture")]
	protected override bool TryGetInlineTexture_Implementation(string ActionTag, EGSInputRichTextMarkUpType MarkUpType, out UTexture2D InlineTexture, out UTexture2D InlineChordTexture, out UTexture2D ConnectTexture)
	{
		return InputIconTracker.TryGetInlineIcon(ActionTag, MarkUpType, out InlineTexture, out InlineChordTexture, out ConnectTexture);
	}

	[USharpPath("/Script/b1-Managed.InputActionEventReceiver:GetRichTextInlineIconInfo")]
	protected override void GetRichTextInlineIconInfo_Implementation(out int BasePixelHeight, out int BaselineOffset, out int ConnectIconOffset)
	{
		BGWUIConfigDataAsset uIConfigDataAsset = BGW_PreloadAssetMgr.Get(this).UIConfigDataAsset;
		BasePixelHeight = uIConfigDataAsset.BasePixelHeight;
		BaselineOffset = uIConfigDataAsset.BaselineOffset;
		ConnectIconOffset = uIConfigDataAsset.ConnectIconOffset;
	}

	[USharpPath("/Script/b1-Managed.InputActionEventReceiver:IsInputDebuggerOpen")]
	protected override bool IsInputDebuggerOpen_Implementation()
	{
		return FInputDebugTracker.IsDebugUIOpen;
	}

	[USharpPath("/Script/b1-Managed.InputActionEventReceiver:PostApplicationActivationChanged")]
	protected override void PostApplicationActivationChanged_Implementation(bool IsActive)
	{
		InputActionProcessor?.OnPostApplicationActivationChanged(IsActive);
		InputTypeTracker?.OnPostApplicationActivationChanged(IsActive);
	}

	[USharpPath("/Script/b1-Managed.InputActionEventReceiver:FetchDebugInfo")]
	protected override void FetchDebugInfo_Implementation(out List<string> DebugLines, out List<FColor> DebugColors)
	{
		List<FDisplayLine> DisplayLines = new List<FDisplayLine>();
		InputDebugTracker?.FetchDebugInfo(out DisplayLines);
		DebugLines = DisplayLines.Select((FDisplayLine item) => item.Line).ToList();
		DebugColors = DisplayLines.Select((FDisplayLine item) => item.Color).ToList();
	}

	[UFunctionInvoker("/Script/b1-Managed.InputActionEventReceiver:FetchDebugInfo")]
	private static void FetchDebugInfo__Invoker(IntPtr buffer, IntPtr obj)
	{
		UInputActionEventReceiver uInputActionEventReceiver = GCHelper.Find<UInputActionEventReceiver>(obj);
		TArrayCopyMarshaler<string> tArrayCopyMarshaler = new TArrayCopyMarshaler<string>(1, FetchDebugInfo_DebugLines_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative);
		List<string> DebugLines = tArrayCopyMarshaler.FromNative(IntPtr.Add(buffer, FetchDebugInfo_DebugLines_Offset));
		TArrayCopyMarshaler<FColor> tArrayCopyMarshaler2 = new TArrayCopyMarshaler<FColor>(1, FetchDebugInfo_DebugColors_PropertyAddress, CachedMarshalingDelegates<FColor, BlittableTypeMarshaler<FColor>>.FromNative, CachedMarshalingDelegates<FColor, BlittableTypeMarshaler<FColor>>.ToNative);
		List<FColor> DebugColors = tArrayCopyMarshaler2.FromNative(IntPtr.Add(buffer, FetchDebugInfo_DebugColors_Offset));
		uInputActionEventReceiver.FetchDebugInfo_Implementation(out DebugLines, out DebugColors);
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, FetchDebugInfo_DebugLines_Offset), DebugLines);
		tArrayCopyMarshaler2.ToNative(IntPtr.Add(buffer, FetchDebugInfo_DebugColors_Offset), DebugColors);
	}

	[UFunctionInvoker("/Script/b1-Managed.InputActionEventReceiver:InputActionTrigger")]
	private static void InputActionTrigger__Invoker(IntPtr buffer, IntPtr obj)
	{
		UInputActionEventReceiver uInputActionEventReceiver = GCHelper.Find<UInputActionEventReceiver>(obj);
		string actionName = FStringMarshaler.FromNative(IntPtr.Add(buffer, InputActionTrigger_ActionName_Offset));
		ETriggerEvent triggerEvent = EnumMarshaler<ETriggerEvent>.FromNative(IntPtr.Add(buffer, InputActionTrigger_TriggerEvent_Offset), 0, InputActionTrigger_TriggerEvent_PropertyAddress.Address);
		EInputActionValueType inputActionValueType = EnumMarshaler<EInputActionValueType>.FromNative(IntPtr.Add(buffer, InputActionTrigger_InputActionValueType_Offset), 0, InputActionTrigger_InputActionValueType_PropertyAddress.Address);
		FVector inputActionValue = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(buffer, InputActionTrigger_InputActionValue_Offset));
		uInputActionEventReceiver.InputActionTrigger_Implementation(actionName, triggerEvent, inputActionValueType, inputActionValue);
	}

	[UFunctionInvoker("/Script/b1-Managed.InputActionEventReceiver:TryGetInlineTexture")]
	private static void TryGetInlineTexture__Invoker(IntPtr buffer, IntPtr obj)
	{
		UInputActionEventReceiver uInputActionEventReceiver = GCHelper.Find<UInputActionEventReceiver>(obj);
		string actionTag = FStringMarshaler.FromNative(IntPtr.Add(buffer, TryGetInlineTexture_ActionTag_Offset));
		EGSInputRichTextMarkUpType markUpType = EnumMarshaler<EGSInputRichTextMarkUpType>.FromNative(IntPtr.Add(buffer, TryGetInlineTexture_MarkUpType_Offset), 0, TryGetInlineTexture_MarkUpType_PropertyAddress.Address);
		UTexture2D InlineTexture;
		UTexture2D InlineChordTexture;
		UTexture2D ConnectTexture;
		bool value = uInputActionEventReceiver.TryGetInlineTexture_Implementation(actionTag, markUpType, out InlineTexture, out InlineChordTexture, out ConnectTexture);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, TryGetInlineTexture_ReturnValue_Offset), 0, TryGetInlineTexture_ReturnValue_PropertyAddress.Address, value);
		UObjectMarshaler<UTexture2D>.ToNative(IntPtr.Add(buffer, TryGetInlineTexture_InlineTexture_Offset), InlineTexture);
		UObjectMarshaler<UTexture2D>.ToNative(IntPtr.Add(buffer, TryGetInlineTexture_InlineChordTexture_Offset), InlineChordTexture);
		UObjectMarshaler<UTexture2D>.ToNative(IntPtr.Add(buffer, TryGetInlineTexture_ConnectTexture_Offset), ConnectTexture);
	}

	[UFunctionInvoker("/Script/b1-Managed.InputActionEventReceiver:IsInputDebuggerOpen")]
	private static void IsInputDebuggerOpen__Invoker(IntPtr buffer, IntPtr obj)
	{
		UInputActionEventReceiver uInputActionEventReceiver = GCHelper.Find<UInputActionEventReceiver>(obj);
		bool value = uInputActionEventReceiver.IsInputDebuggerOpen_Implementation();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, IsInputDebuggerOpen_ReturnValue_Offset), 0, IsInputDebuggerOpen_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.InputActionEventReceiver:TryGetTextureByAction")]
	private static void TryGetTextureByAction__Invoker(IntPtr buffer, IntPtr obj)
	{
		UInputActionEventReceiver uInputActionEventReceiver = GCHelper.Find<UInputActionEventReceiver>(obj);
		UInputAction inputAction = UObjectMarshaler<UInputAction>.FromNative(IntPtr.Add(buffer, TryGetTextureByAction_InputAction_Offset));
		float Offset;
		UTexture2D Texture;
		int BgType;
		float ChordOffset;
		UTexture2D ChordTexture;
		UTexture2D ConnectTexture;
		UTexture2D NoneTexture;
		bool value = uInputActionEventReceiver.TryGetTextureByAction_Implementation(inputAction, out Offset, out Texture, out BgType, out ChordOffset, out ChordTexture, out ConnectTexture, out NoneTexture);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, TryGetTextureByAction_ReturnValue_Offset), 0, TryGetTextureByAction_ReturnValue_PropertyAddress.Address, value);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(buffer, TryGetTextureByAction_Offset_Offset), Offset);
		UObjectMarshaler<UTexture2D>.ToNative(IntPtr.Add(buffer, TryGetTextureByAction_Texture_Offset), Texture);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(buffer, TryGetTextureByAction_BgType_Offset), BgType);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(buffer, TryGetTextureByAction_ChordOffset_Offset), ChordOffset);
		UObjectMarshaler<UTexture2D>.ToNative(IntPtr.Add(buffer, TryGetTextureByAction_ChordTexture_Offset), ChordTexture);
		UObjectMarshaler<UTexture2D>.ToNative(IntPtr.Add(buffer, TryGetTextureByAction_ConnectTexture_Offset), ConnectTexture);
		UObjectMarshaler<UTexture2D>.ToNative(IntPtr.Add(buffer, TryGetTextureByAction_NoneTexture_Offset), NoneTexture);
	}

	[UFunctionInvoker("/Script/b1-Managed.InputActionEventReceiver:TryGetTextureInfoByName")]
	private static void TryGetTextureInfoByName__Invoker(IntPtr buffer, IntPtr obj)
	{
		UInputActionEventReceiver uInputActionEventReceiver = GCHelper.Find<UInputActionEventReceiver>(obj);
		string name = FStringMarshaler.FromNative(IntPtr.Add(buffer, TryGetTextureInfoByName_Name_Offset));
		float Offset;
		int BgType;
		bool value = uInputActionEventReceiver.TryGetTextureInfoByName_Implementation(name, out Offset, out BgType);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, TryGetTextureInfoByName_ReturnValue_Offset), 0, TryGetTextureInfoByName_ReturnValue_PropertyAddress.Address, value);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(buffer, TryGetTextureInfoByName_Offset_Offset), Offset);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(buffer, TryGetTextureInfoByName_BgType_Offset), BgType);
	}

	[UFunctionInvoker("/Script/b1-Managed.InputActionEventReceiver:GetRichTextInlineIconInfo")]
	private static void GetRichTextInlineIconInfo__Invoker(IntPtr buffer, IntPtr obj)
	{
		UInputActionEventReceiver uInputActionEventReceiver = GCHelper.Find<UInputActionEventReceiver>(obj);
		uInputActionEventReceiver.GetRichTextInlineIconInfo_Implementation(out var BasePixelHeight, out var BaselineOffset, out var ConnectIconOffset);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(buffer, GetRichTextInlineIconInfo_BasePixelHeight_Offset), BasePixelHeight);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(buffer, GetRichTextInlineIconInfo_BaselineOffset_Offset), BaselineOffset);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(buffer, GetRichTextInlineIconInfo_ConnectIconOffset_Offset), ConnectIconOffset);
	}

	[UFunctionInvoker("/Script/b1-Managed.InputActionEventReceiver:PostApplicationActivationChanged")]
	private static void PostApplicationActivationChanged__Invoker(IntPtr buffer, IntPtr obj)
	{
		UInputActionEventReceiver uInputActionEventReceiver = GCHelper.Find<UInputActionEventReceiver>(obj);
		bool isActive = BoolMarshaler.FromNative(IntPtr.Add(buffer, PostApplicationActivationChanged_IsActive_Offset), 0, PostApplicationActivationChanged_IsActive_PropertyAddress.Address);
		uInputActionEventReceiver.PostApplicationActivationChanged_Implementation(isActive);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.InputActionEventReceiver");
		FetchDebugInfo_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "FetchDebugInfo");
		FetchDebugInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(FetchDebugInfo_FunctionAddress);
		NativeReflection.GetPropertyRef(ref FetchDebugInfo_DebugLines_PropertyAddress, FetchDebugInfo_FunctionAddress, "DebugLines");
		FetchDebugInfo_DebugLines_Offset = NativeReflection.GetPropertyOffset(FetchDebugInfo_FunctionAddress, "DebugLines");
		FetchDebugInfo_DebugLines_IsValid = NativeReflection.ValidatePropertyClass(FetchDebugInfo_FunctionAddress, "DebugLines", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref FetchDebugInfo_DebugColors_PropertyAddress, FetchDebugInfo_FunctionAddress, "DebugColors");
		FetchDebugInfo_DebugColors_Offset = NativeReflection.GetPropertyOffset(FetchDebugInfo_FunctionAddress, "DebugColors");
		FetchDebugInfo_DebugColors_IsValid = NativeReflection.ValidatePropertyClass(FetchDebugInfo_FunctionAddress, "DebugColors", Classes.FArrayProperty);
		FetchDebugInfo_IsValid = FetchDebugInfo_FunctionAddress != IntPtr.Zero && FetchDebugInfo_DebugLines_IsValid && FetchDebugInfo_DebugColors_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.InputActionEventReceiver:FetchDebugInfo", FetchDebugInfo_IsValid);
		InputActionTrigger_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "InputActionTrigger");
		InputActionTrigger_ParamsSize = NativeReflection.GetFunctionParamsSize(InputActionTrigger_FunctionAddress);
		NativeReflection.GetPropertyRef(ref InputActionTrigger_ActionName_PropertyAddress, InputActionTrigger_FunctionAddress, "ActionName");
		InputActionTrigger_ActionName_Offset = NativeReflection.GetPropertyOffset(InputActionTrigger_FunctionAddress, "ActionName");
		InputActionTrigger_ActionName_IsValid = NativeReflection.ValidatePropertyClass(InputActionTrigger_FunctionAddress, "ActionName", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref InputActionTrigger_TriggerEvent_PropertyAddress, InputActionTrigger_FunctionAddress, "TriggerEvent");
		InputActionTrigger_TriggerEvent_Offset = NativeReflection.GetPropertyOffset(InputActionTrigger_FunctionAddress, "TriggerEvent");
		InputActionTrigger_TriggerEvent_IsValid = NativeReflection.ValidatePropertyClass(InputActionTrigger_FunctionAddress, "TriggerEvent", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref InputActionTrigger_InputActionValueType_PropertyAddress, InputActionTrigger_FunctionAddress, "InputActionValueType");
		InputActionTrigger_InputActionValueType_Offset = NativeReflection.GetPropertyOffset(InputActionTrigger_FunctionAddress, "InputActionValueType");
		InputActionTrigger_InputActionValueType_IsValid = NativeReflection.ValidatePropertyClass(InputActionTrigger_FunctionAddress, "InputActionValueType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref InputActionTrigger_InputActionValue_PropertyAddress, InputActionTrigger_FunctionAddress, "InputActionValue");
		InputActionTrigger_InputActionValue_Offset = NativeReflection.GetPropertyOffset(InputActionTrigger_FunctionAddress, "InputActionValue");
		InputActionTrigger_InputActionValue_IsValid = NativeReflection.ValidatePropertyClass(InputActionTrigger_FunctionAddress, "InputActionValue", Classes.FStructProperty);
		InputActionTrigger_IsValid = InputActionTrigger_FunctionAddress != IntPtr.Zero && InputActionTrigger_ActionName_IsValid && InputActionTrigger_TriggerEvent_IsValid && InputActionTrigger_InputActionValueType_IsValid && InputActionTrigger_InputActionValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.InputActionEventReceiver:InputActionTrigger", InputActionTrigger_IsValid);
		TryGetInlineTexture_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "TryGetInlineTexture");
		TryGetInlineTexture_ParamsSize = NativeReflection.GetFunctionParamsSize(TryGetInlineTexture_FunctionAddress);
		NativeReflection.GetPropertyRef(ref TryGetInlineTexture_ActionTag_PropertyAddress, TryGetInlineTexture_FunctionAddress, "ActionTag");
		TryGetInlineTexture_ActionTag_Offset = NativeReflection.GetPropertyOffset(TryGetInlineTexture_FunctionAddress, "ActionTag");
		TryGetInlineTexture_ActionTag_IsValid = NativeReflection.ValidatePropertyClass(TryGetInlineTexture_FunctionAddress, "ActionTag", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref TryGetInlineTexture_MarkUpType_PropertyAddress, TryGetInlineTexture_FunctionAddress, "MarkUpType");
		TryGetInlineTexture_MarkUpType_Offset = NativeReflection.GetPropertyOffset(TryGetInlineTexture_FunctionAddress, "MarkUpType");
		TryGetInlineTexture_MarkUpType_IsValid = NativeReflection.ValidatePropertyClass(TryGetInlineTexture_FunctionAddress, "MarkUpType", Classes.FEnumProperty);
		TryGetInlineTexture_InlineTexture_Offset = NativeReflection.GetPropertyOffset(TryGetInlineTexture_FunctionAddress, "InlineTexture");
		TryGetInlineTexture_InlineTexture_IsValid = NativeReflection.ValidatePropertyClass(TryGetInlineTexture_FunctionAddress, "InlineTexture", Classes.FObjectProperty);
		TryGetInlineTexture_InlineChordTexture_Offset = NativeReflection.GetPropertyOffset(TryGetInlineTexture_FunctionAddress, "InlineChordTexture");
		TryGetInlineTexture_InlineChordTexture_IsValid = NativeReflection.ValidatePropertyClass(TryGetInlineTexture_FunctionAddress, "InlineChordTexture", Classes.FObjectProperty);
		TryGetInlineTexture_ConnectTexture_Offset = NativeReflection.GetPropertyOffset(TryGetInlineTexture_FunctionAddress, "ConnectTexture");
		TryGetInlineTexture_ConnectTexture_IsValid = NativeReflection.ValidatePropertyClass(TryGetInlineTexture_FunctionAddress, "ConnectTexture", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref TryGetInlineTexture_ReturnValue_PropertyAddress, TryGetInlineTexture_FunctionAddress, "ReturnValue");
		TryGetInlineTexture_ReturnValue_Offset = NativeReflection.GetPropertyOffset(TryGetInlineTexture_FunctionAddress, "ReturnValue");
		TryGetInlineTexture_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(TryGetInlineTexture_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		TryGetInlineTexture_IsValid = TryGetInlineTexture_FunctionAddress != IntPtr.Zero && TryGetInlineTexture_ActionTag_IsValid && TryGetInlineTexture_MarkUpType_IsValid && TryGetInlineTexture_InlineTexture_IsValid && TryGetInlineTexture_InlineChordTexture_IsValid && TryGetInlineTexture_ConnectTexture_IsValid && TryGetInlineTexture_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.InputActionEventReceiver:TryGetInlineTexture", TryGetInlineTexture_IsValid);
		IsInputDebuggerOpen_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsInputDebuggerOpen");
		IsInputDebuggerOpen_ParamsSize = NativeReflection.GetFunctionParamsSize(IsInputDebuggerOpen_FunctionAddress);
		NativeReflection.GetPropertyRef(ref IsInputDebuggerOpen_ReturnValue_PropertyAddress, IsInputDebuggerOpen_FunctionAddress, "ReturnValue");
		IsInputDebuggerOpen_ReturnValue_Offset = NativeReflection.GetPropertyOffset(IsInputDebuggerOpen_FunctionAddress, "ReturnValue");
		IsInputDebuggerOpen_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(IsInputDebuggerOpen_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsInputDebuggerOpen_IsValid = IsInputDebuggerOpen_FunctionAddress != IntPtr.Zero && IsInputDebuggerOpen_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.InputActionEventReceiver:IsInputDebuggerOpen", IsInputDebuggerOpen_IsValid);
		TryGetTextureByAction_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "TryGetTextureByAction");
		TryGetTextureByAction_ParamsSize = NativeReflection.GetFunctionParamsSize(TryGetTextureByAction_FunctionAddress);
		TryGetTextureByAction_InputAction_Offset = NativeReflection.GetPropertyOffset(TryGetTextureByAction_FunctionAddress, "InputAction");
		TryGetTextureByAction_InputAction_IsValid = NativeReflection.ValidatePropertyClass(TryGetTextureByAction_FunctionAddress, "InputAction", Classes.FObjectProperty);
		TryGetTextureByAction_Offset_Offset = NativeReflection.GetPropertyOffset(TryGetTextureByAction_FunctionAddress, "Offset");
		TryGetTextureByAction_Offset_IsValid = NativeReflection.ValidatePropertyClass(TryGetTextureByAction_FunctionAddress, "Offset", Classes.FFloatProperty);
		TryGetTextureByAction_Texture_Offset = NativeReflection.GetPropertyOffset(TryGetTextureByAction_FunctionAddress, "Texture");
		TryGetTextureByAction_Texture_IsValid = NativeReflection.ValidatePropertyClass(TryGetTextureByAction_FunctionAddress, "Texture", Classes.FObjectProperty);
		TryGetTextureByAction_BgType_Offset = NativeReflection.GetPropertyOffset(TryGetTextureByAction_FunctionAddress, "BgType");
		TryGetTextureByAction_BgType_IsValid = NativeReflection.ValidatePropertyClass(TryGetTextureByAction_FunctionAddress, "BgType", Classes.FIntProperty);
		TryGetTextureByAction_ChordOffset_Offset = NativeReflection.GetPropertyOffset(TryGetTextureByAction_FunctionAddress, "ChordOffset");
		TryGetTextureByAction_ChordOffset_IsValid = NativeReflection.ValidatePropertyClass(TryGetTextureByAction_FunctionAddress, "ChordOffset", Classes.FFloatProperty);
		TryGetTextureByAction_ChordTexture_Offset = NativeReflection.GetPropertyOffset(TryGetTextureByAction_FunctionAddress, "ChordTexture");
		TryGetTextureByAction_ChordTexture_IsValid = NativeReflection.ValidatePropertyClass(TryGetTextureByAction_FunctionAddress, "ChordTexture", Classes.FObjectProperty);
		TryGetTextureByAction_ConnectTexture_Offset = NativeReflection.GetPropertyOffset(TryGetTextureByAction_FunctionAddress, "ConnectTexture");
		TryGetTextureByAction_ConnectTexture_IsValid = NativeReflection.ValidatePropertyClass(TryGetTextureByAction_FunctionAddress, "ConnectTexture", Classes.FObjectProperty);
		TryGetTextureByAction_NoneTexture_Offset = NativeReflection.GetPropertyOffset(TryGetTextureByAction_FunctionAddress, "NoneTexture");
		TryGetTextureByAction_NoneTexture_IsValid = NativeReflection.ValidatePropertyClass(TryGetTextureByAction_FunctionAddress, "NoneTexture", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref TryGetTextureByAction_ReturnValue_PropertyAddress, TryGetTextureByAction_FunctionAddress, "ReturnValue");
		TryGetTextureByAction_ReturnValue_Offset = NativeReflection.GetPropertyOffset(TryGetTextureByAction_FunctionAddress, "ReturnValue");
		TryGetTextureByAction_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(TryGetTextureByAction_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		TryGetTextureByAction_IsValid = TryGetTextureByAction_FunctionAddress != IntPtr.Zero && TryGetTextureByAction_InputAction_IsValid && TryGetTextureByAction_Offset_IsValid && TryGetTextureByAction_Texture_IsValid && TryGetTextureByAction_BgType_IsValid && TryGetTextureByAction_ChordOffset_IsValid && TryGetTextureByAction_ChordTexture_IsValid && TryGetTextureByAction_ConnectTexture_IsValid && TryGetTextureByAction_NoneTexture_IsValid && TryGetTextureByAction_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.InputActionEventReceiver:TryGetTextureByAction", TryGetTextureByAction_IsValid);
		TryGetTextureInfoByName_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "TryGetTextureInfoByName");
		TryGetTextureInfoByName_ParamsSize = NativeReflection.GetFunctionParamsSize(TryGetTextureInfoByName_FunctionAddress);
		NativeReflection.GetPropertyRef(ref TryGetTextureInfoByName_Name_PropertyAddress, TryGetTextureInfoByName_FunctionAddress, "Name");
		TryGetTextureInfoByName_Name_Offset = NativeReflection.GetPropertyOffset(TryGetTextureInfoByName_FunctionAddress, "Name");
		TryGetTextureInfoByName_Name_IsValid = NativeReflection.ValidatePropertyClass(TryGetTextureInfoByName_FunctionAddress, "Name", Classes.FStrProperty);
		TryGetTextureInfoByName_Offset_Offset = NativeReflection.GetPropertyOffset(TryGetTextureInfoByName_FunctionAddress, "Offset");
		TryGetTextureInfoByName_Offset_IsValid = NativeReflection.ValidatePropertyClass(TryGetTextureInfoByName_FunctionAddress, "Offset", Classes.FFloatProperty);
		TryGetTextureInfoByName_BgType_Offset = NativeReflection.GetPropertyOffset(TryGetTextureInfoByName_FunctionAddress, "BgType");
		TryGetTextureInfoByName_BgType_IsValid = NativeReflection.ValidatePropertyClass(TryGetTextureInfoByName_FunctionAddress, "BgType", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref TryGetTextureInfoByName_ReturnValue_PropertyAddress, TryGetTextureInfoByName_FunctionAddress, "ReturnValue");
		TryGetTextureInfoByName_ReturnValue_Offset = NativeReflection.GetPropertyOffset(TryGetTextureInfoByName_FunctionAddress, "ReturnValue");
		TryGetTextureInfoByName_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(TryGetTextureInfoByName_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		TryGetTextureInfoByName_IsValid = TryGetTextureInfoByName_FunctionAddress != IntPtr.Zero && TryGetTextureInfoByName_Name_IsValid && TryGetTextureInfoByName_Offset_IsValid && TryGetTextureInfoByName_BgType_IsValid && TryGetTextureInfoByName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.InputActionEventReceiver:TryGetTextureInfoByName", TryGetTextureInfoByName_IsValid);
		GetRichTextInlineIconInfo_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetRichTextInlineIconInfo");
		GetRichTextInlineIconInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRichTextInlineIconInfo_FunctionAddress);
		GetRichTextInlineIconInfo_BasePixelHeight_Offset = NativeReflection.GetPropertyOffset(GetRichTextInlineIconInfo_FunctionAddress, "BasePixelHeight");
		GetRichTextInlineIconInfo_BasePixelHeight_IsValid = NativeReflection.ValidatePropertyClass(GetRichTextInlineIconInfo_FunctionAddress, "BasePixelHeight", Classes.FIntProperty);
		GetRichTextInlineIconInfo_BaselineOffset_Offset = NativeReflection.GetPropertyOffset(GetRichTextInlineIconInfo_FunctionAddress, "BaselineOffset");
		GetRichTextInlineIconInfo_BaselineOffset_IsValid = NativeReflection.ValidatePropertyClass(GetRichTextInlineIconInfo_FunctionAddress, "BaselineOffset", Classes.FIntProperty);
		GetRichTextInlineIconInfo_ConnectIconOffset_Offset = NativeReflection.GetPropertyOffset(GetRichTextInlineIconInfo_FunctionAddress, "ConnectIconOffset");
		GetRichTextInlineIconInfo_ConnectIconOffset_IsValid = NativeReflection.ValidatePropertyClass(GetRichTextInlineIconInfo_FunctionAddress, "ConnectIconOffset", Classes.FIntProperty);
		GetRichTextInlineIconInfo_IsValid = GetRichTextInlineIconInfo_FunctionAddress != IntPtr.Zero && GetRichTextInlineIconInfo_BasePixelHeight_IsValid && GetRichTextInlineIconInfo_BaselineOffset_IsValid && GetRichTextInlineIconInfo_ConnectIconOffset_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.InputActionEventReceiver:GetRichTextInlineIconInfo", GetRichTextInlineIconInfo_IsValid);
		PostApplicationActivationChanged_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "PostApplicationActivationChanged");
		PostApplicationActivationChanged_ParamsSize = NativeReflection.GetFunctionParamsSize(PostApplicationActivationChanged_FunctionAddress);
		NativeReflection.GetPropertyRef(ref PostApplicationActivationChanged_IsActive_PropertyAddress, PostApplicationActivationChanged_FunctionAddress, "IsActive");
		PostApplicationActivationChanged_IsActive_Offset = NativeReflection.GetPropertyOffset(PostApplicationActivationChanged_FunctionAddress, "IsActive");
		PostApplicationActivationChanged_IsActive_IsValid = NativeReflection.ValidatePropertyClass(PostApplicationActivationChanged_FunctionAddress, "IsActive", Classes.FBoolProperty);
		PostApplicationActivationChanged_IsValid = PostApplicationActivationChanged_FunctionAddress != IntPtr.Zero && PostApplicationActivationChanged_IsActive_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.InputActionEventReceiver:PostApplicationActivationChanged", PostApplicationActivationChanged_IsValid);
	}

	static UInputActionEventReceiver()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(UInputActionEventReceiver)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UInputActionEventReceiver));
	}
}
