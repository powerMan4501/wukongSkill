using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.UMG;

[Abstract]
[UClass(Flags = (ClassFlags)888144033uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/UMG.ListViewBase", "UMG", UnrealModuleType.Engine)]
public class UListViewBase : UWidget
{
	private static bool EntryWidgetClass_IsValid;

	private static int EntryWidgetClass_Offset;

	private static bool WheelScrollMultiplier_IsValid;

	private static int WheelScrollMultiplier_Offset;

	private static bool EnableScrollAnimation_IsValid;

	private static FFieldAddress EnableScrollAnimation_PropertyAddress;

	private static int EnableScrollAnimation_Offset;

	private static bool AllowDragging_IsValid;

	private static FFieldAddress AllowDragging_PropertyAddress;

	private static int AllowDragging_Offset;

	private static bool SetWheelScrollMultiplier_IsValid;

	private static IntPtr SetWheelScrollMultiplier_FunctionAddress;

	private static int SetWheelScrollMultiplier_ParamsSize;

	private static bool SetWheelScrollMultiplier_NewWheelScrollMultiplier_IsValid;

	private static FFieldAddress SetWheelScrollMultiplier_NewWheelScrollMultiplier_PropertyAddress;

	private static int SetWheelScrollMultiplier_NewWheelScrollMultiplier_Offset;

	private static bool SetScrollOffset_IsValid;

	private static IntPtr SetScrollOffset_FunctionAddress;

	private static int SetScrollOffset_ParamsSize;

	private static bool SetScrollOffset_InScrollOffset_IsValid;

	private static FFieldAddress SetScrollOffset_InScrollOffset_PropertyAddress;

	private static int SetScrollOffset_InScrollOffset_Offset;

	private static bool SetScrollbarVisibility_IsValid;

	private static IntPtr SetScrollbarVisibility_FunctionAddress;

	private static int SetScrollbarVisibility_ParamsSize;

	private static bool SetScrollbarVisibility_InVisibility_IsValid;

	private static FFieldAddress SetScrollbarVisibility_InVisibility_PropertyAddress;

	private static int SetScrollbarVisibility_InVisibility_Offset;

	private static bool ScrollToTop_IsValid;

	private static IntPtr ScrollToTop_FunctionAddress;

	private static int ScrollToTop_ParamsSize;

	private static bool ScrollToBottom_IsValid;

	private static IntPtr ScrollToBottom_FunctionAddress;

	private static int ScrollToBottom_ParamsSize;

	private static bool RequestRefresh_IsValid;

	private static IntPtr RequestRefresh_FunctionAddress;

	private static int RequestRefresh_ParamsSize;

	private static bool RegenerateAllEntries_IsValid;

	private static IntPtr RegenerateAllEntries_FunctionAddress;

	private static int RegenerateAllEntries_ParamsSize;

	private static bool GetScrollOffset_IsValid;

	private static IntPtr GetScrollOffset_FunctionAddress;

	private static int GetScrollOffset_ParamsSize;

	private static bool GetScrollOffset_ReturnValue_IsValid;

	private static FFieldAddress GetScrollOffset_ReturnValue_PropertyAddress;

	private static int GetScrollOffset_ReturnValue_Offset;

	private static bool GetDisplayedEntryWidgets_IsValid;

	private static IntPtr GetDisplayedEntryWidgets_FunctionAddress;

	private static int GetDisplayedEntryWidgets_ParamsSize;

	private static bool GetDisplayedEntryWidgets_ReturnValue_IsValid;

	private static FFieldAddress GetDisplayedEntryWidgets_ReturnValue_PropertyAddress;

	private static int GetDisplayedEntryWidgets_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)12393764861510165uL)]
	[UMetaPath("/Script/UMG.ListViewBase:EntryWidgetClass")]
	protected TSubclassOf<UUserWidget> EntryWidgetClass
	{
		get
		{
			CheckDestroyed();
			if (!EntryWidgetClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ListViewBase:EntryWidgetClass");
				return default(TSubclassOf<UUserWidget>);
			}
			return TSubclassOfMarshaler<UUserWidget>.FromNative(IntPtr.Add(base.Address, EntryWidgetClass_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EntryWidgetClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ListViewBase:EntryWidgetClass");
			}
			else
			{
				TSubclassOfMarshaler<UUserWidget>.ToNative(IntPtr.Add(base.Address, EntryWidgetClass_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667541uL)]
	[UMetaPath("/Script/UMG.ListViewBase:WheelScrollMultiplier")]
	protected float WheelScrollMultiplier
	{
		get
		{
			CheckDestroyed();
			if (!WheelScrollMultiplier_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ListViewBase:WheelScrollMultiplier");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, WheelScrollMultiplier_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WheelScrollMultiplier_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ListViewBase:WheelScrollMultiplier");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, WheelScrollMultiplier_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667541uL)]
	[UMetaPath("/Script/UMG.ListViewBase:bEnableScrollAnimation")]
	protected bool EnableScrollAnimation
	{
		get
		{
			CheckDestroyed();
			if (!EnableScrollAnimation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ListViewBase:bEnableScrollAnimation");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableScrollAnimation_Offset), 0, EnableScrollAnimation_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableScrollAnimation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ListViewBase:bEnableScrollAnimation");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableScrollAnimation_Offset), 0, EnableScrollAnimation_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667541uL)]
	[UMetaPath("/Script/UMG.ListViewBase:bAllowDragging")]
	protected bool AllowDragging
	{
		get
		{
			CheckDestroyed();
			if (!AllowDragging_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ListViewBase:bAllowDragging");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AllowDragging_Offset), 0, AllowDragging_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AllowDragging_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ListViewBase:bAllowDragging");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AllowDragging_Offset), 0, AllowDragging_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.ListViewBase:SetWheelScrollMultiplier")]
	public unsafe void SetWheelScrollMultiplier(float NewWheelScrollMultiplier)
	{
		CheckDestroyed();
		if (!SetWheelScrollMultiplier_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ListViewBase:SetWheelScrollMultiplier");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetWheelScrollMultiplier_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetWheelScrollMultiplier_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetWheelScrollMultiplier_NewWheelScrollMultiplier_Offset), 0, SetWheelScrollMultiplier_NewWheelScrollMultiplier_PropertyAddress.Address, NewWheelScrollMultiplier);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetWheelScrollMultiplier_FunctionAddress, intPtr, SetWheelScrollMultiplier_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.ListViewBase:SetScrollOffset")]
	public unsafe void SetScrollOffset(float InScrollOffset)
	{
		CheckDestroyed();
		if (!SetScrollOffset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ListViewBase:SetScrollOffset");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetScrollOffset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetScrollOffset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetScrollOffset_InScrollOffset_Offset), 0, SetScrollOffset_InScrollOffset_PropertyAddress.Address, InScrollOffset);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetScrollOffset_FunctionAddress, intPtr, SetScrollOffset_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.ListViewBase:SetScrollbarVisibility")]
	public unsafe void SetScrollbarVisibility(ESlateVisibility InVisibility)
	{
		CheckDestroyed();
		if (!SetScrollbarVisibility_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ListViewBase:SetScrollbarVisibility");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetScrollbarVisibility_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetScrollbarVisibility_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ESlateVisibility>.ToNative(IntPtr.Add(intPtr, SetScrollbarVisibility_InVisibility_Offset), 0, SetScrollbarVisibility_InVisibility_PropertyAddress.Address, InVisibility);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetScrollbarVisibility_FunctionAddress, intPtr, SetScrollbarVisibility_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.ListViewBase:ScrollToTop")]
	public unsafe void ScrollToTop()
	{
		CheckDestroyed();
		if (!ScrollToTop_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ListViewBase:ScrollToTop");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ScrollToTop_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ScrollToTop_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ScrollToTop_FunctionAddress, argsSize: ScrollToTop_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.ListViewBase:ScrollToBottom")]
	public unsafe void ScrollToBottom()
	{
		CheckDestroyed();
		if (!ScrollToBottom_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ListViewBase:ScrollToBottom");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ScrollToBottom_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ScrollToBottom_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ScrollToBottom_FunctionAddress, argsSize: ScrollToBottom_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.ListViewBase:RequestRefresh")]
	public unsafe void RequestRefresh()
	{
		CheckDestroyed();
		if (!RequestRefresh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ListViewBase:RequestRefresh");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RequestRefresh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RequestRefresh_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: RequestRefresh_FunctionAddress, argsSize: RequestRefresh_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.ListViewBase:RegenerateAllEntries")]
	public unsafe void RegenerateAllEntries()
	{
		CheckDestroyed();
		if (!RegenerateAllEntries_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ListViewBase:RegenerateAllEntries");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RegenerateAllEntries_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RegenerateAllEntries_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: RegenerateAllEntries_FunctionAddress, argsSize: RegenerateAllEntries_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.ListViewBase:GetScrollOffset")]
	public unsafe float GetScrollOffset()
	{
		CheckDestroyed();
		if (!GetScrollOffset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ListViewBase:GetScrollOffset");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetScrollOffset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetScrollOffset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetScrollOffset_FunctionAddress, intPtr, GetScrollOffset_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetScrollOffset_ReturnValue_Offset), 0, GetScrollOffset_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.ListViewBase:GetDisplayedEntryWidgets")]
	public unsafe List<UUserWidget> GetDisplayedEntryWidgets()
	{
		CheckDestroyed();
		if (!GetDisplayedEntryWidgets_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ListViewBase:GetDisplayedEntryWidgets");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDisplayedEntryWidgets_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDisplayedEntryWidgets_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDisplayedEntryWidgets_FunctionAddress, intPtr, GetDisplayedEntryWidgets_ParamsSize);
		List<UUserWidget> result = new TArrayCopyMarshaler<UUserWidget>(1, GetDisplayedEntryWidgets_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UUserWidget, UObjectMarshaler<UUserWidget>>.FromNative, CachedMarshalingDelegates<UUserWidget, UObjectMarshaler<UUserWidget>>.ToNative).FromNative(IntPtr.Add(intPtr, GetDisplayedEntryWidgets_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetDisplayedEntryWidgets_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	static UListViewBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UListViewBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UListViewBase));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/UMG.ListViewBase");
		EntryWidgetClass_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "EntryWidgetClass");
		EntryWidgetClass_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "EntryWidgetClass", Classes.FClassProperty);
		WheelScrollMultiplier_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WheelScrollMultiplier");
		WheelScrollMultiplier_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WheelScrollMultiplier", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableScrollAnimation_PropertyAddress, intPtr, "bEnableScrollAnimation");
		EnableScrollAnimation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnableScrollAnimation");
		EnableScrollAnimation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnableScrollAnimation", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AllowDragging_PropertyAddress, intPtr, "bAllowDragging");
		AllowDragging_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAllowDragging");
		AllowDragging_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAllowDragging", Classes.FBoolProperty);
		SetWheelScrollMultiplier_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetWheelScrollMultiplier");
		SetWheelScrollMultiplier_ParamsSize = NativeReflection.GetFunctionParamsSize(SetWheelScrollMultiplier_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetWheelScrollMultiplier_NewWheelScrollMultiplier_PropertyAddress, SetWheelScrollMultiplier_FunctionAddress, "NewWheelScrollMultiplier");
		SetWheelScrollMultiplier_NewWheelScrollMultiplier_Offset = NativeReflectionCached.GetPropertyOffset(SetWheelScrollMultiplier_FunctionAddress, "NewWheelScrollMultiplier");
		SetWheelScrollMultiplier_NewWheelScrollMultiplier_IsValid = NativeReflectionCached.ValidatePropertyClass(SetWheelScrollMultiplier_FunctionAddress, "NewWheelScrollMultiplier", Classes.FFloatProperty);
		SetWheelScrollMultiplier_IsValid = SetWheelScrollMultiplier_FunctionAddress != IntPtr.Zero && SetWheelScrollMultiplier_NewWheelScrollMultiplier_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.ListViewBase:SetWheelScrollMultiplier", SetWheelScrollMultiplier_IsValid);
		SetScrollOffset_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetScrollOffset");
		SetScrollOffset_ParamsSize = NativeReflection.GetFunctionParamsSize(SetScrollOffset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetScrollOffset_InScrollOffset_PropertyAddress, SetScrollOffset_FunctionAddress, "InScrollOffset");
		SetScrollOffset_InScrollOffset_Offset = NativeReflectionCached.GetPropertyOffset(SetScrollOffset_FunctionAddress, "InScrollOffset");
		SetScrollOffset_InScrollOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(SetScrollOffset_FunctionAddress, "InScrollOffset", Classes.FFloatProperty);
		SetScrollOffset_IsValid = SetScrollOffset_FunctionAddress != IntPtr.Zero && SetScrollOffset_InScrollOffset_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.ListViewBase:SetScrollOffset", SetScrollOffset_IsValid);
		SetScrollbarVisibility_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetScrollbarVisibility");
		SetScrollbarVisibility_ParamsSize = NativeReflection.GetFunctionParamsSize(SetScrollbarVisibility_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetScrollbarVisibility_InVisibility_PropertyAddress, SetScrollbarVisibility_FunctionAddress, "InVisibility");
		SetScrollbarVisibility_InVisibility_Offset = NativeReflectionCached.GetPropertyOffset(SetScrollbarVisibility_FunctionAddress, "InVisibility");
		SetScrollbarVisibility_InVisibility_IsValid = NativeReflectionCached.ValidatePropertyClass(SetScrollbarVisibility_FunctionAddress, "InVisibility", Classes.FEnumProperty);
		SetScrollbarVisibility_IsValid = SetScrollbarVisibility_FunctionAddress != IntPtr.Zero && SetScrollbarVisibility_InVisibility_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.ListViewBase:SetScrollbarVisibility", SetScrollbarVisibility_IsValid);
		ScrollToTop_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ScrollToTop");
		ScrollToTop_ParamsSize = NativeReflection.GetFunctionParamsSize(ScrollToTop_FunctionAddress);
		ScrollToTop_IsValid = ScrollToTop_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UMG.ListViewBase:ScrollToTop", ScrollToTop_IsValid);
		ScrollToBottom_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ScrollToBottom");
		ScrollToBottom_ParamsSize = NativeReflection.GetFunctionParamsSize(ScrollToBottom_FunctionAddress);
		ScrollToBottom_IsValid = ScrollToBottom_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UMG.ListViewBase:ScrollToBottom", ScrollToBottom_IsValid);
		RequestRefresh_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RequestRefresh");
		RequestRefresh_ParamsSize = NativeReflection.GetFunctionParamsSize(RequestRefresh_FunctionAddress);
		RequestRefresh_IsValid = RequestRefresh_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UMG.ListViewBase:RequestRefresh", RequestRefresh_IsValid);
		RegenerateAllEntries_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RegenerateAllEntries");
		RegenerateAllEntries_ParamsSize = NativeReflection.GetFunctionParamsSize(RegenerateAllEntries_FunctionAddress);
		RegenerateAllEntries_IsValid = RegenerateAllEntries_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UMG.ListViewBase:RegenerateAllEntries", RegenerateAllEntries_IsValid);
		GetScrollOffset_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetScrollOffset");
		GetScrollOffset_ParamsSize = NativeReflection.GetFunctionParamsSize(GetScrollOffset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetScrollOffset_ReturnValue_PropertyAddress, GetScrollOffset_FunctionAddress, "ReturnValue");
		GetScrollOffset_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetScrollOffset_FunctionAddress, "ReturnValue");
		GetScrollOffset_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetScrollOffset_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetScrollOffset_IsValid = GetScrollOffset_FunctionAddress != IntPtr.Zero && GetScrollOffset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.ListViewBase:GetScrollOffset", GetScrollOffset_IsValid);
		GetDisplayedEntryWidgets_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetDisplayedEntryWidgets");
		GetDisplayedEntryWidgets_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDisplayedEntryWidgets_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDisplayedEntryWidgets_ReturnValue_PropertyAddress, GetDisplayedEntryWidgets_FunctionAddress, "ReturnValue");
		GetDisplayedEntryWidgets_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDisplayedEntryWidgets_FunctionAddress, "ReturnValue");
		GetDisplayedEntryWidgets_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDisplayedEntryWidgets_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetDisplayedEntryWidgets_IsValid = GetDisplayedEntryWidgets_FunctionAddress != IntPtr.Zero && GetDisplayedEntryWidgets_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.ListViewBase:GetDisplayedEntryWidgets", GetDisplayedEntryWidgets_IsValid);
	}
}
