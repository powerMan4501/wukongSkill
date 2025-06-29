using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/AkAudio.AkLateReverbComponent", "AkAudio", UnrealModuleType.GamePlugin)]
public class UAkLateReverbComponent : USceneComponent
{
	private static bool Enable_IsValid;

	private static FFieldAddress Enable_PropertyAddress;

	private static int Enable_Offset;

	private static bool SendLevel_IsValid;

	private static int SendLevel_Offset;

	private static bool FadeRate_IsValid;

	private static int FadeRate_Offset;

	private static bool Priority_IsValid;

	private static int Priority_Offset;

	private static bool AutoAssignAuxBus_IsValid;

	private static FFieldAddress AutoAssignAuxBus_PropertyAddress;

	private static int AutoAssignAuxBus_Offset;

	private static bool AuxBus_IsValid;

	private static int AuxBus_Offset;

	private static bool AuxBusName_IsValid;

	private static int AuxBusName_Offset;

	private static bool AssociateAkTextureSetComponent_IsValid;

	private static IntPtr AssociateAkTextureSetComponent_FunctionAddress;

	private static int AssociateAkTextureSetComponent_ParamsSize;

	private static bool AssociateAkTextureSetComponent_textureSetComponent_IsValid;

	private static FFieldAddress AssociateAkTextureSetComponent_textureSetComponent_PropertyAddress;

	private static int AssociateAkTextureSetComponent_textureSetComponent_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AkAudio.AkLateReverbComponent:bEnable")]
	public bool Enable
	{
		get
		{
			CheckDestroyed();
			if (!Enable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkLateReverbComponent:bEnable");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Enable_Offset), 0, Enable_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Enable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkLateReverbComponent:bEnable");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Enable_Offset), 0, Enable_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AkAudio.AkLateReverbComponent:SendLevel")]
	public float SendLevel
	{
		get
		{
			CheckDestroyed();
			if (!SendLevel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkLateReverbComponent:SendLevel");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SendLevel_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SendLevel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkLateReverbComponent:SendLevel");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SendLevel_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AkAudio.AkLateReverbComponent:FadeRate")]
	public float FadeRate
	{
		get
		{
			CheckDestroyed();
			if (!FadeRate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkLateReverbComponent:FadeRate");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FadeRate_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FadeRate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkLateReverbComponent:FadeRate");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FadeRate_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AkAudio.AkLateReverbComponent:Priority")]
	public float Priority
	{
		get
		{
			CheckDestroyed();
			if (!Priority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkLateReverbComponent:Priority");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Priority_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Priority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkLateReverbComponent:Priority");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Priority_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AkAudio.AkLateReverbComponent:AutoAssignAuxBus")]
	public bool AutoAssignAuxBus
	{
		get
		{
			CheckDestroyed();
			if (!AutoAssignAuxBus_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkLateReverbComponent:AutoAssignAuxBus");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AutoAssignAuxBus_Offset), 0, AutoAssignAuxBus_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AutoAssignAuxBus_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkLateReverbComponent:AutoAssignAuxBus");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AutoAssignAuxBus_Offset), 0, AutoAssignAuxBus_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AkAudio.AkLateReverbComponent:AuxBus")]
	public UAkAuxBus AuxBus
	{
		get
		{
			CheckDestroyed();
			if (!AuxBus_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkLateReverbComponent:AuxBus");
				return null;
			}
			return UObjectMarshaler<UAkAuxBus>.FromNative(IntPtr.Add(base.Address, AuxBus_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AuxBus_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkLateReverbComponent:AuxBus");
			}
			else
			{
				UObjectMarshaler<UAkAuxBus>.ToNative(IntPtr.Add(base.Address, AuxBus_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759797487567365uL)]
	[UMetaPath("/Script/AkAudio.AkLateReverbComponent:AuxBusName")]
	public string AuxBusName
	{
		get
		{
			CheckDestroyed();
			if (!AuxBusName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkLateReverbComponent:AuxBusName");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, AuxBusName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AuxBusName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkLateReverbComponent:AuxBusName");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, AuxBusName_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/AkAudio.AkLateReverbComponent:AssociateAkTextureSetComponent")]
	public unsafe void AssociateAkTextureSetComponent(UAkAcousticTextureSetComponent textureSetComponent)
	{
		CheckDestroyed();
		if (!AssociateAkTextureSetComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkLateReverbComponent:AssociateAkTextureSetComponent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AssociateAkTextureSetComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AssociateAkTextureSetComponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAkAcousticTextureSetComponent>.ToNative(IntPtr.Add(intPtr, AssociateAkTextureSetComponent_textureSetComponent_Offset), 0, AssociateAkTextureSetComponent_textureSetComponent_PropertyAddress.Address, textureSetComponent);
		NativeReflection.InvokeFunctionOptimized(base.Address, AssociateAkTextureSetComponent_FunctionAddress, intPtr, AssociateAkTextureSetComponent_ParamsSize);
	}

	static UAkLateReverbComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAkLateReverbComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAkLateReverbComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/AkAudio.AkLateReverbComponent");
		NativeReflectionCached.GetPropertyRef(ref Enable_PropertyAddress, intPtr, "bEnable");
		Enable_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnable");
		Enable_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnable", Classes.FBoolProperty);
		SendLevel_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SendLevel");
		SendLevel_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SendLevel", Classes.FFloatProperty);
		FadeRate_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FadeRate");
		FadeRate_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FadeRate", Classes.FFloatProperty);
		Priority_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Priority");
		Priority_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Priority", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AutoAssignAuxBus_PropertyAddress, intPtr, "AutoAssignAuxBus");
		AutoAssignAuxBus_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AutoAssignAuxBus");
		AutoAssignAuxBus_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AutoAssignAuxBus", Classes.FBoolProperty);
		AuxBus_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AuxBus");
		AuxBus_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AuxBus", Classes.FObjectProperty);
		AuxBusName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AuxBusName");
		AuxBusName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AuxBusName", Classes.FStrProperty);
		AssociateAkTextureSetComponent_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AssociateAkTextureSetComponent");
		AssociateAkTextureSetComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(AssociateAkTextureSetComponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AssociateAkTextureSetComponent_textureSetComponent_PropertyAddress, AssociateAkTextureSetComponent_FunctionAddress, "textureSetComponent");
		AssociateAkTextureSetComponent_textureSetComponent_Offset = NativeReflectionCached.GetPropertyOffset(AssociateAkTextureSetComponent_FunctionAddress, "textureSetComponent");
		AssociateAkTextureSetComponent_textureSetComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(AssociateAkTextureSetComponent_FunctionAddress, "textureSetComponent", Classes.FObjectProperty);
		AssociateAkTextureSetComponent_IsValid = AssociateAkTextureSetComponent_FunctionAddress != IntPtr.Zero && AssociateAkTextureSetComponent_textureSetComponent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkLateReverbComponent:AssociateAkTextureSetComponent", AssociateAkTextureSetComponent_IsValid);
	}
}
