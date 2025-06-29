using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.DonAINavigation;

[UDelegate]
[UMetaPath("/Script/DonAINavigation.DoNNavigationResultHandler__DelegateSignature")]
public class FDoNNavigationResultHandler : FDelegate<FDoNNavigationResultHandler.Signature>
{
	public delegate void Signature(FDoNNavigationQueryData Data);

	private static bool DoNNavigationResultHandler__DelegateSignature_IsValid;

	private static IntPtr DoNNavigationResultHandler__DelegateSignature_FunctionAddress;

	private static int DoNNavigationResultHandler__DelegateSignature_ParamsSize;

	private static bool DoNNavigationResultHandler__DelegateSignature_Data_IsValid;

	private static FFieldAddress DoNNavigationResultHandler__DelegateSignature_Data_PropertyAddress;

	private static int DoNNavigationResultHandler__DelegateSignature_Data_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FDoNNavigationResultHandler()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		DoNNavigationResultHandler__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/DonAINavigation.DoNNavigationResultHandler__DelegateSignature");
		DoNNavigationResultHandler__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(DoNNavigationResultHandler__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DoNNavigationResultHandler__DelegateSignature_Data_PropertyAddress, DoNNavigationResultHandler__DelegateSignature_FunctionAddress, "Data");
		DoNNavigationResultHandler__DelegateSignature_Data_Offset = NativeReflectionCached.GetPropertyOffset(DoNNavigationResultHandler__DelegateSignature_FunctionAddress, "Data");
		DoNNavigationResultHandler__DelegateSignature_Data_IsValid = NativeReflectionCached.ValidatePropertyClass(DoNNavigationResultHandler__DelegateSignature_FunctionAddress, "Data", Classes.FStructProperty);
		DoNNavigationResultHandler__DelegateSignature_IsValid = DoNNavigationResultHandler__DelegateSignature_FunctionAddress != IntPtr.Zero && DoNNavigationResultHandler__DelegateSignature_Data_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DonAINavigation.DoNNavigationResultHandler__DelegateSignature", DoNNavigationResultHandler__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(FDoNNavigationQueryData Data)
	{
		if (!DoNNavigationResultHandler__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DonAINavigation.DoNNavigationResultHandler__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(DoNNavigationResultHandler__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DoNNavigationResultHandler__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			NativeReflection.InitializeValue_InContainer(DoNNavigationResultHandler__DelegateSignature_Data_PropertyAddress.Address, intPtr);
			FDoNNavigationQueryData.ToNative(IntPtr.Add(intPtr, DoNNavigationResultHandler__DelegateSignature_Data_Offset), 0, DoNNavigationResultHandler__DelegateSignature_Data_PropertyAddress.Address, Data);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(DoNNavigationResultHandler__DelegateSignature_Data_PropertyAddress.Address, intPtr);
		}
	}
}
