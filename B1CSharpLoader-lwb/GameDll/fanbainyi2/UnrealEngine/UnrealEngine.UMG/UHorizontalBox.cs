using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.UMG;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/UMG.HorizontalBox", "UMG", UnrealModuleType.Engine)]
public class UHorizontalBox : UPanelWidget
{
	private static bool AddChildToHorizontalBox_IsValid;

	private static IntPtr AddChildToHorizontalBox_FunctionAddress;

	private static int AddChildToHorizontalBox_ParamsSize;

	private static bool AddChildToHorizontalBox_Content_IsValid;

	private static FFieldAddress AddChildToHorizontalBox_Content_PropertyAddress;

	private static int AddChildToHorizontalBox_Content_Offset;

	private static bool AddChildToHorizontalBox_ReturnValue_IsValid;

	private static FFieldAddress AddChildToHorizontalBox_ReturnValue_PropertyAddress;

	private static int AddChildToHorizontalBox_ReturnValue_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.HorizontalBox:AddChildToHorizontalBox")]
	public unsafe UHorizontalBoxSlot AddChildToHorizontalBox(UWidget Content)
	{
		CheckDestroyed();
		if (!AddChildToHorizontalBox_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.HorizontalBox:AddChildToHorizontalBox");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddChildToHorizontalBox_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddChildToHorizontalBox_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidget>.ToNative(IntPtr.Add(intPtr, AddChildToHorizontalBox_Content_Offset), 0, AddChildToHorizontalBox_Content_PropertyAddress.Address, Content);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddChildToHorizontalBox_FunctionAddress, intPtr, AddChildToHorizontalBox_ParamsSize);
		return UObjectMarshaler<UHorizontalBoxSlot>.FromNative(IntPtr.Add(intPtr, AddChildToHorizontalBox_ReturnValue_Offset), 0, AddChildToHorizontalBox_ReturnValue_PropertyAddress.Address);
	}

	static UHorizontalBox()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UHorizontalBox)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UHorizontalBox));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/UMG.HorizontalBox");
		AddChildToHorizontalBox_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AddChildToHorizontalBox");
		AddChildToHorizontalBox_ParamsSize = NativeReflection.GetFunctionParamsSize(AddChildToHorizontalBox_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddChildToHorizontalBox_Content_PropertyAddress, AddChildToHorizontalBox_FunctionAddress, "Content");
		AddChildToHorizontalBox_Content_Offset = NativeReflectionCached.GetPropertyOffset(AddChildToHorizontalBox_FunctionAddress, "Content");
		AddChildToHorizontalBox_Content_IsValid = NativeReflectionCached.ValidatePropertyClass(AddChildToHorizontalBox_FunctionAddress, "Content", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddChildToHorizontalBox_ReturnValue_PropertyAddress, AddChildToHorizontalBox_FunctionAddress, "ReturnValue");
		AddChildToHorizontalBox_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddChildToHorizontalBox_FunctionAddress, "ReturnValue");
		AddChildToHorizontalBox_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddChildToHorizontalBox_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AddChildToHorizontalBox_IsValid = AddChildToHorizontalBox_FunctionAddress != IntPtr.Zero && AddChildToHorizontalBox_Content_IsValid && AddChildToHorizontalBox_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.HorizontalBox:AddChildToHorizontalBox", AddChildToHorizontalBox_IsValid);
	}
}
