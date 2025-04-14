rule jpg1 {
    meta:
        description = "Valida si el archivo es una imagen .jpg"
    strings:
        $s1 = {FF D8}
    condition:
        $s1 at 0
}
