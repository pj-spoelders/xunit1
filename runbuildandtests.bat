@echo off
::resets color
color

echo START
echo ------------------------------

::build 
echo START BUILD
echo ------------------------------

dotnet build
::echo %ERRORLEVEL%

SET msg= Build returned %ERRORLEVEL% (0 means succesful)
echo %msg%

if %errorlevel% EQU 0 (
::write echo and echo newline
echo OK & echo. 
) Else ( 
Echo ERROR FAILED &color CF 
exit /b 1
)

::tests
echo START TESTS
echo ------------------------------

dotnet test
::echo %ERRORLEVEL%

SET msg= Tests returned %ERRORLEVEL% (0 means succesful)
echo %msg%

if %errorlevel% EQU 0 (echo OK & echo . ) Else ( 
Echo ERROR FAILED & color CF 
echo. 
exit /b 1
)



::unused snippets here:
:: if %errorlevel% EQU 0 (echo OK ) Else ( Echo ERROR FAILED &color CF )
::exit /b [exitCode]