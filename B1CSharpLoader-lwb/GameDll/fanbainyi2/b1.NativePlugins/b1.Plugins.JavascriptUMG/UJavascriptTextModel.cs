using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;

namespace b1.Plugins.JavascriptUMG;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/JavascriptUMG.JavascriptTextModel", "JavascriptUMG", UnrealModuleType.GamePlugin)]
public class UJavascriptTextModel : UObject
{
	private static bool SetString_IsValid;

	private static IntPtr SetString_FunctionAddress;

	private static int SetString_ParamsSize;

	private static bool SetString_String_IsValid;

	private static FFieldAddress SetString_String_PropertyAddress;

	private static int SetString_String_Offset;

	private static bool GetString_IsValid;

	private static IntPtr GetString_FunctionAddress;

	private static int GetString_ParamsSize;

	private static bool GetString_ReturnValue_IsValid;

	private static FFieldAddress GetString_ReturnValue_PropertyAddress;

	private static int GetString_ReturnValue_Offset;

	private static bool CreateRun_IsValid;

	private static IntPtr CreateRun_FunctionAddress;

	private static int CreateRun_ParamsSize;

	private static bool CreateRun_MessageTextStyle_IsValid;

	private static FFieldAddress CreateRun_MessageTextStyle_PropertyAddress;

	private static int CreateRun_MessageTextStyle_Offset;

	private static bool CreateRun_BeginIndex_IsValid;

	private static FFieldAddress CreateRun_BeginIndex_PropertyAddress;

	private static int CreateRun_BeginIndex_Offset;

	private static bool CreateRun_EndIndex_IsValid;

	private static FFieldAddress CreateRun_EndIndex_PropertyAddress;

	private static int CreateRun_EndIndex_Offset;

	private static bool CreateRun_ReturnValue_IsValid;

	private static FFieldAddress CreateRun_ReturnValue_PropertyAddress;

	private static int CreateRun_ReturnValue_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptTextModel:SetString")]
	public unsafe void SetString(string String)
	{
		CheckDestroyed();
		if (!SetString_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptTextModel:SetString");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetString_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetString_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetString_String_Offset), 0, SetString_String_PropertyAddress.Address, String);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetString_FunctionAddress, intPtr, SetString_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetString_String_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptTextModel:GetString")]
	public unsafe string GetString()
	{
		CheckDestroyed();
		if (!GetString_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptTextModel:GetString");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetString_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetString_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetString_FunctionAddress, intPtr, GetString_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetString_ReturnValue_Offset), 0, GetString_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetString_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptTextModel:CreateRun")]
	public unsafe FJavascriptSlateTextRun CreateRun(FTextBlockStyle MessageTextStyle, int BeginIndex, int EndIndex)
	{
		CheckDestroyed();
		if (!CreateRun_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptTextModel:CreateRun");
			return default(FJavascriptSlateTextRun);
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateRun_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateRun_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(CreateRun_MessageTextStyle_PropertyAddress.Address, intPtr);
		FTextBlockStyle.ToNative(IntPtr.Add(intPtr, CreateRun_MessageTextStyle_Offset), 0, CreateRun_MessageTextStyle_PropertyAddress.Address, MessageTextStyle);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, CreateRun_BeginIndex_Offset), 0, CreateRun_BeginIndex_PropertyAddress.Address, BeginIndex);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, CreateRun_EndIndex_Offset), 0, CreateRun_EndIndex_PropertyAddress.Address, EndIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, CreateRun_FunctionAddress, intPtr, CreateRun_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CreateRun_MessageTextStyle_PropertyAddress.Address, intPtr);
		FJavascriptSlateTextRun result = FJavascriptSlateTextRun.FromNative(IntPtr.Add(intPtr, CreateRun_ReturnValue_Offset), 0, CreateRun_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(CreateRun_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	static UJavascriptTextModel()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UJavascriptTextModel)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UJavascriptTextModel));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/JavascriptUMG.JavascriptTextModel");
		SetString_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetString");
		SetString_ParamsSize = NativeReflection.GetFunctionParamsSize(SetString_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetString_String_PropertyAddress, SetString_FunctionAddress, "String");
		SetString_String_Offset = NativeReflectionCached.GetPropertyOffset(SetString_FunctionAddress, "String");
		SetString_String_IsValid = NativeReflectionCached.ValidatePropertyClass(SetString_FunctionAddress, "String", Classes.FStrProperty);
		SetString_IsValid = SetString_FunctionAddress != IntPtr.Zero && SetString_String_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptTextModel:SetString", SetString_IsValid);
		GetString_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetString");
		GetString_ParamsSize = NativeReflection.GetFunctionParamsSize(GetString_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetString_ReturnValue_PropertyAddress, GetString_FunctionAddress, "ReturnValue");
		GetString_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetString_FunctionAddress, "ReturnValue");
		GetString_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetString_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetString_IsValid = GetString_FunctionAddress != IntPtr.Zero && GetString_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptTextModel:GetString", GetString_IsValid);
		CreateRun_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CreateRun");
		CreateRun_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateRun_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateRun_MessageTextStyle_PropertyAddress, CreateRun_FunctionAddress, "MessageTextStyle");
		CreateRun_MessageTextStyle_Offset = NativeReflectionCached.GetPropertyOffset(CreateRun_FunctionAddress, "MessageTextStyle");
		CreateRun_MessageTextStyle_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateRun_FunctionAddress, "MessageTextStyle", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateRun_BeginIndex_PropertyAddress, CreateRun_FunctionAddress, "BeginIndex");
		CreateRun_BeginIndex_Offset = NativeReflectionCached.GetPropertyOffset(CreateRun_FunctionAddress, "BeginIndex");
		CreateRun_BeginIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateRun_FunctionAddress, "BeginIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateRun_EndIndex_PropertyAddress, CreateRun_FunctionAddress, "EndIndex");
		CreateRun_EndIndex_Offset = NativeReflectionCached.GetPropertyOffset(CreateRun_FunctionAddress, "EndIndex");
		CreateRun_EndIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateRun_FunctionAddress, "EndIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateRun_ReturnValue_PropertyAddress, CreateRun_FunctionAddress, "ReturnValue");
		CreateRun_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CreateRun_FunctionAddress, "ReturnValue");
		CreateRun_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateRun_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		CreateRun_IsValid = CreateRun_FunctionAddress != IntPtr.Zero && CreateRun_MessageTextStyle_IsValid && CreateRun_BeginIndex_IsValid && CreateRun_EndIndex_IsValid && CreateRun_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptTextModel:CreateRun", CreateRun_IsValid);
	}
}
