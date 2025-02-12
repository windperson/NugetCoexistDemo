#Requires -Version 7

if ($IsWindows){
    Remove-Item -r -Force $env:USERPROFILE\.nuget\packages\ClassLib*
}
else {
    Remove-Item -r -Force $HOME/.nuget/packages/ClassLib*
}