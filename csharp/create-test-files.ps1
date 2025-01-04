$projects = Get-ChildItem -Directory | Where-Object { $_.Name -match '^\d{2}_'}

foreach ($project in $projects) {
    $testFileName = "Tests/$($project.Name)Tests.cs"
    if (-not (Test-Path $testFileName)) {
        $className = $project.Name -replace '^\d{2}_', '' -replace '_', ' '
        $template = @"
namespace Tests;

public class ${className}Tests
{
    [Fact]
    public void Test1()
    {
        // Arrange

        // Act

        // Assert
        Assert.True(true);
    }
}
"@
        Set-Content -Path $testFileName -Value $template
    }
}
