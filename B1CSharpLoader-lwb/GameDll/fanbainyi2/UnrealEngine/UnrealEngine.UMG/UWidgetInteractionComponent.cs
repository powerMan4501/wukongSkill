using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.InputCore;
using UnrealEngine.Runtime;

namespace UnrealEngine.UMG;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/UMG.WidgetInteractionComponent", "UMG", UnrealModuleType.Engine)]
public class UWidgetInteractionComponent : USceneComponent
{
	private static bool OnHoveredWidgetChanged_IsValid;

	private static int OnHoveredWidgetChanged_Offset;

	private FOnHoveredWidgetChanged OnHoveredWidgetChanged_DelegateCached;

	private static bool VirtualUserIndex_IsValid;

	private static int VirtualUserIndex_Offset;

	private static bool PointerIndex_IsValid;

	private static int PointerIndex_Offset;

	private static bool TraceChannel_IsValid;

	private static FFieldAddress TraceChannel_PropertyAddress;

	private static int TraceChannel_Offset;

	private static bool InteractionDistance_IsValid;

	private static int InteractionDistance_Offset;

	private static bool InteractionSource_IsValid;

	private static FFieldAddress InteractionSource_PropertyAddress;

	private static int InteractionSource_Offset;

	private static bool EnableHitTesting_IsValid;

	private static FFieldAddress EnableHitTesting_PropertyAddress;

	private static int EnableHitTesting_Offset;

	private static bool ShowDebug_IsValid;

	private static FFieldAddress ShowDebug_PropertyAddress;

	private static int ShowDebug_Offset;

	private static bool DebugSphereLineThickness_IsValid;

	private static int DebugSphereLineThickness_Offset;

	private static bool DebugLineThickness_IsValid;

	private static int DebugLineThickness_Offset;

	private static bool DebugColor_IsValid;

	private static int DebugColor_Offset;

	private static bool SetFocus_IsValid;

	private static IntPtr SetFocus_FunctionAddress;

	private static int SetFocus_ParamsSize;

	private static bool SetFocus_FocusWidget_IsValid;

	private static FFieldAddress SetFocus_FocusWidget_PropertyAddress;

	private static int SetFocus_FocusWidget_Offset;

	private static bool SetCustomHitResult_IsValid;

	private static IntPtr SetCustomHitResult_FunctionAddress;

	private static int SetCustomHitResult_ParamsSize;

	private static bool SetCustomHitResult_HitResult_IsValid;

	private static FFieldAddress SetCustomHitResult_HitResult_PropertyAddress;

	private static int SetCustomHitResult_HitResult_Offset;

	private static bool SendKeyChar_IsValid;

	private static IntPtr SendKeyChar_FunctionAddress;

	private static int SendKeyChar_ParamsSize;

	private static bool SendKeyChar_Characters_IsValid;

	private static FFieldAddress SendKeyChar_Characters_PropertyAddress;

	private static int SendKeyChar_Characters_Offset;

	private static bool SendKeyChar_bRepeat_IsValid;

	private static FFieldAddress SendKeyChar_bRepeat_PropertyAddress;

	private static int SendKeyChar_bRepeat_Offset;

	private static bool SendKeyChar_ReturnValue_IsValid;

	private static FFieldAddress SendKeyChar_ReturnValue_PropertyAddress;

	private static int SendKeyChar_ReturnValue_Offset;

	private static bool ScrollWheel_IsValid;

	private static IntPtr ScrollWheel_FunctionAddress;

	private static int ScrollWheel_ParamsSize;

	private static bool ScrollWheel_ScrollDelta_IsValid;

	private static FFieldAddress ScrollWheel_ScrollDelta_PropertyAddress;

	private static int ScrollWheel_ScrollDelta_Offset;

	private static bool ReleasePointerKey_IsValid;

	private static IntPtr ReleasePointerKey_FunctionAddress;

	private static int ReleasePointerKey_ParamsSize;

	private static bool ReleasePointerKey_Key_IsValid;

	private static FFieldAddress ReleasePointerKey_Key_PropertyAddress;

	private static int ReleasePointerKey_Key_Offset;

	private static bool ReleaseKey_IsValid;

	private static IntPtr ReleaseKey_FunctionAddress;

	private static int ReleaseKey_ParamsSize;

	private static bool ReleaseKey_Key_IsValid;

	private static FFieldAddress ReleaseKey_Key_PropertyAddress;

	private static int ReleaseKey_Key_Offset;

	private static bool ReleaseKey_ReturnValue_IsValid;

	private static FFieldAddress ReleaseKey_ReturnValue_PropertyAddress;

	private static int ReleaseKey_ReturnValue_Offset;

	private static bool PressPointerKey_IsValid;

	private static IntPtr PressPointerKey_FunctionAddress;

	private static int PressPointerKey_ParamsSize;

	private static bool PressPointerKey_Key_IsValid;

