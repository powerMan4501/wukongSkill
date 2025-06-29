using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)819990692uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Engine.HeterogeneousVolumeComponent", "Engine", UnrealModuleType.Engine)]
public class UHeterogeneousVolumeComponent : UMeshComponent
{
	private static bool VolumeResolution_IsValid;

	private static int VolumeResolution_Offset;

	private static bool Frame_IsValid;

	private static int Frame_Offset;

	private static bool UseMBOIT_IsValid;

	private static FFieldAddress UseMBOIT_PropertyAddress;

	private static int UseMBOIT_Offset;

	private static bool RenderPriority_IsValid;

	private static int RenderPriority_Offset;

	private static bool IndirectLightingStrength_IsValid;

	private static int IndirectLightingStrength_Offset;

	private static bool UseLightingCache_IsValid;

	private static FFieldAddress UseLightingCache_PropertyAddress;

	private static int UseLightingCache_Offset;

	private static bool ShadowStrength_IsValid;

	private static int ShadowStrength_Offset;

	private static bool SetStartFrame_IsValid;

	private static IntPtr SetStartFrame_FunctionAddress;

	private static int SetStartFrame_ParamsSize;

	private static bool SetStartFrame_NewValue_IsValid;

	private static FFieldAddress SetStartFrame_NewValue_PropertyAddress;

	private static int SetStartFrame_NewValue_Offset;

	private static bool SetPlaying_IsValid;

	private static IntPtr SetPlaying_FunctionAddress;

	private static int SetPlaying_ParamsSize;

	private static bool SetPlaying_NewValue_IsValid;

	private static FFieldAddress SetPlaying_NewValue_PropertyAddress;

	private static int SetPlaying_NewValue_Offset;

	private static bool SetLooping_IsValid;

	private static IntPtr SetLooping_FunctionAddress;

	private static int SetLooping_ParamsSize;

	private static bool SetLooping_NewValue_IsValid;

	private static FFieldAddress SetLooping_NewValue_PropertyAddress;

	private static int SetLooping_NewValue_Offset;

	private static bool SetFrameRate_IsValid;

	private static IntPtr SetFrameRate_FunctionAddress;

	private static int SetFrameRate_ParamsSize;

	private static bool SetFrameRate_NewValue_IsValid;

	private static FFieldAddress SetFrameRate_NewValue_PropertyAddress;

	private static int SetFrameRate_NewValue_Offset;

	private static bool SetFrame_IsValid;

	private static IntPtr SetFrame_FunctionAddress;

	private static int SetFrame_ParamsSize;

	private static bool SetFrame_NewValue_IsValid;

	private static FFieldAddress SetFrame_NewValue_PropertyAddress;

	private static int SetFrame_NewValue_Offset;

	private static bool SetEndFrame_IsValid;

	private static IntPtr SetEndFrame_FunctionAddress;

	private static int SetEndFrame_ParamsSize;

	private static bool SetEndFrame_NewValue_IsValid;

	private static FFieldAddress SetEndFrame_NewValue_PropertyAddress;

	private static int SetEndFrame_NewValue_Offset;

	private static bool Play_IsValid;

	private static IntPtr Play_FunctionAddress;

