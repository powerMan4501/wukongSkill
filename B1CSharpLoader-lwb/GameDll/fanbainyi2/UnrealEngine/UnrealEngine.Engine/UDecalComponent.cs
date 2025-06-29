using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.DecalComponent", "Engine", UnrealModuleType.Engine)]
public class UDecalComponent : USceneComponent
{
	private static bool DecalMaterial_IsValid;

	private static int DecalMaterial_Offset;

	private static bool SortOrder_IsValid;

	private static int SortOrder_Offset;

	private static bool FadeScreenSize_IsValid;

	private static int FadeScreenSize_Offset;

	private static bool FadeStartDelay_IsValid;

	private static int FadeStartDelay_Offset;

	private static bool FadeDuration_IsValid;

	private static int FadeDuration_Offset;

	private static bool FadeInDuration_IsValid;

	private static int FadeInDuration_Offset;

	private static bool FadeInStartDelay_IsValid;

	private static int FadeInStartDelay_Offset;

	private static bool DestroyOwnerAfterFade_IsValid;

	private static FFieldAddress DestroyOwnerAfterFade_PropertyAddress;

	private static int DestroyOwnerAfterFade_Offset;

	private static bool DecalSize_IsValid;

	private static int DecalSize_Offset;

	private static bool SetSortOrder_IsValid;

	private static IntPtr SetSortOrder_FunctionAddress;

	private static int SetSortOrder_ParamsSize;

	private static bool SetSortOrder_Value_IsValid;

	private static FFieldAddress SetSortOrder_Value_PropertyAddress;

	private static int SetSortOrder_Value_Offset;

	private static bool SetFadeScreenSize_IsValid;

	private static IntPtr SetFadeScreenSize_FunctionAddress;

	private static int SetFadeScreenSize_ParamsSize;

	private static bool SetFadeScreenSize_NewFadeScreenSize_IsValid;

	private static FFieldAddress SetFadeScreenSize_NewFadeScreenSize_PropertyAddress;

	private static int SetFadeScreenSize_NewFadeScreenSize_Offset;

	private static bool SetFadeOut_IsValid;

	private static IntPtr SetFadeOut_FunctionAddress;

	private static int SetFadeOut_ParamsSize;

	private static bool SetFadeOut_StartDelay_IsValid;

	private static FFieldAddress SetFadeOut_StartDelay_PropertyAddress;

	private static int SetFadeOut_StartDelay_Offset;

	private static bool SetFadeOut_Duration_IsValid;

	private static FFieldAddress SetFadeOut_Duration_PropertyAddress;

	private static int SetFadeOut_Duration_Offset;

	private static bool SetFadeOut_DestroyOwnerAfterFade_IsValid;

	private static FFieldAddress SetFadeOut_DestroyOwnerAfterFade_PropertyAddress;

	private static int SetFadeOut_DestroyOwnerAfterFade_Offset;

	private static bool SetFadeIn_IsValid;

	private static IntPtr SetFadeIn_FunctionAddress;

	private static int SetFadeIn_ParamsSize;

	private static bool SetFadeIn_StartDelay_IsValid;

	private static FFieldAddress SetFadeIn_StartDelay_PropertyAddress;

	private static int SetFadeIn_StartDelay_Offset;

	private static bool SetFadeIn_Duaration_IsValid;

	private static FFieldAddress SetFadeIn_Duaration_PropertyAddress;

	private static int SetFadeIn_Duaration_Offset;

	private static bool SetDecalMaterial_IsValid;

	private static IntPtr SetDecalMaterial_FunctionAddress;

	private static int SetDecalMaterial_ParamsSize;

	private static bool SetDecalMaterial_NewDecalMaterial_IsValid;

	private static FFieldAddress SetDecalMaterial_NewDecalMaterial_PropertyAddress;

	private static int SetDecalMaterial_NewDecalMaterial_Offset;

	private static bool GetFadeStartDelay_IsValid;

	private static IntPtr GetFadeStartDelay_FunctionAddress;

	private static int GetFadeStartDelay_ParamsSize;

	private static bool GetFadeStartDelay_ReturnValue_IsValid;

	private static FFieldAddress GetFadeStartDelay_ReturnValue_PropertyAddress;

	private static int GetFadeStartDelay_ReturnValue_Offset;

	private static bool GetFadeInStartDelay_IsValid;

