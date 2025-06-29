using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.UMG;

[Abstract]
[UClass(Flags = (ClassFlags)821035169uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/UMG.ContentWidget", "UMG", UnrealModuleType.Engine)]
public class UContentWidget : UPanelWidget
{
	private static bool SetContent_IsValid;

	private static IntPtr SetContent_FunctionAddress;

	private static int SetContent_ParamsSize;

	private static bool SetContent_Content_IsValid;

	private static FFieldAddress SetContent_Content_PropertyAddress;

	private static int SetContent_Content_Offset;

	private static bool SetContent_ReturnValue_IsValid;

	private static FFieldAddress SetContent_ReturnValue_PropertyAddress;

	private static int SetContent_ReturnValue_Offset;

	private static bool GetContentSlot_IsValid;

	private static IntPtr GetContentSlot_FunctionAddress;

	private static int GetContentSlot_ParamsSize;

	private static bool GetContentSlot_ReturnValue_IsValid;

	private static FFieldAddress GetContentSlot_ReturnValue_PropertyAddress;

	private static int GetContentSlot_ReturnValue_Offset;

	private static bool GetContent_IsValid;

	private static IntPtr GetContent_FunctionAddress;

	private static int GetContent_ParamsSize;

	private static bool GetContent_ReturnValue_IsValid;

	private static FFieldAddress GetContent_ReturnValue_PropertyAddress;

	private static int GetContent_ReturnValue_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.ContentWidget:SetContent")]
	public unsafe UPanelSlot SetContent(UWidget Content)
	{
		CheckDestroyed();
		if (!SetContent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ContentWidget:SetContent");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetContent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetContent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidget>.ToNative(IntPtr.Add(intPtr, SetContent_Content_Offset), 0, SetContent_Content_PropertyAddress.Address, Content);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetContent_FunctionAddress, intPtr, SetContent_ParamsSize);
		return UObjectMarshaler<UPanelSlot>.FromNative(IntPtr.Add(intPtr, SetContent_ReturnValue_Offset), 0, SetContent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.ContentWidget:GetContentSlot")]
	public unsafe UPanelSlot GetContentSlot()
	{
		CheckDestroyed();
		if (!GetContentSlot_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ContentWidget:GetContentSlot");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetContentSlot_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetContentSlot_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetContentSlot_FunctionAddress, intPtr, GetContentSlot_ParamsSize);
		return UObjectMarshaler<UPanelSlot>.FromNative(IntPtr.Add(intPtr, GetContentSlot_ReturnValue_Offset), 0, GetContentSlot_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.ContentWidget:GetContent")]
	public unsafe UWidget GetContent()
	{
		CheckDestroyed();
		if (!GetContent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ContentWidget:GetContent");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetContent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetContent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetContent_FunctionAddress, intPtr, GetContent_ParamsSize);
		return UObjectMarshaler<UWidget>.FromNative(IntPtr.Add(intPtr, GetContent_ReturnValue_Offset), 0, GetContent_ReturnValue_PropertyAddress.Address);
	}

	static UContentWidget()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UContentWidget)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UContentWidget));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/UMG.ContentWidget");
		SetContent_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetContent");
		SetContent_ParamsSize = NativeReflection.GetFunctionParamsSize(SetContent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetContent_Content_PropertyAddress, SetContent_FunctionAddress, "Content");
		SetContent_Content_Offset = NativeReflectionCached.GetPropertyOffset(SetContent_FunctionAddress, "Content");
		SetContent_Content_IsValid = NativeReflectionCached.ValidatePropertyClass(SetContent_FunctionAddress, "Content", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetContent_ReturnValue_PropertyAddress, SetContent_FunctionAddress, "ReturnValue");
		SetContent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetContent_FunctionAddress, "ReturnValue");
		SetContent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetContent_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		SetContent_IsValid = SetContent_FunctionAddress != IntPtr.Zero && SetContent_Content_IsValid && SetContent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.ContentWidget:SetContent", SetContent_IsValid);
		GetContentSlot_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetContentSlot");
		GetContentSlot_ParamsSize = NativeReflection.GetFunctionParamsSize(GetContentSlot_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetContentSlot_ReturnValue_PropertyAddress, GetContentSlot_FunctionAddress, "ReturnValue");
		GetContentSlot_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetContentSlot_FunctionAddress, "ReturnValue");
		GetContentSlot_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetContentSlot_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetContentSlot_IsValid = GetContentSlot_FunctionAddress != IntPtr.Zero && GetContentSlot_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.ContentWidget:GetContentSlot", GetContentSlot_IsValid);
		GetContent_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetContent");
		GetContent_ParamsSize = NativeReflection.GetFunctionParamsSize(GetContent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetContent_ReturnValue_PropertyAddress, GetContent_FunctionAddress, "ReturnValue");
		GetContent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetContent_FunctionAddress, "ReturnValue");
		GetContent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetContent_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetContent_IsValid = GetContent_FunctionAddress != IntPtr.Zero && GetContent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.ContentWidget:GetContent", GetContent_IsValid);
	}
}
