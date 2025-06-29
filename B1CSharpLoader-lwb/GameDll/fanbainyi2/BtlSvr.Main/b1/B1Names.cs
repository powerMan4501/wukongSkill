using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

public static class B1Names
{
	public static readonly FName BottomHeightmap = new FName("BottomHeightmap");

	public static readonly FName Bounding = new FName("Bounding");

	public static readonly FName BoundingInfo = new FName("BoundingInfo");

	public static readonly FName ChrMatHitTime = new FName("ChrMatHitTime");

	public static readonly FName ChrMatHitShakeTime = new FName("ChrMatHitShakeTime");

	public static readonly FName ClampGSArtFresnelDotProduct = new FName("ClampGSArtFresnelDotProduct");

	public static readonly FName Color = new FName("Color");

	public static readonly FName Color_Dampening = new FName("Color Dampening");

	public static readonly FName Color_Erosion = new FName("Color Erosion");

	public static readonly FName Constant_Curl = new FName("Constant Curl");

	public static readonly FName Constant_Curl_Tiling = new FName("Constant Curl Tiling");

	public static readonly FName Curl_1_Strength = new FName("Curl 1 Strength");

	public static readonly FName Curl_1_Tiling = new FName("Curl 1 Tiling");

	public static readonly FName Curl_2_Strength = new FName("Curl 2 Strength");

	public static readonly FName Curl_2_Tiling = new FName("Curl 2 Tiling");

	public static readonly FName Density_Mask = new FName("Density Mask");

	public static readonly FName Density_Multiplier = new FName("Density Multiplier");

	public static readonly FName Divergence = new FName("Divergence");

	public static readonly FName Emission_Strength = new FName("Emission Strength");

	public static readonly FName Emission_Temperature = new FName("Emission Temperature");

	public static readonly FName FogHeightmapBounding = new FName("FogHeightmapBounding");

	public static readonly FName Force = new FName("Force");

	public static readonly FName FrameResolution = new FName("FrameResolution");

	public static readonly FName GSArtFresnelBright = new FName("GSArtFresnelBright");

	public static readonly FName GSArtFresnelDark = new FName("GSArtFresnelDark");

	public static readonly FName GSArtFresnelPower = new FName("GSArtFresnelPower");

	public static readonly FName GSUAFBottomAlpha = new FName("GSUAFBottomAlpha");

	public static readonly FName GSUAFTopAlpha = new FName("GSUAFTopAlpha");

	public static readonly FName GSUnitHeight = new FName("GSUnitHeight");

	public static readonly FName GSArtFresnelColor_Out = new FName("GSArtFresnelColor_Out");

	public static readonly FName GSArtFresnelColor_In = new FName("GSArtFresnelColor_In");

	public static readonly FName Hardness = new FName("Hardness");

	public static readonly FName Heat_Inset = new FName("Heat Inset");

	public static readonly FName InvertGSArtFresnel = new FName("InvertGSArtFresnel");

	public static readonly FName IsVelocity = new FName("IsVelocity");

	public static readonly FName boolVelocity = new FName("boolVelocity");

	public static readonly FName Mask = new FName("Mask");

	public static readonly FName Mesh_Previewer = new FName("Mesh_Previewer");

	public static readonly FName Noise_Strength = new FName("Noise Strength");

	public static readonly FName None = new FName("None");

	public static readonly FName Offset = new FName("Offset");

	public static readonly FName P = new FName("P");

	public static readonly FName P2 = new FName("P2");

	public static readonly FName Params = new FName("Params");

	public static readonly FName Pressure = new FName("Pressure");

	public static readonly FName PressurePreview = new FName("PressurePreview");

	public static readonly FName Resolution = new FName("Resolution");

	public static readonly FName R = new FName("R");

	public static readonly FName Radial_Force = new FName("Radial Force");

	public static readonly FName RT = new FName("RT");

	public static readonly FName RT2 = new FName("RT2");

	public static readonly FName RT_Velocity = new FName("RT_Velocity");

	public static readonly FName Temp = new FName("Temp");

	public static readonly FName Temp_Buoyancy = new FName("Temp Buoyancy");

	public static readonly FName Temperature_Dampening = new FName("Temperature Dampening");

	public static readonly FName Temperature_Multiplier = new FName("Temperature Multiplier");

	public static readonly FName TimeStep = new FName("TimeStep");

	public static readonly FName TopHeightmap = new FName("TopHeightmap");

	public static readonly FName Source = new FName("Source");

	public static readonly FName UAFUseVertexNormalNotTex = new FName("UAFUseVertexNormalNotTex");

	public static readonly FName UseGSArtFresnel = new FName("UseGSArtFresnel");

	public static readonly FName UseGSArtFresnelContrast = new FName("UseGSArtFresnelContrast");

	public static readonly FName UseUAFHeightGradientRamp = new FName("UseUAFHeightGradientRamp");

	public static readonly FName V = new FName("V");

	public static readonly FName Velocity = new FName("Velocity");

	public static readonly FName XYFrames = new FName("XYFrames");

	public static readonly FName InteractVelocityMultipier = new FName("VelocityMultipier");

	public static readonly FName GSMaskMatPercent = new FName("Percent");

	public static readonly FName GSMaskMatPercentStart = new FName("Start");

	public static readonly FName GSMaskMatPercentEnd = new FName("End");

	public static readonly FName ShieldBarWidgetName = new FName("ShieldBar");

	public static readonly FName MPBarWidgetName = new FName("MPBar");

	public static readonly FName HPBarWidgetName = new FName("HPBar");

	public static readonly FName GSOPMaskRect = new FName("GSOPMaskRect");

	public static readonly FName GSMatParamNameMainTex = new FName("MainTex");

	public static readonly FName GSMatParamNamePercent = new FName("Percent");

	public static readonly FName GSMatParamNameTier = new FName("Tier");

	public static readonly FName GSMatParamNameIsPlural = new FName("isPlural");

	public static readonly FName GSMatParamNameUseSoftMask = new FName("useSoftMask");

	public static readonly Dictionary<int, FName> GSMatParamNameMainTexDict = new Dictionary<int, FName>
	{
		{
			1,
			new FName("MainTex_1")
		},
		{
			2,
			new FName("MainTex_2")
		},
		{
			3,
			new FName("MainTex_3")
		},
		{
			4,
			new FName("MainTex_4")
		}
	};
}
