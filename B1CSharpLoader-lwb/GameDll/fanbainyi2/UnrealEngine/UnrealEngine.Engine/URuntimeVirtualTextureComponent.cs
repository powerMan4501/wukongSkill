using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Engine.RuntimeVirtualTextureComponent", "Engine", UnrealModuleType.Engine)]
public class URuntimeVirtualTextureComponent : USceneComponent
{
	private static bool VirtualTexture_IsValid;

	private static int VirtualTexture_Offset;

	private static bool StreamingTexture_IsValid;

	private static int StreamingTexture_Offset;

	private static bool BuildDebugStreamingMips_IsValid;

	private static FFieldAddress BuildDebugStreamingMips_PropertyAddress;

	private static int BuildDebugStreamingMips_Offset;

	private static bool Invalidate_IsValid;

	private static IntPtr Invalidate_FunctionAddress;

	private static int Invalidate_ParamsSize;

	private static bool Invalidate_WorldBounds_IsValid;

	private static FFieldAddress Invalidate_WorldBounds_PropertyAddress;

	private static int Invalidate_WorldBounds_Offset;

	[UProperty(Flags = (PropFlags)12534502349865493uL)]
	[UMetaPath("/Script/Engine.RuntimeVirtualTextureComponent:VirtualTexture")]
	protected URuntimeVirtualTexture VirtualTexture
	{
		get
		{
			CheckDestroyed();
			if (!VirtualTexture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.RuntimeVirtualTextureComponent:VirtualTexture");
				return null;
			}
			return UObjectMarshaler<URuntimeVirtualTexture>.FromNative(IntPtr.Add(base.Address, VirtualTexture_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VirtualTexture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.RuntimeVirtualTextureComponent:VirtualTexture");
			}
			else
			{
				UObjectMarshaler<URuntimeVirtualTexture>.ToNative(IntPtr.Add(base.Address, VirtualTexture_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)12534502349865493uL)]
	[UMetaPath("/Script/Engine.RuntimeVirtualTextureComponent:StreamingTexture")]
	protected UVirtualTextureBuilder StreamingTexture
	{
		get
		{
			CheckDestroyed();
			if (!StreamingTexture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.RuntimeVirtualTextureComponent:StreamingTexture");
				return null;
			}
			return UObjectMarshaler<UVirtualTextureBuilder>.FromNative(IntPtr.Add(base.Address, StreamingTexture_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StreamingTexture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.RuntimeVirtualTextureComponent:StreamingTexture");
			}
			else
			{
				UObjectMarshaler<UVirtualTextureBuilder>.ToNative(IntPtr.Add(base.Address, StreamingTexture_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11272263001186837uL)]
	[UMetaPath("/Script/Engine.RuntimeVirtualTextureComponent:bBuildDebugStreamingMips")]
	protected bool BuildDebugStreamingMips
	{
		get
		{
			CheckDestroyed();
			if (!BuildDebugStreamingMips_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.RuntimeVirtualTextureComponent:bBuildDebugStreamingMips");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, BuildDebugStreamingMips_Offset), 0, BuildDebugStreamingMips_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!BuildDebugStreamingMips_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.RuntimeVirtualTextureComponent:bBuildDebugStreamingMips");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, BuildDebugStreamingMips_Offset), 0, BuildDebugStreamingMips_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/Engine.RuntimeVirtualTextureComponent:Invalidate")]
	public unsafe void Invalidate(FBoxSphereBounds WorldBounds)
	{
		CheckDestroyed();
		if (!Invalidate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.RuntimeVirtualTextureComponent:Invalidate");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Invalidate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Invalidate_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FBoxSphereBounds>.ToNative(IntPtr.Add(intPtr, Invalidate_WorldBounds_Offset), 0, Invalidate_WorldBounds_PropertyAddress.Address, WorldBounds);
		NativeReflection.InvokeFunctionOptimized(base.Address, Invalidate_FunctionAddress, intPtr, Invalidate_ParamsSize);
	}

	static URuntimeVirtualTextureComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(URuntimeVirtualTextureComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(URuntimeVirtualTextureComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.RuntimeVirtualTextureComponent");
		VirtualTexture_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VirtualTexture");
		VirtualTexture_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VirtualTexture", Classes.FObjectProperty);
		StreamingTexture_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StreamingTexture");
		StreamingTexture_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StreamingTexture", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BuildDebugStreamingMips_PropertyAddress, intPtr, "bBuildDebugStreamingMips");
		BuildDebugStreamingMips_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bBuildDebugStreamingMips");
		BuildDebugStreamingMips_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bBuildDebugStreamingMips", Classes.FBoolProperty);
		Invalidate_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Invalidate");
		Invalidate_ParamsSize = NativeReflection.GetFunctionParamsSize(Invalidate_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Invalidate_WorldBounds_PropertyAddress, Invalidate_FunctionAddress, "WorldBounds");
		Invalidate_WorldBounds_Offset = NativeReflectionCached.GetPropertyOffset(Invalidate_FunctionAddress, "WorldBounds");
		Invalidate_WorldBounds_IsValid = NativeReflectionCached.ValidatePropertyClass(Invalidate_FunctionAddress, "WorldBounds", Classes.FStructProperty);
		Invalidate_IsValid = Invalidate_FunctionAddress != IntPtr.Zero && Invalidate_WorldBounds_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.RuntimeVirtualTextureComponent:Invalidate", Invalidate_IsValid);
	}
}