	private static FFieldAddress PressPointerKey_Key_PropertyAddress;

	private static int PressPointerKey_Key_Offset;

	private static bool PressKey_IsValid;

	private static IntPtr PressKey_FunctionAddress;

	private static int PressKey_ParamsSize;

	private static bool PressKey_Key_IsValid;

	private static FFieldAddress PressKey_Key_PropertyAddress;

	private static int PressKey_Key_Offset;

	private static bool PressKey_bRepeat_IsValid;

	private static FFieldAddress PressKey_bRepeat_PropertyAddress;

	private static int PressKey_bRepeat_Offset;

	private static bool PressKey_ReturnValue_IsValid;

	private static FFieldAddress PressKey_ReturnValue_PropertyAddress;

	private static int PressKey_ReturnValue_Offset;

	private static bool PressAndReleaseKey_IsValid;

	private static IntPtr PressAndReleaseKey_FunctionAddress;

	private static int PressAndReleaseKey_ParamsSize;

	private static bool PressAndReleaseKey_Key_IsValid;

	private static FFieldAddress PressAndReleaseKey_Key_PropertyAddress;

	private static int PressAndReleaseKey_Key_Offset;

	private static bool PressAndReleaseKey_ReturnValue_IsValid;

	private static FFieldAddress PressAndReleaseKey_ReturnValue_PropertyAddress;

	private static int PressAndReleaseKey_ReturnValue_Offset;

	private static bool IsOverInteractableWidget_IsValid;

	private static IntPtr IsOverInteractableWidget_FunctionAddress;

	private static int IsOverInteractableWidget_ParamsSize;

	private static bool IsOverInteractableWidget_ReturnValue_IsValid;

	private static FFieldAddress IsOverInteractableWidget_ReturnValue_PropertyAddress;

	private static int IsOverInteractableWidget_ReturnValue_Offset;

	private static bool IsOverHitTestVisibleWidget_IsValid;

	private static IntPtr IsOverHitTestVisibleWidget_FunctionAddress;

	private static int IsOverHitTestVisibleWidget_ParamsSize;

	private static bool IsOverHitTestVisibleWidget_ReturnValue_IsValid;

	private static FFieldAddress IsOverHitTestVisibleWidget_ReturnValue_PropertyAddress;

	private static int IsOverHitTestVisibleWidget_ReturnValue_Offset;

	private static bool IsOverFocusableWidget_IsValid;

	private static IntPtr IsOverFocusableWidget_FunctionAddress;

	private static int IsOverFocusableWidget_ParamsSize;

	private static bool IsOverFocusableWidget_ReturnValue_IsValid;

	private static FFieldAddress IsOverFocusableWidget_ReturnValue_PropertyAddress;

	private static int IsOverFocusableWidget_ReturnValue_Offset;

	private static bool GetLastHitResult_IsValid;

	private static IntPtr GetLastHitResult_FunctionAddress;

	private static int GetLastHitResult_ParamsSize;

	private static bool GetLastHitResult_ReturnValue_IsValid;

	private static FFieldAddress GetLastHitResult_ReturnValue_PropertyAddress;

	private static int GetLastHitResult_ReturnValue_Offset;

	private static bool GetHoveredWidgetComponent_IsValid;

	private static IntPtr GetHoveredWidgetComponent_FunctionAddress;

	private static int GetHoveredWidgetComponent_ParamsSize;

	private static bool GetHoveredWidgetComponent_ReturnValue_IsValid;

	private static FFieldAddress GetHoveredWidgetComponent_ReturnValue_PropertyAddress;

	private static int GetHoveredWidgetComponent_ReturnValue_Offset;

	private static bool Get2DHitLocation_IsValid;

	private static IntPtr Get2DHitLocation_FunctionAddress;

	private static int Get2DHitLocation_ParamsSize;

	private static bool Get2DHitLocation_ReturnValue_IsValid;

	private static FFieldAddress Get2DHitLocation_ReturnValue_PropertyAddress;

