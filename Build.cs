return BuildRunner.Execute(args, build =>
{
	build.Target("test")
	.Does(() => {
		var tool = DotNetClassicTool.TryCreateFrom("CentrallyManagedTool.csproj", "NUnit.ConsoleRunner", "nunit3-console.exe") ??
			throw new BuildException("Can't create DotNetClassicTool for NUnit.ConsoleRunner");
	});
});
