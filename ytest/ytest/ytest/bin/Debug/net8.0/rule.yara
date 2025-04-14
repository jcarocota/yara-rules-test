rule exe {
    meta:
        description = "Valida si el archivo es un ejecutable .exe"
    strings:
        $s1 = {4d 5A}
    condition:
        $s1 at 0
}