	private static int Get2DHitLocation_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/UMG.WidgetInteractionComponent:OnHoveredWidgetChanged")]
	public FOnHoveredWidgetChanged OnHoveredWidgetChanged
	{
		get
		{
			CheckDestroyed();
			if (!OnHoveredWidgetChanged_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.WidgetInteractionComponent:OnHoveredWidgetChanged");
				return new FOnHoveredWidgetChanged();
			}
			if (OnHoveredWidgetChanged_DelegateCached == null)
			{
				OnHoveredWidgetChanged_DelegateCached = new FOnHoveredWidgetChanged();
				OnHoveredWidgetChanged_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnHoveredWidgetChanged_Offset));
			}
			return OnHoveredWidgetChanged_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)7036944210985477uL)]
	[UMetaPath("/Script/UMG.WidgetInteractionComponent:VirtualUserIndex")]
	public int VirtualUserIndex
	{
		get
		{
			CheckDestroyed();
			if (!VirtualUserIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.WidgetInteractionComponent:VirtualUserIndex");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, VirtualUserIndex_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VirtualUserIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.WidgetInteractionComponent:VirtualUserIndex");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, VirtualUserIndex_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7036944210985477uL)]
	[UMetaPath("/Script/UMG.WidgetInteractionComponent:PointerIndex")]
	public int PointerIndex
	{
		get
		{
			CheckDestroyed();
			if (!PointerIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.WidgetInteractionComponent:PointerIndex");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, PointerIndex_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PointerIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.WidgetInteractionComponent:PointerIndex");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, PointerIndex_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UMG.WidgetInteractionComponent:TraceChannel")]
	public ECollisionChannel TraceChannel
	{
		get
		{
			CheckDestroyed();
			if (!TraceChannel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.WidgetInteractionComponent:TraceChannel");
				return ECollisionChannel.ECC_WorldStatic;
			}
			return EnumMarshaler<ECollisionChannel>.FromNative(IntPtr.Add(base.Address, TraceChannel_Offset), 0, TraceChannel_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!TraceChannel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.WidgetInteractionComponent:TraceChannel");
			}
			else
			{
				EnumMarshaler<ECollisionChannel>.ToNative(IntPtr.Add(base.Address, TraceChannel_Offset), 0, TraceChannel_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UMG.WidgetInteractionComponent:InteractionDistance")]
	public float InteractionDistance
	{
		get
		{
			CheckDestroyed();
			if (!InteractionDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.WidgetInteractionComponent:InteractionDistance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, InteractionDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InteractionDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.WidgetInteractionComponent:InteractionDistance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, InteractionDistance_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UMG.WidgetInteractionComponent:InteractionSource")]
	public EWidgetInteractionSource InteractionSource
	{
		get
		{
			CheckDestroyed();
			if (!InteractionSource_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.WidgetInteractionComponent:InteractionSource");
				return EWidgetInteractionSource.World;
			}
			return EnumMarshaler<EWidgetInteractionSource>.FromNative(IntPtr.Add(base.Address, InteractionSource_Offset), 0, InteractionSource_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!InteractionSource_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.WidgetInteractionComponent:InteractionSource");
			}
			else
			{
				EnumMarshaler<EWidgetInteractionSource>.ToNative(IntPtr.Add(base.Address, InteractionSource_Offset), 0, InteractionSource_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UMG.WidgetInteractionComponent:bEnableHitTesting")]
	public bool EnableHitTesting
	{
		get
		{
			CheckDestroyed();
			if (!EnableHitTesting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.WidgetInteractionComponent:bEnableHitTesting");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableHitTesting_Offset), 0, EnableHitTesting_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableHitTesting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.WidgetInteractionComponent:bEnableHitTesting");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableHitTesting_Offset), 0, EnableHitTesting_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UMG.WidgetInteractionComponent:bShowDebug")]
	public bool ShowDebug
	{
		get
		{
			CheckDestroyed();
			if (!ShowDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.WidgetInteractionComponent:bShowDebug");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ShowDebug_Offset), 0, ShowDebug_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ShowDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.WidgetInteractionComponent:bShowDebug");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ShowDebug_Offset), 0, ShowDebug_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/UMG.WidgetInteractionComponent:DebugSphereLineThickness")]
	public float DebugSphereLineThickness
	{
		get
		{
			CheckDestroyed();
			if (!DebugSphereLineThickness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.WidgetInteractionComponent:DebugSphereLineThickness");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DebugSphereLineThickness_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DebugSphereLineThickness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.WidgetInteractionComponent:DebugSphereLineThickness");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DebugSphereLineThickness_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/UMG.WidgetInteractionComponent:DebugLineThickness")]
	public float DebugLineThickness
	{
		get
		{
			CheckDestroyed();
			if (!DebugLineThickness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.WidgetInteractionComponent:DebugLineThickness");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DebugLineThickness_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DebugLineThickness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.WidgetInteractionComponent:DebugLineThickness");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DebugLineThickness_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/UMG.WidgetInteractionComponent:DebugColor")]
	public FLinearColor DebugColor
	{
		get
		{
			CheckDestroyed();
			if (!DebugColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.WidgetInteractionComponent:DebugColor");
				return default(FLinearColor);
			}
			return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(base.Address, DebugColor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DebugColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.WidgetInteractionComponent:DebugColor");
			}
			else
			{
				BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(base.Address, DebugColor_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.WidgetInteractionComponent:SetFocus")]
	public unsafe void SetFocus(UWidget FocusWidget)
	{
		CheckDestroyed();
		if (!SetFocus_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetInteractionComponent:SetFocus");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetFocus_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetFocus_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidget>.ToNative(IntPtr.Add(intPtr, SetFocus_FocusWidget_Offset), 0, SetFocus_FocusWidget_PropertyAddress.Address, FocusWidget);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetFocus_FunctionAddress, intPtr, SetFocus_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/UMG.WidgetInteractionComponent:SetCustomHitResult")]
	public unsafe void SetCustomHitResult(FHitResult HitResult)
	{
		CheckDestroyed();
		if (!SetCustomHitResult_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetInteractionComponent:SetCustomHitResult");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCustomHitResult_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCustomHitResult_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetCustomHitResult_HitResult_PropertyAddress.Address, intPtr);
		FHitResult.ToNative(IntPtr.Add(intPtr, SetCustomHitResult_HitResult_Offset), 0, SetCustomHitResult_HitResult_PropertyAddress.Address, HitResult);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCustomHitResult_FunctionAddress, intPtr, SetCustomHitResult_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/UMG.WidgetInteractionComponent:SendKeyChar")]
	public unsafe bool SendKeyChar(string Characters, bool bRepeat = false)
	{
		CheckDestroyed();
		if (!SendKeyChar_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetInteractionComponent:SendKeyChar");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SendKeyChar_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SendKeyChar_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SendKeyChar_Characters_Offset), 0, SendKeyChar_Characters_PropertyAddress.Address, Characters);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SendKeyChar_bRepeat_Offset), 0, SendKeyChar_bRepeat_PropertyAddress.Address, bRepeat);
		NativeReflection.InvokeFunctionOptimized(base.Address, SendKeyChar_FunctionAddress, intPtr, SendKeyChar_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SendKeyChar_Characters_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SendKeyChar_ReturnValue_Offset), 0, SendKeyChar_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/UMG.WidgetInteractionComponent:ScrollWheel")]
	public unsafe void ScrollWheel(float ScrollDelta)
	{
		CheckDestroyed();
		if (!ScrollWheel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetInteractionComponent:ScrollWheel");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ScrollWheel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ScrollWheel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ScrollWheel_ScrollDelta_Offset), 0, ScrollWheel_ScrollDelta_PropertyAddress.Address, ScrollDelta);
		NativeReflection.InvokeFunctionOptimized(base.Address, ScrollWheel_FunctionAddress, intPtr, ScrollWheel_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/UMG.WidgetInteractionComponent:ReleasePointerKey")]
	public unsafe void ReleasePointerKey(FKey Key)
	{
		CheckDestroyed();
		if (!ReleasePointerKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetInteractionComponent:ReleasePointerKey");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReleasePointerKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReleasePointerKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(ReleasePointerKey_Key_PropertyAddress.Address, intPtr);
		FKey.ToNative(IntPtr.Add(intPtr, ReleasePointerKey_Key_Offset), 0, ReleasePointerKey_Key_PropertyAddress.Address, Key);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReleasePointerKey_FunctionAddress, intPtr, ReleasePointerKey_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ReleasePointerKey_Key_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/UMG.WidgetInteractionComponent:ReleaseKey")]
	public unsafe bool ReleaseKey(FKey Key)
	{
		CheckDestroyed();
		if (!ReleaseKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetInteractionComponent:ReleaseKey");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReleaseKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReleaseKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(ReleaseKey_Key_PropertyAddress.Address, intPtr);
		FKey.ToNative(IntPtr.Add(intPtr, ReleaseKey_Key_Offset), 0, ReleaseKey_Key_PropertyAddress.Address, Key);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReleaseKey_FunctionAddress, intPtr, ReleaseKey_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ReleaseKey_Key_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ReleaseKey_ReturnValue_Offset), 0, ReleaseKey_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/UMG.WidgetInteractionComponent:PressPointerKey")]
	public unsafe void PressPointerKey(FKey Key)
	{
		CheckDestroyed();
		if (!PressPointerKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetInteractionComponent:PressPointerKey");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PressPointerKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PressPointerKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(PressPointerKey_Key_PropertyAddress.Address, intPtr);
		FKey.ToNative(IntPtr.Add(intPtr, PressPointerKey_Key_Offset), 0, PressPointerKey_Key_PropertyAddress.Address, Key);
		NativeReflection.InvokeFunctionOptimized(base.Address, PressPointerKey_FunctionAddress, intPtr, PressPointerKey_ParamsSize);
		NativeReflection.DestroyValue_InContainer(PressPointerKey_Key_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/UMG.WidgetInteractionComponent:PressKey")]
	public unsafe bool PressKey(FKey Key, bool bRepeat = false)
	{
		CheckDestroyed();
		if (!PressKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetInteractionComponent:PressKey");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PressKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PressKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(PressKey_Key_PropertyAddress.Address, intPtr);
		FKey.ToNative(IntPtr.Add(intPtr, PressKey_Key_Offset), 0, PressKey_Key_PropertyAddress.Address, Key);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, PressKey_bRepeat_Offset), 0, PressKey_bRepeat_PropertyAddress.Address, bRepeat);
		NativeReflection.InvokeFunctionOptimized(base.Address, PressKey_FunctionAddress, intPtr, PressKey_ParamsSize);
		NativeReflection.DestroyValue_InContainer(PressKey_Key_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, PressKey_ReturnValue_Offset), 0, PressKey_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/UMG.WidgetInteractionComponent:PressAndReleaseKey")]
	public unsafe bool PressAndReleaseKey(FKey Key)
	{
		CheckDestroyed();
		if (!PressAndReleaseKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetInteractionComponent:PressAndReleaseKey");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PressAndReleaseKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PressAndReleaseKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(PressAndReleaseKey_Key_PropertyAddress.Address, intPtr);
		FKey.ToNative(IntPtr.Add(intPtr, PressAndReleaseKey_Key_Offset), 0, PressAndReleaseKey_Key_PropertyAddress.Address, Key);
		NativeReflection.InvokeFunctionOptimized(base.Address, PressAndReleaseKey_FunctionAddress, intPtr, PressAndReleaseKey_ParamsSize);
		NativeReflection.DestroyValue_InContainer(PressAndReleaseKey_Key_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, PressAndReleaseKey_ReturnValue_Offset), 0, PressAndReleaseKey_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.WidgetInteractionComponent:IsOverInteractableWidget")]
	public unsafe bool IsOverInteractableWidget()
	{
		CheckDestroyed();
		if (!IsOverInteractableWidget_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetInteractionComponent:IsOverInteractableWidget");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsOverInteractableWidget_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsOverInteractableWidget_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsOverInteractableWidget_FunctionAddress, intPtr, IsOverInteractableWidget_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsOverInteractableWidget_ReturnValue_Offset), 0, IsOverInteractableWidget_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.WidgetInteractionComponent:IsOverHitTestVisibleWidget")]
	public unsafe bool IsOverHitTestVisibleWidget()
	{
		CheckDestroyed();
		if (!IsOverHitTestVisibleWidget_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetInteractionComponent:IsOverHitTestVisibleWidget");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsOverHitTestVisibleWidget_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsOverHitTestVisibleWidget_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsOverHitTestVisibleWidget_FunctionAddress, intPtr, IsOverHitTestVisibleWidget_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsOverHitTestVisibleWidget_ReturnValue_Offset), 0, IsOverHitTestVisibleWidget_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.WidgetInteractionComponent:IsOverFocusableWidget")]
	public unsafe bool IsOverFocusableWidget()
	{
		CheckDestroyed();
		if (!IsOverFocusableWidget_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetInteractionComponent:IsOverFocusableWidget");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsOverFocusableWidget_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsOverFocusableWidget_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsOverFocusableWidget_FunctionAddress, intPtr, IsOverFocusableWidget_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsOverFocusableWidget_ReturnValue_Offset), 0, IsOverFocusableWidget_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.WidgetInteractionComponent:GetLastHitResult")]
	public unsafe FHitResult GetLastHitResult()
	{
		CheckDestroyed();
		if (!GetLastHitResult_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetInteractionComponent:GetLastHitResult");
			return default(FHitResult);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLastHitResult_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLastHitResult_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetLastHitResult_FunctionAddress, intPtr, GetLastHitResult_ParamsSize);
		return FHitResult.FromNative(IntPtr.Add(intPtr, GetLastHitResult_ReturnValue_Offset), 0, GetLastHitResult_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.WidgetInteractionComponent:GetHoveredWidgetComponent")]
	public unsafe UWidgetComponent GetHoveredWidgetComponent()
	{
		CheckDestroyed();
		if (!GetHoveredWidgetComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetInteractionComponent:GetHoveredWidgetComponent");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetHoveredWidgetComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetHoveredWidgetComponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetHoveredWidgetComponent_FunctionAddress, intPtr, GetHoveredWidgetComponent_ParamsSize);
		return UObjectMarshaler<UWidgetComponent>.FromNative(IntPtr.Add(intPtr, GetHoveredWidgetComponent_ReturnValue_Offset), 0, GetHoveredWidgetComponent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/UMG.WidgetInteractionComponent:Get2DHitLocation")]
	public unsafe FVector2D Get2DHitLocation()
	{
		CheckDestroyed();
		if (!Get2DHitLocation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetInteractionComponent:Get2DHitLocation");
			return default(FVector2D);
		}
		byte* ptr = stackalloc byte[(int)(uint)(Get2DHitLocation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Get2DHitLocation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, Get2DHitLocation_FunctionAddress, intPtr, Get2DHitLocation_ParamsSize);
		return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, Get2DHitLocation_ReturnValue_Offset), 0, Get2DHitLocation_ReturnValue_PropertyAddress.Address);
	}

	static UWidgetInteractionComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UWidgetInteractionComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UWidgetInteractionComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/UMG.WidgetInteractionComponent");
		OnHoveredWidgetChanged_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnHoveredWidgetChanged");
		OnHoveredWidgetChanged_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnHoveredWidgetChanged", Classes.FMulticastDelegateProperty);
		VirtualUserIndex_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VirtualUserIndex");
		VirtualUserIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VirtualUserIndex", Classes.FIntProperty);
		PointerIndex_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PointerIndex");
		PointerIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PointerIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref TraceChannel_PropertyAddress, intPtr, "TraceChannel");
		TraceChannel_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TraceChannel");
		TraceChannel_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TraceChannel", Classes.FByteProperty);
		InteractionDistance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InteractionDistance");
		InteractionDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InteractionDistance", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref InteractionSource_PropertyAddress, intPtr, "InteractionSource");
		InteractionSource_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InteractionSource");
		InteractionSource_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InteractionSource", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableHitTesting_PropertyAddress, intPtr, "bEnableHitTesting");
		EnableHitTesting_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnableHitTesting");
		EnableHitTesting_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnableHitTesting", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ShowDebug_PropertyAddress, intPtr, "bShowDebug");
		ShowDebug_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bShowDebug");
		ShowDebug_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bShowDebug", Classes.FBoolProperty);
		DebugSphereLineThickness_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DebugSphereLineThickness");
		DebugSphereLineThickness_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DebugSphereLineThickness", Classes.FFloatProperty);
		DebugLineThickness_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DebugLineThickness");
		DebugLineThickness_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DebugLineThickness", Classes.FFloatProperty);
		DebugColor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DebugColor");
		DebugColor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DebugColor", Classes.FStructProperty);
		SetFocus_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetFocus");
		SetFocus_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFocus_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetFocus_FocusWidget_PropertyAddress, SetFocus_FunctionAddress, "FocusWidget");
		SetFocus_FocusWidget_Offset = NativeReflectionCached.GetPropertyOffset(SetFocus_FunctionAddress, "FocusWidget");
		SetFocus_FocusWidget_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFocus_FunctionAddress, "FocusWidget", Classes.FObjectProperty);
		SetFocus_IsValid = SetFocus_FunctionAddress != IntPtr.Zero && SetFocus_FocusWidget_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetInteractionComponent:SetFocus", SetFocus_IsValid);
		SetCustomHitResult_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetCustomHitResult");
		SetCustomHitResult_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCustomHitResult_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCustomHitResult_HitResult_PropertyAddress, SetCustomHitResult_FunctionAddress, "HitResult");
		SetCustomHitResult_HitResult_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomHitResult_FunctionAddress, "HitResult");
		SetCustomHitResult_HitResult_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomHitResult_FunctionAddress, "HitResult", Classes.FStructProperty);
		SetCustomHitResult_IsValid = SetCustomHitResult_FunctionAddress != IntPtr.Zero && SetCustomHitResult_HitResult_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetInteractionComponent:SetCustomHitResult", SetCustomHitResult_IsValid);
		SendKeyChar_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SendKeyChar");
		SendKeyChar_ParamsSize = NativeReflection.GetFunctionParamsSize(SendKeyChar_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SendKeyChar_Characters_PropertyAddress, SendKeyChar_FunctionAddress, "Characters");
		SendKeyChar_Characters_Offset = NativeReflectionCached.GetPropertyOffset(SendKeyChar_FunctionAddress, "Characters");
		SendKeyChar_Characters_IsValid = NativeReflectionCached.ValidatePropertyClass(SendKeyChar_FunctionAddress, "Characters", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SendKeyChar_bRepeat_PropertyAddress, SendKeyChar_FunctionAddress, "bRepeat");
		SendKeyChar_bRepeat_Offset = NativeReflectionCached.GetPropertyOffset(SendKeyChar_FunctionAddress, "bRepeat");
		SendKeyChar_bRepeat_IsValid = NativeReflectionCached.ValidatePropertyClass(SendKeyChar_FunctionAddress, "bRepeat", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SendKeyChar_ReturnValue_PropertyAddress, SendKeyChar_FunctionAddress, "ReturnValue");
		SendKeyChar_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SendKeyChar_FunctionAddress, "ReturnValue");
		SendKeyChar_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SendKeyChar_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SendKeyChar_IsValid = SendKeyChar_FunctionAddress != IntPtr.Zero && SendKeyChar_Characters_IsValid && SendKeyChar_bRepeat_IsValid && SendKeyChar_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetInteractionComponent:SendKeyChar", SendKeyChar_IsValid);
		ScrollWheel_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ScrollWheel");
		ScrollWheel_ParamsSize = NativeReflection.GetFunctionParamsSize(ScrollWheel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ScrollWheel_ScrollDelta_PropertyAddress, ScrollWheel_FunctionAddress, "ScrollDelta");
		ScrollWheel_ScrollDelta_Offset = NativeReflectionCached.GetPropertyOffset(ScrollWheel_FunctionAddress, "ScrollDelta");
		ScrollWheel_ScrollDelta_IsValid = NativeReflectionCached.ValidatePropertyClass(ScrollWheel_FunctionAddress, "ScrollDelta", Classes.FFloatProperty);
		ScrollWheel_IsValid = ScrollWheel_FunctionAddress != IntPtr.Zero && ScrollWheel_ScrollDelta_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetInteractionComponent:ScrollWheel", ScrollWheel_IsValid);
		ReleasePointerKey_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReleasePointerKey");
		ReleasePointerKey_ParamsSize = NativeReflection.GetFunctionParamsSize(ReleasePointerKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReleasePointerKey_Key_PropertyAddress, ReleasePointerKey_FunctionAddress, "Key");
		ReleasePointerKey_Key_Offset = NativeReflectionCached.GetPropertyOffset(ReleasePointerKey_FunctionAddress, "Key");
		ReleasePointerKey_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(ReleasePointerKey_FunctionAddress, "Key", Classes.FStructProperty);
		ReleasePointerKey_IsValid = ReleasePointerKey_FunctionAddress != IntPtr.Zero && ReleasePointerKey_Key_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetInteractionComponent:ReleasePointerKey", ReleasePointerKey_IsValid);
		ReleaseKey_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReleaseKey");
		ReleaseKey_ParamsSize = NativeReflection.GetFunctionParamsSize(ReleaseKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReleaseKey_Key_PropertyAddress, ReleaseKey_FunctionAddress, "Key");
		ReleaseKey_Key_Offset = NativeReflectionCached.GetPropertyOffset(ReleaseKey_FunctionAddress, "Key");
		ReleaseKey_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(ReleaseKey_FunctionAddress, "Key", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ReleaseKey_ReturnValue_PropertyAddress, ReleaseKey_FunctionAddress, "ReturnValue");
		ReleaseKey_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ReleaseKey_FunctionAddress, "ReturnValue");
		ReleaseKey_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ReleaseKey_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ReleaseKey_IsValid = ReleaseKey_FunctionAddress != IntPtr.Zero && ReleaseKey_Key_IsValid && ReleaseKey_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetInteractionComponent:ReleaseKey", ReleaseKey_IsValid);
		PressPointerKey_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PressPointerKey");
		PressPointerKey_ParamsSize = NativeReflection.GetFunctionParamsSize(PressPointerKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PressPointerKey_Key_PropertyAddress, PressPointerKey_FunctionAddress, "Key");
		PressPointerKey_Key_Offset = NativeReflectionCached.GetPropertyOffset(PressPointerKey_FunctionAddress, "Key");
		PressPointerKey_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(PressPointerKey_FunctionAddress, "Key", Classes.FStructProperty);
		PressPointerKey_IsValid = PressPointerKey_FunctionAddress != IntPtr.Zero && PressPointerKey_Key_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetInteractionComponent:PressPointerKey", PressPointerKey_IsValid);
		PressKey_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PressKey");
		PressKey_ParamsSize = NativeReflection.GetFunctionParamsSize(PressKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PressKey_Key_PropertyAddress, PressKey_FunctionAddress, "Key");
		PressKey_Key_Offset = NativeReflectionCached.GetPropertyOffset(PressKey_FunctionAddress, "Key");
		PressKey_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(PressKey_FunctionAddress, "Key", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref PressKey_bRepeat_PropertyAddress, PressKey_FunctionAddress, "bRepeat");
		PressKey_bRepeat_Offset = NativeReflectionCached.GetPropertyOffset(PressKey_FunctionAddress, "bRepeat");
		PressKey_bRepeat_IsValid = NativeReflectionCached.ValidatePropertyClass(PressKey_FunctionAddress, "bRepeat", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref PressKey_ReturnValue_PropertyAddress, PressKey_FunctionAddress, "ReturnValue");
		PressKey_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(PressKey_FunctionAddress, "ReturnValue");
		PressKey_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(PressKey_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		PressKey_IsValid = PressKey_FunctionAddress != IntPtr.Zero && PressKey_Key_IsValid && PressKey_bRepeat_IsValid && PressKey_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetInteractionComponent:PressKey", PressKey_IsValid);
		PressAndReleaseKey_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PressAndReleaseKey");
		PressAndReleaseKey_ParamsSize = NativeReflection.GetFunctionParamsSize(PressAndReleaseKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PressAndReleaseKey_Key_PropertyAddress, PressAndReleaseKey_FunctionAddress, "Key");
		PressAndReleaseKey_Key_Offset = NativeReflectionCached.GetPropertyOffset(PressAndReleaseKey_FunctionAddress, "Key");
		PressAndReleaseKey_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(PressAndReleaseKey_FunctionAddress, "Key", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref PressAndReleaseKey_ReturnValue_PropertyAddress, PressAndReleaseKey_FunctionAddress, "ReturnValue");
		PressAndReleaseKey_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(PressAndReleaseKey_FunctionAddress, "ReturnValue");
		PressAndReleaseKey_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(PressAndReleaseKey_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		PressAndReleaseKey_IsValid = PressAndReleaseKey_FunctionAddress != IntPtr.Zero && PressAndReleaseKey_Key_IsValid && PressAndReleaseKey_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetInteractionComponent:PressAndReleaseKey", PressAndReleaseKey_IsValid);
		IsOverInteractableWidget_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsOverInteractableWidget");
		IsOverInteractableWidget_ParamsSize = NativeReflection.GetFunctionParamsSize(IsOverInteractableWidget_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsOverInteractableWidget_ReturnValue_PropertyAddress, IsOverInteractableWidget_FunctionAddress, "ReturnValue");
		IsOverInteractableWidget_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsOverInteractableWidget_FunctionAddress, "ReturnValue");
		IsOverInteractableWidget_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsOverInteractableWidget_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsOverInteractableWidget_IsValid = IsOverInteractableWidget_FunctionAddress != IntPtr.Zero && IsOverInteractableWidget_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetInteractionComponent:IsOverInteractableWidget", IsOverInteractableWidget_IsValid);
		IsOverHitTestVisibleWidget_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsOverHitTestVisibleWidget");
		IsOverHitTestVisibleWidget_ParamsSize = NativeReflection.GetFunctionParamsSize(IsOverHitTestVisibleWidget_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsOverHitTestVisibleWidget_ReturnValue_PropertyAddress, IsOverHitTestVisibleWidget_FunctionAddress, "ReturnValue");
		IsOverHitTestVisibleWidget_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsOverHitTestVisibleWidget_FunctionAddress, "ReturnValue");
		IsOverHitTestVisibleWidget_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsOverHitTestVisibleWidget_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsOverHitTestVisibleWidget_IsValid = IsOverHitTestVisibleWidget_FunctionAddress != IntPtr.Zero && IsOverHitTestVisibleWidget_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetInteractionComponent:IsOverHitTestVisibleWidget", IsOverHitTestVisibleWidget_IsValid);
		IsOverFocusableWidget_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsOverFocusableWidget");
		IsOverFocusableWidget_ParamsSize = NativeReflection.GetFunctionParamsSize(IsOverFocusableWidget_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsOverFocusableWidget_ReturnValue_PropertyAddress, IsOverFocusableWidget_FunctionAddress, "ReturnValue");
		IsOverFocusableWidget_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsOverFocusableWidget_FunctionAddress, "ReturnValue");
		IsOverFocusableWidget_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsOverFocusableWidget_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsOverFocusableWidget_IsValid = IsOverFocusableWidget_FunctionAddress != IntPtr.Zero && IsOverFocusableWidget_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetInteractionComponent:IsOverFocusableWidget", IsOverFocusableWidget_IsValid);
		GetLastHitResult_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetLastHitResult");
		GetLastHitResult_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLastHitResult_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLastHitResult_ReturnValue_PropertyAddress, GetLastHitResult_FunctionAddress, "ReturnValue");
		GetLastHitResult_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLastHitResult_FunctionAddress, "ReturnValue");
		GetLastHitResult_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLastHitResult_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetLastHitResult_IsValid = GetLastHitResult_FunctionAddress != IntPtr.Zero && GetLastHitResult_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetInteractionComponent:GetLastHitResult", GetLastHitResult_IsValid);
		GetHoveredWidgetComponent_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetHoveredWidgetComponent");
		GetHoveredWidgetComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(GetHoveredWidgetComponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetHoveredWidgetComponent_ReturnValue_PropertyAddress, GetHoveredWidgetComponent_FunctionAddress, "ReturnValue");
		GetHoveredWidgetComponent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetHoveredWidgetComponent_FunctionAddress, "ReturnValue");
		GetHoveredWidgetComponent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetHoveredWidgetComponent_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetHoveredWidgetComponent_IsValid = GetHoveredWidgetComponent_FunctionAddress != IntPtr.Zero && GetHoveredWidgetComponent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetInteractionComponent:GetHoveredWidgetComponent", GetHoveredWidgetComponent_IsValid);
		Get2DHitLocation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Get2DHitLocation");
		Get2DHitLocation_ParamsSize = NativeReflection.GetFunctionParamsSize(Get2DHitLocation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Get2DHitLocation_ReturnValue_PropertyAddress, Get2DHitLocation_FunctionAddress, "ReturnValue");
		Get2DHitLocation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Get2DHitLocation_FunctionAddress, "ReturnValue");
		Get2DHitLocation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Get2DHitLocation_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		Get2DHitLocation_IsValid = Get2DHitLocation_FunctionAddress != IntPtr.Zero && Get2DHitLocation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetInteractionComponent:Get2DHitLocation", Get2DHitLocation_IsValid);
	}
}
