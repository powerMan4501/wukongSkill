using System;
using b1.UI.Comm;
using UnrealEngine.Runtime;

namespace b1.GSMUI.GSWidget;

[UClass]
[USharpPath("/Script/b1-Managed.GSRoundRectCS")]
public class GSRoundRectCS : UGSRoundRect
{
	private bool IsInDebugDrawing;

	private FVector2D LastUpdateRefPos;

	private FVector2D LastUpdatePos;

	private FVector2D LastUpdateSize;

	private FVector2D LastUpdateCenterPos;

	private float Angle1;

	private float Angle2;

	private float Angle3;

	private float Angle4;

	private float Angle5;

	private float Angle6;

	private float Angle7;

	private float Angle8;

	private static bool RadiusCfg_IsValid;

	private static int RadiusCfg_Offset;

	private static bool DebugDrawWidget_IsValid;

	private static int DebugDrawWidget_Offset;

	private static bool DebugTick_IsValid;

	private static IntPtr DebugTick_FunctionAddress;

	private static int DebugTick_ParamsSize;

	private static bool GetDebugDraw_IsValid;

	private static IntPtr GetDebugDraw_FunctionAddress;

	private static int GetDebugDraw_ParamsSize;

	private static bool GetDebugDraw_ReturnValue_IsValid;

	private static int GetDebugDraw_ReturnValue_Offset;

	private static FFieldAddress GetDebugDraw_ReturnValue_PropertyAddress;

	private static bool SetDebugDraw_IsValid;

	private static IntPtr SetDebugDraw_FunctionAddress;

	private static int SetDebugDraw_ParamsSize;

	private static bool SetDebugDraw_IsDebugDraw_IsValid;

	private static int SetDebugDraw_IsDebugDraw_Offset;

	private static FFieldAddress SetDebugDraw_IsDebugDraw_PropertyAddress;

	private static bool IsInRoundRect_IsValid;

	private static IntPtr IsInRoundRect_FunctionAddress;

	private static int IsInRoundRect_ParamsSize;

	private static bool IsInRoundRect_PosInViewPort_IsValid;

	private static int IsInRoundRect_PosInViewPort_Offset;

	private static FFieldAddress IsInRoundRect_PosInViewPort_PropertyAddress;

	private static bool IsInRoundRect_ReturnValue_IsValid;

	private static int IsInRoundRect_ReturnValue_Offset;

	private static FFieldAddress IsInRoundRect_ReturnValue_PropertyAddress;

	private static bool GSOnConstruct_IsValid;

	private static IntPtr GSOnConstruct_FunctionAddress;

	private static int GSOnConstruct_ParamsSize;

	private static bool GSStartDebugDraw_IsValid;

	private static IntPtr GSStartDebugDraw_FunctionAddress;

	private static int GSStartDebugDraw_ParamsSize;

	private static bool GetLastUpdateCenterPos_IsValid;

	private static IntPtr GetLastUpdateCenterPos_FunctionAddress;

	private static int GetLastUpdateCenterPos_ParamsSize;

	private static bool GetLastUpdateCenterPos_ReturnValue_IsValid;

	private static int GetLastUpdateCenterPos_ReturnValue_Offset;

	private static FFieldAddress GetLastUpdateCenterPos_ReturnValue_PropertyAddress;

	private static bool CalcMappingRoundRectPoint_IsValid;

	private static IntPtr CalcMappingRoundRectPoint_FunctionAddress;

	private static int CalcMappingRoundRectPoint_ParamsSize;

	private static bool CalcMappingRoundRectPoint_PosInViewPort_IsValid;

	private static int CalcMappingRoundRectPoint_PosInViewPort_Offset;

	private static FFieldAddress CalcMappingRoundRectPoint_PosInViewPort_PropertyAddress;

	private static bool CalcMappingRoundRectPoint_IsInFront_IsValid;

	private static int CalcMappingRoundRectPoint_IsInFront_Offset;

	private static FFieldAddress CalcMappingRoundRectPoint_IsInFront_PropertyAddress;

	private static bool CalcMappingRoundRectPoint_InnerContentRectSize_IsValid;

	private static int CalcMappingRoundRectPoint_InnerContentRectSize_Offset;

	private static FFieldAddress CalcMappingRoundRectPoint_InnerContentRectSize_PropertyAddress;

	private static bool CalcMappingRoundRectPoint_InnerContentRectAlign_IsValid;

	private static int CalcMappingRoundRectPoint_InnerContentRectAlign_Offset;

	private static FFieldAddress CalcMappingRoundRectPoint_InnerContentRectAlign_PropertyAddress;

