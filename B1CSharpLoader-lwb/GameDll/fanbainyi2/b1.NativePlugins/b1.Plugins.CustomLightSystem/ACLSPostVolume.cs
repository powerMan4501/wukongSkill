using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Plugins.CustomLightSystem;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/CustomLightSystem.CLSPostVolume", "CustomLightSystem", UnrealModuleType.GamePlugin)]
public class ACLSPostVolume : ACLSBaseVolume, IInterface_PostProcessVolume, IInterface
{
	private static bool Settings_IsValid;

	private static int Settings_Offset;

	private static bool PostProcessPriority_IsValid;

	private static int PostProcessPriority_Offset;

	private static bool PostProcessBlendRadius_IsValid;

	private static int PostProcessBlendRadius_Offset;

	private static bool PostProcessBlendWeight_IsValid;

	private static int PostProcessBlendWeight_Offset;

	private static bool PostProcessEnabled_IsValid;

	private static FFieldAddress PostProcessEnabled_PropertyAddress;

	private static int PostProcessEnabled_Offset;

	private static bool AddOrUpdateBlendable_IsValid;

	private static IntPtr AddOrUpdateBlendable_FunctionAddress;

	private static int AddOrUpdateBlendable_ParamsSize;

	private static bool AddOrUpdateBlendable_InBlendableObject_IsValid;

	private static FFieldAddress AddOrUpdateBlendable_InBlendableObject_PropertyAddress;

	private static int AddOrUpdateBlendable_InBlendableObject_Offset;

	private static bool AddOrUpdateBlendable_InWeight_IsValid;

	private static FFieldAddress AddOrUpdateBlendable_InWeight_PropertyAddress;

	private static int AddOrUpdateBlendable_InWeight_Offset;

	[UProperty(Flags = (PropFlags)4503608217305093uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSPostVolume:Settings")]
	public FPostProcessSettings Settings
	{
		get
		{
			CheckDestroyed();
			if (!Settings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSPostVolume:Settings");
				return default(FPostProcessSettings);
			}
			return FPostProcessSettings.FromNative(IntPtr.Add(base.Address, Settings_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Settings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSPostVolume:Settings");
			}
			else
			{
				FPostProcessSettings.ToNative(IntPtr.Add(base.Address, Settings_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSPostVolume:PostProcessPriority")]
	public float PostProcessPriority
	{
		get
		{
			CheckDestroyed();
			if (!PostProcessPriority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSPostVolume:PostProcessPriority");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, PostProcessPriority_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PostProcessPriority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSPostVolume:PostProcessPriority");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, PostProcessPriority_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSPostVolume:PostProcessBlendRadius")]
	public float PostProcessBlendRadius
	{
		get
		{
			CheckDestroyed();
			if (!PostProcessBlendRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSPostVolume:PostProcessBlendRadius");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, PostProcessBlendRadius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PostProcessBlendRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSPostVolume:PostProcessBlendRadius");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, PostProcessBlendRadius_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSPostVolume:PostProcessBlendWeight")]
	public float PostProcessBlendWeight
	{
		get
		{
			CheckDestroyed();
			if (!PostProcessBlendWeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSPostVolume:PostProcessBlendWeight");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, PostProcessBlendWeight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PostProcessBlendWeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSPostVolume:PostProcessBlendWeight");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, PostProcessBlendWeight_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSPostVolume:bPostProcessEnabled")]
	public bool PostProcessEnabled
	{
		get
		{
			CheckDestroyed();
			if (!PostProcessEnabled_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSPostVolume:bPostProcessEnabled");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, PostProcessEnabled_Offset), 0, PostProcessEnabled_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!PostProcessEnabled_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSPostVolume:bPostProcessEnabled");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, PostProcessEnabled_Offset), 0, PostProcessEnabled_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/CustomLightSystem.CLSPostVolume:AddOrUpdateBlendable")]
	public unsafe void AddOrUpdateBlendable(IBlendableInterface InBlendableObject, float InWeight = 1f)
	{
		CheckDestroyed();
		if (!AddOrUpdateBlendable_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CustomLightSystem.CLSPostVolume:AddOrUpdateBlendable");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddOrUpdateBlendable_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddOrUpdateBlendable_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		InterfaceMarshaler<IBlendableInterface>.ToNative(IntPtr.Add(intPtr, AddOrUpdateBlendable_InBlendableObject_Offset), 0, AddOrUpdateBlendable_InBlendableObject_PropertyAddress.Address, InBlendableObject);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AddOrUpdateBlendable_InWeight_Offset), 0, AddOrUpdateBlendable_InWeight_PropertyAddress.Address, InWeight);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddOrUpdateBlendable_FunctionAddress, intPtr, AddOrUpdateBlendable_ParamsSize);
	}

	static ACLSPostVolume()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ACLSPostVolume)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ACLSPostVolume));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/CustomLightSystem.CLSPostVolume");
		Settings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Settings");
		Settings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Settings", Classes.FStructProperty);
		PostProcessPriority_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PostProcessPriority");
		PostProcessPriority_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PostProcessPriority", Classes.FFloatProperty);
		PostProcessBlendRadius_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PostProcessBlendRadius");
		PostProcessBlendRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PostProcessBlendRadius", Classes.FFloatProperty);
		PostProcessBlendWeight_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PostProcessBlendWeight");
		PostProcessBlendWeight_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PostProcessBlendWeight", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref PostProcessEnabled_PropertyAddress, intPtr, "bPostProcessEnabled");
		PostProcessEnabled_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bPostProcessEnabled");
		PostProcessEnabled_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bPostProcessEnabled", Classes.FBoolProperty);
		AddOrUpdateBlendable_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddOrUpdateBlendable");
		AddOrUpdateBlendable_ParamsSize = NativeReflection.GetFunctionParamsSize(AddOrUpdateBlendable_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddOrUpdateBlendable_InBlendableObject_PropertyAddress, AddOrUpdateBlendable_FunctionAddress, "InBlendableObject");
		AddOrUpdateBlendable_InBlendableObject_Offset = NativeReflectionCached.GetPropertyOffset(AddOrUpdateBlendable_FunctionAddress, "InBlendableObject");
		AddOrUpdateBlendable_InBlendableObject_IsValid = NativeReflectionCached.ValidatePropertyClass(AddOrUpdateBlendable_FunctionAddress, "InBlendableObject", Classes.FInterfaceProperty);
		NativeReflectionCached.GetPropertyRef(ref AddOrUpdateBlendable_InWeight_PropertyAddress, AddOrUpdateBlendable_FunctionAddress, "InWeight");
		AddOrUpdateBlendable_InWeight_Offset = NativeReflectionCached.GetPropertyOffset(AddOrUpdateBlendable_FunctionAddress, "InWeight");
		AddOrUpdateBlendable_InWeight_IsValid = NativeReflectionCached.ValidatePropertyClass(AddOrUpdateBlendable_FunctionAddress, "InWeight", Classes.FFloatProperty);
		AddOrUpdateBlendable_IsValid = AddOrUpdateBlendable_FunctionAddress != IntPtr.Zero && AddOrUpdateBlendable_InBlendableObject_IsValid && AddOrUpdateBlendable_InWeight_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/CustomLightSystem.CLSPostVolume:AddOrUpdateBlendable", AddOrUpdateBlendable_IsValid);
	}
}
