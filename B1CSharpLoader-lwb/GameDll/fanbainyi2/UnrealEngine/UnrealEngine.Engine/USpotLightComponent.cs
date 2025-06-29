using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)821039268uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Engine.SpotLightComponent", "Engine", UnrealModuleType.Engine)]
public class USpotLightComponent : UPointLightComponent
{
	private static bool InnerConeAngle_IsValid;

	private static int InnerConeAngle_Offset;

	private static bool OuterConeAngle_IsValid;

	private static int OuterConeAngle_Offset;

	private static bool SetOuterConeAngle_IsValid;

	private static IntPtr SetOuterConeAngle_FunctionAddress;

	private static int SetOuterConeAngle_ParamsSize;

	private static bool SetOuterConeAngle_NewOuterConeAngle_IsValid;

	private static FFieldAddress SetOuterConeAngle_NewOuterConeAngle_PropertyAddress;

	private static int SetOuterConeAngle_NewOuterConeAngle_Offset;

	private static bool SetInnerConeAngle_IsValid;

	private static IntPtr SetInnerConeAngle_FunctionAddress;

	private static int SetInnerConeAngle_ParamsSize;

	private static bool SetInnerConeAngle_NewInnerConeAngle_IsValid;

	private static FFieldAddress SetInnerConeAngle_NewInnerConeAngle_PropertyAddress;

	private static int SetInnerConeAngle_NewInnerConeAngle_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.SpotLightComponent:InnerConeAngle")]
	public float InnerConeAngle
	{
		get
		{
			CheckDestroyed();
			if (!InnerConeAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SpotLightComponent:InnerConeAngle");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, InnerConeAngle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InnerConeAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SpotLightComponent:InnerConeAngle");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, InnerConeAngle_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.SpotLightComponent:OuterConeAngle")]
	public float OuterConeAngle
	{
		get
		{
			CheckDestroyed();
			if (!OuterConeAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SpotLightComponent:OuterConeAngle");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, OuterConeAngle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OuterConeAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SpotLightComponent:OuterConeAngle");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, OuterConeAngle_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.SpotLightComponent:SetOuterConeAngle")]
	public unsafe void SetOuterConeAngle(float NewOuterConeAngle)
	{
		CheckDestroyed();
		if (!SetOuterConeAngle_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SpotLightComponent:SetOuterConeAngle");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetOuterConeAngle_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetOuterConeAngle_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetOuterConeAngle_NewOuterConeAngle_Offset), 0, SetOuterConeAngle_NewOuterConeAngle_PropertyAddress.Address, NewOuterConeAngle);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetOuterConeAngle_FunctionAddress, intPtr, SetOuterConeAngle_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.SpotLightComponent:SetInnerConeAngle")]
	public unsafe void SetInnerConeAngle(float NewInnerConeAngle)
	{
		CheckDestroyed();
		if (!SetInnerConeAngle_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SpotLightComponent:SetInnerConeAngle");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetInnerConeAngle_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetInnerConeAngle_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetInnerConeAngle_NewInnerConeAngle_Offset), 0, SetInnerConeAngle_NewInnerConeAngle_PropertyAddress.Address, NewInnerConeAngle);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetInnerConeAngle_FunctionAddress, intPtr, SetInnerConeAngle_ParamsSize);
	}

	static USpotLightComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(USpotLightComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(USpotLightComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.SpotLightComponent");
		InnerConeAngle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InnerConeAngle");
		InnerConeAngle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InnerConeAngle", Classes.FFloatProperty);
		OuterConeAngle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OuterConeAngle");
		OuterConeAngle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OuterConeAngle", Classes.FFloatProperty);
		SetOuterConeAngle_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetOuterConeAngle");
		SetOuterConeAngle_ParamsSize = NativeReflection.GetFunctionParamsSize(SetOuterConeAngle_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetOuterConeAngle_NewOuterConeAngle_PropertyAddress, SetOuterConeAngle_FunctionAddress, "NewOuterConeAngle");
		SetOuterConeAngle_NewOuterConeAngle_Offset = NativeReflectionCached.GetPropertyOffset(SetOuterConeAngle_FunctionAddress, "NewOuterConeAngle");
		SetOuterConeAngle_NewOuterConeAngle_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOuterConeAngle_FunctionAddress, "NewOuterConeAngle", Classes.FFloatProperty);
		SetOuterConeAngle_IsValid = SetOuterConeAngle_FunctionAddress != IntPtr.Zero && SetOuterConeAngle_NewOuterConeAngle_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SpotLightComponent:SetOuterConeAngle", SetOuterConeAngle_IsValid);
		SetInnerConeAngle_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetInnerConeAngle");
		SetInnerConeAngle_ParamsSize = NativeReflection.GetFunctionParamsSize(SetInnerConeAngle_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetInnerConeAngle_NewInnerConeAngle_PropertyAddress, SetInnerConeAngle_FunctionAddress, "NewInnerConeAngle");
		SetInnerConeAngle_NewInnerConeAngle_Offset = NativeReflectionCached.GetPropertyOffset(SetInnerConeAngle_FunctionAddress, "NewInnerConeAngle");
		SetInnerConeAngle_NewInnerConeAngle_IsValid = NativeReflectionCached.ValidatePropertyClass(SetInnerConeAngle_FunctionAddress, "NewInnerConeAngle", Classes.FFloatProperty);
		SetInnerConeAngle_IsValid = SetInnerConeAngle_FunctionAddress != IntPtr.Zero && SetInnerConeAngle_NewInnerConeAngle_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SpotLightComponent:SetInnerConeAngle", SetInnerConeAngle_IsValid);
	}
}
