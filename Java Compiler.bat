@echo off
@title JavaCompiler
color 0a
echo Welkom bij COMPILER 2.0
echo Deze tool compileert alle java bestanden,
echo Als deze in de zelfe map zitten.

:choice
set /P c=Weet je zeker dat je door wilt gaan[Y/N]?
if /I "%c%" EQU "Y" goto :sure
if /I "%c%" EQU "N" goto :nope
goto :choice


:sure

echo Prima
echo Op zoek naar .java bestanden...
"C:\Program Files\Java\jdk1.8.0_144\bin\javac.exe" *.java
echo Klaar!
goto :finish

:nope

echo Jammer
goto :finish

:finish
echo Tot de volgende keer!
pause
exit