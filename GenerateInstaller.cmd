mkdir Output
COPY /y imageDeCap\bin\Release\imageDeCap.exe Output\imageDeCap_v1_27 Portable.exe
tools\ISCC.exe GenerateInstaller.iss
