using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.StreamlineBlueprint;

[UClass(Flags = (ClassFlags)810025120uL, Config = "Engine")]
[UMetaPath("/Script/StreamlineBlueprint.StreamlineLibraryDLSSG", "StreamlineBlueprint", UnrealModuleType.EnginePlugin)]
public class UStreamlineLibraryDLSSG : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool SetDLSSGMode_IsValid;

	private static IntPtr SetDLSSGMode_FunctionAddress;

	private static int SetDLSSGMode_ParamsSize;

	private static bool SetDLSSGMode_DLSSGMode_IsValid;

	private static FFieldAddress SetDLSSGMode_DLSSGMode_PropertyAddress;

	private static int SetDLSSGMode_DLSSGMode_Offset;

	private static bool QueryDLSSGSupport_IsValid;

	private static IntPtr QueryDLSSGSupport_FunctionAddress;

	private static int QueryDLSSGSupport_ParamsSize;

	private static bool QueryDLSSGSupport_ReturnValue_IsValid;

	private static FFieldAddress QueryDLSSGSupport_ReturnValue_PropertyAddress;

	private static int QueryDLSSGSupport_ReturnValue_Offset;

	private static bool IsDLSSGSupported_IsValid;

	private static IntPtr IsDLSSGSupported_FunctionAddress;

	private static int IsDLSSGSupported_ParamsSize;

	private static bool IsDLSSGSupported_ReturnValue_IsValid;

	private static FFieldAddress IsDLSSGSupported_ReturnValue_PropertyAddress;

	private static int IsDLSSGSupported_ReturnValue_Offset;

	private static bool IsDLSSGModeSupported_IsValid;

	private static IntPtr IsDLSSGModeSupported_FunctionAddress;

	private static int IsDLSSGModeSupported_ParamsSize;

	private static bool IsDLSSGModeSupported_DLSSGMode_IsValid;

	private static FFieldAddress IsDLSSGModeSupported_DLSSGMode_PropertyAddress;

	private static int IsDLSSGModeSupported_DLSSGMode_Offset;

	private static bool IsDLSSGModeSupported_ReturnValue_IsValid;

	private static FFieldAddress IsDLSSGModeSupported_ReturnValue_PropertyAddress;

	private static int IsDLSSGModeSupported_ReturnValue_Offset;

	private static bool GetSupportedDLSSGModes_IsValid;

	private static IntPtr GetSupportedDLSSGModes_FunctionAddress;

	private static int GetSupportedDLSSGModes_ParamsSize;

	private static bool GetSupportedDLSSGModes_ReturnValue_IsValid;

	private static FFieldAddress GetSupportedDLSSGModes_ReturnValue_PropertyAddress;

	private static int GetSupportedDLSSGModes_ReturnValue_Offset;

	private static bool GetDLSSGMode_IsValid;

	private static IntPtr GetDLSSGMode_FunctionAddress;

	private static int GetDLSSGMode_ParamsSize;

	private static bool GetDLSSGMode_ReturnValue_IsValid;

	private static FFieldAddress GetDLSSGMode_ReturnValue_PropertyAddress;

	private static int GetDLSSGMode_ReturnValue_Offset;

	private static bool GetDLSSGFrameTiming_IsValid;

	private static IntPtr GetDLSSGFrameTiming_FunctionAddress;

	private static int GetDLSSGFrameTiming_ParamsSize;

	private static bool GetDLSSGFrameTiming_FrameRateInHertz_IsValid;

	private static FFieldAddress GetDLSSGFrameTiming_FrameRateInHertz_PropertyAddress;

	private static int GetDLSSGFrameTiming_FrameRateInHertz_Offset;

	private static bool GetDLSSGFrameTiming_FramesPresented_IsValid;

	private static FFieldAddress GetDLSSGFrameTiming_FramesPresented_PropertyAddress;

	private static int GetDLSSGFrameTiming_FramesPresented_Offset;

	private static bool GetDefaultDLSSGMode_IsValid;

	private static IntPtr GetDefaultDLSSGMode_FunctionAddress;

	private static int GetDefaultDLSSGMode_ParamsSize;

	private static bool GetDefaultDLSSGMode_ReturnValue_IsValid;

	private static FFieldAddress GetDefaultDLSSGMode_ReturnValue_PropertyAddress;

	private static int GetDefaultDLSSGMode_ReturnValue_Offset;

	[UFunction(Flags = 67249155u)]
	[UMetaPath("/Script/StreamlineBlueprint.StreamlineLibraryDLSSG:SetDLSSGMode")]
	public unsafe static void SetDLSSGMode(EUStreamlineDLSSGMode DLSSGMode)
	{
		if (!SetDLSSGMode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/StreamlineBlueprint.StreamlineLibraryDLSSG:SetDLSSGMode");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDLSSGMode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDLSSGMode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EUStreamlineDLSSGMode>.ToNative(IntPtr.Add(intPtr, SetDLSSGMode_DLSSGMode_Offset), 0, SetDLSSGMode_DLSSGMode_PropertyAddress.Address, DLSSGMode);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetDLSSGMode_FunctionAddress, intPtr, SetDLSSGMode_ParamsSize);
	}

	[UFunction(Flags = 335684611u)]
	[UMetaPath("/Script/StreamlineBlueprint.StreamlineLibraryDLSSG:QueryDLSSGSupport")]
	public unsafe static EUStreamlineFeatureSupport QueryDLSSGSupport()
	{
		if (!QueryDLSSGSupport_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/StreamlineBlueprint.StreamlineLibraryDLSSG:QueryDLSSGSupport");
			return EUStreamlineFeatureSupport.Supported;
		}
		byte* ptr = stackalloc byte[(int)(uint)(QueryDLSSGSupport_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)QueryDLSSGSupport_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, QueryDLSSGSupport_FunctionAddress, intPtr, QueryDLSSGSupport_ParamsSize);
		return EnumMarshaler<EUStreamlineFeatureSupport>.FromNative(IntPtr.Add(intPtr, QueryDLSSGSupport_ReturnValue_Offset), 0, QueryDLSSGSupport_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684611u)]
	[UMetaPath("/Script/StreamlineBlueprint.StreamlineLibraryDLSSG:IsDLSSGSupported")]
	public unsafe static bool IsDLSSGSupported()
	{
		if (!IsDLSSGSupported_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/StreamlineBlueprint.StreamlineLibraryDLSSG:IsDLSSGSupported");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsDLSSGSupported_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsDLSSGSupported_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsDLSSGSupported_FunctionAddress, intPtr, IsDLSSGSupported_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsDLSSGSupported_ReturnValue_Offset), 0, IsDLSSGSupported_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684611u)]
	[UMetaPath("/Script/StreamlineBlueprint.StreamlineLibraryDLSSG:IsDLSSGModeSupported")]
	public unsafe static bool IsDLSSGModeSupported(EUStreamlineDLSSGMode DLSSGMode)
	{
		if (!IsDLSSGModeSupported_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/StreamlineBlueprint.StreamlineLibraryDLSSG:IsDLSSGModeSupported");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsDLSSGModeSupported_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsDLSSGModeSupported_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EUStreamlineDLSSGMode>.ToNative(IntPtr.Add(intPtr, IsDLSSGModeSupported_DLSSGMode_Offset), 0, IsDLSSGModeSupported_DLSSGMode_PropertyAddress.Address, DLSSGMode);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsDLSSGModeSupported_FunctionAddress, intPtr, IsDLSSGModeSupported_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsDLSSGModeSupported_ReturnValue_Offset), 0, IsDLSSGModeSupported_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684611u)]
	[UMetaPath("/Script/StreamlineBlueprint.StreamlineLibraryDLSSG:GetSupportedDLSSGModes")]
	public unsafe static List<EUStreamlineDLSSGMode> GetSupportedDLSSGModes()
	{
		if (!GetSupportedDLSSGModes_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/StreamlineBlueprint.StreamlineLibraryDLSSG:GetSupportedDLSSGModes");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSupportedDLSSGModes_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSupportedDLSSGModes_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetSupportedDLSSGModes_FunctionAddress, intPtr, GetSupportedDLSSGModes_ParamsSize);
		List<EUStreamlineDLSSGMode> result = new TArrayCopyMarshaler<EUStreamlineDLSSGMode>(1, GetSupportedDLSSGModes_ReturnValue_PropertyAddress, CachedMarshalingDelegates<EUStreamlineDLSSGMode, EnumMarshaler<EUStreamlineDLSSGMode>>.FromNative, CachedMarshalingDelegates<EUStreamlineDLSSGMode, EnumMarshaler<EUStreamlineDLSSGMode>>.ToNative).FromNative(IntPtr.Add(intPtr, GetSupportedDLSSGModes_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetSupportedDLSSGModes_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684611u)]
	[UMetaPath("/Script/StreamlineBlueprint.StreamlineLibraryDLSSG:GetDLSSGMode")]
	public unsafe static EUStreamlineDLSSGMode GetDLSSGMode()
	{
		if (!GetDLSSGMode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/StreamlineBlueprint.StreamlineLibraryDLSSG:GetDLSSGMode");
			return EUStreamlineDLSSGMode.Off;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDLSSGMode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDLSSGMode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetDLSSGMode_FunctionAddress, intPtr, GetDLSSGMode_ParamsSize);
		return EnumMarshaler<EUStreamlineDLSSGMode>.FromNative(IntPtr.Add(intPtr, GetDLSSGMode_ReturnValue_Offset), 0, GetDLSSGMode_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878915u)]
	[UMetaPath("/Script/StreamlineBlueprint.StreamlineLibraryDLSSG:GetDLSSGFrameTiming")]
	public unsafe static void GetDLSSGFrameTiming(out float FrameRateInHertz, out int FramesPresented)
	{
		if (!GetDLSSGFrameTiming_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/StreamlineBlueprint.StreamlineLibraryDLSSG:GetDLSSGFrameTiming");
			FrameRateInHertz = 0f;
			FramesPresented = 0;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDLSSGFrameTiming_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDLSSGFrameTiming_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetDLSSGFrameTiming_FunctionAddress, intPtr, GetDLSSGFrameTiming_ParamsSize);
		FrameRateInHertz = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetDLSSGFrameTiming_FrameRateInHertz_Offset), 0, GetDLSSGFrameTiming_FrameRateInHertz_PropertyAddress.Address);
		FramesPresented = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetDLSSGFrameTiming_FramesPresented_Offset), 0, GetDLSSGFrameTiming_FramesPresented_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684611u)]
	[UMetaPath("/Script/StreamlineBlueprint.StreamlineLibraryDLSSG:GetDefaultDLSSGMode")]
	public unsafe static EUStreamlineDLSSGMode GetDefaultDLSSGMode()
	{
		if (!GetDefaultDLSSGMode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/StreamlineBlueprint.StreamlineLibraryDLSSG:GetDefaultDLSSGMode");
			return EUStreamlineDLSSGMode.Off;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDefaultDLSSGMode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDefaultDLSSGMode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetDefaultDLSSGMode_FunctionAddress, intPtr, GetDefaultDLSSGMode_ParamsSize);
		return EnumMarshaler<EUStreamlineDLSSGMode>.FromNative(IntPtr.Add(intPtr, GetDefaultDLSSGMode_ReturnValue_Offset), 0, GetDefaultDLSSGMode_ReturnValue_PropertyAddress.Address);
	}

	static UStreamlineLibraryDLSSG()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UStreamlineLibraryDLSSG)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UStreamlineLibraryDLSSG));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/StreamlineBlueprint.StreamlineLibraryDLSSG");
		SetDLSSGMode_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetDLSSGMode");
		SetDLSSGMode_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDLSSGMode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDLSSGMode_DLSSGMode_PropertyAddress, SetDLSSGMode_FunctionAddress, "DLSSGMode");
		SetDLSSGMode_DLSSGMode_Offset = NativeReflectionCached.GetPropertyOffset(SetDLSSGMode_FunctionAddress, "DLSSGMode");
		SetDLSSGMode_DLSSGMode_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDLSSGMode_FunctionAddress, "DLSSGMode", Classes.FEnumProperty);
		SetDLSSGMode_IsValid = SetDLSSGMode_FunctionAddress != IntPtr.Zero && SetDLSSGMode_DLSSGMode_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/StreamlineBlueprint.StreamlineLibraryDLSSG:SetDLSSGMode", SetDLSSGMode_IsValid);
		QueryDLSSGSupport_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "QueryDLSSGSupport");
		QueryDLSSGSupport_ParamsSize = NativeReflection.GetFunctionParamsSize(QueryDLSSGSupport_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref QueryDLSSGSupport_ReturnValue_PropertyAddress, QueryDLSSGSupport_FunctionAddress, "ReturnValue");
		QueryDLSSGSupport_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(QueryDLSSGSupport_FunctionAddress, "ReturnValue");
		QueryDLSSGSupport_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(QueryDLSSGSupport_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		QueryDLSSGSupport_IsValid = QueryDLSSGSupport_FunctionAddress != IntPtr.Zero && QueryDLSSGSupport_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/StreamlineBlueprint.StreamlineLibraryDLSSG:QueryDLSSGSupport", QueryDLSSGSupport_IsValid);
		IsDLSSGSupported_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsDLSSGSupported");
		IsDLSSGSupported_ParamsSize = NativeReflection.GetFunctionParamsSize(IsDLSSGSupported_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsDLSSGSupported_ReturnValue_PropertyAddress, IsDLSSGSupported_FunctionAddress, "ReturnValue");
		IsDLSSGSupported_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsDLSSGSupported_FunctionAddress, "ReturnValue");
		IsDLSSGSupported_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsDLSSGSupported_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsDLSSGSupported_IsValid = IsDLSSGSupported_FunctionAddress != IntPtr.Zero && IsDLSSGSupported_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/StreamlineBlueprint.StreamlineLibraryDLSSG:IsDLSSGSupported", IsDLSSGSupported_IsValid);
		IsDLSSGModeSupported_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsDLSSGModeSupported");
		IsDLSSGModeSupported_ParamsSize = NativeReflection.GetFunctionParamsSize(IsDLSSGModeSupported_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsDLSSGModeSupported_DLSSGMode_PropertyAddress, IsDLSSGModeSupported_FunctionAddress, "DLSSGMode");
		IsDLSSGModeSupported_DLSSGMode_Offset = NativeReflectionCached.GetPropertyOffset(IsDLSSGModeSupported_FunctionAddress, "DLSSGMode");
		IsDLSSGModeSupported_DLSSGMode_IsValid = NativeReflectionCached.ValidatePropertyClass(IsDLSSGModeSupported_FunctionAddress, "DLSSGMode", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref IsDLSSGModeSupported_ReturnValue_PropertyAddress, IsDLSSGModeSupported_FunctionAddress, "ReturnValue");
		IsDLSSGModeSupported_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsDLSSGModeSupported_FunctionAddress, "ReturnValue");
		IsDLSSGModeSupported_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsDLSSGModeSupported_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsDLSSGModeSupported_IsValid = IsDLSSGModeSupported_FunctionAddress != IntPtr.Zero && IsDLSSGModeSupported_DLSSGMode_IsValid && IsDLSSGModeSupported_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/StreamlineBlueprint.StreamlineLibraryDLSSG:IsDLSSGModeSupported", IsDLSSGModeSupported_IsValid);
		GetSupportedDLSSGModes_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetSupportedDLSSGModes");
		GetSupportedDLSSGModes_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSupportedDLSSGModes_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSupportedDLSSGModes_ReturnValue_PropertyAddress, GetSupportedDLSSGModes_FunctionAddress, "ReturnValue");
		GetSupportedDLSSGModes_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSupportedDLSSGModes_FunctionAddress, "ReturnValue");
		GetSupportedDLSSGModes_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSupportedDLSSGModes_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetSupportedDLSSGModes_IsValid = GetSupportedDLSSGModes_FunctionAddress != IntPtr.Zero && GetSupportedDLSSGModes_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/StreamlineBlueprint.StreamlineLibraryDLSSG:GetSupportedDLSSGModes", GetSupportedDLSSGModes_IsValid);
		GetDLSSGMode_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetDLSSGMode");
		GetDLSSGMode_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDLSSGMode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDLSSGMode_ReturnValue_PropertyAddress, GetDLSSGMode_FunctionAddress, "ReturnValue");
		GetDLSSGMode_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDLSSGMode_FunctionAddress, "ReturnValue");
		GetDLSSGMode_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDLSSGMode_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		GetDLSSGMode_IsValid = GetDLSSGMode_FunctionAddress != IntPtr.Zero && GetDLSSGMode_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/StreamlineBlueprint.StreamlineLibraryDLSSG:GetDLSSGMode", GetDLSSGMode_IsValid);
		GetDLSSGFrameTiming_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetDLSSGFrameTiming");
		GetDLSSGFrameTiming_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDLSSGFrameTiming_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDLSSGFrameTiming_FrameRateInHertz_PropertyAddress, GetDLSSGFrameTiming_FunctionAddress, "FrameRateInHertz");
		GetDLSSGFrameTiming_FrameRateInHertz_Offset = NativeReflectionCached.GetPropertyOffset(GetDLSSGFrameTiming_FunctionAddress, "FrameRateInHertz");
		GetDLSSGFrameTiming_FrameRateInHertz_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDLSSGFrameTiming_FunctionAddress, "FrameRateInHertz", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDLSSGFrameTiming_FramesPresented_PropertyAddress, GetDLSSGFrameTiming_FunctionAddress, "FramesPresented");
		GetDLSSGFrameTiming_FramesPresented_Offset = NativeReflectionCached.GetPropertyOffset(GetDLSSGFrameTiming_FunctionAddress, "FramesPresented");
		GetDLSSGFrameTiming_FramesPresented_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDLSSGFrameTiming_FunctionAddress, "FramesPresented", Classes.FIntProperty);
		GetDLSSGFrameTiming_IsValid = GetDLSSGFrameTiming_FunctionAddress != IntPtr.Zero && GetDLSSGFrameTiming_FrameRateInHertz_IsValid && GetDLSSGFrameTiming_FramesPresented_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/StreamlineBlueprint.StreamlineLibraryDLSSG:GetDLSSGFrameTiming", GetDLSSGFrameTiming_IsValid);
		GetDefaultDLSSGMode_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetDefaultDLSSGMode");
		GetDefaultDLSSGMode_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDefaultDLSSGMode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDefaultDLSSGMode_ReturnValue_PropertyAddress, GetDefaultDLSSGMode_FunctionAddress, "ReturnValue");
		GetDefaultDLSSGMode_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDefaultDLSSGMode_FunctionAddress, "ReturnValue");
		GetDefaultDLSSGMode_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDefaultDLSSGMode_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		GetDefaultDLSSGMode_IsValid = GetDefaultDLSSGMode_FunctionAddress != IntPtr.Zero && GetDefaultDLSSGMode_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/StreamlineBlueprint.StreamlineLibraryDLSSG:GetDefaultDLSSGMode", GetDefaultDLSSGMode_IsValid);
	}
}