	private static int Play_ParamsSize;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.HeterogeneousVolumeComponent:VolumeResolution")]
	public FIntVector VolumeResolution
	{
		get
		{
			CheckDestroyed();
			if (!VolumeResolution_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.HeterogeneousVolumeComponent:VolumeResolution");
				return default(FIntVector);
			}
			return BlittableTypeMarshaler<FIntVector>.FromNative(IntPtr.Add(base.Address, VolumeResolution_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VolumeResolution_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.HeterogeneousVolumeComponent:VolumeResolution");
			}
			else
			{
				BlittableTypeMarshaler<FIntVector>.ToNative(IntPtr.Add(base.Address, VolumeResolution_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.HeterogeneousVolumeComponent:Frame")]
	public float Frame
	{
		get
		{
			CheckDestroyed();
			if (!Frame_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.HeterogeneousVolumeComponent:Frame");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Frame_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Frame_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.HeterogeneousVolumeComponent:Frame");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Frame_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/Engine.HeterogeneousVolumeComponent:UseMBOIT")]
	public bool UseMBOIT
	{
		get
		{
			CheckDestroyed();
			if (!UseMBOIT_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.HeterogeneousVolumeComponent:UseMBOIT");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseMBOIT_Offset), 0, UseMBOIT_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseMBOIT_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.HeterogeneousVolumeComponent:UseMBOIT");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseMBOIT_Offset), 0, UseMBOIT_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.HeterogeneousVolumeComponent:RenderPriority")]
	public int RenderPriority
	{
		get
		{
			CheckDestroyed();
			if (!RenderPriority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.HeterogeneousVolumeComponent:RenderPriority");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, RenderPriority_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RenderPriority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.HeterogeneousVolumeComponent:RenderPriority");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, RenderPriority_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.HeterogeneousVolumeComponent:IndirectLightingStrength")]
	public float IndirectLightingStrength
	{
		get
		{
			CheckDestroyed();
			if (!IndirectLightingStrength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.HeterogeneousVolumeComponent:IndirectLightingStrength");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, IndirectLightingStrength_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IndirectLightingStrength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.HeterogeneousVolumeComponent:IndirectLightingStrength");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, IndirectLightingStrength_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.HeterogeneousVolumeComponent:UseLightingCache")]
	public bool UseLightingCache
	{
		get
		{
			CheckDestroyed();
			if (!UseLightingCache_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.HeterogeneousVolumeComponent:UseLightingCache");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseLightingCache_Offset), 0, UseLightingCache_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseLightingCache_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.HeterogeneousVolumeComponent:UseLightingCache");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseLightingCache_Offset), 0, UseLightingCache_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.HeterogeneousVolumeComponent:ShadowStrength")]
	public float ShadowStrength
	{
		get
		{
			CheckDestroyed();
			if (!ShadowStrength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.HeterogeneousVolumeComponent:ShadowStrength");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ShadowStrength_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ShadowStrength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.HeterogeneousVolumeComponent:ShadowStrength");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ShadowStrength_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240963u)]
	[UMetaPath("/Script/Engine.HeterogeneousVolumeComponent:SetStartFrame")]
	public unsafe void SetStartFrame(float NewValue)
	{
		CheckDestroyed();
		if (!SetStartFrame_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.HeterogeneousVolumeComponent:SetStartFrame");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetStartFrame_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetStartFrame_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetStartFrame_NewValue_Offset), 0, SetStartFrame_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetStartFrame_FunctionAddress, intPtr, SetStartFrame_ParamsSize);
	}

	[UFunction(Flags = 67240963u)]
	[UMetaPath("/Script/Engine.HeterogeneousVolumeComponent:SetPlaying")]
	public unsafe void SetPlaying(bool NewValue)
	{
		CheckDestroyed();
		if (!SetPlaying_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.HeterogeneousVolumeComponent:SetPlaying");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPlaying_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPlaying_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetPlaying_NewValue_Offset), 0, SetPlaying_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPlaying_FunctionAddress, intPtr, SetPlaying_ParamsSize);
	}

	[UFunction(Flags = 67240963u)]
	[UMetaPath("/Script/Engine.HeterogeneousVolumeComponent:SetLooping")]
	public unsafe void SetLooping(bool NewValue)
	{
		CheckDestroyed();
		if (!SetLooping_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.HeterogeneousVolumeComponent:SetLooping");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLooping_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLooping_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetLooping_NewValue_Offset), 0, SetLooping_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLooping_FunctionAddress, intPtr, SetLooping_ParamsSize);
	}

	[UFunction(Flags = 67240963u)]
	[UMetaPath("/Script/Engine.HeterogeneousVolumeComponent:SetFrameRate")]
	public unsafe void SetFrameRate(float NewValue)
	{
		CheckDestroyed();
		if (!SetFrameRate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.HeterogeneousVolumeComponent:SetFrameRate");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetFrameRate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetFrameRate_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetFrameRate_NewValue_Offset), 0, SetFrameRate_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetFrameRate_FunctionAddress, intPtr, SetFrameRate_ParamsSize);
	}

	[UFunction(Flags = 67240963u)]
	[UMetaPath("/Script/Engine.HeterogeneousVolumeComponent:SetFrame")]
	public unsafe void SetFrame(float NewValue)
	{
		CheckDestroyed();
		if (!SetFrame_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.HeterogeneousVolumeComponent:SetFrame");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetFrame_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetFrame_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetFrame_NewValue_Offset), 0, SetFrame_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetFrame_FunctionAddress, intPtr, SetFrame_ParamsSize);
	}

	[UFunction(Flags = 67240963u)]
	[UMetaPath("/Script/Engine.HeterogeneousVolumeComponent:SetEndFrame")]
	public unsafe void SetEndFrame(float NewValue)
	{
		CheckDestroyed();
		if (!SetEndFrame_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.HeterogeneousVolumeComponent:SetEndFrame");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetEndFrame_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetEndFrame_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetEndFrame_NewValue_Offset), 0, SetEndFrame_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetEndFrame_FunctionAddress, intPtr, SetEndFrame_ParamsSize);
	}

	[UFunction(Flags = 67240963u)]
	[UMetaPath("/Script/Engine.HeterogeneousVolumeComponent:Play")]
	public unsafe void Play()
	{
		CheckDestroyed();
		if (!Play_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.HeterogeneousVolumeComponent:Play");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Play_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Play_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Play_FunctionAddress, argsSize: Play_ParamsSize);
	}

	static UHeterogeneousVolumeComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UHeterogeneousVolumeComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UHeterogeneousVolumeComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.HeterogeneousVolumeComponent");
		VolumeResolution_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VolumeResolution");
		VolumeResolution_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VolumeResolution", Classes.FStructProperty);
		Frame_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Frame");
		Frame_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Frame", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref UseMBOIT_PropertyAddress, intPtr, "UseMBOIT");
		UseMBOIT_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UseMBOIT");
		UseMBOIT_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UseMBOIT", Classes.FBoolProperty);
		RenderPriority_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RenderPriority");
		RenderPriority_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RenderPriority", Classes.FIntProperty);
		IndirectLightingStrength_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "IndirectLightingStrength");
		IndirectLightingStrength_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "IndirectLightingStrength", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref UseLightingCache_PropertyAddress, intPtr, "UseLightingCache");
		UseLightingCache_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UseLightingCache");
		UseLightingCache_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UseLightingCache", Classes.FBoolProperty);
		ShadowStrength_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ShadowStrength");
		ShadowStrength_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ShadowStrength", Classes.FFloatProperty);
		SetStartFrame_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetStartFrame");
		SetStartFrame_ParamsSize = NativeReflection.GetFunctionParamsSize(SetStartFrame_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetStartFrame_NewValue_PropertyAddress, SetStartFrame_FunctionAddress, "NewValue");
		SetStartFrame_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetStartFrame_FunctionAddress, "NewValue");
		SetStartFrame_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStartFrame_FunctionAddress, "NewValue", Classes.FFloatProperty);
		SetStartFrame_IsValid = SetStartFrame_FunctionAddress != IntPtr.Zero && SetStartFrame_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.HeterogeneousVolumeComponent:SetStartFrame", SetStartFrame_IsValid);
		SetPlaying_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetPlaying");
		SetPlaying_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPlaying_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPlaying_NewValue_PropertyAddress, SetPlaying_FunctionAddress, "NewValue");
		SetPlaying_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetPlaying_FunctionAddress, "NewValue");
		SetPlaying_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPlaying_FunctionAddress, "NewValue", Classes.FBoolProperty);
		SetPlaying_IsValid = SetPlaying_FunctionAddress != IntPtr.Zero && SetPlaying_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.HeterogeneousVolumeComponent:SetPlaying", SetPlaying_IsValid);
		SetLooping_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetLooping");
		SetLooping_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLooping_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLooping_NewValue_PropertyAddress, SetLooping_FunctionAddress, "NewValue");
		SetLooping_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetLooping_FunctionAddress, "NewValue");
		SetLooping_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLooping_FunctionAddress, "NewValue", Classes.FBoolProperty);
		SetLooping_IsValid = SetLooping_FunctionAddress != IntPtr.Zero && SetLooping_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.HeterogeneousVolumeComponent:SetLooping", SetLooping_IsValid);
		SetFrameRate_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetFrameRate");
		SetFrameRate_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFrameRate_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetFrameRate_NewValue_PropertyAddress, SetFrameRate_FunctionAddress, "NewValue");
		SetFrameRate_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetFrameRate_FunctionAddress, "NewValue");
		SetFrameRate_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFrameRate_FunctionAddress, "NewValue", Classes.FFloatProperty);
		SetFrameRate_IsValid = SetFrameRate_FunctionAddress != IntPtr.Zero && SetFrameRate_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.HeterogeneousVolumeComponent:SetFrameRate", SetFrameRate_IsValid);
		SetFrame_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetFrame");
		SetFrame_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFrame_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetFrame_NewValue_PropertyAddress, SetFrame_FunctionAddress, "NewValue");
		SetFrame_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetFrame_FunctionAddress, "NewValue");
		SetFrame_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFrame_FunctionAddress, "NewValue", Classes.FFloatProperty);
		SetFrame_IsValid = SetFrame_FunctionAddress != IntPtr.Zero && SetFrame_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.HeterogeneousVolumeComponent:SetFrame", SetFrame_IsValid);
		SetEndFrame_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetEndFrame");
		SetEndFrame_ParamsSize = NativeReflection.GetFunctionParamsSize(SetEndFrame_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetEndFrame_NewValue_PropertyAddress, SetEndFrame_FunctionAddress, "NewValue");
		SetEndFrame_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetEndFrame_FunctionAddress, "NewValue");
		SetEndFrame_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetEndFrame_FunctionAddress, "NewValue", Classes.FFloatProperty);
		SetEndFrame_IsValid = SetEndFrame_FunctionAddress != IntPtr.Zero && SetEndFrame_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.HeterogeneousVolumeComponent:SetEndFrame", SetEndFrame_IsValid);
		Play_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Play");
		Play_ParamsSize = NativeReflection.GetFunctionParamsSize(Play_FunctionAddress);
		Play_IsValid = Play_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.HeterogeneousVolumeComponent:Play", Play_IsValid);
	}
}
