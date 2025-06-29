using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.JavascriptEditor;

[UDelegate]
[UMetaPath("/Script/JavascriptEditor.DynamicSimpleGetBoolDelegate__DelegateSignature")]
public class FDynamicSimpleGetBoolDelegate : FDelegate<FDynamicSimpleGetBoolDelegate.Signature>
{
	public delegate bool Signature();

	private static bool DynamicSimpleGetBoolDelegate__DelegateSignature_IsValid;

	private static IntPtr DynamicSimpleGetBoolDelegate__DelegateSignature_FunctionAddress;

	private static int DynamicSimpleGetBoolDelegate__DelegateSignature_ParamsSize;

	private static bool DynamicSimpleGetBoolDelegate__DelegateSignature_ReturnValue_IsValid;

	private static FFieldAddress DynamicSimpleGetBoolDelegate__DelegateSignature_ReturnValue_PropertyAddress;

	private static int DynamicSimpleGetBoolDelegate__DelegateSignature_ReturnValue_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FDynamicSimpleGetBoolDelegate()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		DynamicSimpleGetBoolDelegate__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/JavascriptEditor.DynamicSimpleGetBoolDelegate__DelegateSignature");
		DynamicSimpleGetBoolDelegate__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(DynamicSimpleGetBoolDelegate__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DynamicSimpleGetBoolDelegate__DelegateSignature_ReturnValue_PropertyAddress, DynamicSimpleGetBoolDelegate__DelegateSignature_FunctionAddress, "ReturnValue");
		DynamicSimpleGetBoolDelegate__DelegateSignature_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(DynamicSimpleGetBoolDelegate__DelegateSignature_FunctionAddress, "ReturnValue");
		DynamicSimpleGetBoolDelegate__DelegateSignature_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(DynamicSimpleGetBoolDelegate__DelegateSignature_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		DynamicSimpleGetBoolDelegate__DelegateSignature_IsValid = DynamicSimpleGetBoolDelegate__DelegateSignature_FunctionAddress != IntPtr.Zero && DynamicSimpleGetBoolDelegate__DelegateSignature_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.DynamicSimpleGetBoolDelegate__DelegateSignature", DynamicSimpleGetBoolDelegate__DelegateSignature_IsValid);
	}

	private unsafe bool Invoker()
	{
		if (!DynamicSimpleGetBoolDelegate__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.DynamicSimpleGetBoolDelegate__DelegateSignature");
			return false;
		}
		if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(DynamicSimpleGetBoolDelegate__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DynamicSimpleGetBoolDelegate__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			ProcessDelegate(intPtr);
			return BoolMarshaler.FromNative(IntPtr.Add(intPtr, DynamicSimpleGetBoolDelegate__DelegateSignature_ReturnValue_Offset), 0, DynamicSimpleGetBoolDelegate__DelegateSignature_ReturnValue_PropertyAddress.Address);
		}
		return false;
	}
}
