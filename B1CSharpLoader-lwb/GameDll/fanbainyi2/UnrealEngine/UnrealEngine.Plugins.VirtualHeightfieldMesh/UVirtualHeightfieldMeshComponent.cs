using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.VirtualHeightfieldMesh;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/VirtualHeightfieldMesh.VirtualHeightfieldMeshComponent", "VirtualHeightfieldMesh", UnrealModuleType.EnginePlugin)]
public class UVirtualHeightfieldMeshComponent : UPrimitiveComponent
{
	private static bool MinMaxTexture_IsValid;

	private static int MinMaxTexture_Offset;

	private static bool NumMinMaxTextureBuildLevels_IsValid;

	private static int NumMinMaxTextureBuildLevels_Offset;

	private static bool SetDynamicLodBiasSize_IsValid;

	private static IntPtr SetDynamicLodBiasSize_FunctionAddress;

	private static int SetDynamicLodBiasSize_ParamsSize;

	private static bool SetDynamicLodBiasSize_BiasSize_IsValid;

	private static FFieldAddress SetDynamicLodBiasSize_BiasSize_PropertyAddress;

	private static int SetDynamicLodBiasSize_BiasSize_Offset;

	private static bool SetDynamicLodBiasCenter_IsValid;

	private static IntPtr SetDynamicLodBiasCenter_FunctionAddress;

	private static int SetDynamicLodBiasCenter_ParamsSize;

	private static bool SetDynamicLodBiasCenter_Position_IsValid;

	private static FFieldAddress SetDynamicLodBiasCenter_Position_PropertyAddress;

	private static int SetDynamicLodBiasCenter_Position_Offset;

	[UProperty(Flags = (PropFlags)11267864954667541uL)]
	[UMetaPath("/Script/VirtualHeightfieldMesh.VirtualHeightfieldMeshComponent:MinMaxTexture")]
	protected UHeightfieldMinMaxTexture MinMaxTexture
	{
		get
		{
			CheckDestroyed();
			if (!MinMaxTexture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/VirtualHeightfieldMesh.VirtualHeightfieldMeshComponent:MinMaxTexture");
				return null;
			}
			return UObjectMarshaler<UHeightfieldMinMaxTexture>.FromNative(IntPtr.Add(base.Address, MinMaxTexture_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MinMaxTexture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/VirtualHeightfieldMesh.VirtualHeightfieldMeshComponent:MinMaxTexture");
			}
			else
			{
				UObjectMarshaler<UHeightfieldMinMaxTexture>.ToNative(IntPtr.Add(base.Address, MinMaxTexture_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667541uL)]
	[UMetaPath("/Script/VirtualHeightfieldMesh.VirtualHeightfieldMeshComponent:NumMinMaxTextureBuildLevels")]
	protected int NumMinMaxTextureBuildLevels
	{
		get
		{
			CheckDestroyed();
			if (!NumMinMaxTextureBuildLevels_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/VirtualHeightfieldMesh.VirtualHeightfieldMeshComponent:NumMinMaxTextureBuildLevels");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, NumMinMaxTextureBuildLevels_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NumMinMaxTextureBuildLevels_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/VirtualHeightfieldMesh.VirtualHeightfieldMeshComponent:NumMinMaxTextureBuildLevels");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, NumMinMaxTextureBuildLevels_Offset), value);
			}
		}
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/VirtualHeightfieldMesh.VirtualHeightfieldMeshComponent:SetDynamicLodBiasSize")]
	public unsafe void SetDynamicLodBiasSize(FVector3f BiasSize)
	{
		CheckDestroyed();
		if (!SetDynamicLodBiasSize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/VirtualHeightfieldMesh.VirtualHeightfieldMeshComponent:SetDynamicLodBiasSize");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDynamicLodBiasSize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDynamicLodBiasSize_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FVector3f.ToNative(IntPtr.Add(intPtr, SetDynamicLodBiasSize_BiasSize_Offset), 0, SetDynamicLodBiasSize_BiasSize_PropertyAddress.Address, BiasSize);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetDynamicLodBiasSize_FunctionAddress, intPtr, SetDynamicLodBiasSize_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/VirtualHeightfieldMesh.VirtualHeightfieldMeshComponent:SetDynamicLodBiasCenter")]
	public unsafe void SetDynamicLodBiasCenter(FVector3f Position)
	{
		CheckDestroyed();
		if (!SetDynamicLodBiasCenter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/VirtualHeightfieldMesh.VirtualHeightfieldMeshComponent:SetDynamicLodBiasCenter");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDynamicLodBiasCenter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDynamicLodBiasCenter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FVector3f.ToNative(IntPtr.Add(intPtr, SetDynamicLodBiasCenter_Position_Offset), 0, SetDynamicLodBiasCenter_Position_PropertyAddress.Address, Position);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetDynamicLodBiasCenter_FunctionAddress, intPtr, SetDynamicLodBiasCenter_ParamsSize);
	}

	static UVirtualHeightfieldMeshComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UVirtualHeightfieldMeshComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UVirtualHeightfieldMeshComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/VirtualHeightfieldMesh.VirtualHeightfieldMeshComponent");
		MinMaxTexture_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MinMaxTexture");
		MinMaxTexture_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MinMaxTexture", Classes.FObjectProperty);
		NumMinMaxTextureBuildLevels_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NumMinMaxTextureBuildLevels");
		NumMinMaxTextureBuildLevels_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NumMinMaxTextureBuildLevels", Classes.FIntProperty);
		SetDynamicLodBiasSize_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetDynamicLodBiasSize");
		SetDynamicLodBiasSize_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDynamicLodBiasSize_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDynamicLodBiasSize_BiasSize_PropertyAddress, SetDynamicLodBiasSize_FunctionAddress, "BiasSize");
		SetDynamicLodBiasSize_BiasSize_Offset = NativeReflectionCached.GetPropertyOffset(SetDynamicLodBiasSize_FunctionAddress, "BiasSize");
		SetDynamicLodBiasSize_BiasSize_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDynamicLodBiasSize_FunctionAddress, "BiasSize", Classes.FStructProperty);
		SetDynamicLodBiasSize_IsValid = SetDynamicLodBiasSize_FunctionAddress != IntPtr.Zero && SetDynamicLodBiasSize_BiasSize_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/VirtualHeightfieldMesh.VirtualHeightfieldMeshComponent:SetDynamicLodBiasSize", SetDynamicLodBiasSize_IsValid);
		SetDynamicLodBiasCenter_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetDynamicLodBiasCenter");
		SetDynamicLodBiasCenter_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDynamicLodBiasCenter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDynamicLodBiasCenter_Position_PropertyAddress, SetDynamicLodBiasCenter_FunctionAddress, "Position");
		SetDynamicLodBiasCenter_Position_Offset = NativeReflectionCached.GetPropertyOffset(SetDynamicLodBiasCenter_FunctionAddress, "Position");
		SetDynamicLodBiasCenter_Position_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDynamicLodBiasCenter_FunctionAddress, "Position", Classes.FStructProperty);
		SetDynamicLodBiasCenter_IsValid = SetDynamicLodBiasCenter_FunctionAddress != IntPtr.Zero && SetDynamicLodBiasCenter_Position_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/VirtualHeightfieldMesh.VirtualHeightfieldMeshComponent:SetDynamicLodBiasCenter", SetDynamicLodBiasCenter_IsValid);
	}
}
