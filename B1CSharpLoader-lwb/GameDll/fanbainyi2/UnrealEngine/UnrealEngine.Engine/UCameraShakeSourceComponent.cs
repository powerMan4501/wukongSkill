using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Engine.CameraShakeSourceComponent", "Engine", UnrealModuleType.Engine)]
public class UCameraShakeSourceComponent : USceneComponent
{
	private static bool Attenuation_IsValid;

	private static FFieldAddress Attenuation_PropertyAddress;

	private static int Attenuation_Offset;

	private static bool InnerAttenuationRadius_IsValid;

	private static int InnerAttenuationRadius_Offset;

	private static bool OuterAttenuationRadius_IsValid;

	private static int OuterAttenuationRadius_Offset;

	private static bool CameraShake_IsValid;

	private static int CameraShake_Offset;

	private static bool AutoStart_IsValid;

	private static FFieldAddress AutoStart_PropertyAddress;

	private static int AutoStart_Offset;

	private static bool StopAllCameraShakesOfType_IsValid;

	private static IntPtr StopAllCameraShakesOfType_FunctionAddress;

	private static int StopAllCameraShakesOfType_ParamsSize;

	private static bool StopAllCameraShakesOfType_InCameraShake_IsValid;

	private static FFieldAddress StopAllCameraShakesOfType_InCameraShake_PropertyAddress;

	private static int StopAllCameraShakesOfType_InCameraShake_Offset;

	private static bool StopAllCameraShakesOfType_bImmediately_IsValid;

	private static FFieldAddress StopAllCameraShakesOfType_bImmediately_PropertyAddress;

	private static int StopAllCameraShakesOfType_bImmediately_Offset;

	private static bool StopAllCameraShakes_IsValid;

	private static IntPtr StopAllCameraShakes_FunctionAddress;

	private static int StopAllCameraShakes_ParamsSize;

	private static bool StopAllCameraShakes_bImmediately_IsValid;

	private static FFieldAddress StopAllCameraShakes_bImmediately_PropertyAddress;

	private static int StopAllCameraShakes_bImmediately_Offset;

	private static bool StartCameraShake_IsValid;

	private static IntPtr StartCameraShake_FunctionAddress;

	private static int StartCameraShake_ParamsSize;

	private static bool StartCameraShake_InCameraShake_IsValid;

	private static FFieldAddress StartCameraShake_InCameraShake_PropertyAddress;

	private static int StartCameraShake_InCameraShake_Offset;

	private static bool StartCameraShake_Scale_IsValid;

	private static FFieldAddress StartCameraShake_Scale_PropertyAddress;

	private static int StartCameraShake_Scale_Offset;

	private static bool StartCameraShake_PlaySpace_IsValid;

	private static FFieldAddress StartCameraShake_PlaySpace_PropertyAddress;

	private static int StartCameraShake_PlaySpace_Offset;

	private static bool StartCameraShake_UserPlaySpaceRot_IsValid;

	private static FFieldAddress StartCameraShake_UserPlaySpaceRot_PropertyAddress;

	private static int StartCameraShake_UserPlaySpaceRot_Offset;

	private static bool Start_IsValid;

	private static IntPtr Start_FunctionAddress;

	private static int Start_ParamsSize;

	private static bool GetAttenuationFactor_IsValid;

	private static IntPtr GetAttenuationFactor_FunctionAddress;

	private static int GetAttenuationFactor_ParamsSize;

	private static bool GetAttenuationFactor_Location_IsValid;

	private static FFieldAddress GetAttenuationFactor_Location_PropertyAddress;

	private static int GetAttenuationFactor_Location_Offset;

	private static bool GetAttenuationFactor_ReturnValue_IsValid;

	private static FFieldAddress GetAttenuationFactor_ReturnValue_PropertyAddress;

