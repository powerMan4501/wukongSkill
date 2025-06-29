using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Plugins.TressFX;

[UClass(Flags = (ClassFlags)821039268uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/TressFX.TressFXSDFComponent", "TressFX", UnrealModuleType.GamePlugin)]
public class UTressFXSDFComponent : UMeshComponent, ILODSyncInterface, IInterface
{
	private static bool EnableSDF_IsValid;

	private static FFieldAddress EnableSDF_PropertyAddress;

	private static int EnableSDF_Offset;

	private static bool TressFXMeshAsset_IsValid;

	private static int TressFXMeshAsset_Offset;

	private static bool SetTressFXMeshAsset_IsValid;

	private static IntPtr SetTressFXMeshAsset_FunctionAddress;

	private static int SetTressFXMeshAsset_ParamsSize;

	private static bool SetTressFXMeshAsset_Asset_IsValid;

	private static FFieldAddress SetTressFXMeshAsset_Asset_PropertyAddress;

	private static int SetTressFXMeshAsset_Asset_Offset;

	[UProperty(Flags = (PropFlags)6759875870720533uL)]
	[UMetaPath("/Script/TressFX.TressFXSDFComponent:EnableSDF")]
	public bool EnableSDF
	{
		get
		{
			CheckDestroyed();
			if (!EnableSDF_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/TressFX.TressFXSDFComponent:EnableSDF");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableSDF_Offset), 0, EnableSDF_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableSDF_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/TressFX.TressFXSDFComponent:EnableSDF");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableSDF_Offset), 0, EnableSDF_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/TressFX.TressFXSDFComponent:TressFXMeshAsset")]
	public UTressFXMeshAsset TressFXMeshAsset
	{
		get
		{
			CheckDestroyed();
			if (!TressFXMeshAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/TressFX.TressFXSDFComponent:TressFXMeshAsset");
				return null;
			}
			return UObjectMarshaler<UTressFXMeshAsset>.FromNative(IntPtr.Add(base.Address, TressFXMeshAsset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TressFXMeshAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/TressFX.TressFXSDFComponent:TressFXMeshAsset");
			}
			else
			{
				UObjectMarshaler<UTressFXMeshAsset>.ToNative(IntPtr.Add(base.Address, TressFXMeshAsset_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/TressFX.TressFXSDFComponent:SetTressFXMeshAsset")]
	public unsafe void SetTressFXMeshAsset(UTressFXMeshAsset Asset)
	{
		CheckDestroyed();
		if (!SetTressFXMeshAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/TressFX.TressFXSDFComponent:SetTressFXMeshAsset");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTressFXMeshAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTressFXMeshAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UTressFXMeshAsset>.ToNative(IntPtr.Add(intPtr, SetTressFXMeshAsset_Asset_Offset), 0, SetTressFXMeshAsset_Asset_PropertyAddress.Address, Asset);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetTressFXMeshAsset_FunctionAddress, intPtr, SetTressFXMeshAsset_ParamsSize);
	}

	static UTressFXSDFComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UTressFXSDFComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UTressFXSDFComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/TressFX.TressFXSDFComponent");
		NativeReflectionCached.GetPropertyRef(ref EnableSDF_PropertyAddress, intPtr, "EnableSDF");
		EnableSDF_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "EnableSDF");
		EnableSDF_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "EnableSDF", Classes.FBoolProperty);
		TressFXMeshAsset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TressFXMeshAsset");
		TressFXMeshAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TressFXMeshAsset", Classes.FObjectProperty);
		SetTressFXMeshAsset_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetTressFXMeshAsset");
		SetTressFXMeshAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTressFXMeshAsset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTressFXMeshAsset_Asset_PropertyAddress, SetTressFXMeshAsset_FunctionAddress, "Asset");
		SetTressFXMeshAsset_Asset_Offset = NativeReflectionCached.GetPropertyOffset(SetTressFXMeshAsset_FunctionAddress, "Asset");
		SetTressFXMeshAsset_Asset_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTressFXMeshAsset_FunctionAddress, "Asset", Classes.FObjectProperty);
		SetTressFXMeshAsset_IsValid = SetTressFXMeshAsset_FunctionAddress != IntPtr.Zero && SetTressFXMeshAsset_Asset_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/TressFX.TressFXSDFComponent:SetTressFXMeshAsset", SetTressFXMeshAsset_IsValid);
	}
}
