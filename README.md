# SwaggerInMultipleAzureProjectsInProcess
To reproduce:
1. Rebuild solution
- folder InternalAPIFunctionsBin should be created if not exist
2. In PowerShell run copyAllFunctions.ps1 from the project repo level
- Azure Functions dll and others should be copied to InternalAPIFunctionsBin
3. Run server_start.cmd from the project repo level
4 go to [https://localhost:7002/api/swagger/ui](https://localhost:7002/api/swagger/ui)https://localhost:7002/api/swagger/ui

In my case, only one function is shown.
