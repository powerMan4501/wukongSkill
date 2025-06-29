using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)821039268uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Engine.PointLightComponent", "Engine", UnrealModuleType.Engine)]
public class UPointLightComponent : ULocalLightComponent
{
	private static bool UseInverseSquaredFalloff_IsValid;

	private static FFieldAddress UseInverseSquaredFalloff_PropertyAddress;

	private static int UseInverseSquaredFalloff_Offset;

	private static bool LightFalloffExponent_IsValid;

	private static int LightFalloffExponent_Offset;

	private static bool SourceRadius_IsValid;

	private static int SourceRadius_Offset;

	private static bool SoftSourceRadius_IsValid;

	private static int SoftSourceRadius_Offset;

	private static bool SourceLength_IsValid;

	private static int SourceLength_Offset;

	private static bool SetSourceRadius_IsValid;

	private static IntPtr SetSourceRadius_FunctionAddress;

	private static int SetSourceRadius_ParamsSize;

	private static bool SetSourceRadius_bNewValue_IsValid;

	private static FFieldAddress SetSourceRadius_bNewValue_PropertyAddress;

	private static int SetSourceRadius_bNewValue_Offset;

	private static bool SetSourceLength_IsValid;

	private static IntPtr SetSourceLength_FunctionAddress;

	private static int SetSourceLength_ParamsSize;

	private static bool SetSourceLength_NewValue_IsValid;

	private static FFieldAddress SetSourceLength_NewValue_PropertyAddress;

	private static int SetSourceLength_NewValue_Offset;

	private static bool SetSoftSourceRadius_IsValid;

	private static IntPtr SetSoftSourceRadius_FunctionAddress;

	private static int SetSoftSourceRadius_ParamsSize;

	private static bool SetSoftSourceRadius_bNewValue_IsValid;

	private static FFieldAddress SetSoftSourceRadius_bNewValue_PropertyAddress;

	private static int SetSoftSourceRadius_bNewValue_Offset;

	private static bool SetLightFalloffExponent_IsValid;

	private static IntPtr SetLightFalloffExponent_FunctionAddress;

	private static int SetLightFalloffExponent_ParamsSize;

	private static bool SetLightFalloffExponent_NewLightFalloffExponent_IsValid;

	private static FFieldAddress SetLightFalloffExponent_NewLightFalloffExponent_PropertyAddress;

