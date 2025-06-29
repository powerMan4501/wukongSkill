using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)821039268uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Engine.RectLightComponent", "Engine", UnrealModuleType.Engine)]
public class URectLightComponent : ULocalLightComponent
{
	private static bool SourceWidth_IsValid;

	private static int SourceWidth_Offset;

	private static bool SourceHeight_IsValid;

	private static int SourceHeight_Offset;

	private static bool BarnDoorAngle_IsValid;

	private static int BarnDoorAngle_Offset;

	private static bool BarnDoorLength_IsValid;

	private static int BarnDoorLength_Offset;

	private static bool SourceTexture_IsValid;

	private static int SourceTexture_Offset;

	private static bool SetSourceWidth_IsValid;

	private static IntPtr SetSourceWidth_FunctionAddress;

	private static int SetSourceWidth_ParamsSize;

	private static bool SetSourceWidth_bNewValue_IsValid;

	private static FFieldAddress SetSourceWidth_bNewValue_PropertyAddress;

	private static int SetSourceWidth_bNewValue_Offset;

	private static bool SetSourceTexture_IsValid;

	private static IntPtr SetSourceTexture_FunctionAddress;

	private static int SetSourceTexture_ParamsSize;

	private static bool SetSourceTexture_bNewValue_IsValid;

	private static FFieldAddress SetSourceTexture_bNewValue_PropertyAddress;

	private static int SetSourceTexture_bNewValue_Offset;

	private static bool SetSourceHeight_IsValid;

	private static IntPtr SetSourceHeight_FunctionAddress;

	private static int SetSourceHeight_ParamsSize;

	private static bool SetSourceHeight_NewValue_IsValid;

	private static FFieldAddress SetSourceHeight_NewValue_PropertyAddress;

	private static int SetSourceHeight_NewValue_Offset;

	private static bool SetBarnDoorLength_IsValid;

	private static IntPtr SetBarnDoorLength_FunctionAddress;

	private static int SetBarnDoorLength_ParamsSize;

	private static bool SetBarnDoorLength_NewValue_IsValid;

	private static FFieldAddress SetBarnDoorLength_NewValue_PropertyAddress;

	private static int SetBarnDoorLength_NewValue_Offset;

	private static bool SetBarnDoorAngle_IsValid;

	private static IntPtr SetBarnDoorAngle_FunctionAddress;

	private static int SetBarnDoorAngle_ParamsSize;

	private static bool SetBarnDoorAngle_NewValue_IsValid;

	private static FFieldAddress SetBarnDoorAngle_NewValue_PropertyAddress;

	private static int SetBarnDoorAngle_NewValue_Offset;

