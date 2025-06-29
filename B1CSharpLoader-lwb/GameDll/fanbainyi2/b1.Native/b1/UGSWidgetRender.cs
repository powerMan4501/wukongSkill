using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/UnrealExtent.GSWidgetRender", "UnrealExtent", UnrealModuleType.Game)]
public class UGSWidgetRender : USceneComponent
{
	private static bool UpdateRenderTarget2D_IsValid;

	private static IntPtr UpdateRenderTarget2D_FunctionAddress;

	private static int UpdateRenderTarget2D_ParamsSize;

	private static bool GetUserWidgetObject_IsValid;

	private static IntPtr GetUserWidgetObject_FunctionAddress;

	private static int GetUserWidgetObject_ParamsSize;

	private static bool GetUserWidgetObject_ReturnValue_IsValid;

	private static FFieldAddress GetUserWidgetObject_ReturnValue_PropertyAddress;

	private static int GetUserWidgetObject_ReturnValue_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.GSWidgetRender:UpdateRenderTarget2D")]
	public unsafe void UpdateRenderTarget2D()
	{
		CheckDestroyed();
		if (!UpdateRenderTarget2D_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSWidgetRender:UpdateRenderTarget2D");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UpdateRenderTarget2D_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UpdateRenderTarget2D_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: UpdateRenderTarget2D_FunctionAddress, argsSize: UpdateRenderTarget2D_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UnrealExtent.GSWidgetRender:GetUserWidgetObject")]
	public unsafe UUserWidget GetUserWidgetObject()
	{
		CheckDestroyed();
		if (!GetUserWidgetObject_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSWidgetRender:GetUserWidgetObject");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetUserWidgetObject_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetUserWidgetObject_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetUserWidgetObject_FunctionAddress, intPtr, GetUserWidgetObject_ParamsSize);
		return UObjectMarshaler<UUserWidget>.FromNative(IntPtr.Add(intPtr, GetUserWidgetObject_ReturnValue_Offset), 0, GetUserWidgetObject_ReturnValue_PropertyAddress.Address);
	}

	static UGSWidgetRender()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSWidgetRender)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSWidgetRender));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/UnrealExtent.GSWidgetRender");
		UpdateRenderTarget2D_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "UpdateRenderTarget2D");
		UpdateRenderTarget2D_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateRenderTarget2D_FunctionAddress);
		UpdateRenderTarget2D_IsValid = UpdateRenderTarget2D_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSWidgetRender:UpdateRenderTarget2D", UpdateRenderTarget2D_IsValid);
		GetUserWidgetObject_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetUserWidgetObject");
		GetUserWidgetObject_ParamsSize = NativeReflection.GetFunctionParamsSize(GetUserWidgetObject_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetUserWidgetObject_ReturnValue_PropertyAddress, GetUserWidgetObject_FunctionAddress, "ReturnValue");
		GetUserWidgetObject_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetUserWidgetObject_FunctionAddress, "ReturnValue");
		GetUserWidgetObject_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetUserWidgetObject_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetUserWidgetObject_IsValid = GetUserWidgetObject_FunctionAddress != IntPtr.Zero && GetUserWidgetObject_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSWidgetRender:GetUserWidgetObject", GetUserWidgetObject_IsValid);
	}
}
