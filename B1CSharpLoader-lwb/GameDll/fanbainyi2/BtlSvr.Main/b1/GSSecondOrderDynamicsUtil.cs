using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.GSSecondOrderDynamicsUtil")]
public class GSSecondOrderDynamicsUtil : UBlueprintFunctionLibrary
{
	public static GSSecondOrderDynamics CurSecOrdDyn;

	private static bool InitCurSecOrdDyn_IsValid;

	private static IntPtr InitCurSecOrdDyn_FunctionAddress;

	private static int InitCurSecOrdDyn_ParamsSize;

	private static bool InitCurSecOrdDyn_F_IsValid;

	private static int InitCurSecOrdDyn_F_Offset;

	private static bool InitCurSecOrdDyn_Z_IsValid;

	private static int InitCurSecOrdDyn_Z_Offset;

	private static bool InitCurSecOrdDyn_R_IsValid;

	private static int InitCurSecOrdDyn_R_Offset;

	private static bool InitCurSecOrdDyn_X0_IsValid;

	private static int InitCurSecOrdDyn_X0_Offset;

	private static bool CurSecOrdDynUpdate_IsValid;

	private static IntPtr CurSecOrdDynUpdate_FunctionAddress;

	private static int CurSecOrdDynUpdate_ParamsSize;

	private static bool CurSecOrdDynUpdate_T_IsValid;

	private static int CurSecOrdDynUpdate_T_Offset;

	private static bool CurSecOrdDynUpdate_X_IsValid;

	private static int CurSecOrdDynUpdate_X_Offset;

	private static bool CurSecOrdDynUpdate_XD_IsValid;

	private static int CurSecOrdDynUpdate_XD_Offset;

	private static bool CurSecOrdDynUpdate_ReturnValue_IsValid;

	private static int CurSecOrdDynUpdate_ReturnValue_Offset;

	[BlueprintCallable]
	[UFunction]
	[Category("SecOrdDynUtil")]
	[USharpPath("/Script/b1-Managed.GSSecondOrderDynamicsUtil:InitCurSecOrdDyn")]
	public static void InitCurSecOrdDyn(float F, float Z, float R, float X0)
	{
		CurSecOrdDyn = new GSSecondOrderDynamics(F, Z, R, X0);
	}

