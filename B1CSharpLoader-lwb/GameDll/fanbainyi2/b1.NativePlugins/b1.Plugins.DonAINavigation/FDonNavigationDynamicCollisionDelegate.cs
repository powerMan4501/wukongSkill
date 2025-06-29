using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.DonAINavigation;

[UDelegate]
[UMetaPath("/Script/DonAINavigation.DonNavigationDynamicCollisionDelegate__DelegateSignature")]
public class FDonNavigationDynamicCollisionDelegate : FDelegate<FDonNavigationDynamicCollisionDelegate.Signature>
{
	public delegate void Signature(FDonNavigationDynamicCollisionPayload Data);

	private static bool DonNavigationDynamicCollisionDelegate__DelegateSignature_IsValid;

	private static IntPtr DonNavigationDynamicCollisionDelegate__DelegateSignature_FunctionAddress;

	private static int DonNavigationDynamicCollisionDelegate__DelegateSignature_ParamsSize;

	private static bool DonNavigationDynamicCollisionDelegate__DelegateSignature_Data_IsValid;

	private static FFieldAddress DonNavigationDynamicCollisionDelegate__DelegateSignature_Data_PropertyAddress;

	private static int DonNavigationDynamicCollisionDelegate__DelegateSignature_Data_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FDonNavigationDynamicCollisionDelegate()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		DonNavigationDynamicCollisionDelegate__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/DonAINavigation.DonNavigationDynamicCollisionDelegate__DelegateSignature");
		DonNavigationDynamicCollisionDelegate__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(DonNavigationDynamicCollisionDelegate__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DonNavigationDynamicCollisionDelegate__DelegateSignature_Data_PropertyAddress, DonNavigationDynamicCollisionDelegate__DelegateSignature_FunctionAddress, "Data");
		DonNavigationDynamicCollisionDelegate__DelegateSignature_Data_Offset = NativeReflectionCached.GetPropertyOffset(DonNavigationDynamicCollisionDelegate__DelegateSignature_FunctionAddress, "Data");
		DonNavigationDynamicCollisionDelegate__DelegateSignature_Data_IsValid = NativeReflectionCached.ValidatePropertyClass(DonNavigationDynamicCollisionDelegate__DelegateSignature_FunctionAddress, "Data", Classes.FStructProperty);
		DonNavigationDynamicCollisionDelegate__DelegateSignature_IsValid = DonNavigationDynamicCollisionDelegate__DelegateSignature_FunctionAddress != IntPtr.Zero && DonNavigationDynamicCollisionDelegate__DelegateSignature_Data_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DonAINavigation.DonNavigationDynamicCollisionDelegate__DelegateSignature", DonNavigationDynamicCollisionDelegate__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(FDonNavigationDynamicCollisionPayload Data)
	{
		if (!DonNavigationDynamicCollisionDelegate__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DonAINavigation.DonNavigationDynamicCollisionDelegate__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(DonNavigationDynamicCollisionDelegate__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DonNavigationDynamicCollisionDelegate__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			NativeReflection.InitializeValue_InContainer(DonNavigationDynamicCollisionDelegate__DelegateSignature_Data_PropertyAddress.Address, intPtr);
			FDonNavigationDynamicCollisionPayload.ToNative(IntPtr.Add(intPtr, DonNavigationDynamicCollisionDelegate__DelegateSignature_Data_Offset), 0, DonNavigationDynamicCollisionDelegate__DelegateSignature_Data_PropertyAddress.Address, Data);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(DonNavigationDynamicCollisionDelegate__DelegateSignature_Data_PropertyAddress.Address, intPtr);
		}
	}
}
