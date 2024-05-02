// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class unreal_srs_demoTarget : TargetRules
{
	public unreal_srs_demoTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		ExtraModuleNames.Add("unreal_srs_demo");
	}
}
