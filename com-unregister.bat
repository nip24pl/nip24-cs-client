@echo off

setlocal

set output=%~dp0\nip24Library\bin\Release\com

"%systemroot%\Microsoft.NET\Framework\v4.0.30319\RegAsm.exe" /unregister /nologo "%output%\nip24Library.dll"
"%systemroot%\Microsoft.NET\Framework64\v4.0.30319\RegAsm.exe" /unregister /nologo "%output%\nip24Library.dll"

endlocal