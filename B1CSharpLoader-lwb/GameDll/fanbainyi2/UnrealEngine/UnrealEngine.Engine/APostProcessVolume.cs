using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.PostProcessVolume", "Engine", UnrealModuleType.Engine)]
public class APostProcessVolume : AVolume, IInterface_PostProcessVolume, IInterface
{
	private static bool Settings_IsValid;

	private static int Settings_Offset;

	private static bool Priority_IsValid;

	private static int Priority_Offset;

	private static bool BlendRadius_IsValid;

	private static int BlendRadius_Offset;

	private static bool BlendWeight_IsValid;

	private static int BlendWeight_Offset;

	private static bool Enabled_IsValid;

	private static FFieldAddress Enabled_PropertyAddress;

	private static int Enabled_Offset;

	private static bool Unbound_IsValid;

	private static FFieldAddress Unbound_PropertyAddress;

	private static int Unbound_Offset;

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
	[UMetaPath("/Script/Engine.PostProcessVolume:Settings")]
	public FPostProcessSettings Settings
	{
		get
		{
			CheckDestroyed();
			if (!Settings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PostProcessVolume:Settings");
				return default(FPostProcessSettings);
			}
			return FPostProcessSettings.FromNative(IntPtr.Add(base.Address, Settings_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Settings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PostProcessVolume:Settings");
			}
			else
			{
				FPostProcessSettings.ToNative(IntPtr.Add(base.Address, Settings_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.PostProcessVolume:Priority")]
	public float Priority
	{
		get
		{
			CheckDestroyed();
			if (!Priority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PostProcessVolume:Priority");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Priority_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Priority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PostProcessVolume:Priority");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Priority_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/Engine.PostProcessVolume:BlendRadius")]
	public float BlendRadius
	{
		get
		{
			CheckDestroyed();
			if (!BlendRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PostProcessVolume:BlendRadius");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BlendRadius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BlendRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PostProcessVolume:BlendRadius");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BlendRadius_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/Engine.PostProcessVolume:BlendWeight")]
	public float BlendWeight
	{
		get
		{
			CheckDestroyed();
			if (!BlendWeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PostProcessVolume:BlendWeight");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BlendWeight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BlendWeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PostProcessVolume:BlendWeight");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BlendWeight_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.PostProcessVolume:bEnabled")]
	public bool Enabled
	{
		get
		{
			CheckDestroyed();
			if (!Enabled_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PostProcessVolume:bEnabled");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Enabled_Offset), 0, Enabled_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Enabled_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PostProcessVolume:bEnabled");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Enabled_Offset), 0, Enabled_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.PostProcessVolume:bUnbound")]
	public bool Unbound
	{
		get
		{
			CheckDestroyed();
			if (!Unbound_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PostProcessVolume:bUnbound");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Unbound_Offset), 0, Unbound_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Unbound_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PostProcessVolume:bUnbound");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Unbound_Offset), 0, Unbound_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PostProcessVolume:AddOrUpdateBlendable")]
	public unsafe void AddOrUpdateBlendable(IBlendableInterface InBlendableObject, float InWeight = 1f)
	{
		CheckDestroyed();
		if (!AddOrUpdateBlendable_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PostProcessVolume:AddOrUpdateBlendable");
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

	static APostProcessVolume()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(APostProcessVolume)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(APostProcessVolume));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.PostProcessVolume");
		Settings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Settings");
		Settings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Settings", Classes.FStructProperty);
		Priority_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Priority");
		Priority_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Priority", Classes.FFloatProperty);
		BlendRadius_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BlendRadius");
		BlendRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BlendRadius", Classes.FFloatProperty);
		BlendWeight_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BlendWeight");
		BlendWeight_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BlendWeight", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref Enabled_PropertyAddress, intPtr, "bEnabled");
		Enabled_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnabled");
		Enabled_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnabled", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Unbound_PropertyAddress, intPtr, "bUnbound");
		Unbound_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUnbound");
		Unbound_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUnbound", Classes.FBoolProperty);
		AddOrUpdateBlendable_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddOrUpdateBlendable");
		AddOrUpdateBlendable_ParamsSize = NativeReflection.GetFunctionParamsSize(AddOrUpdateBlendable_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddOrUpdateBlendable_InBlendableObject_PropertyAddress, AddOrUpdateBlendable_FunctionAddress, "InBlendableObject");
		AddOrUpdateBlendable_InBlendableObject_Offset = NativeReflectionCached.GetPropertyOffset(AddOrUpdateBlendable_FunctionAddress, "InBlendableObject");
		AddOrUpdateBlendable_InBlendableObject_IsValid = NativeReflectionCached.ValidatePropertyClass(AddOrUpdateBlendable_FunctionAddress, "InBlendableObject", Classes.FInterfaceProperty);
		NativeReflectionCached.GetPropertyRef(ref AddOrUpdateBlendable_InWeight_PropertyAddress, AddOrUpdateBlendable_FunctionAddress, "InWeight");
		AddOrUpdateBlendable_InWeight_Offset = NativeReflectionCached.GetPropertyOffset(AddOrUpdateBlendable_FunctionAddress, "InWeight");
		AddOrUpdateBlendable_InWeight_IsValid = NativeReflectionCached.ValidatePropertyClass(AddOrUpdateBlendable_FunctionAddress, "InWeight", Classes.FFloatProperty);
		AddOrUpdateBlendable_IsValid = AddOrUpdateBlendable_FunctionAddress != IntPtr.Zero && AddOrUpdateBlendable_InBlendableObject_IsValid && AddOrUpdateBlendable_InWeight_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PostProcessVolume:AddOrUpdateBlendable", AddOrUpdateBlendable_IsValid);
	}
}
