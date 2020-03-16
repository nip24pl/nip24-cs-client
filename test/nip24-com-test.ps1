# Uruchomić: Wiersz poleceń (administrator) i wpisać:
# powershell -ExecutionPolicy ByPass -File nip24-com-test.ps1

write-output "----- BEGIN NIP24 TEST -----"

$nip24 = new-object -comObject 'NIP24.NIP24Client'
$nip24 | get-member

$nip24.URL = 'https://www.nip24.pl/api-test'
$nip24.Id = 'test_id'
$nip24.Key = 'test_key'

$nip = '7171642051'
$nip_eu = 'PL' + $nip
$account_number = '49154000046458439719826658'

write-output ""
write-output "   Test data:"
write-output ""
write-output "NIP:    $nip"
write-output "NIP EU: $nip_eu"
write-output "IBAN:   $account_number"
write-output ""

write-output "----- BEGIN VAT STATUS -----"

$vat = $nip24.GetVATStatus($nip)
$vat

write-output "----- BEGIN IBAN STATUS -----"

$iban = $nip24.GetIBANStatus($nip, $account_number)
$iban

write-output "----- BEGIN WHITELIST STATUS -----"

$whitelist = $nip24.GetWhitelistStatus($nip, $account_number)
$whitelist

write-output "----- BEGIN SEARCH VAT REGISTRY -----"

$search = $nip24.SearchVATRegistry($nip)
$search

write-output "----- EOF -----"
