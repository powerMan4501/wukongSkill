using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.OnDataLayerRuntimeStateChanged__DelegateSignature")]
public class FOnDataLayerRuntimeStateChanged : FMulticastDelegate<FOnDataLayerRuntimeStateChanged.Signature>
{
	public delegate void Signature(UDataLayer DataLayer, EDataLayerRuntimeState State);

	private static bool OnDataLayerRuntimeStateChanged__DelegateSignature_IsValid;

	private static IntPtr OnDataLayerRuntimeStateChanged__DelegateSignature_FunctionAddress;

	private static int OnDataLayerRuntimeStateChanged__DelegateSignature_ParamsSize;

	private static bool OnDataLayerRuntimeStateChanged__DelegateSignature_DataLayer_IsValid;

	private static FFieldAddress OnDataLayerRuntimeStateChanged__DelegateSignature_DataLayer_PropertyAddress;

	private static int OnDataLayerRuntimeStateChanged__DelegateSignature_DataLayer_Offset;

	private static bool OnDataLayerRuntimeStateChanged__DelegateSignature_State_IsValid;

	private static FFieldAddress OnDataLayerRuntimeStateChanged__DelegateSignature_State_PropertyAddress;

	private static int OnDataLayerRuntimeStateChanged__DelegateSignature_State_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnDataLayerRuntimeStateChanged()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnDataLayerRuntimeStateChanged__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.OnDataLayerRuntimeStateChanged__DelegateSignature");
		OnDataLayerRuntimeStateChanged__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnDataLayerRuntimeStateChanged__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnDataLayerRuntimeStateChanged__DelegateSignature_DataLayer_PropertyAddress, OnDataLayerRuntimeStateChanged__DelegateSignature_FunctionAddress, "DataLayer");
		OnDataLayerRuntimeStateChanged__DelegateSignature_DataLayer_Offset = NativeReflectionCached.GetPropertyOffset(OnDataLayerRuntimeStateChanged__DelegateSignature_FunctionAddress, "DataLayer");
		OnDataLayerRuntimeStateChanged__DelegateSignature_DataLayer_IsValid = NativeReflectionCached.ValidatePropertyClass(OnDataLayerRuntimeStateChanged__DelegateSignature_FunctionAddress, "DataLayer", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref OnDataLayerRuntimeStateChanged__DelegateSignature_State_PropertyAddress, OnDataLayerRuntimeStateChanged__DelegateSignature_FunctionAddress, "State");
		OnDataLayerRuntimeStateChanged__DelegateSignature_State_Offset = NativeReflectionCached.GetPropertyOffset(OnDataLayerRuntimeStateChanged__DelegateSignature_FunctionAddress, "State");
		OnDataLayerRuntimeStateChanged__DelegateSignature_State_IsValid = NativeReflectionCached.ValidatePropertyClass(OnDataLayerRuntimeStateChanged__DelegateSignature_FunctionAddress, "State", Classes.FEnumProperty);
		OnDataLayerRuntimeStateChanged__DelegateSignature_IsValid = OnDataLayerRuntimeStateChanged__DelegateSignature_FunctionAddress != IntPtr.Zero && OnDataLayerRuntimeStateChanged__DelegateSignature_DataLayer_IsValid && OnDataLayerRuntimeStateChanged__DelegateSignature_State_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.OnDataLayerRuntimeStateChanged__DelegateSignature", OnDataLayerRuntimeStateChanged__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(UDataLayer DataLayer, EDataLayerRuntimeState State)
	{
		if (!OnDataLayerRuntimeStateChanged__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.OnDataLayerRuntimeStateChanged__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnDataLayerRuntimeStateChanged__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnDataLayerRuntimeStateChanged__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			UObjectMarshaler<UDataLayer>.ToNative(IntPtr.Add(intPtr, OnDataLayerRuntimeStateChanged__DelegateSignature_DataLayer_Offset), 0, OnDataLayerRuntimeStateChanged__DelegateSignature_DataLayer_PropertyAddress.Address, DataLayer);
			EnumMarshaler<EDataLayerRuntimeState>.ToNative(IntPtr.Add(intPtr, OnDataLayerRuntimeStateChanged__DelegateSignature_State_Offset), 0, OnDataLayerRuntimeStateChanged__DelegateSignature_State_PropertyAddress.Address, State);
			ProcessDelegate(intPtr);
		}
	}
}
