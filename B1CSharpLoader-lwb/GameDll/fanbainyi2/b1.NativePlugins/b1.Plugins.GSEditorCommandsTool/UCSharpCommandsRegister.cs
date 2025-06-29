using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.GSEditorCommandsTool;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/GSEditorCommandsTool.CSharpCommandsRegister", "GSEditorCommandsTool", UnrealModuleType.GamePlugin)]
public class UCSharpCommandsRegister : UObject
{
	private static IntPtr classAddress;

	private static bool Register_IsValid;

	private static IntPtr Register_FunctionAddress;

	private static int Register_ParamsSize;

	private static bool Register_Name_IsValid;

	private static FFieldAddress Register_Name_PropertyAddress;

	private static int Register_Name_Offset;

	private static bool Register_Description_IsValid;

	private static FFieldAddress Register_Description_PropertyAddress;

	private static int Register_Description_Offset;

	private static bool PostRegisterFinish_IsValid;

	private static IntPtr PostRegisterFinish_FunctionAddress;

	private static int PostRegisterFinish_ParamsSize;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GSEditorCommandsTool.CSharpCommandsRegister:Register")]
	public unsafe static void Register(string Name, string Description)
	{
		if (!Register_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSEditorCommandsTool.CSharpCommandsRegister:Register");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Register_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Register_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, Register_Name_Offset), 0, Register_Name_PropertyAddress.Address, Name);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, Register_Description_Offset), 0, Register_Description_PropertyAddress.Address, Description);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Register_FunctionAddress, intPtr, Register_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Register_Name_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(Register_Description_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GSEditorCommandsTool.CSharpCommandsRegister:PostRegisterFinish")]
	public unsafe static void PostRegisterFinish()
	{
		if (!PostRegisterFinish_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSEditorCommandsTool.CSharpCommandsRegister:PostRegisterFinish");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PostRegisterFinish_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PostRegisterFinish_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: PostRegisterFinish_FunctionAddress, argsSize: PostRegisterFinish_ParamsSize);
	}

	static UCSharpCommandsRegister()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UCSharpCommandsRegister)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UCSharpCommandsRegister));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/GSEditorCommandsTool.CSharpCommandsRegister");
		Register_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Register");
		Register_ParamsSize = NativeReflection.GetFunctionParamsSize(Register_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Register_Name_PropertyAddress, Register_FunctionAddress, "Name");
		Register_Name_Offset = NativeReflectionCached.GetPropertyOffset(Register_FunctionAddress, "Name");
		Register_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(Register_FunctionAddress, "Name", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref Register_Description_PropertyAddress, Register_FunctionAddress, "Description");
		Register_Description_Offset = NativeReflectionCached.GetPropertyOffset(Register_FunctionAddress, "Description");
		Register_Description_IsValid = NativeReflectionCached.ValidatePropertyClass(Register_FunctionAddress, "Description", Classes.FStrProperty);
		Register_IsValid = Register_FunctionAddress != IntPtr.Zero && Register_Name_IsValid && Register_Description_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSEditorCommandsTool.CSharpCommandsRegister:Register", Register_IsValid);
		PostRegisterFinish_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "PostRegisterFinish");
		PostRegisterFinish_ParamsSize = NativeReflection.GetFunctionParamsSize(PostRegisterFinish_FunctionAddress);
		PostRegisterFinish_IsValid = PostRegisterFinish_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/GSEditorCommandsTool.CSharpCommandsRegister:PostRegisterFinish", PostRegisterFinish_IsValid);
	}
}