	private static bool CalcMappingRoundRectPoint_IsOuter_IsValid;

	private static int CalcMappingRoundRectPoint_IsOuter_Offset;

	private static FFieldAddress CalcMappingRoundRectPoint_IsOuter_PropertyAddress;

	private static bool CalcMappingRoundRectPoint_BorderPosRefRoundRect_IsValid;

	private static int CalcMappingRoundRectPoint_BorderPosRefRoundRect_Offset;

	private static FFieldAddress CalcMappingRoundRectPoint_BorderPosRefRoundRect_PropertyAddress;

	private static bool CalcMappingRoundRectPoint_RectAngle_IsValid;

	private static int CalcMappingRoundRectPoint_RectAngle_Offset;

	private static bool CalcMappingRoundRectPoint_OutIndicatorType_IsValid;

	private static int CalcMappingRoundRectPoint_OutIndicatorType_Offset;

	private static bool CalcMappingRoundRectPoint_ReturnValue_IsValid;

	private static int CalcMappingRoundRectPoint_ReturnValue_Offset;

	private static FFieldAddress CalcMappingRoundRectPoint_ReturnValue_PropertyAddress;

	[Tooltip("X是TopLeft, Y是TopRight, Z是BottomRight, W是BottomLeft, 顺时针")]
	[Category("GSRoundRectCfg")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.GSRoundRectCS:RadiusCfg")]
	public FVector4 RadiusCfg
	{
		get
		{
			CheckDestroyed();
			if (!RadiusCfg_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSRoundRectCS:RadiusCfg");
				return default(FVector4);
			}
			return BlittableTypeMarshaler<FVector4>.FromNative(IntPtr.Add(base.Address, RadiusCfg_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RadiusCfg_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSRoundRectCS:RadiusCfg");
			}
			else
			{
				BlittableTypeMarshaler<FVector4>.ToNative(IntPtr.Add(base.Address, RadiusCfg_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("GSRoundRectCfg")]
	[USharpPath("/Script/b1-Managed.GSRoundRectCS:DebugDrawWidget")]
	public BUI_DebugDrawRoundRect DebugDrawWidget
	{
		get
		{
			CheckDestroyed();
			if (!DebugDrawWidget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSRoundRectCS:DebugDrawWidget");
				return null;
			}
			return UObjectMarshaler<BUI_DebugDrawRoundRect>.FromNative(IntPtr.Add(base.Address, DebugDrawWidget_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DebugDrawWidget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSRoundRectCS:DebugDrawWidget");
			}
			else
			{
				UObjectMarshaler<BUI_DebugDrawRoundRect>.ToNative(IntPtr.Add(base.Address, DebugDrawWidget_Offset), value);
			}
		}
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.GSRoundRectCS:GetLastUpdateCenterPos")]
	public FVector2D GetLastUpdateCenterPos()
	{
		return LastUpdateCenterPos;
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		RadiusCfg.Set(100.0, 100.0, 100.0, 100.0);
		IsInDebugDrawing = false;
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.GSRoundRectCS:GSOnConstruct")]
	public virtual void GSOnConstruct()
	{
		UGSE_EngineFuncLib.LogInfo($"GSRoundRect GSOnConstruct IsInDebugDrawing{IsInDebugDrawing}");
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.GSRoundRectCS:GSStartDebugDraw")]
	public void GSStartDebugDraw()
	{
		IsInDebugDrawing = true;
		if (IsInDebugDrawing && DebugDrawWidget != null)
		{
			DebugDrawWidget.SetRadiusCfg(RadiusCfg);
		}
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.GSRoundRectCS:DebugTick")]
	public void DebugTick()
	{
		UGSE_EngineFuncLib.LogInfo($"GSRoundRect GSOnConstruct IsInDebugDrawing{IsInDebugDrawing} LastUpdateRefPos:{LastUpdateRefPos} LastUpdatePos:{LastUpdatePos} RectSize:{LastUpdateSize}");
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.GSRoundRectCS:GetDebugDraw")]
	public bool GetDebugDraw()
	{
		return IsInDebugDrawing;
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.GSRoundRectCS:SetDebugDraw")]
	public void SetDebugDraw(bool IsDebugDraw)
	{
		IsInDebugDrawing = IsDebugDraw;
	}

	private void UpdateRectRefData(FVector2D ContentRectSize, FVector2D ContentRectAlign, bool IsOuter)
	{
		UGSE_UMGFuncLib.GetWidgetPositionSizeRefViewPort(this, out LastUpdateRefPos, out LastUpdateSize);
		LastUpdateCenterPos = LastUpdateRefPos + LastUpdateSize / 2.0;
		if (IsInDebugDrawing)
		{
			DebugDrawWidget?.SetRefRectPosCenter(LastUpdateSize / 2.0);
		}
		FVector2D fVector2D = ContentRectSize * ContentRectAlign;
		if (!IsOuter)
		{
			LastUpdatePos = LastUpdateRefPos + fVector2D;
			LastUpdateSize -= ContentRectSize;
		}
		else
		{
			LastUpdatePos = LastUpdateRefPos - fVector2D;
			LastUpdateSize += ContentRectSize;
		}
		float z = RadiusCfg.Z;
		FVector2D inPoint = LastUpdatePos + LastUpdateSize;
		inPoint.Y -= z;
		FVector2D inPoint2 = LastUpdatePos + LastUpdateSize;
		inPoint2.X -= z;
		z = RadiusCfg.W;
		FVector2D lastUpdatePos = LastUpdatePos;
		lastUpdatePos.X += z;
		lastUpdatePos.Y += LastUpdateSize.Y;
		FVector2D lastUpdatePos2 = LastUpdatePos;
		lastUpdatePos2.Y = lastUpdatePos2.Y + LastUpdateSize.Y - z;
		z = RadiusCfg.X;
		FVector2D lastUpdatePos3 = LastUpdatePos;
		lastUpdatePos3.Y += z;
		FVector2D lastUpdatePos4 = LastUpdatePos;
		lastUpdatePos4.X += z;
		z = RadiusCfg.Y;
		FVector2D lastUpdatePos5 = LastUpdatePos;
		lastUpdatePos5.X = lastUpdatePos5.X + LastUpdateSize.X - z;
		FVector2D lastUpdatePos6 = LastUpdatePos;
		lastUpdatePos6.X += LastUpdateSize.X;
		lastUpdatePos6.Y += z;
		Angle1 = CalcAngle(inPoint);
		Angle2 = CalcAngle(inPoint2);
		Angle3 = CalcAngle(lastUpdatePos);
		Angle4 = CalcAngle(lastUpdatePos2);
		Angle5 = CalcAngle(lastUpdatePos3);
		Angle6 = CalcAngle(lastUpdatePos4);
		Angle7 = CalcAngle(lastUpdatePos5);
		Angle8 = CalcAngle(lastUpdatePos6);
	}

	private bool IsInCorner(FVector2D PosInViewPort, FVector2D RectTopLeft, float Radius)
	{
		if (PosInViewPort.X >= RectTopLeft.X && PosInViewPort.X <= RectTopLeft.X + Radius && PosInViewPort.Y >= RectTopLeft.Y && PosInViewPort.Y <= RectTopLeft.Y + Radius)
		{
			return true;
		}
		return false;
	}

	private bool IsInRoundCorner(FVector2D PosInViewPort, FVector2D RoundPos, float Radius)
	{
		if (FVector2D.DistSquared(PosInViewPort, RoundPos) > Radius * Radius)
		{
			return false;
		}
		return true;
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.GSRoundRectCS:IsInRoundRect")]
	public bool IsInRoundRect(FVector2D PosInViewPort)
	{
		if (PosInViewPort.X < LastUpdatePos.X || PosInViewPort.X > LastUpdatePos.X + LastUpdateSize.X)
		{
			return false;
		}
		if (PosInViewPort.Y < LastUpdatePos.Y || PosInViewPort.Y > LastUpdatePos.Y + LastUpdateSize.Y)
		{
			return false;
		}
		float x = RadiusCfg.X;
		FVector2D lastUpdatePos = LastUpdatePos;
		FVector2D roundPos = lastUpdatePos + x;
		if (IsInCorner(PosInViewPort, lastUpdatePos, x))
		{
			return IsInRoundCorner(PosInViewPort, roundPos, x);
		}
		x = RadiusCfg.Y;
		lastUpdatePos.X = LastUpdatePos.X + LastUpdateSize.X - x;
		lastUpdatePos.Y = LastUpdatePos.Y;
		roundPos.X = lastUpdatePos.X;
		roundPos.Y = lastUpdatePos.Y + x;
		if (IsInCorner(PosInViewPort, lastUpdatePos, x))
		{
			return IsInRoundCorner(PosInViewPort, roundPos, x);
		}
		x = RadiusCfg.Z;
		lastUpdatePos = LastUpdatePos + LastUpdateSize - x;
		roundPos = lastUpdatePos;
		if (IsInCorner(PosInViewPort, lastUpdatePos, x))
		{
			return IsInRoundCorner(PosInViewPort, roundPos, x);
		}
		x = RadiusCfg.W;
		lastUpdatePos.X = LastUpdatePos.X;
		lastUpdatePos.Y = LastUpdatePos.Y + LastUpdateSize.Y - x;
		roundPos.X = lastUpdatePos.X + x;
		roundPos.Y = lastUpdatePos.Y;
		if (IsInCorner(PosInViewPort, lastUpdatePos, x))
		{
			return IsInRoundCorner(PosInViewPort, roundPos, x);
		}
		return true;
	}

	private float CalcAngle(FVector2D InPoint)
	{
		FVector2D b = new FVector2D(1.0, 0.0);
		FVector2D safeNormal = (InPoint - LastUpdateCenterPos).GetSafeNormal();
		float num = FMath.Acos(FVector2D.DotProduct(safeNormal.GetSafeNormal(), b));
		if (safeNormal.Y < 0f)
		{
			return (float)Math.PI + ((float)Math.PI - num);
		}
		return num;
	}

	private void CalcCrossRoundPoint(float ySign, FVector2D PosInViewPort, float r, float xc, float yc, out float x, out float y)
	{
		float y2 = PosInViewPort.Y;
		float x2 = PosInViewPort.X;
		float y3 = LastUpdateCenterPos.Y;
		float x3 = LastUpdateCenterPos.X;
		float num = (x2 - x3) / (y2 - y3);
		float num2 = x2 - xc - num * y2;
		float num3 = 0f - (r * r - yc * yc - num2 * num2);
		float num4 = num * num + 1f;
		float num5 = 2f * num * num2 - 2f * yc;
		y = (0f - num5 + ySign * FMath.Sqrt(num5 * num5 - 4f * num4 * num3)) / (2f * num4);
		x = x2 - (y2 - y) * num;
	}

	private bool IsPosRectInRoundRect(FVector2D PosInViewPort, FVector2D InRectSize)
	{
		if (!IsInRoundRect(PosInViewPort))
		{
			return false;
		}
		FVector2D posInViewPort = PosInViewPort;
		posInViewPort.X -= InRectSize.X / 2f;
		posInViewPort.Y -= InRectSize.Y;
		if (!IsInRoundRect(posInViewPort))
		{
			return false;
		}
		posInViewPort = PosInViewPort;
		posInViewPort.X += InRectSize.X / 2f;
		posInViewPort.Y -= InRectSize.Y;
		if (!IsInRoundRect(posInViewPort))
		{
			return false;
		}
		posInViewPort = PosInViewPort;
		posInViewPort.X += InRectSize.X / 2f;
		if (!IsInRoundRect(posInViewPort))
		{
			return false;
		}
		posInViewPort = PosInViewPort;
		posInViewPort.X -= InRectSize.X / 2f;
		if (!IsInRoundRect(posInViewPort))
		{
			return false;
		}
		return true;
	}

	[USharpPath("/Script/b1-Managed.GSRoundRectCS:CalcMappingRoundRectPoint")]
	protected override bool CalcMappingRoundRectPoint_Implementation(FVector2D PosInViewPort, bool IsInFront, FVector2D InnerContentRectSize, FVector2D InnerContentRectAlign, bool IsOuter, out FVector2D BorderPosRefRoundRect, out float RectAngle, out int OutIndicatorType)
	{
		BorderPosRefRoundRect = default(FVector2D);
		OutIndicatorType = 4;
		UpdateRectRefData(InnerContentRectSize, InnerContentRectAlign, IsOuter);
		if (!IsInFront)
		{
			PosInViewPort.Y += LastUpdateSize.Y;
			if (PosInViewPort.Y < LastUpdatePos.Y + LastUpdateSize.Y)
			{
				PosInViewPort.Y = LastUpdatePos.Y + LastUpdateSize.Y + 100f;
			}
		}
		float num = (RectAngle = CalcAngle(PosInViewPort));
		if (IsInRoundRect(PosInViewPort))
		{
			BorderPosRefRoundRect = PosInViewPort - LastUpdateRefPos - InnerContentRectSize * InnerContentRectAlign;
			return false;
		}
		float y = PosInViewPort.Y;
		float x = PosInViewPort.X;
		float y2 = LastUpdateCenterPos.Y;
		float x2 = LastUpdateCenterPos.X;
		float x3 = 0f;
		float y3 = 0f;
		if (num >= Angle8 || num <= Angle1)
		{
			x3 = LastUpdatePos.X + LastUpdateSize.X;
			y3 = y - (x - x3) * (y - y2) / (x - x2);
			OutIndicatorType = 3;
		}
		else if (num >= Angle4 && num <= Angle5)
		{
			x3 = LastUpdatePos.X;
			y3 = y - (x - x3) * (y - y2) / (x - x2);
			OutIndicatorType = 2;
		}
		else if (num >= Angle2 && num <= Angle3)
		{
			y3 = LastUpdatePos.Y + LastUpdateSize.Y;
			x3 = x - (x - x2) * (y - y3) / (y - y2);
			OutIndicatorType = 1;
		}
		else if (num >= Angle6 && num <= Angle7)
		{
			y3 = LastUpdatePos.Y;
			x3 = x - (x - x2) * (y - y3) / (y - y2);
			OutIndicatorType = 0;
		}
		else if (num > Angle1 && num < Angle2)
		{
			float z = RadiusCfg.Z;
			float xc = LastUpdatePos.X + LastUpdateSize.X - z;
			float yc = LastUpdatePos.Y + LastUpdateSize.Y - z;
			CalcCrossRoundPoint(1f, PosInViewPort, z, xc, yc, out x3, out y3);
			OutIndicatorType = 3;
		}
		else if (num > Angle3 && num < Angle4)
		{
			float w = RadiusCfg.W;
			float xc2 = LastUpdatePos.X + w;
			float yc2 = LastUpdatePos.Y + LastUpdateSize.Y - w;
			CalcCrossRoundPoint(1f, PosInViewPort, w, xc2, yc2, out x3, out y3);
			OutIndicatorType = 2;
		}
		else if (num > Angle5 && num < Angle6)
		{
			float x4 = RadiusCfg.X;
			float xc3 = LastUpdatePos.X + x4;
			float yc3 = LastUpdatePos.Y + x4;
			CalcCrossRoundPoint(-1f, PosInViewPort, x4, xc3, yc3, out x3, out y3);
			OutIndicatorType = 2;
		}
		else if (num > Angle7 && num < Angle8)
		{
			float y4 = RadiusCfg.Y;
			float xc4 = LastUpdatePos.X + LastUpdateSize.X - y4;
			float yc4 = LastUpdatePos.Y + y4;
			CalcCrossRoundPoint(-1f, PosInViewPort, y4, xc4, yc4, out x3, out y3);
			OutIndicatorType = 3;
		}
		BorderPosRefRoundRect.X = x3;
		BorderPosRefRoundRect.Y = y3;
		BorderPosRefRoundRect = BorderPosRefRoundRect - LastUpdateRefPos - InnerContentRectSize * InnerContentRectAlign;
		return true;
	}

	[UFunctionInvoker("/Script/b1-Managed.GSRoundRectCS:DebugTick")]
	private static void DebugTick__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSRoundRectCS gSRoundRectCS = GCHelper.Find<GSRoundRectCS>(obj);
		gSRoundRectCS.DebugTick();
	}

	[UFunctionInvoker("/Script/b1-Managed.GSRoundRectCS:GetDebugDraw")]
	private static void GetDebugDraw__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSRoundRectCS gSRoundRectCS = GCHelper.Find<GSRoundRectCS>(obj);
		bool debugDraw = gSRoundRectCS.GetDebugDraw();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, GetDebugDraw_ReturnValue_Offset), 0, GetDebugDraw_ReturnValue_PropertyAddress.Address, debugDraw);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSRoundRectCS:SetDebugDraw")]
	private static void SetDebugDraw__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSRoundRectCS gSRoundRectCS = GCHelper.Find<GSRoundRectCS>(obj);
		bool debugDraw = BoolMarshaler.FromNative(IntPtr.Add(buffer, SetDebugDraw_IsDebugDraw_Offset), 0, SetDebugDraw_IsDebugDraw_PropertyAddress.Address);
		gSRoundRectCS.SetDebugDraw(debugDraw);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSRoundRectCS:IsInRoundRect")]
	private static void IsInRoundRect__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSRoundRectCS gSRoundRectCS = GCHelper.Find<GSRoundRectCS>(obj);
		FVector2D posInViewPort = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(buffer, IsInRoundRect_PosInViewPort_Offset));
		bool value = gSRoundRectCS.IsInRoundRect(posInViewPort);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, IsInRoundRect_ReturnValue_Offset), 0, IsInRoundRect_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSRoundRectCS:GSOnConstruct")]
	private static void GSOnConstruct__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSRoundRectCS gSRoundRectCS = GCHelper.Find<GSRoundRectCS>(obj);
		gSRoundRectCS.GSOnConstruct();
	}

	[UFunctionInvoker("/Script/b1-Managed.GSRoundRectCS:GSStartDebugDraw")]
	private static void GSStartDebugDraw__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSRoundRectCS gSRoundRectCS = GCHelper.Find<GSRoundRectCS>(obj);
		gSRoundRectCS.GSStartDebugDraw();
	}

	[UFunctionInvoker("/Script/b1-Managed.GSRoundRectCS:GetLastUpdateCenterPos")]
	private static void GetLastUpdateCenterPos__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSRoundRectCS gSRoundRectCS = GCHelper.Find<GSRoundRectCS>(obj);
		FVector2D lastUpdateCenterPos = gSRoundRectCS.GetLastUpdateCenterPos();
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(buffer, GetLastUpdateCenterPos_ReturnValue_Offset), lastUpdateCenterPos);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSRoundRectCS:CalcMappingRoundRectPoint")]
	private static void CalcMappingRoundRectPoint__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSRoundRectCS gSRoundRectCS = GCHelper.Find<GSRoundRectCS>(obj);
		FVector2D posInViewPort = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(buffer, CalcMappingRoundRectPoint_PosInViewPort_Offset));
		bool isInFront = BoolMarshaler.FromNative(IntPtr.Add(buffer, CalcMappingRoundRectPoint_IsInFront_Offset), 0, CalcMappingRoundRectPoint_IsInFront_PropertyAddress.Address);
		FVector2D innerContentRectSize = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(buffer, CalcMappingRoundRectPoint_InnerContentRectSize_Offset));
		FVector2D innerContentRectAlign = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(buffer, CalcMappingRoundRectPoint_InnerContentRectAlign_Offset));
		bool isOuter = BoolMarshaler.FromNative(IntPtr.Add(buffer, CalcMappingRoundRectPoint_IsOuter_Offset), 0, CalcMappingRoundRectPoint_IsOuter_PropertyAddress.Address);
		FVector2D BorderPosRefRoundRect;
		float RectAngle;
		int OutIndicatorType;
		bool value = gSRoundRectCS.CalcMappingRoundRectPoint_Implementation(posInViewPort, isInFront, innerContentRectSize, innerContentRectAlign, isOuter, out BorderPosRefRoundRect, out RectAngle, out OutIndicatorType);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, CalcMappingRoundRectPoint_ReturnValue_Offset), 0, CalcMappingRoundRectPoint_ReturnValue_PropertyAddress.Address, value);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(buffer, CalcMappingRoundRectPoint_BorderPosRefRoundRect_Offset), BorderPosRefRoundRect);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(buffer, CalcMappingRoundRectPoint_RectAngle_Offset), RectAngle);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(buffer, CalcMappingRoundRectPoint_OutIndicatorType_Offset), OutIndicatorType);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.GSRoundRectCS");
		RadiusCfg_Offset = NativeReflection.GetPropertyOffset(intPtr, "RadiusCfg");
		RadiusCfg_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RadiusCfg", Classes.FStructProperty);
		DebugDrawWidget_Offset = NativeReflection.GetPropertyOffset(intPtr, "DebugDrawWidget");
		DebugDrawWidget_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DebugDrawWidget", Classes.FObjectProperty);
		DebugTick_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "DebugTick");
		DebugTick_ParamsSize = NativeReflection.GetFunctionParamsSize(DebugTick_FunctionAddress);
		DebugTick_IsValid = DebugTick_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSRoundRectCS:DebugTick", DebugTick_IsValid);
		GetDebugDraw_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetDebugDraw");
		GetDebugDraw_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDebugDraw_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetDebugDraw_ReturnValue_PropertyAddress, GetDebugDraw_FunctionAddress, "ReturnValue");
		GetDebugDraw_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetDebugDraw_FunctionAddress, "ReturnValue");
		GetDebugDraw_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetDebugDraw_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetDebugDraw_IsValid = GetDebugDraw_FunctionAddress != IntPtr.Zero && GetDebugDraw_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSRoundRectCS:GetDebugDraw", GetDebugDraw_IsValid);
		SetDebugDraw_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetDebugDraw");
		SetDebugDraw_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDebugDraw_FunctionAddress);
		NativeReflection.GetPropertyRef(ref SetDebugDraw_IsDebugDraw_PropertyAddress, SetDebugDraw_FunctionAddress, "IsDebugDraw");
		SetDebugDraw_IsDebugDraw_Offset = NativeReflection.GetPropertyOffset(SetDebugDraw_FunctionAddress, "IsDebugDraw");
		SetDebugDraw_IsDebugDraw_IsValid = NativeReflection.ValidatePropertyClass(SetDebugDraw_FunctionAddress, "IsDebugDraw", Classes.FBoolProperty);
		SetDebugDraw_IsValid = SetDebugDraw_FunctionAddress != IntPtr.Zero && SetDebugDraw_IsDebugDraw_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSRoundRectCS:SetDebugDraw", SetDebugDraw_IsValid);
		IsInRoundRect_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsInRoundRect");
		IsInRoundRect_ParamsSize = NativeReflection.GetFunctionParamsSize(IsInRoundRect_FunctionAddress);
		NativeReflection.GetPropertyRef(ref IsInRoundRect_PosInViewPort_PropertyAddress, IsInRoundRect_FunctionAddress, "PosInViewPort");
		IsInRoundRect_PosInViewPort_Offset = NativeReflection.GetPropertyOffset(IsInRoundRect_FunctionAddress, "PosInViewPort");
		IsInRoundRect_PosInViewPort_IsValid = NativeReflection.ValidatePropertyClass(IsInRoundRect_FunctionAddress, "PosInViewPort", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref IsInRoundRect_ReturnValue_PropertyAddress, IsInRoundRect_FunctionAddress, "ReturnValue");
		IsInRoundRect_ReturnValue_Offset = NativeReflection.GetPropertyOffset(IsInRoundRect_FunctionAddress, "ReturnValue");
		IsInRoundRect_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(IsInRoundRect_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsInRoundRect_IsValid = IsInRoundRect_FunctionAddress != IntPtr.Zero && IsInRoundRect_PosInViewPort_IsValid && IsInRoundRect_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSRoundRectCS:IsInRoundRect", IsInRoundRect_IsValid);
		GSOnConstruct_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSOnConstruct");
		GSOnConstruct_ParamsSize = NativeReflection.GetFunctionParamsSize(GSOnConstruct_FunctionAddress);
		GSOnConstruct_IsValid = GSOnConstruct_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSRoundRectCS:GSOnConstruct", GSOnConstruct_IsValid);
		GSStartDebugDraw_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSStartDebugDraw");
		GSStartDebugDraw_ParamsSize = NativeReflection.GetFunctionParamsSize(GSStartDebugDraw_FunctionAddress);
		GSStartDebugDraw_IsValid = GSStartDebugDraw_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSRoundRectCS:GSStartDebugDraw", GSStartDebugDraw_IsValid);
		GetLastUpdateCenterPos_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetLastUpdateCenterPos");
		GetLastUpdateCenterPos_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLastUpdateCenterPos_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetLastUpdateCenterPos_ReturnValue_PropertyAddress, GetLastUpdateCenterPos_FunctionAddress, "ReturnValue");
		GetLastUpdateCenterPos_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetLastUpdateCenterPos_FunctionAddress, "ReturnValue");
		GetLastUpdateCenterPos_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetLastUpdateCenterPos_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetLastUpdateCenterPos_IsValid = GetLastUpdateCenterPos_FunctionAddress != IntPtr.Zero && GetLastUpdateCenterPos_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSRoundRectCS:GetLastUpdateCenterPos", GetLastUpdateCenterPos_IsValid);
		CalcMappingRoundRectPoint_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CalcMappingRoundRectPoint");
		CalcMappingRoundRectPoint_ParamsSize = NativeReflection.GetFunctionParamsSize(CalcMappingRoundRectPoint_FunctionAddress);
		NativeReflection.GetPropertyRef(ref CalcMappingRoundRectPoint_PosInViewPort_PropertyAddress, CalcMappingRoundRectPoint_FunctionAddress, "PosInViewPort");
		CalcMappingRoundRectPoint_PosInViewPort_Offset = NativeReflection.GetPropertyOffset(CalcMappingRoundRectPoint_FunctionAddress, "PosInViewPort");
		CalcMappingRoundRectPoint_PosInViewPort_IsValid = NativeReflection.ValidatePropertyClass(CalcMappingRoundRectPoint_FunctionAddress, "PosInViewPort", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref CalcMappingRoundRectPoint_IsInFront_PropertyAddress, CalcMappingRoundRectPoint_FunctionAddress, "IsInFront");
		CalcMappingRoundRectPoint_IsInFront_Offset = NativeReflection.GetPropertyOffset(CalcMappingRoundRectPoint_FunctionAddress, "IsInFront");
		CalcMappingRoundRectPoint_IsInFront_IsValid = NativeReflection.ValidatePropertyClass(CalcMappingRoundRectPoint_FunctionAddress, "IsInFront", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref CalcMappingRoundRectPoint_InnerContentRectSize_PropertyAddress, CalcMappingRoundRectPoint_FunctionAddress, "InnerContentRectSize");
		CalcMappingRoundRectPoint_InnerContentRectSize_Offset = NativeReflection.GetPropertyOffset(CalcMappingRoundRectPoint_FunctionAddress, "InnerContentRectSize");
		CalcMappingRoundRectPoint_InnerContentRectSize_IsValid = NativeReflection.ValidatePropertyClass(CalcMappingRoundRectPoint_FunctionAddress, "InnerContentRectSize", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref CalcMappingRoundRectPoint_InnerContentRectAlign_PropertyAddress, CalcMappingRoundRectPoint_FunctionAddress, "InnerContentRectAlign");
		CalcMappingRoundRectPoint_InnerContentRectAlign_Offset = NativeReflection.GetPropertyOffset(CalcMappingRoundRectPoint_FunctionAddress, "InnerContentRectAlign");
		CalcMappingRoundRectPoint_InnerContentRectAlign_IsValid = NativeReflection.ValidatePropertyClass(CalcMappingRoundRectPoint_FunctionAddress, "InnerContentRectAlign", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref CalcMappingRoundRectPoint_IsOuter_PropertyAddress, CalcMappingRoundRectPoint_FunctionAddress, "IsOuter");
		CalcMappingRoundRectPoint_IsOuter_Offset = NativeReflection.GetPropertyOffset(CalcMappingRoundRectPoint_FunctionAddress, "IsOuter");
		CalcMappingRoundRectPoint_IsOuter_IsValid = NativeReflection.ValidatePropertyClass(CalcMappingRoundRectPoint_FunctionAddress, "IsOuter", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref CalcMappingRoundRectPoint_BorderPosRefRoundRect_PropertyAddress, CalcMappingRoundRectPoint_FunctionAddress, "BorderPosRefRoundRect");
		CalcMappingRoundRectPoint_BorderPosRefRoundRect_Offset = NativeReflection.GetPropertyOffset(CalcMappingRoundRectPoint_FunctionAddress, "BorderPosRefRoundRect");
		CalcMappingRoundRectPoint_BorderPosRefRoundRect_IsValid = NativeReflection.ValidatePropertyClass(CalcMappingRoundRectPoint_FunctionAddress, "BorderPosRefRoundRect", Classes.FStructProperty);
		CalcMappingRoundRectPoint_RectAngle_Offset = NativeReflection.GetPropertyOffset(CalcMappingRoundRectPoint_FunctionAddress, "RectAngle");
		CalcMappingRoundRectPoint_RectAngle_IsValid = NativeReflection.ValidatePropertyClass(CalcMappingRoundRectPoint_FunctionAddress, "RectAngle", Classes.FFloatProperty);
		CalcMappingRoundRectPoint_OutIndicatorType_Offset = NativeReflection.GetPropertyOffset(CalcMappingRoundRectPoint_FunctionAddress, "OutIndicatorType");
		CalcMappingRoundRectPoint_OutIndicatorType_IsValid = NativeReflection.ValidatePropertyClass(CalcMappingRoundRectPoint_FunctionAddress, "OutIndicatorType", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref CalcMappingRoundRectPoint_ReturnValue_PropertyAddress, CalcMappingRoundRectPoint_FunctionAddress, "ReturnValue");
		CalcMappingRoundRectPoint_ReturnValue_Offset = NativeReflection.GetPropertyOffset(CalcMappingRoundRectPoint_FunctionAddress, "ReturnValue");
		CalcMappingRoundRectPoint_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(CalcMappingRoundRectPoint_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CalcMappingRoundRectPoint_IsValid = CalcMappingRoundRectPoint_FunctionAddress != IntPtr.Zero && CalcMappingRoundRectPoint_PosInViewPort_IsValid && CalcMappingRoundRectPoint_IsInFront_IsValid && CalcMappingRoundRectPoint_InnerContentRectSize_IsValid && CalcMappingRoundRectPoint_InnerContentRectAlign_IsValid && CalcMappingRoundRectPoint_IsOuter_IsValid && CalcMappingRoundRectPoint_BorderPosRefRoundRect_IsValid && CalcMappingRoundRectPoint_RectAngle_IsValid && CalcMappingRoundRectPoint_OutIndicatorType_IsValid && CalcMappingRoundRectPoint_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSRoundRectCS:CalcMappingRoundRectPoint", CalcMappingRoundRectPoint_IsValid);
	}

	static GSRoundRectCS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(GSRoundRectCS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(GSRoundRectCS));
	}
}
