using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using AOT;
using UnrealEngine.Runtime;

namespace b1.CppExport;

public class GSE_NiagaraFunc
{
	[MonoNativeFunctionWrapper]
	public delegate int Del_SetNiagaraArrayFloat(IntPtr NiagaraSystem, FName OverrideName, float[] Vectors, int Count);

	[MonoNativeFunctionWrapper]
	public delegate int Del_SetNiagaraArrayVector2D(IntPtr NiagaraSystem, FName OverrideName, FVector2D[] Vectors, int Count);

	[MonoNativeFunctionWrapper]
	public delegate int Del_SetNiagaraArrayVector(IntPtr NiagaraSystem, FName OverrideName, FVector[] Vectors, int Count);

	[MonoNativeFunctionWrapper]
	public delegate int Del_SetNiagaraArrayVector4(IntPtr NiagaraSystem, FName OverrideName, FVector4[] Vectors, int Count);

	[MonoNativeFunctionWrapper]
	public delegate int Del_SetNiagaraArrayInt32(IntPtr NiagaraSystem, FName OverrideName, int[] Vectors, int Count);

	[MonoNativeFunctionWrapper]
	public delegate int Del_SetNiagaraArrayQuat(IntPtr NiagaraSystem, FName OverrideName, FQuat[] Vectors, int Count);

	[MonoNativeFunctionWrapper]
	public delegate int Del_SetNiagaraArrayBool(IntPtr NiagaraSystem, FName OverrideName, bool[] Vectors, int Count);

	[MonoNativeFunctionWrapper]
	public delegate int Del_SetNiagaraArrayPosition(IntPtr NiagaraSystem, FName OverrideName, FVector[] Vectors, int Count);

	[MonoNativeFunctionWrapper]
	public delegate int Del_SetNiagaraArrayColor(IntPtr NiagaraSystem, FName OverrideName, FLinearColor[] Vectors, int Count);

	public static Del_SetNiagaraArrayFloat SetNiagaraArrayFloat;

	public static Del_SetNiagaraArrayVector2D SetNiagaraArrayVector2D;

	public static Del_SetNiagaraArrayVector SetNiagaraArrayVector;

	public static Del_SetNiagaraArrayVector4 SetNiagaraArrayVector4;

	public static Del_SetNiagaraArrayInt32 SetNiagaraArrayInt32;

	public static Del_SetNiagaraArrayQuat SetNiagaraArrayQuat;

	public static Del_SetNiagaraArrayBool SetNiagaraArrayBool;

	public static Del_SetNiagaraArrayPosition SetNiagaraArrayPosition;

	public static Del_SetNiagaraArrayColor SetNiagaraArrayColor;

	static GSE_NiagaraFunc()
	{
		Type typeFromHandle = typeof(GSE_NiagaraFunc);
		Dictionary<string, FIntPtr> niagaraFuncAsMap = UGSE_CppExport.GetNiagaraFuncAsMap();
		FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		foreach (FieldInfo fieldInfo in fields)
		{
			if (niagaraFuncAsMap.TryGetValue(fieldInfo.Name, out var value))
			{
				fieldInfo.SetValue(null, Marshal.GetDelegateForFunctionPointer(FIntPtrHelper.FIntPtr2IntPtr(value), fieldInfo.FieldType));
			}
		}
	}
}
