using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/b1.BGUFuncLibCSDelegateRegister", "b1", UnrealModuleType.Game)]
public class UBGUFuncLibCSDelegateRegister : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool Register_SetFloatProperty_IsValid;

	private static IntPtr Register_SetFloatProperty_FunctionAddress;

	private static int Register_SetFloatProperty_ParamsSize;

	private static bool Register_SetFloatProperty_FuncPtr_IsValid;

	private static FFieldAddress Register_SetFloatProperty_FuncPtr_PropertyAddress;

	private static int Register_SetFloatProperty_FuncPtr_Offset;

	private static bool Register_SetEnumProperty_IsValid;

	private static IntPtr Register_SetEnumProperty_FunctionAddress;

	private static int Register_SetEnumProperty_ParamsSize;

	private static bool Register_SetEnumProperty_FuncPtr_IsValid;

	private static FFieldAddress Register_SetEnumProperty_FuncPtr_PropertyAddress;

	private static int Register_SetEnumProperty_FuncPtr_Offset;

	private static bool Register_SetCollisionResponseProperty_IsValid;

	private static IntPtr Register_SetCollisionResponseProperty_FunctionAddress;

	private static int Register_SetCollisionResponseProperty_ParamsSize;

	private static bool Register_SetCollisionResponseProperty_FuncPtr_IsValid;

	private static FFieldAddress Register_SetCollisionResponseProperty_FuncPtr_PropertyAddress;

	private static int Register_SetCollisionResponseProperty_FuncPtr_Offset;

	private static bool Register_ResetProperty_IsValid;

	private static IntPtr Register_ResetProperty_FunctionAddress;

	private static int Register_ResetProperty_ParamsSize;

	private static bool Register_ResetProperty_FuncPtr_IsValid;

	private static FFieldAddress Register_ResetProperty_FuncPtr_PropertyAddress;

	private static int Register_ResetProperty_FuncPtr_Offset;

	private static bool Register_BTTaskTick_IsValid;

	private static IntPtr Register_BTTaskTick_FunctionAddress;

	private static int Register_BTTaskTick_ParamsSize;

	private static bool Register_BTTaskTick_FuncPtr_IsValid;

	private static FFieldAddress Register_BTTaskTick_FuncPtr_PropertyAddress;

	private static int Register_BTTaskTick_FuncPtr_Offset;

	private static bool Register_BTTaskExecute_IsValid;

	private static IntPtr Register_BTTaskExecute_FunctionAddress;

	private static int Register_BTTaskExecute_ParamsSize;

	private static bool Register_BTTaskExecute_FuncPtr_IsValid;

	private static FFieldAddress Register_BTTaskExecute_FuncPtr_PropertyAddress;

	private static int Register_BTTaskExecute_FuncPtr_Offset;

	private static bool Register_BTTaskAbort_IsValid;

	private static IntPtr Register_BTTaskAbort_FunctionAddress;

	private static int Register_BTTaskAbort_ParamsSize;

	private static bool Register_BTTaskAbort_FuncPtr_IsValid;

	private static FFieldAddress Register_BTTaskAbort_FuncPtr_PropertyAddress;

	private static int Register_BTTaskAbort_FuncPtr_Offset;

	private static bool Register_BTServiceTick_IsValid;

	private static IntPtr Register_BTServiceTick_FunctionAddress;

	private static int Register_BTServiceTick_ParamsSize;

	private static bool Register_BTServiceTick_FuncPtr_IsValid;

	private static FFieldAddress Register_BTServiceTick_FuncPtr_PropertyAddress;

	private static int Register_BTServiceTick_FuncPtr_Offset;

	private static bool Register_BTServiceSearchStart_IsValid;

	private static IntPtr Register_BTServiceSearchStart_FunctionAddress;

	private static int Register_BTServiceSearchStart_ParamsSize;

	private static bool Register_BTServiceSearchStart_FuncPtr_IsValid;

	private static FFieldAddress Register_BTServiceSearchStart_FuncPtr_PropertyAddress;

	private static int Register_BTServiceSearchStart_FuncPtr_Offset;

	private static bool Register_BTServiceDeactivation_IsValid;

	private static IntPtr Register_BTServiceDeactivation_FunctionAddress;

	private static int Register_BTServiceDeactivation_ParamsSize;

	private static bool Register_BTServiceDeactivation_FuncPtr_IsValid;

	private static FFieldAddress Register_BTServiceDeactivation_FuncPtr_PropertyAddress;

	private static int Register_BTServiceDeactivation_FuncPtr_Offset;

	private static bool Register_BTServiceActivation_IsValid;

	private static IntPtr Register_BTServiceActivation_FunctionAddress;

	private static int Register_BTServiceActivation_ParamsSize;

	private static bool Register_BTServiceActivation_FuncPtr_IsValid;

	private static FFieldAddress Register_BTServiceActivation_FuncPtr_PropertyAddress;

	private static int Register_BTServiceActivation_FuncPtr_Offset;

	private static bool Register_BTDecoratorCheckCondition_IsValid;

	private static IntPtr Register_BTDecoratorCheckCondition_FunctionAddress;

	private static int Register_BTDecoratorCheckCondition_ParamsSize;

	private static bool Register_BTDecoratorCheckCondition_FuncPtr_IsValid;

	private static FFieldAddress Register_BTDecoratorCheckCondition_FuncPtr_PropertyAddress;

	private static int Register_BTDecoratorCheckCondition_FuncPtr_Offset;

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/b1.BGUFuncLibCSDelegateRegister:Register_SetFloatProperty")]
	public unsafe static void Register_SetFloatProperty(FIntPtr FuncPtr)
	{
		if (!Register_SetFloatProperty_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFuncLibCSDelegateRegister:Register_SetFloatProperty");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Register_SetFloatProperty_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Register_SetFloatProperty_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FIntPtr>.ToNative(IntPtr.Add(intPtr, Register_SetFloatProperty_FuncPtr_Offset), 0, Register_SetFloatProperty_FuncPtr_PropertyAddress.Address, FuncPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Register_SetFloatProperty_FunctionAddress, intPtr, Register_SetFloatProperty_ParamsSize);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/b1.BGUFuncLibCSDelegateRegister:Register_SetEnumProperty")]
	public unsafe static void Register_SetEnumProperty(FIntPtr FuncPtr)
	{
		if (!Register_SetEnumProperty_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFuncLibCSDelegateRegister:Register_SetEnumProperty");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Register_SetEnumProperty_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Register_SetEnumProperty_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FIntPtr>.ToNative(IntPtr.Add(intPtr, Register_SetEnumProperty_FuncPtr_Offset), 0, Register_SetEnumProperty_FuncPtr_PropertyAddress.Address, FuncPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Register_SetEnumProperty_FunctionAddress, intPtr, Register_SetEnumProperty_ParamsSize);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/b1.BGUFuncLibCSDelegateRegister:Register_SetCollisionResponseProperty")]
	public unsafe static void Register_SetCollisionResponseProperty(FIntPtr FuncPtr)
	{
		if (!Register_SetCollisionResponseProperty_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFuncLibCSDelegateRegister:Register_SetCollisionResponseProperty");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Register_SetCollisionResponseProperty_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Register_SetCollisionResponseProperty_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FIntPtr>.ToNative(IntPtr.Add(intPtr, Register_SetCollisionResponseProperty_FuncPtr_Offset), 0, Register_SetCollisionResponseProperty_FuncPtr_PropertyAddress.Address, FuncPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Register_SetCollisionResponseProperty_FunctionAddress, intPtr, Register_SetCollisionResponseProperty_ParamsSize);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/b1.BGUFuncLibCSDelegateRegister:Register_ResetProperty")]
	public unsafe static void Register_ResetProperty(FIntPtr FuncPtr)
	{
		if (!Register_ResetProperty_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFuncLibCSDelegateRegister:Register_ResetProperty");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Register_ResetProperty_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Register_ResetProperty_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FIntPtr>.ToNative(IntPtr.Add(intPtr, Register_ResetProperty_FuncPtr_Offset), 0, Register_ResetProperty_FuncPtr_PropertyAddress.Address, FuncPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Register_ResetProperty_FunctionAddress, intPtr, Register_ResetProperty_ParamsSize);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/b1.BGUFuncLibCSDelegateRegister:Register_BTTaskTick")]
	public unsafe static void Register_BTTaskTick(FIntPtr FuncPtr)
	{
		if (!Register_BTTaskTick_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFuncLibCSDelegateRegister:Register_BTTaskTick");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Register_BTTaskTick_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Register_BTTaskTick_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FIntPtr>.ToNative(IntPtr.Add(intPtr, Register_BTTaskTick_FuncPtr_Offset), 0, Register_BTTaskTick_FuncPtr_PropertyAddress.Address, FuncPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Register_BTTaskTick_FunctionAddress, intPtr, Register_BTTaskTick_ParamsSize);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/b1.BGUFuncLibCSDelegateRegister:Register_BTTaskExecute")]
	public unsafe static void Register_BTTaskExecute(FIntPtr FuncPtr)
	{
		if (!Register_BTTaskExecute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFuncLibCSDelegateRegister:Register_BTTaskExecute");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Register_BTTaskExecute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Register_BTTaskExecute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FIntPtr>.ToNative(IntPtr.Add(intPtr, Register_BTTaskExecute_FuncPtr_Offset), 0, Register_BTTaskExecute_FuncPtr_PropertyAddress.Address, FuncPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Register_BTTaskExecute_FunctionAddress, intPtr, Register_BTTaskExecute_ParamsSize);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/b1.BGUFuncLibCSDelegateRegister:Register_BTTaskAbort")]
	public unsafe static void Register_BTTaskAbort(FIntPtr FuncPtr)
	{
		if (!Register_BTTaskAbort_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFuncLibCSDelegateRegister:Register_BTTaskAbort");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Register_BTTaskAbort_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Register_BTTaskAbort_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FIntPtr>.ToNative(IntPtr.Add(intPtr, Register_BTTaskAbort_FuncPtr_Offset), 0, Register_BTTaskAbort_FuncPtr_PropertyAddress.Address, FuncPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Register_BTTaskAbort_FunctionAddress, intPtr, Register_BTTaskAbort_ParamsSize);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/b1.BGUFuncLibCSDelegateRegister:Register_BTServiceTick")]
	public unsafe static void Register_BTServiceTick(FIntPtr FuncPtr)
	{
		if (!Register_BTServiceTick_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFuncLibCSDelegateRegister:Register_BTServiceTick");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Register_BTServiceTick_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Register_BTServiceTick_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FIntPtr>.ToNative(IntPtr.Add(intPtr, Register_BTServiceTick_FuncPtr_Offset), 0, Register_BTServiceTick_FuncPtr_PropertyAddress.Address, FuncPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Register_BTServiceTick_FunctionAddress, intPtr, Register_BTServiceTick_ParamsSize);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/b1.BGUFuncLibCSDelegateRegister:Register_BTServiceSearchStart")]
	public unsafe static void Register_BTServiceSearchStart(FIntPtr FuncPtr)
	{
		if (!Register_BTServiceSearchStart_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFuncLibCSDelegateRegister:Register_BTServiceSearchStart");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Register_BTServiceSearchStart_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Register_BTServiceSearchStart_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FIntPtr>.ToNative(IntPtr.Add(intPtr, Register_BTServiceSearchStart_FuncPtr_Offset), 0, Register_BTServiceSearchStart_FuncPtr_PropertyAddress.Address, FuncPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Register_BTServiceSearchStart_FunctionAddress, intPtr, Register_BTServiceSearchStart_ParamsSize);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/b1.BGUFuncLibCSDelegateRegister:Register_BTServiceDeactivation")]
	public unsafe static void Register_BTServiceDeactivation(FIntPtr FuncPtr)
	{
		if (!Register_BTServiceDeactivation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFuncLibCSDelegateRegister:Register_BTServiceDeactivation");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Register_BTServiceDeactivation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Register_BTServiceDeactivation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FIntPtr>.ToNative(IntPtr.Add(intPtr, Register_BTServiceDeactivation_FuncPtr_Offset), 0, Register_BTServiceDeactivation_FuncPtr_PropertyAddress.Address, FuncPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Register_BTServiceDeactivation_FunctionAddress, intPtr, Register_BTServiceDeactivation_ParamsSize);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/b1.BGUFuncLibCSDelegateRegister:Register_BTServiceActivation")]
	public unsafe static void Register_BTServiceActivation(FIntPtr FuncPtr)
	{
		if (!Register_BTServiceActivation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFuncLibCSDelegateRegister:Register_BTServiceActivation");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Register_BTServiceActivation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Register_BTServiceActivation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FIntPtr>.ToNative(IntPtr.Add(intPtr, Register_BTServiceActivation_FuncPtr_Offset), 0, Register_BTServiceActivation_FuncPtr_PropertyAddress.Address, FuncPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Register_BTServiceActivation_FunctionAddress, intPtr, Register_BTServiceActivation_ParamsSize);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/b1.BGUFuncLibCSDelegateRegister:Register_BTDecoratorCheckCondition")]
	public unsafe static void Register_BTDecoratorCheckCondition(FIntPtr FuncPtr)
	{
		if (!Register_BTDecoratorCheckCondition_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFuncLibCSDelegateRegister:Register_BTDecoratorCheckCondition");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Register_BTDecoratorCheckCondition_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Register_BTDecoratorCheckCondition_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FIntPtr>.ToNative(IntPtr.Add(intPtr, Register_BTDecoratorCheckCondition_FuncPtr_Offset), 0, Register_BTDecoratorCheckCondition_FuncPtr_PropertyAddress.Address, FuncPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Register_BTDecoratorCheckCondition_FunctionAddress, intPtr, Register_BTDecoratorCheckCondition_ParamsSize);
	}

	static UBGUFuncLibCSDelegateRegister()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBGUFuncLibCSDelegateRegister)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBGUFuncLibCSDelegateRegister));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/b1.BGUFuncLibCSDelegateRegister");
		Register_SetFloatProperty_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Register_SetFloatProperty");
		Register_SetFloatProperty_ParamsSize = NativeReflection.GetFunctionParamsSize(Register_SetFloatProperty_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Register_SetFloatProperty_FuncPtr_PropertyAddress, Register_SetFloatProperty_FunctionAddress, "FuncPtr");
		Register_SetFloatProperty_FuncPtr_Offset = NativeReflectionCached.GetPropertyOffset(Register_SetFloatProperty_FunctionAddress, "FuncPtr");
		Register_SetFloatProperty_FuncPtr_IsValid = NativeReflectionCached.ValidatePropertyClass(Register_SetFloatProperty_FunctionAddress, "FuncPtr", Classes.FStructProperty);
		Register_SetFloatProperty_IsValid = Register_SetFloatProperty_FunctionAddress != IntPtr.Zero && Register_SetFloatProperty_FuncPtr_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFuncLibCSDelegateRegister:Register_SetFloatProperty", Register_SetFloatProperty_IsValid);
		Register_SetEnumProperty_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Register_SetEnumProperty");
		Register_SetEnumProperty_ParamsSize = NativeReflection.GetFunctionParamsSize(Register_SetEnumProperty_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Register_SetEnumProperty_FuncPtr_PropertyAddress, Register_SetEnumProperty_FunctionAddress, "FuncPtr");
		Register_SetEnumProperty_FuncPtr_Offset = NativeReflectionCached.GetPropertyOffset(Register_SetEnumProperty_FunctionAddress, "FuncPtr");
		Register_SetEnumProperty_FuncPtr_IsValid = NativeReflectionCached.ValidatePropertyClass(Register_SetEnumProperty_FunctionAddress, "FuncPtr", Classes.FStructProperty);
		Register_SetEnumProperty_IsValid = Register_SetEnumProperty_FunctionAddress != IntPtr.Zero && Register_SetEnumProperty_FuncPtr_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFuncLibCSDelegateRegister:Register_SetEnumProperty", Register_SetEnumProperty_IsValid);
		Register_SetCollisionResponseProperty_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Register_SetCollisionResponseProperty");
		Register_SetCollisionResponseProperty_ParamsSize = NativeReflection.GetFunctionParamsSize(Register_SetCollisionResponseProperty_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Register_SetCollisionResponseProperty_FuncPtr_PropertyAddress, Register_SetCollisionResponseProperty_FunctionAddress, "FuncPtr");
		Register_SetCollisionResponseProperty_FuncPtr_Offset = NativeReflectionCached.GetPropertyOffset(Register_SetCollisionResponseProperty_FunctionAddress, "FuncPtr");
		Register_SetCollisionResponseProperty_FuncPtr_IsValid = NativeReflectionCached.ValidatePropertyClass(Register_SetCollisionResponseProperty_FunctionAddress, "FuncPtr", Classes.FStructProperty);
		Register_SetCollisionResponseProperty_IsValid = Register_SetCollisionResponseProperty_FunctionAddress != IntPtr.Zero && Register_SetCollisionResponseProperty_FuncPtr_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFuncLibCSDelegateRegister:Register_SetCollisionResponseProperty", Register_SetCollisionResponseProperty_IsValid);
		Register_ResetProperty_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Register_ResetProperty");
		Register_ResetProperty_ParamsSize = NativeReflection.GetFunctionParamsSize(Register_ResetProperty_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Register_ResetProperty_FuncPtr_PropertyAddress, Register_ResetProperty_FunctionAddress, "FuncPtr");
		Register_ResetProperty_FuncPtr_Offset = NativeReflectionCached.GetPropertyOffset(Register_ResetProperty_FunctionAddress, "FuncPtr");
		Register_ResetProperty_FuncPtr_IsValid = NativeReflectionCached.ValidatePropertyClass(Register_ResetProperty_FunctionAddress, "FuncPtr", Classes.FStructProperty);
		Register_ResetProperty_IsValid = Register_ResetProperty_FunctionAddress != IntPtr.Zero && Register_ResetProperty_FuncPtr_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFuncLibCSDelegateRegister:Register_ResetProperty", Register_ResetProperty_IsValid);
		Register_BTTaskTick_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Register_BTTaskTick");
		Register_BTTaskTick_ParamsSize = NativeReflection.GetFunctionParamsSize(Register_BTTaskTick_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Register_BTTaskTick_FuncPtr_PropertyAddress, Register_BTTaskTick_FunctionAddress, "FuncPtr");
		Register_BTTaskTick_FuncPtr_Offset = NativeReflectionCached.GetPropertyOffset(Register_BTTaskTick_FunctionAddress, "FuncPtr");
		Register_BTTaskTick_FuncPtr_IsValid = NativeReflectionCached.ValidatePropertyClass(Register_BTTaskTick_FunctionAddress, "FuncPtr", Classes.FStructProperty);
		Register_BTTaskTick_IsValid = Register_BTTaskTick_FunctionAddress != IntPtr.Zero && Register_BTTaskTick_FuncPtr_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFuncLibCSDelegateRegister:Register_BTTaskTick", Register_BTTaskTick_IsValid);
		Register_BTTaskExecute_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Register_BTTaskExecute");
		Register_BTTaskExecute_ParamsSize = NativeReflection.GetFunctionParamsSize(Register_BTTaskExecute_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Register_BTTaskExecute_FuncPtr_PropertyAddress, Register_BTTaskExecute_FunctionAddress, "FuncPtr");
		Register_BTTaskExecute_FuncPtr_Offset = NativeReflectionCached.GetPropertyOffset(Register_BTTaskExecute_FunctionAddress, "FuncPtr");
		Register_BTTaskExecute_FuncPtr_IsValid = NativeReflectionCached.ValidatePropertyClass(Register_BTTaskExecute_FunctionAddress, "FuncPtr", Classes.FStructProperty);
		Register_BTTaskExecute_IsValid = Register_BTTaskExecute_FunctionAddress != IntPtr.Zero && Register_BTTaskExecute_FuncPtr_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFuncLibCSDelegateRegister:Register_BTTaskExecute", Register_BTTaskExecute_IsValid);
		Register_BTTaskAbort_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Register_BTTaskAbort");
		Register_BTTaskAbort_ParamsSize = NativeReflection.GetFunctionParamsSize(Register_BTTaskAbort_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Register_BTTaskAbort_FuncPtr_PropertyAddress, Register_BTTaskAbort_FunctionAddress, "FuncPtr");
		Register_BTTaskAbort_FuncPtr_Offset = NativeReflectionCached.GetPropertyOffset(Register_BTTaskAbort_FunctionAddress, "FuncPtr");
		Register_BTTaskAbort_FuncPtr_IsValid = NativeReflectionCached.ValidatePropertyClass(Register_BTTaskAbort_FunctionAddress, "FuncPtr", Classes.FStructProperty);
		Register_BTTaskAbort_IsValid = Register_BTTaskAbort_FunctionAddress != IntPtr.Zero && Register_BTTaskAbort_FuncPtr_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFuncLibCSDelegateRegister:Register_BTTaskAbort", Register_BTTaskAbort_IsValid);
		Register_BTServiceTick_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Register_BTServiceTick");
		Register_BTServiceTick_ParamsSize = NativeReflection.GetFunctionParamsSize(Register_BTServiceTick_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Register_BTServiceTick_FuncPtr_PropertyAddress, Register_BTServiceTick_FunctionAddress, "FuncPtr");
		Register_BTServiceTick_FuncPtr_Offset = NativeReflectionCached.GetPropertyOffset(Register_BTServiceTick_FunctionAddress, "FuncPtr");
		Register_BTServiceTick_FuncPtr_IsValid = NativeReflectionCached.ValidatePropertyClass(Register_BTServiceTick_FunctionAddress, "FuncPtr", Classes.FStructProperty);
		Register_BTServiceTick_IsValid = Register_BTServiceTick_FunctionAddress != IntPtr.Zero && Register_BTServiceTick_FuncPtr_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFuncLibCSDelegateRegister:Register_BTServiceTick", Register_BTServiceTick_IsValid);
		Register_BTServiceSearchStart_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Register_BTServiceSearchStart");
		Register_BTServiceSearchStart_ParamsSize = NativeReflection.GetFunctionParamsSize(Register_BTServiceSearchStart_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Register_BTServiceSearchStart_FuncPtr_PropertyAddress, Register_BTServiceSearchStart_FunctionAddress, "FuncPtr");
		Register_BTServiceSearchStart_FuncPtr_Offset = NativeReflectionCached.GetPropertyOffset(Register_BTServiceSearchStart_FunctionAddress, "FuncPtr");
		Register_BTServiceSearchStart_FuncPtr_IsValid = NativeReflectionCached.ValidatePropertyClass(Register_BTServiceSearchStart_FunctionAddress, "FuncPtr", Classes.FStructProperty);
		Register_BTServiceSearchStart_IsValid = Register_BTServiceSearchStart_FunctionAddress != IntPtr.Zero && Register_BTServiceSearchStart_FuncPtr_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFuncLibCSDelegateRegister:Register_BTServiceSearchStart", Register_BTServiceSearchStart_IsValid);
		Register_BTServiceDeactivation_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Register_BTServiceDeactivation");
		Register_BTServiceDeactivation_ParamsSize = NativeReflection.GetFunctionParamsSize(Register_BTServiceDeactivation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Register_BTServiceDeactivation_FuncPtr_PropertyAddress, Register_BTServiceDeactivation_FunctionAddress, "FuncPtr");
		Register_BTServiceDeactivation_FuncPtr_Offset = NativeReflectionCached.GetPropertyOffset(Register_BTServiceDeactivation_FunctionAddress, "FuncPtr");
		Register_BTServiceDeactivation_FuncPtr_IsValid = NativeReflectionCached.ValidatePropertyClass(Register_BTServiceDeactivation_FunctionAddress, "FuncPtr", Classes.FStructProperty);
		Register_BTServiceDeactivation_IsValid = Register_BTServiceDeactivation_FunctionAddress != IntPtr.Zero && Register_BTServiceDeactivation_FuncPtr_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFuncLibCSDelegateRegister:Register_BTServiceDeactivation", Register_BTServiceDeactivation_IsValid);
		Register_BTServiceActivation_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Register_BTServiceActivation");
		Register_BTServiceActivation_ParamsSize = NativeReflection.GetFunctionParamsSize(Register_BTServiceActivation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Register_BTServiceActivation_FuncPtr_PropertyAddress, Register_BTServiceActivation_FunctionAddress, "FuncPtr");
		Register_BTServiceActivation_FuncPtr_Offset = NativeReflectionCached.GetPropertyOffset(Register_BTServiceActivation_FunctionAddress, "FuncPtr");
		Register_BTServiceActivation_FuncPtr_IsValid = NativeReflectionCached.ValidatePropertyClass(Register_BTServiceActivation_FunctionAddress, "FuncPtr", Classes.FStructProperty);
		Register_BTServiceActivation_IsValid = Register_BTServiceActivation_FunctionAddress != IntPtr.Zero && Register_BTServiceActivation_FuncPtr_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFuncLibCSDelegateRegister:Register_BTServiceActivation", Register_BTServiceActivation_IsValid);
		Register_BTDecoratorCheckCondition_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Register_BTDecoratorCheckCondition");
		Register_BTDecoratorCheckCondition_ParamsSize = NativeReflection.GetFunctionParamsSize(Register_BTDecoratorCheckCondition_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Register_BTDecoratorCheckCondition_FuncPtr_PropertyAddress, Register_BTDecoratorCheckCondition_FunctionAddress, "FuncPtr");
		Register_BTDecoratorCheckCondition_FuncPtr_Offset = NativeReflectionCached.GetPropertyOffset(Register_BTDecoratorCheckCondition_FunctionAddress, "FuncPtr");
		Register_BTDecoratorCheckCondition_FuncPtr_IsValid = NativeReflectionCached.ValidatePropertyClass(Register_BTDecoratorCheckCondition_FunctionAddress, "FuncPtr", Classes.FStructProperty);
		Register_BTDecoratorCheckCondition_IsValid = Register_BTDecoratorCheckCondition_FunctionAddress != IntPtr.Zero && Register_BTDecoratorCheckCondition_FuncPtr_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFuncLibCSDelegateRegister:Register_BTDecoratorCheckCondition", Register_BTDecoratorCheckCondition_IsValid);
	}
}
