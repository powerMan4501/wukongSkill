using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Landscape;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/FuncLibEditor.GSEditorLandscapeManager", "FuncLibEditor", UnrealModuleType.Game)]
public class AGSEditorLandscapeManager : AActor
{
	private static bool TargetProxy_IsValid;

	private static int TargetProxy_Offset;

	private static bool LandscapeReader_IsValid;

	private static int LandscapeReader_Offset;

	private static bool SetLandscape_IsValid;

	private static IntPtr SetLandscape_FunctionAddress;

	private static int SetLandscape_ParamsSize;

	private static bool SetLandscape_Proxy_IsValid;

	private static FFieldAddress SetLandscape_Proxy_PropertyAddress;

	private static int SetLandscape_Proxy_Offset;

	private static bool CacheLandscapeReader_IsValid;

	private static IntPtr CacheLandscapeReader_FunctionAddress;

	private static int CacheLandscapeReader_ParamsSize;

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLandscapeManager:TargetProxy")]
	public ALandscapeProxy TargetProxy
	{
		get
		{
			CheckDestroyed();
			if (!TargetProxy_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSEditorLandscapeManager:TargetProxy");
				return null;
			}
			return UObjectMarshaler<ALandscapeProxy>.FromNative(IntPtr.Add(base.Address, TargetProxy_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TargetProxy_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSEditorLandscapeManager:TargetProxy");
			}
			else
			{
				UObjectMarshaler<ALandscapeProxy>.ToNative(IntPtr.Add(base.Address, TargetProxy_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLandscapeManager:LandscapeReader")]
	public ULandscapeReader LandscapeReader
	{
		get
		{
			CheckDestroyed();
			if (!LandscapeReader_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSEditorLandscapeManager:LandscapeReader");
				return null;
			}
			return UObjectMarshaler<ULandscapeReader>.FromNative(IntPtr.Add(base.Address, LandscapeReader_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LandscapeReader_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSEditorLandscapeManager:LandscapeReader");
			}
			else
			{
				UObjectMarshaler<ULandscapeReader>.ToNative(IntPtr.Add(base.Address, LandscapeReader_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLandscapeManager:SetLandscape")]
	public unsafe void SetLandscape(ALandscapeProxy Proxy)
	{
		CheckDestroyed();
		if (!SetLandscape_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLandscapeManager:SetLandscape");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLandscape_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLandscape_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ALandscapeProxy>.ToNative(IntPtr.Add(intPtr, SetLandscape_Proxy_Offset), 0, SetLandscape_Proxy_PropertyAddress.Address, Proxy);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLandscape_FunctionAddress, intPtr, SetLandscape_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLandscapeManager:CacheLandscapeReader")]
	public unsafe void CacheLandscapeReader()
	{
		CheckDestroyed();
		if (!CacheLandscapeReader_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLandscapeManager:CacheLandscapeReader");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CacheLandscapeReader_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CacheLandscapeReader_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: CacheLandscapeReader_FunctionAddress, argsSize: CacheLandscapeReader_ParamsSize);
	}

	static AGSEditorLandscapeManager()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(AGSEditorLandscapeManager)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AGSEditorLandscapeManager));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/FuncLibEditor.GSEditorLandscapeManager");
		TargetProxy_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TargetProxy");
		TargetProxy_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TargetProxy", Classes.FObjectProperty);
		LandscapeReader_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LandscapeReader");
		LandscapeReader_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LandscapeReader", Classes.FObjectProperty);
		SetLandscape_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetLandscape");
		SetLandscape_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLandscape_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLandscape_Proxy_PropertyAddress, SetLandscape_FunctionAddress, "Proxy");
		SetLandscape_Proxy_Offset = NativeReflectionCached.GetPropertyOffset(SetLandscape_FunctionAddress, "Proxy");
		SetLandscape_Proxy_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLandscape_FunctionAddress, "Proxy", Classes.FObjectProperty);
		SetLandscape_IsValid = SetLandscape_FunctionAddress != IntPtr.Zero && SetLandscape_Proxy_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLandscapeManager:SetLandscape", SetLandscape_IsValid);
		CacheLandscapeReader_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CacheLandscapeReader");
		CacheLandscapeReader_ParamsSize = NativeReflection.GetFunctionParamsSize(CacheLandscapeReader_FunctionAddress);
		CacheLandscapeReader_IsValid = CacheLandscapeReader_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLandscapeManager:CacheLandscapeReader", CacheLandscapeReader_IsValid);
	}
}
