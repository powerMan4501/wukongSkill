using System;
using System.Runtime.CompilerServices;
using UnrealEngine.RigVM;
using UnrealEngine.Runtime;

namespace UnrealEngine.RigVMDeveloper;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/RigVMDeveloper.RigVMCompiler", "RigVMDeveloper", UnrealModuleType.Engine)]
public class URigVMCompiler : UObject
{
	private static bool Settings_IsValid;

	private static int Settings_Offset;

	private static bool Compile_IsValid;

	private static IntPtr Compile_FunctionAddress;

	private static int Compile_ParamsSize;

	private static bool Compile_InGraph_IsValid;

	private static FFieldAddress Compile_InGraph_PropertyAddress;

	private static int Compile_InGraph_Offset;

	private static bool Compile_InController_IsValid;

	private static FFieldAddress Compile_InController_PropertyAddress;

	private static int Compile_InController_Offset;

	private static bool Compile_OutVM_IsValid;

	private static FFieldAddress Compile_OutVM_PropertyAddress;

	private static int Compile_OutVM_Offset;

	private static bool Compile_ReturnValue_IsValid;

	private static FFieldAddress Compile_ReturnValue_PropertyAddress;

	private static int Compile_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)4503599627370500uL)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMCompiler:Settings")]
	public FRigVMCompileSettings Settings
	{
		get
		{
			CheckDestroyed();
			if (!Settings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/RigVMDeveloper.RigVMCompiler:Settings");
				return default(FRigVMCompileSettings);
			}
			return FRigVMCompileSettings.FromNative(IntPtr.Add(base.Address, Settings_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Settings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/RigVMDeveloper.RigVMCompiler:Settings");
			}
			else
			{
				FRigVMCompileSettings.ToNative(IntPtr.Add(base.Address, Settings_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMCompiler:Compile")]
	public unsafe bool Compile(URigVMGraph InGraph, URigVMController InController, URigVM OutVM)
	{
		CheckDestroyed();
		if (!Compile_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMCompiler:Compile");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Compile_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Compile_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<URigVMGraph>.ToNative(IntPtr.Add(intPtr, Compile_InGraph_Offset), 0, Compile_InGraph_PropertyAddress.Address, InGraph);
		UObjectMarshaler<URigVMController>.ToNative(IntPtr.Add(intPtr, Compile_InController_Offset), 0, Compile_InController_PropertyAddress.Address, InController);
		UObjectMarshaler<URigVM>.ToNative(IntPtr.Add(intPtr, Compile_OutVM_Offset), 0, Compile_OutVM_PropertyAddress.Address, OutVM);
		NativeReflection.InvokeFunctionOptimized(base.Address, Compile_FunctionAddress, intPtr, Compile_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, Compile_ReturnValue_Offset), 0, Compile_ReturnValue_PropertyAddress.Address);
	}

	static URigVMCompiler()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(URigVMCompiler)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(URigVMCompiler));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/RigVMDeveloper.RigVMCompiler");
		Settings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Settings");
		Settings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Settings", Classes.FStructProperty);
		Compile_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Compile");
		Compile_ParamsSize = NativeReflection.GetFunctionParamsSize(Compile_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Compile_InGraph_PropertyAddress, Compile_FunctionAddress, "InGraph");
		Compile_InGraph_Offset = NativeReflectionCached.GetPropertyOffset(Compile_FunctionAddress, "InGraph");
		Compile_InGraph_IsValid = NativeReflectionCached.ValidatePropertyClass(Compile_FunctionAddress, "InGraph", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref Compile_InController_PropertyAddress, Compile_FunctionAddress, "InController");
		Compile_InController_Offset = NativeReflectionCached.GetPropertyOffset(Compile_FunctionAddress, "InController");
		Compile_InController_IsValid = NativeReflectionCached.ValidatePropertyClass(Compile_FunctionAddress, "InController", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref Compile_OutVM_PropertyAddress, Compile_FunctionAddress, "OutVM");
		Compile_OutVM_Offset = NativeReflectionCached.GetPropertyOffset(Compile_FunctionAddress, "OutVM");
		Compile_OutVM_IsValid = NativeReflectionCached.ValidatePropertyClass(Compile_FunctionAddress, "OutVM", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref Compile_ReturnValue_PropertyAddress, Compile_FunctionAddress, "ReturnValue");
		Compile_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Compile_FunctionAddress, "ReturnValue");
		Compile_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Compile_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		Compile_IsValid = Compile_FunctionAddress != IntPtr.Zero && Compile_InGraph_IsValid && Compile_InController_IsValid && Compile_OutVM_IsValid && Compile_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMCompiler:Compile", Compile_IsValid);
	}
}
