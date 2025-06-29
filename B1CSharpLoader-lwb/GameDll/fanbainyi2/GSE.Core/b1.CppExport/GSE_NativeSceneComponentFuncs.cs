using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using AOT;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.CppExport;

public class GSE_NativeSceneComponentFuncs
{
	[MonoNativeFunctionWrapper]
	public delegate FVector Del_GetSocketLocation(IntPtr Comp, ref FName SocketName);

	[MonoNativeFunctionWrapper]
	public delegate FRotator Del_GetSocketRotation(IntPtr Comp, ref FName SocketName);

	[MonoNativeFunctionWrapper]
	public delegate FTransform Del_GetSocketTransform(IntPtr Comp, ref FName SocketName, ERelativeTransformSpace TransformSpace = ERelativeTransformSpace.RTS_World);

	[MonoNativeFunctionWrapper]
	public delegate void Del_SetWorldLocationAndRotationSimple(IntPtr Comp, FVector Pos, FRotator Rot);

	static GSE_NativeSceneComponentFuncs()
	{
		Type typeFromHandle = typeof(SceneComponentFuncLib);
		Dictionary<string, FIntPtr> sceneComponentFuncAsMap = UGSE_CppExport.GetSceneComponentFuncAsMap();
		FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		foreach (FieldInfo fieldInfo in fields)
		{
			if (sceneComponentFuncAsMap.TryGetValue(fieldInfo.Name, out var value))
			{
				fieldInfo.SetValue(null, Marshal.GetDelegateForFunctionPointer(FIntPtrHelper.FIntPtr2IntPtr(value), fieldInfo.FieldType));
			}
		}
	}
}
