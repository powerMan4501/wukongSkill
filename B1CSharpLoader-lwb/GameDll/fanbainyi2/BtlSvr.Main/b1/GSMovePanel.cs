using System;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.GSMovePanel")]
public class GSMovePanel : UCanvasPanel
{
	private static bool Direction_IsValid;

	private static int Direction_Offset;

	private static bool Amplitude_IsValid;

	private static int Amplitude_Offset;

	private static bool Speed_IsValid;

	private static int Speed_Offset;

	private static bool Offset_IsValid;

	private static int Offset_Offset;

	private static bool Scale_IsValid;

	private static int Scale_Offset;

	private static bool SetSpeed_IsValid;

	private static IntPtr SetSpeed_FunctionAddress;

	private static int SetSpeed_ParamsSize;

	private static bool SetSpeed_Speed_IsValid;

	private static int SetSpeed_Speed_Offset;

	private static bool SetScale_IsValid;

	private static IntPtr SetScale_FunctionAddress;

	private static int SetScale_ParamsSize;

	private static bool SetScale_Scale_IsValid;

	private static int SetScale_Scale_Offset;

	private static bool SetOffset_IsValid;

	private static IntPtr SetOffset_FunctionAddress;

	private static int SetOffset_ParamsSize;

	private static bool SetOffset_Offset_IsValid;

	private static int SetOffset_Offset_Offset;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.GSMovePanel:Direction")]
	public FVector2D Direction
	{
		get
		{
			CheckDestroyed();
			if (!Direction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSMovePanel:Direction");
				return default(FVector2D);
			}
			return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(base.Address, Direction_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Direction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSMovePanel:Direction");
			}
			else
			{
				BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(base.Address, Direction_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.GSMovePanel:Amplitude")]
	public float Amplitude
	{
		get
		{
			CheckDestroyed();
			if (!Amplitude_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSMovePanel:Amplitude");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Amplitude_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Amplitude_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSMovePanel:Amplitude");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Amplitude_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.GSMovePanel:Speed")]
	public float Speed
	{
		get
		{
			CheckDestroyed();
			if (!Speed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSMovePanel:Speed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Speed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Speed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSMovePanel:Speed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Speed_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.GSMovePanel:Offset")]
	public float Offset
	{
		get
		{
			CheckDestroyed();
			if (!Offset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSMovePanel:Offset");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Offset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Offset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSMovePanel:Offset");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Offset_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.GSMovePanel:Scale")]
	public float Scale
	{
		get
		{
			CheckDestroyed();
			if (!Scale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSMovePanel:Scale");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Scale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Scale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSMovePanel:Scale");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Scale_Offset), value);
			}
		}
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.GSMovePanel:SetSpeed")]
	public void SetSpeed(float Speed)
	{
		SetRenderTranslation(base.RenderTransform.Translation + Amplitude * Speed * Direction);
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.GSMovePanel:SetOffset")]
	public void SetOffset(float Offset)
	{
		(base.Slot as UCanvasPanelSlot).SetPosition(Offset * Direction);
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.GSMovePanel:SetScale")]
	public void SetScale(float Scale)
	{
		SetRenderScale(new FVector2D(Scale, Scale) * Amplitude);
	}

	public void Reset()
	{
		Direction = FVector2D.ZeroVector;
		Amplitude = 1f;
		SetScale(1f);
		SetRenderTranslation(FVector2D.ZeroVector);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSMovePanel:SetSpeed")]
	private static void SetSpeed__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSMovePanel gSMovePanel = GCHelper.Find<GSMovePanel>(obj);
		float speed = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, SetSpeed_Speed_Offset));
		gSMovePanel.SetSpeed(speed);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSMovePanel:SetScale")]
	private static void SetScale__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSMovePanel gSMovePanel = GCHelper.Find<GSMovePanel>(obj);
		float scale = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, SetScale_Scale_Offset));
		gSMovePanel.SetScale(scale);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSMovePanel:SetOffset")]
	private static void SetOffset__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSMovePanel gSMovePanel = GCHelper.Find<GSMovePanel>(obj);
		float offset = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, SetOffset_Offset_Offset));
		gSMovePanel.SetOffset(offset);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.GSMovePanel");
		Direction_Offset = NativeReflection.GetPropertyOffset(intPtr, "Direction");
		Direction_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Direction", Classes.FStructProperty);
		Amplitude_Offset = NativeReflection.GetPropertyOffset(intPtr, "Amplitude");
		Amplitude_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Amplitude", Classes.FFloatProperty);
		Speed_Offset = NativeReflection.GetPropertyOffset(intPtr, "Speed");
		Speed_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Speed", Classes.FFloatProperty);
		Offset_Offset = NativeReflection.GetPropertyOffset(intPtr, "Offset");
		Offset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Offset", Classes.FFloatProperty);
		Scale_Offset = NativeReflection.GetPropertyOffset(intPtr, "Scale");
		Scale_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Scale", Classes.FFloatProperty);
		SetSpeed_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSpeed");
		SetSpeed_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSpeed_FunctionAddress);
		SetSpeed_Speed_Offset = NativeReflection.GetPropertyOffset(SetSpeed_FunctionAddress, "Speed");
		SetSpeed_Speed_IsValid = NativeReflection.ValidatePropertyClass(SetSpeed_FunctionAddress, "Speed", Classes.FFloatProperty);
		SetSpeed_IsValid = SetSpeed_FunctionAddress != IntPtr.Zero && SetSpeed_Speed_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSMovePanel:SetSpeed", SetSpeed_IsValid);
		SetScale_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetScale");
		SetScale_ParamsSize = NativeReflection.GetFunctionParamsSize(SetScale_FunctionAddress);
		SetScale_Scale_Offset = NativeReflection.GetPropertyOffset(SetScale_FunctionAddress, "Scale");
		SetScale_Scale_IsValid = NativeReflection.ValidatePropertyClass(SetScale_FunctionAddress, "Scale", Classes.FFloatProperty);
		SetScale_IsValid = SetScale_FunctionAddress != IntPtr.Zero && SetScale_Scale_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSMovePanel:SetScale", SetScale_IsValid);
		SetOffset_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetOffset");
		SetOffset_ParamsSize = NativeReflection.GetFunctionParamsSize(SetOffset_FunctionAddress);
		SetOffset_Offset_Offset = NativeReflection.GetPropertyOffset(SetOffset_FunctionAddress, "Offset");
		SetOffset_Offset_IsValid = NativeReflection.ValidatePropertyClass(SetOffset_FunctionAddress, "Offset", Classes.FFloatProperty);
		SetOffset_IsValid = SetOffset_FunctionAddress != IntPtr.Zero && SetOffset_Offset_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSMovePanel:SetOffset", SetOffset_IsValid);
	}

	static GSMovePanel()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(GSMovePanel)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(GSMovePanel));
	}
}
