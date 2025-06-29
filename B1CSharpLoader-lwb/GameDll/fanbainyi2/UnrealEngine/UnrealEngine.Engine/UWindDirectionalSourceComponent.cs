using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)821047460uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.WindDirectionalSourceComponent", "Engine", UnrealModuleType.Engine)]
public class UWindDirectionalSourceComponent : USceneComponent
{
	private static bool Strength_IsValid;

	private static int Strength_Offset;

	private static bool Speed_IsValid;

	private static int Speed_Offset;

	private static bool MinGustAmount_IsValid;

	private static int MinGustAmount_Offset;

	private static bool MaxGustAmount_IsValid;

	private static int MaxGustAmount_Offset;

	private static bool Radius_IsValid;

	private static int Radius_Offset;

	private static bool PointWind_IsValid;

	private static FFieldAddress PointWind_PropertyAddress;

	private static int PointWind_Offset;

	private static bool SetWindType_IsValid;

	private static IntPtr SetWindType_FunctionAddress;

	private static int SetWindType_ParamsSize;

	private static bool SetWindType_InNewType_IsValid;

	private static FFieldAddress SetWindType_InNewType_PropertyAddress;

	private static int SetWindType_InNewType_Offset;

	private static bool SetStrength_IsValid;

	private static IntPtr SetStrength_FunctionAddress;

	private static int SetStrength_ParamsSize;

	private static bool SetStrength_InNewStrength_IsValid;

	private static FFieldAddress SetStrength_InNewStrength_PropertyAddress;

	private static int SetStrength_InNewStrength_Offset;

	private static bool SetSpeed_IsValid;

	private static IntPtr SetSpeed_FunctionAddress;

	private static int SetSpeed_ParamsSize;

	private static bool SetSpeed_InNewSpeed_IsValid;

	private static FFieldAddress SetSpeed_InNewSpeed_PropertyAddress;

	private static int SetSpeed_InNewSpeed_Offset;

	private static bool SetRadius_IsValid;

	private static IntPtr SetRadius_FunctionAddress;

	private static int SetRadius_ParamsSize;

	private static bool SetRadius_InNewRadius_IsValid;

	private static FFieldAddress SetRadius_InNewRadius_PropertyAddress;

	private static int SetRadius_InNewRadius_Offset;

	private static bool SetMinimumGustAmount_IsValid;

	private static IntPtr SetMinimumGustAmount_FunctionAddress;

	private static int SetMinimumGustAmount_ParamsSize;

	private static bool SetMinimumGustAmount_InNewMinGust_IsValid;

	private static FFieldAddress SetMinimumGustAmount_InNewMinGust_PropertyAddress;

	private static int SetMinimumGustAmount_InNewMinGust_Offset;

	private static bool SetMaximumGustAmount_IsValid;

	private static IntPtr SetMaximumGustAmount_FunctionAddress;

	private static int SetMaximumGustAmount_ParamsSize;

	private static bool SetMaximumGustAmount_InNewMaxGust_IsValid;

	private static FFieldAddress SetMaximumGustAmount_InNewMaxGust_PropertyAddress;

