using System;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace GSDispLib;

[UClass]
[USharpPath("/Script/b1-Managed.DispLibDebugTest_SpawnAttachedNiagara")]
public class DispLibDebugTest_SpawnAttachedNiagara : AActor
{
	private static bool Template_IsValid;

	private static int Template_Offset;

	private static bool SpawnNS_IsValid;

	private static IntPtr SpawnNS_FunctionAddress;

	private static int SpawnNS_ParamsSize;

	private static bool SetVisible_IsValid;

	private static IntPtr SetVisible_FunctionAddress;

	private static int SetVisible_ParamsSize;

	private static bool SetVisible_vis_IsValid;

	private static int SetVisible_vis_Offset;

	private static FFieldAddress SetVisible_vis_PropertyAddress;

	private static bool SetVisible_child_IsValid;

	private static int SetVisible_child_Offset;

	private static FFieldAddress SetVisible_child_PropertyAddress;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.DispLibDebugTest_SpawnAttachedNiagara:Template")]
	public UNiagaraSystem Template
	{
		get
		{
			CheckDestroyed();
			if (!Template_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLibDebugTest_SpawnAttachedNiagara:Template");
				return null;
			}
			return UObjectMarshaler<UNiagaraSystem>.FromNative(IntPtr.Add(base.Address, Template_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Template_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLibDebugTest_SpawnAttachedNiagara:Template");
			}
			else
			{
				UObjectMarshaler<UNiagaraSystem>.ToNative(IntPtr.Add(base.Address, Template_Offset), value);
			}
		}
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.DispLibDebugTest_SpawnAttachedNiagara:SpawnNS")]
	public void SpawnNS()
	{
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.DispLibDebugTest_SpawnAttachedNiagara:SetVisible")]
	public void SetVisible(bool vis, bool child)
	{
	}

	[UFunctionInvoker("/Script/b1-Managed.DispLibDebugTest_SpawnAttachedNiagara:SpawnNS")]
	private static void SpawnNS__Invoker(IntPtr buffer, IntPtr obj)
	{
		DispLibDebugTest_SpawnAttachedNiagara dispLibDebugTest_SpawnAttachedNiagara = GCHelper.Find<DispLibDebugTest_SpawnAttachedNiagara>(obj);
		dispLibDebugTest_SpawnAttachedNiagara.SpawnNS();
	}

	[UFunctionInvoker("/Script/b1-Managed.DispLibDebugTest_SpawnAttachedNiagara:SetVisible")]
	private static void SetVisible__Invoker(IntPtr buffer, IntPtr obj)
	{
		DispLibDebugTest_SpawnAttachedNiagara dispLibDebugTest_SpawnAttachedNiagara = GCHelper.Find<DispLibDebugTest_SpawnAttachedNiagara>(obj);
		bool vis = BoolMarshaler.FromNative(IntPtr.Add(buffer, SetVisible_vis_Offset), 0, SetVisible_vis_PropertyAddress.Address);
		bool child = BoolMarshaler.FromNative(IntPtr.Add(buffer, SetVisible_child_Offset), 0, SetVisible_child_PropertyAddress.Address);
		dispLibDebugTest_SpawnAttachedNiagara.SetVisible(vis, child);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.DispLibDebugTest_SpawnAttachedNiagara");
		Template_Offset = NativeReflection.GetPropertyOffset(intPtr, "Template");
		Template_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Template", Classes.FObjectProperty);
		SpawnNS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SpawnNS");
		SpawnNS_ParamsSize = NativeReflection.GetFunctionParamsSize(SpawnNS_FunctionAddress);
		SpawnNS_IsValid = SpawnNS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.DispLibDebugTest_SpawnAttachedNiagara:SpawnNS", SpawnNS_IsValid);
		SetVisible_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetVisible");
		SetVisible_ParamsSize = NativeReflection.GetFunctionParamsSize(SetVisible_FunctionAddress);
		NativeReflection.GetPropertyRef(ref SetVisible_vis_PropertyAddress, SetVisible_FunctionAddress, "vis");
		SetVisible_vis_Offset = NativeReflection.GetPropertyOffset(SetVisible_FunctionAddress, "vis");
		SetVisible_vis_IsValid = NativeReflection.ValidatePropertyClass(SetVisible_FunctionAddress, "vis", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref SetVisible_child_PropertyAddress, SetVisible_FunctionAddress, "child");
		SetVisible_child_Offset = NativeReflection.GetPropertyOffset(SetVisible_FunctionAddress, "child");
		SetVisible_child_IsValid = NativeReflection.ValidatePropertyClass(SetVisible_FunctionAddress, "child", Classes.FBoolProperty);
		SetVisible_IsValid = SetVisible_FunctionAddress != IntPtr.Zero && SetVisible_vis_IsValid && SetVisible_child_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.DispLibDebugTest_SpawnAttachedNiagara:SetVisible", SetVisible_IsValid);
	}

	static DispLibDebugTest_SpawnAttachedNiagara()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(DispLibDebugTest_SpawnAttachedNiagara)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(DispLibDebugTest_SpawnAttachedNiagara));
	}
}
