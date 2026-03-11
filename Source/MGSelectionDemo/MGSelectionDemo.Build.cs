// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class MGSelectionDemo : ModuleRules
{
	public MGSelectionDemo(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"NavigationSystem",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"Niagara",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"MGSelectionDemo",
			"MGSelectionDemo/Variant_Strategy",
			"MGSelectionDemo/Variant_Strategy/UI",
			"MGSelectionDemo/Variant_TwinStick",
			"MGSelectionDemo/Variant_TwinStick/AI",
			"MGSelectionDemo/Variant_TwinStick/Gameplay",
			"MGSelectionDemo/Variant_TwinStick/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
