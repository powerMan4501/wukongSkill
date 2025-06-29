using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.Plugins.GSInput;

[UClass(Flags = (ClassFlags)819986592uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/GSInput.GSOverlay", "GSInput", UnrealModuleType.GamePlugin)]
public class UGSOverlay : UOverlay
{
	private static bool OnChildAddToGSOverlayCS_IsValid;

	private IntPtr OnChildAddToGSOverlayCS_InstanceFunctionAddress;

	private static IntPtr OnChildAddToGSOverlayCS_FunctionAddress;

	private static int OnChildAddToGSOverlayCS_ParamsSize;

	private static bool OnChildAddToGSOverlayCS_Widget_IsValid;

	private static FFieldAddress OnChildAddToGSOverlayCS_Widget_PropertyAddress;

	private static int OnChildAddToGSOverlayCS_Widget_Offset;

	private static bool AddChildToGSOverlay_IsValid;

	private static IntPtr AddChildToGSOverlay_FunctionAddress;

	private static int AddChildToGSOverlay_ParamsSize;

	private static bool AddChildToGSOverlay_Content_IsValid;

	private static FFieldAddress AddChildToGSOverlay_Content_PropertyAddress;

	private static int AddChildToGSOverlay_Content_Offset;

	private static bool AddChildToGSOverlay_ReturnValue_IsValid;

	private static FFieldAddress AddChildToGSOverlay_ReturnValue_PropertyAddress;

	private static int AddChildToGSOverlay_ReturnValue_Offset;

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/GSInput.GSOverlay:OnChildAddToGSOverlayCS")]
	public unsafe void OnChildAddToGSOverlayCS(UWidget Widget)
	{
		CheckDestroyed();
		if (!OnChildAddToGSOverlayCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSOverlay:OnChildAddToGSOverlayCS");
			return;
		}
		if (OnChildAddToGSOverlayCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnChildAddToGSOverlayCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnChildAddToGSOverlayCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnChildAddToGSOverlayCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnChildAddToGSOverlayCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidget>.ToNative(IntPtr.Add(intPtr, OnChildAddToGSOverlayCS_Widget_Offset), 0, OnChildAddToGSOverlayCS_Widget_PropertyAddress.Address, Widget);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnChildAddToGSOverlayCS_InstanceFunctionAddress, intPtr, OnChildAddToGSOverlayCS_ParamsSize);
	}

	protected unsafe virtual void OnChildAddToGSOverlayCS_Implementation(UWidget Widget)
	{
		CheckDestroyed();
		if (!OnChildAddToGSOverlayCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSOverlay:OnChildAddToGSOverlayCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnChildAddToGSOverlayCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnChildAddToGSOverlayCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidget>.ToNative(IntPtr.Add(intPtr, OnChildAddToGSOverlayCS_Widget_Offset), 0, OnChildAddToGSOverlayCS_Widget_PropertyAddress.Address, Widget);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnChildAddToGSOverlayCS_FunctionAddress, intPtr, OnChildAddToGSOverlayCS_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GSInput.GSOverlay:AddChildToGSOverlay")]
	public unsafe UOverlaySlot AddChildToGSOverlay(UWidget Content)
	{
		CheckDestroyed();
		if (!AddChildToGSOverlay_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSOverlay:AddChildToGSOverlay");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddChildToGSOverlay_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddChildToGSOverlay_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidget>.ToNative(IntPtr.Add(intPtr, AddChildToGSOverlay_Content_Offset), 0, AddChildToGSOverlay_Content_PropertyAddress.Address, Content);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddChildToGSOverlay_FunctionAddress, intPtr, AddChildToGSOverlay_ParamsSize);
		return UObjectMarshaler<UOverlaySlot>.FromNative(IntPtr.Add(intPtr, AddChildToGSOverlay_ReturnValue_Offset), 0, AddChildToGSOverlay_ReturnValue_PropertyAddress.Address);
	}

	static UGSOverlay()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSOverlay)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSOverlay));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/GSInput.GSOverlay");
		OnChildAddToGSOverlayCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnChildAddToGSOverlayCS");
		OnChildAddToGSOverlayCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnChildAddToGSOverlayCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnChildAddToGSOverlayCS_Widget_PropertyAddress, OnChildAddToGSOverlayCS_FunctionAddress, "Widget");
		OnChildAddToGSOverlayCS_Widget_Offset = NativeReflectionCached.GetPropertyOffset(OnChildAddToGSOverlayCS_FunctionAddress, "Widget");
		OnChildAddToGSOverlayCS_Widget_IsValid = NativeReflectionCached.ValidatePropertyClass(OnChildAddToGSOverlayCS_FunctionAddress, "Widget", Classes.FObjectProperty);
		OnChildAddToGSOverlayCS_IsValid = OnChildAddToGSOverlayCS_FunctionAddress != IntPtr.Zero && OnChildAddToGSOverlayCS_Widget_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSOverlay:OnChildAddToGSOverlayCS", OnChildAddToGSOverlayCS_IsValid);
		AddChildToGSOverlay_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AddChildToGSOverlay");
		AddChildToGSOverlay_ParamsSize = NativeReflection.GetFunctionParamsSize(AddChildToGSOverlay_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddChildToGSOverlay_Content_PropertyAddress, AddChildToGSOverlay_FunctionAddress, "Content");
		AddChildToGSOverlay_Content_Offset = NativeReflectionCached.GetPropertyOffset(AddChildToGSOverlay_FunctionAddress, "Content");
		AddChildToGSOverlay_Content_IsValid = NativeReflectionCached.ValidatePropertyClass(AddChildToGSOverlay_FunctionAddress, "Content", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddChildToGSOverlay_ReturnValue_PropertyAddress, AddChildToGSOverlay_FunctionAddress, "ReturnValue");
		AddChildToGSOverlay_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddChildToGSOverlay_FunctionAddress, "ReturnValue");
		AddChildToGSOverlay_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddChildToGSOverlay_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AddChildToGSOverlay_IsValid = AddChildToGSOverlay_FunctionAddress != IntPtr.Zero && AddChildToGSOverlay_Content_IsValid && AddChildToGSOverlay_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSOverlay:AddChildToGSOverlay", AddChildToGSOverlay_IsValid);
	}
}
