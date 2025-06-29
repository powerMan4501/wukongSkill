using System;
using AOT;

namespace UnrealEngine.Runtime.Native;

internal static class Native_FSlowTask
{
	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_New(float amountOfWork, ref FScriptArray defaultMessage, csbool enabled);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_New_FScopedSlowTask(float amountOfWork, ref FScriptArray defaultMessage, csbool enabled);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Delete(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Get_DefaultMessageStr(IntPtr instance, ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Set_DefaultMessageStr(IntPtr instance, ref FScriptArray value);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Get_FrameMessageStr(IntPtr instance, ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Set_FrameMessageStr(IntPtr instance, ref FScriptArray value);

	[MonoNativeFunctionWrapper]
	public delegate float Del_Get_TotalAmountOfWork(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Set_TotalAmountOfWork(IntPtr instance, float value);

	[MonoNativeFunctionWrapper]
	public delegate float Del_Get_CompletedWork(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Set_CompletedWork(IntPtr instance, float value);

	[MonoNativeFunctionWrapper]
	public delegate float Del_Get_CurrentFrameScope(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Set_CurrentFrameScope(IntPtr instance, float value);

	[MonoNativeFunctionWrapper]
	public delegate int Del_Get_Visibility(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Set_Visibility(IntPtr instance, int value);

	[MonoNativeFunctionWrapper]
	public delegate double Del_Get_StartTime(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Set_StartTime(IntPtr instance, double value);

	[MonoNativeFunctionWrapper]
	public delegate float Del_Get_OpenDialogThreshold(IntPtr instance, out csbool hasValue);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Set_OpenDialogThreshold(IntPtr instance, float value, csbool hasValue);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Initialize(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Destroy(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_MakeDialogDelayed(IntPtr instance, float threshold, csbool showCancelButton, csbool allowInPIE);

	[MonoNativeFunctionWrapper]
	public delegate void Del_MakeDialog(IntPtr instance, csbool showCancelButton, csbool allowInPIE);

	[MonoNativeFunctionWrapper]
	public delegate void Del_EnterProgressFrame(IntPtr instance, float expectedWorkThisFrame, ref FScriptArray text);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GetCurrentMessage(IntPtr instance, ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_ShouldCancel(IntPtr instance);

	public static Del_New New;

	public static Del_New_FScopedSlowTask New_FScopedSlowTask;

	public static Del_Delete Delete;

	public static Del_Get_DefaultMessageStr Get_DefaultMessageStr;

	public static Del_Set_DefaultMessageStr Set_DefaultMessageStr;

	public static Del_Get_FrameMessageStr Get_FrameMessageStr;

	public static Del_Set_FrameMessageStr Set_FrameMessageStr;

	public static Del_Get_TotalAmountOfWork Get_TotalAmountOfWork;

	public static Del_Set_TotalAmountOfWork Set_TotalAmountOfWork;

	public static Del_Get_CompletedWork Get_CompletedWork;

	public static Del_Set_CompletedWork Set_CompletedWork;

	public static Del_Get_CurrentFrameScope Get_CurrentFrameScope;

	public static Del_Set_CurrentFrameScope Set_CurrentFrameScope;

	public static Del_Get_Visibility Get_Visibility;

	public static Del_Set_Visibility Set_Visibility;

	public static Del_Get_StartTime Get_StartTime;

	public static Del_Set_StartTime Set_StartTime;

	public static Del_Get_OpenDialogThreshold Get_OpenDialogThreshold;

	public static Del_Set_OpenDialogThreshold Set_OpenDialogThreshold;

	public static Del_Initialize Initialize;

	public static Del_Destroy Destroy;

	public static Del_MakeDialogDelayed MakeDialogDelayed;

	public static Del_MakeDialog MakeDialog;

	public static Del_EnterProgressFrame EnterProgressFrame;

	public static Del_GetCurrentMessage GetCurrentMessage;

	public static Del_ShouldCancel ShouldCancel;
}
