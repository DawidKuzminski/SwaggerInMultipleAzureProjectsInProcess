echo off
echo "Starting server."
cd .\InternalAPIFunctionsBin\net6.0
func host start -p 7002 --verbose --useHttps --cert "D:\WORK\localhost.pfx" --password "SuperPassword!1"