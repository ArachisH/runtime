// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

#nullable enable

namespace Wasm.Build.Tests;

public record AssertTestMainJsAppBundleOptions(
    string Config,
    bool IsPublish,
    string TargetFramework,
    string BinFrameworkDir,
    string? CustomIcuFile,
    string ProjectName,
    string MainJS,
    GlobalizationMode GlobalizationMode = GlobalizationMode.Sharded,
    string BootJsonFileName = "blazor.boot.json",
    NativeFilesType ExpectedFileType = NativeFilesType.FromRuntimePack,
    RuntimeVariant RuntimeType = RuntimeVariant.SingleThreaded,
    bool ExpectFingerprintOnDotnetJs = false,
    bool ExpectSymbolsFile = true,
    bool AssertIcuAssets = true,
    bool AssertSymbolsFile = true,
    bool HasV8Script = false,
    bool IsBrowserProject = true)
        : AssertWasmSdkBundleOptions(
               Config: Config,
               IsPublish: IsPublish,
               TargetFramework: TargetFramework,
               BinFrameworkDir: BinFrameworkDir,
               CustomIcuFile: CustomIcuFile,
               GlobalizationMode: GlobalizationMode,
               ExpectedFileType: ExpectedFileType,
               RuntimeType: RuntimeType,
               BootConfigFileName: BootJsonFileName,
               ExpectFingerprintOnDotnetJs: ExpectFingerprintOnDotnetJs,
               ExpectSymbolsFile: ExpectSymbolsFile,
               AssertIcuAssets: AssertIcuAssets,
               AssertSymbolsFile: AssertSymbolsFile)
{
}