	private static IntPtr GetFadeInStartDelay_FunctionAddress;

	private static int GetFadeInStartDelay_ParamsSize;

	private static bool GetFadeInStartDelay_ReturnValue_IsValid;

	private static FFieldAddress GetFadeInStartDelay_ReturnValue_PropertyAddress;

	private static int GetFadeInStartDelay_ReturnValue_Offset;

	private static bool GetFadeInDuration_IsValid;

	private static IntPtr GetFadeInDuration_FunctionAddress;

	private static int GetFadeInDuration_ParamsSize;

	private static bool GetFadeInDuration_ReturnValue_IsValid;

	private static FFieldAddress GetFadeInDuration_ReturnValue_PropertyAddress;

	private static int GetFadeInDuration_ReturnValue_Offset;

	private static bool GetFadeDuration_IsValid;

	private static IntPtr GetFadeDuration_FunctionAddress;

	private static int GetFadeDuration_ParamsSize;

	private static bool GetFadeDuration_ReturnValue_IsValid;

	private static FFieldAddress GetFadeDuration_ReturnValue_PropertyAddress;

	private static int GetFadeDuration_ReturnValue_Offset;

	private static bool GetDecalMaterial_IsValid;

	private static IntPtr GetDecalMaterial_FunctionAddress;

	private static int GetDecalMaterial_ParamsSize;

	private static bool GetDecalMaterial_ReturnValue_IsValid;

	private static FFieldAddress GetDecalMaterial_ReturnValue_PropertyAddress;

	private static int GetDecalMaterial_ReturnValue_Offset;

	private static bool CreateDynamicMaterialInstance_IsValid;

	private static IntPtr CreateDynamicMaterialInstance_FunctionAddress;

	private static int CreateDynamicMaterialInstance_ParamsSize;

	private static bool CreateDynamicMaterialInstance_ReturnValue_IsValid;

	private static FFieldAddress CreateDynamicMaterialInstance_ReturnValue_PropertyAddress;

