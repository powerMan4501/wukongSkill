using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.Plugins.JavascriptUMG;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/JavascriptUMG.JavascriptWindow", "JavascriptUMG", UnrealModuleType.GamePlugin)]
public class UJavascriptWindow : UContentWidget
{
	[UDelegate]
	[UMetaPath("/Script/JavascriptUMG.JavascriptWindow:OnWindowWidgetClosed__DelegateSignature")]
	public class FOnWindowWidgetClosed : FDelegate<FOnWindowWidgetClosed.Signature>
	{
		public delegate void Signature();

		private static bool OnWindowWidgetClosed__DelegateSignature_IsValid;

		private static IntPtr OnWindowWidgetClosed__DelegateSignature_FunctionAddress;

		private static int OnWindowWidgetClosed__DelegateSignature_ParamsSize;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FOnWindowWidgetClosed()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			OnWindowWidgetClosed__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/JavascriptUMG.JavascriptWindow:OnWindowWidgetClosed__DelegateSignature");
			OnWindowWidgetClosed__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnWindowWidgetClosed__DelegateSignature_FunctionAddress);
			OnWindowWidgetClosed__DelegateSignature_IsValid = OnWindowWidgetClosed__DelegateSignature_FunctionAddress != IntPtr.Zero;
			NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptWindow:OnWindowWidgetClosed__DelegateSignature", OnWindowWidgetClosed__DelegateSignature_IsValid);
		}

		private unsafe void Invoker()
		{
			if (!OnWindowWidgetClosed__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptWindow:OnWindowWidgetClosed__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(OnWindowWidgetClosed__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnWindowWidgetClosed__DelegateSignature_ParamsSize);
				IntPtr parameters = new IntPtr(ptr2);
				ProcessDelegate(parameters);
			}
		}
	}

	[UDelegate]
	[UMetaPath("/Script/JavascriptUMG.JavascriptWindow:OnWindowDeactivated__DelegateSignature")]
	public class FOnWindowDeactivated : FDelegate<FOnWindowDeactivated.Signature>
	{
		public delegate void Signature();

		private static bool OnWindowDeactivated__DelegateSignature_IsValid;

		private static IntPtr OnWindowDeactivated__DelegateSignature_FunctionAddress;

		private static int OnWindowDeactivated__DelegateSignature_ParamsSize;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FOnWindowDeactivated()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			OnWindowDeactivated__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/JavascriptUMG.JavascriptWindow:OnWindowDeactivated__DelegateSignature");
			OnWindowDeactivated__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnWindowDeactivated__DelegateSignature_FunctionAddress);
			OnWindowDeactivated__DelegateSignature_IsValid = OnWindowDeactivated__DelegateSignature_FunctionAddress != IntPtr.Zero;
			NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptWindow:OnWindowDeactivated__DelegateSignature", OnWindowDeactivated__DelegateSignature_IsValid);
		}

		private unsafe void Invoker()
		{
			if (!OnWindowDeactivated__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptWindow:OnWindowDeactivated__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(OnWindowDeactivated__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnWindowDeactivated__DelegateSignature_ParamsSize);
				IntPtr parameters = new IntPtr(ptr2);
				ProcessDelegate(parameters);
			}
		}
	}

	private static bool ShowWindow_IsValid;

	private static IntPtr ShowWindow_FunctionAddress;

	private static int ShowWindow_ParamsSize;

	private static bool SetOpacity_IsValid;

	private static IntPtr SetOpacity_FunctionAddress;

	private static int SetOpacity_ParamsSize;

	private static bool SetOpacity_InOpacity_IsValid;

	private static FFieldAddress SetOpacity_InOpacity_PropertyAddress;

	private static int SetOpacity_InOpacity_Offset;

	private static bool Resize_IsValid;

	private static IntPtr Resize_FunctionAddress;

	private static int Resize_ParamsSize;

	private static bool Resize_NewSize_IsValid;

	private static FFieldAddress Resize_NewSize_PropertyAddress;

	private static int Resize_NewSize_Offset;

	private static bool ReshapeWindow_IsValid;

	private static IntPtr ReshapeWindow_FunctionAddress;

	private static int ReshapeWindow_ParamsSize;

	private static bool ReshapeWindow_NewPosition_IsValid;

	private static FFieldAddress ReshapeWindow_NewPosition_PropertyAddress;

	private static int ReshapeWindow_NewPosition_Offset;

	private static bool ReshapeWindow_NewSize_IsValid;

	private static FFieldAddress ReshapeWindow_NewSize_PropertyAddress;

	private static int ReshapeWindow_NewSize_Offset;

	private static bool RequestDestroyWindow_IsValid;

	private static IntPtr RequestDestroyWindow_FunctionAddress;

	private static int RequestDestroyWindow_ParamsSize;

	private static bool MoveWindowTo_IsValid;

	private static IntPtr MoveWindowTo_FunctionAddress;

	private static int MoveWindowTo_ParamsSize;

	private static bool MoveWindowTo_NewPosition_IsValid;

	private static FFieldAddress MoveWindowTo_NewPosition_PropertyAddress;

	private static int MoveWindowTo_NewPosition_Offset;

	private static bool HideWindow_IsValid;

	private static IntPtr HideWindow_FunctionAddress;

	private static int HideWindow_ParamsSize;

	private static bool FlashWindow_IsValid;

	private static IntPtr FlashWindow_FunctionAddress;

	private static int FlashWindow_ParamsSize;

	private static bool EnableWindow_IsValid;

	private static IntPtr EnableWindow_FunctionAddress;

	private static int EnableWindow_ParamsSize;

	private static bool EnableWindow_bEnable_IsValid;

	private static FFieldAddress EnableWindow_bEnable_PropertyAddress;

	private static int EnableWindow_bEnable_Offset;

	private static bool DestroyWindowImmediately_IsValid;

	private static IntPtr DestroyWindowImmediately_FunctionAddress;

	private static int DestroyWindowImmediately_ParamsSize;

	private static bool BringToFront_IsValid;

	private static IntPtr BringToFront_FunctionAddress;

	private static int BringToFront_ParamsSize;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptWindow:ShowWindow")]
	public unsafe void ShowWindow()
	{
		CheckDestroyed();
		if (!ShowWindow_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptWindow:ShowWindow");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ShowWindow_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ShowWindow_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ShowWindow_FunctionAddress, argsSize: ShowWindow_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptWindow:SetOpacity")]
	public unsafe void SetOpacity(float InOpacity)
	{
		CheckDestroyed();
		if (!SetOpacity_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptWindow:SetOpacity");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetOpacity_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetOpacity_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetOpacity_InOpacity_Offset), 0, SetOpacity_InOpacity_PropertyAddress.Address, InOpacity);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetOpacity_FunctionAddress, intPtr, SetOpacity_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptWindow:Resize")]
	public unsafe void Resize(FVector2D NewSize)
	{
		CheckDestroyed();
		if (!Resize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptWindow:Resize");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Resize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Resize_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, Resize_NewSize_Offset), 0, Resize_NewSize_PropertyAddress.Address, NewSize);
		NativeReflection.InvokeFunctionOptimized(base.Address, Resize_FunctionAddress, intPtr, Resize_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptWindow:ReshapeWindow")]
	public unsafe void ReshapeWindow(FVector2D NewPosition, FVector2D NewSize)
	{
		CheckDestroyed();
		if (!ReshapeWindow_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptWindow:ReshapeWindow");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReshapeWindow_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReshapeWindow_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, ReshapeWindow_NewPosition_Offset), 0, ReshapeWindow_NewPosition_PropertyAddress.Address, NewPosition);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, ReshapeWindow_NewSize_Offset), 0, ReshapeWindow_NewSize_PropertyAddress.Address, NewSize);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReshapeWindow_FunctionAddress, intPtr, ReshapeWindow_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptWindow:RequestDestroyWindow")]
	public unsafe void RequestDestroyWindow()
	{
		CheckDestroyed();
		if (!RequestDestroyWindow_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptWindow:RequestDestroyWindow");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RequestDestroyWindow_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RequestDestroyWindow_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: RequestDestroyWindow_FunctionAddress, argsSize: RequestDestroyWindow_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptWindow:MoveWindowTo")]
	public unsafe void MoveWindowTo(FVector2D NewPosition)
	{
		CheckDestroyed();
		if (!MoveWindowTo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptWindow:MoveWindowTo");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MoveWindowTo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MoveWindowTo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, MoveWindowTo_NewPosition_Offset), 0, MoveWindowTo_NewPosition_PropertyAddress.Address, NewPosition);
		NativeReflection.InvokeFunctionOptimized(base.Address, MoveWindowTo_FunctionAddress, intPtr, MoveWindowTo_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptWindow:HideWindow")]
	public unsafe void HideWindow()
	{
		CheckDestroyed();
		if (!HideWindow_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptWindow:HideWindow");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HideWindow_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HideWindow_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: HideWindow_FunctionAddress, argsSize: HideWindow_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptWindow:FlashWindow")]
	public unsafe void FlashWindow()
	{
		CheckDestroyed();
		if (!FlashWindow_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptWindow:FlashWindow");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FlashWindow_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FlashWindow_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: FlashWindow_FunctionAddress, argsSize: FlashWindow_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptWindow:EnableWindow")]
	public unsafe void EnableWindow(bool bEnable)
	{
		CheckDestroyed();
		if (!EnableWindow_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptWindow:EnableWindow");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EnableWindow_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EnableWindow_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, EnableWindow_bEnable_Offset), 0, EnableWindow_bEnable_PropertyAddress.Address, bEnable);
		NativeReflection.InvokeFunctionOptimized(base.Address, EnableWindow_FunctionAddress, intPtr, EnableWindow_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptWindow:DestroyWindowImmediately")]
	public unsafe void DestroyWindowImmediately()
	{
		CheckDestroyed();
		if (!DestroyWindowImmediately_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptWindow:DestroyWindowImmediately");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DestroyWindowImmediately_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DestroyWindowImmediately_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: DestroyWindowImmediately_FunctionAddress, argsSize: DestroyWindowImmediately_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptWindow:BringToFront")]
	public unsafe void BringToFront()
	{
		CheckDestroyed();
		if (!BringToFront_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptWindow:BringToFront");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BringToFront_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BringToFront_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: BringToFront_FunctionAddress, argsSize: BringToFront_ParamsSize);
	}

	static UJavascriptWindow()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UJavascriptWindow)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UJavascriptWindow));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/JavascriptUMG.JavascriptWindow");
		ShowWindow_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ShowWindow");
		ShowWindow_ParamsSize = NativeReflection.GetFunctionParamsSize(ShowWindow_FunctionAddress);
		ShowWindow_IsValid = ShowWindow_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptWindow:ShowWindow", ShowWindow_IsValid);
		SetOpacity_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetOpacity");
		SetOpacity_ParamsSize = NativeReflection.GetFunctionParamsSize(SetOpacity_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetOpacity_InOpacity_PropertyAddress, SetOpacity_FunctionAddress, "InOpacity");
		SetOpacity_InOpacity_Offset = NativeReflectionCached.GetPropertyOffset(SetOpacity_FunctionAddress, "InOpacity");
		SetOpacity_InOpacity_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOpacity_FunctionAddress, "InOpacity", Classes.FFloatProperty);
		SetOpacity_IsValid = SetOpacity_FunctionAddress != IntPtr.Zero && SetOpacity_InOpacity_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptWindow:SetOpacity", SetOpacity_IsValid);
		Resize_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Resize");
		Resize_ParamsSize = NativeReflection.GetFunctionParamsSize(Resize_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Resize_NewSize_PropertyAddress, Resize_FunctionAddress, "NewSize");
		Resize_NewSize_Offset = NativeReflectionCached.GetPropertyOffset(Resize_FunctionAddress, "NewSize");
		Resize_NewSize_IsValid = NativeReflectionCached.ValidatePropertyClass(Resize_FunctionAddress, "NewSize", Classes.FStructProperty);
		Resize_IsValid = Resize_FunctionAddress != IntPtr.Zero && Resize_NewSize_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptWindow:Resize", Resize_IsValid);
		ReshapeWindow_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ReshapeWindow");
		ReshapeWindow_ParamsSize = NativeReflection.GetFunctionParamsSize(ReshapeWindow_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReshapeWindow_NewPosition_PropertyAddress, ReshapeWindow_FunctionAddress, "NewPosition");
		ReshapeWindow_NewPosition_Offset = NativeReflectionCached.GetPropertyOffset(ReshapeWindow_FunctionAddress, "NewPosition");
		ReshapeWindow_NewPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(ReshapeWindow_FunctionAddress, "NewPosition", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ReshapeWindow_NewSize_PropertyAddress, ReshapeWindow_FunctionAddress, "NewSize");
		ReshapeWindow_NewSize_Offset = NativeReflectionCached.GetPropertyOffset(ReshapeWindow_FunctionAddress, "NewSize");
		ReshapeWindow_NewSize_IsValid = NativeReflectionCached.ValidatePropertyClass(ReshapeWindow_FunctionAddress, "NewSize", Classes.FStructProperty);
		ReshapeWindow_IsValid = ReshapeWindow_FunctionAddress != IntPtr.Zero && ReshapeWindow_NewPosition_IsValid && ReshapeWindow_NewSize_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptWindow:ReshapeWindow", ReshapeWindow_IsValid);
		RequestDestroyWindow_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RequestDestroyWindow");
		RequestDestroyWindow_ParamsSize = NativeReflection.GetFunctionParamsSize(RequestDestroyWindow_FunctionAddress);
		RequestDestroyWindow_IsValid = RequestDestroyWindow_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptWindow:RequestDestroyWindow", RequestDestroyWindow_IsValid);
		MoveWindowTo_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "MoveWindowTo");
		MoveWindowTo_ParamsSize = NativeReflection.GetFunctionParamsSize(MoveWindowTo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MoveWindowTo_NewPosition_PropertyAddress, MoveWindowTo_FunctionAddress, "NewPosition");
		MoveWindowTo_NewPosition_Offset = NativeReflectionCached.GetPropertyOffset(MoveWindowTo_FunctionAddress, "NewPosition");
		MoveWindowTo_NewPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(MoveWindowTo_FunctionAddress, "NewPosition", Classes.FStructProperty);
		MoveWindowTo_IsValid = MoveWindowTo_FunctionAddress != IntPtr.Zero && MoveWindowTo_NewPosition_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptWindow:MoveWindowTo", MoveWindowTo_IsValid);
		HideWindow_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "HideWindow");
		HideWindow_ParamsSize = NativeReflection.GetFunctionParamsSize(HideWindow_FunctionAddress);
		HideWindow_IsValid = HideWindow_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptWindow:HideWindow", HideWindow_IsValid);
		FlashWindow_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "FlashWindow");
		FlashWindow_ParamsSize = NativeReflection.GetFunctionParamsSize(FlashWindow_FunctionAddress);
		FlashWindow_IsValid = FlashWindow_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptWindow:FlashWindow", FlashWindow_IsValid);
		EnableWindow_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "EnableWindow");
		EnableWindow_ParamsSize = NativeReflection.GetFunctionParamsSize(EnableWindow_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref EnableWindow_bEnable_PropertyAddress, EnableWindow_FunctionAddress, "bEnable");
		EnableWindow_bEnable_Offset = NativeReflectionCached.GetPropertyOffset(EnableWindow_FunctionAddress, "bEnable");
		EnableWindow_bEnable_IsValid = NativeReflectionCached.ValidatePropertyClass(EnableWindow_FunctionAddress, "bEnable", Classes.FBoolProperty);
		EnableWindow_IsValid = EnableWindow_FunctionAddress != IntPtr.Zero && EnableWindow_bEnable_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptWindow:EnableWindow", EnableWindow_IsValid);
		DestroyWindowImmediately_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "DestroyWindowImmediately");
		DestroyWindowImmediately_ParamsSize = NativeReflection.GetFunctionParamsSize(DestroyWindowImmediately_FunctionAddress);
		DestroyWindowImmediately_IsValid = DestroyWindowImmediately_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptWindow:DestroyWindowImmediately", DestroyWindowImmediately_IsValid);
		BringToFront_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BringToFront");
		BringToFront_ParamsSize = NativeReflection.GetFunctionParamsSize(BringToFront_FunctionAddress);
		BringToFront_IsValid = BringToFront_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptWindow:BringToFront", BringToFront_IsValid);
	}
}
