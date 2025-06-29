using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.UMG;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/UMG.CanvasPanel", "UMG", UnrealModuleType.Engine)]
public class UCanvasPanel : UPanelWidget
{
	private static bool AddChildToCanvas_IsValid;

	private static IntPtr AddChildToCanvas_FunctionAddress;

	private static int AddChildToCanvas_ParamsSize;

	private static bool AddChildToCanvas_Content_IsValid;

	private static FFieldAddress AddChildToCanvas_Content_PropertyAddress;

	private static int AddChildToCanvas_Content_Offset;

	private static bool AddChildToCanvas_ReturnValue_IsValid;

	private static FFieldAddress AddChildToCanvas_ReturnValue_PropertyAddress;

	private static int AddChildToCanvas_ReturnValue_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.CanvasPanel:AddChildToCanvas")]
	public unsafe UCanvasPanelSlot AddChildToCanvas(UWidget Content)
	{
		CheckDestroyed();
		if (!AddChildToCanvas_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.CanvasPanel:AddChildToCanvas");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddChildToCanvas_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddChildToCanvas_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidget>.ToNative(IntPtr.Add(intPtr, AddChildToCanvas_Content_Offset), 0, AddChildToCanvas_Content_PropertyAddress.Address, Content);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddChildToCanvas_FunctionAddress, intPtr, AddChildToCanvas_ParamsSize);
		return UObjectMarshaler<UCanvasPanelSlot>.FromNative(IntPtr.Add(intPtr, AddChildToCanvas_ReturnValue_Offset), 0, AddChildToCanvas_ReturnValue_PropertyAddress.Address);
	}

	static UCanvasPanel()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UCanvasPanel)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UCanvasPanel));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/UMG.CanvasPanel");
		AddChildToCanvas_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AddChildToCanvas");
		AddChildToCanvas_ParamsSize = NativeReflection.GetFunctionParamsSize(AddChildToCanvas_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddChildToCanvas_Content_PropertyAddress, AddChildToCanvas_FunctionAddress, "Content");
		AddChildToCanvas_Content_Offset = NativeReflectionCached.GetPropertyOffset(AddChildToCanvas_FunctionAddress, "Content");
		AddChildToCanvas_Content_IsValid = NativeReflectionCached.ValidatePropertyClass(AddChildToCanvas_FunctionAddress, "Content", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddChildToCanvas_ReturnValue_PropertyAddress, AddChildToCanvas_FunctionAddress, "ReturnValue");
		AddChildToCanvas_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddChildToCanvas_FunctionAddress, "ReturnValue");
		AddChildToCanvas_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddChildToCanvas_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AddChildToCanvas_IsValid = AddChildToCanvas_FunctionAddress != IntPtr.Zero && AddChildToCanvas_Content_IsValid && AddChildToCanvas_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.CanvasPanel:AddChildToCanvas", AddChildToCanvas_IsValid);
	}
}
