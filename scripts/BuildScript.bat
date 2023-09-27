set projectDir=%1
set configurationName=%2
set projectName=%3
set outputBin=%4

if not exist ..\%outputBin%\ mkdir ..\%outputBin%\
echo %projectDir%bin\%configurationName% > %projectDir%..\%outputBin%\_source_%projectName%.txt