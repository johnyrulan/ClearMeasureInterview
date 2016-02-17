@echo off

call "C:\Program Files (x86)\Microsoft Visual Studio 12.0\VC\vcvarsall.bat" x64
mkdir build
pushd build
csc /target:library ..\src\ClearMeasureInterview.PrintNumLib\FizzBuzz.cs
popd