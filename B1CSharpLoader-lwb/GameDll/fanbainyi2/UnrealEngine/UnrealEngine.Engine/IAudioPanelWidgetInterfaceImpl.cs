using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

public sealed class IAudioPanelWidgetInterfaceImpl : IInterfaceImpl, IAudioPanelWidgetInterface, IInterface
{
	private static bool GetIconBrushName_IsValid;

	private IntPtr GetIconBrushName_InstanceFunctionAddress;

	private static IntPtr GetIconBrushName_FunctionAddress;

	private static int GetIconBrushName_ParamsSize;

	private static bool GetIconBrushName_ReturnValue_IsValid;

	private static FFieldAddress GetIconBrushName_ReturnValue_PropertyAddress;

	private static int GetIconBrushName_ReturnValue_Offset;

	private static bool GetEditorName_IsValid;

	private IntPtr GetEditorName_InstanceFunctionAddress;

	private static IntPtr GetEditorName_FunctionAddress;

	private static int GetEditorName_ParamsSize;

	private static bool GetEditorName_ReturnValue_IsValid;

	private static FFieldAddress GetEditorName_ReturnValue_PropertyAddress;

	private static int GetEditorName_ReturnValue_Offset;

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/Engine.AudioPanelWidgetInterface:GetIconBrushName")]
	public unsafe FName GetIconBrushName()
	{
		CheckDestroyed();
		if (!GetIconBrushName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AudioPanelWidgetInterface:GetIconBrushName");
			return default(FName);
		}
		if (GetIconBrushName_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetIconBrushName_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetIconBrushName");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetIconBrushName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetIconBrushName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetIconBrushName_InstanceFunctionAddress, intPtr, GetIconBrushName_ParamsSize);
		return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, GetIconBrushName_ReturnValue_Offset), 0, GetIconBrushName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/Engine.AudioPanelWidgetInterface:GetEditorName")]
	public unsafe string GetEditorName()
	{
		CheckDestroyed();
		if (!GetEditorName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AudioPanelWidgetInterface:GetEditorName");
			return FStringMarshaler.DefaultString;
		}
		if (GetEditorName_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetEditorName_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetEditorName");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetEditorName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetEditorName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetEditorName_InstanceFunctionAddress, intPtr, GetEditorName_ParamsSize);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, GetEditorName_ReturnValue_Offset), 0, GetEditorName_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(GetEditorName_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	public override void ResetInterface()
	{
		GetIconBrushName_InstanceFunctionAddress = IntPtr.Zero;
		GetEditorName_InstanceFunctionAddress = IntPtr.Zero;
	}

	static IAudioPanelWidgetInterfaceImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(IAudioPanelWidgetInterfaceImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(IAudioPanelWidgetInterfaceImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/Engine.AudioPanelWidgetInterface");
		GetIconBrushName_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetIconBrushName");
		GetIconBrushName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetIconBrushName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetIconBrushName_ReturnValue_PropertyAddress, GetIconBrushName_FunctionAddress, "ReturnValue");
		GetIconBrushName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetIconBrushName_FunctionAddress, "ReturnValue");
		GetIconBrushName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetIconBrushName_FunctionAddress, "ReturnValue", Classes.FNameProperty);
		GetIconBrushName_IsValid = GetIconBrushName_FunctionAddress != IntPtr.Zero && GetIconBrushName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AudioPanelWidgetInterface:GetIconBrushName", GetIconBrushName_IsValid);
		GetEditorName_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetEditorName");
		GetEditorName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetEditorName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetEditorName_ReturnValue_PropertyAddress, GetEditorName_FunctionAddress, "ReturnValue");
		GetEditorName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetEditorName_FunctionAddress, "ReturnValue");
		GetEditorName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetEditorName_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		GetEditorName_IsValid = GetEditorName_FunctionAddress != IntPtr.Zero && GetEditorName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AudioPanelWidgetInterface:GetEditorName", GetEditorName_IsValid);
	}
}
