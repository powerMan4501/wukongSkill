using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Engine.CameraModifier", "Engine", UnrealModuleType.Engine)]
public class UCameraModifier : UObject
{
	private static bool Exclusive_IsValid;

	private static FFieldAddress Exclusive_PropertyAddress;

	private static int Exclusive_Offset;

	private static bool Priority_IsValid;

	private static int Priority_Offset;

	private static bool CameraOwner_IsValid;

	private static int CameraOwner_Offset;

	private static bool AlphaInTime_IsValid;

	private static int AlphaInTime_Offset;

	private static bool AlphaOutTime_IsValid;

	private static int AlphaOutTime_Offset;

	private static bool Alpha_IsValid;

	private static int Alpha_Offset;

	private static bool IsDisabled_IsValid;

	private static IntPtr IsDisabled_FunctionAddress;

	private static int IsDisabled_ParamsSize;

	private static bool IsDisabled_ReturnValue_IsValid;

	private static FFieldAddress IsDisabled_ReturnValue_PropertyAddress;

	private static int IsDisabled_ReturnValue_Offset;

	private static bool GetViewTarget_IsValid;

	private static IntPtr GetViewTarget_FunctionAddress;

	private static int GetViewTarget_ParamsSize;

	private static bool GetViewTarget_ReturnValue_IsValid;

	private static FFieldAddress GetViewTarget_ReturnValue_PropertyAddress;

	private static int GetViewTarget_ReturnValue_Offset;

	private static bool EnableModifier_IsValid;

	private static IntPtr EnableModifier_FunctionAddress;

	private static int EnableModifier_ParamsSize;

	private static bool DisableModifier_IsValid;

	private static IntPtr DisableModifier_FunctionAddress;

	private static int DisableModifier_ParamsSize;

	private static bool DisableModifier_bImmediate_IsValid;

	private static FFieldAddress DisableModifier_bImmediate_PropertyAddress;

	private static int DisableModifier_bImmediate_Offset;

	private static bool BlueprintModifyPostProcess_IsValid;

	private IntPtr BlueprintModifyPostProcess_InstanceFunctionAddress;

	private static IntPtr BlueprintModifyPostProcess_FunctionAddress;

	private static int BlueprintModifyPostProcess_ParamsSize;

	private static bool BlueprintModifyPostProcess_DeltaTime_IsValid;

	private static FFieldAddress BlueprintModifyPostProcess_DeltaTime_PropertyAddress;

	private static int BlueprintModifyPostProcess_DeltaTime_Offset;

	private static bool BlueprintModifyPostProcess_PostProcessBlendWeight_IsValid;

	private static FFieldAddress BlueprintModifyPostProcess_PostProcessBlendWeight_PropertyAddress;

	private static int BlueprintModifyPostProcess_PostProcessBlendWeight_Offset;

	private static bool BlueprintModifyPostProcess_PostProcessSettings_IsValid;

	private static FFieldAddress BlueprintModifyPostProcess_PostProcessSettings_PropertyAddress;

	private static int BlueprintModifyPostProcess_PostProcessSettings_Offset;

	private static bool BlueprintModifyCamera_IsValid;

	private IntPtr BlueprintModifyCamera_InstanceFunctionAddress;

	private static IntPtr BlueprintModifyCamera_FunctionAddress;

	private static int BlueprintModifyCamera_ParamsSize;

	private static bool BlueprintModifyCamera_DeltaTime_IsValid;

	private static FFieldAddress BlueprintModifyCamera_DeltaTime_PropertyAddress;

	private static int BlueprintModifyCamera_DeltaTime_Offset;

	private static bool BlueprintModifyCamera_ViewLocation_IsValid;

	private static FFieldAddress BlueprintModifyCamera_ViewLocation_PropertyAddress;

	private static int BlueprintModifyCamera_ViewLocation_Offset;

	private static bool BlueprintModifyCamera_ViewRotation_IsValid;

	private static FFieldAddress BlueprintModifyCamera_ViewRotation_PropertyAddress;

	private static int BlueprintModifyCamera_ViewRotation_Offset;

	private static bool BlueprintModifyCamera_FOV_IsValid;

	private static FFieldAddress BlueprintModifyCamera_FOV_PropertyAddress;

	private static int BlueprintModifyCamera_FOV_Offset;

	private static bool BlueprintModifyCamera_NewViewLocation_IsValid;

