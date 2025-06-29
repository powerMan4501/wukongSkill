using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.StreamlineBlueprint;

[UClass(Flags = (ClassFlags)810025120uL, Config = "Engine")]
[UMetaPath("/Script/StreamlineBlueprint.StreamlineLibraryReflex", "StreamlineBlueprint", UnrealModuleType.EnginePlugin)]
public class UStreamlineLibraryReflex : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool SetReflexMode_IsValid;

	private static IntPtr SetReflexMode_FunctionAddress;

	private static int SetReflexMode_ParamsSize;

	private static bool SetReflexMode_Mode_IsValid;

	private static FFieldAddress SetReflexMode_Mode_PropertyAddress;

	private static int SetReflexMode_Mode_Offset;

	private static bool QueryReflexSupport_IsValid;

	private static IntPtr QueryReflexSupport_FunctionAddress;

	private static int QueryReflexSupport_ParamsSize;

	private static bool QueryReflexSupport_ReturnValue_IsValid;

	private static FFieldAddress QueryReflexSupport_ReturnValue_PropertyAddress;

	private static int QueryReflexSupport_ReturnValue_Offset;

	private static bool IsReflexSupported_IsValid;

	private static IntPtr IsReflexSupported_FunctionAddress;

	private static int IsReflexSupported_ParamsSize;

	private static bool IsReflexSupported_ReturnValue_IsValid;

	private static FFieldAddress IsReflexSupported_ReturnValue_PropertyAddress;

	private static int IsReflexSupported_ReturnValue_Offset;

	private static bool GetRenderLatencyInMs_IsValid;

	private static IntPtr GetRenderLatencyInMs_FunctionAddress;

	private static int GetRenderLatencyInMs_ParamsSize;

	private static bool GetRenderLatencyInMs_ReturnValue_IsValid;

	private static FFieldAddress GetRenderLatencyInMs_ReturnValue_PropertyAddress;

	private static int GetRenderLatencyInMs_ReturnValue_Offset;

	private static bool GetReflexMode_IsValid;

	private static IntPtr GetReflexMode_FunctionAddress;

	private static int GetReflexMode_ParamsSize;

	private static bool GetReflexMode_ReturnValue_IsValid;

	private static FFieldAddress GetReflexMode_ReturnValue_PropertyAddress;

	private static int GetReflexMode_ReturnValue_Offset;

	private static bool GetGameToRenderLatencyInMs_IsValid;

	private static IntPtr GetGameToRenderLatencyInMs_FunctionAddress;

	private static int GetGameToRenderLatencyInMs_ParamsSize;

	private static bool GetGameToRenderLatencyInMs_ReturnValue_IsValid;

	private static FFieldAddress GetGameToRenderLatencyInMs_ReturnValue_PropertyAddress;

	private static int GetGameToRenderLatencyInMs_ReturnValue_Offset;

	private static bool GetGameLatencyInMs_IsValid;

	private static IntPtr GetGameLatencyInMs_FunctionAddress;

	private static int GetGameLatencyInMs_ParamsSize;

	private static bool GetGameLatencyInMs_ReturnValue_IsValid;

	private static FFieldAddress GetGameLatencyInMs_ReturnValue_PropertyAddress;

	private static int GetGameLatencyInMs_ReturnValue_Offset;

	private static bool GetDefaultReflexMode_IsValid;

	private static IntPtr GetDefaultReflexMode_FunctionAddress;

	private static int GetDefaultReflexMode_ParamsSize;

	private static bool GetDefaultReflexMode_ReturnValue_IsValid;

	private static FFieldAddress GetDefaultReflexMode_ReturnValue_PropertyAddress;

	private static int GetDefaultReflexMode_ReturnValue_Offset;

	[UFunction(Flags = 67249155u)]
	[UMetaPath("/Script/StreamlineBlueprint.StreamlineLibraryReflex:SetReflexMode")]
	public unsafe static void SetReflexMode(EUStreamlineReflexMode Mode)
	{
		if (!SetReflexMode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/StreamlineBlueprint.StreamlineLibraryReflex:SetReflexMode");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetReflexMode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetReflexMode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EUStreamlineReflexMode>.ToNative(IntPtr.Add(intPtr, SetReflexMode_Mode_Offset), 0, SetReflexMode_Mode_PropertyAddress.Address, Mode);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetReflexMode_FunctionAddress, intPtr, SetReflexMode_ParamsSize);
	}

	[UFunction(Flags = 335684611u)]
	[UMetaPath("/Script/StreamlineBlueprint.StreamlineLibraryReflex:QueryReflexSupport")]
	public unsafe static EUStreamlineFeatureSupport QueryReflexSupport()
	{
		if (!QueryReflexSupport_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/StreamlineBlueprint.StreamlineLibraryReflex:QueryReflexSupport");
			return EUStreamlineFeatureSupport.Supported;
		}
		byte* ptr = stackalloc byte[(int)(uint)(QueryReflexSupport_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)QueryReflexSupport_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, QueryReflexSupport_FunctionAddress, intPtr, QueryReflexSupport_ParamsSize);
		return EnumMarshaler<EUStreamlineFeatureSupport>.FromNative(IntPtr.Add(intPtr, QueryReflexSupport_ReturnValue_Offset), 0, QueryReflexSupport_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684611u)]
	[UMetaPath("/Script/StreamlineBlueprint.StreamlineLibraryReflex:IsReflexSupported")]
	public unsafe static bool IsReflexSupported()
	{
		if (!IsReflexSupported_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/StreamlineBlueprint.StreamlineLibraryReflex:IsReflexSupported");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsReflexSupported_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsReflexSupported_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsReflexSupported_FunctionAddress, intPtr, IsReflexSupported_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsReflexSupported_ReturnValue_Offset), 0, IsReflexSupported_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684611u)]
	[UMetaPath("/Script/StreamlineBlueprint.StreamlineLibraryReflex:GetRenderLatencyInMs")]
	public unsafe static float GetRenderLatencyInMs()
	{
		if (!GetRenderLatencyInMs_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/StreamlineBlueprint.StreamlineLibraryReflex:GetRenderLatencyInMs");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRenderLatencyInMs_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRenderLatencyInMs_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetRenderLatencyInMs_FunctionAddress, intPtr, GetRenderLatencyInMs_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetRenderLatencyInMs_ReturnValue_Offset), 0, GetRenderLatencyInMs_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684611u)]
	[UMetaPath("/Script/StreamlineBlueprint.StreamlineLibraryReflex:GetReflexMode")]
	public unsafe static EUStreamlineReflexMode GetReflexMode()
	{
		if (!GetReflexMode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/StreamlineBlueprint.StreamlineLibraryReflex:GetReflexMode");
			return EUStreamlineReflexMode.Disabled;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetReflexMode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetReflexMode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetReflexMode_FunctionAddress, intPtr, GetReflexMode_ParamsSize);
		return EnumMarshaler<EUStreamlineReflexMode>.FromNative(IntPtr.Add(intPtr, GetReflexMode_ReturnValue_Offset), 0, GetReflexMode_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684611u)]
	[UMetaPath("/Script/StreamlineBlueprint.StreamlineLibraryReflex:GetGameToRenderLatencyInMs")]
	public unsafe static float GetGameToRenderLatencyInMs()
	{
		if (!GetGameToRenderLatencyInMs_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/StreamlineBlueprint.StreamlineLibraryReflex:GetGameToRenderLatencyInMs");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetGameToRenderLatencyInMs_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetGameToRenderLatencyInMs_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetGameToRenderLatencyInMs_FunctionAddress, intPtr, GetGameToRenderLatencyInMs_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetGameToRenderLatencyInMs_ReturnValue_Offset), 0, GetGameToRenderLatencyInMs_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684611u)]
	[UMetaPath("/Script/StreamlineBlueprint.StreamlineLibraryReflex:GetGameLatencyInMs")]
	public unsafe static float GetGameLatencyInMs()
	{
		if (!GetGameLatencyInMs_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/StreamlineBlueprint.StreamlineLibraryReflex:GetGameLatencyInMs");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetGameLatencyInMs_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetGameLatencyInMs_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetGameLatencyInMs_FunctionAddress, intPtr, GetGameLatencyInMs_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetGameLatencyInMs_ReturnValue_Offset), 0, GetGameLatencyInMs_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684611u)]
	[UMetaPath("/Script/StreamlineBlueprint.StreamlineLibraryReflex:GetDefaultReflexMode")]
	public unsafe static EUStreamlineReflexMode GetDefaultReflexMode()
	{
		if (!GetDefaultReflexMode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/StreamlineBlueprint.StreamlineLibraryReflex:GetDefaultReflexMode");
			return EUStreamlineReflexMode.Disabled;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDefaultReflexMode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDefaultReflexMode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetDefaultReflexMode_FunctionAddress, intPtr, GetDefaultReflexMode_ParamsSize);
		return EnumMarshaler<EUStreamlineReflexMode>.FromNative(IntPtr.Add(intPtr, GetDefaultReflexMode_ReturnValue_Offset), 0, GetDefaultReflexMode_ReturnValue_PropertyAddress.Address);
	}

	static UStreamlineLibraryReflex()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UStreamlineLibraryReflex)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UStreamlineLibraryReflex));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/StreamlineBlueprint.StreamlineLibraryReflex");
		SetReflexMode_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetReflexMode");
		SetReflexMode_ParamsSize = NativeReflection.GetFunctionParamsSize(SetReflexMode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetReflexMode_Mode_PropertyAddress, SetReflexMode_FunctionAddress, "Mode");
		SetReflexMode_Mode_Offset = NativeReflectionCached.GetPropertyOffset(SetReflexMode_FunctionAddress, "Mode");
		SetReflexMode_Mode_IsValid = NativeReflectionCached.ValidatePropertyClass(SetReflexMode_FunctionAddress, "Mode", Classes.FEnumProperty);
		SetReflexMode_IsValid = SetReflexMode_FunctionAddress != IntPtr.Zero && SetReflexMode_Mode_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/StreamlineBlueprint.StreamlineLibraryReflex:SetReflexMode", SetReflexMode_IsValid);
		QueryReflexSupport_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "QueryReflexSupport");
		QueryReflexSupport_ParamsSize = NativeReflection.GetFunctionParamsSize(QueryReflexSupport_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref QueryReflexSupport_ReturnValue_PropertyAddress, QueryReflexSupport_FunctionAddress, "ReturnValue");
		QueryReflexSupport_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(QueryReflexSupport_FunctionAddress, "ReturnValue");
		QueryReflexSupport_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(QueryReflexSupport_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		QueryReflexSupport_IsValid = QueryReflexSupport_FunctionAddress != IntPtr.Zero && QueryReflexSupport_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/StreamlineBlueprint.StreamlineLibraryReflex:QueryReflexSupport", QueryReflexSupport_IsValid);
		IsReflexSupported_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsReflexSupported");
		IsReflexSupported_ParamsSize = NativeReflection.GetFunctionParamsSize(IsReflexSupported_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsReflexSupported_ReturnValue_PropertyAddress, IsReflexSupported_FunctionAddress, "ReturnValue");
		IsReflexSupported_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsReflexSupported_FunctionAddress, "ReturnValue");
		IsReflexSupported_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsReflexSupported_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsReflexSupported_IsValid = IsReflexSupported_FunctionAddress != IntPtr.Zero && IsReflexSupported_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/StreamlineBlueprint.StreamlineLibraryReflex:IsReflexSupported", IsReflexSupported_IsValid);
		GetRenderLatencyInMs_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetRenderLatencyInMs");
		GetRenderLatencyInMs_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRenderLatencyInMs_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRenderLatencyInMs_ReturnValue_PropertyAddress, GetRenderLatencyInMs_FunctionAddress, "ReturnValue");
		GetRenderLatencyInMs_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRenderLatencyInMs_FunctionAddress, "ReturnValue");
		GetRenderLatencyInMs_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRenderLatencyInMs_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetRenderLatencyInMs_IsValid = GetRenderLatencyInMs_FunctionAddress != IntPtr.Zero && GetRenderLatencyInMs_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/StreamlineBlueprint.StreamlineLibraryReflex:GetRenderLatencyInMs", GetRenderLatencyInMs_IsValid);
		GetReflexMode_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetReflexMode");
		GetReflexMode_ParamsSize = NativeReflection.GetFunctionParamsSize(GetReflexMode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetReflexMode_ReturnValue_PropertyAddress, GetReflexMode_FunctionAddress, "ReturnValue");
		GetReflexMode_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetReflexMode_FunctionAddress, "ReturnValue");
		GetReflexMode_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetReflexMode_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		GetReflexMode_IsValid = GetReflexMode_FunctionAddress != IntPtr.Zero && GetReflexMode_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/StreamlineBlueprint.StreamlineLibraryReflex:GetReflexMode", GetReflexMode_IsValid);
		GetGameToRenderLatencyInMs_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetGameToRenderLatencyInMs");
		GetGameToRenderLatencyInMs_ParamsSize = NativeReflection.GetFunctionParamsSize(GetGameToRenderLatencyInMs_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetGameToRenderLatencyInMs_ReturnValue_PropertyAddress, GetGameToRenderLatencyInMs_FunctionAddress, "ReturnValue");
		GetGameToRenderLatencyInMs_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetGameToRenderLatencyInMs_FunctionAddress, "ReturnValue");
		GetGameToRenderLatencyInMs_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetGameToRenderLatencyInMs_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetGameToRenderLatencyInMs_IsValid = GetGameToRenderLatencyInMs_FunctionAddress != IntPtr.Zero && GetGameToRenderLatencyInMs_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/StreamlineBlueprint.StreamlineLibraryReflex:GetGameToRenderLatencyInMs", GetGameToRenderLatencyInMs_IsValid);
		GetGameLatencyInMs_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetGameLatencyInMs");
		GetGameLatencyInMs_ParamsSize = NativeReflection.GetFunctionParamsSize(GetGameLatencyInMs_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetGameLatencyInMs_ReturnValue_PropertyAddress, GetGameLatencyInMs_FunctionAddress, "ReturnValue");
		GetGameLatencyInMs_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetGameLatencyInMs_FunctionAddress, "ReturnValue");
		GetGameLatencyInMs_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetGameLatencyInMs_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetGameLatencyInMs_IsValid = GetGameLatencyInMs_FunctionAddress != IntPtr.Zero && GetGameLatencyInMs_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/StreamlineBlueprint.StreamlineLibraryReflex:GetGameLatencyInMs", GetGameLatencyInMs_IsValid);
		GetDefaultReflexMode_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetDefaultReflexMode");
		GetDefaultReflexMode_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDefaultReflexMode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDefaultReflexMode_ReturnValue_PropertyAddress, GetDefaultReflexMode_FunctionAddress, "ReturnValue");
		GetDefaultReflexMode_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDefaultReflexMode_FunctionAddress, "ReturnValue");
		GetDefaultReflexMode_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDefaultReflexMode_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		GetDefaultReflexMode_IsValid = GetDefaultReflexMode_FunctionAddress != IntPtr.Zero && GetDefaultReflexMode_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/StreamlineBlueprint.StreamlineLibraryReflex:GetDefaultReflexMode", GetDefaultReflexMode_IsValid);
	}
}
