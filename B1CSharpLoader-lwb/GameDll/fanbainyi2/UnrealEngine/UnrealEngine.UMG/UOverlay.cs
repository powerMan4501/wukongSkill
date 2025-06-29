using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.UMG;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/UMG.Overlay", "UMG", UnrealModuleType.Engine)]
public class UOverlay : UPanelWidget
{
	private static bool AddChildToOverlay_IsValid;

	private static IntPtr AddChildToOverlay_FunctionAddress;

	private static int AddChildToOverlay_ParamsSize;

	private static bool AddChildToOverlay_Content_IsValid;

	private static FFieldAddress AddChildToOverlay_Content_PropertyAddress;

	private static int AddChildToOverlay_Content_Offset;

	private static bool AddChildToOverlay_ReturnValue_IsValid;

	private static FFieldAddress AddChildToOverlay_ReturnValue_PropertyAddress;

	private static int AddChildToOverlay_ReturnValue_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.Overlay:AddChildToOverlay")]
	public unsafe UOverlaySlot AddChildToOverlay(UWidget Content)
	{
		CheckDestroyed();
		if (!AddChildToOverlay_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Overlay:AddChildToOverlay");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddChildToOverlay_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddChildToOverlay_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidget>.ToNative(IntPtr.Add(intPtr, AddChildToOverlay_Content_Offset), 0, AddChildToOverlay_Content_PropertyAddress.Address, Content);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddChildToOverlay_FunctionAddress, intPtr, AddChildToOverlay_ParamsSize);
		return UObjectMarshaler<UOverlaySlot>.FromNative(IntPtr.Add(intPtr, AddChildToOverlay_ReturnValue_Offset), 0, AddChildToOverlay_ReturnValue_PropertyAddress.Address);
	}

	static UOverlay()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UOverlay)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UOverlay));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/UMG.Overlay");
		AddChildToOverlay_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AddChildToOverlay");
		AddChildToOverlay_ParamsSize = NativeReflection.GetFunctionParamsSize(AddChildToOverlay_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddChildToOverlay_Content_PropertyAddress, AddChildToOverlay_FunctionAddress, "Content");
		AddChildToOverlay_Content_Offset = NativeReflectionCached.GetPropertyOffset(AddChildToOverlay_FunctionAddress, "Content");
		AddChildToOverlay_Content_IsValid = NativeReflectionCached.ValidatePropertyClass(AddChildToOverlay_FunctionAddress, "Content", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddChildToOverlay_ReturnValue_PropertyAddress, AddChildToOverlay_FunctionAddress, "ReturnValue");
		AddChildToOverlay_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddChildToOverlay_FunctionAddress, "ReturnValue");
		AddChildToOverlay_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddChildToOverlay_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AddChildToOverlay_IsValid = AddChildToOverlay_FunctionAddress != IntPtr.Zero && AddChildToOverlay_Content_IsValid && AddChildToOverlay_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Overlay:AddChildToOverlay", AddChildToOverlay_IsValid);
	}
}
