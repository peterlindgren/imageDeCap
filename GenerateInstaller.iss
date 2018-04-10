; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{9BE609C6-1558-49CC-AC59-11E5999DDD2E}
AppName=ImageDeCap
AppVersion=1.26
;AppVerName=ImageDeCap 1.26
AppPublisher=Mattias Westphal, www.mattwestphal.com
AppPublisherURL=http://mattwestphal.com/
AppSupportURL=http://mattwestphal.com/
AppUpdatesURL=http://mattwestphal.com/
DefaultDirName={pf}\ImageDeCap
DefaultGroupName=ImageDeCap
AllowNoIcons=yes
OutputBaseFilename=imageDeCap_v1_26 Installer
SetupIconFile={#SourcePath}\imageDeCap\Images\Untitled-2.ico
Compression=lzma
SolidCompression=yes
UninstallDisplayIcon={#SourcePath}\imageDeCap\Images\Untitled-2.ico

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked
Name: startup; Description: "Add ImageDeCap to startup."; GroupDescription: "{cm:AdditionalIcons}"


[Files]
Source: "{#SourcePath}\imageDeCap\bin\Debug\imageDeCap.exe"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{group}\ImageDeCap"; Filename: "{app}\imageDeCap.exe"
Name: "{group}\{cm:UninstallProgram,ImageDeCap}"; Filename: "{uninstallexe}"
Name: "{commondesktop}\ImageDeCap"; Filename: "{app}\imageDeCap.exe"; Tasks: desktopicon
Name: "{commonstartup}\ImageDeCap"; Filename: "{app}\imageDeCap.exe"; Tasks: startup

; Optionally delete settings
[Code]
 procedure CurUninstallStepChanged (CurUninstallStep: TUninstallStep);
 var
     mres : integer;
 begin
    case CurUninstallStep of                   
      usPostUninstall:
        begin
          mres := MsgBox('Do you want to Remove settings?', mbConfirmation, MB_YESNO or MB_DEFBUTTON2)
          if mres = IDYES then
            DelTree(ExpandConstant('{userappdata}\imageDeCap'), True, True, True);
       end;
   end;
end;

[Run]
Filename: "{app}\imageDeCap.exe"; Description: "{cm:LaunchProgram,ImageDeCap}"; Flags: nowait postinstall skipifsilent

