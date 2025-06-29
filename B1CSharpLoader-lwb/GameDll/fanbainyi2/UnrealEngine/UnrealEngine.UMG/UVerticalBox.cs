using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.UMG;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/UMG.VerticalBox", "UMG", UnrealModuleType.Engine)]
public class UVerticalBox : UPanelWidget
{
	private static bool AddChildToVerticalBox_IsValid;

	private static IntPtr AddChildToVerticalBox_FunctionAddress;

	private static int AddChildToVerticalBox_ParamsSize;

	private static bool AddChildToVerticalBox_Content_IsValid;

	private static FFieldAddress AddChildToVerticalBox_Content_PropertyAddress;

	private static int AddChildToVerticalBox_Content_Offset;

	private static bool AddChildToVerticalBox_ReturnValue_IsValid;

	private static FFieldAddress AddChildToVerticalBox_ReturnValue_PropertyAddress;

	private static int AddChildToVerticalBox_ReturnValue_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.VerticalBox:AddChildToVerticalBox")]
	public unsafe UVerticalBoxSlot AddChildToVerticalBox(UWidget Content)
	{
		CheckDestroyed();
		if (!AddChildToVerticalBox_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.VerticalBox:AddChildToVerticalBox");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddChildToVerticalBox_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddChildToVerticalBox_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidget>.ToNative(IntPtr.Add(intPtr, AddChildToVerticalBox_Content_Offset), 0, AddChildToVerticalBox_Content_PropertyAddress.Address, Content);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddChildToVerticalBox_FunctionAddress, intPtr, AddChildToVerticalBox_ParamsSize);
		return UObjectMarshaler<UVerticalBoxSlot>.FromNative(IntPtr.Add(intPtr, AddChildToVerticalBox_ReturnValue_Offset), 0, AddChildToVerticalBox_ReturnValue_PropertyAddress.Address);
	}

	static UVerticalBox()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UVerticalBox)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UVerticalBox));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/UMG.VerticalBox");
		AddChildToVerticalBox_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AddChildToVerticalBox");
		AddChildToVerticalBox_ParamsSize = NativeReflection.GetFunctionParamsSize(AddChildToVerticalBox_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddChildToVerticalBox_Content_PropertyAddress, AddChildToVerticalBox_FunctionAddress, "Content");
		AddChildToVerticalBox_Content_Offset = NativeReflectionCached.GetPropertyOffset(AddChildToVerticalBox_FunctionAddress, "Content");
		AddChildToVerticalBox_Content_IsValid = NativeReflectionCached.ValidatePropertyClass(AddChildToVerticalBox_FunctionAddress, "Content", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddChildToVerticalBox_ReturnValue_PropertyAddress, AddChildToVerticalBox_FunctionAddress, "ReturnValue");
		AddChildToVerticalBox_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddChildToVerticalBox_FunctionAddress, "ReturnValue");
		AddChildToVerticalBox_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddChildToVerticalBox_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AddChildToVerticalBox_IsValid = AddChildToVerticalBox_FunctionAddress != IntPtr.Zero && AddChildToVerticalBox_Content_IsValid && AddChildToVerticalBox_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.VerticalBox:AddChildToVerticalBox", AddChildToVerticalBox_IsValid);
	}
}
