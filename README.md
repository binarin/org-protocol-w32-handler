# org-protocol-w32-handler

org-protocol URL fixer-upper for Windows users

## Building

    dotnet publish
    cp bin\Release\net9.0\win-x64\publish\org-protocol-w32-handler.exe c:\emacs\bin\

## Using

Run in administrator powershell:

```powershell
Push-Location
Set-Location Registry::HKEY_CLASSES_ROOT
New-Item -Path .\org-protocol\
New-ItemProperty -Path .\org-protocol -Name 'URL Protocol' -Value ''
New-Item -Path .\org-protocol\shell\
New-Item -Path .\org-protocol\shell\open
New-Item -Path .\org-protocol\shell\open\command -Value 'c:\emacs\bin\org-protocol-w32-handler.exe "%1"'
```
