$pshost = Get-Host
$psWindow = $pshost.UI.RawUI
$newSize = $psWindow.WindowSize
$newSize.Height = 2
$newSize.Width = 9
$psWindow.WindowSize= $newSize
$Host.UI.RawUI.BackgroundColor = ($bckgrnd = 'Black')
$Host.UI.RawUI.ForegroundColor = 'Green'


while($true)
{
    $o = "{0:X}" -f [int][double]::Parse((Get-Date -UFormat %s))
    Write-Host $o #-ForegroundColor Green
    Start-Sleep -s 1
    clear
}