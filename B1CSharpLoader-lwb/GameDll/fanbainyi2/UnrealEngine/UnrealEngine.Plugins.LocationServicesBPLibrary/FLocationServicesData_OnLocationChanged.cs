using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.LocationServicesBPLibrary;

[UDelegate]
[UMetaPath("/Script/LocationServicesBPLibrary.LocationServicesData_OnLocationChanged__DelegateSignature")]
public class FLocationServicesData_OnLocationChanged : FMulticastDelegate<FLocationServicesData_OnLocationChanged.Signature>
{
	public delegate void Signature(FLocationServicesData LocationData);

	private static bool LocationServicesData_OnLocationChanged__DelegateSignature_IsValid;

	private static IntPtr LocationServicesData_OnLocationChanged__DelegateSignature_FunctionAddress;

	private static int LocationServicesData_OnLocationChanged__DelegateSignature_ParamsSize;

	private static bool LocationServicesData_OnLocationChanged__DelegateSignature_LocationData_IsValid;

	private static FFieldAddress LocationServicesData_OnLocationChanged__DelegateSignature_LocationData_PropertyAddress;

	private static int LocationServicesData_OnLocationChanged__DelegateSignature_LocationData_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FLocationServicesData_OnLocationChanged()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		LocationServicesData_OnLocationChanged__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/LocationServicesBPLibrary.LocationServicesData_OnLocationChanged__DelegateSignature");
		LocationServicesData_OnLocationChanged__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(LocationServicesData_OnLocationChanged__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LocationServicesData_OnLocationChanged__DelegateSignature_LocationData_PropertyAddress, LocationServicesData_OnLocationChanged__DelegateSignature_FunctionAddress, "LocationData");
		LocationServicesData_OnLocationChanged__DelegateSignature_LocationData_Offset = NativeReflectionCached.GetPropertyOffset(LocationServicesData_OnLocationChanged__DelegateSignature_FunctionAddress, "LocationData");
		LocationServicesData_OnLocationChanged__DelegateSignature_LocationData_IsValid = NativeReflectionCached.ValidatePropertyClass(LocationServicesData_OnLocationChanged__DelegateSignature_FunctionAddress, "LocationData", Classes.FStructProperty);
		LocationServicesData_OnLocationChanged__DelegateSignature_IsValid = LocationServicesData_OnLocationChanged__DelegateSignature_FunctionAddress != IntPtr.Zero && LocationServicesData_OnLocationChanged__DelegateSignature_LocationData_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LocationServicesBPLibrary.LocationServicesData_OnLocationChanged__DelegateSignature", LocationServicesData_OnLocationChanged__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(FLocationServicesData LocationData)
	{
		if (!LocationServicesData_OnLocationChanged__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LocationServicesBPLibrary.LocationServicesData_OnLocationChanged__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(LocationServicesData_OnLocationChanged__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LocationServicesData_OnLocationChanged__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			NativeReflection.InitializeValue_InContainer(LocationServicesData_OnLocationChanged__DelegateSignature_LocationData_PropertyAddress.Address, intPtr);
			FLocationServicesData.ToNative(IntPtr.Add(intPtr, LocationServicesData_OnLocationChanged__DelegateSignature_LocationData_Offset), 0, LocationServicesData_OnLocationChanged__DelegateSignature_LocationData_PropertyAddress.Address, LocationData);
			ProcessDelegate(intPtr);
		}
	}
}