	[UProperty(Flags = (PropFlags)6755477824209429uL)]
	[UMetaPath("/Script/Engine.RectLightComponent:SourceWidth")]
	public float SourceWidth
	{
		get
		{
			CheckDestroyed();
			if (!SourceWidth_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.RectLightComponent:SourceWidth");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SourceWidth_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SourceWidth_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.RectLightComponent:SourceWidth");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SourceWidth_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755477824209429uL)]
	[UMetaPath("/Script/Engine.RectLightComponent:SourceHeight")]
	public float SourceHeight
	{
		get
		{
			CheckDestroyed();
			if (!SourceHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.RectLightComponent:SourceHeight");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SourceHeight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SourceHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.RectLightComponent:SourceHeight");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SourceHeight_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755477824209429uL)]
	[UMetaPath("/Script/Engine.RectLightComponent:BarnDoorAngle")]
	public float BarnDoorAngle
	{
		get
		{
			CheckDestroyed();
			if (!BarnDoorAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.RectLightComponent:BarnDoorAngle");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BarnDoorAngle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BarnDoorAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.RectLightComponent:BarnDoorAngle");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BarnDoorAngle_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755477824209429uL)]
	[UMetaPath("/Script/Engine.RectLightComponent:BarnDoorLength")]
	public float BarnDoorLength
	{
		get
		{
			CheckDestroyed();
			if (!BarnDoorLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.RectLightComponent:BarnDoorLength");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BarnDoorLength_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BarnDoorLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.RectLightComponent:BarnDoorLength");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BarnDoorLength_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141117461uL)]
	[UMetaPath("/Script/Engine.RectLightComponent:SourceTexture")]
	public UTexture SourceTexture
	{
		get
		{
			CheckDestroyed();
			if (!SourceTexture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.RectLightComponent:SourceTexture");
				return null;
			}
			return UObjectMarshaler<UTexture>.FromNative(IntPtr.Add(base.Address, SourceTexture_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SourceTexture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.RectLightComponent:SourceTexture");
			}
			else
			{
				UObjectMarshaler<UTexture>.ToNative(IntPtr.Add(base.Address, SourceTexture_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.RectLightComponent:SetSourceWidth")]
	public unsafe void SetSourceWidth(float bNewValue)
	{
		CheckDestroyed();
		if (!SetSourceWidth_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.RectLightComponent:SetSourceWidth");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSourceWidth_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSourceWidth_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetSourceWidth_bNewValue_Offset), 0, SetSourceWidth_bNewValue_PropertyAddress.Address, bNewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSourceWidth_FunctionAddress, intPtr, SetSourceWidth_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.RectLightComponent:SetSourceTexture")]
	public unsafe void SetSourceTexture(UTexture bNewValue)
	{
		CheckDestroyed();
		if (!SetSourceTexture_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.RectLightComponent:SetSourceTexture");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSourceTexture_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSourceTexture_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UTexture>.ToNative(IntPtr.Add(intPtr, SetSourceTexture_bNewValue_Offset), 0, SetSourceTexture_bNewValue_PropertyAddress.Address, bNewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSourceTexture_FunctionAddress, intPtr, SetSourceTexture_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.RectLightComponent:SetSourceHeight")]
	public unsafe void SetSourceHeight(float NewValue)
	{
		CheckDestroyed();
		if (!SetSourceHeight_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.RectLightComponent:SetSourceHeight");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSourceHeight_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSourceHeight_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetSourceHeight_NewValue_Offset), 0, SetSourceHeight_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSourceHeight_FunctionAddress, intPtr, SetSourceHeight_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.RectLightComponent:SetBarnDoorLength")]
	public unsafe void SetBarnDoorLength(float NewValue)
	{
		CheckDestroyed();
		if (!SetBarnDoorLength_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.RectLightComponent:SetBarnDoorLength");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBarnDoorLength_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBarnDoorLength_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetBarnDoorLength_NewValue_Offset), 0, SetBarnDoorLength_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetBarnDoorLength_FunctionAddress, intPtr, SetBarnDoorLength_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.RectLightComponent:SetBarnDoorAngle")]
	public unsafe void SetBarnDoorAngle(float NewValue)
	{
		CheckDestroyed();
		if (!SetBarnDoorAngle_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.RectLightComponent:SetBarnDoorAngle");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBarnDoorAngle_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBarnDoorAngle_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetBarnDoorAngle_NewValue_Offset), 0, SetBarnDoorAngle_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetBarnDoorAngle_FunctionAddress, intPtr, SetBarnDoorAngle_ParamsSize);
	}

	static URectLightComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(URectLightComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(URectLightComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.RectLightComponent");
		SourceWidth_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SourceWidth");
		SourceWidth_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SourceWidth", Classes.FFloatProperty);
		SourceHeight_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SourceHeight");
		SourceHeight_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SourceHeight", Classes.FFloatProperty);
		BarnDoorAngle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BarnDoorAngle");
		BarnDoorAngle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BarnDoorAngle", Classes.FFloatProperty);
		BarnDoorLength_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BarnDoorLength");
		BarnDoorLength_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BarnDoorLength", Classes.FFloatProperty);
		SourceTexture_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SourceTexture");
		SourceTexture_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SourceTexture", Classes.FObjectProperty);
		SetSourceWidth_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSourceWidth");
		SetSourceWidth_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSourceWidth_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSourceWidth_bNewValue_PropertyAddress, SetSourceWidth_FunctionAddress, "bNewValue");
		SetSourceWidth_bNewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetSourceWidth_FunctionAddress, "bNewValue");
		SetSourceWidth_bNewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSourceWidth_FunctionAddress, "bNewValue", Classes.FFloatProperty);
		SetSourceWidth_IsValid = SetSourceWidth_FunctionAddress != IntPtr.Zero && SetSourceWidth_bNewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.RectLightComponent:SetSourceWidth", SetSourceWidth_IsValid);
		SetSourceTexture_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSourceTexture");
		SetSourceTexture_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSourceTexture_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSourceTexture_bNewValue_PropertyAddress, SetSourceTexture_FunctionAddress, "bNewValue");
		SetSourceTexture_bNewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetSourceTexture_FunctionAddress, "bNewValue");
		SetSourceTexture_bNewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSourceTexture_FunctionAddress, "bNewValue", Classes.FObjectProperty);
		SetSourceTexture_IsValid = SetSourceTexture_FunctionAddress != IntPtr.Zero && SetSourceTexture_bNewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.RectLightComponent:SetSourceTexture", SetSourceTexture_IsValid);
		SetSourceHeight_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSourceHeight");
		SetSourceHeight_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSourceHeight_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSourceHeight_NewValue_PropertyAddress, SetSourceHeight_FunctionAddress, "NewValue");
		SetSourceHeight_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetSourceHeight_FunctionAddress, "NewValue");
		SetSourceHeight_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSourceHeight_FunctionAddress, "NewValue", Classes.FFloatProperty);
		SetSourceHeight_IsValid = SetSourceHeight_FunctionAddress != IntPtr.Zero && SetSourceHeight_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.RectLightComponent:SetSourceHeight", SetSourceHeight_IsValid);
		SetBarnDoorLength_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetBarnDoorLength");
		SetBarnDoorLength_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBarnDoorLength_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBarnDoorLength_NewValue_PropertyAddress, SetBarnDoorLength_FunctionAddress, "NewValue");
		SetBarnDoorLength_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetBarnDoorLength_FunctionAddress, "NewValue");
		SetBarnDoorLength_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBarnDoorLength_FunctionAddress, "NewValue", Classes.FFloatProperty);
		SetBarnDoorLength_IsValid = SetBarnDoorLength_FunctionAddress != IntPtr.Zero && SetBarnDoorLength_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.RectLightComponent:SetBarnDoorLength", SetBarnDoorLength_IsValid);
		SetBarnDoorAngle_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetBarnDoorAngle");
		SetBarnDoorAngle_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBarnDoorAngle_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBarnDoorAngle_NewValue_PropertyAddress, SetBarnDoorAngle_FunctionAddress, "NewValue");
		SetBarnDoorAngle_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetBarnDoorAngle_FunctionAddress, "NewValue");
		SetBarnDoorAngle_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBarnDoorAngle_FunctionAddress, "NewValue", Classes.FFloatProperty);
		SetBarnDoorAngle_IsValid = SetBarnDoorAngle_FunctionAddress != IntPtr.Zero && SetBarnDoorAngle_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.RectLightComponent:SetBarnDoorAngle", SetBarnDoorAngle_IsValid);
	}
}
