using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.EnhancedInput;
using UnrealEngine.Runtime;

namespace b1.Plugins.GSInput;

[UClass(Flags = (ClassFlags)809500832uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/GSInput.GSInputTargetBinding", "GSInput", UnrealModuleType.GamePlugin)]
public class UGSInputTargetBinding : UObject
{
	private static bool TryGetTextureInfoByName_IsValid;

	private IntPtr TryGetTextureInfoByName_InstanceFunctionAddress;

	private static IntPtr TryGetTextureInfoByName_FunctionAddress;

	private static int TryGetTextureInfoByName_ParamsSize;

	private static bool TryGetTextureInfoByName_Name_IsValid;

	private static FFieldAddress TryGetTextureInfoByName_Name_PropertyAddress;

	private static int TryGetTextureInfoByName_Name_Offset;

	private static bool TryGetTextureInfoByName_Offset_IsValid;

	private static FFieldAddress TryGetTextureInfoByName_Offset_PropertyAddress;

	private static int TryGetTextureInfoByName_Offset_Offset;

	private static bool TryGetTextureInfoByName_BgType_IsValid;

	private static FFieldAddress TryGetTextureInfoByName_BgType_PropertyAddress;

	private static int TryGetTextureInfoByName_BgType_Offset;

	private static bool TryGetTextureInfoByName_ReturnValue_IsValid;

	private static FFieldAddress TryGetTextureInfoByName_ReturnValue_PropertyAddress;

	private static int TryGetTextureInfoByName_ReturnValue_Offset;

	private static bool TryGetTextureByAction_IsValid;

	private IntPtr TryGetTextureByAction_InstanceFunctionAddress;

	private static IntPtr TryGetTextureByAction_FunctionAddress;

	private static int TryGetTextureByAction_ParamsSize;

	private static bool TryGetTextureByAction_InputAction_IsValid;

	private static FFieldAddress TryGetTextureByAction_InputAction_PropertyAddress;

	private static int TryGetTextureByAction_InputAction_Offset;

	private static bool TryGetTextureByAction_Offset_IsValid;

	private static FFieldAddress TryGetTextureByAction_Offset_PropertyAddress;

	private static int TryGetTextureByAction_Offset_Offset;

	private static bool TryGetTextureByAction_Texture_IsValid;

	private static FFieldAddress TryGetTextureByAction_Texture_PropertyAddress;

	private static int TryGetTextureByAction_Texture_Offset;

	private static bool TryGetTextureByAction_BgType_IsValid;

	private static FFieldAddress TryGetTextureByAction_BgType_PropertyAddress;

	private static int TryGetTextureByAction_BgType_Offset;

	private static bool TryGetTextureByAction_ChordOffset_IsValid;

	private static FFieldAddress TryGetTextureByAction_ChordOffset_PropertyAddress;

	private static int TryGetTextureByAction_ChordOffset_Offset;

	private static bool TryGetTextureByAction_ChordTexture_IsValid;

	private static FFieldAddress TryGetTextureByAction_ChordTexture_PropertyAddress;

	private static int TryGetTextureByAction_ChordTexture_Offset;

	private static bool TryGetTextureByAction_ConnectTexture_IsValid;

	private static FFieldAddress TryGetTextureByAction_ConnectTexture_PropertyAddress;

	private static int TryGetTextureByAction_ConnectTexture_Offset;

	private static bool TryGetTextureByAction_NoneTexture_IsValid;

	private static FFieldAddress TryGetTextureByAction_NoneTexture_PropertyAddress;

	private static int TryGetTextureByAction_NoneTexture_Offset;

	private static bool TryGetTextureByAction_ReturnValue_IsValid;

	private static FFieldAddress TryGetTextureByAction_ReturnValue_PropertyAddress;

	private static int TryGetTextureByAction_ReturnValue_Offset;

	private static bool TryGetInlineTexture_IsValid;

	private IntPtr TryGetInlineTexture_InstanceFunctionAddress;

	private static IntPtr TryGetInlineTexture_FunctionAddress;

	private static int TryGetInlineTexture_ParamsSize;

	private static bool TryGetInlineTexture_ActionTag_IsValid;

	private static FFieldAddress TryGetInlineTexture_ActionTag_PropertyAddress;

	private static int TryGetInlineTexture_ActionTag_Offset;

	private static bool TryGetInlineTexture_MarkUpType_IsValid;

	private static FFieldAddress TryGetInlineTexture_MarkUpType_PropertyAddress;

	private static int TryGetInlineTexture_MarkUpType_Offset;

	private static bool TryGetInlineTexture_InlineTexture_IsValid;

	private static FFieldAddress TryGetInlineTexture_InlineTexture_PropertyAddress;

	private static int TryGetInlineTexture_InlineTexture_Offset;

	private static bool TryGetInlineTexture_InlineChordTexture_IsValid;

	private static FFieldAddress TryGetInlineTexture_InlineChordTexture_PropertyAddress;

	private static int TryGetInlineTexture_InlineChordTexture_Offset;

	private static bool TryGetInlineTexture_ConnectTexture_IsValid;

	private static FFieldAddress TryGetInlineTexture_ConnectTexture_PropertyAddress;

	private static int TryGetInlineTexture_ConnectTexture_Offset;

	private static bool TryGetInlineTexture_ReturnValue_IsValid;

	private static FFieldAddress TryGetInlineTexture_ReturnValue_PropertyAddress;

	private static int TryGetInlineTexture_ReturnValue_Offset;

	private static bool TriggeredActionListener_IsValid;

	private static IntPtr TriggeredActionListener_FunctionAddress;

	private static int TriggeredActionListener_ParamsSize;

	private static bool TriggeredActionListener_ActionInstance_IsValid;

	private static FFieldAddress TriggeredActionListener_ActionInstance_PropertyAddress;

	private static int TriggeredActionListener_ActionInstance_Offset;

	private static bool StartedActionListener_IsValid;

	private static IntPtr StartedActionListener_FunctionAddress;

	private static int StartedActionListener_ParamsSize;

	private static bool StartedActionListener_ActionInstance_IsValid;

	private static FFieldAddress StartedActionListener_ActionInstance_PropertyAddress;

	private static int StartedActionListener_ActionInstance_Offset;

	private static bool PostConsoleActivationStateChanged_IsValid;

	private IntPtr PostConsoleActivationStateChanged_InstanceFunctionAddress;

	private static IntPtr PostConsoleActivationStateChanged_FunctionAddress;

	private static int PostConsoleActivationStateChanged_ParamsSize;

	private static bool PostConsoleActivationStateChanged_IsActive_IsValid;

	private static FFieldAddress PostConsoleActivationStateChanged_IsActive_PropertyAddress;

	private static int PostConsoleActivationStateChanged_IsActive_Offset;

	private static bool PostApplicationActivationChanged_IsValid;

	private IntPtr PostApplicationActivationChanged_InstanceFunctionAddress;

	private static IntPtr PostApplicationActivationChanged_FunctionAddress;

	private static int PostApplicationActivationChanged_ParamsSize;

	private static bool PostApplicationActivationChanged_IsActive_IsValid;

	private static FFieldAddress PostApplicationActivationChanged_IsActive_PropertyAddress;

	private static int PostApplicationActivationChanged_IsActive_Offset;

	private static bool OngoingActionListener_IsValid;

	private static IntPtr OngoingActionListener_FunctionAddress;

	private static int OngoingActionListener_ParamsSize;

	private static bool OngoingActionListener_ActionInstance_IsValid;

	private static FFieldAddress OngoingActionListener_ActionInstance_PropertyAddress;

	private static int OngoingActionListener_ActionInstance_Offset;

	private static bool IsInputDebuggerOpen_IsValid;

	private IntPtr IsInputDebuggerOpen_InstanceFunctionAddress;

	private static IntPtr IsInputDebuggerOpen_FunctionAddress;

	private static int IsInputDebuggerOpen_ParamsSize;

	private static bool IsInputDebuggerOpen_ReturnValue_IsValid;

	private static FFieldAddress IsInputDebuggerOpen_ReturnValue_PropertyAddress;

	private static int IsInputDebuggerOpen_ReturnValue_Offset;

	private static bool InputActionTrigger_IsValid;

	private IntPtr InputActionTrigger_InstanceFunctionAddress;

	private static IntPtr InputActionTrigger_FunctionAddress;

	private static int InputActionTrigger_ParamsSize;

	private static bool InputActionTrigger_ActionName_IsValid;

	private static FFieldAddress InputActionTrigger_ActionName_PropertyAddress;

	private static int InputActionTrigger_ActionName_Offset;

	private static bool InputActionTrigger_TriggerEvent_IsValid;

	private static FFieldAddress InputActionTrigger_TriggerEvent_PropertyAddress;

	private static int InputActionTrigger_TriggerEvent_Offset;

	private static bool InputActionTrigger_InputActionValueType_IsValid;

	private static FFieldAddress InputActionTrigger_InputActionValueType_PropertyAddress;

	private static int InputActionTrigger_InputActionValueType_Offset;

	private static bool InputActionTrigger_InputActionValue_IsValid;

	private static FFieldAddress InputActionTrigger_InputActionValue_PropertyAddress;

	private static int InputActionTrigger_InputActionValue_Offset;

	private static bool GetRichTextInlineIconInfo_IsValid;

	private IntPtr GetRichTextInlineIconInfo_InstanceFunctionAddress;

	private static IntPtr GetRichTextInlineIconInfo_FunctionAddress;

	private static int GetRichTextInlineIconInfo_ParamsSize;

	private static bool GetRichTextInlineIconInfo_BasePixelHeight_IsValid;

	private static FFieldAddress GetRichTextInlineIconInfo_BasePixelHeight_PropertyAddress;

	private static int GetRichTextInlineIconInfo_BasePixelHeight_Offset;

	private static bool GetRichTextInlineIconInfo_BaselineOffset_IsValid;

	private static FFieldAddress GetRichTextInlineIconInfo_BaselineOffset_PropertyAddress;

	private static int GetRichTextInlineIconInfo_BaselineOffset_Offset;

	private static bool GetRichTextInlineIconInfo_ConnectIconOffset_IsValid;

	private static FFieldAddress GetRichTextInlineIconInfo_ConnectIconOffset_PropertyAddress;

	private static int GetRichTextInlineIconInfo_ConnectIconOffset_Offset;

	private static bool FetchDebugInfo_IsValid;

	private IntPtr FetchDebugInfo_InstanceFunctionAddress;

	private static IntPtr FetchDebugInfo_FunctionAddress;

	private static int FetchDebugInfo_ParamsSize;

	private static bool FetchDebugInfo_DebugLines_IsValid;

	private static FFieldAddress FetchDebugInfo_DebugLines_PropertyAddress;

	private static int FetchDebugInfo_DebugLines_Offset;

	private static bool FetchDebugInfo_DebugColors_IsValid;

	private static FFieldAddress FetchDebugInfo_DebugColors_PropertyAddress;

	private static int FetchDebugInfo_DebugColors_Offset;

	private static bool CompletedActionListener_IsValid;

	private static IntPtr CompletedActionListener_FunctionAddress;

	private static int CompletedActionListener_ParamsSize;

	private static bool CompletedActionListener_ActionInstance_IsValid;

	private static FFieldAddress CompletedActionListener_ActionInstance_PropertyAddress;

	private static int CompletedActionListener_ActionInstance_Offset;

	private static bool CanceledActionListener_IsValid;

	private static IntPtr CanceledActionListener_FunctionAddress;

	private static int CanceledActionListener_ParamsSize;

	private static bool CanceledActionListener_ActionInstance_IsValid;

	private static FFieldAddress CanceledActionListener_ActionInstance_PropertyAddress;

	private static int CanceledActionListener_ActionInstance_Offset;

	private static bool ActionListener_IsValid;

	private static IntPtr ActionListener_FunctionAddress;

	private static int ActionListener_ParamsSize;

	private static bool ActionListener_ActionInstance_IsValid;

	private static FFieldAddress ActionListener_ActionInstance_PropertyAddress;

	private static int ActionListener_ActionInstance_Offset;

	[UFunction(Flags = 205654016u)]
	[UMetaPath("/Script/GSInput.GSInputTargetBinding:TryGetTextureInfoByName")]
	public unsafe bool TryGetTextureInfoByName(string Name, out float Offset, out int BgType)
	{
		CheckDestroyed();
		if (!TryGetTextureInfoByName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSInputTargetBinding:TryGetTextureInfoByName");
			Offset = 0f;
			BgType = 0;
			return false;
		}
		if (TryGetTextureInfoByName_InstanceFunctionAddress == IntPtr.Zero)
		{
			TryGetTextureInfoByName_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "TryGetTextureInfoByName");
		}
		byte* ptr = stackalloc byte[(int)(uint)(TryGetTextureInfoByName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TryGetTextureInfoByName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, TryGetTextureInfoByName_Name_Offset), 0, TryGetTextureInfoByName_Name_PropertyAddress.Address, Name);
		NativeReflection.InvokeFunctionOptimized(base.Address, TryGetTextureInfoByName_InstanceFunctionAddress, intPtr, TryGetTextureInfoByName_ParamsSize);
		NativeReflection.DestroyValue_InContainer(TryGetTextureInfoByName_Name_PropertyAddress.Address, intPtr);
		Offset = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, TryGetTextureInfoByName_Offset_Offset), 0, TryGetTextureInfoByName_Offset_PropertyAddress.Address);
		BgType = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, TryGetTextureInfoByName_BgType_Offset), 0, TryGetTextureInfoByName_BgType_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, TryGetTextureInfoByName_ReturnValue_Offset), 0, TryGetTextureInfoByName_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual bool TryGetTextureInfoByName_Implementation(string Name, out float Offset, out int BgType)
	{
		CheckDestroyed();
		if (!TryGetTextureInfoByName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSInputTargetBinding:TryGetTextureInfoByName");
			Offset = 0f;
			BgType = 0;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(TryGetTextureInfoByName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TryGetTextureInfoByName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, TryGetTextureInfoByName_Name_Offset), 0, TryGetTextureInfoByName_Name_PropertyAddress.Address, Name);
		NativeReflection.InvokeFunctionOptimized(base.Address, TryGetTextureInfoByName_FunctionAddress, intPtr, TryGetTextureInfoByName_ParamsSize);
		NativeReflection.DestroyValue_InContainer(TryGetTextureInfoByName_Name_PropertyAddress.Address, intPtr);
		Offset = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, TryGetTextureInfoByName_Offset_Offset), 0, TryGetTextureInfoByName_Offset_PropertyAddress.Address);
		BgType = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, TryGetTextureInfoByName_BgType_Offset), 0, TryGetTextureInfoByName_BgType_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, TryGetTextureInfoByName_ReturnValue_Offset), 0, TryGetTextureInfoByName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 205654016u)]
	[UMetaPath("/Script/GSInput.GSInputTargetBinding:TryGetTextureByAction")]
	public unsafe bool TryGetTextureByAction(UInputAction InputAction, out float Offset, out UTexture2D Texture, out int BgType, out float ChordOffset, out UTexture2D ChordTexture, out UTexture2D ConnectTexture, out UTexture2D NoneTexture)
	{
		CheckDestroyed();
		if (!TryGetTextureByAction_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSInputTargetBinding:TryGetTextureByAction");
			Offset = 0f;
			Texture = null;
			BgType = 0;
			ChordOffset = 0f;
			ChordTexture = null;
			ConnectTexture = null;
			NoneTexture = null;
			return false;
		}
		if (TryGetTextureByAction_InstanceFunctionAddress == IntPtr.Zero)
		{
			TryGetTextureByAction_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "TryGetTextureByAction");
		}
		byte* ptr = stackalloc byte[(int)(uint)(TryGetTextureByAction_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TryGetTextureByAction_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UInputAction>.ToNative(IntPtr.Add(intPtr, TryGetTextureByAction_InputAction_Offset), 0, TryGetTextureByAction_InputAction_PropertyAddress.Address, InputAction);
		NativeReflection.InvokeFunctionOptimized(base.Address, TryGetTextureByAction_InstanceFunctionAddress, intPtr, TryGetTextureByAction_ParamsSize);
		Offset = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, TryGetTextureByAction_Offset_Offset), 0, TryGetTextureByAction_Offset_PropertyAddress.Address);
		Texture = UObjectMarshaler<UTexture2D>.FromNative(IntPtr.Add(intPtr, TryGetTextureByAction_Texture_Offset), 0, TryGetTextureByAction_Texture_PropertyAddress.Address);
		BgType = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, TryGetTextureByAction_BgType_Offset), 0, TryGetTextureByAction_BgType_PropertyAddress.Address);
		ChordOffset = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, TryGetTextureByAction_ChordOffset_Offset), 0, TryGetTextureByAction_ChordOffset_PropertyAddress.Address);
		ChordTexture = UObjectMarshaler<UTexture2D>.FromNative(IntPtr.Add(intPtr, TryGetTextureByAction_ChordTexture_Offset), 0, TryGetTextureByAction_ChordTexture_PropertyAddress.Address);
		ConnectTexture = UObjectMarshaler<UTexture2D>.FromNative(IntPtr.Add(intPtr, TryGetTextureByAction_ConnectTexture_Offset), 0, TryGetTextureByAction_ConnectTexture_PropertyAddress.Address);
		NoneTexture = UObjectMarshaler<UTexture2D>.FromNative(IntPtr.Add(intPtr, TryGetTextureByAction_NoneTexture_Offset), 0, TryGetTextureByAction_NoneTexture_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, TryGetTextureByAction_ReturnValue_Offset), 0, TryGetTextureByAction_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual bool TryGetTextureByAction_Implementation(UInputAction InputAction, out float Offset, out UTexture2D Texture, out int BgType, out float ChordOffset, out UTexture2D ChordTexture, out UTexture2D ConnectTexture, out UTexture2D NoneTexture)
	{
		CheckDestroyed();
		if (!TryGetTextureByAction_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSInputTargetBinding:TryGetTextureByAction");
			Offset = 0f;
			Texture = null;
			BgType = 0;
			ChordOffset = 0f;
			ChordTexture = null;
			ConnectTexture = null;
			NoneTexture = null;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(TryGetTextureByAction_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TryGetTextureByAction_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UInputAction>.ToNative(IntPtr.Add(intPtr, TryGetTextureByAction_InputAction_Offset), 0, TryGetTextureByAction_InputAction_PropertyAddress.Address, InputAction);
		NativeReflection.InvokeFunctionOptimized(base.Address, TryGetTextureByAction_FunctionAddress, intPtr, TryGetTextureByAction_ParamsSize);
		Offset = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, TryGetTextureByAction_Offset_Offset), 0, TryGetTextureByAction_Offset_PropertyAddress.Address);
		Texture = UObjectMarshaler<UTexture2D>.FromNative(IntPtr.Add(intPtr, TryGetTextureByAction_Texture_Offset), 0, TryGetTextureByAction_Texture_PropertyAddress.Address);
		BgType = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, TryGetTextureByAction_BgType_Offset), 0, TryGetTextureByAction_BgType_PropertyAddress.Address);
		ChordOffset = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, TryGetTextureByAction_ChordOffset_Offset), 0, TryGetTextureByAction_ChordOffset_PropertyAddress.Address);
		ChordTexture = UObjectMarshaler<UTexture2D>.FromNative(IntPtr.Add(intPtr, TryGetTextureByAction_ChordTexture_Offset), 0, TryGetTextureByAction_ChordTexture_PropertyAddress.Address);
		ConnectTexture = UObjectMarshaler<UTexture2D>.FromNative(IntPtr.Add(intPtr, TryGetTextureByAction_ConnectTexture_Offset), 0, TryGetTextureByAction_ConnectTexture_PropertyAddress.Address);
		NoneTexture = UObjectMarshaler<UTexture2D>.FromNative(IntPtr.Add(intPtr, TryGetTextureByAction_NoneTexture_Offset), 0, TryGetTextureByAction_NoneTexture_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, TryGetTextureByAction_ReturnValue_Offset), 0, TryGetTextureByAction_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 205654016u)]
	[UMetaPath("/Script/GSInput.GSInputTargetBinding:TryGetInlineTexture")]
	public unsafe bool TryGetInlineTexture(string ActionTag, EGSInputRichTextMarkUpType MarkUpType, out UTexture2D InlineTexture, out UTexture2D InlineChordTexture, out UTexture2D ConnectTexture)
	{
		CheckDestroyed();
		if (!TryGetInlineTexture_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSInputTargetBinding:TryGetInlineTexture");
			InlineTexture = null;
			InlineChordTexture = null;
			ConnectTexture = null;
			return false;
		}
		if (TryGetInlineTexture_InstanceFunctionAddress == IntPtr.Zero)
		{
			TryGetInlineTexture_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "TryGetInlineTexture");
		}
		byte* ptr = stackalloc byte[(int)(uint)(TryGetInlineTexture_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TryGetInlineTexture_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, TryGetInlineTexture_ActionTag_Offset), 0, TryGetInlineTexture_ActionTag_PropertyAddress.Address, ActionTag);
		EnumMarshaler<EGSInputRichTextMarkUpType>.ToNative(IntPtr.Add(intPtr, TryGetInlineTexture_MarkUpType_Offset), 0, TryGetInlineTexture_MarkUpType_PropertyAddress.Address, MarkUpType);
		NativeReflection.InvokeFunctionOptimized(base.Address, TryGetInlineTexture_InstanceFunctionAddress, intPtr, TryGetInlineTexture_ParamsSize);
		NativeReflection.DestroyValue_InContainer(TryGetInlineTexture_ActionTag_PropertyAddress.Address, intPtr);
		InlineTexture = UObjectMarshaler<UTexture2D>.FromNative(IntPtr.Add(intPtr, TryGetInlineTexture_InlineTexture_Offset), 0, TryGetInlineTexture_InlineTexture_PropertyAddress.Address);
		InlineChordTexture = UObjectMarshaler<UTexture2D>.FromNative(IntPtr.Add(intPtr, TryGetInlineTexture_InlineChordTexture_Offset), 0, TryGetInlineTexture_InlineChordTexture_PropertyAddress.Address);
		ConnectTexture = UObjectMarshaler<UTexture2D>.FromNative(IntPtr.Add(intPtr, TryGetInlineTexture_ConnectTexture_Offset), 0, TryGetInlineTexture_ConnectTexture_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, TryGetInlineTexture_ReturnValue_Offset), 0, TryGetInlineTexture_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual bool TryGetInlineTexture_Implementation(string ActionTag, EGSInputRichTextMarkUpType MarkUpType, out UTexture2D InlineTexture, out UTexture2D InlineChordTexture, out UTexture2D ConnectTexture)
	{
		CheckDestroyed();
		if (!TryGetInlineTexture_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSInputTargetBinding:TryGetInlineTexture");
			InlineTexture = null;
			InlineChordTexture = null;
			ConnectTexture = null;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(TryGetInlineTexture_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TryGetInlineTexture_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, TryGetInlineTexture_ActionTag_Offset), 0, TryGetInlineTexture_ActionTag_PropertyAddress.Address, ActionTag);
		EnumMarshaler<EGSInputRichTextMarkUpType>.ToNative(IntPtr.Add(intPtr, TryGetInlineTexture_MarkUpType_Offset), 0, TryGetInlineTexture_MarkUpType_PropertyAddress.Address, MarkUpType);
		NativeReflection.InvokeFunctionOptimized(base.Address, TryGetInlineTexture_FunctionAddress, intPtr, TryGetInlineTexture_ParamsSize);
		NativeReflection.DestroyValue_InContainer(TryGetInlineTexture_ActionTag_PropertyAddress.Address, intPtr);
		InlineTexture = UObjectMarshaler<UTexture2D>.FromNative(IntPtr.Add(intPtr, TryGetInlineTexture_InlineTexture_Offset), 0, TryGetInlineTexture_InlineTexture_PropertyAddress.Address);
		InlineChordTexture = UObjectMarshaler<UTexture2D>.FromNative(IntPtr.Add(intPtr, TryGetInlineTexture_InlineChordTexture_Offset), 0, TryGetInlineTexture_InlineChordTexture_PropertyAddress.Address);
		ConnectTexture = UObjectMarshaler<UTexture2D>.FromNative(IntPtr.Add(intPtr, TryGetInlineTexture_ConnectTexture_Offset), 0, TryGetInlineTexture_ConnectTexture_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, TryGetInlineTexture_ReturnValue_Offset), 0, TryGetInlineTexture_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/GSInput.GSInputTargetBinding:TriggeredActionListener")]
	public unsafe void TriggeredActionListener(FInputActionInstance ActionInstance)
	{
		CheckDestroyed();
		if (!TriggeredActionListener_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSInputTargetBinding:TriggeredActionListener");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(TriggeredActionListener_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TriggeredActionListener_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(TriggeredActionListener_ActionInstance_PropertyAddress.Address, intPtr);
		FInputActionInstance.ToNative(IntPtr.Add(intPtr, TriggeredActionListener_ActionInstance_Offset), 0, TriggeredActionListener_ActionInstance_PropertyAddress.Address, ActionInstance);
		NativeReflection.InvokeFunctionOptimized(base.Address, TriggeredActionListener_FunctionAddress, intPtr, TriggeredActionListener_ParamsSize);
		NativeReflection.DestroyValue_InContainer(TriggeredActionListener_ActionInstance_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/GSInput.GSInputTargetBinding:StartedActionListener")]
	public unsafe void StartedActionListener(FInputActionInstance ActionInstance)
	{
		CheckDestroyed();
		if (!StartedActionListener_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSInputTargetBinding:StartedActionListener");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StartedActionListener_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StartedActionListener_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(StartedActionListener_ActionInstance_PropertyAddress.Address, intPtr);
		FInputActionInstance.ToNative(IntPtr.Add(intPtr, StartedActionListener_ActionInstance_Offset), 0, StartedActionListener_ActionInstance_PropertyAddress.Address, ActionInstance);
		NativeReflection.InvokeFunctionOptimized(base.Address, StartedActionListener_FunctionAddress, intPtr, StartedActionListener_ParamsSize);
		NativeReflection.DestroyValue_InContainer(StartedActionListener_ActionInstance_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 201459712u)]
	[UMetaPath("/Script/GSInput.GSInputTargetBinding:PostConsoleActivationStateChanged")]
	public unsafe void PostConsoleActivationStateChanged(bool IsActive)
	{
		CheckDestroyed();
		if (!PostConsoleActivationStateChanged_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSInputTargetBinding:PostConsoleActivationStateChanged");
			return;
		}
		if (PostConsoleActivationStateChanged_InstanceFunctionAddress == IntPtr.Zero)
		{
			PostConsoleActivationStateChanged_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "PostConsoleActivationStateChanged");
		}
		byte* ptr = stackalloc byte[(int)(uint)(PostConsoleActivationStateChanged_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PostConsoleActivationStateChanged_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, PostConsoleActivationStateChanged_IsActive_Offset), 0, PostConsoleActivationStateChanged_IsActive_PropertyAddress.Address, IsActive);
		NativeReflection.InvokeFunctionOptimized(base.Address, PostConsoleActivationStateChanged_InstanceFunctionAddress, intPtr, PostConsoleActivationStateChanged_ParamsSize);
	}

	protected unsafe virtual void PostConsoleActivationStateChanged_Implementation(bool IsActive)
	{
		CheckDestroyed();
		if (!PostConsoleActivationStateChanged_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSInputTargetBinding:PostConsoleActivationStateChanged");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PostConsoleActivationStateChanged_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PostConsoleActivationStateChanged_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, PostConsoleActivationStateChanged_IsActive_Offset), 0, PostConsoleActivationStateChanged_IsActive_PropertyAddress.Address, IsActive);
		NativeReflection.InvokeFunctionOptimized(base.Address, PostConsoleActivationStateChanged_FunctionAddress, intPtr, PostConsoleActivationStateChanged_ParamsSize);
	}

	[UFunction(Flags = 201459712u)]
	[UMetaPath("/Script/GSInput.GSInputTargetBinding:PostApplicationActivationChanged")]
	public unsafe void PostApplicationActivationChanged(bool IsActive)
	{
		CheckDestroyed();
		if (!PostApplicationActivationChanged_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSInputTargetBinding:PostApplicationActivationChanged");
			return;
		}
		if (PostApplicationActivationChanged_InstanceFunctionAddress == IntPtr.Zero)
		{
			PostApplicationActivationChanged_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "PostApplicationActivationChanged");
		}
		byte* ptr = stackalloc byte[(int)(uint)(PostApplicationActivationChanged_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PostApplicationActivationChanged_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, PostApplicationActivationChanged_IsActive_Offset), 0, PostApplicationActivationChanged_IsActive_PropertyAddress.Address, IsActive);
		NativeReflection.InvokeFunctionOptimized(base.Address, PostApplicationActivationChanged_InstanceFunctionAddress, intPtr, PostApplicationActivationChanged_ParamsSize);
	}

	protected unsafe virtual void PostApplicationActivationChanged_Implementation(bool IsActive)
	{
		CheckDestroyed();
		if (!PostApplicationActivationChanged_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSInputTargetBinding:PostApplicationActivationChanged");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PostApplicationActivationChanged_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PostApplicationActivationChanged_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, PostApplicationActivationChanged_IsActive_Offset), 0, PostApplicationActivationChanged_IsActive_PropertyAddress.Address, IsActive);
		NativeReflection.InvokeFunctionOptimized(base.Address, PostApplicationActivationChanged_FunctionAddress, intPtr, PostApplicationActivationChanged_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/GSInput.GSInputTargetBinding:OngoingActionListener")]
	public unsafe void OngoingActionListener(FInputActionInstance ActionInstance)
	{
		CheckDestroyed();
		if (!OngoingActionListener_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSInputTargetBinding:OngoingActionListener");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OngoingActionListener_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OngoingActionListener_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OngoingActionListener_ActionInstance_PropertyAddress.Address, intPtr);
		FInputActionInstance.ToNative(IntPtr.Add(intPtr, OngoingActionListener_ActionInstance_Offset), 0, OngoingActionListener_ActionInstance_PropertyAddress.Address, ActionInstance);
		NativeReflection.InvokeFunctionOptimized(base.Address, OngoingActionListener_FunctionAddress, intPtr, OngoingActionListener_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OngoingActionListener_ActionInstance_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 201459712u)]
	[UMetaPath("/Script/GSInput.GSInputTargetBinding:IsInputDebuggerOpen")]
	public unsafe bool IsInputDebuggerOpen()
	{
		CheckDestroyed();
		if (!IsInputDebuggerOpen_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSInputTargetBinding:IsInputDebuggerOpen");
			return false;
		}
		if (IsInputDebuggerOpen_InstanceFunctionAddress == IntPtr.Zero)
		{
			IsInputDebuggerOpen_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "IsInputDebuggerOpen");
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsInputDebuggerOpen_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsInputDebuggerOpen_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsInputDebuggerOpen_InstanceFunctionAddress, intPtr, IsInputDebuggerOpen_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsInputDebuggerOpen_ReturnValue_Offset), 0, IsInputDebuggerOpen_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual bool IsInputDebuggerOpen_Implementation()
	{
		CheckDestroyed();
		if (!IsInputDebuggerOpen_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSInputTargetBinding:IsInputDebuggerOpen");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsInputDebuggerOpen_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsInputDebuggerOpen_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsInputDebuggerOpen_FunctionAddress, intPtr, IsInputDebuggerOpen_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsInputDebuggerOpen_ReturnValue_Offset), 0, IsInputDebuggerOpen_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 209848320u)]
	[UMetaPath("/Script/GSInput.GSInputTargetBinding:InputActionTrigger")]
	public unsafe void InputActionTrigger(string ActionName, ETriggerEvent TriggerEvent, EInputActionValueType InputActionValueType, FVector InputActionValue)
	{
		CheckDestroyed();
		if (!InputActionTrigger_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSInputTargetBinding:InputActionTrigger");
			return;
		}
		if (InputActionTrigger_InstanceFunctionAddress == IntPtr.Zero)
		{
			InputActionTrigger_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "InputActionTrigger");
		}
		byte* ptr = stackalloc byte[(int)(uint)(InputActionTrigger_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InputActionTrigger_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, InputActionTrigger_ActionName_Offset), 0, InputActionTrigger_ActionName_PropertyAddress.Address, ActionName);
		EnumMarshaler<ETriggerEvent>.ToNative(IntPtr.Add(intPtr, InputActionTrigger_TriggerEvent_Offset), 0, InputActionTrigger_TriggerEvent_PropertyAddress.Address, TriggerEvent);
		EnumMarshaler<EInputActionValueType>.ToNative(IntPtr.Add(intPtr, InputActionTrigger_InputActionValueType_Offset), 0, InputActionTrigger_InputActionValueType_PropertyAddress.Address, InputActionValueType);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, InputActionTrigger_InputActionValue_Offset), 0, InputActionTrigger_InputActionValue_PropertyAddress.Address, InputActionValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, InputActionTrigger_InstanceFunctionAddress, intPtr, InputActionTrigger_ParamsSize);
		NativeReflection.DestroyValue_InContainer(InputActionTrigger_ActionName_PropertyAddress.Address, intPtr);
	}

	protected unsafe virtual void InputActionTrigger_Implementation(string ActionName, ETriggerEvent TriggerEvent, EInputActionValueType InputActionValueType, FVector InputActionValue)
	{
		CheckDestroyed();
		if (!InputActionTrigger_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSInputTargetBinding:InputActionTrigger");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(InputActionTrigger_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InputActionTrigger_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, InputActionTrigger_ActionName_Offset), 0, InputActionTrigger_ActionName_PropertyAddress.Address, ActionName);
		EnumMarshaler<ETriggerEvent>.ToNative(IntPtr.Add(intPtr, InputActionTrigger_TriggerEvent_Offset), 0, InputActionTrigger_TriggerEvent_PropertyAddress.Address, TriggerEvent);
		EnumMarshaler<EInputActionValueType>.ToNative(IntPtr.Add(intPtr, InputActionTrigger_InputActionValueType_Offset), 0, InputActionTrigger_InputActionValueType_PropertyAddress.Address, InputActionValueType);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, InputActionTrigger_InputActionValue_Offset), 0, InputActionTrigger_InputActionValue_PropertyAddress.Address, InputActionValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, InputActionTrigger_FunctionAddress, intPtr, InputActionTrigger_ParamsSize);
		NativeReflection.DestroyValue_InContainer(InputActionTrigger_ActionName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 205654016u)]
	[UMetaPath("/Script/GSInput.GSInputTargetBinding:GetRichTextInlineIconInfo")]
	public unsafe void GetRichTextInlineIconInfo(out int BasePixelHeight, out int BaselineOffset, out int ConnectIconOffset)
	{
		CheckDestroyed();
		if (!GetRichTextInlineIconInfo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSInputTargetBinding:GetRichTextInlineIconInfo");
			BasePixelHeight = 0;
			BaselineOffset = 0;
			ConnectIconOffset = 0;
			return;
		}
		if (GetRichTextInlineIconInfo_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetRichTextInlineIconInfo_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetRichTextInlineIconInfo");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRichTextInlineIconInfo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRichTextInlineIconInfo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetRichTextInlineIconInfo_InstanceFunctionAddress, intPtr, GetRichTextInlineIconInfo_ParamsSize);
		BasePixelHeight = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetRichTextInlineIconInfo_BasePixelHeight_Offset), 0, GetRichTextInlineIconInfo_BasePixelHeight_PropertyAddress.Address);
		BaselineOffset = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetRichTextInlineIconInfo_BaselineOffset_Offset), 0, GetRichTextInlineIconInfo_BaselineOffset_PropertyAddress.Address);
		ConnectIconOffset = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetRichTextInlineIconInfo_ConnectIconOffset_Offset), 0, GetRichTextInlineIconInfo_ConnectIconOffset_PropertyAddress.Address);
	}

	protected unsafe virtual void GetRichTextInlineIconInfo_Implementation(out int BasePixelHeight, out int BaselineOffset, out int ConnectIconOffset)
	{
		CheckDestroyed();
		if (!GetRichTextInlineIconInfo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSInputTargetBinding:GetRichTextInlineIconInfo");
			BasePixelHeight = 0;
			BaselineOffset = 0;
			ConnectIconOffset = 0;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRichTextInlineIconInfo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRichTextInlineIconInfo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetRichTextInlineIconInfo_FunctionAddress, intPtr, GetRichTextInlineIconInfo_ParamsSize);
		BasePixelHeight = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetRichTextInlineIconInfo_BasePixelHeight_Offset), 0, GetRichTextInlineIconInfo_BasePixelHeight_PropertyAddress.Address);
		BaselineOffset = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetRichTextInlineIconInfo_BaselineOffset_Offset), 0, GetRichTextInlineIconInfo_BaselineOffset_PropertyAddress.Address);
		ConnectIconOffset = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetRichTextInlineIconInfo_ConnectIconOffset_Offset), 0, GetRichTextInlineIconInfo_ConnectIconOffset_PropertyAddress.Address);
	}

	[UFunction(Flags = 205654016u)]
	[UMetaPath("/Script/GSInput.GSInputTargetBinding:FetchDebugInfo")]
	public unsafe void FetchDebugInfo(out List<string> DebugLines, out List<FColor> DebugColors)
	{
		CheckDestroyed();
		if (!FetchDebugInfo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSInputTargetBinding:FetchDebugInfo");
			DebugLines = null;
			DebugColors = null;
			return;
		}
		if (FetchDebugInfo_InstanceFunctionAddress == IntPtr.Zero)
		{
			FetchDebugInfo_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "FetchDebugInfo");
		}
		byte* ptr = stackalloc byte[(int)(uint)(FetchDebugInfo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FetchDebugInfo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, FetchDebugInfo_InstanceFunctionAddress, intPtr, FetchDebugInfo_ParamsSize);
		DebugLines = new TArrayCopyMarshaler<string>(1, FetchDebugInfo_DebugLines_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, FetchDebugInfo_DebugLines_Offset));
		NativeReflection.DestroyValue_InContainer(FetchDebugInfo_DebugLines_PropertyAddress.Address, intPtr);
		DebugColors = new TArrayCopyMarshaler<FColor>(1, FetchDebugInfo_DebugColors_PropertyAddress, CachedMarshalingDelegates<FColor, BlittableTypeMarshaler<FColor>>.FromNative, CachedMarshalingDelegates<FColor, BlittableTypeMarshaler<FColor>>.ToNative).FromNative(IntPtr.Add(intPtr, FetchDebugInfo_DebugColors_Offset));
		NativeReflection.DestroyValue_InContainer(FetchDebugInfo_DebugColors_PropertyAddress.Address, intPtr);
	}

	protected unsafe virtual void FetchDebugInfo_Implementation(out List<string> DebugLines, out List<FColor> DebugColors)
	{
		CheckDestroyed();
		if (!FetchDebugInfo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSInputTargetBinding:FetchDebugInfo");
			DebugLines = null;
			DebugColors = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FetchDebugInfo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FetchDebugInfo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, FetchDebugInfo_FunctionAddress, intPtr, FetchDebugInfo_ParamsSize);
		DebugLines = new TArrayCopyMarshaler<string>(1, FetchDebugInfo_DebugLines_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, FetchDebugInfo_DebugLines_Offset));
		NativeReflection.DestroyValue_InContainer(FetchDebugInfo_DebugLines_PropertyAddress.Address, intPtr);
		DebugColors = new TArrayCopyMarshaler<FColor>(1, FetchDebugInfo_DebugColors_PropertyAddress, CachedMarshalingDelegates<FColor, BlittableTypeMarshaler<FColor>>.FromNative, CachedMarshalingDelegates<FColor, BlittableTypeMarshaler<FColor>>.ToNative).FromNative(IntPtr.Add(intPtr, FetchDebugInfo_DebugColors_Offset));
		NativeReflection.DestroyValue_InContainer(FetchDebugInfo_DebugColors_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/GSInput.GSInputTargetBinding:CompletedActionListener")]
	public unsafe void CompletedActionListener(FInputActionInstance ActionInstance)
	{
		CheckDestroyed();
		if (!CompletedActionListener_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSInputTargetBinding:CompletedActionListener");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CompletedActionListener_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CompletedActionListener_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(CompletedActionListener_ActionInstance_PropertyAddress.Address, intPtr);
		FInputActionInstance.ToNative(IntPtr.Add(intPtr, CompletedActionListener_ActionInstance_Offset), 0, CompletedActionListener_ActionInstance_PropertyAddress.Address, ActionInstance);
		NativeReflection.InvokeFunctionOptimized(base.Address, CompletedActionListener_FunctionAddress, intPtr, CompletedActionListener_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CompletedActionListener_ActionInstance_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/GSInput.GSInputTargetBinding:CanceledActionListener")]
	public unsafe void CanceledActionListener(FInputActionInstance ActionInstance)
	{
		CheckDestroyed();
		if (!CanceledActionListener_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSInputTargetBinding:CanceledActionListener");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CanceledActionListener_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CanceledActionListener_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(CanceledActionListener_ActionInstance_PropertyAddress.Address, intPtr);
		FInputActionInstance.ToNative(IntPtr.Add(intPtr, CanceledActionListener_ActionInstance_Offset), 0, CanceledActionListener_ActionInstance_PropertyAddress.Address, ActionInstance);
		NativeReflection.InvokeFunctionOptimized(base.Address, CanceledActionListener_FunctionAddress, intPtr, CanceledActionListener_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CanceledActionListener_ActionInstance_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/GSInput.GSInputTargetBinding:ActionListener")]
	public unsafe void ActionListener(FInputActionInstance ActionInstance)
	{
		CheckDestroyed();
		if (!ActionListener_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSInputTargetBinding:ActionListener");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ActionListener_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ActionListener_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(ActionListener_ActionInstance_PropertyAddress.Address, intPtr);
		FInputActionInstance.ToNative(IntPtr.Add(intPtr, ActionListener_ActionInstance_Offset), 0, ActionListener_ActionInstance_PropertyAddress.Address, ActionInstance);
		NativeReflection.InvokeFunctionOptimized(base.Address, ActionListener_FunctionAddress, intPtr, ActionListener_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ActionListener_ActionInstance_PropertyAddress.Address, intPtr);
	}

	static UGSInputTargetBinding()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSInputTargetBinding)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSInputTargetBinding));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/GSInput.GSInputTargetBinding");
		TryGetTextureInfoByName_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "TryGetTextureInfoByName");
		TryGetTextureInfoByName_ParamsSize = NativeReflection.GetFunctionParamsSize(TryGetTextureInfoByName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref TryGetTextureInfoByName_Name_PropertyAddress, TryGetTextureInfoByName_FunctionAddress, "Name");
		TryGetTextureInfoByName_Name_Offset = NativeReflectionCached.GetPropertyOffset(TryGetTextureInfoByName_FunctionAddress, "Name");
		TryGetTextureInfoByName_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(TryGetTextureInfoByName_FunctionAddress, "Name", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref TryGetTextureInfoByName_Offset_PropertyAddress, TryGetTextureInfoByName_FunctionAddress, "Offset");
		TryGetTextureInfoByName_Offset_Offset = NativeReflectionCached.GetPropertyOffset(TryGetTextureInfoByName_FunctionAddress, "Offset");
		TryGetTextureInfoByName_Offset_IsValid = NativeReflectionCached.ValidatePropertyClass(TryGetTextureInfoByName_FunctionAddress, "Offset", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref TryGetTextureInfoByName_BgType_PropertyAddress, TryGetTextureInfoByName_FunctionAddress, "BgType");
		TryGetTextureInfoByName_BgType_Offset = NativeReflectionCached.GetPropertyOffset(TryGetTextureInfoByName_FunctionAddress, "BgType");
		TryGetTextureInfoByName_BgType_IsValid = NativeReflectionCached.ValidatePropertyClass(TryGetTextureInfoByName_FunctionAddress, "BgType", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref TryGetTextureInfoByName_ReturnValue_PropertyAddress, TryGetTextureInfoByName_FunctionAddress, "ReturnValue");
		TryGetTextureInfoByName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(TryGetTextureInfoByName_FunctionAddress, "ReturnValue");
		TryGetTextureInfoByName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(TryGetTextureInfoByName_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		TryGetTextureInfoByName_IsValid = TryGetTextureInfoByName_FunctionAddress != IntPtr.Zero && TryGetTextureInfoByName_Name_IsValid && TryGetTextureInfoByName_Offset_IsValid && TryGetTextureInfoByName_BgType_IsValid && TryGetTextureInfoByName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSInputTargetBinding:TryGetTextureInfoByName", TryGetTextureInfoByName_IsValid);
		TryGetTextureByAction_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "TryGetTextureByAction");
		TryGetTextureByAction_ParamsSize = NativeReflection.GetFunctionParamsSize(TryGetTextureByAction_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref TryGetTextureByAction_InputAction_PropertyAddress, TryGetTextureByAction_FunctionAddress, "InputAction");
		TryGetTextureByAction_InputAction_Offset = NativeReflectionCached.GetPropertyOffset(TryGetTextureByAction_FunctionAddress, "InputAction");
		TryGetTextureByAction_InputAction_IsValid = NativeReflectionCached.ValidatePropertyClass(TryGetTextureByAction_FunctionAddress, "InputAction", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref TryGetTextureByAction_Offset_PropertyAddress, TryGetTextureByAction_FunctionAddress, "Offset");
		TryGetTextureByAction_Offset_Offset = NativeReflectionCached.GetPropertyOffset(TryGetTextureByAction_FunctionAddress, "Offset");
		TryGetTextureByAction_Offset_IsValid = NativeReflectionCached.ValidatePropertyClass(TryGetTextureByAction_FunctionAddress, "Offset", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref TryGetTextureByAction_Texture_PropertyAddress, TryGetTextureByAction_FunctionAddress, "Texture");
		TryGetTextureByAction_Texture_Offset = NativeReflectionCached.GetPropertyOffset(TryGetTextureByAction_FunctionAddress, "Texture");
		TryGetTextureByAction_Texture_IsValid = NativeReflectionCached.ValidatePropertyClass(TryGetTextureByAction_FunctionAddress, "Texture", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref TryGetTextureByAction_BgType_PropertyAddress, TryGetTextureByAction_FunctionAddress, "BgType");
		TryGetTextureByAction_BgType_Offset = NativeReflectionCached.GetPropertyOffset(TryGetTextureByAction_FunctionAddress, "BgType");
		TryGetTextureByAction_BgType_IsValid = NativeReflectionCached.ValidatePropertyClass(TryGetTextureByAction_FunctionAddress, "BgType", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref TryGetTextureByAction_ChordOffset_PropertyAddress, TryGetTextureByAction_FunctionAddress, "ChordOffset");
		TryGetTextureByAction_ChordOffset_Offset = NativeReflectionCached.GetPropertyOffset(TryGetTextureByAction_FunctionAddress, "ChordOffset");
		TryGetTextureByAction_ChordOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(TryGetTextureByAction_FunctionAddress, "ChordOffset", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref TryGetTextureByAction_ChordTexture_PropertyAddress, TryGetTextureByAction_FunctionAddress, "ChordTexture");
		TryGetTextureByAction_ChordTexture_Offset = NativeReflectionCached.GetPropertyOffset(TryGetTextureByAction_FunctionAddress, "ChordTexture");
		TryGetTextureByAction_ChordTexture_IsValid = NativeReflectionCached.ValidatePropertyClass(TryGetTextureByAction_FunctionAddress, "ChordTexture", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref TryGetTextureByAction_ConnectTexture_PropertyAddress, TryGetTextureByAction_FunctionAddress, "ConnectTexture");
		TryGetTextureByAction_ConnectTexture_Offset = NativeReflectionCached.GetPropertyOffset(TryGetTextureByAction_FunctionAddress, "ConnectTexture");
		TryGetTextureByAction_ConnectTexture_IsValid = NativeReflectionCached.ValidatePropertyClass(TryGetTextureByAction_FunctionAddress, "ConnectTexture", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref TryGetTextureByAction_NoneTexture_PropertyAddress, TryGetTextureByAction_FunctionAddress, "NoneTexture");
		TryGetTextureByAction_NoneTexture_Offset = NativeReflectionCached.GetPropertyOffset(TryGetTextureByAction_FunctionAddress, "NoneTexture");
		TryGetTextureByAction_NoneTexture_IsValid = NativeReflectionCached.ValidatePropertyClass(TryGetTextureByAction_FunctionAddress, "NoneTexture", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref TryGetTextureByAction_ReturnValue_PropertyAddress, TryGetTextureByAction_FunctionAddress, "ReturnValue");
		TryGetTextureByAction_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(TryGetTextureByAction_FunctionAddress, "ReturnValue");
		TryGetTextureByAction_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(TryGetTextureByAction_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		TryGetTextureByAction_IsValid = TryGetTextureByAction_FunctionAddress != IntPtr.Zero && TryGetTextureByAction_InputAction_IsValid && TryGetTextureByAction_Offset_IsValid && TryGetTextureByAction_Texture_IsValid && TryGetTextureByAction_BgType_IsValid && TryGetTextureByAction_ChordOffset_IsValid && TryGetTextureByAction_ChordTexture_IsValid && TryGetTextureByAction_ConnectTexture_IsValid && TryGetTextureByAction_NoneTexture_IsValid && TryGetTextureByAction_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSInputTargetBinding:TryGetTextureByAction", TryGetTextureByAction_IsValid);
		TryGetInlineTexture_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "TryGetInlineTexture");
		TryGetInlineTexture_ParamsSize = NativeReflection.GetFunctionParamsSize(TryGetInlineTexture_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref TryGetInlineTexture_ActionTag_PropertyAddress, TryGetInlineTexture_FunctionAddress, "ActionTag");
		TryGetInlineTexture_ActionTag_Offset = NativeReflectionCached.GetPropertyOffset(TryGetInlineTexture_FunctionAddress, "ActionTag");
		TryGetInlineTexture_ActionTag_IsValid = NativeReflectionCached.ValidatePropertyClass(TryGetInlineTexture_FunctionAddress, "ActionTag", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref TryGetInlineTexture_MarkUpType_PropertyAddress, TryGetInlineTexture_FunctionAddress, "MarkUpType");
		TryGetInlineTexture_MarkUpType_Offset = NativeReflectionCached.GetPropertyOffset(TryGetInlineTexture_FunctionAddress, "MarkUpType");
		TryGetInlineTexture_MarkUpType_IsValid = NativeReflectionCached.ValidatePropertyClass(TryGetInlineTexture_FunctionAddress, "MarkUpType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref TryGetInlineTexture_InlineTexture_PropertyAddress, TryGetInlineTexture_FunctionAddress, "InlineTexture");
		TryGetInlineTexture_InlineTexture_Offset = NativeReflectionCached.GetPropertyOffset(TryGetInlineTexture_FunctionAddress, "InlineTexture");
		TryGetInlineTexture_InlineTexture_IsValid = NativeReflectionCached.ValidatePropertyClass(TryGetInlineTexture_FunctionAddress, "InlineTexture", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref TryGetInlineTexture_InlineChordTexture_PropertyAddress, TryGetInlineTexture_FunctionAddress, "InlineChordTexture");
		TryGetInlineTexture_InlineChordTexture_Offset = NativeReflectionCached.GetPropertyOffset(TryGetInlineTexture_FunctionAddress, "InlineChordTexture");
		TryGetInlineTexture_InlineChordTexture_IsValid = NativeReflectionCached.ValidatePropertyClass(TryGetInlineTexture_FunctionAddress, "InlineChordTexture", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref TryGetInlineTexture_ConnectTexture_PropertyAddress, TryGetInlineTexture_FunctionAddress, "ConnectTexture");
		TryGetInlineTexture_ConnectTexture_Offset = NativeReflectionCached.GetPropertyOffset(TryGetInlineTexture_FunctionAddress, "ConnectTexture");
		TryGetInlineTexture_ConnectTexture_IsValid = NativeReflectionCached.ValidatePropertyClass(TryGetInlineTexture_FunctionAddress, "ConnectTexture", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref TryGetInlineTexture_ReturnValue_PropertyAddress, TryGetInlineTexture_FunctionAddress, "ReturnValue");
		TryGetInlineTexture_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(TryGetInlineTexture_FunctionAddress, "ReturnValue");
		TryGetInlineTexture_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(TryGetInlineTexture_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		TryGetInlineTexture_IsValid = TryGetInlineTexture_FunctionAddress != IntPtr.Zero && TryGetInlineTexture_ActionTag_IsValid && TryGetInlineTexture_MarkUpType_IsValid && TryGetInlineTexture_InlineTexture_IsValid && TryGetInlineTexture_InlineChordTexture_IsValid && TryGetInlineTexture_ConnectTexture_IsValid && TryGetInlineTexture_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSInputTargetBinding:TryGetInlineTexture", TryGetInlineTexture_IsValid);
		TriggeredActionListener_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "TriggeredActionListener");
		TriggeredActionListener_ParamsSize = NativeReflection.GetFunctionParamsSize(TriggeredActionListener_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref TriggeredActionListener_ActionInstance_PropertyAddress, TriggeredActionListener_FunctionAddress, "ActionInstance");
		TriggeredActionListener_ActionInstance_Offset = NativeReflectionCached.GetPropertyOffset(TriggeredActionListener_FunctionAddress, "ActionInstance");
		TriggeredActionListener_ActionInstance_IsValid = NativeReflectionCached.ValidatePropertyClass(TriggeredActionListener_FunctionAddress, "ActionInstance", Classes.FStructProperty);
		TriggeredActionListener_IsValid = TriggeredActionListener_FunctionAddress != IntPtr.Zero && TriggeredActionListener_ActionInstance_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSInputTargetBinding:TriggeredActionListener", TriggeredActionListener_IsValid);
		StartedActionListener_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "StartedActionListener");
		StartedActionListener_ParamsSize = NativeReflection.GetFunctionParamsSize(StartedActionListener_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref StartedActionListener_ActionInstance_PropertyAddress, StartedActionListener_FunctionAddress, "ActionInstance");
		StartedActionListener_ActionInstance_Offset = NativeReflectionCached.GetPropertyOffset(StartedActionListener_FunctionAddress, "ActionInstance");
		StartedActionListener_ActionInstance_IsValid = NativeReflectionCached.ValidatePropertyClass(StartedActionListener_FunctionAddress, "ActionInstance", Classes.FStructProperty);
		StartedActionListener_IsValid = StartedActionListener_FunctionAddress != IntPtr.Zero && StartedActionListener_ActionInstance_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSInputTargetBinding:StartedActionListener", StartedActionListener_IsValid);
		PostConsoleActivationStateChanged_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "PostConsoleActivationStateChanged");
		PostConsoleActivationStateChanged_ParamsSize = NativeReflection.GetFunctionParamsSize(PostConsoleActivationStateChanged_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PostConsoleActivationStateChanged_IsActive_PropertyAddress, PostConsoleActivationStateChanged_FunctionAddress, "IsActive");
		PostConsoleActivationStateChanged_IsActive_Offset = NativeReflectionCached.GetPropertyOffset(PostConsoleActivationStateChanged_FunctionAddress, "IsActive");
		PostConsoleActivationStateChanged_IsActive_IsValid = NativeReflectionCached.ValidatePropertyClass(PostConsoleActivationStateChanged_FunctionAddress, "IsActive", Classes.FBoolProperty);
		PostConsoleActivationStateChanged_IsValid = PostConsoleActivationStateChanged_FunctionAddress != IntPtr.Zero && PostConsoleActivationStateChanged_IsActive_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSInputTargetBinding:PostConsoleActivationStateChanged", PostConsoleActivationStateChanged_IsValid);
		PostApplicationActivationChanged_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "PostApplicationActivationChanged");
		PostApplicationActivationChanged_ParamsSize = NativeReflection.GetFunctionParamsSize(PostApplicationActivationChanged_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PostApplicationActivationChanged_IsActive_PropertyAddress, PostApplicationActivationChanged_FunctionAddress, "IsActive");
		PostApplicationActivationChanged_IsActive_Offset = NativeReflectionCached.GetPropertyOffset(PostApplicationActivationChanged_FunctionAddress, "IsActive");
		PostApplicationActivationChanged_IsActive_IsValid = NativeReflectionCached.ValidatePropertyClass(PostApplicationActivationChanged_FunctionAddress, "IsActive", Classes.FBoolProperty);
		PostApplicationActivationChanged_IsValid = PostApplicationActivationChanged_FunctionAddress != IntPtr.Zero && PostApplicationActivationChanged_IsActive_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSInputTargetBinding:PostApplicationActivationChanged", PostApplicationActivationChanged_IsValid);
		OngoingActionListener_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OngoingActionListener");
		OngoingActionListener_ParamsSize = NativeReflection.GetFunctionParamsSize(OngoingActionListener_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OngoingActionListener_ActionInstance_PropertyAddress, OngoingActionListener_FunctionAddress, "ActionInstance");
		OngoingActionListener_ActionInstance_Offset = NativeReflectionCached.GetPropertyOffset(OngoingActionListener_FunctionAddress, "ActionInstance");
		OngoingActionListener_ActionInstance_IsValid = NativeReflectionCached.ValidatePropertyClass(OngoingActionListener_FunctionAddress, "ActionInstance", Classes.FStructProperty);
		OngoingActionListener_IsValid = OngoingActionListener_FunctionAddress != IntPtr.Zero && OngoingActionListener_ActionInstance_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSInputTargetBinding:OngoingActionListener", OngoingActionListener_IsValid);
		IsInputDebuggerOpen_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsInputDebuggerOpen");
		IsInputDebuggerOpen_ParamsSize = NativeReflection.GetFunctionParamsSize(IsInputDebuggerOpen_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsInputDebuggerOpen_ReturnValue_PropertyAddress, IsInputDebuggerOpen_FunctionAddress, "ReturnValue");
		IsInputDebuggerOpen_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsInputDebuggerOpen_FunctionAddress, "ReturnValue");
		IsInputDebuggerOpen_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsInputDebuggerOpen_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsInputDebuggerOpen_IsValid = IsInputDebuggerOpen_FunctionAddress != IntPtr.Zero && IsInputDebuggerOpen_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSInputTargetBinding:IsInputDebuggerOpen", IsInputDebuggerOpen_IsValid);
		InputActionTrigger_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "InputActionTrigger");
		InputActionTrigger_ParamsSize = NativeReflection.GetFunctionParamsSize(InputActionTrigger_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref InputActionTrigger_ActionName_PropertyAddress, InputActionTrigger_FunctionAddress, "ActionName");
		InputActionTrigger_ActionName_Offset = NativeReflectionCached.GetPropertyOffset(InputActionTrigger_FunctionAddress, "ActionName");
		InputActionTrigger_ActionName_IsValid = NativeReflectionCached.ValidatePropertyClass(InputActionTrigger_FunctionAddress, "ActionName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref InputActionTrigger_TriggerEvent_PropertyAddress, InputActionTrigger_FunctionAddress, "TriggerEvent");
		InputActionTrigger_TriggerEvent_Offset = NativeReflectionCached.GetPropertyOffset(InputActionTrigger_FunctionAddress, "TriggerEvent");
		InputActionTrigger_TriggerEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(InputActionTrigger_FunctionAddress, "TriggerEvent", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref InputActionTrigger_InputActionValueType_PropertyAddress, InputActionTrigger_FunctionAddress, "InputActionValueType");
		InputActionTrigger_InputActionValueType_Offset = NativeReflectionCached.GetPropertyOffset(InputActionTrigger_FunctionAddress, "InputActionValueType");
		InputActionTrigger_InputActionValueType_IsValid = NativeReflectionCached.ValidatePropertyClass(InputActionTrigger_FunctionAddress, "InputActionValueType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref InputActionTrigger_InputActionValue_PropertyAddress, InputActionTrigger_FunctionAddress, "InputActionValue");
		InputActionTrigger_InputActionValue_Offset = NativeReflectionCached.GetPropertyOffset(InputActionTrigger_FunctionAddress, "InputActionValue");
		InputActionTrigger_InputActionValue_IsValid = NativeReflectionCached.ValidatePropertyClass(InputActionTrigger_FunctionAddress, "InputActionValue", Classes.FStructProperty);
		InputActionTrigger_IsValid = InputActionTrigger_FunctionAddress != IntPtr.Zero && InputActionTrigger_ActionName_IsValid && InputActionTrigger_TriggerEvent_IsValid && InputActionTrigger_InputActionValueType_IsValid && InputActionTrigger_InputActionValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSInputTargetBinding:InputActionTrigger", InputActionTrigger_IsValid);
		GetRichTextInlineIconInfo_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetRichTextInlineIconInfo");
		GetRichTextInlineIconInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRichTextInlineIconInfo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRichTextInlineIconInfo_BasePixelHeight_PropertyAddress, GetRichTextInlineIconInfo_FunctionAddress, "BasePixelHeight");
		GetRichTextInlineIconInfo_BasePixelHeight_Offset = NativeReflectionCached.GetPropertyOffset(GetRichTextInlineIconInfo_FunctionAddress, "BasePixelHeight");
		GetRichTextInlineIconInfo_BasePixelHeight_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRichTextInlineIconInfo_FunctionAddress, "BasePixelHeight", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRichTextInlineIconInfo_BaselineOffset_PropertyAddress, GetRichTextInlineIconInfo_FunctionAddress, "BaselineOffset");
		GetRichTextInlineIconInfo_BaselineOffset_Offset = NativeReflectionCached.GetPropertyOffset(GetRichTextInlineIconInfo_FunctionAddress, "BaselineOffset");
		GetRichTextInlineIconInfo_BaselineOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRichTextInlineIconInfo_FunctionAddress, "BaselineOffset", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRichTextInlineIconInfo_ConnectIconOffset_PropertyAddress, GetRichTextInlineIconInfo_FunctionAddress, "ConnectIconOffset");
		GetRichTextInlineIconInfo_ConnectIconOffset_Offset = NativeReflectionCached.GetPropertyOffset(GetRichTextInlineIconInfo_FunctionAddress, "ConnectIconOffset");
		GetRichTextInlineIconInfo_ConnectIconOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRichTextInlineIconInfo_FunctionAddress, "ConnectIconOffset", Classes.FIntProperty);
		GetRichTextInlineIconInfo_IsValid = GetRichTextInlineIconInfo_FunctionAddress != IntPtr.Zero && GetRichTextInlineIconInfo_BasePixelHeight_IsValid && GetRichTextInlineIconInfo_BaselineOffset_IsValid && GetRichTextInlineIconInfo_ConnectIconOffset_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSInputTargetBinding:GetRichTextInlineIconInfo", GetRichTextInlineIconInfo_IsValid);
		FetchDebugInfo_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "FetchDebugInfo");
		FetchDebugInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(FetchDebugInfo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FetchDebugInfo_DebugLines_PropertyAddress, FetchDebugInfo_FunctionAddress, "DebugLines");
		FetchDebugInfo_DebugLines_Offset = NativeReflectionCached.GetPropertyOffset(FetchDebugInfo_FunctionAddress, "DebugLines");
		FetchDebugInfo_DebugLines_IsValid = NativeReflectionCached.ValidatePropertyClass(FetchDebugInfo_FunctionAddress, "DebugLines", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref FetchDebugInfo_DebugColors_PropertyAddress, FetchDebugInfo_FunctionAddress, "DebugColors");
		FetchDebugInfo_DebugColors_Offset = NativeReflectionCached.GetPropertyOffset(FetchDebugInfo_FunctionAddress, "DebugColors");
		FetchDebugInfo_DebugColors_IsValid = NativeReflectionCached.ValidatePropertyClass(FetchDebugInfo_FunctionAddress, "DebugColors", Classes.FArrayProperty);
		FetchDebugInfo_IsValid = FetchDebugInfo_FunctionAddress != IntPtr.Zero && FetchDebugInfo_DebugLines_IsValid && FetchDebugInfo_DebugColors_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSInputTargetBinding:FetchDebugInfo", FetchDebugInfo_IsValid);
		CompletedActionListener_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CompletedActionListener");
		CompletedActionListener_ParamsSize = NativeReflection.GetFunctionParamsSize(CompletedActionListener_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CompletedActionListener_ActionInstance_PropertyAddress, CompletedActionListener_FunctionAddress, "ActionInstance");
		CompletedActionListener_ActionInstance_Offset = NativeReflectionCached.GetPropertyOffset(CompletedActionListener_FunctionAddress, "ActionInstance");
		CompletedActionListener_ActionInstance_IsValid = NativeReflectionCached.ValidatePropertyClass(CompletedActionListener_FunctionAddress, "ActionInstance", Classes.FStructProperty);
		CompletedActionListener_IsValid = CompletedActionListener_FunctionAddress != IntPtr.Zero && CompletedActionListener_ActionInstance_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSInputTargetBinding:CompletedActionListener", CompletedActionListener_IsValid);
		CanceledActionListener_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CanceledActionListener");
		CanceledActionListener_ParamsSize = NativeReflection.GetFunctionParamsSize(CanceledActionListener_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CanceledActionListener_ActionInstance_PropertyAddress, CanceledActionListener_FunctionAddress, "ActionInstance");
		CanceledActionListener_ActionInstance_Offset = NativeReflectionCached.GetPropertyOffset(CanceledActionListener_FunctionAddress, "ActionInstance");
		CanceledActionListener_ActionInstance_IsValid = NativeReflectionCached.ValidatePropertyClass(CanceledActionListener_FunctionAddress, "ActionInstance", Classes.FStructProperty);
		CanceledActionListener_IsValid = CanceledActionListener_FunctionAddress != IntPtr.Zero && CanceledActionListener_ActionInstance_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSInputTargetBinding:CanceledActionListener", CanceledActionListener_IsValid);
		ActionListener_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ActionListener");
		ActionListener_ParamsSize = NativeReflection.GetFunctionParamsSize(ActionListener_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ActionListener_ActionInstance_PropertyAddress, ActionListener_FunctionAddress, "ActionInstance");
		ActionListener_ActionInstance_Offset = NativeReflectionCached.GetPropertyOffset(ActionListener_FunctionAddress, "ActionInstance");
		ActionListener_ActionInstance_IsValid = NativeReflectionCached.ValidatePropertyClass(ActionListener_FunctionAddress, "ActionInstance", Classes.FStructProperty);
		ActionListener_IsValid = ActionListener_FunctionAddress != IntPtr.Zero && ActionListener_ActionInstance_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSInputTargetBinding:ActionListener", ActionListener_IsValid);
	}
}
