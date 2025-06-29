using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.AppleImageUtils;

[UDelegate]
[UMetaPath("/Script/AppleImageUtils.AppleImageConversionDelegate__DelegateSignature")]
public class FAppleImageConversionDelegate : FMulticastDelegate<FAppleImageConversionDelegate.Signature>
{
	public delegate void Signature(FAppleImageUtilsImageConversionResult ConversionResult);

	private static bool AppleImageConversionDelegate__DelegateSignature_IsValid;

	private static IntPtr AppleImageConversionDelegate__DelegateSignature_FunctionAddress;

	private static int AppleImageConversionDelegate__DelegateSignature_ParamsSize;

	private static bool AppleImageConversionDelegate__DelegateSignature_ConversionResult_IsValid;

	private static FFieldAddress AppleImageConversionDelegate__DelegateSignature_ConversionResult_PropertyAddress;

	private static int AppleImageConversionDelegate__DelegateSignature_ConversionResult_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FAppleImageConversionDelegate()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		AppleImageConversionDelegate__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/AppleImageUtils.AppleImageConversionDelegate__DelegateSignature");
		AppleImageConversionDelegate__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(AppleImageConversionDelegate__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AppleImageConversionDelegate__DelegateSignature_ConversionResult_PropertyAddress, AppleImageConversionDelegate__DelegateSignature_FunctionAddress, "ConversionResult");
		AppleImageConversionDelegate__DelegateSignature_ConversionResult_Offset = NativeReflectionCached.GetPropertyOffset(AppleImageConversionDelegate__DelegateSignature_FunctionAddress, "ConversionResult");
		AppleImageConversionDelegate__DelegateSignature_ConversionResult_IsValid = NativeReflectionCached.ValidatePropertyClass(AppleImageConversionDelegate__DelegateSignature_FunctionAddress, "ConversionResult", Classes.FStructProperty);
		AppleImageConversionDelegate__DelegateSignature_IsValid = AppleImageConversionDelegate__DelegateSignature_FunctionAddress != IntPtr.Zero && AppleImageConversionDelegate__DelegateSignature_ConversionResult_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AppleImageUtils.AppleImageConversionDelegate__DelegateSignature", AppleImageConversionDelegate__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(FAppleImageUtilsImageConversionResult ConversionResult)
	{
		if (!AppleImageConversionDelegate__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AppleImageUtils.AppleImageConversionDelegate__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(AppleImageConversionDelegate__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AppleImageConversionDelegate__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			NativeReflection.InitializeValue_InContainer(AppleImageConversionDelegate__DelegateSignature_ConversionResult_PropertyAddress.Address, intPtr);
			FAppleImageUtilsImageConversionResult.ToNative(IntPtr.Add(intPtr, AppleImageConversionDelegate__DelegateSignature_ConversionResult_Offset), 0, AppleImageConversionDelegate__DelegateSignature_ConversionResult_PropertyAddress.Address, ConversionResult);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(AppleImageConversionDelegate__DelegateSignature_ConversionResult_PropertyAddress.Address, intPtr);
		}
	}
}