	private static int SetLightFalloffExponent_NewLightFalloffExponent_Offset;

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Engine.PointLightComponent:bUseInverseSquaredFalloff")]
	public bool UseInverseSquaredFalloff
	{
		get
		{
			CheckDestroyed();
			if (!UseInverseSquaredFalloff_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PointLightComponent:bUseInverseSquaredFalloff");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseInverseSquaredFalloff_Offset), 0, UseInverseSquaredFalloff_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseInverseSquaredFalloff_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PointLightComponent:bUseInverseSquaredFalloff");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseInverseSquaredFalloff_Offset), 0, UseInverseSquaredFalloff_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759875870720533uL)]
	[UMetaPath("/Script/Engine.PointLightComponent:LightFalloffExponent")]
	public float LightFalloffExponent
	{
		get
		{
			CheckDestroyed();
			if (!LightFalloffExponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PointLightComponent:LightFalloffExponent");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LightFalloffExponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LightFalloffExponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PointLightComponent:LightFalloffExponent");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LightFalloffExponent_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755477824209429uL)]
	[UMetaPath("/Script/Engine.PointLightComponent:SourceRadius")]
	public float SourceRadius
	{
		get
		{
			CheckDestroyed();
			if (!SourceRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PointLightComponent:SourceRadius");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SourceRadius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SourceRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PointLightComponent:SourceRadius");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SourceRadius_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755477824209429uL)]
	[UMetaPath("/Script/Engine.PointLightComponent:SoftSourceRadius")]
	public float SoftSourceRadius
	{
		get
		{
			CheckDestroyed();
			if (!SoftSourceRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PointLightComponent:SoftSourceRadius");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SoftSourceRadius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SoftSourceRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PointLightComponent:SoftSourceRadius");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SoftSourceRadius_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755477824209429uL)]
	[UMetaPath("/Script/Engine.PointLightComponent:SourceLength")]
	public float SourceLength
	{
		get
		{
			CheckDestroyed();
			if (!SourceLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PointLightComponent:SourceLength");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SourceLength_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SourceLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PointLightComponent:SourceLength");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SourceLength_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PointLightComponent:SetSourceRadius")]
	public unsafe void SetSourceRadius(float bNewValue)
	{
		CheckDestroyed();
		if (!SetSourceRadius_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PointLightComponent:SetSourceRadius");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSourceRadius_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSourceRadius_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetSourceRadius_bNewValue_Offset), 0, SetSourceRadius_bNewValue_PropertyAddress.Address, bNewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSourceRadius_FunctionAddress, intPtr, SetSourceRadius_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PointLightComponent:SetSourceLength")]
	public unsafe void SetSourceLength(float NewValue)
	{
		CheckDestroyed();
		if (!SetSourceLength_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PointLightComponent:SetSourceLength");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSourceLength_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSourceLength_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetSourceLength_NewValue_Offset), 0, SetSourceLength_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSourceLength_FunctionAddress, intPtr, SetSourceLength_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PointLightComponent:SetSoftSourceRadius")]
	public unsafe void SetSoftSourceRadius(float bNewValue)
	{
		CheckDestroyed();
		if (!SetSoftSourceRadius_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PointLightComponent:SetSoftSourceRadius");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSoftSourceRadius_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSoftSourceRadius_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetSoftSourceRadius_bNewValue_Offset), 0, SetSoftSourceRadius_bNewValue_PropertyAddress.Address, bNewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSoftSourceRadius_FunctionAddress, intPtr, SetSoftSourceRadius_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PointLightComponent:SetLightFalloffExponent")]
	public unsafe void SetLightFalloffExponent(float NewLightFalloffExponent)
	{
		CheckDestroyed();
		if (!SetLightFalloffExponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PointLightComponent:SetLightFalloffExponent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLightFalloffExponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLightFalloffExponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetLightFalloffExponent_NewLightFalloffExponent_Offset), 0, SetLightFalloffExponent_NewLightFalloffExponent_PropertyAddress.Address, NewLightFalloffExponent);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLightFalloffExponent_FunctionAddress, intPtr, SetLightFalloffExponent_ParamsSize);
	}

	static UPointLightComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPointLightComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPointLightComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.PointLightComponent");
		NativeReflectionCached.GetPropertyRef(ref UseInverseSquaredFalloff_PropertyAddress, intPtr, "bUseInverseSquaredFalloff");
		UseInverseSquaredFalloff_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUseInverseSquaredFalloff");
		UseInverseSquaredFalloff_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUseInverseSquaredFalloff", Classes.FBoolProperty);
		LightFalloffExponent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LightFalloffExponent");
		LightFalloffExponent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LightFalloffExponent", Classes.FFloatProperty);
		SourceRadius_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SourceRadius");
		SourceRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SourceRadius", Classes.FFloatProperty);
		SoftSourceRadius_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SoftSourceRadius");
		SoftSourceRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SoftSourceRadius", Classes.FFloatProperty);
		SourceLength_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SourceLength");
		SourceLength_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SourceLength", Classes.FFloatProperty);
		SetSourceRadius_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSourceRadius");
		SetSourceRadius_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSourceRadius_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSourceRadius_bNewValue_PropertyAddress, SetSourceRadius_FunctionAddress, "bNewValue");
		SetSourceRadius_bNewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetSourceRadius_FunctionAddress, "bNewValue");
		SetSourceRadius_bNewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSourceRadius_FunctionAddress, "bNewValue", Classes.FFloatProperty);
		SetSourceRadius_IsValid = SetSourceRadius_FunctionAddress != IntPtr.Zero && SetSourceRadius_bNewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PointLightComponent:SetSourceRadius", SetSourceRadius_IsValid);
		SetSourceLength_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSourceLength");
		SetSourceLength_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSourceLength_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSourceLength_NewValue_PropertyAddress, SetSourceLength_FunctionAddress, "NewValue");
		SetSourceLength_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetSourceLength_FunctionAddress, "NewValue");
		SetSourceLength_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSourceLength_FunctionAddress, "NewValue", Classes.FFloatProperty);
		SetSourceLength_IsValid = SetSourceLength_FunctionAddress != IntPtr.Zero && SetSourceLength_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PointLightComponent:SetSourceLength", SetSourceLength_IsValid);
		SetSoftSourceRadius_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSoftSourceRadius");
		SetSoftSourceRadius_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSoftSourceRadius_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSoftSourceRadius_bNewValue_PropertyAddress, SetSoftSourceRadius_FunctionAddress, "bNewValue");
		SetSoftSourceRadius_bNewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetSoftSourceRadius_FunctionAddress, "bNewValue");
		SetSoftSourceRadius_bNewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSoftSourceRadius_FunctionAddress, "bNewValue", Classes.FFloatProperty);
		SetSoftSourceRadius_IsValid = SetSoftSourceRadius_FunctionAddress != IntPtr.Zero && SetSoftSourceRadius_bNewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PointLightComponent:SetSoftSourceRadius", SetSoftSourceRadius_IsValid);
		SetLightFalloffExponent_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetLightFalloffExponent");
		SetLightFalloffExponent_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLightFalloffExponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLightFalloffExponent_NewLightFalloffExponent_PropertyAddress, SetLightFalloffExponent_FunctionAddress, "NewLightFalloffExponent");
		SetLightFalloffExponent_NewLightFalloffExponent_Offset = NativeReflectionCached.GetPropertyOffset(SetLightFalloffExponent_FunctionAddress, "NewLightFalloffExponent");
		SetLightFalloffExponent_NewLightFalloffExponent_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLightFalloffExponent_FunctionAddress, "NewLightFalloffExponent", Classes.FFloatProperty);
		SetLightFalloffExponent_IsValid = SetLightFalloffExponent_FunctionAddress != IntPtr.Zero && SetLightFalloffExponent_NewLightFalloffExponent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PointLightComponent:SetLightFalloffExponent", SetLightFalloffExponent_IsValid);
	}
}
