using System;
using UnrealEngine.Runtime;

namespace HelloUSharp;

[UDelegate]
[USharpPath("/Script/b1-Managed.HelloUSharpDelegate__DelegateSignature")]
public class HelloUSharpDelegate : FMulticastDelegate<HelloUSharpDelegate.Signature>
{
	public delegate void Signature(byte param1, string param2, int param3);

	private static bool Invoke_IsValid;

	private static IntPtr Invoke_FunctionAddress;

	private static int Invoke_ParamsSize;

	private static bool Invoke_param1_IsValid;

	private static int Invoke_param1_Offset;

	private static bool Invoke_param2_IsValid;

	private static int Invoke_param2_Offset;

	private static FFieldAddress Invoke_param2_PropertyAddress;

	private static bool Invoke_param3_IsValid;

	private static int Invoke_param3_Offset;

	private unsafe void Invoker(byte param1, string param2, int param3)
	{
		if (!Invoke_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.HelloUSharpDelegate__DelegateSignature:Invoke");
		}
		else if (IsBound)
		{
			byte* value = stackalloc byte[(int)(uint)Invoke_ParamsSize];
			IntPtr intPtr = new IntPtr(value);
			FMemory.Memzero(intPtr, Invoke_ParamsSize);
			BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(intPtr, Invoke_param1_Offset), param1);
			FStringMarshaler.ToNative(IntPtr.Add(intPtr, Invoke_param2_Offset), param2);
			BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, Invoke_param3_Offset), param3);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(Invoke_param2_PropertyAddress.Address, intPtr);
		}
	}

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	private static void LoadNativeType()
	{
		Invoke_FunctionAddress = NativeReflection.GetFunction("/Script/b1-Managed.HelloUSharpDelegate__DelegateSignature");
		Invoke_ParamsSize = NativeReflection.GetFunctionParamsSize(Invoke_FunctionAddress);
		Invoke_param1_Offset = NativeReflection.GetPropertyOffset(Invoke_FunctionAddress, "param1");
		Invoke_param1_IsValid = NativeReflection.ValidatePropertyClass(Invoke_FunctionAddress, "param1", Classes.FByteProperty);
		NativeReflection.GetPropertyRef(ref Invoke_param2_PropertyAddress, Invoke_FunctionAddress, "param2");
		Invoke_param2_Offset = NativeReflection.GetPropertyOffset(Invoke_FunctionAddress, "param2");
		Invoke_param2_IsValid = NativeReflection.ValidatePropertyClass(Invoke_FunctionAddress, "param2", Classes.FStrProperty);
		Invoke_param3_Offset = NativeReflection.GetPropertyOffset(Invoke_FunctionAddress, "param3");
		Invoke_param3_IsValid = NativeReflection.ValidatePropertyClass(Invoke_FunctionAddress, "param3", Classes.FIntProperty);
		Invoke_IsValid = Invoke_FunctionAddress != IntPtr.Zero && Invoke_param1_IsValid && Invoke_param2_IsValid && Invoke_param3_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.HelloUSharpDelegate__DelegateSignature", Invoke_IsValid);
	}

	static HelloUSharpDelegate()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(HelloUSharpDelegate)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(HelloUSharpDelegate));
	}
}
