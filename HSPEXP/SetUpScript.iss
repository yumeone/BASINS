; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "HSPEXP+"
#define MyAppVersion "1.40beta"
#define MyAppPublisher "RESPEC"
#define MyAppURL "http://www.aquaterra.com/resources/downloads/HSPEXPplus.php"
#define MyAppExeName "HSPEXP+.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{07C3304A-C9A6-4D30-81C0-004F939FB8C1}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={reg:HKLM\SOFTWARE\RESPEC\BASINS41,Base Directory|{pf}\HSPEXP+}
DefaultGroupName={#MyAppName}
OutputBaseFilename=HSPEXP+1.40betaSetUp
Compression=lzma
SolidCompression=yes
InfoBeforeFile=install.txt

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "C:\Dev\BASINS\BASINS\HSPEXP\bin\x86\Debug\HSPEXP+.exe"; DestDir: "{app}"; Permissions: everyone-modify; Flags: ignoreversion
Source: "C:\Dev\BASINS\BASINS\HSPEXP\bin\x86\Debug\WinHSPFLt\*"; DestDir: "{app}\WinHSPFLt"; Permissions: everyone-modify; Flags: ignoreversion
Source: "C:\Dev\BASINS\BASINS\HSPEXP\bin\x86\Debug\*.dll"; DestDir: "{app}"; Permissions: everyone-modify; Flags: ignoreversion
Source: "C:\Dev\BASINS\BASINS\HSPEXP\*.chm"; DestDir: "{app}"; Permissions: everyone-modify; Flags: ignoreversion
Source: "C:\Dev\BASINS\BASINS\HSPEXP\GraphColors.txt"; DestDir: "{app}"; Permissions: everyone-modify; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversiono" on any shared system files

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Dirs]
Name: {app}; Permissions: everyone-modify
Name: {app}\WinHSPFLt; Permissions: everyone-modify

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