	private static FFieldAddress BlueprintModifyCamera_NewViewLocation_PropertyAddress;

	private static int BlueprintModifyCamera_NewViewLocation_Offset;

	private static bool BlueprintModifyCamera_NewViewRotation_IsValid;

	private static FFieldAddress BlueprintModifyCamera_NewViewRotation_PropertyAddress;

	private static int BlueprintModifyCamera_NewViewRotation_Offset;

	private static bool BlueprintModifyCamera_NewFOV_IsValid;

	private static FFieldAddress BlueprintModifyCamera_NewFOV_PropertyAddress;

	private static int BlueprintModifyCamera_NewFOV_Offset;

	[UProperty(Flags = (PropFlags)6755468160598037uL)]
	[UMetaPath("/Script/Engine.CameraModifier:bExclusive")]
	protected bool Exclusive
	{
		get
		{
			CheckDestroyed();
			if (!Exclusive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CameraModifier:bExclusive");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Exclusive_Offset), 0, Exclusive_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Exclusive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CameraModifier:bExclusive");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Exclusive_Offset), 0, Exclusive_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234340373uL)]
	[UMetaPath("/Script/Engine.CameraModifier:Priority")]
	protected byte Priority
	{
		get
		{
			CheckDestroyed();
			if (!Priority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CameraModifier:Priority");
				return 0;
			}
			return BlittableTypeMarshaler<byte>.FromNative(IntPtr.Add(base.Address, Priority_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Priority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CameraModifier:Priority");
			}
			else
			{
				BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(base.Address, Priority_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)12393764861518356uL)]
	[UMetaPath("/Script/Engine.CameraModifier:CameraOwner")]
	protected APlayerCameraManager CameraOwner
	{
		get
		{
			CheckDestroyed();
			if (!CameraOwner_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CameraModifier:CameraOwner");
				return null;
			}
			return UObjectMarshaler<APlayerCameraManager>.FromNative(IntPtr.Add(base.Address, CameraOwner_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CameraOwner_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CameraModifier:CameraOwner");
			}
			else
			{
				UObjectMarshaler<APlayerCameraManager>.ToNative(IntPtr.Add(base.Address, CameraOwner_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954733077uL)]
	[UMetaPath("/Script/Engine.CameraModifier:AlphaInTime")]
	protected float AlphaInTime
	{
		get
		{
			CheckDestroyed();
			if (!AlphaInTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CameraModifier:AlphaInTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AlphaInTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AlphaInTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CameraModifier:AlphaInTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AlphaInTime_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954733077uL)]
	[UMetaPath("/Script/Engine.CameraModifier:AlphaOutTime")]
	protected float AlphaOutTime
	{
		get
		{
			CheckDestroyed();
			if (!AlphaOutTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CameraModifier:AlphaOutTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AlphaOutTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AlphaOutTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CameraModifier:AlphaOutTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AlphaOutTime_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954675732uL)]
	[UMetaPath("/Script/Engine.CameraModifier:Alpha")]
	protected float Alpha
	{
		get
		{
			CheckDestroyed();
			if (!Alpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CameraModifier:Alpha");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Alpha_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Alpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CameraModifier:Alpha");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Alpha_Offset), value);
			}
		}
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Engine.CameraModifier:IsDisabled")]
	public unsafe bool IsDisabled()
	{
		CheckDestroyed();
		if (!IsDisabled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CameraModifier:IsDisabled");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsDisabled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsDisabled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsDisabled_FunctionAddress, intPtr, IsDisabled_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsDisabled_ReturnValue_Offset), 0, IsDisabled_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Engine.CameraModifier:GetViewTarget")]
	public unsafe AActor GetViewTarget()
	{
		CheckDestroyed();
		if (!GetViewTarget_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CameraModifier:GetViewTarget");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetViewTarget_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetViewTarget_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetViewTarget_FunctionAddress, intPtr, GetViewTarget_ParamsSize);
		return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(intPtr, GetViewTarget_ReturnValue_Offset), 0, GetViewTarget_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.CameraModifier:EnableModifier")]
	public unsafe void EnableModifier()
	{
		CheckDestroyed();
		if (!EnableModifier_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CameraModifier:EnableModifier");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EnableModifier_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EnableModifier_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: EnableModifier_FunctionAddress, argsSize: EnableModifier_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.CameraModifier:DisableModifier")]
	public unsafe void DisableModifier(bool bImmediate = false)
	{
		CheckDestroyed();
		if (!DisableModifier_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CameraModifier:DisableModifier");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DisableModifier_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DisableModifier_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, DisableModifier_bImmediate_Offset), 0, DisableModifier_bImmediate_PropertyAddress.Address, bImmediate);
		NativeReflection.InvokeFunctionOptimized(base.Address, DisableModifier_FunctionAddress, intPtr, DisableModifier_ParamsSize);
	}

	[UFunction(Flags = 138545160u)]
	[UMetaPath("/Script/Engine.CameraModifier:BlueprintModifyPostProcess")]
	public unsafe void BlueprintModifyPostProcess(float DeltaTime, out float PostProcessBlendWeight, out FPostProcessSettings PostProcessSettings)
	{
		CheckDestroyed();
		if (!BlueprintModifyPostProcess_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CameraModifier:BlueprintModifyPostProcess");
			PostProcessBlendWeight = 0f;
			PostProcessSettings = default(FPostProcessSettings);
			return;
		}
		if (BlueprintModifyPostProcess_InstanceFunctionAddress == IntPtr.Zero)
		{
			BlueprintModifyPostProcess_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "BlueprintModifyPostProcess");
		}
		byte* ptr = stackalloc byte[(int)(uint)(BlueprintModifyPostProcess_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BlueprintModifyPostProcess_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, BlueprintModifyPostProcess_DeltaTime_Offset), 0, BlueprintModifyPostProcess_DeltaTime_PropertyAddress.Address, DeltaTime);
		NativeReflection.InitializeValue_InContainer(BlueprintModifyPostProcess_PostProcessSettings_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeFunctionOptimized(base.Address, BlueprintModifyPostProcess_InstanceFunctionAddress, intPtr, BlueprintModifyPostProcess_ParamsSize);
		PostProcessBlendWeight = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, BlueprintModifyPostProcess_PostProcessBlendWeight_Offset), 0, BlueprintModifyPostProcess_PostProcessBlendWeight_PropertyAddress.Address);
		PostProcessSettings = FPostProcessSettings.FromNative(IntPtr.Add(intPtr, BlueprintModifyPostProcess_PostProcessSettings_Offset), 0, BlueprintModifyPostProcess_PostProcessSettings_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(BlueprintModifyPostProcess_PostProcessSettings_PropertyAddress.Address, intPtr);
	}

	protected unsafe virtual void BlueprintModifyPostProcess_Implementation(float DeltaTime, out float PostProcessBlendWeight, out FPostProcessSettings PostProcessSettings)
	{
		CheckDestroyed();
		if (!BlueprintModifyPostProcess_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CameraModifier:BlueprintModifyPostProcess");
			PostProcessBlendWeight = 0f;
			PostProcessSettings = default(FPostProcessSettings);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BlueprintModifyPostProcess_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BlueprintModifyPostProcess_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, BlueprintModifyPostProcess_DeltaTime_Offset), 0, BlueprintModifyPostProcess_DeltaTime_PropertyAddress.Address, DeltaTime);
		NativeReflection.InitializeValue_InContainer(BlueprintModifyPostProcess_PostProcessSettings_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeFunctionOptimized(base.Address, BlueprintModifyPostProcess_FunctionAddress, intPtr, BlueprintModifyPostProcess_ParamsSize);
		PostProcessBlendWeight = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, BlueprintModifyPostProcess_PostProcessBlendWeight_Offset), 0, BlueprintModifyPostProcess_PostProcessBlendWeight_PropertyAddress.Address);
		PostProcessSettings = FPostProcessSettings.FromNative(IntPtr.Add(intPtr, BlueprintModifyPostProcess_PostProcessSettings_Offset), 0, BlueprintModifyPostProcess_PostProcessSettings_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(BlueprintModifyPostProcess_PostProcessSettings_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 146933768u)]
	[UMetaPath("/Script/Engine.CameraModifier:BlueprintModifyCamera")]
	public unsafe void BlueprintModifyCamera(float DeltaTime, FVector ViewLocation, FRotator ViewRotation, float FOV, out FVector NewViewLocation, out FRotator NewViewRotation, out float NewFOV)
	{
		CheckDestroyed();
		if (!BlueprintModifyCamera_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CameraModifier:BlueprintModifyCamera");
			NewViewLocation = default(FVector);
			NewViewRotation = default(FRotator);
			NewFOV = 0f;
			return;
		}
		if (BlueprintModifyCamera_InstanceFunctionAddress == IntPtr.Zero)
		{
			BlueprintModifyCamera_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "BlueprintModifyCamera");
		}
		byte* ptr = stackalloc byte[(int)(uint)(BlueprintModifyCamera_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BlueprintModifyCamera_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, BlueprintModifyCamera_DeltaTime_Offset), 0, BlueprintModifyCamera_DeltaTime_PropertyAddress.Address, DeltaTime);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, BlueprintModifyCamera_ViewLocation_Offset), 0, BlueprintModifyCamera_ViewLocation_PropertyAddress.Address, ViewLocation);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, BlueprintModifyCamera_ViewRotation_Offset), 0, BlueprintModifyCamera_ViewRotation_PropertyAddress.Address, ViewRotation);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, BlueprintModifyCamera_FOV_Offset), 0, BlueprintModifyCamera_FOV_PropertyAddress.Address, FOV);
		NativeReflection.InvokeFunctionOptimized(base.Address, BlueprintModifyCamera_InstanceFunctionAddress, intPtr, BlueprintModifyCamera_ParamsSize);
		NewViewLocation = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, BlueprintModifyCamera_NewViewLocation_Offset), 0, BlueprintModifyCamera_NewViewLocation_PropertyAddress.Address);
		NewViewRotation = BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(intPtr, BlueprintModifyCamera_NewViewRotation_Offset), 0, BlueprintModifyCamera_NewViewRotation_PropertyAddress.Address);
		NewFOV = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, BlueprintModifyCamera_NewFOV_Offset), 0, BlueprintModifyCamera_NewFOV_PropertyAddress.Address);
	}

	protected unsafe virtual void BlueprintModifyCamera_Implementation(float DeltaTime, FVector ViewLocation, FRotator ViewRotation, float FOV, out FVector NewViewLocation, out FRotator NewViewRotation, out float NewFOV)
	{
		CheckDestroyed();
		if (!BlueprintModifyCamera_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CameraModifier:BlueprintModifyCamera");
			NewViewLocation = default(FVector);
			NewViewRotation = default(FRotator);
			NewFOV = 0f;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BlueprintModifyCamera_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BlueprintModifyCamera_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, BlueprintModifyCamera_DeltaTime_Offset), 0, BlueprintModifyCamera_DeltaTime_PropertyAddress.Address, DeltaTime);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, BlueprintModifyCamera_ViewLocation_Offset), 0, BlueprintModifyCamera_ViewLocation_PropertyAddress.Address, ViewLocation);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, BlueprintModifyCamera_ViewRotation_Offset), 0, BlueprintModifyCamera_ViewRotation_PropertyAddress.Address, ViewRotation);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, BlueprintModifyCamera_FOV_Offset), 0, BlueprintModifyCamera_FOV_PropertyAddress.Address, FOV);
		NativeReflection.InvokeFunctionOptimized(base.Address, BlueprintModifyCamera_FunctionAddress, intPtr, BlueprintModifyCamera_ParamsSize);
		NewViewLocation = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, BlueprintModifyCamera_NewViewLocation_Offset), 0, BlueprintModifyCamera_NewViewLocation_PropertyAddress.Address);
		NewViewRotation = BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(intPtr, BlueprintModifyCamera_NewViewRotation_Offset), 0, BlueprintModifyCamera_NewViewRotation_PropertyAddress.Address);
		NewFOV = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, BlueprintModifyCamera_NewFOV_Offset), 0, BlueprintModifyCamera_NewFOV_PropertyAddress.Address);
	}

	static UCameraModifier()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UCameraModifier)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UCameraModifier));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.CameraModifier");
		NativeReflectionCached.GetPropertyRef(ref Exclusive_PropertyAddress, intPtr, "bExclusive");
		Exclusive_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bExclusive");
		Exclusive_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bExclusive", Classes.FBoolProperty);
		Priority_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Priority");
		Priority_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Priority", Classes.FByteProperty);
		CameraOwner_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CameraOwner");
		CameraOwner_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CameraOwner", Classes.FObjectProperty);
		AlphaInTime_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AlphaInTime");
		AlphaInTime_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AlphaInTime", Classes.FFloatProperty);
		AlphaOutTime_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AlphaOutTime");
		AlphaOutTime_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AlphaOutTime", Classes.FFloatProperty);
		Alpha_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Alpha");
		Alpha_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Alpha", Classes.FFloatProperty);
		IsDisabled_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsDisabled");
		IsDisabled_ParamsSize = NativeReflection.GetFunctionParamsSize(IsDisabled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsDisabled_ReturnValue_PropertyAddress, IsDisabled_FunctionAddress, "ReturnValue");
		IsDisabled_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsDisabled_FunctionAddress, "ReturnValue");
		IsDisabled_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsDisabled_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsDisabled_IsValid = IsDisabled_FunctionAddress != IntPtr.Zero && IsDisabled_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CameraModifier:IsDisabled", IsDisabled_IsValid);
		GetViewTarget_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetViewTarget");
		GetViewTarget_ParamsSize = NativeReflection.GetFunctionParamsSize(GetViewTarget_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetViewTarget_ReturnValue_PropertyAddress, GetViewTarget_FunctionAddress, "ReturnValue");
		GetViewTarget_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetViewTarget_FunctionAddress, "ReturnValue");
		GetViewTarget_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetViewTarget_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetViewTarget_IsValid = GetViewTarget_FunctionAddress != IntPtr.Zero && GetViewTarget_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CameraModifier:GetViewTarget", GetViewTarget_IsValid);
		EnableModifier_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "EnableModifier");
		EnableModifier_ParamsSize = NativeReflection.GetFunctionParamsSize(EnableModifier_FunctionAddress);
		EnableModifier_IsValid = EnableModifier_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CameraModifier:EnableModifier", EnableModifier_IsValid);
		DisableModifier_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "DisableModifier");
		DisableModifier_ParamsSize = NativeReflection.GetFunctionParamsSize(DisableModifier_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DisableModifier_bImmediate_PropertyAddress, DisableModifier_FunctionAddress, "bImmediate");
		DisableModifier_bImmediate_Offset = NativeReflectionCached.GetPropertyOffset(DisableModifier_FunctionAddress, "bImmediate");
		DisableModifier_bImmediate_IsValid = NativeReflectionCached.ValidatePropertyClass(DisableModifier_FunctionAddress, "bImmediate", Classes.FBoolProperty);
		DisableModifier_IsValid = DisableModifier_FunctionAddress != IntPtr.Zero && DisableModifier_bImmediate_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CameraModifier:DisableModifier", DisableModifier_IsValid);
		BlueprintModifyPostProcess_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BlueprintModifyPostProcess");
		BlueprintModifyPostProcess_ParamsSize = NativeReflection.GetFunctionParamsSize(BlueprintModifyPostProcess_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BlueprintModifyPostProcess_DeltaTime_PropertyAddress, BlueprintModifyPostProcess_FunctionAddress, "DeltaTime");
		BlueprintModifyPostProcess_DeltaTime_Offset = NativeReflectionCached.GetPropertyOffset(BlueprintModifyPostProcess_FunctionAddress, "DeltaTime");
		BlueprintModifyPostProcess_DeltaTime_IsValid = NativeReflectionCached.ValidatePropertyClass(BlueprintModifyPostProcess_FunctionAddress, "DeltaTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref BlueprintModifyPostProcess_PostProcessBlendWeight_PropertyAddress, BlueprintModifyPostProcess_FunctionAddress, "PostProcessBlendWeight");
		BlueprintModifyPostProcess_PostProcessBlendWeight_Offset = NativeReflectionCached.GetPropertyOffset(BlueprintModifyPostProcess_FunctionAddress, "PostProcessBlendWeight");
		BlueprintModifyPostProcess_PostProcessBlendWeight_IsValid = NativeReflectionCached.ValidatePropertyClass(BlueprintModifyPostProcess_FunctionAddress, "PostProcessBlendWeight", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref BlueprintModifyPostProcess_PostProcessSettings_PropertyAddress, BlueprintModifyPostProcess_FunctionAddress, "PostProcessSettings");
		BlueprintModifyPostProcess_PostProcessSettings_Offset = NativeReflectionCached.GetPropertyOffset(BlueprintModifyPostProcess_FunctionAddress, "PostProcessSettings");
		BlueprintModifyPostProcess_PostProcessSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(BlueprintModifyPostProcess_FunctionAddress, "PostProcessSettings", Classes.FStructProperty);
		BlueprintModifyPostProcess_IsValid = BlueprintModifyPostProcess_FunctionAddress != IntPtr.Zero && BlueprintModifyPostProcess_DeltaTime_IsValid && BlueprintModifyPostProcess_PostProcessBlendWeight_IsValid && BlueprintModifyPostProcess_PostProcessSettings_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CameraModifier:BlueprintModifyPostProcess", BlueprintModifyPostProcess_IsValid);
		BlueprintModifyCamera_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BlueprintModifyCamera");
		BlueprintModifyCamera_ParamsSize = NativeReflection.GetFunctionParamsSize(BlueprintModifyCamera_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BlueprintModifyCamera_DeltaTime_PropertyAddress, BlueprintModifyCamera_FunctionAddress, "DeltaTime");
		BlueprintModifyCamera_DeltaTime_Offset = NativeReflectionCached.GetPropertyOffset(BlueprintModifyCamera_FunctionAddress, "DeltaTime");
		BlueprintModifyCamera_DeltaTime_IsValid = NativeReflectionCached.ValidatePropertyClass(BlueprintModifyCamera_FunctionAddress, "DeltaTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref BlueprintModifyCamera_ViewLocation_PropertyAddress, BlueprintModifyCamera_FunctionAddress, "ViewLocation");
		BlueprintModifyCamera_ViewLocation_Offset = NativeReflectionCached.GetPropertyOffset(BlueprintModifyCamera_FunctionAddress, "ViewLocation");
		BlueprintModifyCamera_ViewLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(BlueprintModifyCamera_FunctionAddress, "ViewLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BlueprintModifyCamera_ViewRotation_PropertyAddress, BlueprintModifyCamera_FunctionAddress, "ViewRotation");
		BlueprintModifyCamera_ViewRotation_Offset = NativeReflectionCached.GetPropertyOffset(BlueprintModifyCamera_FunctionAddress, "ViewRotation");
		BlueprintModifyCamera_ViewRotation_IsValid = NativeReflectionCached.ValidatePropertyClass(BlueprintModifyCamera_FunctionAddress, "ViewRotation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BlueprintModifyCamera_FOV_PropertyAddress, BlueprintModifyCamera_FunctionAddress, "FOV");
		BlueprintModifyCamera_FOV_Offset = NativeReflectionCached.GetPropertyOffset(BlueprintModifyCamera_FunctionAddress, "FOV");
		BlueprintModifyCamera_FOV_IsValid = NativeReflectionCached.ValidatePropertyClass(BlueprintModifyCamera_FunctionAddress, "FOV", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref BlueprintModifyCamera_NewViewLocation_PropertyAddress, BlueprintModifyCamera_FunctionAddress, "NewViewLocation");
		BlueprintModifyCamera_NewViewLocation_Offset = NativeReflectionCached.GetPropertyOffset(BlueprintModifyCamera_FunctionAddress, "NewViewLocation");
		BlueprintModifyCamera_NewViewLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(BlueprintModifyCamera_FunctionAddress, "NewViewLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BlueprintModifyCamera_NewViewRotation_PropertyAddress, BlueprintModifyCamera_FunctionAddress, "NewViewRotation");
		BlueprintModifyCamera_NewViewRotation_Offset = NativeReflectionCached.GetPropertyOffset(BlueprintModifyCamera_FunctionAddress, "NewViewRotation");
		BlueprintModifyCamera_NewViewRotation_IsValid = NativeReflectionCached.ValidatePropertyClass(BlueprintModifyCamera_FunctionAddress, "NewViewRotation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BlueprintModifyCamera_NewFOV_PropertyAddress, BlueprintModifyCamera_FunctionAddress, "NewFOV");
		BlueprintModifyCamera_NewFOV_Offset = NativeReflectionCached.GetPropertyOffset(BlueprintModifyCamera_FunctionAddress, "NewFOV");
		BlueprintModifyCamera_NewFOV_IsValid = NativeReflectionCached.ValidatePropertyClass(BlueprintModifyCamera_FunctionAddress, "NewFOV", Classes.FFloatProperty);
		BlueprintModifyCamera_IsValid = BlueprintModifyCamera_FunctionAddress != IntPtr.Zero && BlueprintModifyCamera_DeltaTime_IsValid && BlueprintModifyCamera_ViewLocation_IsValid && BlueprintModifyCamera_ViewRotation_IsValid && BlueprintModifyCamera_FOV_IsValid && BlueprintModifyCamera_NewViewLocation_IsValid && BlueprintModifyCamera_NewViewRotation_IsValid && BlueprintModifyCamera_NewFOV_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CameraModifier:BlueprintModifyCamera", BlueprintModifyCamera_IsValid);
	}
}
