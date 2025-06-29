using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;

namespace UnrealEngine.UMG;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/UMG.MenuAnchor", "UMG", UnrealModuleType.Engine)]
public class UMenuAnchor : UContentWidget
{
	[UDelegate]
	[UMetaPath("/Script/UMG.MenuAnchor:GetUserWidget__DelegateSignature")]
	public class FGetUserWidget : FDelegate<FGetUserWidget.Signature>
	{
		public delegate UUserWidget Signature();

		private static bool GetUserWidget__DelegateSignature_IsValid;

		private static IntPtr GetUserWidget__DelegateSignature_FunctionAddress;

		private static int GetUserWidget__DelegateSignature_ParamsSize;

		private static bool GetUserWidget__DelegateSignature_ReturnValue_IsValid;

		private static FFieldAddress GetUserWidget__DelegateSignature_ReturnValue_PropertyAddress;

		private static int GetUserWidget__DelegateSignature_ReturnValue_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FGetUserWidget()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			GetUserWidget__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/UMG.MenuAnchor:GetUserWidget__DelegateSignature");
			GetUserWidget__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(GetUserWidget__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref GetUserWidget__DelegateSignature_ReturnValue_PropertyAddress, GetUserWidget__DelegateSignature_FunctionAddress, "ReturnValue");
			GetUserWidget__DelegateSignature_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetUserWidget__DelegateSignature_FunctionAddress, "ReturnValue");
			GetUserWidget__DelegateSignature_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetUserWidget__DelegateSignature_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
			GetUserWidget__DelegateSignature_IsValid = GetUserWidget__DelegateSignature_FunctionAddress != IntPtr.Zero && GetUserWidget__DelegateSignature_ReturnValue_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/UMG.MenuAnchor:GetUserWidget__DelegateSignature", GetUserWidget__DelegateSignature_IsValid);
		}

		private unsafe UUserWidget Invoker()
		{
			if (!GetUserWidget__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.MenuAnchor:GetUserWidget__DelegateSignature");
				return null;
			}
			if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(GetUserWidget__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetUserWidget__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				ProcessDelegate(intPtr);
				return UObjectMarshaler<UUserWidget>.FromNative(IntPtr.Add(intPtr, GetUserWidget__DelegateSignature_ReturnValue_Offset), 0, GetUserWidget__DelegateSignature_ReturnValue_PropertyAddress.Address);
			}
			return null;
		}
	}

	private static bool MenuClass_IsValid;

	private static int MenuClass_Offset;

	private static bool Placement_IsValid;

	private static FFieldAddress Placement_PropertyAddress;

	private static int Placement_Offset;

	private static bool ShouldFitInWindow_IsValid;

	private static FFieldAddress ShouldFitInWindow_PropertyAddress;

	private static int ShouldFitInWindow_Offset;

	private static bool ShouldDeferPaintingAfterWindowContent_IsValid;

	private static FFieldAddress ShouldDeferPaintingAfterWindowContent_PropertyAddress;

	private static int ShouldDeferPaintingAfterWindowContent_Offset;

	private static bool UseApplicationMenuStack_IsValid;

	private static FFieldAddress UseApplicationMenuStack_PropertyAddress;

	private static int UseApplicationMenuStack_Offset;

	private static bool OnMenuOpenChanged_IsValid;

	private static int OnMenuOpenChanged_Offset;

	private FOnMenuOpenChangedEvent OnMenuOpenChanged_DelegateCached;

	private static bool ToggleOpen_IsValid;

	private static IntPtr ToggleOpen_FunctionAddress;

	private static int ToggleOpen_ParamsSize;

	private static bool ToggleOpen_bFocusOnOpen_IsValid;

	private static FFieldAddress ToggleOpen_bFocusOnOpen_PropertyAddress;

	private static int ToggleOpen_bFocusOnOpen_Offset;

	private static bool ShouldOpenDueToClick_IsValid;

	private static IntPtr ShouldOpenDueToClick_FunctionAddress;

	private static int ShouldOpenDueToClick_ParamsSize;

	private static bool ShouldOpenDueToClick_ReturnValue_IsValid;

	private static FFieldAddress ShouldOpenDueToClick_ReturnValue_PropertyAddress;

	private static int ShouldOpenDueToClick_ReturnValue_Offset;

	private static bool SetPlacement_IsValid;

	private static IntPtr SetPlacement_FunctionAddress;

	private static int SetPlacement_ParamsSize;

	private static bool SetPlacement_InPlacement_IsValid;

	private static FFieldAddress SetPlacement_InPlacement_PropertyAddress;

	private static int SetPlacement_InPlacement_Offset;

	private static bool Open_IsValid;

	private static IntPtr Open_FunctionAddress;

	private static int Open_ParamsSize;

	private static bool Open_bFocusMenu_IsValid;

	private static FFieldAddress Open_bFocusMenu_PropertyAddress;

	private static int Open_bFocusMenu_Offset;

	private static bool IsOpen_IsValid;

	private static IntPtr IsOpen_FunctionAddress;

	private static int IsOpen_ParamsSize;

	private static bool IsOpen_ReturnValue_IsValid;

	private static FFieldAddress IsOpen_ReturnValue_PropertyAddress;

	private static int IsOpen_ReturnValue_Offset;

	private static bool HasOpenSubMenus_IsValid;

	private static IntPtr HasOpenSubMenus_FunctionAddress;

	private static int HasOpenSubMenus_ParamsSize;

	private static bool HasOpenSubMenus_ReturnValue_IsValid;

	private static FFieldAddress HasOpenSubMenus_ReturnValue_PropertyAddress;

	private static int HasOpenSubMenus_ReturnValue_Offset;

	private static bool GetMenuPosition_IsValid;

	private static IntPtr GetMenuPosition_FunctionAddress;

	private static int GetMenuPosition_ParamsSize;

	private static bool GetMenuPosition_ReturnValue_IsValid;

	private static FFieldAddress GetMenuPosition_ReturnValue_PropertyAddress;

	private static int GetMenuPosition_ReturnValue_Offset;

	private static bool FitInWindow_IsValid;

	private static IntPtr FitInWindow_FunctionAddress;

	private static int FitInWindow_ParamsSize;

	private static bool FitInWindow_bFit_IsValid;

	private static FFieldAddress FitInWindow_bFit_PropertyAddress;

	private static int FitInWindow_bFit_Offset;

	private static bool Close_IsValid;

	private static IntPtr Close_FunctionAddress;

	private static int Close_ParamsSize;

	[UProperty(Flags = (PropFlags)7881369141117461uL)]
	[UMetaPath("/Script/UMG.MenuAnchor:MenuClass")]
	public TSubclassOf<UUserWidget> MenuClass
	{
		get
		{
			CheckDestroyed();
			if (!MenuClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.MenuAnchor:MenuClass");
				return default(TSubclassOf<UUserWidget>);
			}
			return TSubclassOfMarshaler<UUserWidget>.FromNative(IntPtr.Add(base.Address, MenuClass_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MenuClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.MenuAnchor:MenuClass");
			}
			else
			{
				TSubclassOfMarshaler<UUserWidget>.ToNative(IntPtr.Add(base.Address, MenuClass_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.MenuAnchor:Placement")]
	public EMenuPlacement Placement
	{
		get
		{
			CheckDestroyed();
			if (!Placement_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.MenuAnchor:Placement");
				return EMenuPlacement.MenuPlacement_BelowAnchor;
			}
			return EnumMarshaler<EMenuPlacement>.FromNative(IntPtr.Add(base.Address, Placement_Offset), 0, Placement_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Placement_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.MenuAnchor:Placement");
			}
			else
			{
				EnumMarshaler<EMenuPlacement>.ToNative(IntPtr.Add(base.Address, Placement_Offset), 0, Placement_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.MenuAnchor:bFitInWindow")]
	public bool ShouldFitInWindow
	{
		get
		{
			CheckDestroyed();
			if (!ShouldFitInWindow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.MenuAnchor:bFitInWindow");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ShouldFitInWindow_Offset), 0, ShouldFitInWindow_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ShouldFitInWindow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.MenuAnchor:bFitInWindow");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ShouldFitInWindow_Offset), 0, ShouldFitInWindow_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/UMG.MenuAnchor:ShouldDeferPaintingAfterWindowContent")]
	public bool ShouldDeferPaintingAfterWindowContent
	{
		get
		{
			CheckDestroyed();
			if (!ShouldDeferPaintingAfterWindowContent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.MenuAnchor:ShouldDeferPaintingAfterWindowContent");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ShouldDeferPaintingAfterWindowContent_Offset), 0, ShouldDeferPaintingAfterWindowContent_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ShouldDeferPaintingAfterWindowContent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.MenuAnchor:ShouldDeferPaintingAfterWindowContent");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ShouldDeferPaintingAfterWindowContent_Offset), 0, ShouldDeferPaintingAfterWindowContent_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/UMG.MenuAnchor:UseApplicationMenuStack")]
	public bool UseApplicationMenuStack
	{
		get
		{
			CheckDestroyed();
			if (!UseApplicationMenuStack_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.MenuAnchor:UseApplicationMenuStack");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseApplicationMenuStack_Offset), 0, UseApplicationMenuStack_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseApplicationMenuStack_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.MenuAnchor:UseApplicationMenuStack");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseApplicationMenuStack_Offset), 0, UseApplicationMenuStack_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/UMG.MenuAnchor:OnMenuOpenChanged")]
	public FOnMenuOpenChangedEvent OnMenuOpenChanged
	{
		get
		{
			CheckDestroyed();
			if (!OnMenuOpenChanged_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.MenuAnchor:OnMenuOpenChanged");
				return new FOnMenuOpenChangedEvent();
			}
			if (OnMenuOpenChanged_DelegateCached == null)
			{
				OnMenuOpenChanged_DelegateCached = new FOnMenuOpenChangedEvent();
				OnMenuOpenChanged_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnMenuOpenChanged_Offset));
			}
			return OnMenuOpenChanged_DelegateCached;
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.MenuAnchor:ToggleOpen")]
	public unsafe void ToggleOpen(bool bFocusOnOpen)
	{
		CheckDestroyed();
		if (!ToggleOpen_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.MenuAnchor:ToggleOpen");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ToggleOpen_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ToggleOpen_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ToggleOpen_bFocusOnOpen_Offset), 0, ToggleOpen_bFocusOnOpen_PropertyAddress.Address, bFocusOnOpen);
		NativeReflection.InvokeFunctionOptimized(base.Address, ToggleOpen_FunctionAddress, intPtr, ToggleOpen_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.MenuAnchor:ShouldOpenDueToClick")]
	public unsafe bool ShouldOpenDueToClick()
	{
		CheckDestroyed();
		if (!ShouldOpenDueToClick_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.MenuAnchor:ShouldOpenDueToClick");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ShouldOpenDueToClick_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ShouldOpenDueToClick_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, ShouldOpenDueToClick_FunctionAddress, intPtr, ShouldOpenDueToClick_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ShouldOpenDueToClick_ReturnValue_Offset), 0, ShouldOpenDueToClick_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.MenuAnchor:SetPlacement")]
	public unsafe void SetPlacement(EMenuPlacement InPlacement)
	{
		CheckDestroyed();
		if (!SetPlacement_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.MenuAnchor:SetPlacement");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPlacement_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPlacement_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EMenuPlacement>.ToNative(IntPtr.Add(intPtr, SetPlacement_InPlacement_Offset), 0, SetPlacement_InPlacement_PropertyAddress.Address, InPlacement);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPlacement_FunctionAddress, intPtr, SetPlacement_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.MenuAnchor:Open")]
	public unsafe void Open(bool bFocusMenu)
	{
		CheckDestroyed();
		if (!Open_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.MenuAnchor:Open");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Open_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Open_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, Open_bFocusMenu_Offset), 0, Open_bFocusMenu_PropertyAddress.Address, bFocusMenu);
		NativeReflection.InvokeFunctionOptimized(base.Address, Open_FunctionAddress, intPtr, Open_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.MenuAnchor:IsOpen")]
	public unsafe bool IsOpen()
	{
		CheckDestroyed();
		if (!IsOpen_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.MenuAnchor:IsOpen");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsOpen_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsOpen_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsOpen_FunctionAddress, intPtr, IsOpen_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsOpen_ReturnValue_Offset), 0, IsOpen_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.MenuAnchor:HasOpenSubMenus")]
	public unsafe bool HasOpenSubMenus()
	{
		CheckDestroyed();
		if (!HasOpenSubMenus_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.MenuAnchor:HasOpenSubMenus");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HasOpenSubMenus_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HasOpenSubMenus_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, HasOpenSubMenus_FunctionAddress, intPtr, HasOpenSubMenus_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, HasOpenSubMenus_ReturnValue_Offset), 0, HasOpenSubMenus_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/UMG.MenuAnchor:GetMenuPosition")]
	public unsafe FVector2D GetMenuPosition()
	{
		CheckDestroyed();
		if (!GetMenuPosition_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.MenuAnchor:GetMenuPosition");
			return default(FVector2D);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMenuPosition_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMenuPosition_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetMenuPosition_FunctionAddress, intPtr, GetMenuPosition_ParamsSize);
		return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, GetMenuPosition_ReturnValue_Offset), 0, GetMenuPosition_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.MenuAnchor:FitInWindow")]
	public unsafe void FitInWindow(bool bFit)
	{
		CheckDestroyed();
		if (!FitInWindow_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.MenuAnchor:FitInWindow");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FitInWindow_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FitInWindow_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, FitInWindow_bFit_Offset), 0, FitInWindow_bFit_PropertyAddress.Address, bFit);
		NativeReflection.InvokeFunctionOptimized(base.Address, FitInWindow_FunctionAddress, intPtr, FitInWindow_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.MenuAnchor:Close")]
	public unsafe void Close()
	{
		CheckDestroyed();
		if (!Close_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.MenuAnchor:Close");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Close_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Close_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Close_FunctionAddress, argsSize: Close_ParamsSize);
	}

	static UMenuAnchor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMenuAnchor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMenuAnchor));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/UMG.MenuAnchor");
		MenuClass_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MenuClass");
		MenuClass_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MenuClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref Placement_PropertyAddress, intPtr, "Placement");
		Placement_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Placement");
		Placement_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Placement", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref ShouldFitInWindow_PropertyAddress, intPtr, "bFitInWindow");
		ShouldFitInWindow_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bFitInWindow");
		ShouldFitInWindow_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bFitInWindow", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ShouldDeferPaintingAfterWindowContent_PropertyAddress, intPtr, "ShouldDeferPaintingAfterWindowContent");
		ShouldDeferPaintingAfterWindowContent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ShouldDeferPaintingAfterWindowContent");
		ShouldDeferPaintingAfterWindowContent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ShouldDeferPaintingAfterWindowContent", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref UseApplicationMenuStack_PropertyAddress, intPtr, "UseApplicationMenuStack");
		UseApplicationMenuStack_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UseApplicationMenuStack");
		UseApplicationMenuStack_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UseApplicationMenuStack", Classes.FBoolProperty);
		OnMenuOpenChanged_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnMenuOpenChanged");
		OnMenuOpenChanged_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnMenuOpenChanged", Classes.FMulticastDelegateProperty);
		ToggleOpen_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ToggleOpen");
		ToggleOpen_ParamsSize = NativeReflection.GetFunctionParamsSize(ToggleOpen_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ToggleOpen_bFocusOnOpen_PropertyAddress, ToggleOpen_FunctionAddress, "bFocusOnOpen");
		ToggleOpen_bFocusOnOpen_Offset = NativeReflectionCached.GetPropertyOffset(ToggleOpen_FunctionAddress, "bFocusOnOpen");
		ToggleOpen_bFocusOnOpen_IsValid = NativeReflectionCached.ValidatePropertyClass(ToggleOpen_FunctionAddress, "bFocusOnOpen", Classes.FBoolProperty);
		ToggleOpen_IsValid = ToggleOpen_FunctionAddress != IntPtr.Zero && ToggleOpen_bFocusOnOpen_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.MenuAnchor:ToggleOpen", ToggleOpen_IsValid);
		ShouldOpenDueToClick_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ShouldOpenDueToClick");
		ShouldOpenDueToClick_ParamsSize = NativeReflection.GetFunctionParamsSize(ShouldOpenDueToClick_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ShouldOpenDueToClick_ReturnValue_PropertyAddress, ShouldOpenDueToClick_FunctionAddress, "ReturnValue");
		ShouldOpenDueToClick_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ShouldOpenDueToClick_FunctionAddress, "ReturnValue");
		ShouldOpenDueToClick_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ShouldOpenDueToClick_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ShouldOpenDueToClick_IsValid = ShouldOpenDueToClick_FunctionAddress != IntPtr.Zero && ShouldOpenDueToClick_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.MenuAnchor:ShouldOpenDueToClick", ShouldOpenDueToClick_IsValid);
		SetPlacement_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetPlacement");
		SetPlacement_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPlacement_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPlacement_InPlacement_PropertyAddress, SetPlacement_FunctionAddress, "InPlacement");
		SetPlacement_InPlacement_Offset = NativeReflectionCached.GetPropertyOffset(SetPlacement_FunctionAddress, "InPlacement");
		SetPlacement_InPlacement_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPlacement_FunctionAddress, "InPlacement", Classes.FByteProperty);
		SetPlacement_IsValid = SetPlacement_FunctionAddress != IntPtr.Zero && SetPlacement_InPlacement_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.MenuAnchor:SetPlacement", SetPlacement_IsValid);
		Open_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Open");
		Open_ParamsSize = NativeReflection.GetFunctionParamsSize(Open_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Open_bFocusMenu_PropertyAddress, Open_FunctionAddress, "bFocusMenu");
		Open_bFocusMenu_Offset = NativeReflectionCached.GetPropertyOffset(Open_FunctionAddress, "bFocusMenu");
		Open_bFocusMenu_IsValid = NativeReflectionCached.ValidatePropertyClass(Open_FunctionAddress, "bFocusMenu", Classes.FBoolProperty);
		Open_IsValid = Open_FunctionAddress != IntPtr.Zero && Open_bFocusMenu_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.MenuAnchor:Open", Open_IsValid);
		IsOpen_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsOpen");
		IsOpen_ParamsSize = NativeReflection.GetFunctionParamsSize(IsOpen_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsOpen_ReturnValue_PropertyAddress, IsOpen_FunctionAddress, "ReturnValue");
		IsOpen_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsOpen_FunctionAddress, "ReturnValue");
		IsOpen_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsOpen_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsOpen_IsValid = IsOpen_FunctionAddress != IntPtr.Zero && IsOpen_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.MenuAnchor:IsOpen", IsOpen_IsValid);
		HasOpenSubMenus_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "HasOpenSubMenus");
		HasOpenSubMenus_ParamsSize = NativeReflection.GetFunctionParamsSize(HasOpenSubMenus_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref HasOpenSubMenus_ReturnValue_PropertyAddress, HasOpenSubMenus_FunctionAddress, "ReturnValue");
		HasOpenSubMenus_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(HasOpenSubMenus_FunctionAddress, "ReturnValue");
		HasOpenSubMenus_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(HasOpenSubMenus_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		HasOpenSubMenus_IsValid = HasOpenSubMenus_FunctionAddress != IntPtr.Zero && HasOpenSubMenus_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.MenuAnchor:HasOpenSubMenus", HasOpenSubMenus_IsValid);
		GetMenuPosition_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetMenuPosition");
		GetMenuPosition_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMenuPosition_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMenuPosition_ReturnValue_PropertyAddress, GetMenuPosition_FunctionAddress, "ReturnValue");
		GetMenuPosition_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMenuPosition_FunctionAddress, "ReturnValue");
		GetMenuPosition_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMenuPosition_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetMenuPosition_IsValid = GetMenuPosition_FunctionAddress != IntPtr.Zero && GetMenuPosition_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.MenuAnchor:GetMenuPosition", GetMenuPosition_IsValid);
		FitInWindow_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "FitInWindow");
		FitInWindow_ParamsSize = NativeReflection.GetFunctionParamsSize(FitInWindow_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FitInWindow_bFit_PropertyAddress, FitInWindow_FunctionAddress, "bFit");
		FitInWindow_bFit_Offset = NativeReflectionCached.GetPropertyOffset(FitInWindow_FunctionAddress, "bFit");
		FitInWindow_bFit_IsValid = NativeReflectionCached.ValidatePropertyClass(FitInWindow_FunctionAddress, "bFit", Classes.FBoolProperty);
		FitInWindow_IsValid = FitInWindow_FunctionAddress != IntPtr.Zero && FitInWindow_bFit_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.MenuAnchor:FitInWindow", FitInWindow_IsValid);
		Close_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Close");
		Close_ParamsSize = NativeReflection.GetFunctionParamsSize(Close_FunctionAddress);
		Close_IsValid = Close_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UMG.MenuAnchor:Close", Close_IsValid);
	}
}
