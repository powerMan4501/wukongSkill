using System;
using AOT;
using UnrealEngine.Engine;

namespace UnrealEngine.Runtime.Native;

internal static class Native_UUserDefinedStruct
{
	[MonoNativeFunctionWrapper]
	public delegate EUserDefinedStructureStatus Del_Get_Status(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Set_Status(IntPtr instance, EUserDefinedStructureStatus status);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Get_ErrorMessage(IntPtr instance, ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Set_ErrorMessage(IntPtr instance, ref FScriptArray errorMessage);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_Get_EditorData(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Set_EditorData(IntPtr instance, IntPtr editorData);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Get_Guid(IntPtr instance, out Guid guid);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Set_Guid(IntPtr instance, ref Guid guid);

	public static Del_Get_Status Get_Status;

	public static Del_Set_Status Set_Status;

	public static Del_Get_ErrorMessage Get_ErrorMessage;

	public static Del_Set_ErrorMessage Set_ErrorMessage;

	public static Del_Get_EditorData Get_EditorData;

	public static Del_Set_EditorData Set_EditorData;

	public static Del_Get_Guid Get_Guid;

	public static Del_Set_Guid Set_Guid;
}