	[UFunction]
	[BlueprintCallable]
	[Category("SecOrdDynUtil")]
	[USharpPath("/Script/b1-Managed.GSSecondOrderDynamicsUtil:CurSecOrdDynUpdate")]
	public static float CurSecOrdDynUpdate(float T, float X, float XD)
	{
		return CurSecOrdDyn.Update(T, X, XD);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSSecondOrderDynamicsUtil:InitCurSecOrdDyn")]
	private static void InitCurSecOrdDyn__Invoker(IntPtr buffer, IntPtr obj)
	{
		float f = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, InitCurSecOrdDyn_F_Offset));
		float z = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, InitCurSecOrdDyn_Z_Offset));
		float r = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, InitCurSecOrdDyn_R_Offset));
		float x = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, InitCurSecOrdDyn_X0_Offset));
		InitCurSecOrdDyn(f, z, r, x);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSSecondOrderDynamicsUtil:CurSecOrdDynUpdate")]
	private static void CurSecOrdDynUpdate__Invoker(IntPtr buffer, IntPtr obj)
	{
		float t = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, CurSecOrdDynUpdate_T_Offset));
		float x = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, CurSecOrdDynUpdate_X_Offset));
		float xD = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, CurSecOrdDynUpdate_XD_Offset));
		float value = CurSecOrdDynUpdate(t, x, xD);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(buffer, CurSecOrdDynUpdate_ReturnValue_Offset), value);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.GSSecondOrderDynamicsUtil");
		InitCurSecOrdDyn_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "InitCurSecOrdDyn");
		InitCurSecOrdDyn_ParamsSize = NativeReflection.GetFunctionParamsSize(InitCurSecOrdDyn_FunctionAddress);
		InitCurSecOrdDyn_F_Offset = NativeReflection.GetPropertyOffset(InitCurSecOrdDyn_FunctionAddress, "F");
		InitCurSecOrdDyn_F_IsValid = NativeReflection.ValidatePropertyClass(InitCurSecOrdDyn_FunctionAddress, "F", Classes.FFloatProperty);
		InitCurSecOrdDyn_Z_Offset = NativeReflection.GetPropertyOffset(InitCurSecOrdDyn_FunctionAddress, "Z");
		InitCurSecOrdDyn_Z_IsValid = NativeReflection.ValidatePropertyClass(InitCurSecOrdDyn_FunctionAddress, "Z", Classes.FFloatProperty);
		InitCurSecOrdDyn_R_Offset = NativeReflection.GetPropertyOffset(InitCurSecOrdDyn_FunctionAddress, "R");
		InitCurSecOrdDyn_R_IsValid = NativeReflection.ValidatePropertyClass(InitCurSecOrdDyn_FunctionAddress, "R", Classes.FFloatProperty);
		InitCurSecOrdDyn_X0_Offset = NativeReflection.GetPropertyOffset(InitCurSecOrdDyn_FunctionAddress, "X0");
		InitCurSecOrdDyn_X0_IsValid = NativeReflection.ValidatePropertyClass(InitCurSecOrdDyn_FunctionAddress, "X0", Classes.FFloatProperty);
		InitCurSecOrdDyn_IsValid = InitCurSecOrdDyn_FunctionAddress != IntPtr.Zero && InitCurSecOrdDyn_F_IsValid && InitCurSecOrdDyn_Z_IsValid && InitCurSecOrdDyn_R_IsValid && InitCurSecOrdDyn_X0_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSSecondOrderDynamicsUtil:InitCurSecOrdDyn", InitCurSecOrdDyn_IsValid);
		CurSecOrdDynUpdate_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CurSecOrdDynUpdate");
		CurSecOrdDynUpdate_ParamsSize = NativeReflection.GetFunctionParamsSize(CurSecOrdDynUpdate_FunctionAddress);
		CurSecOrdDynUpdate_T_Offset = NativeReflection.GetPropertyOffset(CurSecOrdDynUpdate_FunctionAddress, "T");
		CurSecOrdDynUpdate_T_IsValid = NativeReflection.ValidatePropertyClass(CurSecOrdDynUpdate_FunctionAddress, "T", Classes.FFloatProperty);
		CurSecOrdDynUpdate_X_Offset = NativeReflection.GetPropertyOffset(CurSecOrdDynUpdate_FunctionAddress, "X");
		CurSecOrdDynUpdate_X_IsValid = NativeReflection.ValidatePropertyClass(CurSecOrdDynUpdate_FunctionAddress, "X", Classes.FFloatProperty);
		CurSecOrdDynUpdate_XD_Offset = NativeReflection.GetPropertyOffset(CurSecOrdDynUpdate_FunctionAddress, "XD");
		CurSecOrdDynUpdate_XD_IsValid = NativeReflection.ValidatePropertyClass(CurSecOrdDynUpdate_FunctionAddress, "XD", Classes.FFloatProperty);
		CurSecOrdDynUpdate_ReturnValue_Offset = NativeReflection.GetPropertyOffset(CurSecOrdDynUpdate_FunctionAddress, "ReturnValue");
		CurSecOrdDynUpdate_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(CurSecOrdDynUpdate_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		CurSecOrdDynUpdate_IsValid = CurSecOrdDynUpdate_FunctionAddress != IntPtr.Zero && CurSecOrdDynUpdate_T_IsValid && CurSecOrdDynUpdate_X_IsValid && CurSecOrdDynUpdate_XD_IsValid && CurSecOrdDynUpdate_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSSecondOrderDynamicsUtil:CurSecOrdDynUpdate", CurSecOrdDynUpdate_IsValid);
	}

	static GSSecondOrderDynamicsUtil()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(GSSecondOrderDynamicsUtil)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(GSSecondOrderDynamicsUtil));
	}
}