	private static int GetAttenuationFactor_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.CameraShakeSourceComponent:Attenuation")]
	public ECameraShakeAttenuation Attenuation
	{
		get
		{
			CheckDestroyed();
			if (!Attenuation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CameraShakeSourceComponent:Attenuation");
				return ECameraShakeAttenuation.Linear;
			}
			return EnumMarshaler<ECameraShakeAttenuation>.FromNative(IntPtr.Add(base.Address, Attenuation_Offset), 0, Attenuation_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Attenuation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CameraShakeSourceComponent:Attenuation");
			}
			else
			{
				EnumMarshaler<ECameraShakeAttenuation>.ToNative(IntPtr.Add(base.Address, Attenuation_Offset), 0, Attenuation_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.CameraShakeSourceComponent:InnerAttenuationRadius")]
	public float InnerAttenuationRadius
	{
		get
		{
			CheckDestroyed();
			if (!InnerAttenuationRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CameraShakeSourceComponent:InnerAttenuationRadius");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, InnerAttenuationRadius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InnerAttenuationRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CameraShakeSourceComponent:InnerAttenuationRadius");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, InnerAttenuationRadius_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.CameraShakeSourceComponent:OuterAttenuationRadius")]
	public float OuterAttenuationRadius
	{
		get
		{
			CheckDestroyed();
			if (!OuterAttenuationRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CameraShakeSourceComponent:OuterAttenuationRadius");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, OuterAttenuationRadius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OuterAttenuationRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CameraShakeSourceComponent:OuterAttenuationRadius");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, OuterAttenuationRadius_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/Engine.CameraShakeSourceComponent:CameraShake")]
	public TSubclassOf<UCameraShakeBase> CameraShake
	{
		get
		{
			CheckDestroyed();
			if (!CameraShake_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CameraShakeSourceComponent:CameraShake");
				return default(TSubclassOf<UCameraShakeBase>);
			}
			return TSubclassOfMarshaler<UCameraShakeBase>.FromNative(IntPtr.Add(base.Address, CameraShake_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CameraShake_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CameraShakeSourceComponent:CameraShake");
			}
			else
			{
				TSubclassOfMarshaler<UCameraShakeBase>.ToNative(IntPtr.Add(base.Address, CameraShake_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.CameraShakeSourceComponent:bAutoStart")]
	public bool AutoStart
	{
		get
		{
			CheckDestroyed();
			if (!AutoStart_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CameraShakeSourceComponent:bAutoStart");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AutoStart_Offset), 0, AutoStart_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AutoStart_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CameraShakeSourceComponent:bAutoStart");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AutoStart_Offset), 0, AutoStart_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.CameraShakeSourceComponent:StopAllCameraShakesOfType")]
	public unsafe void StopAllCameraShakesOfType(TSubclassOf<UCameraShakeBase> InCameraShake, bool bImmediately = true)
	{
		CheckDestroyed();
		if (!StopAllCameraShakesOfType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CameraShakeSourceComponent:StopAllCameraShakesOfType");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StopAllCameraShakesOfType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StopAllCameraShakesOfType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfMarshaler<UCameraShakeBase>.ToNative(IntPtr.Add(intPtr, StopAllCameraShakesOfType_InCameraShake_Offset), 0, StopAllCameraShakesOfType_InCameraShake_PropertyAddress.Address, InCameraShake);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, StopAllCameraShakesOfType_bImmediately_Offset), 0, StopAllCameraShakesOfType_bImmediately_PropertyAddress.Address, bImmediately);
		NativeReflection.InvokeFunctionOptimized(base.Address, StopAllCameraShakesOfType_FunctionAddress, intPtr, StopAllCameraShakesOfType_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.CameraShakeSourceComponent:StopAllCameraShakes")]
	public unsafe void StopAllCameraShakes(bool bImmediately = true)
	{
		CheckDestroyed();
		if (!StopAllCameraShakes_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CameraShakeSourceComponent:StopAllCameraShakes");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StopAllCameraShakes_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StopAllCameraShakes_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, StopAllCameraShakes_bImmediately_Offset), 0, StopAllCameraShakes_bImmediately_PropertyAddress.Address, bImmediately);
		NativeReflection.InvokeFunctionOptimized(base.Address, StopAllCameraShakes_FunctionAddress, intPtr, StopAllCameraShakes_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Engine.CameraShakeSourceComponent:StartCameraShake")]
	public unsafe void StartCameraShake(TSubclassOf<UCameraShakeBase> InCameraShake, float Scale = 1f, ECameraShakePlaySpace PlaySpace = ECameraShakePlaySpace.CameraLocal, FRotator UserPlaySpaceRot = default(FRotator))
	{
		CheckDestroyed();
		if (!StartCameraShake_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CameraShakeSourceComponent:StartCameraShake");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StartCameraShake_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StartCameraShake_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfMarshaler<UCameraShakeBase>.ToNative(IntPtr.Add(intPtr, StartCameraShake_InCameraShake_Offset), 0, StartCameraShake_InCameraShake_PropertyAddress.Address, InCameraShake);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, StartCameraShake_Scale_Offset), 0, StartCameraShake_Scale_PropertyAddress.Address, Scale);
		EnumMarshaler<ECameraShakePlaySpace>.ToNative(IntPtr.Add(intPtr, StartCameraShake_PlaySpace_Offset), 0, StartCameraShake_PlaySpace_PropertyAddress.Address, PlaySpace);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, StartCameraShake_UserPlaySpaceRot_Offset), 0, StartCameraShake_UserPlaySpaceRot_PropertyAddress.Address, UserPlaySpaceRot);
		NativeReflection.InvokeFunctionOptimized(base.Address, StartCameraShake_FunctionAddress, intPtr, StartCameraShake_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.CameraShakeSourceComponent:Start")]
	public unsafe void Start()
	{
		CheckDestroyed();
		if (!Start_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CameraShakeSourceComponent:Start");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Start_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Start_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Start_FunctionAddress, argsSize: Start_ParamsSize);
	}

	[UFunction(Flags = 1422001153u)]
	[UMetaPath("/Script/Engine.CameraShakeSourceComponent:GetAttenuationFactor")]
	public unsafe float GetAttenuationFactor(FVector Location)
	{
		CheckDestroyed();
		if (!GetAttenuationFactor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CameraShakeSourceComponent:GetAttenuationFactor");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAttenuationFactor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAttenuationFactor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, GetAttenuationFactor_Location_Offset), 0, GetAttenuationFactor_Location_PropertyAddress.Address, Location);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAttenuationFactor_FunctionAddress, intPtr, GetAttenuationFactor_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetAttenuationFactor_ReturnValue_Offset), 0, GetAttenuationFactor_ReturnValue_PropertyAddress.Address);
	}

	static UCameraShakeSourceComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UCameraShakeSourceComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UCameraShakeSourceComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.CameraShakeSourceComponent");
		NativeReflectionCached.GetPropertyRef(ref Attenuation_PropertyAddress, intPtr, "Attenuation");
		Attenuation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Attenuation");
		Attenuation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Attenuation", Classes.FEnumProperty);
		InnerAttenuationRadius_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InnerAttenuationRadius");
		InnerAttenuationRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InnerAttenuationRadius", Classes.FFloatProperty);
		OuterAttenuationRadius_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OuterAttenuationRadius");
		OuterAttenuationRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OuterAttenuationRadius", Classes.FFloatProperty);
		CameraShake_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CameraShake");
		CameraShake_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CameraShake", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref AutoStart_PropertyAddress, intPtr, "bAutoStart");
		AutoStart_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAutoStart");
		AutoStart_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAutoStart", Classes.FBoolProperty);
		StopAllCameraShakesOfType_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "StopAllCameraShakesOfType");
		StopAllCameraShakesOfType_ParamsSize = NativeReflection.GetFunctionParamsSize(StopAllCameraShakesOfType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref StopAllCameraShakesOfType_InCameraShake_PropertyAddress, StopAllCameraShakesOfType_FunctionAddress, "InCameraShake");
		StopAllCameraShakesOfType_InCameraShake_Offset = NativeReflectionCached.GetPropertyOffset(StopAllCameraShakesOfType_FunctionAddress, "InCameraShake");
		StopAllCameraShakesOfType_InCameraShake_IsValid = NativeReflectionCached.ValidatePropertyClass(StopAllCameraShakesOfType_FunctionAddress, "InCameraShake", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref StopAllCameraShakesOfType_bImmediately_PropertyAddress, StopAllCameraShakesOfType_FunctionAddress, "bImmediately");
		StopAllCameraShakesOfType_bImmediately_Offset = NativeReflectionCached.GetPropertyOffset(StopAllCameraShakesOfType_FunctionAddress, "bImmediately");
		StopAllCameraShakesOfType_bImmediately_IsValid = NativeReflectionCached.ValidatePropertyClass(StopAllCameraShakesOfType_FunctionAddress, "bImmediately", Classes.FBoolProperty);
		StopAllCameraShakesOfType_IsValid = StopAllCameraShakesOfType_FunctionAddress != IntPtr.Zero && StopAllCameraShakesOfType_InCameraShake_IsValid && StopAllCameraShakesOfType_bImmediately_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CameraShakeSourceComponent:StopAllCameraShakesOfType", StopAllCameraShakesOfType_IsValid);
		StopAllCameraShakes_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "StopAllCameraShakes");
		StopAllCameraShakes_ParamsSize = NativeReflection.GetFunctionParamsSize(StopAllCameraShakes_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref StopAllCameraShakes_bImmediately_PropertyAddress, StopAllCameraShakes_FunctionAddress, "bImmediately");
		StopAllCameraShakes_bImmediately_Offset = NativeReflectionCached.GetPropertyOffset(StopAllCameraShakes_FunctionAddress, "bImmediately");
		StopAllCameraShakes_bImmediately_IsValid = NativeReflectionCached.ValidatePropertyClass(StopAllCameraShakes_FunctionAddress, "bImmediately", Classes.FBoolProperty);
		StopAllCameraShakes_IsValid = StopAllCameraShakes_FunctionAddress != IntPtr.Zero && StopAllCameraShakes_bImmediately_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CameraShakeSourceComponent:StopAllCameraShakes", StopAllCameraShakes_IsValid);
		StartCameraShake_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "StartCameraShake");
		StartCameraShake_ParamsSize = NativeReflection.GetFunctionParamsSize(StartCameraShake_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref StartCameraShake_InCameraShake_PropertyAddress, StartCameraShake_FunctionAddress, "InCameraShake");
		StartCameraShake_InCameraShake_Offset = NativeReflectionCached.GetPropertyOffset(StartCameraShake_FunctionAddress, "InCameraShake");
		StartCameraShake_InCameraShake_IsValid = NativeReflectionCached.ValidatePropertyClass(StartCameraShake_FunctionAddress, "InCameraShake", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref StartCameraShake_Scale_PropertyAddress, StartCameraShake_FunctionAddress, "Scale");
		StartCameraShake_Scale_Offset = NativeReflectionCached.GetPropertyOffset(StartCameraShake_FunctionAddress, "Scale");
		StartCameraShake_Scale_IsValid = NativeReflectionCached.ValidatePropertyClass(StartCameraShake_FunctionAddress, "Scale", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref StartCameraShake_PlaySpace_PropertyAddress, StartCameraShake_FunctionAddress, "PlaySpace");
		StartCameraShake_PlaySpace_Offset = NativeReflectionCached.GetPropertyOffset(StartCameraShake_FunctionAddress, "PlaySpace");
		StartCameraShake_PlaySpace_IsValid = NativeReflectionCached.ValidatePropertyClass(StartCameraShake_FunctionAddress, "PlaySpace", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref StartCameraShake_UserPlaySpaceRot_PropertyAddress, StartCameraShake_FunctionAddress, "UserPlaySpaceRot");
		StartCameraShake_UserPlaySpaceRot_Offset = NativeReflectionCached.GetPropertyOffset(StartCameraShake_FunctionAddress, "UserPlaySpaceRot");
		StartCameraShake_UserPlaySpaceRot_IsValid = NativeReflectionCached.ValidatePropertyClass(StartCameraShake_FunctionAddress, "UserPlaySpaceRot", Classes.FStructProperty);
		StartCameraShake_IsValid = StartCameraShake_FunctionAddress != IntPtr.Zero && StartCameraShake_InCameraShake_IsValid && StartCameraShake_Scale_IsValid && StartCameraShake_PlaySpace_IsValid && StartCameraShake_UserPlaySpaceRot_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CameraShakeSourceComponent:StartCameraShake", StartCameraShake_IsValid);
		Start_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Start");
		Start_ParamsSize = NativeReflection.GetFunctionParamsSize(Start_FunctionAddress);
		Start_IsValid = Start_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CameraShakeSourceComponent:Start", Start_IsValid);
		GetAttenuationFactor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetAttenuationFactor");
		GetAttenuationFactor_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAttenuationFactor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAttenuationFactor_Location_PropertyAddress, GetAttenuationFactor_FunctionAddress, "Location");
		GetAttenuationFactor_Location_Offset = NativeReflectionCached.GetPropertyOffset(GetAttenuationFactor_FunctionAddress, "Location");
		GetAttenuationFactor_Location_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAttenuationFactor_FunctionAddress, "Location", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAttenuationFactor_ReturnValue_PropertyAddress, GetAttenuationFactor_FunctionAddress, "ReturnValue");
		GetAttenuationFactor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAttenuationFactor_FunctionAddress, "ReturnValue");
		GetAttenuationFactor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAttenuationFactor_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetAttenuationFactor_IsValid = GetAttenuationFactor_FunctionAddress != IntPtr.Zero && GetAttenuationFactor_Location_IsValid && GetAttenuationFactor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CameraShakeSourceComponent:GetAttenuationFactor", GetAttenuationFactor_IsValid);
	}
}