	private static int CreateDynamicMaterialInstance_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)12393764861510165uL)]
	[UMetaPath("/Script/Engine.DecalComponent:DecalMaterial")]
	protected UMaterialInterface DecalMaterial
	{
		get
		{
			CheckDestroyed();
			if (!DecalMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DecalComponent:DecalMaterial");
				return null;
			}
			return UObjectMarshaler<UMaterialInterface>.FromNative(IntPtr.Add(base.Address, DecalMaterial_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DecalMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DecalComponent:DecalMaterial");
			}
			else
			{
				UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(base.Address, DecalMaterial_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.DecalComponent:SortOrder")]
	public int SortOrder
	{
		get
		{
			CheckDestroyed();
			if (!SortOrder_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DecalComponent:SortOrder");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, SortOrder_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SortOrder_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DecalComponent:SortOrder");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, SortOrder_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.DecalComponent:FadeScreenSize")]
	public float FadeScreenSize
	{
		get
		{
			CheckDestroyed();
			if (!FadeScreenSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DecalComponent:FadeScreenSize");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FadeScreenSize_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FadeScreenSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DecalComponent:FadeScreenSize");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FadeScreenSize_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.DecalComponent:FadeStartDelay")]
	public float FadeStartDelay
	{
		get
		{
			CheckDestroyed();
			if (!FadeStartDelay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DecalComponent:FadeStartDelay");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FadeStartDelay_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FadeStartDelay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DecalComponent:FadeStartDelay");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FadeStartDelay_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.DecalComponent:FadeDuration")]
	public float FadeDuration
	{
		get
		{
			CheckDestroyed();
			if (!FadeDuration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DecalComponent:FadeDuration");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FadeDuration_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FadeDuration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DecalComponent:FadeDuration");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FadeDuration_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.DecalComponent:FadeInDuration")]
	public float FadeInDuration
	{
		get
		{
			CheckDestroyed();
			if (!FadeInDuration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DecalComponent:FadeInDuration");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FadeInDuration_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FadeInDuration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DecalComponent:FadeInDuration");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FadeInDuration_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.DecalComponent:FadeInStartDelay")]
	public float FadeInStartDelay
	{
		get
		{
			CheckDestroyed();
			if (!FadeInStartDelay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DecalComponent:FadeInStartDelay");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FadeInStartDelay_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FadeInStartDelay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DecalComponent:FadeInStartDelay");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FadeInStartDelay_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.DecalComponent:bDestroyOwnerAfterFade")]
	public bool DestroyOwnerAfterFade
	{
		get
		{
			CheckDestroyed();
			if (!DestroyOwnerAfterFade_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DecalComponent:bDestroyOwnerAfterFade");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DestroyOwnerAfterFade_Offset), 0, DestroyOwnerAfterFade_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DestroyOwnerAfterFade_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DecalComponent:bDestroyOwnerAfterFade");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DestroyOwnerAfterFade_Offset), 0, DestroyOwnerAfterFade_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.DecalComponent:DecalSize")]
	public FVector DecalSize
	{
		get
		{
			CheckDestroyed();
			if (!DecalSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DecalComponent:DecalSize");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, DecalSize_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DecalSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DecalComponent:DecalSize");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, DecalSize_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.DecalComponent:SetSortOrder")]
	public unsafe void SetSortOrder(int Value)
	{
		CheckDestroyed();
		if (!SetSortOrder_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.DecalComponent:SetSortOrder");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSortOrder_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSortOrder_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetSortOrder_Value_Offset), 0, SetSortOrder_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSortOrder_FunctionAddress, intPtr, SetSortOrder_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.DecalComponent:SetFadeScreenSize")]
	public unsafe void SetFadeScreenSize(float NewFadeScreenSize)
	{
		CheckDestroyed();
		if (!SetFadeScreenSize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.DecalComponent:SetFadeScreenSize");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetFadeScreenSize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetFadeScreenSize_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetFadeScreenSize_NewFadeScreenSize_Offset), 0, SetFadeScreenSize_NewFadeScreenSize_PropertyAddress.Address, NewFadeScreenSize);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetFadeScreenSize_FunctionAddress, intPtr, SetFadeScreenSize_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.DecalComponent:SetFadeOut")]
	public unsafe void SetFadeOut(float StartDelay, float Duration, bool DestroyOwnerAfterFade = true)
	{
		CheckDestroyed();
		if (!SetFadeOut_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.DecalComponent:SetFadeOut");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetFadeOut_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetFadeOut_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetFadeOut_StartDelay_Offset), 0, SetFadeOut_StartDelay_PropertyAddress.Address, StartDelay);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetFadeOut_Duration_Offset), 0, SetFadeOut_Duration_PropertyAddress.Address, Duration);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetFadeOut_DestroyOwnerAfterFade_Offset), 0, SetFadeOut_DestroyOwnerAfterFade_PropertyAddress.Address, DestroyOwnerAfterFade);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetFadeOut_FunctionAddress, intPtr, SetFadeOut_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.DecalComponent:SetFadeIn")]
	public unsafe void SetFadeIn(float StartDelay, float Duaration)
	{
		CheckDestroyed();
		if (!SetFadeIn_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.DecalComponent:SetFadeIn");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetFadeIn_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetFadeIn_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetFadeIn_StartDelay_Offset), 0, SetFadeIn_StartDelay_PropertyAddress.Address, StartDelay);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetFadeIn_Duaration_Offset), 0, SetFadeIn_Duaration_PropertyAddress.Address, Duaration);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetFadeIn_FunctionAddress, intPtr, SetFadeIn_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.DecalComponent:SetDecalMaterial")]
	public unsafe void SetDecalMaterial(UMaterialInterface NewDecalMaterial)
	{
		CheckDestroyed();
		if (!SetDecalMaterial_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.DecalComponent:SetDecalMaterial");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDecalMaterial_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDecalMaterial_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(intPtr, SetDecalMaterial_NewDecalMaterial_Offset), 0, SetDecalMaterial_NewDecalMaterial_PropertyAddress.Address, NewDecalMaterial);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetDecalMaterial_FunctionAddress, intPtr, SetDecalMaterial_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.DecalComponent:GetFadeStartDelay")]
	public unsafe float GetFadeStartDelay()
	{
		CheckDestroyed();
		if (!GetFadeStartDelay_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.DecalComponent:GetFadeStartDelay");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetFadeStartDelay_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetFadeStartDelay_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetFadeStartDelay_FunctionAddress, intPtr, GetFadeStartDelay_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetFadeStartDelay_ReturnValue_Offset), 0, GetFadeStartDelay_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.DecalComponent:GetFadeInStartDelay")]
	public unsafe float GetFadeInStartDelay()
	{
		CheckDestroyed();
		if (!GetFadeInStartDelay_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.DecalComponent:GetFadeInStartDelay");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetFadeInStartDelay_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetFadeInStartDelay_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetFadeInStartDelay_FunctionAddress, intPtr, GetFadeInStartDelay_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetFadeInStartDelay_ReturnValue_Offset), 0, GetFadeInStartDelay_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.DecalComponent:GetFadeInDuration")]
	public unsafe float GetFadeInDuration()
	{
		CheckDestroyed();
		if (!GetFadeInDuration_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.DecalComponent:GetFadeInDuration");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetFadeInDuration_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetFadeInDuration_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetFadeInDuration_FunctionAddress, intPtr, GetFadeInDuration_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetFadeInDuration_ReturnValue_Offset), 0, GetFadeInDuration_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.DecalComponent:GetFadeDuration")]
	public unsafe float GetFadeDuration()
	{
		CheckDestroyed();
		if (!GetFadeDuration_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.DecalComponent:GetFadeDuration");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetFadeDuration_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetFadeDuration_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetFadeDuration_FunctionAddress, intPtr, GetFadeDuration_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetFadeDuration_ReturnValue_Offset), 0, GetFadeDuration_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.DecalComponent:GetDecalMaterial")]
	public unsafe UMaterialInterface GetDecalMaterial()
	{
		CheckDestroyed();
		if (!GetDecalMaterial_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.DecalComponent:GetDecalMaterial");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDecalMaterial_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDecalMaterial_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDecalMaterial_FunctionAddress, intPtr, GetDecalMaterial_ParamsSize);
		return UObjectMarshaler<UMaterialInterface>.FromNative(IntPtr.Add(intPtr, GetDecalMaterial_ReturnValue_Offset), 0, GetDecalMaterial_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.DecalComponent:CreateDynamicMaterialInstance")]
	public unsafe UMaterialInstanceDynamic CreateDynamicMaterialInstance()
	{
		CheckDestroyed();
		if (!CreateDynamicMaterialInstance_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.DecalComponent:CreateDynamicMaterialInstance");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateDynamicMaterialInstance_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateDynamicMaterialInstance_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, CreateDynamicMaterialInstance_FunctionAddress, intPtr, CreateDynamicMaterialInstance_ParamsSize);
		return UObjectMarshaler<UMaterialInstanceDynamic>.FromNative(IntPtr.Add(intPtr, CreateDynamicMaterialInstance_ReturnValue_Offset), 0, CreateDynamicMaterialInstance_ReturnValue_PropertyAddress.Address);
	}

	static UDecalComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UDecalComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UDecalComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.DecalComponent");
		DecalMaterial_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DecalMaterial");
		DecalMaterial_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DecalMaterial", Classes.FObjectProperty);
		SortOrder_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SortOrder");
		SortOrder_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SortOrder", Classes.FIntProperty);
		FadeScreenSize_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FadeScreenSize");
		FadeScreenSize_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FadeScreenSize", Classes.FFloatProperty);
		FadeStartDelay_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FadeStartDelay");
		FadeStartDelay_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FadeStartDelay", Classes.FFloatProperty);
		FadeDuration_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FadeDuration");
		FadeDuration_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FadeDuration", Classes.FFloatProperty);
		FadeInDuration_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FadeInDuration");
		FadeInDuration_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FadeInDuration", Classes.FFloatProperty);
		FadeInStartDelay_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FadeInStartDelay");
		FadeInStartDelay_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FadeInStartDelay", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DestroyOwnerAfterFade_PropertyAddress, intPtr, "bDestroyOwnerAfterFade");
		DestroyOwnerAfterFade_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bDestroyOwnerAfterFade");
		DestroyOwnerAfterFade_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bDestroyOwnerAfterFade", Classes.FBoolProperty);
		DecalSize_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DecalSize");
		DecalSize_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DecalSize", Classes.FStructProperty);
		SetSortOrder_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSortOrder");
		SetSortOrder_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSortOrder_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSortOrder_Value_PropertyAddress, SetSortOrder_FunctionAddress, "Value");
		SetSortOrder_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetSortOrder_FunctionAddress, "Value");
		SetSortOrder_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSortOrder_FunctionAddress, "Value", Classes.FIntProperty);
		SetSortOrder_IsValid = SetSortOrder_FunctionAddress != IntPtr.Zero && SetSortOrder_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.DecalComponent:SetSortOrder", SetSortOrder_IsValid);
		SetFadeScreenSize_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetFadeScreenSize");
		SetFadeScreenSize_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFadeScreenSize_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetFadeScreenSize_NewFadeScreenSize_PropertyAddress, SetFadeScreenSize_FunctionAddress, "NewFadeScreenSize");
		SetFadeScreenSize_NewFadeScreenSize_Offset = NativeReflectionCached.GetPropertyOffset(SetFadeScreenSize_FunctionAddress, "NewFadeScreenSize");
		SetFadeScreenSize_NewFadeScreenSize_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFadeScreenSize_FunctionAddress, "NewFadeScreenSize", Classes.FFloatProperty);
		SetFadeScreenSize_IsValid = SetFadeScreenSize_FunctionAddress != IntPtr.Zero && SetFadeScreenSize_NewFadeScreenSize_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.DecalComponent:SetFadeScreenSize", SetFadeScreenSize_IsValid);
		SetFadeOut_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetFadeOut");
		SetFadeOut_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFadeOut_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetFadeOut_StartDelay_PropertyAddress, SetFadeOut_FunctionAddress, "StartDelay");
		SetFadeOut_StartDelay_Offset = NativeReflectionCached.GetPropertyOffset(SetFadeOut_FunctionAddress, "StartDelay");
		SetFadeOut_StartDelay_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFadeOut_FunctionAddress, "StartDelay", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetFadeOut_Duration_PropertyAddress, SetFadeOut_FunctionAddress, "Duration");
		SetFadeOut_Duration_Offset = NativeReflectionCached.GetPropertyOffset(SetFadeOut_FunctionAddress, "Duration");
		SetFadeOut_Duration_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFadeOut_FunctionAddress, "Duration", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetFadeOut_DestroyOwnerAfterFade_PropertyAddress, SetFadeOut_FunctionAddress, "DestroyOwnerAfterFade");
		SetFadeOut_DestroyOwnerAfterFade_Offset = NativeReflectionCached.GetPropertyOffset(SetFadeOut_FunctionAddress, "DestroyOwnerAfterFade");
		SetFadeOut_DestroyOwnerAfterFade_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFadeOut_FunctionAddress, "DestroyOwnerAfterFade", Classes.FBoolProperty);
		SetFadeOut_IsValid = SetFadeOut_FunctionAddress != IntPtr.Zero && SetFadeOut_StartDelay_IsValid && SetFadeOut_Duration_IsValid && SetFadeOut_DestroyOwnerAfterFade_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.DecalComponent:SetFadeOut", SetFadeOut_IsValid);
		SetFadeIn_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetFadeIn");
		SetFadeIn_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFadeIn_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetFadeIn_StartDelay_PropertyAddress, SetFadeIn_FunctionAddress, "StartDelay");
		SetFadeIn_StartDelay_Offset = NativeReflectionCached.GetPropertyOffset(SetFadeIn_FunctionAddress, "StartDelay");
		SetFadeIn_StartDelay_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFadeIn_FunctionAddress, "StartDelay", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetFadeIn_Duaration_PropertyAddress, SetFadeIn_FunctionAddress, "Duaration");
		SetFadeIn_Duaration_Offset = NativeReflectionCached.GetPropertyOffset(SetFadeIn_FunctionAddress, "Duaration");
		SetFadeIn_Duaration_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFadeIn_FunctionAddress, "Duaration", Classes.FFloatProperty);
		SetFadeIn_IsValid = SetFadeIn_FunctionAddress != IntPtr.Zero && SetFadeIn_StartDelay_IsValid && SetFadeIn_Duaration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.DecalComponent:SetFadeIn", SetFadeIn_IsValid);
		SetDecalMaterial_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetDecalMaterial");
		SetDecalMaterial_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDecalMaterial_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDecalMaterial_NewDecalMaterial_PropertyAddress, SetDecalMaterial_FunctionAddress, "NewDecalMaterial");
		SetDecalMaterial_NewDecalMaterial_Offset = NativeReflectionCached.GetPropertyOffset(SetDecalMaterial_FunctionAddress, "NewDecalMaterial");
		SetDecalMaterial_NewDecalMaterial_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDecalMaterial_FunctionAddress, "NewDecalMaterial", Classes.FObjectProperty);
		SetDecalMaterial_IsValid = SetDecalMaterial_FunctionAddress != IntPtr.Zero && SetDecalMaterial_NewDecalMaterial_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.DecalComponent:SetDecalMaterial", SetDecalMaterial_IsValid);
		GetFadeStartDelay_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetFadeStartDelay");
		GetFadeStartDelay_ParamsSize = NativeReflection.GetFunctionParamsSize(GetFadeStartDelay_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetFadeStartDelay_ReturnValue_PropertyAddress, GetFadeStartDelay_FunctionAddress, "ReturnValue");
		GetFadeStartDelay_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetFadeStartDelay_FunctionAddress, "ReturnValue");
		GetFadeStartDelay_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFadeStartDelay_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetFadeStartDelay_IsValid = GetFadeStartDelay_FunctionAddress != IntPtr.Zero && GetFadeStartDelay_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.DecalComponent:GetFadeStartDelay", GetFadeStartDelay_IsValid);
		GetFadeInStartDelay_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetFadeInStartDelay");
		GetFadeInStartDelay_ParamsSize = NativeReflection.GetFunctionParamsSize(GetFadeInStartDelay_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetFadeInStartDelay_ReturnValue_PropertyAddress, GetFadeInStartDelay_FunctionAddress, "ReturnValue");
		GetFadeInStartDelay_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetFadeInStartDelay_FunctionAddress, "ReturnValue");
		GetFadeInStartDelay_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFadeInStartDelay_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetFadeInStartDelay_IsValid = GetFadeInStartDelay_FunctionAddress != IntPtr.Zero && GetFadeInStartDelay_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.DecalComponent:GetFadeInStartDelay", GetFadeInStartDelay_IsValid);
		GetFadeInDuration_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetFadeInDuration");
		GetFadeInDuration_ParamsSize = NativeReflection.GetFunctionParamsSize(GetFadeInDuration_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetFadeInDuration_ReturnValue_PropertyAddress, GetFadeInDuration_FunctionAddress, "ReturnValue");
		GetFadeInDuration_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetFadeInDuration_FunctionAddress, "ReturnValue");
		GetFadeInDuration_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFadeInDuration_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetFadeInDuration_IsValid = GetFadeInDuration_FunctionAddress != IntPtr.Zero && GetFadeInDuration_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.DecalComponent:GetFadeInDuration", GetFadeInDuration_IsValid);
		GetFadeDuration_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetFadeDuration");
		GetFadeDuration_ParamsSize = NativeReflection.GetFunctionParamsSize(GetFadeDuration_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetFadeDuration_ReturnValue_PropertyAddress, GetFadeDuration_FunctionAddress, "ReturnValue");
		GetFadeDuration_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetFadeDuration_FunctionAddress, "ReturnValue");
		GetFadeDuration_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFadeDuration_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetFadeDuration_IsValid = GetFadeDuration_FunctionAddress != IntPtr.Zero && GetFadeDuration_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.DecalComponent:GetFadeDuration", GetFadeDuration_IsValid);
		GetDecalMaterial_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetDecalMaterial");
		GetDecalMaterial_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDecalMaterial_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDecalMaterial_ReturnValue_PropertyAddress, GetDecalMaterial_FunctionAddress, "ReturnValue");
		GetDecalMaterial_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDecalMaterial_FunctionAddress, "ReturnValue");
		GetDecalMaterial_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDecalMaterial_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetDecalMaterial_IsValid = GetDecalMaterial_FunctionAddress != IntPtr.Zero && GetDecalMaterial_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.DecalComponent:GetDecalMaterial", GetDecalMaterial_IsValid);
		CreateDynamicMaterialInstance_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CreateDynamicMaterialInstance");
		CreateDynamicMaterialInstance_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateDynamicMaterialInstance_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateDynamicMaterialInstance_ReturnValue_PropertyAddress, CreateDynamicMaterialInstance_FunctionAddress, "ReturnValue");
		CreateDynamicMaterialInstance_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CreateDynamicMaterialInstance_FunctionAddress, "ReturnValue");
		CreateDynamicMaterialInstance_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateDynamicMaterialInstance_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		CreateDynamicMaterialInstance_IsValid = CreateDynamicMaterialInstance_FunctionAddress != IntPtr.Zero && CreateDynamicMaterialInstance_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.DecalComponent:CreateDynamicMaterialInstance", CreateDynamicMaterialInstance_IsValid);
	}
}
