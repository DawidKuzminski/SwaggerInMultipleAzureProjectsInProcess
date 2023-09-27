# SwaggerInMultipleAzureProjectsInProcess
Requirements: 
- .NET 6
- azure-functions-core-tools@4

To reproduce:
1. Restore nuggets
2. Rebuild solution
- folder InternalAPIFunctionsBin should be created if not exist
3. In PowerShell run copyAllFunctions.ps1 from the project repo level (if error occured run: Set-ExecutionPolicy RemoteSigned or Set-ExecutionPolicy Unrestricted)
- Azure Functions dll and others should be copied to InternalAPIFunctionsBin
4. Run server_start.cmd from the project repo level
5. go to [https://localhost:7002/api/swagger/ui](https://localhost:7002/api/swagger/ui)

In my case, only one function is shown.
