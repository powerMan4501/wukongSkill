using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/Engine.KismetGuidLibrary", "Engine", UnrealModuleType.Engine)]
public class UGuidLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool Parse_StringToGuid_IsValid;

	private static IntPtr Parse_StringToGuid_FunctionAddress;

	private static int Parse_StringToGuid_ParamsSize;

	private static bool Parse_StringToGuid_GuidString_IsValid;

	private static FFieldAddress Parse_StringToGuid_GuidString_PropertyAddress;

	private static int Parse_StringToGuid_GuidString_Offset;

	private static bool Parse_StringToGuid_OutGuid_IsValid;

	private static FFieldAddress Parse_StringToGuid_OutGuid_PropertyAddress;

	private static int Parse_StringToGuid_OutGuid_Offset;

	private static bool Parse_StringToGuid_Success_IsValid;

	private static FFieldAddress Parse_StringToGuid_Success_PropertyAddress;

	private static int Parse_StringToGuid_Success_Offset;

	private static bool NotEqual_GuidGuid_IsValid;

	private static IntPtr NotEqual_GuidGuid_FunctionAddress;

	private static int NotEqual_GuidGuid_ParamsSize;

	private static bool NotEqual_GuidGuid_A_IsValid;

	private static FFieldAddress NotEqual_GuidGuid_A_PropertyAddress;

	private static int NotEqual_GuidGuid_A_Offset;

	private static bool NotEqual_GuidGuid_B_IsValid;

	private static FFieldAddress NotEqual_GuidGuid_B_PropertyAddress;

	private static int NotEqual_GuidGuid_B_Offset;

	private static bool NotEqual_GuidGuid_ReturnValue_IsValid;

	private static FFieldAddress NotEqual_GuidGuid_ReturnValue_PropertyAddress;

	private static int NotEqual_GuidGuid_ReturnValue_Offset;

	private static bool NewGuid_IsValid;

	private static IntPtr NewGuid_FunctionAddress;

	private static int NewGuid_ParamsSize;

	private static bool NewGuid_ReturnValue_IsValid;

	private static FFieldAddress NewGuid_ReturnValue_PropertyAddress;

	private static int NewGuid_ReturnValue_Offset;

	private static bool IsValid_Guid_IsValid;

	private static IntPtr IsValid_Guid_FunctionAddress;

	private static int IsValid_Guid_ParamsSize;

	private static bool IsValid_Guid_InGuid_IsValid;

	private static FFieldAddress IsValid_Guid_InGuid_PropertyAddress;

	private static int IsValid_Guid_InGuid_Offset;

	private static bool IsValid_Guid_ReturnValue_IsValid;

	private static FFieldAddress IsValid_Guid_ReturnValue_PropertyAddress;

	private static int IsValid_Guid_ReturnValue_Offset;

	private static bool Invalidate_Guid_IsValid;

	private static IntPtr Invalidate_Guid_FunctionAddress;

	private static int Invalidate_Guid_ParamsSize;

	private static bool Invalidate_Guid_InGuid_IsValid;

	private static FFieldAddress Invalidate_Guid_InGuid_PropertyAddress;

	private static int Invalidate_Guid_InGuid_Offset;

	private static bool EqualEqual_GuidGuid_IsValid;

	private static IntPtr EqualEqual_GuidGuid_FunctionAddress;

	private static int EqualEqual_GuidGuid_ParamsSize;

	private static bool EqualEqual_GuidGuid_A_IsValid;

	private static FFieldAddress EqualEqual_GuidGuid_A_PropertyAddress;

	private static int EqualEqual_GuidGuid_A_Offset;

	private static bool EqualEqual_GuidGuid_B_IsValid;

	private static FFieldAddress EqualEqual_GuidGuid_B_PropertyAddress;

	private static int EqualEqual_GuidGuid_B_Offset;

	private static bool EqualEqual_GuidGuid_ReturnValue_IsValid;

	private static FFieldAddress EqualEqual_GuidGuid_ReturnValue_PropertyAddress;

	private static int EqualEqual_GuidGuid_ReturnValue_Offset;

	private static bool Conv_GuidToString_IsValid;

	private static IntPtr Conv_GuidToString_FunctionAddress;

	private static int Conv_GuidToString_ParamsSize;

	private static bool Conv_GuidToString_InGuid_IsValid;

	private static FFieldAddress Conv_GuidToString_InGuid_PropertyAddress;

	private static int Conv_GuidToString_InGuid_Offset;

	private static bool Conv_GuidToString_ReturnValue_IsValid;

	private static FFieldAddress Conv_GuidToString_ReturnValue_PropertyAddress;

	private static int Conv_GuidToString_ReturnValue_Offset;

	[UFunction(Flags = 348267521u)]
	[UMetaPath("/Script/Engine.KismetGuidLibrary:Parse_StringToGuid")]
	public unsafe static void Parse_StringToGuid(string GuidString, out Guid OutGuid, out bool Success)
	{
		if (!Parse_StringToGuid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetGuidLibrary:Parse_StringToGuid");
			OutGuid = default(Guid);
			Success = false;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Parse_StringToGuid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Parse_StringToGuid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, Parse_StringToGuid_GuidString_Offset), 0, Parse_StringToGuid_GuidString_PropertyAddress.Address, GuidString);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Parse_StringToGuid_FunctionAddress, intPtr, Parse_StringToGuid_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Parse_StringToGuid_GuidString_PropertyAddress.Address, intPtr);
		OutGuid = BlittableTypeMarshaler<Guid>.FromNative(IntPtr.Add(intPtr, Parse_StringToGuid_OutGuid_Offset), 0, Parse_StringToGuid_OutGuid_PropertyAddress.Address);
		Success = BoolMarshaler.FromNative(IntPtr.Add(intPtr, Parse_StringToGuid_Success_Offset), 0, Parse_StringToGuid_Success_PropertyAddress.Address);
	}

	[UFunction(Flags = 348267521u)]
	[UMetaPath("/Script/Engine.KismetGuidLibrary:NotEqual_GuidGuid")]
	public unsafe static bool NotEqual_GuidGuid(Guid A, Guid B)
	{
		if (!NotEqual_GuidGuid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetGuidLibrary:NotEqual_GuidGuid");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(NotEqual_GuidGuid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)NotEqual_GuidGuid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<Guid>.ToNative(IntPtr.Add(intPtr, NotEqual_GuidGuid_A_Offset), 0, NotEqual_GuidGuid_A_PropertyAddress.Address, A);
		BlittableTypeMarshaler<Guid>.ToNative(IntPtr.Add(intPtr, NotEqual_GuidGuid_B_Offset), 0, NotEqual_GuidGuid_B_PropertyAddress.Address, B);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, NotEqual_GuidGuid_FunctionAddress, intPtr, NotEqual_GuidGuid_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, NotEqual_GuidGuid_ReturnValue_Offset), 0, NotEqual_GuidGuid_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 344073217u)]
	[UMetaPath("/Script/Engine.KismetGuidLibrary:NewGuid")]
	public unsafe static Guid NewGuid()
	{
		if (!NewGuid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetGuidLibrary:NewGuid");
			return default(Guid);
		}
		byte* ptr = stackalloc byte[(int)(uint)(NewGuid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)NewGuid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, NewGuid_FunctionAddress, intPtr, NewGuid_ParamsSize);
		return BlittableTypeMarshaler<Guid>.FromNative(IntPtr.Add(intPtr, NewGuid_ReturnValue_Offset), 0, NewGuid_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 348267521u)]
	[UMetaPath("/Script/Engine.KismetGuidLibrary:IsValid_Guid")]
	public unsafe static bool IsValid_Guid(Guid InGuid)
	{
		if (!IsValid_Guid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetGuidLibrary:IsValid_Guid");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsValid_Guid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsValid_Guid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<Guid>.ToNative(IntPtr.Add(intPtr, IsValid_Guid_InGuid_Offset), 0, IsValid_Guid_InGuid_PropertyAddress.Address, InGuid);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsValid_Guid_FunctionAddress, intPtr, IsValid_Guid_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsValid_Guid_ReturnValue_Offset), 0, IsValid_Guid_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/Engine.KismetGuidLibrary:Invalidate_Guid")]
	public unsafe static void Invalidate_Guid(ref Guid InGuid)
	{
		if (!Invalidate_Guid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetGuidLibrary:Invalidate_Guid");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Invalidate_Guid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Invalidate_Guid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<Guid>.ToNative(IntPtr.Add(intPtr, Invalidate_Guid_InGuid_Offset), 0, Invalidate_Guid_InGuid_PropertyAddress.Address, InGuid);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Invalidate_Guid_FunctionAddress, intPtr, Invalidate_Guid_ParamsSize);
		InGuid = BlittableTypeMarshaler<Guid>.FromNative(IntPtr.Add(intPtr, Invalidate_Guid_InGuid_Offset), 0, Invalidate_Guid_InGuid_PropertyAddress.Address);
	}

	[UFunction(Flags = 348267521u)]
	[UMetaPath("/Script/Engine.KismetGuidLibrary:EqualEqual_GuidGuid")]
	public unsafe static bool EqualEqual_GuidGuid(Guid A, Guid B)
	{
		if (!EqualEqual_GuidGuid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetGuidLibrary:EqualEqual_GuidGuid");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EqualEqual_GuidGuid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EqualEqual_GuidGuid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<Guid>.ToNative(IntPtr.Add(intPtr, EqualEqual_GuidGuid_A_Offset), 0, EqualEqual_GuidGuid_A_PropertyAddress.Address, A);
		BlittableTypeMarshaler<Guid>.ToNative(IntPtr.Add(intPtr, EqualEqual_GuidGuid_B_Offset), 0, EqualEqual_GuidGuid_B_PropertyAddress.Address, B);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, EqualEqual_GuidGuid_FunctionAddress, intPtr, EqualEqual_GuidGuid_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, EqualEqual_GuidGuid_ReturnValue_Offset), 0, EqualEqual_GuidGuid_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 348267521u)]
	[UMetaPath("/Script/Engine.KismetGuidLibrary:Conv_GuidToString")]
	public unsafe static string Conv_GuidToString(Guid InGuid)
	{
		if (!Conv_GuidToString_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetGuidLibrary:Conv_GuidToString");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Conv_GuidToString_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Conv_GuidToString_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<Guid>.ToNative(IntPtr.Add(intPtr, Conv_GuidToString_InGuid_Offset), 0, Conv_GuidToString_InGuid_PropertyAddress.Address, InGuid);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Conv_GuidToString_FunctionAddress, intPtr, Conv_GuidToString_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, Conv_GuidToString_ReturnValue_Offset), 0, Conv_GuidToString_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(Conv_GuidToString_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	static UGuidLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGuidLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGuidLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/Engine.KismetGuidLibrary");
		Parse_StringToGuid_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Parse_StringToGuid");
		Parse_StringToGuid_ParamsSize = NativeReflection.GetFunctionParamsSize(Parse_StringToGuid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Parse_StringToGuid_GuidString_PropertyAddress, Parse_StringToGuid_FunctionAddress, "GuidString");
		Parse_StringToGuid_GuidString_Offset = NativeReflectionCached.GetPropertyOffset(Parse_StringToGuid_FunctionAddress, "GuidString");
		Parse_StringToGuid_GuidString_IsValid = NativeReflectionCached.ValidatePropertyClass(Parse_StringToGuid_FunctionAddress, "GuidString", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref Parse_StringToGuid_OutGuid_PropertyAddress, Parse_StringToGuid_FunctionAddress, "OutGuid");
		Parse_StringToGuid_OutGuid_Offset = NativeReflectionCached.GetPropertyOffset(Parse_StringToGuid_FunctionAddress, "OutGuid");
		Parse_StringToGuid_OutGuid_IsValid = NativeReflectionCached.ValidatePropertyClass(Parse_StringToGuid_FunctionAddress, "OutGuid", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Parse_StringToGuid_Success_PropertyAddress, Parse_StringToGuid_FunctionAddress, "Success");
		Parse_StringToGuid_Success_Offset = NativeReflectionCached.GetPropertyOffset(Parse_StringToGuid_FunctionAddress, "Success");
		Parse_StringToGuid_Success_IsValid = NativeReflectionCached.ValidatePropertyClass(Parse_StringToGuid_FunctionAddress, "Success", Classes.FBoolProperty);
		Parse_StringToGuid_IsValid = Parse_StringToGuid_FunctionAddress != IntPtr.Zero && Parse_StringToGuid_GuidString_IsValid && Parse_StringToGuid_OutGuid_IsValid && Parse_StringToGuid_Success_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetGuidLibrary:Parse_StringToGuid", Parse_StringToGuid_IsValid);
		NotEqual_GuidGuid_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "NotEqual_GuidGuid");
		NotEqual_GuidGuid_ParamsSize = NativeReflection.GetFunctionParamsSize(NotEqual_GuidGuid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref NotEqual_GuidGuid_A_PropertyAddress, NotEqual_GuidGuid_FunctionAddress, "A");
		NotEqual_GuidGuid_A_Offset = NativeReflectionCached.GetPropertyOffset(NotEqual_GuidGuid_FunctionAddress, "A");
		NotEqual_GuidGuid_A_IsValid = NativeReflectionCached.ValidatePropertyClass(NotEqual_GuidGuid_FunctionAddress, "A", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref NotEqual_GuidGuid_B_PropertyAddress, NotEqual_GuidGuid_FunctionAddress, "B");
		NotEqual_GuidGuid_B_Offset = NativeReflectionCached.GetPropertyOffset(NotEqual_GuidGuid_FunctionAddress, "B");
		NotEqual_GuidGuid_B_IsValid = NativeReflectionCached.ValidatePropertyClass(NotEqual_GuidGuid_FunctionAddress, "B", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref NotEqual_GuidGuid_ReturnValue_PropertyAddress, NotEqual_GuidGuid_FunctionAddress, "ReturnValue");
		NotEqual_GuidGuid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(NotEqual_GuidGuid_FunctionAddress, "ReturnValue");
		NotEqual_GuidGuid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(NotEqual_GuidGuid_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		NotEqual_GuidGuid_IsValid = NotEqual_GuidGuid_FunctionAddress != IntPtr.Zero && NotEqual_GuidGuid_A_IsValid && NotEqual_GuidGuid_B_IsValid && NotEqual_GuidGuid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetGuidLibrary:NotEqual_GuidGuid", NotEqual_GuidGuid_IsValid);
		NewGuid_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "NewGuid");
		NewGuid_ParamsSize = NativeReflection.GetFunctionParamsSize(NewGuid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref NewGuid_ReturnValue_PropertyAddress, NewGuid_FunctionAddress, "ReturnValue");
		NewGuid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(NewGuid_FunctionAddress, "ReturnValue");
		NewGuid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(NewGuid_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		NewGuid_IsValid = NewGuid_FunctionAddress != IntPtr.Zero && NewGuid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetGuidLibrary:NewGuid", NewGuid_IsValid);
		IsValid_Guid_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsValid_Guid");
		IsValid_Guid_ParamsSize = NativeReflection.GetFunctionParamsSize(IsValid_Guid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsValid_Guid_InGuid_PropertyAddress, IsValid_Guid_FunctionAddress, "InGuid");
		IsValid_Guid_InGuid_Offset = NativeReflectionCached.GetPropertyOffset(IsValid_Guid_FunctionAddress, "InGuid");
		IsValid_Guid_InGuid_IsValid = NativeReflectionCached.ValidatePropertyClass(IsValid_Guid_FunctionAddress, "InGuid", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsValid_Guid_ReturnValue_PropertyAddress, IsValid_Guid_FunctionAddress, "ReturnValue");
		IsValid_Guid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsValid_Guid_FunctionAddress, "ReturnValue");
		IsValid_Guid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsValid_Guid_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsValid_Guid_IsValid = IsValid_Guid_FunctionAddress != IntPtr.Zero && IsValid_Guid_InGuid_IsValid && IsValid_Guid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetGuidLibrary:IsValid_Guid", IsValid_Guid_IsValid);
		Invalidate_Guid_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Invalidate_Guid");
		Invalidate_Guid_ParamsSize = NativeReflection.GetFunctionParamsSize(Invalidate_Guid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Invalidate_Guid_InGuid_PropertyAddress, Invalidate_Guid_FunctionAddress, "InGuid");
		Invalidate_Guid_InGuid_Offset = NativeReflectionCached.GetPropertyOffset(Invalidate_Guid_FunctionAddress, "InGuid");
		Invalidate_Guid_InGuid_IsValid = NativeReflectionCached.ValidatePropertyClass(Invalidate_Guid_FunctionAddress, "InGuid", Classes.FStructProperty);
		Invalidate_Guid_IsValid = Invalidate_Guid_FunctionAddress != IntPtr.Zero && Invalidate_Guid_InGuid_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetGuidLibrary:Invalidate_Guid", Invalidate_Guid_IsValid);
		EqualEqual_GuidGuid_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "EqualEqual_GuidGuid");
		EqualEqual_GuidGuid_ParamsSize = NativeReflection.GetFunctionParamsSize(EqualEqual_GuidGuid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref EqualEqual_GuidGuid_A_PropertyAddress, EqualEqual_GuidGuid_FunctionAddress, "A");
		EqualEqual_GuidGuid_A_Offset = NativeReflectionCached.GetPropertyOffset(EqualEqual_GuidGuid_FunctionAddress, "A");
		EqualEqual_GuidGuid_A_IsValid = NativeReflectionCached.ValidatePropertyClass(EqualEqual_GuidGuid_FunctionAddress, "A", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref EqualEqual_GuidGuid_B_PropertyAddress, EqualEqual_GuidGuid_FunctionAddress, "B");
		EqualEqual_GuidGuid_B_Offset = NativeReflectionCached.GetPropertyOffset(EqualEqual_GuidGuid_FunctionAddress, "B");
		EqualEqual_GuidGuid_B_IsValid = NativeReflectionCached.ValidatePropertyClass(EqualEqual_GuidGuid_FunctionAddress, "B", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref EqualEqual_GuidGuid_ReturnValue_PropertyAddress, EqualEqual_GuidGuid_FunctionAddress, "ReturnValue");
		EqualEqual_GuidGuid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(EqualEqual_GuidGuid_FunctionAddress, "ReturnValue");
		EqualEqual_GuidGuid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(EqualEqual_GuidGuid_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		EqualEqual_GuidGuid_IsValid = EqualEqual_GuidGuid_FunctionAddress != IntPtr.Zero && EqualEqual_GuidGuid_A_IsValid && EqualEqual_GuidGuid_B_IsValid && EqualEqual_GuidGuid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetGuidLibrary:EqualEqual_GuidGuid", EqualEqual_GuidGuid_IsValid);
		Conv_GuidToString_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Conv_GuidToString");
		Conv_GuidToString_ParamsSize = NativeReflection.GetFunctionParamsSize(Conv_GuidToString_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Conv_GuidToString_InGuid_PropertyAddress, Conv_GuidToString_FunctionAddress, "InGuid");
		Conv_GuidToString_InGuid_Offset = NativeReflectionCached.GetPropertyOffset(Conv_GuidToString_FunctionAddress, "InGuid");
		Conv_GuidToString_InGuid_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_GuidToString_FunctionAddress, "InGuid", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Conv_GuidToString_ReturnValue_PropertyAddress, Conv_GuidToString_FunctionAddress, "ReturnValue");
		Conv_GuidToString_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Conv_GuidToString_FunctionAddress, "ReturnValue");
		Conv_GuidToString_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_GuidToString_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		Conv_GuidToString_IsValid = Conv_GuidToString_FunctionAddress != IntPtr.Zero && Conv_GuidToString_InGuid_IsValid && Conv_GuidToString_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetGuidLibrary:Conv_GuidToString", Conv_GuidToString_IsValid);
	}
}
