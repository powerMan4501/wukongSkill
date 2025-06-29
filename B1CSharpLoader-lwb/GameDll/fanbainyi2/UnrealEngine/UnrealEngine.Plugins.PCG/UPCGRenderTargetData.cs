using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGRenderTargetData", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGRenderTargetData : UPCGBaseTextureData
{
	private static bool RenderTarget_IsValid;

	private static int RenderTarget_Offset;

	private static bool Initialize_IsValid;

	private static IntPtr Initialize_FunctionAddress;

	private static int Initialize_ParamsSize;

	private static bool Initialize_InRenderTarget_IsValid;

	private static FFieldAddress Initialize_InRenderTarget_PropertyAddress;

	private static int Initialize_InRenderTarget_Offset;

	private static bool Initialize_InTransform_IsValid;

	private static FFieldAddress Initialize_InTransform_PropertyAddress;

	private static int Initialize_InTransform_Offset;

	[UProperty(Flags = (PropFlags)7881369141248533uL)]
	[UMetaPath("/Script/PCG.PCGRenderTargetData:RenderTarget")]
	public UTextureRenderTarget2D RenderTarget
	{
		get
		{
			CheckDestroyed();
			if (!RenderTarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGRenderTargetData:RenderTarget");
				return null;
			}
			return UObjectMarshaler<UTextureRenderTarget2D>.FromNative(IntPtr.Add(base.Address, RenderTarget_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RenderTarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGRenderTargetData:RenderTarget");
			}
			else
			{
				UObjectMarshaler<UTextureRenderTarget2D>.ToNative(IntPtr.Add(base.Address, RenderTarget_Offset), value);
			}
		}
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/PCG.PCGRenderTargetData:Initialize")]
	public unsafe void Initialize(UTextureRenderTarget2D InRenderTarget, FTransform InTransform)
	{
		CheckDestroyed();
		if (!Initialize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGRenderTargetData:Initialize");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Initialize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Initialize_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UTextureRenderTarget2D>.ToNative(IntPtr.Add(intPtr, Initialize_InRenderTarget_Offset), 0, Initialize_InRenderTarget_PropertyAddress.Address, InRenderTarget);
		NativeReflection.InitializeValue_InContainer(Initialize_InTransform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, Initialize_InTransform_Offset), 0, Initialize_InTransform_PropertyAddress.Address, InTransform);
		NativeReflection.InvokeFunctionOptimized(base.Address, Initialize_FunctionAddress, intPtr, Initialize_ParamsSize);
	}

	static UPCGRenderTargetData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGRenderTargetData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGRenderTargetData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/PCG.PCGRenderTargetData");
		RenderTarget_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RenderTarget");
		RenderTarget_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RenderTarget", Classes.FObjectProperty);
		Initialize_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Initialize");
		Initialize_ParamsSize = NativeReflection.GetFunctionParamsSize(Initialize_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Initialize_InRenderTarget_PropertyAddress, Initialize_FunctionAddress, "InRenderTarget");
		Initialize_InRenderTarget_Offset = NativeReflectionCached.GetPropertyOffset(Initialize_FunctionAddress, "InRenderTarget");
		Initialize_InRenderTarget_IsValid = NativeReflectionCached.ValidatePropertyClass(Initialize_FunctionAddress, "InRenderTarget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref Initialize_InTransform_PropertyAddress, Initialize_FunctionAddress, "InTransform");
		Initialize_InTransform_Offset = NativeReflectionCached.GetPropertyOffset(Initialize_FunctionAddress, "InTransform");
		Initialize_InTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(Initialize_FunctionAddress, "InTransform", Classes.FStructProperty);
		Initialize_IsValid = Initialize_FunctionAddress != IntPtr.Zero && Initialize_InRenderTarget_IsValid && Initialize_InTransform_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGRenderTargetData:Initialize", Initialize_IsValid);
	}
}
