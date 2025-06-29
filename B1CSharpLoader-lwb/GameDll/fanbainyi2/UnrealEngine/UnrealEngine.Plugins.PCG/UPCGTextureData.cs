using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGTextureData", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGTextureData : UPCGBaseTextureData
{
	private static bool Texture_IsValid;

	private static int Texture_Offset;

	private static bool Initialize_IsValid;

	private static IntPtr Initialize_FunctionAddress;

	private static int Initialize_ParamsSize;

	private static bool Initialize_InTexture_IsValid;

	private static FFieldAddress Initialize_InTexture_PropertyAddress;

	private static int Initialize_InTexture_Offset;

	private static bool Initialize_InTransform_IsValid;

	private static FFieldAddress Initialize_InTransform_PropertyAddress;

	private static int Initialize_InTransform_Offset;

	[UProperty(Flags = (PropFlags)7881369141248533uL)]
	[UMetaPath("/Script/PCG.PCGTextureData:Texture")]
	public TWeakObject<UTexture2D> Texture
	{
		get
		{
			CheckDestroyed();
			if (!Texture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGTextureData:Texture");
				return default(TWeakObject<UTexture2D>);
			}
			return TWeakObjectMarshaler<UTexture2D>.FromNative(IntPtr.Add(base.Address, Texture_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Texture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGTextureData:Texture");
			}
			else
			{
				TWeakObjectMarshaler<UTexture2D>.ToNative(IntPtr.Add(base.Address, Texture_Offset), value);
			}
		}
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/PCG.PCGTextureData:Initialize")]
	public unsafe void Initialize(UTexture2D InTexture, FTransform InTransform)
	{
		CheckDestroyed();
		if (!Initialize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGTextureData:Initialize");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Initialize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Initialize_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UTexture2D>.ToNative(IntPtr.Add(intPtr, Initialize_InTexture_Offset), 0, Initialize_InTexture_PropertyAddress.Address, InTexture);
		NativeReflection.InitializeValue_InContainer(Initialize_InTransform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, Initialize_InTransform_Offset), 0, Initialize_InTransform_PropertyAddress.Address, InTransform);
		NativeReflection.InvokeFunctionOptimized(base.Address, Initialize_FunctionAddress, intPtr, Initialize_ParamsSize);
	}

	static UPCGTextureData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGTextureData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGTextureData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/PCG.PCGTextureData");
		Texture_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Texture");
		Texture_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Texture", Classes.FWeakObjectProperty);
		Initialize_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Initialize");
		Initialize_ParamsSize = NativeReflection.GetFunctionParamsSize(Initialize_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Initialize_InTexture_PropertyAddress, Initialize_FunctionAddress, "InTexture");
		Initialize_InTexture_Offset = NativeReflectionCached.GetPropertyOffset(Initialize_FunctionAddress, "InTexture");
		Initialize_InTexture_IsValid = NativeReflectionCached.ValidatePropertyClass(Initialize_FunctionAddress, "InTexture", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref Initialize_InTransform_PropertyAddress, Initialize_FunctionAddress, "InTransform");
		Initialize_InTransform_Offset = NativeReflectionCached.GetPropertyOffset(Initialize_FunctionAddress, "InTransform");
		Initialize_InTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(Initialize_FunctionAddress, "InTransform", Classes.FStructProperty);
		Initialize_IsValid = Initialize_FunctionAddress != IntPtr.Zero && Initialize_InTexture_IsValid && Initialize_InTransform_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGTextureData:Initialize", Initialize_IsValid);
	}
}
