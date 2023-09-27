set-variable -Name outputDir -Value InternalAPIFunctionsBin

Get-ChildItem .\$outputDir\ -Filter _source_* | ForEach-Object {
$file = Get-Content $_.FullName; 
ROBOCOPY $file .\$outputDir\ /E
}