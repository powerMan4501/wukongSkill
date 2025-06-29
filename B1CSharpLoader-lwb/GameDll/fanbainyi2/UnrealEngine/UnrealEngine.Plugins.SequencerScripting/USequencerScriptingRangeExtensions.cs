using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.SequencerScripting;

[UClass(Flags = (ClassFlags)809500832uL, Config = "Engine")]
[UMetaPath("/Script/SequencerScripting.SequencerScriptingRangeExtensions", "SequencerScripting", UnrealModuleType.EnginePlugin)]
public class USequencerScriptingRangeExtensions : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool SetStartSeconds_IsValid;

	private static IntPtr SetStartSeconds_FunctionAddress;

	private static int SetStartSeconds_ParamsSize;

	private static bool SetStartSeconds_Range_IsValid;

	private static FFieldAddress SetStartSeconds_Range_PropertyAddress;

	private static int SetStartSeconds_Range_Offset;

	private static bool SetStartSeconds_Start_IsValid;

	private static FFieldAddress SetStartSeconds_Start_PropertyAddress;

	private static int SetStartSeconds_Start_Offset;

	private static bool SetStartFrame_IsValid;

	private static IntPtr SetStartFrame_FunctionAddress;

	private static int SetStartFrame_ParamsSize;

	private static bool SetStartFrame_Range_IsValid;

	private static FFieldAddress SetStartFrame_Range_PropertyAddress;

	private static int SetStartFrame_Range_Offset;

	private static bool SetStartFrame_Start_IsValid;

	private static FFieldAddress SetStartFrame_Start_PropertyAddress;

	private static int SetStartFrame_Start_Offset;

	private static bool SetEndSeconds_IsValid;

	private static IntPtr SetEndSeconds_FunctionAddress;

	private static int SetEndSeconds_ParamsSize;

	private static bool SetEndSeconds_Range_IsValid;

	private static FFieldAddress SetEndSeconds_Range_PropertyAddress;

	private static int SetEndSeconds_Range_Offset;

	private static bool SetEndSeconds_End_IsValid;

	private static FFieldAddress SetEndSeconds_End_PropertyAddress;

	private static int SetEndSeconds_End_Offset;

	private static bool SetEndFrame_IsValid;

	private static IntPtr SetEndFrame_FunctionAddress;

	private static int SetEndFrame_ParamsSize;

	private static bool SetEndFrame_Range_IsValid;

	private static FFieldAddress SetEndFrame_Range_PropertyAddress;

	private static int SetEndFrame_Range_Offset;

	private static bool SetEndFrame_End_IsValid;

	private static FFieldAddress SetEndFrame_End_PropertyAddress;

	private static int SetEndFrame_End_Offset;

	private static bool RemoveStart_IsValid;

	private static IntPtr RemoveStart_FunctionAddress;

	private static int RemoveStart_ParamsSize;

	private static bool RemoveStart_Range_IsValid;

	private static FFieldAddress RemoveStart_Range_PropertyAddress;

	private static int RemoveStart_Range_Offset;

	private static bool RemoveEnd_IsValid;

	private static IntPtr RemoveEnd_FunctionAddress;

	private static int RemoveEnd_ParamsSize;

	private static bool RemoveEnd_Range_IsValid;

	private static FFieldAddress RemoveEnd_Range_PropertyAddress;

	private static int RemoveEnd_Range_Offset;

	private static bool HasStart_IsValid;

	private static IntPtr HasStart_FunctionAddress;

	private static int HasStart_ParamsSize;

	private static bool HasStart_Range_IsValid;

	private static FFieldAddress HasStart_Range_PropertyAddress;

	private static int HasStart_Range_Offset;

	private static bool HasStart_ReturnValue_IsValid;

	private static FFieldAddress HasStart_ReturnValue_PropertyAddress;

	private static int HasStart_ReturnValue_Offset;

	private static bool HasEnd_IsValid;

	private static IntPtr HasEnd_FunctionAddress;

	private static int HasEnd_ParamsSize;

	private static bool HasEnd_Range_IsValid;

	private static FFieldAddress HasEnd_Range_PropertyAddress;

	private static int HasEnd_Range_Offset;

	private static bool HasEnd_ReturnValue_IsValid;

	private static FFieldAddress HasEnd_ReturnValue_PropertyAddress;

	private static int HasEnd_ReturnValue_Offset;

	private static bool GetStartSeconds_IsValid;

	private static IntPtr GetStartSeconds_FunctionAddress;

	private static int GetStartSeconds_ParamsSize;

	private static bool GetStartSeconds_Range_IsValid;

	private static FFieldAddress GetStartSeconds_Range_PropertyAddress;

	private static int GetStartSeconds_Range_Offset;

	private static bool GetStartSeconds_ReturnValue_IsValid;

	private static FFieldAddress GetStartSeconds_ReturnValue_PropertyAddress;

	private static int GetStartSeconds_ReturnValue_Offset;

	private static bool GetStartFrame_IsValid;

	private static IntPtr GetStartFrame_FunctionAddress;

	private static int GetStartFrame_ParamsSize;

	private static bool GetStartFrame_Range_IsValid;

	private static FFieldAddress GetStartFrame_Range_PropertyAddress;

	private static int GetStartFrame_Range_Offset;

	private static bool GetStartFrame_ReturnValue_IsValid;

	private static FFieldAddress GetStartFrame_ReturnValue_PropertyAddress;

	private static int GetStartFrame_ReturnValue_Offset;

	private static bool GetEndSeconds_IsValid;

	private static IntPtr GetEndSeconds_FunctionAddress;

	private static int GetEndSeconds_ParamsSize;

	private static bool GetEndSeconds_Range_IsValid;

	private static FFieldAddress GetEndSeconds_Range_PropertyAddress;

	private static int GetEndSeconds_Range_Offset;

	private static bool GetEndSeconds_ReturnValue_IsValid;

	private static FFieldAddress GetEndSeconds_ReturnValue_PropertyAddress;

	private static int GetEndSeconds_ReturnValue_Offset;

	private static bool GetEndFrame_IsValid;

	private static IntPtr GetEndFrame_FunctionAddress;

	private static int GetEndFrame_ParamsSize;

	private static bool GetEndFrame_Range_IsValid;

	private static FFieldAddress GetEndFrame_Range_PropertyAddress;

	private static int GetEndFrame_Range_Offset;

	private static bool GetEndFrame_ReturnValue_IsValid;

	private static FFieldAddress GetEndFrame_ReturnValue_PropertyAddress;

	private static int GetEndFrame_ReturnValue_Offset;

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/SequencerScripting.SequencerScriptingRangeExtensions:SetStartSeconds")]
	public unsafe static void SetStartSeconds(ref FSequencerScriptingRange Range, float Start)
	{
		if (!SetStartSeconds_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.SequencerScriptingRangeExtensions:SetStartSeconds");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetStartSeconds_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetStartSeconds_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetStartSeconds_Range_PropertyAddress.Address, intPtr);
		FSequencerScriptingRange.ToNative(IntPtr.Add(intPtr, SetStartSeconds_Range_Offset), 0, SetStartSeconds_Range_PropertyAddress.Address, Range);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetStartSeconds_Start_Offset), 0, SetStartSeconds_Start_PropertyAddress.Address, Start);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetStartSeconds_FunctionAddress, intPtr, SetStartSeconds_ParamsSize);
		Range = FSequencerScriptingRange.FromNative(IntPtr.Add(intPtr, SetStartSeconds_Range_Offset), 0, SetStartSeconds_Range_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/SequencerScripting.SequencerScriptingRangeExtensions:SetStartFrame")]
	public unsafe static void SetStartFrame(ref FSequencerScriptingRange Range, int Start)
	{
		if (!SetStartFrame_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.SequencerScriptingRangeExtensions:SetStartFrame");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetStartFrame_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetStartFrame_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetStartFrame_Range_PropertyAddress.Address, intPtr);
		FSequencerScriptingRange.ToNative(IntPtr.Add(intPtr, SetStartFrame_Range_Offset), 0, SetStartFrame_Range_PropertyAddress.Address, Range);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetStartFrame_Start_Offset), 0, SetStartFrame_Start_PropertyAddress.Address, Start);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetStartFrame_FunctionAddress, intPtr, SetStartFrame_ParamsSize);
		Range = FSequencerScriptingRange.FromNative(IntPtr.Add(intPtr, SetStartFrame_Range_Offset), 0, SetStartFrame_Range_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/SequencerScripting.SequencerScriptingRangeExtensions:SetEndSeconds")]
	public unsafe static void SetEndSeconds(ref FSequencerScriptingRange Range, float End)
	{
		if (!SetEndSeconds_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.SequencerScriptingRangeExtensions:SetEndSeconds");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetEndSeconds_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetEndSeconds_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetEndSeconds_Range_PropertyAddress.Address, intPtr);
		FSequencerScriptingRange.ToNative(IntPtr.Add(intPtr, SetEndSeconds_Range_Offset), 0, SetEndSeconds_Range_PropertyAddress.Address, Range);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetEndSeconds_End_Offset), 0, SetEndSeconds_End_PropertyAddress.Address, End);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetEndSeconds_FunctionAddress, intPtr, SetEndSeconds_ParamsSize);
		Range = FSequencerScriptingRange.FromNative(IntPtr.Add(intPtr, SetEndSeconds_Range_Offset), 0, SetEndSeconds_Range_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/SequencerScripting.SequencerScriptingRangeExtensions:SetEndFrame")]
	public unsafe static void SetEndFrame(ref FSequencerScriptingRange Range, int End)
	{
		if (!SetEndFrame_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.SequencerScriptingRangeExtensions:SetEndFrame");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetEndFrame_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetEndFrame_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetEndFrame_Range_PropertyAddress.Address, intPtr);
		FSequencerScriptingRange.ToNative(IntPtr.Add(intPtr, SetEndFrame_Range_Offset), 0, SetEndFrame_Range_PropertyAddress.Address, Range);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetEndFrame_End_Offset), 0, SetEndFrame_End_PropertyAddress.Address, End);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetEndFrame_FunctionAddress, intPtr, SetEndFrame_ParamsSize);
		Range = FSequencerScriptingRange.FromNative(IntPtr.Add(intPtr, SetEndFrame_Range_Offset), 0, SetEndFrame_Range_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/SequencerScripting.SequencerScriptingRangeExtensions:RemoveStart")]
	public unsafe static void RemoveStart(ref FSequencerScriptingRange Range)
	{
		if (!RemoveStart_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.SequencerScriptingRangeExtensions:RemoveStart");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveStart_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveStart_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(RemoveStart_Range_PropertyAddress.Address, intPtr);
		FSequencerScriptingRange.ToNative(IntPtr.Add(intPtr, RemoveStart_Range_Offset), 0, RemoveStart_Range_PropertyAddress.Address, Range);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RemoveStart_FunctionAddress, intPtr, RemoveStart_ParamsSize);
		Range = FSequencerScriptingRange.FromNative(IntPtr.Add(intPtr, RemoveStart_Range_Offset), 0, RemoveStart_Range_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/SequencerScripting.SequencerScriptingRangeExtensions:RemoveEnd")]
	public unsafe static void RemoveEnd(ref FSequencerScriptingRange Range)
	{
		if (!RemoveEnd_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.SequencerScriptingRangeExtensions:RemoveEnd");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveEnd_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveEnd_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(RemoveEnd_Range_PropertyAddress.Address, intPtr);
		FSequencerScriptingRange.ToNative(IntPtr.Add(intPtr, RemoveEnd_Range_Offset), 0, RemoveEnd_Range_PropertyAddress.Address, Range);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RemoveEnd_FunctionAddress, intPtr, RemoveEnd_ParamsSize);
		Range = FSequencerScriptingRange.FromNative(IntPtr.Add(intPtr, RemoveEnd_Range_Offset), 0, RemoveEnd_Range_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/SequencerScripting.SequencerScriptingRangeExtensions:HasStart")]
	public unsafe static bool HasStart(FSequencerScriptingRange Range)
	{
		if (!HasStart_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.SequencerScriptingRangeExtensions:HasStart");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HasStart_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HasStart_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(HasStart_Range_PropertyAddress.Address, intPtr);
		FSequencerScriptingRange.ToNative(IntPtr.Add(intPtr, HasStart_Range_Offset), 0, HasStart_Range_PropertyAddress.Address, Range);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, HasStart_FunctionAddress, intPtr, HasStart_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, HasStart_ReturnValue_Offset), 0, HasStart_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/SequencerScripting.SequencerScriptingRangeExtensions:HasEnd")]
	public unsafe static bool HasEnd(FSequencerScriptingRange Range)
	{
		if (!HasEnd_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.SequencerScriptingRangeExtensions:HasEnd");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HasEnd_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HasEnd_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(HasEnd_Range_PropertyAddress.Address, intPtr);
		FSequencerScriptingRange.ToNative(IntPtr.Add(intPtr, HasEnd_Range_Offset), 0, HasEnd_Range_PropertyAddress.Address, Range);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, HasEnd_FunctionAddress, intPtr, HasEnd_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, HasEnd_ReturnValue_Offset), 0, HasEnd_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/SequencerScripting.SequencerScriptingRangeExtensions:GetStartSeconds")]
	public unsafe static float GetStartSeconds(FSequencerScriptingRange Range)
	{
		if (!GetStartSeconds_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.SequencerScriptingRangeExtensions:GetStartSeconds");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetStartSeconds_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetStartSeconds_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetStartSeconds_Range_PropertyAddress.Address, intPtr);
		FSequencerScriptingRange.ToNative(IntPtr.Add(intPtr, GetStartSeconds_Range_Offset), 0, GetStartSeconds_Range_PropertyAddress.Address, Range);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetStartSeconds_FunctionAddress, intPtr, GetStartSeconds_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetStartSeconds_ReturnValue_Offset), 0, GetStartSeconds_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/SequencerScripting.SequencerScriptingRangeExtensions:GetStartFrame")]
	public unsafe static int GetStartFrame(FSequencerScriptingRange Range)
	{
		if (!GetStartFrame_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.SequencerScriptingRangeExtensions:GetStartFrame");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetStartFrame_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetStartFrame_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetStartFrame_Range_PropertyAddress.Address, intPtr);
		FSequencerScriptingRange.ToNative(IntPtr.Add(intPtr, GetStartFrame_Range_Offset), 0, GetStartFrame_Range_PropertyAddress.Address, Range);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetStartFrame_FunctionAddress, intPtr, GetStartFrame_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetStartFrame_ReturnValue_Offset), 0, GetStartFrame_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/SequencerScripting.SequencerScriptingRangeExtensions:GetEndSeconds")]
	public unsafe static float GetEndSeconds(FSequencerScriptingRange Range)
	{
		if (!GetEndSeconds_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.SequencerScriptingRangeExtensions:GetEndSeconds");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetEndSeconds_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetEndSeconds_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetEndSeconds_Range_PropertyAddress.Address, intPtr);
		FSequencerScriptingRange.ToNative(IntPtr.Add(intPtr, GetEndSeconds_Range_Offset), 0, GetEndSeconds_Range_PropertyAddress.Address, Range);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetEndSeconds_FunctionAddress, intPtr, GetEndSeconds_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetEndSeconds_ReturnValue_Offset), 0, GetEndSeconds_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/SequencerScripting.SequencerScriptingRangeExtensions:GetEndFrame")]
	public unsafe static int GetEndFrame(FSequencerScriptingRange Range)
	{
		if (!GetEndFrame_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.SequencerScriptingRangeExtensions:GetEndFrame");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetEndFrame_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetEndFrame_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetEndFrame_Range_PropertyAddress.Address, intPtr);
		FSequencerScriptingRange.ToNative(IntPtr.Add(intPtr, GetEndFrame_Range_Offset), 0, GetEndFrame_Range_PropertyAddress.Address, Range);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetEndFrame_FunctionAddress, intPtr, GetEndFrame_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetEndFrame_ReturnValue_Offset), 0, GetEndFrame_ReturnValue_PropertyAddress.Address);
	}

	static USequencerScriptingRangeExtensions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(USequencerScriptingRangeExtensions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(USequencerScriptingRangeExtensions));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/SequencerScripting.SequencerScriptingRangeExtensions");
		SetStartSeconds_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetStartSeconds");
		SetStartSeconds_ParamsSize = NativeReflection.GetFunctionParamsSize(SetStartSeconds_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetStartSeconds_Range_PropertyAddress, SetStartSeconds_FunctionAddress, "Range");
		SetStartSeconds_Range_Offset = NativeReflectionCached.GetPropertyOffset(SetStartSeconds_FunctionAddress, "Range");
		SetStartSeconds_Range_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStartSeconds_FunctionAddress, "Range", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetStartSeconds_Start_PropertyAddress, SetStartSeconds_FunctionAddress, "Start");
		SetStartSeconds_Start_Offset = NativeReflectionCached.GetPropertyOffset(SetStartSeconds_FunctionAddress, "Start");
		SetStartSeconds_Start_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStartSeconds_FunctionAddress, "Start", Classes.FFloatProperty);
		SetStartSeconds_IsValid = SetStartSeconds_FunctionAddress != IntPtr.Zero && SetStartSeconds_Range_IsValid && SetStartSeconds_Start_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.SequencerScriptingRangeExtensions:SetStartSeconds", SetStartSeconds_IsValid);
		SetStartFrame_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetStartFrame");
		SetStartFrame_ParamsSize = NativeReflection.GetFunctionParamsSize(SetStartFrame_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetStartFrame_Range_PropertyAddress, SetStartFrame_FunctionAddress, "Range");
		SetStartFrame_Range_Offset = NativeReflectionCached.GetPropertyOffset(SetStartFrame_FunctionAddress, "Range");
		SetStartFrame_Range_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStartFrame_FunctionAddress, "Range", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetStartFrame_Start_PropertyAddress, SetStartFrame_FunctionAddress, "Start");
		SetStartFrame_Start_Offset = NativeReflectionCached.GetPropertyOffset(SetStartFrame_FunctionAddress, "Start");
		SetStartFrame_Start_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStartFrame_FunctionAddress, "Start", Classes.FIntProperty);
		SetStartFrame_IsValid = SetStartFrame_FunctionAddress != IntPtr.Zero && SetStartFrame_Range_IsValid && SetStartFrame_Start_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.SequencerScriptingRangeExtensions:SetStartFrame", SetStartFrame_IsValid);
		SetEndSeconds_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetEndSeconds");
		SetEndSeconds_ParamsSize = NativeReflection.GetFunctionParamsSize(SetEndSeconds_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetEndSeconds_Range_PropertyAddress, SetEndSeconds_FunctionAddress, "Range");
		SetEndSeconds_Range_Offset = NativeReflectionCached.GetPropertyOffset(SetEndSeconds_FunctionAddress, "Range");
		SetEndSeconds_Range_IsValid = NativeReflectionCached.ValidatePropertyClass(SetEndSeconds_FunctionAddress, "Range", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetEndSeconds_End_PropertyAddress, SetEndSeconds_FunctionAddress, "End");
		SetEndSeconds_End_Offset = NativeReflectionCached.GetPropertyOffset(SetEndSeconds_FunctionAddress, "End");
		SetEndSeconds_End_IsValid = NativeReflectionCached.ValidatePropertyClass(SetEndSeconds_FunctionAddress, "End", Classes.FFloatProperty);
		SetEndSeconds_IsValid = SetEndSeconds_FunctionAddress != IntPtr.Zero && SetEndSeconds_Range_IsValid && SetEndSeconds_End_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.SequencerScriptingRangeExtensions:SetEndSeconds", SetEndSeconds_IsValid);
		SetEndFrame_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetEndFrame");
		SetEndFrame_ParamsSize = NativeReflection.GetFunctionParamsSize(SetEndFrame_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetEndFrame_Range_PropertyAddress, SetEndFrame_FunctionAddress, "Range");
		SetEndFrame_Range_Offset = NativeReflectionCached.GetPropertyOffset(SetEndFrame_FunctionAddress, "Range");
		SetEndFrame_Range_IsValid = NativeReflectionCached.ValidatePropertyClass(SetEndFrame_FunctionAddress, "Range", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetEndFrame_End_PropertyAddress, SetEndFrame_FunctionAddress, "End");
		SetEndFrame_End_Offset = NativeReflectionCached.GetPropertyOffset(SetEndFrame_FunctionAddress, "End");
		SetEndFrame_End_IsValid = NativeReflectionCached.ValidatePropertyClass(SetEndFrame_FunctionAddress, "End", Classes.FIntProperty);
		SetEndFrame_IsValid = SetEndFrame_FunctionAddress != IntPtr.Zero && SetEndFrame_Range_IsValid && SetEndFrame_End_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.SequencerScriptingRangeExtensions:SetEndFrame", SetEndFrame_IsValid);
		RemoveStart_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemoveStart");
		RemoveStart_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveStart_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveStart_Range_PropertyAddress, RemoveStart_FunctionAddress, "Range");
		RemoveStart_Range_Offset = NativeReflectionCached.GetPropertyOffset(RemoveStart_FunctionAddress, "Range");
		RemoveStart_Range_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveStart_FunctionAddress, "Range", Classes.FStructProperty);
		RemoveStart_IsValid = RemoveStart_FunctionAddress != IntPtr.Zero && RemoveStart_Range_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.SequencerScriptingRangeExtensions:RemoveStart", RemoveStart_IsValid);
		RemoveEnd_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemoveEnd");
		RemoveEnd_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveEnd_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveEnd_Range_PropertyAddress, RemoveEnd_FunctionAddress, "Range");
		RemoveEnd_Range_Offset = NativeReflectionCached.GetPropertyOffset(RemoveEnd_FunctionAddress, "Range");
		RemoveEnd_Range_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveEnd_FunctionAddress, "Range", Classes.FStructProperty);
		RemoveEnd_IsValid = RemoveEnd_FunctionAddress != IntPtr.Zero && RemoveEnd_Range_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.SequencerScriptingRangeExtensions:RemoveEnd", RemoveEnd_IsValid);
		HasStart_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "HasStart");
		HasStart_ParamsSize = NativeReflection.GetFunctionParamsSize(HasStart_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref HasStart_Range_PropertyAddress, HasStart_FunctionAddress, "Range");
		HasStart_Range_Offset = NativeReflectionCached.GetPropertyOffset(HasStart_FunctionAddress, "Range");
		HasStart_Range_IsValid = NativeReflectionCached.ValidatePropertyClass(HasStart_FunctionAddress, "Range", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref HasStart_ReturnValue_PropertyAddress, HasStart_FunctionAddress, "ReturnValue");
		HasStart_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(HasStart_FunctionAddress, "ReturnValue");
		HasStart_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(HasStart_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		HasStart_IsValid = HasStart_FunctionAddress != IntPtr.Zero && HasStart_Range_IsValid && HasStart_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.SequencerScriptingRangeExtensions:HasStart", HasStart_IsValid);
		HasEnd_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "HasEnd");
		HasEnd_ParamsSize = NativeReflection.GetFunctionParamsSize(HasEnd_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref HasEnd_Range_PropertyAddress, HasEnd_FunctionAddress, "Range");
		HasEnd_Range_Offset = NativeReflectionCached.GetPropertyOffset(HasEnd_FunctionAddress, "Range");
		HasEnd_Range_IsValid = NativeReflectionCached.ValidatePropertyClass(HasEnd_FunctionAddress, "Range", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref HasEnd_ReturnValue_PropertyAddress, HasEnd_FunctionAddress, "ReturnValue");
		HasEnd_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(HasEnd_FunctionAddress, "ReturnValue");
		HasEnd_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(HasEnd_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		HasEnd_IsValid = HasEnd_FunctionAddress != IntPtr.Zero && HasEnd_Range_IsValid && HasEnd_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.SequencerScriptingRangeExtensions:HasEnd", HasEnd_IsValid);
		GetStartSeconds_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetStartSeconds");
		GetStartSeconds_ParamsSize = NativeReflection.GetFunctionParamsSize(GetStartSeconds_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetStartSeconds_Range_PropertyAddress, GetStartSeconds_FunctionAddress, "Range");
		GetStartSeconds_Range_Offset = NativeReflectionCached.GetPropertyOffset(GetStartSeconds_FunctionAddress, "Range");
		GetStartSeconds_Range_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStartSeconds_FunctionAddress, "Range", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetStartSeconds_ReturnValue_PropertyAddress, GetStartSeconds_FunctionAddress, "ReturnValue");
		GetStartSeconds_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetStartSeconds_FunctionAddress, "ReturnValue");
		GetStartSeconds_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStartSeconds_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetStartSeconds_IsValid = GetStartSeconds_FunctionAddress != IntPtr.Zero && GetStartSeconds_Range_IsValid && GetStartSeconds_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.SequencerScriptingRangeExtensions:GetStartSeconds", GetStartSeconds_IsValid);
		GetStartFrame_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetStartFrame");
		GetStartFrame_ParamsSize = NativeReflection.GetFunctionParamsSize(GetStartFrame_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetStartFrame_Range_PropertyAddress, GetStartFrame_FunctionAddress, "Range");
		GetStartFrame_Range_Offset = NativeReflectionCached.GetPropertyOffset(GetStartFrame_FunctionAddress, "Range");
		GetStartFrame_Range_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStartFrame_FunctionAddress, "Range", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetStartFrame_ReturnValue_PropertyAddress, GetStartFrame_FunctionAddress, "ReturnValue");
		GetStartFrame_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetStartFrame_FunctionAddress, "ReturnValue");
		GetStartFrame_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStartFrame_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetStartFrame_IsValid = GetStartFrame_FunctionAddress != IntPtr.Zero && GetStartFrame_Range_IsValid && GetStartFrame_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.SequencerScriptingRangeExtensions:GetStartFrame", GetStartFrame_IsValid);
		GetEndSeconds_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetEndSeconds");
		GetEndSeconds_ParamsSize = NativeReflection.GetFunctionParamsSize(GetEndSeconds_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetEndSeconds_Range_PropertyAddress, GetEndSeconds_FunctionAddress, "Range");
		GetEndSeconds_Range_Offset = NativeReflectionCached.GetPropertyOffset(GetEndSeconds_FunctionAddress, "Range");
		GetEndSeconds_Range_IsValid = NativeReflectionCached.ValidatePropertyClass(GetEndSeconds_FunctionAddress, "Range", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetEndSeconds_ReturnValue_PropertyAddress, GetEndSeconds_FunctionAddress, "ReturnValue");
		GetEndSeconds_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetEndSeconds_FunctionAddress, "ReturnValue");
		GetEndSeconds_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetEndSeconds_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetEndSeconds_IsValid = GetEndSeconds_FunctionAddress != IntPtr.Zero && GetEndSeconds_Range_IsValid && GetEndSeconds_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.SequencerScriptingRangeExtensions:GetEndSeconds", GetEndSeconds_IsValid);
		GetEndFrame_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetEndFrame");
		GetEndFrame_ParamsSize = NativeReflection.GetFunctionParamsSize(GetEndFrame_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetEndFrame_Range_PropertyAddress, GetEndFrame_FunctionAddress, "Range");
		GetEndFrame_Range_Offset = NativeReflectionCached.GetPropertyOffset(GetEndFrame_FunctionAddress, "Range");
		GetEndFrame_Range_IsValid = NativeReflectionCached.ValidatePropertyClass(GetEndFrame_FunctionAddress, "Range", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetEndFrame_ReturnValue_PropertyAddress, GetEndFrame_FunctionAddress, "ReturnValue");
		GetEndFrame_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetEndFrame_FunctionAddress, "ReturnValue");
		GetEndFrame_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetEndFrame_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetEndFrame_IsValid = GetEndFrame_FunctionAddress != IntPtr.Zero && GetEndFrame_Range_IsValid && GetEndFrame_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.SequencerScriptingRangeExtensions:GetEndFrame", GetEndFrame_IsValid);
	}
}