	private static int SetMaximumGustAmount_InNewMaxGust_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/Engine.WindDirectionalSourceComponent:Strength")]
	public float Strength
	{
		get
		{
			CheckDestroyed();
			if (!Strength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.WindDirectionalSourceComponent:Strength");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Strength_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Strength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.WindDirectionalSourceComponent:Strength");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Strength_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/Engine.WindDirectionalSourceComponent:Speed")]
	public float Speed
	{
		get
		{
			CheckDestroyed();
			if (!Speed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.WindDirectionalSourceComponent:Speed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Speed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Speed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.WindDirectionalSourceComponent:Speed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Speed_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755477824209429uL)]
	[UMetaPath("/Script/Engine.WindDirectionalSourceComponent:MinGustAmount")]
	public float MinGustAmount
	{
		get
		{
			CheckDestroyed();
			if (!MinGustAmount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.WindDirectionalSourceComponent:MinGustAmount");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MinGustAmount_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MinGustAmount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.WindDirectionalSourceComponent:MinGustAmount");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MinGustAmount_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755477824209429uL)]
	[UMetaPath("/Script/Engine.WindDirectionalSourceComponent:MaxGustAmount")]
	public float MaxGustAmount
	{
		get
		{
			CheckDestroyed();
			if (!MaxGustAmount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.WindDirectionalSourceComponent:MaxGustAmount");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaxGustAmount_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxGustAmount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.WindDirectionalSourceComponent:MaxGustAmount");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MaxGustAmount_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/Engine.WindDirectionalSourceComponent:Radius")]
	public float Radius
	{
		get
		{
			CheckDestroyed();
			if (!Radius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.WindDirectionalSourceComponent:Radius");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Radius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Radius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.WindDirectionalSourceComponent:Radius");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Radius_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.WindDirectionalSourceComponent:bPointWind")]
	public bool PointWind
	{
		get
		{
			CheckDestroyed();
			if (!PointWind_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.WindDirectionalSourceComponent:bPointWind");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, PointWind_Offset), 0, PointWind_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!PointWind_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.WindDirectionalSourceComponent:bPointWind");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, PointWind_Offset), 0, PointWind_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.WindDirectionalSourceComponent:SetWindType")]
	public unsafe void SetWindType(EWindSourceType InNewType)
	{
		CheckDestroyed();
		if (!SetWindType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.WindDirectionalSourceComponent:SetWindType");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetWindType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetWindType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EWindSourceType>.ToNative(IntPtr.Add(intPtr, SetWindType_InNewType_Offset), 0, SetWindType_InNewType_PropertyAddress.Address, InNewType);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetWindType_FunctionAddress, intPtr, SetWindType_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.WindDirectionalSourceComponent:SetStrength")]
	public unsafe void SetStrength(float InNewStrength)
	{
		CheckDestroyed();
		if (!SetStrength_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.WindDirectionalSourceComponent:SetStrength");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetStrength_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetStrength_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetStrength_InNewStrength_Offset), 0, SetStrength_InNewStrength_PropertyAddress.Address, InNewStrength);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetStrength_FunctionAddress, intPtr, SetStrength_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.WindDirectionalSourceComponent:SetSpeed")]
	public unsafe void SetSpeed(float InNewSpeed)
	{
		CheckDestroyed();
		if (!SetSpeed_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.WindDirectionalSourceComponent:SetSpeed");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSpeed_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSpeed_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetSpeed_InNewSpeed_Offset), 0, SetSpeed_InNewSpeed_PropertyAddress.Address, InNewSpeed);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSpeed_FunctionAddress, intPtr, SetSpeed_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.WindDirectionalSourceComponent:SetRadius")]
	public unsafe void SetRadius(float InNewRadius)
	{
		CheckDestroyed();
		if (!SetRadius_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.WindDirectionalSourceComponent:SetRadius");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetRadius_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetRadius_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetRadius_InNewRadius_Offset), 0, SetRadius_InNewRadius_PropertyAddress.Address, InNewRadius);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetRadius_FunctionAddress, intPtr, SetRadius_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.WindDirectionalSourceComponent:SetMinimumGustAmount")]
	public unsafe void SetMinimumGustAmount(float InNewMinGust)
	{
		CheckDestroyed();
		if (!SetMinimumGustAmount_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.WindDirectionalSourceComponent:SetMinimumGustAmount");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMinimumGustAmount_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMinimumGustAmount_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetMinimumGustAmount_InNewMinGust_Offset), 0, SetMinimumGustAmount_InNewMinGust_PropertyAddress.Address, InNewMinGust);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetMinimumGustAmount_FunctionAddress, intPtr, SetMinimumGustAmount_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.WindDirectionalSourceComponent:SetMaximumGustAmount")]
	public unsafe void SetMaximumGustAmount(float InNewMaxGust)
	{
		CheckDestroyed();
		if (!SetMaximumGustAmount_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.WindDirectionalSourceComponent:SetMaximumGustAmount");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMaximumGustAmount_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMaximumGustAmount_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetMaximumGustAmount_InNewMaxGust_Offset), 0, SetMaximumGustAmount_InNewMaxGust_PropertyAddress.Address, InNewMaxGust);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetMaximumGustAmount_FunctionAddress, intPtr, SetMaximumGustAmount_ParamsSize);
	}

	static UWindDirectionalSourceComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UWindDirectionalSourceComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UWindDirectionalSourceComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.WindDirectionalSourceComponent");
		Strength_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Strength");
		Strength_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Strength", Classes.FFloatProperty);
		Speed_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Speed");
		Speed_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Speed", Classes.FFloatProperty);
		MinGustAmount_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MinGustAmount");
		MinGustAmount_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MinGustAmount", Classes.FFloatProperty);
		MaxGustAmount_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxGustAmount");
		MaxGustAmount_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxGustAmount", Classes.FFloatProperty);
		Radius_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Radius");
		Radius_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Radius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref PointWind_PropertyAddress, intPtr, "bPointWind");
		PointWind_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bPointWind");
		PointWind_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bPointWind", Classes.FBoolProperty);
		SetWindType_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetWindType");
		SetWindType_ParamsSize = NativeReflection.GetFunctionParamsSize(SetWindType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetWindType_InNewType_PropertyAddress, SetWindType_FunctionAddress, "InNewType");
		SetWindType_InNewType_Offset = NativeReflectionCached.GetPropertyOffset(SetWindType_FunctionAddress, "InNewType");
		SetWindType_InNewType_IsValid = NativeReflectionCached.ValidatePropertyClass(SetWindType_FunctionAddress, "InNewType", Classes.FEnumProperty);
		SetWindType_IsValid = SetWindType_FunctionAddress != IntPtr.Zero && SetWindType_InNewType_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.WindDirectionalSourceComponent:SetWindType", SetWindType_IsValid);
		SetStrength_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetStrength");
		SetStrength_ParamsSize = NativeReflection.GetFunctionParamsSize(SetStrength_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetStrength_InNewStrength_PropertyAddress, SetStrength_FunctionAddress, "InNewStrength");
		SetStrength_InNewStrength_Offset = NativeReflectionCached.GetPropertyOffset(SetStrength_FunctionAddress, "InNewStrength");
		SetStrength_InNewStrength_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStrength_FunctionAddress, "InNewStrength", Classes.FFloatProperty);
		SetStrength_IsValid = SetStrength_FunctionAddress != IntPtr.Zero && SetStrength_InNewStrength_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.WindDirectionalSourceComponent:SetStrength", SetStrength_IsValid);
		SetSpeed_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSpeed");
		SetSpeed_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSpeed_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSpeed_InNewSpeed_PropertyAddress, SetSpeed_FunctionAddress, "InNewSpeed");
		SetSpeed_InNewSpeed_Offset = NativeReflectionCached.GetPropertyOffset(SetSpeed_FunctionAddress, "InNewSpeed");
		SetSpeed_InNewSpeed_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSpeed_FunctionAddress, "InNewSpeed", Classes.FFloatProperty);
		SetSpeed_IsValid = SetSpeed_FunctionAddress != IntPtr.Zero && SetSpeed_InNewSpeed_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.WindDirectionalSourceComponent:SetSpeed", SetSpeed_IsValid);
		SetRadius_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetRadius");
		SetRadius_ParamsSize = NativeReflection.GetFunctionParamsSize(SetRadius_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetRadius_InNewRadius_PropertyAddress, SetRadius_FunctionAddress, "InNewRadius");
		SetRadius_InNewRadius_Offset = NativeReflectionCached.GetPropertyOffset(SetRadius_FunctionAddress, "InNewRadius");
		SetRadius_InNewRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRadius_FunctionAddress, "InNewRadius", Classes.FFloatProperty);
		SetRadius_IsValid = SetRadius_FunctionAddress != IntPtr.Zero && SetRadius_InNewRadius_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.WindDirectionalSourceComponent:SetRadius", SetRadius_IsValid);
		SetMinimumGustAmount_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetMinimumGustAmount");
		SetMinimumGustAmount_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMinimumGustAmount_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMinimumGustAmount_InNewMinGust_PropertyAddress, SetMinimumGustAmount_FunctionAddress, "InNewMinGust");
		SetMinimumGustAmount_InNewMinGust_Offset = NativeReflectionCached.GetPropertyOffset(SetMinimumGustAmount_FunctionAddress, "InNewMinGust");
		SetMinimumGustAmount_InNewMinGust_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMinimumGustAmount_FunctionAddress, "InNewMinGust", Classes.FFloatProperty);
		SetMinimumGustAmount_IsValid = SetMinimumGustAmount_FunctionAddress != IntPtr.Zero && SetMinimumGustAmount_InNewMinGust_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.WindDirectionalSourceComponent:SetMinimumGustAmount", SetMinimumGustAmount_IsValid);
		SetMaximumGustAmount_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetMaximumGustAmount");
		SetMaximumGustAmount_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMaximumGustAmount_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMaximumGustAmount_InNewMaxGust_PropertyAddress, SetMaximumGustAmount_FunctionAddress, "InNewMaxGust");
		SetMaximumGustAmount_InNewMaxGust_Offset = NativeReflectionCached.GetPropertyOffset(SetMaximumGustAmount_FunctionAddress, "InNewMaxGust");
		SetMaximumGustAmount_InNewMaxGust_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMaximumGustAmount_FunctionAddress, "InNewMaxGust", Classes.FFloatProperty);
		SetMaximumGustAmount_IsValid = SetMaximumGustAmount_FunctionAddress != IntPtr.Zero && SetMaximumGustAmount_InNewMaxGust_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.WindDirectionalSourceComponent:SetMaximumGustAmount", SetMaximumGustAmount_IsValid);
	}
}
