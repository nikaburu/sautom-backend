@echo off

rem Find solution file name
set folder=%cd%
where /R %folder%\.. *.sln > tmpFile
set /p solution= < tmpFile 
del tmpFile 

for %%a in (%solution%) do (
    set file=%%~fa
    set filepath=%%~dpa
    set filename=%%~nxa
)    
set solution=%filename:.sln=%
echo Solution found: %solution%.sln

rem Calculate project name
set /p input="Enter project name: "
echo %input% | findstr /C:"%solution%">nul && (
    echo Project name contains solution name.
    set project=%input%    
) || ( 
    echo Project name does not contain solution name.
    set project=%solution%.%input%
)
echo Full project name is %project%

rem Select project type
@echo on
dotnet new --list
@echo off
set /p project_type="Enter project type: "

rem Create project in solution
dotnet new %project_type% -n %project% -o ..\source\%project%\
dotnet sln ..\%solution%.sln add ..\source\%project%\%project%.csproj